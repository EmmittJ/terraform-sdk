#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Terraform.Sdk.AppHost.Pipeline;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Extension methods for configuring Terraform code generation in Aspire.
/// </summary>
public static class TerraformCodeGenHostingExtensions
{
    /// <summary>
    /// Enables Terraform code generation pipeline integration.
    /// This should be called during AppHost setup to register the pipeline hooks.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <returns>The builder for chaining.</returns>
    public static IDistributedApplicationBuilder AddTerraformCodeGenPipeline(
        this IDistributedApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        // Register the eventing subscriber that adds pipeline steps
        builder.Services.AddEventingSubscriber<TerraformCodeGenPipelineHook>();

        return builder;
    }
}
