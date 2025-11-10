using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for config_server_git_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlock : TerraformBlock
{
    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        set => SetProperty("label", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SearchPaths
    {
        set => SetProperty("search_paths", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for container_registry in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceContainerRegistryBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        set => SetProperty("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for default_build_service in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceDefaultBuildServiceBlock : TerraformBlock
{
    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryName
    {
        set => SetProperty("container_registry_name", value);
    }

}

/// <summary>
/// Block type for marketplace in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceMarketplaceBlock : TerraformBlock
{
    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        set => SetProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceNetworkBlock : TerraformBlock
{
    /// <summary>
    /// The app_network_resource_group attribute.
    /// </summary>
    public TerraformProperty<string>? AppNetworkResourceGroup
    {
        set => SetProperty("app_network_resource_group", value);
    }

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    public required TerraformProperty<string> AppSubnetId
    {
        set => SetProperty("app_subnet_id", value);
    }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    public List<TerraformProperty<string>>? CidrRanges
    {
        set => SetProperty("cidr_ranges", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundType
    {
        set => SetProperty("outbound_type", value);
    }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ReadTimeoutSeconds
    {
        set => SetProperty("read_timeout_seconds", value);
    }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRuntimeNetworkResourceGroup
    {
        set => SetProperty("service_runtime_network_resource_group", value);
    }

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
    public required TerraformProperty<string> ServiceRuntimeSubnetId
    {
        set => SetProperty("service_runtime_subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for trace in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceTraceBlock : TerraformBlock
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? SampleRate
    {
        set => SetProperty("sample_rate", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudService : TerraformResource
{
    public AzurermSpringCloudService(string name) : base("azurerm_spring_cloud_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("outbound_public_ip_addresses");
        SetOutput("required_network_traffic_rules");
        SetOutput("service_registry_id");
        SetOutput("build_agent_pool_size");
        SetOutput("id");
        SetOutput("location");
        SetOutput("log_stream_public_endpoint_enabled");
        SetOutput("managed_environment_id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("service_registry_enabled");
        SetOutput("sku_name");
        SetOutput("sku_tier");
        SetOutput("tags");
        SetOutput("zone_redundant");
    }

    /// <summary>
    /// The build_agent_pool_size attribute.
    /// </summary>
    public TerraformProperty<string> BuildAgentPoolSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_agent_pool_size");
        set => SetProperty("build_agent_pool_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LogStreamPublicEndpointEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_stream_public_endpoint_enabled");
        set => SetProperty("log_stream_public_endpoint_enabled", value);
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_environment_id");
        set => SetProperty("managed_environment_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ServiceRegistryEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("service_registry_enabled");
        set => SetProperty("service_registry_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string> SkuTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_tier");
        set => SetProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundant
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundant");
        set => SetProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for config_server_git_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigServerGitSetting block(s) allowed")]
    public List<AzurermSpringCloudServiceConfigServerGitSettingBlock>? ConfigServerGitSetting
    {
        set => SetProperty("config_server_git_setting", value);
    }

    /// <summary>
    /// Block for container_registry.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSpringCloudServiceContainerRegistryBlock>? ContainerRegistry
    {
        set => SetProperty("container_registry", value);
    }

    /// <summary>
    /// Block for default_build_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultBuildService block(s) allowed")]
    public List<AzurermSpringCloudServiceDefaultBuildServiceBlock>? DefaultBuildService
    {
        set => SetProperty("default_build_service", value);
    }

    /// <summary>
    /// Block for marketplace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketplace block(s) allowed")]
    public List<AzurermSpringCloudServiceMarketplaceBlock>? Marketplace
    {
        set => SetProperty("marketplace", value);
    }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public List<AzurermSpringCloudServiceNetworkBlock>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trace block(s) allowed")]
    public List<AzurermSpringCloudServiceTraceBlock>? Trace
    {
        set => SetProperty("trace", value);
    }

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundPublicIpAddresses => this["outbound_public_ip_addresses"];

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    public TerraformExpression RequiredNetworkTrafficRules => this["required_network_traffic_rules"];

    /// <summary>
    /// The service_registry_id attribute.
    /// </summary>
    public TerraformExpression ServiceRegistryId => this["service_registry_id"];

}
