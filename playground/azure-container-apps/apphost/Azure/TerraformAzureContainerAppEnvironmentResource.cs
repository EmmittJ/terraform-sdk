// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIRECOMPUTE002

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;

namespace TerraformPlayground.AppHost.Azure;

/// <summary>
/// Represents a Terraform-managed Azure Container Apps environment that automatically provisions
/// container registry, log analytics, managed identity, and container app environment resources.
/// </summary>
/// <remarks>
/// <para>
/// This resource creates a two-stage Terraform deployment:
/// <list type="number">
/// <item>Stage 1: Container Registry - provisions ACR for image storage (separate state)</item>
/// <item>Stage 2: Environment - provisions Log Analytics, Managed Identity, Role Assignment, and Container App Environment</item>
/// </list>
/// </para>
/// <para>
/// The environment name is used as the base name for all generated resources:
/// <list type="bullet">
/// <item><c>{name}-registry-rg</c> - Resource group for container registry</item>
/// <item><c>{name}-aca-rg</c> - Resource group for container apps environment</item>
/// <item><c>{name}-law</c> - Log Analytics Workspace</item>
/// <item><c>{name}-mi</c> - Managed Identity for ACR pull</item>
/// <item><c>{name}-cae</c> - Container App Environment</item>
/// </list>
/// </para>
/// </remarks>
public sealed class TerraformAzureContainerAppEnvironmentResource :
    Resource,
    IComputeEnvironmentResource,
    IContainerRegistry
{
    /// <summary>
    /// Gets or sets the Azure subscription ID parameter.
    /// </summary>
    public ParameterResource? SubscriptionIdParameter { get; set; }

    /// <summary>
    /// Gets or sets the Azure location (region) as a string.
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// Gets or sets the Azure location parameter.
    /// </summary>
    public ParameterResource? LocationParameter { get; set; }

    /// <summary>
    /// Gets or sets the Terraform backend type.
    /// </summary>
    public string? BackendType { get; set; }

    /// <summary>
    /// Gets or sets the backend configuration callback.
    /// </summary>
    public Action<TerraformBackendBlock>? ConfigureBackend { get; set; }

    /// <summary>
    /// Gets the internal container registry resource.
    /// </summary>
    internal TerraformContainerRegistryResource ContainerRegistryResource { get; }

    /// <summary>
    /// Gets the internal environment resource.
    /// </summary>
    internal TerraformEnvironmentResource EnvironmentResource { get; }

    /// <summary>
    /// Gets the output reference for the Container App Environment ID.
    /// </summary>
    public TerraformOutputReference ContainerAppEnvironmentId => new("container_env_id", EnvironmentResource);

    /// <summary>
    /// Gets the output reference for the Managed Identity ID.
    /// </summary>
    public TerraformOutputReference ManagedIdentityId => new("managed_identity_id", EnvironmentResource);

    /// <summary>
    /// Gets the output reference for the Resource Group Name.
    /// </summary>
    public TerraformOutputReference ResourceGroupName => new("resource_group_name", EnvironmentResource);

    // IContainerRegistry implementation
    ReferenceExpression IContainerRegistry.Name => ReferenceExpression.Create($"{ContainerRegistryResource.NameOutput}");
    ReferenceExpression IContainerRegistry.Endpoint => ReferenceExpression.Create($"{ContainerRegistryResource.EndpointOutput}");

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformAzureContainerAppEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the environment.</param>
    public TerraformAzureContainerAppEnvironmentResource(string name)
        : base(name)
    {
        // Create container registry resource (Stage 1)
        ContainerRegistryResource = new TerraformContainerRegistryResource($"{Name}-acr");
        ContainerRegistryResource.LoginCallback = TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback();

        // Create environment resource (Stage 2) - depends on the container registry
        EnvironmentResource = new TerraformEnvironmentResource(Name, ContainerRegistryResource);

        // Add ContainerRegistryReferenceAnnotation for lookup
        EnvironmentResource.Annotations.Add(new ContainerRegistryReferenceAnnotation(ContainerRegistryResource));

        // Add pipeline step annotation to create and expand steps
        Annotations.Add(new PipelineStepAnnotation(async (factoryContext) =>
        {
            // Apply configuration before expanding steps
            ApplyConfiguration();

            var steps = new List<PipelineStep>();

            // Expand steps from child resources using the helper
            await TerraformPipelineHelpers.ExpandChildStepsAsync(ContainerRegistryResource, factoryContext, steps).ConfigureAwait(false);
            await TerraformPipelineHelpers.ExpandChildStepsAsync(EnvironmentResource, factoryContext, steps).ConfigureAwait(false);

            return steps;
        }));

        // Add pipeline configuration annotation to wire up dependencies
        Annotations.Add(new PipelineConfigurationAnnotation(context =>
        {
            // Expand configuration from child resources using the helper
            TerraformPipelineHelpers.ExpandChildConfiguration(ContainerRegistryResource, context);
            TerraformPipelineHelpers.ExpandChildConfiguration(EnvironmentResource, context);
        }));
    }

    /// <summary>
    /// Applies the configuration to the child resources. Called before pipeline steps are created.
    /// </summary>
    private void ApplyConfiguration()
    {
        // Validate required configuration
        if (SubscriptionIdParameter is null)
        {
            throw new InvalidOperationException(
                $"Azure subscription ID is required. Call .WithSubscriptionId() on the '{Name}' resource.");
        }

        if (Location is null && LocationParameter is null)
        {
            throw new InvalidOperationException(
                $"Azure location is required. Call .WithLocation() on the '{Name}' resource.");
        }

        // Common tags
        var tags = new TerraformMap<string>
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire-Terraform"
        };

        // Configure backend if specified
        if (BackendType is not null)
        {
            ConfigureResourceBackend(ContainerRegistryResource.TerraformResource.Stack, BackendType);
            ConfigureResourceBackend(EnvironmentResource.TerraformResource.Stack, BackendType);
        }

        // Configure required providers for registry
        ConfigureRequiredProviders(ContainerRegistryResource.TerraformResource.Stack);

        // Configure container registry Terraform resources
        ContainerRegistryResource.Annotations.Add(new TerraformCustomizationAnnotation(registry =>
        {
            ConfigureAzurermProvider(registry);
            var locationVar = ConfigureLocationVariable(registry);

            var resourceGroup = new AzurermResourceGroup("rg")
            {
                Name = $"{Name}-registry-rg",
                Location = locationVar,
                Tags = tags
            };
            registry.Add(resourceGroup);

            // Generate a random suffix for globally unique ACR name
            var acrSuffix = new TerraformResource("random_string", "acr_suffix")
            {
                ["length"] = 8,
                ["special"] = false,
                ["upper"] = false,
                ["numeric"] = true,
                ["keepers"] = new TerraformMap<string>
                {
                    ["resource_group"] = resourceGroup.Name
                }
            };
            registry.Add(acrSuffix);

            var containerRegistry = new AzurermContainerRegistry("acr")
            {
                Name = Tf.Interpolate($"acr{acrSuffix["result"]}"),
                Location = resourceGroup.Location,
                ResourceGroupName = resourceGroup.Name,
                Sku = "Basic",
                AdminEnabled = true,
                Tags = tags
            };
            registry.Add(containerRegistry);

            // Required outputs for IContainerRegistry
            registry.Add(new TerraformOutput("name")
            {
                Value = containerRegistry.Name,
                Description = "The name of the Azure Container Registry"
            });

            registry.Add(new TerraformOutput("endpoint")
            {
                Value = containerRegistry.LoginServer,
                Description = "The login server URL for the Azure Container Registry"
            });
        }));

        // Configure required providers for environment
        ConfigureRequiredProviders(EnvironmentResource.TerraformResource.Stack);

        // Configure environment Terraform resources
        EnvironmentResource.TerraformResource.Annotations.Add(new TerraformCustomizationAnnotation(infra =>
        {
            ConfigureAzurermProvider(infra);
            var locationVar = ConfigureLocationVariable(infra);

            var registryEndpointVar = infra.RegistryEndpoint;
            var registryNameVar = infra.RegistryName;

            var resourceGroup = new AzurermResourceGroup("rg")
            {
                Name = $"{Name}-aca-rg",
                Location = locationVar,
                Tags = tags
            };
            infra.Add(resourceGroup);

            var logAnalytics = new AzurermLogAnalyticsWorkspace("law")
            {
                Name = $"{Name}-law",
                Location = locationVar,
                ResourceGroupName = resourceGroup.Name,
                Sku = "PerGB2018",
                RetentionInDays = 30,
                Tags = tags
            };
            infra.Add(logAnalytics);

            var managedIdentity = new AzurermUserAssignedIdentity("mi")
            {
                Name = $"{Name}-mi",
                Location = locationVar,
                ResourceGroupName = resourceGroup.Name,
                Tags = tags
            };
            infra.Add(managedIdentity);

            // Data source to reference the existing ACR for role assignment
            var acrDataSource = new TerraformDataSource("azurerm_container_registry", "acr")
            {
                ["name"] = registryNameVar,
                ["resource_group_name"] = $"{Name}-registry-rg"
            };
            infra.Add(acrDataSource);

            // Grant the managed identity permission to pull images from ACR
            var acrPullRole = new AzurermRoleAssignment("acr-pull")
            {
                Scope = acrDataSource["id"].AsLazy<string>(),
                RoleDefinitionName = "AcrPull",
                PrincipalId = managedIdentity.PrincipalId,
                PrincipalType = "ServicePrincipal"
            };
            infra.Add(acrPullRole);

            var containerAppEnvironment = new AzurermContainerAppEnvironment("cae")
            {
                Name = $"{Name}-cae",
                Location = locationVar,
                ResourceGroupName = resourceGroup.Name,
                LogAnalyticsWorkspaceId = logAnalytics.Id,
                LogsDestination = "log-analytics",
                Tags = tags
            };
            infra.Add(containerAppEnvironment);

            // Outputs consumed by child modules
            infra.AddOutput("container_env_id", containerAppEnvironment.Id);
            infra.AddOutput("managed_identity_id", managedIdentity.Id);
            infra.AddOutput("resource_group_name", resourceGroup.Name);
        }));
    }

    private void ConfigureResourceBackend(TerraformStack stack, string backendType)
    {
        stack.Terraform ??= new TerraformSettingsBlock();
        var backend = new TerraformBackendBlock(backendType);
        ConfigureBackend?.Invoke(backend);
        stack.Terraform.Backend = backend;
    }

    private static void ConfigureRequiredProviders(TerraformStack stack)
    {
        stack.Terraform ??= new TerraformSettingsBlock();
        var requiredProviders = new TerraformRequiredProvidersBlock();
        requiredProviders["azurerm"] = new ProviderRequirement { Source = "hashicorp/azurerm", Version = "~> 4.0" };
        requiredProviders["random"] = new ProviderRequirement { Source = "hashicorp/random", Version = "~> 3.0" };
        stack.Terraform.RequiredProviders = requiredProviders;
    }

    private void ConfigureAzurermProvider(TerraformProvisioningResource infra)
    {
        // SubscriptionIdParameter is validated in ApplyConfiguration before this method is called
        ArgumentNullException.ThrowIfNull(SubscriptionIdParameter);

        var azurerm = new AzurermProvider("azurerm")
        {
            UseCli = true,
            SubscriptionId = infra.AddVariable(SubscriptionIdParameter),
            Features = [new()]
        };
        infra.Add(azurerm);
    }

    private TerraformVariable ConfigureLocationVariable(TerraformProvisioningResource infra)
    {
        if (LocationParameter is not null)
        {
            return infra.AddVariable(LocationParameter);
        }

        // Location is validated in ApplyConfiguration before this method is called (when LocationParameter is null)
        ArgumentNullException.ThrowIfNull(Location);

        var locationVar = new TerraformVariable("location")
        {
            Type = "string",
            Default = Location
        };
        infra.Stack.Add(locationVar);
        return locationVar;
    }

    /// <summary>
    /// Computes the host URL <see cref="ReferenceExpression"/> for the given <see cref="EndpointReference"/>.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to compute the host address for.</param>
    /// <returns>A <see cref="ReferenceExpression"/> representing the host address.</returns>
    ReferenceExpression IComputeEnvironmentResource.GetHostAddressExpression(EndpointReference endpointReference)
    {
        var resource = endpointReference.Resource;
        var endpointName = endpointReference.EndpointName;

        // Create an output reference using the naming convention: {endpoint_name}_endpoint
        var outputName = $"{endpointName}{TerraformProvisioningResource.EndpointOutputNameSuffix}";
        var outputRef = new TerraformOutputReference(outputName, resource);

        return ReferenceExpression.Create($"{outputRef}");
    }
}
