// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform infrastructure provisioning to Aspire resources.
/// </summary>
public static class TerraformBuilderExtensions
{
    /// <summary>
    /// Adds a Terraform customization to a resource.
    /// This allows you to customize how the resource is represented in Terraform configuration.
    /// </summary>
    /// <typeparam name="T">The type of the resource.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">The configuration action for customizing the Terraform stack.</param>
    /// <returns>The updated resource builder.</returns>
    /// <remarks>
    /// <para>
    /// This method adds a customization annotation that will be invoked during Terraform generation
    /// when the resource is deployed to a Terraform environment.
    /// </para>
    /// <para>
    /// Multiple calls to this method on the same resource will add multiple customizations,
    /// which will all be applied during generation.
    /// </para>
    /// <example>
    /// <code>
    /// var builder = DistributedApplication.CreateBuilder(args);
    ///
    /// var terraform = builder.AddTerraformEnvironment("terraform")
    ///     .WithBackend("s3", config =>
    ///     {
    ///         config["bucket"] = "my-terraform-state";
    ///         config["region"] = "us-west-2";
    ///     });
    ///
    /// builder.AddProject&lt;Projects.Api&gt;("api")
    ///     .WithTerraformCustomization((stack, resource) =>
    ///     {
    ///         // Add S3 bucket for the API
    ///         // stack.AddResource(...);
    ///     });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<T> WithTerraformCustomization<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformStack, IResource> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        builder.WithAnnotation(new TerraformCustomizationAnnotation(configure));

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
