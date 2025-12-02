// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides methods for resolving Terraform variables and writing them to tfvars files.
/// </summary>
internal static class TerraformVariableResolver
{
    /// <summary>
    /// Resolves parameter values from the environment and writes non-sensitive values to aspire.auto.tfvars.
    /// Returns sensitive values as a dictionary to be passed as TF_VAR_* environment variables.
    /// </summary>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="environment">The Terraform environment containing parameter variables.</param>
    /// <param name="outputPath">The output path where aspire.auto.tfvars will be written.</param>
    /// <returns>A dictionary of sensitive variable names to values for TF_VAR_* environment variables.</returns>
    public static async Task<Dictionary<string, string>> ResolveParameterVariablesAsync(
        PipelineStepContext context,
        ITerraformEnvironment environment,
        string outputPath)
    {
        var sensitiveVars = new Dictionary<string, string>();
        var nonSensitiveVars = new List<(string Name, string Value)>();

        if (environment.ParameterVariables.Count > 0)
        {
            context.Logger.LogInformation("Resolving {Count} Terraform parameter variables", environment.ParameterVariables.Count);

            foreach (var (parameter, variable) in environment.ParameterVariables)
            {
                var value = await parameter.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

                if (string.IsNullOrEmpty(value))
                {
                    context.Logger.LogWarning(
                        "Parameter '{ParameterName}' (variable '{VariableName}') has no value.",
                        parameter.Name, variable.Name);
                    continue;
                }

                if (parameter.Secret)
                {
                    sensitiveVars[variable.Name] = value;
                }
                else
                {
                    nonSensitiveVars.Add((variable.Name, value));
                }
            }
        }

        await WriteTfvarsFileAsync(outputPath, nonSensitiveVars, context.Logger).ConfigureAwait(false);

        return sensitiveVars;
    }

    /// <summary>
    /// Resolves all variables for the environment including parameter variables, output references, and container image references.
    /// Writes non-sensitive values to aspire.auto.tfvars and returns sensitive values for TF_VAR_* environment variables.
    /// </summary>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="environment">The Terraform environment.</param>
    /// <param name="outputPath">The output path where aspire.auto.tfvars will be written.</param>
    /// <returns>A dictionary of sensitive variable names to values for TF_VAR_* environment variables.</returns>
    public static async Task<Dictionary<string, string>> ResolveAllVariablesAsync(
        PipelineStepContext context,
        TerraformEnvironmentResource environment,
        string outputPath)
    {
        var sensitiveVars = new Dictionary<string, string>();
        var nonSensitiveVars = new List<(string Name, string Value)>();

        // Resolve Aspire parameter values
        if (environment.ParameterVariables.Count > 0)
        {
            context.Logger.LogInformation("Resolving {Count} Terraform parameter variables", environment.ParameterVariables.Count);

            foreach (var (parameter, variable) in environment.ParameterVariables)
            {
                var value = await parameter.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

                if (string.IsNullOrEmpty(value))
                {
                    context.Logger.LogWarning(
                        "Parameter '{ParameterName}' (variable '{VariableName}') has no value. " +
                        "Terraform may prompt for it or use a default if defined.",
                        parameter.Name, variable.Name);
                    continue;
                }

                if (parameter.Secret)
                {
                    sensitiveVars[variable.Name] = value;
                    context.Logger.LogDebug("Sensitive variable '{VariableName}' will be passed via TF_VAR_* environment variable", variable.Name);
                }
                else
                {
                    nonSensitiveVars.Add((variable.Name, value));
                    context.Logger.LogDebug("Variable '{VariableName}' will be written to aspire.auto.tfvars", variable.Name);
                }
            }
        }

        // Collect all inputs from the environment's TerraformResource and all compute resources
        var allInputs = CollectInputs(context, environment);

        // Resolve all collected inputs
        await ResolveInputsAsync(context, allInputs, sensitiveVars, nonSensitiveVars).ConfigureAwait(false);

        await WriteTfvarsFileAsync(outputPath, nonSensitiveVars, context.Logger).ConfigureAwait(false);

        return sensitiveVars;
    }

    private static Dictionary<string, object> CollectInputs(PipelineStepContext context, TerraformEnvironmentResource environment)
    {
        var allInputs = new Dictionary<string, object>();

        // Add environment-level inputs
        foreach (var (inputName, inputValue) in environment.TerraformResource.Inputs)
        {
            allInputs[inputName] = inputValue;
        }

        // Add inputs from all compute resources that are deployed to this environment
        foreach (var computeResource in context.Model.GetComputeResources())
        {
            if (computeResource.GetDeploymentTargetAnnotation(environment)?.DeploymentTarget is TerraformProvisioningResource terraformResource)
            {
                foreach (var (inputName, inputValue) in terraformResource.Inputs)
                {
                    // Only add if not already present (environment-level takes precedence)
                    if (!allInputs.ContainsKey(inputName))
                    {
                        allInputs[inputName] = inputValue;
                    }
                }
            }
        }

        return allInputs;
    }

