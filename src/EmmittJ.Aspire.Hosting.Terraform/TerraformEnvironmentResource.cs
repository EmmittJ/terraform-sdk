// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIRECOMPUTE002

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Aspire.Hosting.Utils;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform environment resource that can host application resources.
/// </summary>
public sealed class TerraformEnvironmentResource : Resource, IComputeEnvironmentResource
{
    /// <summary>
    /// Gets the <see cref="TerraformResource"/> for this environment, which provides the root stack
    /// and helper methods for configuring the environment's Terraform infrastructure.
    /// </summary>
    /// <remarks>
    /// This is the same resource passed to callbacks when using <c>PublishAsTerraform</c> on the environment itself.
    /// The <see cref="TerraformProvisioningResource.Stack"/> contains the root Terraform blocks (providers, outputs, etc.).
    /// </remarks>
    public TerraformProvisioningResource TerraformResource { get; }

    /// <summary>
    /// Gets or sets the Terraform workspace name.
    /// </summary>
    public string? WorkspaceName { get; set; }

    /// <summary>
    /// Gets or sets the Terraform version to use.
    /// </summary>
    public string? TerraformVersion { get; set; }

    /// <summary>
    /// Gets or sets the output path for generated Terraform files relative to the publish output directory.
    /// </summary>
    public string? OutputPath { get; set; }

