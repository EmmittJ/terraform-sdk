// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform code generation to Aspire resources.
/// </summary>
public static class TerraformBuilderExtensions
{
    /// <summary>
    /// Publishes the specified compute resource as Terraform infrastructure.
    /// </summary>
    /// <typeparam name="T">The type of the compute resource.</typeparam>
    /// <param name="builder">The compute resource builder.</param>
    /// <param name="configure">The configuration action for the Terraform stack.</param>
    /// <returns>The updated compute resource builder.</returns>
    /// <remarks>
    /// This method checks if the application is in publish mode. If it is, it adds the necessary
    /// infrastructure for Terraform generation and applies the provided configuration action.
    /// <example>
    /// <code>
    /// builder.AddProject&lt;Projects.Api&gt;("api").PublishAsTerraform(stack =>
    /// {
    ///     // Configure Terraform infrastructure here
    ///     var bucket = new S3Bucket("api-storage");
    ///     stack.Add(bucket);
    /// });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<T> PublishAsTerraform<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformStack> configure)
        where T : IComputeResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        if (!builder.ApplicationBuilder.ExecutionContext.IsPublishMode)
        {
            return builder;
        }

        builder.ApplicationBuilder.AddTerraformInfrastructureCore();

        return builder.WithAnnotation(new TerraformStackAnnotation(configure));
    }

    /// <summary>
    /// Configures Terraform generation settings for a compute resource.
    /// </summary>
    /// <typeparam name="T">The compute resource type.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">An action to configure the Terraform settings.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<T> WithTerraformConfiguration<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformConfigurationAnnotation> configure)
        where T : IComputeResource
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

    internal static IDistributedApplicationBuilder AddTerraformInfrastructureCore(this IDistributedApplicationBuilder builder)
    {
        builder.Services.TryAddEventingSubscriber<TerraformEventingSubscriber>();
        return builder;
    }
}
