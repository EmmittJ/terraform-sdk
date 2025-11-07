// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform infrastructure provisioning to Aspire resources.
/// </summary>
public static class TerraformBuilderExtensions
{
    /// <summary>
    /// Adds Terraform infrastructure provisioning for the specified resource.
    /// This method generates Terraform HCL code during the publish phase.
    /// </summary>
    /// <typeparam name="T">The type of the resource.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">The configuration action for the Terraform stack.</param>
    /// <returns>The updated resource builder.</returns>
    /// <remarks>
    /// <para>
    /// This method provisions infrastructure similar to Azure Bicep resources,
    /// but is not a compute environment like Kubernetes or Azure Container Apps.
    /// </para>
    /// <para>
    /// Multiple calls to this method on the same resource will add multiple Terraform stacks,
    /// each generating a separate Terraform file during publish.
    /// </para>
    /// <example>
    /// <code>
    /// builder.AddProject&lt;Projects.Api&gt;("api").WithTerraform(stack =>
    /// {
    ///     // Configure Terraform infrastructure here
    ///     var bucket = new S3Bucket("api-storage");
    ///     stack.Add(bucket);
    /// });
    /// </code>
    /// </example>
    /// </remarks>
#pragma warning disable ASPIREPIPELINES001 // Type is for evaluation purposes only and is subject to change or removal in future updates
    [Experimental("ASPIREPIPELINES001", UrlFormat = "https://aka.ms/aspire/diagnostics/{0}")]
    public static IResourceBuilder<T> WithTerraform<T>(
#pragma warning restore ASPIREPIPELINES001
        this IResourceBuilder<T> builder,
        Action<TerraformStack> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        if (!builder.ApplicationBuilder.ExecutionContext.IsPublishMode)
        {
            return builder;
        }

        // Add the Terraform stack configuration annotation
        builder.WithAnnotation(new TerraformStackAnnotation(configure));

        // Add pipeline step annotation only once per resource
        // The pipeline step will process all TerraformStackAnnotation instances on the resource
        if (!builder.Resource.Annotations.OfType<TerraformPipelineStepMarkerAnnotation>().Any())
        {
            builder.WithAnnotation(new TerraformPipelineStepMarkerAnnotation());
#pragma warning disable ASPIREPIPELINES001
            builder.WithAnnotation(new PipelineStepAnnotation(TerraformPipelineStepFactory.CreateTerraformGenerationSteps));
#pragma warning restore ASPIREPIPELINES001
        }

        return builder;
    }

    /// <summary>
    /// Configures Terraform generation settings for a resource.
    /// </summary>
    /// <typeparam name="T">The resource type.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">An action to configure the Terraform settings.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<T> WithTerraformConfiguration<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformConfigurationAnnotation> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        var annotation = builder.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        if (annotation is null)
        {
            annotation = new TerraformConfigurationAnnotation();
            builder.WithAnnotation(annotation);
        }

        configure(annotation);
        return builder;
    }
}
