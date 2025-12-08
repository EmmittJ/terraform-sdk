// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;
using Microsoft.Extensions.DependencyInjection;

namespace TerraformPlayground.AppHost;

/// <summary>
/// Extension methods for configuring Terraform Azure Container Apps environment resources.
/// </summary>
public static class TerraformAzureContainerAppEnvironmentExtensions
{
    /// <summary>
    /// Adds a Terraform-managed Azure Container Apps environment to the distributed application.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the environment resource.</param>
    /// <returns>A resource builder for the Azure Container Apps environment.</returns>
    /// <remarks>
    /// <para>
    /// This creates a two-stage Terraform deployment:
    /// <list type="number">
    /// <item>Stage 1: Container Registry - provisions ACR for image storage (separate state)</item>
    /// <item>Stage 2: Environment - provisions Log Analytics, Managed Identity, Role Assignment, and Container App Environment</item>
    /// </list>
    /// </para>
    /// <para>
    /// You must configure the environment with <c>.WithSubscriptionId()</c> and <c>.WithLocation()</c> before publishing.
    /// </para>
    /// </remarks>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> AddTerraformAzureContainerAppEnvironment(
        this IDistributedApplicationBuilder builder,
        string name)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(name);

        builder.Services.TryAddEventingSubscriber<TerraformCloudInfrastructure<TerraformAzureContainerAppEnvironmentResource>>();

        var resource = new TerraformAzureContainerAppEnvironmentResource(name);

        if (builder.ExecutionContext.IsRunMode)
        {
            return builder.CreateResourceBuilder(resource);
        }

        return builder.AddResource(resource);
    }

    /// <summary>
    /// Configures the Azure subscription ID for the environment.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="subscriptionId">The subscription ID parameter.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithSubscriptionId(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        ParameterResource subscriptionId)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(subscriptionId);

        builder.Resource.SubscriptionIdParameter = subscriptionId;
        return builder;
    }

    /// <summary>
    /// Configures the Azure subscription ID for the environment.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="subscriptionId">The subscription ID parameter builder.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithSubscriptionId(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        IResourceBuilder<ParameterResource> subscriptionId)
    {
        return builder.WithSubscriptionId(subscriptionId.Resource);
    }

    /// <summary>
    /// Configures the Azure tenant ID for the environment.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="tenantId">The tenant ID parameter.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithTenantId(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        ParameterResource tenantId)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(tenantId);

        builder.Resource.TenantIdParameter = tenantId;
        return builder;
    }

    /// <summary>
    /// Configures the Azure tenant ID for the environment.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="tenantId">The tenant ID parameter builder.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithTenantId(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        IResourceBuilder<ParameterResource> tenantId)
    {
        return builder.WithTenantId(tenantId.Resource);
    }

    /// <summary>
    /// Configures the Azure location (region) for the environment.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="location">The Azure location string (e.g., "westus2").</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithLocation(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        string location)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(location);

        builder.Resource.Location = location;
        return builder;
    }

    /// <summary>
    /// Configures the Azure location (region) for the environment using a parameter.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="location">The location parameter.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithLocation(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        ParameterResource location)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(location);

        builder.Resource.LocationParameter = location;
        return builder;
    }

    /// <summary>
    /// Configures the Azure location (region) for the environment using a parameter builder.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="location">The location parameter builder.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithLocation(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        IResourceBuilder<ParameterResource> location)
    {
        return builder.WithLocation(location.Resource);
    }

    /// <summary>
    /// Configures the Terraform backend for the environment's state storage.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="backendType">The backend type (e.g., "local", "azurerm", "s3").</param>
    /// <param name="configure">Optional callback to configure the backend block.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> WithBackend(
        this IResourceBuilder<TerraformAzureContainerAppEnvironmentResource> builder,
        string backendType,
        Action<TerraformBackendBlock>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(backendType);

        builder.Resource.BackendType = backendType;
        builder.Resource.ConfigureBackend = configure;
        return builder;
    }

    /// <summary>
    /// Publishes a compute resource as a Terraform-managed Azure Container App with customization.
    /// </summary>
    /// <typeparam name="T">The resource type.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">The callback to customize the container app.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<T> PublishAsTerraformContainerApp<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformProvisioningResource, AzurermContainerApp> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        builder.WithAnnotation(new TerraformAzureContainerAppCustomizationAnnotation(configure));
        return builder;
    }
}
