// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIREPIPELINES002
#pragma warning disable IL2026
#pragma warning disable IL3050

using System.Text.Json;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Context for publishing Terraform configurations from Aspire resources.
/// </summary>
internal sealed class TerraformPublishingContext
{
    private readonly DistributedApplicationExecutionContext _executionContext;
    private readonly PipelineStepContext _pipelineContext;
    private readonly string _baseOutputPath;
    private readonly ILogger _logger;
    private readonly TerraformEnvironmentResource _environment;
    private readonly CancellationToken _cancellationToken;

    public TerraformPublishingContext(
        PipelineStepContext pipelineContext,
        DistributedApplicationExecutionContext executionContext,
        string baseOutputPath,
        ILogger logger,
        TerraformEnvironmentResource environment,
        CancellationToken cancellationToken = default)
    {
        _pipelineContext = pipelineContext;
        _executionContext = executionContext;
        _baseOutputPath = baseOutputPath;
        _logger = logger;
        _environment = environment;
        _cancellationToken = cancellationToken;
    }

    internal async Task WriteModelAsync(DistributedApplicationModel model, TerraformEnvironmentResource environment)
    {
        if (!_executionContext.IsPublishMode)
        {
            return;
        }

        _logger.LogInformation("Starting Terraform configuration generation");

        ArgumentNullException.ThrowIfNull(model);
        ArgumentNullException.ThrowIfNull(_baseOutputPath);

        if (model.Resources.Count == 0)
        {
            _logger.LogWarning("Model is empty, no resources to generate");
            return;
        }

        await WriteTerraformOutputAsync(model, environment).ConfigureAwait(false);

        _logger.LogInformation("Finished generating Terraform configuration at {OutputPath}", _baseOutputPath);
    }

    private async Task WriteTerraformOutputAsync(DistributedApplicationModel model, TerraformEnvironmentResource environment)
    {
        // Ensure base output directory exists
        Directory.CreateDirectory(_baseOutputPath);

        // Create the root stack that will reference all resource modules
        var stack = new TerraformStack();

        // Process each resource that has a deployment target for this environment
        foreach (var resource in model.Resources)
        {
            if (resource.GetDeploymentTargetAnnotation(environment)?.DeploymentTarget is TerraformResource terraformResource)
            {
                var module = await ProcessResourceAsync(terraformResource).ConfigureAwait(false);
                stack.Add(module);
            }
        }

        // Generate the root main.tf if we have any blocks
        if (stack.Blocks.Count > 0)
        {
            await GenerateRootMainTfAsync(stack).ConfigureAwait(false);
        }

        // Generate .terraform-version file at the root if specified
        if (!string.IsNullOrEmpty(_environment.TerraformVersion))
        {
            var versionFilePath = Path.Combine(_baseOutputPath, ".terraform-version");
            await File.WriteAllTextAsync(versionFilePath, _environment.TerraformVersion, _cancellationToken).ConfigureAwait(false);
        }
    }

    private async Task<TerraformModule> ProcessResourceAsync(TerraformResource terraformResource)
    {
        _logger.LogInformation("Processing resource: {ResourceName}", terraformResource.TargetResource.Name);

        var resource = terraformResource.TargetResource;

        // Get the output path for this specific resource
        var resourceOutputPath = PublishingContextUtils.GetResourceOutputPath(_pipelineContext, _environment, resource);
        Directory.CreateDirectory(resourceOutputPath);

        // Process each TerraformCustomizationAnnotation separately (each creates its own stack/file)
        if (resource.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var annotations))
        {
            foreach (var annotation in annotations)
            {
                // Create a new stack for this annotation
                var stack = new TerraformStack();

                // Apply the customization
                annotation.Configure(stack, resource);

                // Handle different resource types
                await ProcessResourceByTypeAsync(resource, stack).ConfigureAwait(false);

                // Generate the Terraform configuration files for this stack
                // Use stack name if provided, otherwise use "main"
                var fileName = !string.IsNullOrEmpty(stack.Name) ? $"{stack.Name}.tf" : "main.tf";
                await GenerateConfigurationFileAsync(stack, resourceOutputPath, fileName).ConfigureAwait(false);
            }
        }
        else
        {
            // If no customization annotations, create a default stack
            var stack = new TerraformStack();

            await ProcessResourceByTypeAsync(resource, stack).ConfigureAwait(false);
            await GenerateConfigurationFileAsync(stack, resourceOutputPath, "main.tf").ConfigureAwait(false);
        }