    private static async Task ResolveInputsAsync(
        PipelineStepContext context,
        Dictionary<string, object> allInputs,
        Dictionary<string, string> sensitiveVars,
        List<(string Name, string Value)> nonSensitiveVars)
    {
        foreach (var (inputName, inputValue) in allInputs)
        {
            if (inputValue is TerraformOutputReference outputRef)
            {
                await ResolveOutputReferenceAsync(context, inputName, outputRef, sensitiveVars, nonSensitiveVars).ConfigureAwait(false);
            }
            else if (inputValue is ContainerImageReference imageRef)
            {
                await ResolveContainerImageReferenceAsync(context, inputName, imageRef, nonSensitiveVars).ConfigureAwait(false);
            }
        }
    }

    private static Task ResolveOutputReferenceAsync(
        PipelineStepContext context,
        string inputName,
        TerraformOutputReference outputRef,
        Dictionary<string, string> sensitiveVars,
        List<(string Name, string Value)> nonSensitiveVars)
    {
        // Skip output references to the environment itself - these are wired up at publish time
        // as direct references to root module outputs, not runtime values
        if (outputRef.Resource is TerraformEnvironmentResource)
        {
            context.Logger.LogDebug(
                "Skipping output reference '{OutputName}' - environment outputs are wired at publish time",
                outputRef.Name);
            return Task.CompletedTask;
        }

        // Skip output references to other modules - these are wired up at publish time
        // as module.{name}.{output} references
        if (outputRef.Resource is not TerraformContainerRegistryResource)
        {
            context.Logger.LogDebug(
                "Skipping output reference '{ResourceName}.{OutputName}' - module outputs are wired at publish time",
                outputRef.Resource.Name, outputRef.Name);
            return Task.CompletedTask;
        }

        // Container registry outputs need runtime resolution (separate state)
        var value = outputRef.Value;
        if (string.IsNullOrEmpty(value))
        {
            context.Logger.LogWarning(
                "Output reference '{ResourceName}.{OutputName}' (variable '{VariableName}') has no value. " +
                "Ensure the source resource has been applied and outputs read.",
                outputRef.Resource.Name, outputRef.Name, inputName);
            return Task.CompletedTask;
        }

        if (outputRef.Sensitive)
        {
            sensitiveVars[inputName] = value;
            context.Logger.LogDebug("Sensitive output reference '{VariableName}' will be passed via TF_VAR_* environment variable", inputName);
        }
        else
        {
            nonSensitiveVars.Add((inputName, value));
            context.Logger.LogDebug("Output reference '{VariableName}' will be written to aspire.auto.tfvars", inputName);
        }

        return Task.CompletedTask;
    }

    private static async Task ResolveContainerImageReferenceAsync(
        PipelineStepContext context,
        string inputName,
        ContainerImageReference imageRef,
        List<(string Name, string Value)> nonSensitiveVars)
    {
        var provider = imageRef as IValueProvider;
        var value = await provider.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

        if (string.IsNullOrEmpty(value))
        {
            context.Logger.LogWarning(
                "Container image reference for '{ResourceName}' (variable '{VariableName}') has no value. " +
                "Ensure the image has been built and pushed.",
                imageRef.Resource.Name, inputName);
            return;
        }

        // Container images are not sensitive
        nonSensitiveVars.Add((inputName, value));
        context.Logger.LogDebug("Container image '{VariableName}' = '{Value}' will be written to aspire.auto.tfvars", inputName, value);
    }

    private static async Task WriteTfvarsFileAsync(
        string outputPath,
        List<(string Name, string Value)> nonSensitiveVars,
        ILogger logger)
    {
        if (nonSensitiveVars.Count == 0)
        {
            return;
        }

        var tfvarsPath = Path.Combine(outputPath, "aspire.auto.tfvars");
        await using var writer = new StreamWriter(tfvarsPath, append: false);

        await writer.WriteLineAsync("# Auto-generated by Aspire Terraform publishing").ConfigureAwait(false);
        await writer.WriteLineAsync($"# Generated at {DateTime.UtcNow:O}").ConfigureAwait(false);
        await writer.WriteLineAsync().ConfigureAwait(false);

        var hclContext = TerraformContext.Temporary();
        foreach (var (name, value) in nonSensitiveVars)
        {
            var argumentNode = new TerraformArgumentNode(name, TerraformExpression.Literal(value));
            await writer.WriteLineAsync(argumentNode.ToHcl(hclContext)).ConfigureAwait(false);
        }

        logger.LogInformation("Wrote {Count} variables to {Path}", nonSensitiveVars.Count, tfvarsPath);
    }
}
