// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for customizing Terraform resource publishing.
/// </summary>
public static class TerraformExtensions
{
    /// <summary>
    /// Publishes the specified resource as Terraform infrastructure.
    /// </summary>
    /// <typeparam name="T">The type of the resource.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">The configuration action for customizing the Terraform infrastructure.</param>
    /// <returns>The updated resource builder.</returns>
    /// <remarks>
    /// This method checks if the application is in publish mode. If it is, it adds the necessary infrastructure
    /// for Terraform and applies the provided configuration action to customize the Terraform stack.
    /// <example>
    /// <code>
    /// var builder = DistributedApplication.CreateBuilder(args);
    ///
    /// var terraform = builder.AddTerraformEnvironment("azure");
    ///
    /// builder.AddResource(myResource)
    ///     .PublishAsTerraform((infrastructure, resource) =>
    ///     {
    ///         // Configure the Terraform infrastructure here
    ///     });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<T> PublishAsTerraform<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformResourceInfrastructure> configure)
        where T : IResource
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
                GetTerraformEnvironment(builder));
            configure(infrastructure);
        }));

        return builder;
    }

    /// <summary>
    /// Publishes the specified resource as Terraform infrastructure with access to the stack and resource.
    /// </summary>
    /// <typeparam name="T">The type of the resource.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">The configuration action for customizing the Terraform stack and resource.</param>
    /// <returns>The updated resource builder.</returns>
    /// <remarks>
    /// This overload provides direct access to the Terraform stack and Aspire resource for advanced scenarios.
    /// <example>
    /// <code>
    /// builder.AddResource(myResource)
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
        where T : IResource
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

    /// <summary>
    /// Gets the Terraform environment resource from the application model.
    /// </summary>
    /// <typeparam name="T">The type of the resource.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <returns>The Terraform environment resource.</returns>
    /// <exception cref="InvalidOperationException">Thrown when no Terraform environment is found.</exception>
    internal static TerraformEnvironmentResource GetTerraformEnvironment<T>(IResourceBuilder<T> builder)
        where T : IResource
    {
        // Find the Terraform environment from the application model
        var environment = builder.ApplicationBuilder.Resources
            .OfType<TerraformEnvironmentResource>()
            .FirstOrDefault();

        if (environment == null)
        {
            throw new InvalidOperationException(
                "No Terraform environment found. Call AddTerraformEnvironment() on the application builder before using PublishAsTerraform().");
        }

        return environment;
    }
}
