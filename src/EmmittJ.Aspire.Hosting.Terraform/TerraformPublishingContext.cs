// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES002
#pragma warning disable IL2026
#pragma warning disable IL3050

using System.Text.Json;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
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
    private readonly string _outputPath;
    private readonly ILogger _logger;
    private readonly TerraformEnvironmentResource _environment;
    private readonly CancellationToken _cancellationToken;
    private readonly TerraformStack _stack;

    public TerraformPublishingContext(
        DistributedApplicationExecutionContext executionContext,
        string outputPath,
        ILogger logger,
        TerraformEnvironmentResource environment,
        CancellationToken cancellationToken = default)
    {
        _executionContext = executionContext;
        _outputPath = outputPath;
        _logger = logger;
        _environment = environment;
        _cancellationToken = cancellationToken;
        _stack = new TerraformStack();
    }

    internal async Task WriteModelAsync(DistributedApplicationModel model, TerraformEnvironmentResource environment)
    {
        if (!_executionContext.IsPublishMode)
        {
            return;
        }

        _logger.LogInformation("Starting Terraform configuration generation");

        ArgumentNullException.ThrowIfNull(model);
        ArgumentNullException.ThrowIfNull(_outputPath);

        if (model.Resources.Count == 0)
        {
            _logger.LogWarning("Model is empty, no resources to generate");
            return;
        }

        await WriteTerraformOutputAsync(model, environment).ConfigureAwait(false);

        _logger.LogInformation("Finished generating Terraform configuration at {OutputPath}", _outputPath);
    }

    private async Task WriteTerraformOutputAsync(DistributedApplicationModel model, TerraformEnvironmentResource environment)
    {
        // Ensure output directory exists
        Directory.CreateDirectory(_outputPath);

        // Configure backend if specified
        if (!string.IsNullOrEmpty(_environment.BackendType))
        {
            ConfigureBackend();
        }

        // Process each resource that has a deployment target for this environment
        foreach (var resource in model.Resources)
        {
            if (resource.GetDeploymentTargetAnnotation(environment)?.DeploymentTarget is TerraformResource terraformResource)
            {
                await ProcessResourceAsync(terraformResource).ConfigureAwait(false);
            }
        }

        // Generate the Terraform configuration files
        await GenerateConfigurationFilesAsync().ConfigureAwait(false);
    }

    private void ConfigureBackend()
    {
        // Configure backend based on type
        // This would use your TerraformStack SDK to configure backend
        _logger.LogInformation("Configuring Terraform backend: {BackendType}", _environment.BackendType);

        // Example: Add backend configuration to the stack
        // The actual implementation depends on your SDK's backend configuration API
    }

    private async Task ProcessResourceAsync(TerraformResource terraformResource)
    {
        _logger.LogInformation("Processing resource: {ResourceName}", terraformResource.TargetResource.Name);

        var resource = terraformResource.TargetResource;

        // Apply any TerraformCustomizationAnnotation customizations
        if (resource.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var annotations))
        {
            foreach (var annotation in annotations)
            {
                annotation.Configure(_stack, resource);
            }
        }

        // Handle different resource types
        await ProcessResourceByTypeAsync(resource).ConfigureAwait(false);
    }

    private async Task ProcessResourceByTypeAsync(IResource resource)
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
        // - Add resources to _stack using your SDK
    }

    private async Task GenerateConfigurationFilesAsync()
    {
        _logger.LogInformation("Generating Terraform configuration files");

        // Generate the Terraform HCL configuration
        var hcl = _stack.ToHcl();

        // Write main configuration file as HCL
        var mainFilePath = Path.Combine(_outputPath, "main.tf");
        await File.WriteAllTextAsync(mainFilePath, hcl, _cancellationToken).ConfigureAwait(false);

        _logger.LogInformation("Generated main configuration: {FilePath}", mainFilePath);

        // Optionally generate variables.tf.json
        await GenerateVariablesFileAsync().ConfigureAwait(false);

        // Optionally generate outputs.tf.json
        await GenerateOutputsFileAsync().ConfigureAwait(false);

        // Generate .terraform-version file if version is specified
        if (!string.IsNullOrEmpty(_environment.TerraformVersion))
        {
            var versionFilePath = Path.Combine(_outputPath, ".terraform-version");
            await File.WriteAllTextAsync(versionFilePath, _environment.TerraformVersion, _cancellationToken).ConfigureAwait(false);
        }
    }

    private async Task GenerateVariablesFileAsync()
    {
        var variablesFilePath = Path.Combine(_outputPath, "variables.tf.json");

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

    private async Task GenerateOutputsFileAsync()
    {
        var outputsFilePath = Path.Combine(_outputPath, "outputs.tf.json");

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
}
