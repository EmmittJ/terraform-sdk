// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Factory for creating Terraform pipeline steps and resolving variables.
/// </summary>
internal static class TerraformPipelineFactory
{
    #region Step Creation

    /// <summary>
    /// Creates the standard set of Terraform pipeline steps for an environment.
    /// </summary>
    /// <param name="environment">The Terraform environment resource.</param>
    /// <param name="stepNamePrefix">The prefix for step names (e.g., "terraform" or "registry").</param>
    /// <param name="getOutputPath">Function to get the output path from the pipeline context.</param>
    /// <param name="publishAction">The action to run for the publish step.</param>
    /// <param name="additionalTags">Additional tags to add to all steps.</param>
    /// <returns>A list of configured pipeline steps.</returns>
    public static List<PipelineStep> CreateTerraformSteps(
        ITerraformEnvironment environment,
        string stepNamePrefix,
        Func<PipelineStepContext, string> getOutputPath,
        Func<PipelineStepContext, Task> publishAction,
        string[]? additionalTags = null)
    {
        var steps = new List<PipelineStep>();
        var tags = additionalTags ?? [];

        // Publish step - generates Terraform files
        var publishStep = new PipelineStep
        {
            Name = $"publish-{stepNamePrefix}-{environment.Name}",
            Action = publishAction,
            Tags = [TerraformPipelineTags.PublishTerraform, .. tags],
            RequiredBySteps = [WellKnownPipelineSteps.Publish, WellKnownPipelineSteps.Deploy]
        };
        steps.Add(publishStep);

        if (!environment.AutoInit)
        {
            return steps;
        }

        // Init step
        var initStep = new PipelineStep
        {
            Name = $"terraform-init-{stepNamePrefix}-{environment.Name}",
            Action = ctx => TerraformCli.RunCommandAsync(
                ctx,
                "init -input=false -no-color",
                getOutputPath(ctx)),
            Tags = [TerraformPipelineTags.TerraformInit, .. tags],
            DependsOnSteps = [publishStep.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(initStep);

        if (!environment.AutoPlan)
        {
            return steps;
        }

        // Plan step
        var planStep = new PipelineStep
        {
            Name = $"terraform-plan-{stepNamePrefix}-{environment.Name}",
            Action = async ctx =>
            {
                var outputPath = getOutputPath(ctx);
                var sensitiveEnvVars = await ResolveVariablesAsync(ctx, environment, outputPath).ConfigureAwait(false);
                await TerraformCli.RunCommandAsync(
                    ctx,
                    "plan -out=aspire.tfplan -input=false -no-color",
                    outputPath,
                    sensitiveEnvVars,
                    logOutput: true).ConfigureAwait(false);
            },
            Tags = [TerraformPipelineTags.TerraformPlan, .. tags],
            DependsOnSteps = [initStep.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(planStep);

        if (!environment.AutoApply)
        {
            return steps;
        }

        // Apply step
        var applyStep = new PipelineStep
        {
            Name = $"terraform-apply-{stepNamePrefix}-{environment.Name}",
            Action = async ctx =>
            {
                var outputPath = getOutputPath(ctx);
                var sensitiveEnvVars = await ResolveVariablesAsync(ctx, environment, outputPath).ConfigureAwait(false);
                await TerraformCli.RunCommandAsync(
                    ctx,
                    "apply -auto-approve -input=false -no-color aspire.tfplan",
                    outputPath,
                    sensitiveEnvVars,
                    logOutput: true).ConfigureAwait(false);
            },
            Tags = [TerraformPipelineTags.TerraformApply, WellKnownPipelineTags.ProvisionInfrastructure, .. tags],
            DependsOnSteps = [planStep.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(applyStep);

        // Read outputs step
        var readOutputsStep = new PipelineStep
        {
            Name = $"read-outputs-{stepNamePrefix}-{environment.Name}",
            Action = ctx => ReadOutputsAsync(ctx, environment, getOutputPath(ctx)),
            Tags = [TerraformPipelineTags.TerraformOutputs, .. tags],
            DependsOnSteps = [applyStep.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(readOutputsStep);

        // Print summary step
        var printSummaryStep = new PipelineStep
        {
            Name = $"print-summary-{stepNamePrefix}-{environment.Name}",
            Action = ctx => PrintOutputSummaryAsync(ctx, environment),
            Tags = [TerraformPipelineTags.TerraformSummary, .. tags],
            DependsOnSteps = [readOutputsStep.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(printSummaryStep);

        return steps;
    }

    private static async Task ReadOutputsAsync(
        PipelineStepContext context,
        ITerraformEnvironment environment,
        string outputPath)
    {
        var outputs = await TerraformCli.ReadOutputsAsync(context, outputPath).ConfigureAwait(false);

        // Populate the OutputsAnnotation for TerraformOutputReference access
        var outputsAnnotation = environment.TerraformResource.OutputsAnnotation;
        foreach (var (key, (value, sensitive)) in outputs)
        {
            outputsAnnotation.Outputs[key] = value;
            // Track sensitivity for summary printing
            if (sensitive)
            {
                outputsAnnotation.SensitiveOutputs ??= new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                outputsAnnotation.SensitiveOutputs.Add(key);
            }
        }

        // Signal that provisioning is complete
        outputsAnnotation.ProvisioningTaskCompletionSource?.TrySetResult();

        context.Logger.LogDebug("Read {Count} Terraform outputs for '{EnvironmentName}'", outputs.Count, environment.Name);
    }

    private static async Task PrintOutputSummaryAsync(
        PipelineStepContext context,
        ITerraformEnvironment environment)
    {
        var outputsAnnotation = environment.TerraformResource.OutputsAnnotation;
        var sensitiveOutputs = outputsAnnotation.SensitiveOutputs ?? [];

        var nonSensitiveOutputs = outputsAnnotation.Outputs
            .Where(kvp => !sensitiveOutputs.Contains(kvp.Key))
            .OrderBy(kvp => kvp.Key)
            .ToList();

        if (nonSensitiveOutputs.Count > 0)
        {
            context.Logger.LogInformation("Terraform outputs for '{EnvironmentName}':", environment.Name);
            foreach (var (name, value) in nonSensitiveOutputs)
            {
                context.Logger.LogInformation("  {OutputName}: {OutputValue}", name, FormatOutputValue(value));
            }
        }

        await context.ReportingStep.CompleteAsync(
            $"Deployment complete for '{environment.Name}'",
            CompletionState.Completed,
            context.CancellationToken).ConfigureAwait(false);
    }

    private static string FormatOutputValue(object? value)
    {
        return value switch
        {
            null => "(null)",
            string s => s,
            _ => value.ToString() ?? "(null)"
        };
    }

    #endregion

    #region Variable Resolution

    /// <summary>
    /// Resolves all applicable variables for the environment based on its capabilities.
    /// </summary>
    /// <remarks>
    /// Resolution is based on the interfaces the environment implements:
    /// <list type="bullet">
    /// <item><see cref="ITerraformEnvironment"/>: Resolves parameter variables</item>
    /// <item><see cref="IComputeEnvironmentResource"/>: Resolves container images and terraform inputs from compute resources</item>
    /// </list>
    /// </remarks>
    private static async Task<Dictionary<string, string>> ResolveVariablesAsync(
        PipelineStepContext context,
        ITerraformEnvironment environment,
        string outputPath)
    {
        var sensitiveVars = new Dictionary<string, string>();
        var nonSensitiveVars = new List<(string Name, string Value)>();

        // All ITerraformEnvironment implementations have parameter variables
        await ResolveParameterVariablesAsync(context, environment, sensitiveVars, nonSensitiveVars).ConfigureAwait(false);

        // IComputeEnvironmentResource implementations host compute resources with container images and inputs
        if (environment is IComputeEnvironmentResource computeEnvironment)
        {
            var allInputs = CollectInputs(context, environment, computeEnvironment);
            await ResolveInputsAsync(context, allInputs, sensitiveVars, nonSensitiveVars).ConfigureAwait(false);
        }

        await WriteTfvarsFileAsync(outputPath, nonSensitiveVars, context.Logger).ConfigureAwait(false);

        return sensitiveVars;
    }

    /// <summary>
    /// Resolves parameter values from the environment.
    /// </summary>
    private static async Task ResolveParameterVariablesAsync(
        PipelineStepContext context,
        ITerraformEnvironment environment,
        Dictionary<string, string> sensitiveVars,
        List<(string Name, string Value)> nonSensitiveVars)
    {
        if (environment.ParameterVariables.Count == 0)
        {
            return;
        }

        context.Logger.LogDebug("Resolving {Count} Terraform parameter variables", environment.ParameterVariables.Count);

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
                context.Logger.LogDebug("Sensitive variable '{VariableName}' will be passed via TF_VAR_* environment variable", variable.Name);
            }
            else
            {
                nonSensitiveVars.Add((variable.Name, value));
                context.Logger.LogDebug("Variable '{VariableName}' will be written to aspire.auto.tfvars", variable.Name);
            }
        }
    }

    private static Dictionary<string, object> CollectInputs(
        PipelineStepContext context,
        ITerraformEnvironment environment,
        IComputeEnvironmentResource computeEnvironment)
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
            if (computeResource.GetDeploymentTargetAnnotation(computeEnvironment)?.DeploymentTarget is TerraformProvisioningResource terraformResource)
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

        logger.LogDebug("Wrote {Count} variables to {Path}", nonSensitiveVars.Count, tfvarsPath);
    }

    #endregion

    #region Shared Helpers

    /// <summary>
    /// Computes the host URL <see cref="ReferenceExpression"/> for the given <see cref="EndpointReference"/>.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to compute the host address for.</param>
    /// <returns>A <see cref="ReferenceExpression"/> representing the host address.</returns>
    /// <remarks>
    /// <para>
    /// This method returns a <see cref="ReferenceExpression"/> that wraps a <see cref="TerraformOutputReference"/>
    /// for the endpoint. The output name follows the convention: <c>{endpoint_name}_endpoint</c>.
    /// </para>
    /// <para>
    /// Resources should define corresponding outputs in their <c>PublishAsTerraform</c> callback:
    /// </para>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app") { ... };
    ///     infra.Add(containerApp);
    ///
    ///     // Export the endpoint for cross-resource references
    ///     infra.AddOutput("http_endpoint", Tf.Interpolate($"https://{containerApp.LatestRevisionFqdn}"));
    /// });
    /// </code>
    /// </example>
    /// </remarks>
    public static ReferenceExpression GetHostAddressExpression(EndpointReference endpointReference)
    {
        var resource = endpointReference.Resource;
        var endpointName = endpointReference.EndpointName;

        // Create an output reference using the naming convention: {endpoint_name}_endpoint
        // Examples: "http_endpoint", "https_endpoint", "grpc_endpoint"
        var outputName = $"{endpointName}{TerraformProvisioningResource.EndpointOutputNameSuffix}";
        var outputRef = new TerraformOutputReference(outputName, resource);

        return ReferenceExpression.Create($"{outputRef}");
    }

    #endregion
}