    /// <summary>
    /// Gets or sets whether to automatically run terraform init during publishing.
    /// </summary>
    public bool AutoInit { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to automatically run terraform plan during publishing.
    /// </summary>
    public bool AutoPlan { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to automatically run terraform apply during publishing.
    /// </summary>
    public bool AutoApply { get; set; } = true;

    /// <summary>
    /// Gets the collection of parameter resources that have been registered as Terraform variables.
    /// This dictionary maps ParameterResource instances to their corresponding TerraformVariable definitions.
    /// </summary>
    /// <remarks>
    /// Parameters are registered when <see cref="TerraformProvisioningResource.AddVariable(ParameterResource, string?)"/> is called.
    /// During plan/apply, these parameters are resolved and passed to Terraform via tfvars (non-sensitive)
    /// or TF_VAR_* environment variables (sensitive).
    /// </remarks>
    internal Dictionary<ParameterResource, TerraformVariable> ParameterVariables { get; } = new();

    /// <summary>
    /// Gets the container registry associated with this environment, if any.
    /// </summary>
    /// <remarks>
    /// When set, the environment's plan step will depend on the registry's login step,
    /// ensuring the registry is provisioned and authenticated before deployment.
    /// </remarks>
    internal TerraformContainerRegistryResource? ContainerRegistry { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform environment.</param>
    public TerraformEnvironmentResource(string name) : base(name)
    {
        // Create the TerraformResource for this environment (it references itself as the target)
        TerraformResource = new TerraformProvisioningResource(name, this, this);

        // Add pipeline step annotation to create steps and expand deployment target steps
        Annotations.Add(new PipelineStepAnnotation(async (factoryContext) =>
        {
            var model = factoryContext.PipelineContext.Model;
            var steps = new List<PipelineStep>();

            // Add the publish step that generates Terraform files
            var publishStep = new PipelineStep
            {
                Name = $"publish-terraform-{Name}",
                Action = ctx => PublishAsync(ctx),
                Tags = ["publish-terraform"],
                RequiredBySteps = [WellKnownPipelineSteps.Publish, WellKnownPipelineSteps.Deploy]
            };
            steps.Add(publishStep);

            // Optionally add terraform init step
            if (AutoInit)
            {
                var initStep = new PipelineStep
                {
                    Name = $"terraform-init-{Name}",
                    Action = ctx => RunTerraformCommandAsync(ctx, "init -input=false -no-color"),
                    Tags = ["terraform-init"],
                    DependsOnSteps = [publishStep.Name],
                    RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                };
                steps.Add(initStep);

                // Optionally add terraform plan step
                if (AutoPlan)
                {
                    // Build dependencies for plan step - if there's a registry, depend on its login step
                    var planDependencies = new List<string> { initStep.Name, WellKnownPipelineSteps.DeployPrereq };
                    if (ContainerRegistry is not null)
                    {
                        // The environment's plan step must wait for the registry's login step to complete
                        planDependencies.Add($"login-registry-{ContainerRegistry.Name}");
                    }

                    var planStep = new PipelineStep
                    {
                        Name = $"terraform-plan-{Name}",
                        Action = async ctx =>
                        {
                            var sensitiveEnvVars = await ResolveAndWriteVariablesAsync(ctx).ConfigureAwait(false);
                            await RunTerraformCommandAsync(ctx, "plan -out=aspire.tfplan -input=false -no-color", sensitiveEnvVars).ConfigureAwait(false);
                        },
                        Tags = ["terraform-plan"],
                        DependsOnSteps = [.. planDependencies],
                        RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                    };
                    steps.Add(planStep);

                    // Optionally add terraform apply step
                    if (AutoApply)
                    {
                        var applyStep = new PipelineStep
                        {
                            Name = $"terraform-apply-{Name}",
                            Action = async ctx =>
                            {
                                var sensitiveEnvVars = await ResolveAndWriteVariablesAsync(ctx).ConfigureAwait(false);
                                await RunTerraformCommandAsync(ctx, "apply -auto-approve -input=false -no-color aspire.tfplan", sensitiveEnvVars).ConfigureAwait(false);
                            },
                            Tags = ["terraform-apply", WellKnownPipelineTags.ProvisionInfrastructure],
                            DependsOnSteps = [planStep.Name, WellKnownPipelineSteps.DeployPrereq],
                            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                        };
                        steps.Add(applyStep);
                    }
                }
            }

            // Expand deployment target steps for all compute resources
            // This ensures the push/provision steps from deployment targets are included in the pipeline
            foreach (var computeResource in model.GetComputeResources())
            {
                var deploymentTarget = computeResource.GetDeploymentTargetAnnotation(this)?.DeploymentTarget;

                if (deploymentTarget is not null && deploymentTarget.TryGetAnnotationsOfType<PipelineStepAnnotation>(out var annotations))
                {
                    // Resolve the deployment target's PipelineStepAnnotation and expand its steps
                    // We do this because the deployment target is not in the model
                    foreach (var annotation in annotations)
                    {
                        var childFactoryContext = new PipelineStepFactoryContext
                        {
                            PipelineContext = factoryContext.PipelineContext,
                            Resource = deploymentTarget
                        };

                        var deploymentTargetSteps = await annotation.CreateStepsAsync(childFactoryContext).ConfigureAwait(false);

                        foreach (var step in deploymentTargetSteps)
                        {
                            // Ensure the step is associated with the deployment target resource
                            step.Resource ??= deploymentTarget;
                        }

                        steps.AddRange(deploymentTargetSteps);
                    }
                }
            }

            return steps;
        }));

        // Add pipeline configuration annotation to wire up dependencies
        Annotations.Add(new PipelineConfigurationAnnotation(context =>
        {
            // Wire up build step dependencies for compute resources
            foreach (var computeResource in context.Model.GetComputeResources())
            {
                var deploymentTarget = computeResource.GetDeploymentTargetAnnotation(this)?.DeploymentTarget;

                if (deploymentTarget is null)
                {
                    continue;
                }

                // Execute the PipelineConfigurationAnnotation callbacks on the deployment target
                if (deploymentTarget.TryGetAnnotationsOfType<PipelineConfigurationAnnotation>(out var annotations))
                {
                    foreach (var annotation in annotations)
                    {
                        annotation.Callback(context);
                    }
                }
            }

            // Ensure build resources are wired up for deployment
            foreach (var computeResource in context.Model.GetBuildResources())
            {
                context.GetSteps(computeResource, WellKnownPipelineTags.BuildCompute)
                    .RequiredBy(WellKnownPipelineSteps.Deploy)
                    .DependsOn(WellKnownPipelineSteps.DeployPrereq);
            }
        }));
    }

    /// <summary>
    /// Computes the host URL <see cref="ReferenceExpression"/> for the given <see cref="EndpointReference"/>.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to compute the host address for.</param>
    /// <returns>A <see cref="ReferenceExpression"/> representing the host address.</returns>
    ReferenceExpression IComputeEnvironmentResource.GetHostAddressExpression(EndpointReference endpointReference)
    {
        var resource = endpointReference.Resource;

        // For Terraform, we'll use the resource name as a placeholder
        // This can be customized based on the actual Terraform output
        return ReferenceExpression.Create($"{resource.Name}");
    }

    private Task PublishAsync(PipelineStepContext context)
    {
        // Get the correct output path using the pipeline output service
        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);

        var terraformContext = new TerraformPublishingContext(
            context,
            context.ExecutionContext,
            outputPath,
            context.Logger,
            this,
            context.CancellationToken);

        return terraformContext.WriteModelAsync(context.Model, this);
    }

    private async Task RunTerraformCommandAsync(
        PipelineStepContext context,
        string command,
        Dictionary<string, string>? sensitiveEnvironmentVariables = null)
    {
        // Get the correct output path using the pipeline output service
        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);

        if (!Directory.Exists(outputPath))
        {
            throw new InvalidOperationException($"Terraform configuration directory does not exist: {outputPath}");
        }

        context.Logger.LogInformation("Running terraform {Command} in {Path}", command, outputPath);

        await context.ReportingStep.CompleteAsync(
            $"Running terraform {command}",
            CompletionState.InProgress,
            context.CancellationToken).ConfigureAwait(false);

        var processStartInfo = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "terraform",
            Arguments = command,
            WorkingDirectory = outputPath,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            // Set TF_IN_AUTOMATION to suppress "next step" suggestions
            Environment = { ["TF_IN_AUTOMATION"] = "true" }
        };

        // Add sensitive variables as TF_VAR_* environment variables
        if (sensitiveEnvironmentVariables is not null)
        {
            foreach (var (varName, varValue) in sensitiveEnvironmentVariables)
            {
                processStartInfo.Environment[$"TF_VAR_{varName}"] = varValue;
            }
        }

        using var process = new System.Diagnostics.Process { StartInfo = processStartInfo };

        process.Start();

        // Read output asynchronously to prevent deadlocks
        var outputTask = process.StandardOutput.ReadToEndAsync(context.CancellationToken);
        var errorTask = process.StandardError.ReadToEndAsync(context.CancellationToken);

        await process.WaitForExitAsync(context.CancellationToken).ConfigureAwait(false);

        var output = await outputTask.ConfigureAwait(false);
        var error = await errorTask.ConfigureAwait(false);

        if (!string.IsNullOrWhiteSpace(output))
        {
            context.Logger.LogInformation("Terraform output: {Output}", output);
        }

        if (!string.IsNullOrWhiteSpace(error))
        {
            context.Logger.LogWarning("Terraform stderr: {Error}", error);
        }

        if (process.ExitCode != 0)
        {
            await context.ReportingStep.CompleteAsync(
                $"Terraform '{command}' failed with exit code {process.ExitCode}",
                CompletionState.CompletedWithError,
                context.CancellationToken).ConfigureAwait(false);

            throw new InvalidOperationException($"Terraform '{command}' failed with exit code {process.ExitCode}. Error: {error}");
        }

        await context.ReportingStep.CompleteAsync(
            $"Terraform '{command}' completed successfully",
            CompletionState.Completed,
            context.CancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Resolves parameter values and output references, writing non-sensitive values to aspire.auto.tfvars.
    /// Returns sensitive values as a dictionary to be passed as TF_VAR_* environment variables.
    /// </summary>
    private async Task<Dictionary<string, string>> ResolveAndWriteVariablesAsync(PipelineStepContext context)
    {
        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);
        var sensitiveVars = new Dictionary<string, string>();
        var nonSensitiveVars = new List<(string Name, string Value)>();

        // Resolve Aspire parameter values
        if (ParameterVariables.Count > 0)
        {
            context.Logger.LogInformation("Resolving {Count} Terraform parameter variables", ParameterVariables.Count);

            // Parameters are initialized by DeployPrereq step (which runs before our terraform steps)
            // via ParameterProcessor.InitializeParametersAsync - we just need to get the values here

            foreach (var (parameter, variable) in ParameterVariables)
            {
                // Parameters should already be resolved by DeployPrereq step
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
                    // Sensitive values go to TF_VAR_* environment variables
                    sensitiveVars[variable.Name] = value;
                    context.Logger.LogDebug("Sensitive variable '{VariableName}' will be passed via TF_VAR_* environment variable", variable.Name);
                }
                else
                {
                    // Non-sensitive values go to aspire.auto.tfvars
                    nonSensitiveVars.Add((variable.Name, value));
                    context.Logger.LogDebug("Variable '{VariableName}' will be written to aspire.auto.tfvars", variable.Name);
                }
            }
        }

        // Collect all inputs from the environment's TerraformResource and all compute resources
        // Use a dictionary to avoid duplicates (same variable can be referenced from multiple places)
        var allInputs = new Dictionary<string, object>();

        // Add environment-level inputs
        foreach (var (inputName, inputValue) in TerraformResource.Inputs)
        {
            allInputs[inputName] = inputValue;
        }

        // Add inputs from all compute resources that are deployed to this environment
        foreach (var computeResource in context.Model.GetComputeResources())
        {
            if (computeResource.GetDeploymentTargetAnnotation(this)?.DeploymentTarget is TerraformProvisioningResource terraformResource)
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

        // Resolve all collected inputs
        foreach (var (inputName, inputValue) in allInputs)
        {
            if (inputValue is TerraformOutputReference outputRef)
            {
                // Skip output references to the environment itself - these are wired up at publish time
                // as direct references to root module outputs, not runtime values
                if (outputRef.Resource == this)
                {
                    context.Logger.LogDebug(
                        "Skipping output reference '{OutputName}' - environment outputs are wired at publish time",
                        outputRef.Name);
                    continue;
                }

                // Skip output references to other modules - these are wired up at publish time
                // as module.{name}.{output} references
                if (outputRef.Resource is not TerraformContainerRegistryResource)
                {
                    context.Logger.LogDebug(
                        "Skipping output reference '{ResourceName}.{OutputName}' - module outputs are wired at publish time",
                        outputRef.Resource.Name, outputRef.Name);
                    continue;
                }

                // Container registry outputs need runtime resolution (separate state)
                var value = outputRef.Value;
                if (string.IsNullOrEmpty(value))
                {
                    context.Logger.LogWarning(
                        "Output reference '{ResourceName}.{OutputName}' (variable '{VariableName}') has no value. " +
                        "Ensure the source resource has been applied and outputs read.",
                        outputRef.Resource.Name, outputRef.Name, inputName);
                    continue;
                }

                if (outputRef.Sensitive)
                {
                    // Sensitive values go to TF_VAR_* environment variables
                    sensitiveVars[inputName] = value;
                    context.Logger.LogDebug("Sensitive output reference '{VariableName}' will be passed via TF_VAR_* environment variable", inputName);
                }
                else
                {
                    // Non-sensitive values go to aspire.auto.tfvars
                    nonSensitiveVars.Add((inputName, value));
                    context.Logger.LogDebug("Output reference '{VariableName}' will be written to aspire.auto.tfvars", inputName);
                }
            }
            else if (inputValue is ContainerImageReference imageRef)
            {
                // Resolve the container image reference (includes registry, name, and tag)
                var provider = imageRef as IValueProvider;
                var value = await provider.GetValueAsync(context.CancellationToken).ConfigureAwait(false);
                if (string.IsNullOrEmpty(value))
                {
                    context.Logger.LogWarning(
                        "Container image reference for '{ResourceName}' (variable '{VariableName}') has no value. " +
                        "Ensure the image has been built and pushed.",
                        imageRef.Resource.Name, inputName);
                    continue;
                }

                // Container images are not sensitive
                nonSensitiveVars.Add((inputName, value));
                context.Logger.LogDebug("Container image '{VariableName}' = '{Value}' will be written to aspire.auto.tfvars", inputName, value);
            }
        }

        // Write non-sensitive values to aspire.auto.tfvars in HCL format
        if (nonSensitiveVars.Count > 0)
        {
            var tfvarsPath = Path.Combine(outputPath, "aspire.auto.tfvars");
            await using var writer = new StreamWriter(tfvarsPath, append: false);

            await writer.WriteLineAsync("# Auto-generated by Aspire Terraform publishing").ConfigureAwait(false);
            await writer.WriteLineAsync($"# Generated at {DateTime.UtcNow:O}").ConfigureAwait(false);
            await writer.WriteLineAsync().ConfigureAwait(false);

            // Use TerraformArgumentNode for consistent HCL formatting
            var hclContext = TerraformContext.Temporary();
            foreach (var (name, value) in nonSensitiveVars)
            {
                var argumentNode = new TerraformArgumentNode(name, TerraformExpression.Literal(value));
                await writer.WriteLineAsync(argumentNode.ToHcl(hclContext)).ConfigureAwait(false);
            }

            context.Logger.LogInformation("Wrote {Count} variables to {Path}", nonSensitiveVars.Count, tfvarsPath);
        }

        return sensitiveVars;
    }
}