        // Compute the relative path from base output to resource output for the module source
        var relativePath = Path.GetRelativePath(_baseOutputPath, resourceOutputPath);
        return new TerraformModule(resource.Name)
        {
            Source = $"./{relativePath.Replace("\\", "/")}"  // Implicit conversion from string to TerraformValue<string>
        };
    }

    private async Task ProcessResourceByTypeAsync(IResource resource, TerraformStack stack)
    {
        // Process environment variables
        var environmentVariables = new Dictionary<string, object>();

        if (resource.TryGetAnnotationsOfType<EnvironmentCallbackAnnotation>(out var envCallbacks))
        {
            var context = new EnvironmentCallbackContext(
                _executionContext,
                resource,
                environmentVariables,
                _cancellationToken);

            foreach (var callback in envCallbacks)
            {
                await callback.Callback(context).ConfigureAwait(false);
            }
        }

        // Log the resource type for debugging
        _logger.LogDebug("Processing resource type: {ResourceType}", resource.GetType().Name);

        // Here you would add logic to create Terraform resources based on the Aspire resource type
        // For example:
        // - ProjectResource -> Container/ECS Task/etc
        // - ContainerResource -> Container/ECS Task/etc
        // - ExecutableResource -> Custom compute
        // - Add resources to stack using your SDK
    }

    private async Task GenerateConfigurationFileAsync(TerraformStack stack, string outputPath, string fileName)
    {
        _logger.LogInformation("Generating Terraform configuration file {FileName} in {OutputPath}", fileName, outputPath);

        // Generate the Terraform HCL configuration
        var hcl = stack.ToHcl();

        // Write configuration file as HCL
        var filePath = Path.Combine(outputPath, fileName);
        await File.WriteAllTextAsync(filePath, hcl, _cancellationToken).ConfigureAwait(false);

        _logger.LogInformation("Generated configuration: {FilePath}", filePath);
    }

    private async Task GenerateVariablesFileAsync(string outputPath)
    {
        var variablesFilePath = Path.Combine(outputPath, "variables.tf.json");

        // Create variables configuration
        var variables = new Dictionary<string, object>();

        // Add any variables needed for the configuration
        // This would be populated based on the resources being deployed

        if (variables.Count > 0)
        {
            var variablesWrapper = new { variable = variables };
            var json = System.Text.Json.JsonSerializer.Serialize(variablesWrapper, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            await File.WriteAllTextAsync(variablesFilePath, json, _cancellationToken).ConfigureAwait(false);

            _logger.LogInformation("Generated variables file: {FilePath}", variablesFilePath);
        }
    }

    private async Task GenerateOutputsFileAsync(string outputPath)
    {
        var outputsFilePath = Path.Combine(outputPath, "outputs.tf.json");

        // Create outputs configuration
        var outputs = new Dictionary<string, object>();

        // Add any outputs needed from the configuration
        // This would be populated based on the resources being deployed

        if (outputs.Count > 0)
        {
            var outputsWrapper = new { output = outputs };
            var json = System.Text.Json.JsonSerializer.Serialize(outputsWrapper, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            await File.WriteAllTextAsync(outputsFilePath, json, _cancellationToken).ConfigureAwait(false);

            _logger.LogInformation("Generated outputs file: {FilePath}", outputsFilePath);
        }
    }

    private async Task GenerateRootMainTfAsync(TerraformStack rootStack)
    {
        _logger.LogInformation("Generating root main.tf with {Count} modules", rootStack.Blocks.Count);

        // Add terraform settings to the root stack if specified
        if (_environment.Settings != null)
        {
            rootStack.Terraform = _environment.Settings;
        }

        // Generate root main.tf using the SDK
        var rootMainTfPath = Path.Combine(_baseOutputPath, "main.tf");
        var hcl = rootStack.ToHcl();
        await File.WriteAllTextAsync(rootMainTfPath, hcl, _cancellationToken).ConfigureAwait(false);

        _logger.LogInformation("Generated root main.tf at {Path}", rootMainTfPath);
    }
}

