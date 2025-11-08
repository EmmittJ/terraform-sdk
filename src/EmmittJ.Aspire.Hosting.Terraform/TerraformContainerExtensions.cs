// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for publishing container resources as Terraform infrastructure.
/// </summary>
public static class TerraformContainerExtensions
{
    /// <summary>
    /// Publishes the specified container resource as Terraform infrastructure.
    /// </summary>
    /// <typeparam name="T">The type of the container resource.</typeparam>
    /// <param name="builder">The container resource builder.</param>
    /// <param name="configure">The configuration action for customizing the Terraform infrastructure.</param>
    /// <returns>The updated container resource builder.</returns>
    /// <remarks>
    /// This method checks if the application is in publish mode. If it is, it adds the necessary infrastructure
    /// for Terraform and applies the provided configuration action to customize the Terraform stack.
    /// <example>
    /// <code>
    /// var builder = DistributedApplication.CreateBuilder(args);
    ///
    /// var terraform = builder.AddTerraformEnvironment("azure");
    ///
    /// builder.AddContainer("nginx", "nginx")
    ///     .PublishAsTerraform((infrastructure) =>
    ///     {
    ///         // Configure the Terraform infrastructure here
    ///         // Access infrastructure.Stack, infrastructure.Resource, infrastructure.Environment
    ///     });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<T> PublishAsTerraform<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformResourceInfrastructure> configure)
        where T : ContainerResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        if (!builder.ApplicationBuilder.ExecutionContext.IsPublishMode)
        {
            return builder;
        }

        builder.ApplicationBuilder.AddTerraformInfrastructureCore();

        builder.WithAnnotation(new TerraformCustomizationAnnotation((stack, resource) =>
        {
            var infrastructure = new TerraformResourceInfrastructure(
                resource,
                stack,
                TerraformExtensions.GetTerraformEnvironment(builder));
            configure(infrastructure);
        }));

        return builder;
    }

    /// <summary>
    /// Publishes the specified container resource as Terraform infrastructure with access to the stack and resource.
    /// </summary>
    /// <typeparam name="T">The type of the container resource.</typeparam>
    /// <param name="builder">The container resource builder.</param>
    /// <param name="configure">The configuration action for customizing the Terraform stack and resource.</param>
    /// <returns>The updated container resource builder.</returns>
    /// <remarks>
    /// This overload provides direct access to the Terraform stack and Aspire resource for advanced scenarios.
    /// <example>
    /// <code>
    /// builder.AddContainer("nginx", "nginx")
    ///     .PublishAsTerraform((stack, resource) =>
    ///     {
    ///         // Direct access to stack and resource
    ///     });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<T> PublishAsTerraform<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformStack, IResource> configure)
        where T : ContainerResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        if (!builder.ApplicationBuilder.ExecutionContext.IsPublishMode)
        {
            return builder;
        }

        builder.ApplicationBuilder.AddTerraformInfrastructureCore();

        builder.WithAnnotation(new TerraformCustomizationAnnotation(configure));

        return builder;
    }
}
