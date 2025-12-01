// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding and configuring <see cref="TerraformContainerRegistryResource"/>.
/// </summary>
public static class TerraformContainerRegistryExtensions
{
    /// <summary>
    /// Adds a Terraform-managed container registry to the application model.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the container registry resource.</param>
    /// <returns>A resource builder for the container registry.</returns>
    /// <remarks>
    /// <para>
    /// This creates a <see cref="TerraformContainerRegistryResource"/> that can be associated with a
    /// Terraform environment using <see cref="TerraformEnvironmentExtensions.AddTerraformEnvironment(IDistributedApplicationBuilder, string, IResourceBuilder{TerraformContainerRegistryResource})"/>.
    /// The registry is provisioned first, allowing images to be built and pushed before the
    /// environment resources are deployed.
    /// </para>
    /// <para>
    /// The registry configuration must define two outputs:
    /// <list type="bullet">
    /// <item><c>name</c>: The name of the container registry</item>
    /// <item><c>endpoint</c>: The endpoint URL for the container registry (e.g., login server)</item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var acr = builder.AddTerraformContainerRegistry("acr")
    ///     .PublishAsTerraform(registry =>
    ///     {
    ///         var azurerm = new AzurermProvider("azurerm") { ... };
    ///         registry.Add(azurerm);
    ///
    ///         var acr = new AzurermContainerRegistry("acr") { ... };
    ///         registry.Add(acr);
    ///
    ///         // Required outputs
    ///         registry.Add(new TerraformOutput("name") { Value = acr.Name });
    ///         registry.Add(new TerraformOutput("endpoint") { Value = acr.LoginServer });
    ///     })
    ///     .WithLoginCallback(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());
    ///
    /// var terraform = builder.AddTerraformEnvironment("azure", acr);
    /// </code>
    /// </example>
    public static IResourceBuilder<TerraformContainerRegistryResource> AddTerraformContainerRegistry(
        this IDistributedApplicationBuilder builder,
        [ResourceName] string name)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        // Create the container registry resource (environment will be set later via WithContainerRegistry)
        var registryResource = new TerraformContainerRegistryResource(name);

        // Add the registry resource to the application model and return its builder
        return builder.AddResource(registryResource);
    }

    /// <summary>
    /// Configures the authentication callback for the container registry.
    /// </summary>
    /// <param name="builder">The container registry resource builder.</param>
    /// <param name="loginCallback">A callback that performs authentication to the container registry.</param>
    /// <returns>The updated resource builder.</returns>
    /// <remarks>
    /// <para>
    /// This method configures how the deployment pipeline authenticates to the container registry before
    /// pushing images. The callback is invoked after the registry is provisioned and its outputs are read.
    /// </para>
    /// <para>
    /// Use <see cref="TerraformContainerRegistryHelpers"/> for common login patterns:
    /// <list type="bullet">
    /// <item><see cref="TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback"/> - Azure Container Registry via <c>az acr login</c></item>
    /// <item><see cref="TerraformContainerRegistryHelpers.CreateAwsEcrLoginCallback"/> - AWS ECR via <c>aws ecr get-login-password</c></item>
    /// <item><see cref="TerraformContainerRegistryHelpers.CreateDockerLoginCallback"/> - Generic Docker login with username/password</item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var acr = builder.AddTerraformContainerRegistry("acr")
    ///     .PublishAsTerraform(registry => { ... })
    ///     .WithLoginCallback(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());
    /// </code>
    /// </example>
    public static IResourceBuilder<TerraformContainerRegistryResource> WithLoginCallback(
        this IResourceBuilder<TerraformContainerRegistryResource> builder,
        Func<PipelineStepContext, TerraformContainerRegistryResource, Task> loginCallback)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(loginCallback);

        builder.Resource.LoginCallback = loginCallback;

        return builder;
    }

    /// <summary>
    /// Gets a <see cref="TerraformOutputReference"/> for the container registry name from the environment.
    /// </summary>
    /// <param name="environment">The Terraform environment resource.</param>
    /// <returns>A reference to the registry name output, or <c>null</c> if no registry is configured.</returns>
    public static TerraformOutputReference? ContainerRegistryName(this TerraformEnvironmentResource environment)
    {
        ArgumentNullException.ThrowIfNull(environment);

        return environment.ContainerRegistry?.NameOutput;
    }

    /// <summary>
    /// Gets a <see cref="TerraformOutputReference"/> for the container registry endpoint from the environment.
    /// </summary>
    /// <param name="environment">The Terraform environment resource.</param>
    /// <returns>A reference to the registry endpoint output, or <c>null</c> if no registry is configured.</returns>
    public static TerraformOutputReference? ContainerRegistryEndpoint(this TerraformEnvironmentResource environment)
    {
        ArgumentNullException.ThrowIfNull(environment);

        return environment.ContainerRegistry?.EndpointOutput;
    }
}
