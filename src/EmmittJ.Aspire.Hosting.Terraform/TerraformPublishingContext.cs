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

    // Lookup dictionaries for tracking outputs and parameters
    private readonly Dictionary<TerraformOutputReference, TerraformOutput> _outputLookup = new();
    private readonly Dictionary<ParameterResource, TerraformVariable> _parameterLookup = new();
    private readonly Dictionary<string, TerraformModule> _moduleMap = new();

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

        // Create root stack with environment customizations
        var rootStack = CreateRootStack(environment);

        // Phase 1: Process all resources and generate their module files
        // This also collects all input dependencies (outputs and parameters)
        var resourceModules = new List<(TerraformProvisioningResource TerraformResource, TerraformModule Module)>();

        foreach (var resource in model.Resources)
        {
            // Skip the environment resource itself - it's already in the root stack
            if (resource == environment)
            {
                continue;
            }

            if (resource.GetDeploymentTargetAnnotation(environment)?.DeploymentTarget is TerraformProvisioningResource terraformResource)
            {
                var module = await ProcessResourceAsync(terraformResource).ConfigureAwait(false);
                resourceModules.Add((terraformResource, module));
                _moduleMap[resource.Name] = module;
            }
        }

        // Phase 2: Discover all referenced outputs for module wiring
        var referencedOutputs = new HashSet<TerraformOutputReference>();

        foreach (var (terraformResource, _) in resourceModules)
        {
            foreach (var input in terraformResource.Inputs.Values)
            {
                Visit(input, value =>
                {
                    if (value is TerraformOutputReference outputRef)
                    {
                        referencedOutputs.Add(outputRef);
                    }
                });
            }
        }

        // Track output references for resolution
        foreach (var outputRef in referencedOutputs)
        {
            // Check if this is a reference to an environment output (root stack)
            if (outputRef.Resource == environment)
            {
                // For environment outputs, find the actual output in the root stack
                var existingOutput = rootStack?.Blocks?.OfType<TerraformOutput>()
                    .FirstOrDefault(o => o.Name == outputRef.Name);

                if (existingOutput is not null)
                {
                    _outputLookup[outputRef] = existingOutput;
                }
                else
                {
                    _logger.LogWarning("Output '{OutputName}' not found in environment '{ResourceName}'. " +
                        "Ensure the output is defined in the environment's PublishAsTerraform callback.",
                        outputRef.Name, outputRef.Resource.Name);
                }
                continue;
            }

            // For other resources, verify the module exists
            if (!_moduleMap.TryGetValue(outputRef.Resource.Name, out _))
            {
                _logger.LogWarning("Output reference to '{ResourceName}.{OutputName}' cannot be resolved - source module not found",
                    outputRef.Resource.Name, outputRef.Name);
                continue;
            }

            // Create a placeholder for module outputs (we don't need to store these, just validate they exist)
        }

        // Phase 3: Wire module blocks with input parameters
        foreach (var (terraformResource, module) in resourceModules)
        {
            foreach (var (inputName, inputValue) in terraformResource.Inputs)
            {
                var resolvedValue = ResolveInputValue(inputValue);
                module.SetArgument(inputName, resolvedValue);
            }

            rootStack?.Add(module);
        }

        // Phase 4: Add parameter variables to root stack (for bubbling up to root module)
        // Only add variables that aren't already present in the root stack
        if (rootStack is not null)
        {
            var existingVariables = rootStack.Blocks.OfType<TerraformVariable>()
                .Select(v => v.Name)
                .ToHashSet(StringComparer.Ordinal);

            foreach (var variable in _parameterLookup.Values)
            {
                if (!existingVariables.Contains(variable.Name))
                {
                    rootStack.Add(variable);
                }
            }
        }

        // Generate the root main.tf if we have any blocks
        if (rootStack?.Blocks?.Count > 0)
        {
            await GenerateRootMainTfAsync(rootStack).ConfigureAwait(false);
        }

        // Generate .terraform-version file at the root if specified
        if (!string.IsNullOrEmpty(_environment.TerraformVersion))
        {
            var versionFilePath = Path.Combine(_baseOutputPath, ".terraform-version");
            await File.WriteAllTextAsync(versionFilePath, _environment.TerraformVersion, _cancellationToken).ConfigureAwait(false);
        }
    }

    private static TerraformStack? CreateRootStack(TerraformEnvironmentResource environment)
    {
        // Check if the environment resource itself has customization annotations
        if (environment.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var environmentAnnotations))
        {
            // Run all customization callbacks against the environment's TerraformResource
            foreach (var annotation in environmentAnnotations)
            {
                annotation.Configure(environment.TerraformResource);
            }

            return environment.TerraformResource.Stack;
        }

        // Return the stack if it has settings configured (even without customization annotations)
        if (environment.TerraformResource.Stack.Terraform is not null)
        {
            return environment.TerraformResource.Stack;
        }

        return null;
    }

    private async Task<TerraformModule> ProcessResourceAsync(TerraformProvisioningResource terraformResource)
    {
        var resource = terraformResource.TargetResource ?? terraformResource;

        _logger.LogInformation("Processing resource: {ResourceName}", resource.Name);

        // Get the output path for this specific resource
        var resourceOutputPath = PublishingContextUtils.GetResourceOutputPath(_pipelineContext, _environment, resource);
        Directory.CreateDirectory(resourceOutputPath);

        // Apply all customization annotations to the same stack
        if (resource.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var annotations))
        {
            foreach (var annotation in annotations)
            {
                // Apply the customization callback
                // This populates terraformResource.Inputs with any dependencies from AddVariable calls
                annotation.Configure(terraformResource);
            }
        }

        // Handle different resource types
        await ProcessResourceByTypeAsync(resource, terraformResource.Stack).ConfigureAwait(false);

        // Generate .tf file using stack name (defaults to "main")
        var fileName = $"{terraformResource.Stack.Name}.tf";
        await GenerateConfigurationFileAsync(terraformResource.Stack, resourceOutputPath, fileName).ConfigureAwait(false);

        // Return module reference for this resource's directory
        var relativePath = Path.GetRelativePath(_baseOutputPath, resourceOutputPath);
        return new TerraformModule(resource.Name)
        {
            Source = $"./{relativePath.Replace("\\", "/")}"
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
    }

    private object ResolveInputValue(object inputValue)
    {
        return inputValue switch
        {
            TerraformOutputReference outputRef => ResolveOutputReference(outputRef),

            ParameterResource param =>
                GetOrCreateParameterVariable(param).AsReference(),

            string s =>
                TerraformExpression.Literal(s),

            TerraformExpression expr =>
                expr,

            _ => throw new NotSupportedException(
                $"Input value type '{inputValue.GetType().Name}' is not supported for module parameters. " +
                $"Supported types: TerraformOutputReference, ParameterResource, string, TerraformExpression")
        };
    }

    private object ResolveOutputReference(TerraformOutputReference outputRef)
    {
        // If the output is produced by the environment resource (root stack),
        // reference the resource directly instead of as a module
        if (outputRef.Resource == _environment)
        {
            // Find the output in the root stack and get its value expression
            if (_outputLookup.TryGetValue(outputRef, out var output))
            {
                // Return the output's value directly - it will be resolved when the module is rendered
                return output.Value;
            }

            throw new InvalidOperationException(
                $"Output '{outputRef.Name}' from environment '{outputRef.Resource.Name}' not found. " +
                $"Ensure the output is defined in the environment's PublishAsTerraform callback.");
        }

        // For other resources, reference as a module output
        return TerraformExpression.Identifier($"module.{outputRef.Resource.Name}.{outputRef.Name}");
    }

    private TerraformVariable GetOrCreateParameterVariable(ParameterResource parameter)
    {
        if (!_parameterLookup.TryGetValue(parameter, out var variable))
        {
            var variableName = parameter.Name.Replace("-", "_");
            variable = new TerraformVariable(variableName)
            {
                Type = "string",
                Description = parameter.Description ?? $"Parameter '{parameter.Name}'",
                Sensitive = parameter.Secret
            };
            _parameterLookup[parameter] = variable;
        }
        return variable;
    }

    private static void Visit(object? value, Action<object> visitor)
    {
        var visited = new HashSet<object>(ReferenceEqualityComparer.Instance);
        VisitCore(value, visitor, visited);
    }

    private static void VisitCore(object? value, Action<object> visitor, HashSet<object> visited)
    {
        if (value is null || !visited.Add(value))
        {
            return;
        }

        visitor(value);

        // Visit nested values if the object contains references
        // For now, we handle common cases explicitly
        if (value is IEnumerable<object> enumerable)
        {
            foreach (var item in enumerable)
            {
                VisitCore(item, visitor, visited);
            }
        }
    }

    private async Task GenerateConfigurationFileAsync(TerraformStack stack, string outputPath, string fileName)
    {
        _logger.LogInformation("Generating Terraform configuration file {FileName} in {OutputPath}", fileName, outputPath);

        var hcl = stack.ToHcl();
        var filePath = Path.Combine(outputPath, fileName);
        await File.WriteAllTextAsync(filePath, hcl, _cancellationToken).ConfigureAwait(false);

        _logger.LogInformation("Generated configuration: {FilePath}", filePath);
    }

    private async Task GenerateRootMainTfAsync(TerraformStack rootStack)
    {
        _logger.LogInformation("Generating root main.tf with {Count} blocks", rootStack.Blocks.Count);

        var rootMainTfPath = Path.Combine(_baseOutputPath, "main.tf");
        var hcl = rootStack.ToHcl();
        await File.WriteAllTextAsync(rootMainTfPath, hcl, _cancellationToken).ConfigureAwait(false);

        _logger.LogInformation("Generated root main.tf at {Path}", rootMainTfPath);
    }
}
