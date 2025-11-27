// Licensed under the MIT License.

using System.Diagnostics;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
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
    ///     .PublishAsTerraform(infra =>
    ///     {
    ///         // Configure the Terraform infrastructure here
    ///         // infra.Stack - the Terraform stack to add resources to
    ///         // infra.Resource - the Aspire resource being published
    ///
    ///         // Reference outputs from other resources
    ///         var redisHost = infra.AddVariable(redisResource.HostnameOutput);
    ///
    ///         var container = new AzurermContainerApp("api")
    ///         {
    ///             EnvironmentVariables = new() { ["REDIS_HOST"] = redisHost }
    ///         };
    ///         infra.Add(container);
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
        builder.WithAnnotation(new TerraformCustomizationAnnotation(configure));

        return builder;
    }
}
