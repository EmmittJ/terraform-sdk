// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for publishing project resources as Terraform infrastructure.
/// </summary>
public static class TerraformProjectExtensions
{
    /// <summary>
    /// Publishes the specified project resource as Terraform infrastructure.
    /// </summary>
    /// <typeparam name="T">The type of the project resource.</typeparam>
    /// <param name="builder">The project resource builder.</param>
    /// <param name="configure">The configuration action for customizing the Terraform infrastructure.</param>
    /// <returns>The updated project resource builder.</returns>
    /// <remarks>
    /// This method checks if the application is in publish mode. If it is, it adds the necessary infrastructure
    /// for Terraform and applies the provided configuration action to customize the Terraform stack.
    /// <example>
    /// <code>
    /// var builder = DistributedApplication.CreateBuilder(args);
    ///
    /// var terraform = builder.AddTerraformEnvironment("azure");
    ///
    /// builder.AddProject&lt;Projects.Api&gt;("api")
    ///     .PublishAsTerraform((stack, resource) =>
    ///     {
    ///         // Configure the Terraform infrastructure here
    ///         // stack - the Terraform stack to add resources to
    ///         // resource - the Aspire resource being published
    ///     });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<T> PublishAsTerraform<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformStack, IResource> configure)
        where T : ProjectResource
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
