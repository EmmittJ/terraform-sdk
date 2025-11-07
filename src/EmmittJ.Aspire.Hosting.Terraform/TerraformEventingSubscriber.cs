// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Infrastructure subscriber that processes Terraform stack annotations on compute resources.
/// </summary>
internal sealed class TerraformEventingSubscriber(
    ILogger<TerraformEventingSubscriber> logger,
    DistributedApplicationExecutionContext executionContext,
#pragma warning disable ASPIREPIPELINES001 // Type is for evaluation purposes only and is subject to change or removal in future updates
    IOptions<PipelineOptions>? pipelineOptions = null) : IDistributedApplicationEventingSubscriber
#pragma warning restore ASPIREPIPELINES001
{
    private async Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
    {
        if (executionContext.IsRunMode)
        {
            return;
        }

        var computeResources = @event.Model.GetComputeResources()
            .Where(r => r.TryGetAnnotationsOfType<TerraformStackAnnotation>(out _))
            .ToList();

        if (computeResources.Count == 0)
        {
            return;
        }

        logger.LogInformation("Found {Count} compute resource(s) with Terraform configuration", computeResources.Count);

        foreach (var resource in computeResources)
        {
            await GenerateTerraformForResourceAsync(resource, cancellationToken);
        }
    }

    private async Task GenerateTerraformForResourceAsync(IResource resource, CancellationToken cancellationToken)
    {
        if (!resource.TryGetAnnotationsOfType<TerraformStackAnnotation>(out var annotations))
        {
            return;
        }

        logger.LogInformation("Generating Terraform for resource: {ResourceName}", resource.Name);

        foreach (var annotation in annotations)
        {
            // Use annotation name if provided, otherwise default to "main" (Terraform convention)
            var stackName = annotation.Name ?? "main";

            // Create and configure the stack
            var stack = new TerraformStack(stackName);
            annotation.Configure(stack);

            // Validate the stack
            var validationResult = stack.Validate();
            if (!validationResult.IsValid)
            {
                var errors = string.Join(Environment.NewLine, validationResult.Errors.Select(e => $"  • {e.Message}"));
                logger.LogError("❌ Terraform validation failed for {StackName}:{NewLine}{Errors}",
                    stackName, Environment.NewLine, errors);
                throw new InvalidOperationException(
                    $"Terraform stack validation failed for '{stackName}' with {validationResult.Errors.Count} error(s).");
            }

            logger.LogInformation("✅ Terraform validation passed for {StackName}", stackName);

            // Generate HCL
            var hclContent = stack.ToHcl();

            // Determine output path
            var workingDirectory = GetWorkingDirectory(resource);
            Directory.CreateDirectory(workingDirectory);

            // Write file
            var terraformFileName = $"{stackName}.tf";
            var terraformFilePath = Path.Combine(workingDirectory, terraformFileName);
            await File.WriteAllTextAsync(terraformFilePath, hclContent, cancellationToken);

            var fullyQualifiedPath = Path.GetFullPath(terraformFilePath);
            logger.LogInformation("✅ Generated Terraform file: {FilePath}", fullyQualifiedPath);
        }
    }

    private string GetWorkingDirectory(IResource resource)
    {
        // Get the base output path from pipeline options (CLI --output-path) or default
        var baseOutputPath = pipelineOptions?.Value.OutputPath ?? Directory.GetCurrentDirectory();

        // Check if resource has custom output path configuration
        var customPath = resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault()
            ?.OutputPath;

        if (customPath is not null)
        {
            return Path.IsPathRooted(customPath)
                ? customPath
                : Path.Combine(baseOutputPath, customPath);
        }

        // Default: use resource name as subdirectory
        return Path.Combine(baseOutputPath, resource.Name);
    }

    public Task SubscribeAsync(
        IDistributedApplicationEventing eventing,
        DistributedApplicationExecutionContext executionContext,
        CancellationToken cancellationToken)
    {
        eventing.Subscribe<BeforeStartEvent>(OnBeforeStartAsync);
        return Task.CompletedTask;
    }
}
