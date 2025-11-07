// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Creates pipeline steps for generating Terraform configuration files.
/// </summary>
#pragma warning disable ASPIREPIPELINES001 // Type is for evaluation purposes only and is subject to change or removal in future updates
[Experimental("ASPIREPIPELINES001", UrlFormat = "https://aka.ms/aspire/diagnostics/{0}")]
internal static class TerraformPipelineStepFactory
#pragma warning restore ASPIREPIPELINES001
{
    /// <summary>
    /// Creates pipeline steps that generate Terraform configuration for a resource with Terraform annotations.
    /// Returns multiple steps if the resource has multiple TerraformStackAnnotation annotations.
    /// </summary>
    public static IEnumerable<PipelineStep> CreateTerraformGenerationSteps(PipelineStepFactoryContext factoryContext)
    {
        var resource = factoryContext.Resource;

        if (!resource.TryGetAnnotationsOfType<TerraformStackAnnotation>(out var annotations))
        {
            yield break;
        }

        var annotationIndex = 0;
        foreach (var annotation in annotations)
        {
            var stepIndex = annotationIndex++;
            yield return new PipelineStep
            {
                Name = stepIndex == 0
                    ? $"terraform-generate-{resource.Name}"
                    : $"terraform-generate-{resource.Name}-{stepIndex}",
                Action = async stepContext =>
                {
                    var logger = stepContext.Logger;
                    var pipelineOptions = stepContext.Services.GetService(typeof(IOptions<PipelineOptions>)) as IOptions<PipelineOptions>;

                    logger.LogInformation("Generating Terraform for resource: {ResourceName}", resource.Name);

                    await GenerateTerraformAsync(
                        resource,
                        annotation,
                        logger,
                        pipelineOptions,
                        stepContext.CancellationToken);
                },
                Tags = [WellKnownPipelineTags.ProvisionInfrastructure],
                RequiredBySteps = [WellKnownPipelineSteps.Publish],
                Resource = resource
            };
        }
    }

    private static async Task GenerateTerraformAsync(
        IResource resource,
        TerraformStackAnnotation annotation,
        ILogger logger,
        IOptions<PipelineOptions>? pipelineOptions,
        CancellationToken cancellationToken)
    {
        // Create and configure the stack
        var stack = new TerraformStack();
        annotation.Configure(stack);

        // Validate the stack
        var validationResult = stack.Validate();
        if (!validationResult.IsValid)
        {
            logger.LogError("❌ Terraform validation failed for {StackName}:", stack.Name);
            foreach (var error in validationResult.Errors)
            {
                logger.LogError("  • {ErrorMessage}", error.Message);
            }
            throw new InvalidOperationException(
                $"Terraform stack validation failed for '{stack.Name}' with {validationResult.Errors.Count} error(s).");
        }

        logger.LogInformation("✅ Terraform validation passed for {StackName}", stack.Name);

        // Generate HCL
        var hclContent = stack.ToHcl();

        // Determine output path
        var workingDirectory = GetWorkingDirectory(resource, pipelineOptions);
        Directory.CreateDirectory(workingDirectory);

        // Write file
        var terraformFileName = $"{stack.Name}.tf";
        var terraformFilePath = Path.Combine(workingDirectory, terraformFileName);
        await File.WriteAllTextAsync(terraformFilePath, hclContent, cancellationToken);

        var fullyQualifiedPath = Path.GetFullPath(terraformFilePath);
        logger.LogInformation("✅ Generated Terraform file: {FilePath}", fullyQualifiedPath);
    }

    private static string GetWorkingDirectory(IResource resource, IOptions<PipelineOptions>? pipelineOptions)
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
}
