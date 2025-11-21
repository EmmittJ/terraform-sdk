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
                Tags = ["publish-terraform"]
            };
            publishStep.RequiredBy(WellKnownPipelineSteps.Publish);
            steps.Add(publishStep);

            // Optionally add terraform init step
            if (AutoInit)
            {
                var initStep = new PipelineStep
                {
                    Name = $"terraform-init-{Name}",
                    Action = ctx => RunTerraformCommandAsync(ctx, "init"),
                    Tags = ["terraform-init"],
                    DependsOnSteps = [publishStep.Name]
                };
                steps.Add(initStep);

                // Optionally add terraform plan step
                if (AutoPlan)
                {
                    var planStep = new PipelineStep
                    {
                        Name = $"terraform-plan-{Name}",
                        Action = ctx => RunTerraformCommandAsync(ctx, "plan"),
                        Tags = ["terraform-plan"],
                        DependsOnSteps = [initStep.Name]
                    };
                    steps.Add(planStep);

                    // Optionally add terraform apply step
                    if (AutoApply)
                    {
                        var applyStep = new PipelineStep
                        {
                            Name = $"terraform-apply-{Name}",
                            Action = ctx => RunTerraformCommandAsync(ctx, "apply -auto-approve"),
                            Tags = ["terraform-apply"],
                            DependsOnSteps = [planStep.Name]
                        };
                        steps.Add(applyStep);
                    }
                }
            }

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

    private async Task RunTerraformCommandAsync(PipelineStepContext context, string command)
    {
        // Get the correct output path using the pipeline output service
        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);

        context.Logger.LogInformation("Running terraform {Command} in {Path}", command, outputPath);

        var workingDirectory = Directory.Exists(outputPath) ? outputPath : Environment.CurrentDirectory;

        await context.ReportingStep.CompleteAsync(
            $"Running terraform {command}",
            CompletionState.InProgress,
            context.CancellationToken).ConfigureAwait(false);

        // Note: In a real implementation, you would execute the terraform CLI here
        // For now, we just log the intent
        context.Logger.LogInformation("Terraform {Command} would be executed in {Directory}", command, workingDirectory);

        await context.ReportingStep.CompleteAsync(
            $"Terraform {command} completed",
            CompletionState.Completed,
            context.CancellationToken).ConfigureAwait(false);
    }
}
