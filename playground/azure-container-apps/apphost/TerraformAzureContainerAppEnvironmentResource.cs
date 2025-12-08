// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIRECOMPUTE002

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;
using EmmittJ.Terraform.Sdk.Providers.Random;

namespace TerraformPlayground.AppHost;

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
public sealed class TerraformAzureContainerAppEnvironmentResource : TerraformCloudEnvironmentResource
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

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformAzureContainerAppEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the environment.</param>
    public TerraformAzureContainerAppEnvironmentResource(string name)
        : base(name)
    {
        Configure(options =>
        {
            options.RegistryLoginCallback = TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback();
        });
    }

    /// <inheritdoc/>
    protected override void ValidateConfiguration()
    {
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
    }

    /// <inheritdoc/>
    protected override void ConfigureContainerRegistry(TerraformProvisioningResource registry)
    {
        ConfigureRequiredProviders(registry.Stack);
        ConfigureAzurermProvider(registry);
        var locationVar = ConfigureLocationVariable(registry);

        var tags = new TerraformMap<string>
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire-Terraform"
        };

        var resourceGroup = new AzurermResourceGroup("rg")
        {
            Name = $"{Name}-registry-rg",
            Location = locationVar,
            Tags = tags
        };
        registry.Add(resourceGroup);

        // Generate a random pet name and suffix for globally unique ACR name
        var acrPet = new RandomPet("acr_pet")
        {
            Length = 1,
            Separator = "",
            Keepers = new TerraformMap<string>
            {
                ["resource_group"] = resourceGroup.Name
            }
        };
        registry.Add(acrPet);

        var acrSuffix = new RandomString("acr_suffix")
        {
            Length = 4,
            Special = false,
            Upper = false,
            Numeric = true,
            Lower = false,
            Keepers = new TerraformMap<string>
            {
                ["resource_group"] = resourceGroup.Name
            }
        };
        registry.Add(acrSuffix);

        var containerRegistry = new AzurermContainerRegistry("acr")
        {
            Name = Tf.Interpolate($"acr{acrPet.Id}{acrSuffix.Result}"),
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
    }

    /// <inheritdoc/>
    protected override void ConfigureEnvironment(TerraformProvisioningResource environment)
    {
        ConfigureRequiredProviders(environment.Stack);
        ConfigureAzurermProvider(environment);
        var locationVar = ConfigureLocationVariable(environment);

        var registryEndpointVar = environment.RegistryEndpoint;
        var registryNameVar = environment.RegistryName;

        var tags = new TerraformMap<string>
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire-Terraform"
        };

        var resourceGroup = new AzurermResourceGroup("rg")
        {
            Name = $"{Name}-aca-rg",
            Location = locationVar,
            Tags = tags
        };
        environment.Add(resourceGroup);

        var logAnalytics = new AzurermLogAnalyticsWorkspace("law")
        {
            Name = $"{Name}-law",
            Location = locationVar,
            ResourceGroupName = resourceGroup.Name,
            Sku = "PerGB2018",
            RetentionInDays = 30,
            Tags = tags
        };
        environment.Add(logAnalytics);

        var managedIdentity = new AzurermUserAssignedIdentity("mi")
        {
            Name = $"{Name}-mi",
            Location = locationVar,
            ResourceGroupName = resourceGroup.Name,
            Tags = tags
        };
        environment.Add(managedIdentity);

        // Data source to reference the existing ACR for role assignment
        var acrDataSource = new TerraformDataSource("azurerm_container_registry", "acr")
        {
            ["name"] = registryNameVar,
            ["resource_group_name"] = $"{Name}-registry-rg"
        };
        environment.Add(acrDataSource);

        // Grant the managed identity permission to pull images from ACR
        var acrPullRole = new AzurermRoleAssignment("acr-pull")
        {
            Scope = acrDataSource["id"].AsLazy<string>(),
            RoleDefinitionName = "AcrPull",
            PrincipalId = managedIdentity.PrincipalId,
            PrincipalType = "ServicePrincipal"
        };
        environment.Add(acrPullRole);

        var containerAppEnvironment = new AzurermContainerAppEnvironment("cae")
        {
            Name = $"{Name}-cae",
            Location = locationVar,
            ResourceGroupName = resourceGroup.Name,
            LogAnalyticsWorkspaceId = logAnalytics.Id,
            LogsDestination = "log-analytics",
            Tags = tags
        };
        environment.Add(containerAppEnvironment);

        // Outputs consumed by child modules
        environment.AddOutput("container_env_id", containerAppEnvironment.Id);
        environment.AddOutput("managed_identity_id", managedIdentity.Id);
        environment.AddOutput("resource_group_name", resourceGroup.Name);
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
        // SubscriptionIdParameter is validated in ValidateConfiguration before this method is called
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

        // Location is validated in ValidateConfiguration before this method is called (when LocationParameter is null)
        ArgumentNullException.ThrowIfNull(Location);

        var locationVar = new TerraformVariable("location")
        {
            Type = "string",
            Default = Location
        };
        infra.Stack.Add(locationVar);
        return locationVar;
    }

    /// <inheritdoc/>
    protected override TerraformComputeResourceContext CreateComputeResourceContext(
        IResource resource,
        DistributedApplicationExecutionContext executionContext)
    {
        return new TerraformAzureContainerAppContext(resource, executionContext, Name);
    }
}
