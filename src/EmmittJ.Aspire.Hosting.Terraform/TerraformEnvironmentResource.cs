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
    /// Gets or sets the Terraform workspace name.
    /// </summary>
    public string? WorkspaceName { get; set; }

    /// <summary>
    /// Gets or sets the Terraform version to use.
    /// </summary>
    public string? TerraformVersion { get; set; }

    /// <summary>
    /// Gets or sets the Terraform settings including backend configuration, required providers, and other global settings.
    /// </summary>
    public TerraformSettingsBlock? Settings { get; set; }

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
    public bool AutoApply { get; set; } = false;

    /// <summary>
    /// Gets the collection of parameter resources that have been registered as Terraform variables.
    /// This dictionary maps ParameterResource instances to their corresponding TerraformVariable definitions.
    /// </summary>
    /// <remarks>
    /// Parameters are registered when <see cref="TerraformProvisioningExtensions.AsVariable(ParameterResource, TerraformResourceInfrastructure, string?)"/> is called.
    /// During plan/apply, these parameters are resolved and passed to Terraform via tfvars (non-sensitive)
    /// or TF_VAR_* environment variables (sensitive).
    /// </remarks>
    internal Dictionary<ParameterResource, TerraformVariable> ParameterVariables { get; } = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform environment.</param>
    public TerraformEnvironmentResource(string name) : base(name)
    {
        Annotations.Add(new PipelineStepAnnotation(context =>
        {
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
            if (!AutoInit)
            {
                return steps;
            }

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
            if (!AutoPlan)
            {
                return steps;
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
                DependsOnSteps = [initStep.Name, WellKnownPipelineSteps.DeployPrereq],
                RequiredBySteps = [WellKnownPipelineSteps.Deploy]
            };
            steps.Add(planStep);

            // Optionally add terraform apply step
            if (!AutoApply)
            {
                return steps;
            }
            var applyStep = new PipelineStep
            {
                Name = $"terraform-apply-{Name}",
                Action = async ctx =>
                {
                    var sensitiveEnvVars = await ResolveAndWriteVariablesAsync(ctx).ConfigureAwait(false);
                    await RunTerraformCommandAsync(ctx, "apply -auto-approve -input=false -no-color aspire.tfplan", sensitiveEnvVars).ConfigureAwait(false);
                },
                Tags = ["terraform-apply"],
                DependsOnSteps = [planStep.Name, WellKnownPipelineSteps.DeployPrereq],
                RequiredBySteps = [WellKnownPipelineSteps.Deploy]
            };
            steps.Add(applyStep);

            return steps;
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
    /// Resolves parameter values and writes non-sensitive values to aspire.auto.tfvars.
    /// Returns sensitive values as a dictionary to be passed as TF_VAR_* environment variables.
    /// </summary>
    private async Task<Dictionary<string, string>> ResolveAndWriteVariablesAsync(PipelineStepContext context)
    {
        if (ParameterVariables.Count == 0)
        {
            return new Dictionary<string, string>();
        }

        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);
        var sensitiveVars = new Dictionary<string, string>();
        var nonSensitiveVars = new List<(string Name, string Value)>();

        context.Logger.LogInformation("Resolving {Count} Terraform variables", ParameterVariables.Count);

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
