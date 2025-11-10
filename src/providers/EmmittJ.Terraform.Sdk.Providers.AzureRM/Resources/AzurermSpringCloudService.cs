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
        get => GetProperty<TerraformProperty<string>>("label");
        set => WithProperty("label", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SearchPaths
    {
        get => GetProperty<List<TerraformProperty<string>>>("search_paths");
        set => WithProperty("search_paths", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server");
        set => WithProperty("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetProperty<TerraformProperty<string>>("container_registry_name");
        set => WithProperty("container_registry_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("plan");
        set => WithProperty("plan", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        get => GetRequiredProperty<TerraformProperty<string>>("product");
        set => WithProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
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
        get => GetProperty<TerraformProperty<string>>("app_network_resource_group");
        set => WithProperty("app_network_resource_group", value);
    }

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    public required TerraformProperty<string> AppSubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_subnet_id");
        set => WithProperty("app_subnet_id", value);
    }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    public List<TerraformProperty<string>>? CidrRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("cidr_ranges");
        set => WithProperty("cidr_ranges", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundType
    {
        get => GetProperty<TerraformProperty<string>>("outbound_type");
        set => WithProperty("outbound_type", value);
    }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ReadTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("read_timeout_seconds");
        set => WithProperty("read_timeout_seconds", value);
    }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRuntimeNetworkResourceGroup
    {
        get => GetProperty<TerraformProperty<string>>("service_runtime_network_resource_group");
        set => WithProperty("service_runtime_network_resource_group", value);
    }

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
    public required TerraformProperty<string> ServiceRuntimeSubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_runtime_subnet_id");
        set => WithProperty("service_runtime_subnet_id", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => WithProperty("connection_string", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? SampleRate
    {
        get => GetProperty<TerraformProperty<double>>("sample_rate");
        set => WithProperty("sample_rate", value);
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
        this.WithOutpututbound_public_ip_addresses");
        this.WithOutputequired_network_traffic_rules");
        this.WithOutputervice_registry_id");
    }

    /// <summary>
    /// The build_agent_pool_size attribute.
    /// </summary>
    public TerraformProperty<string>? BuildAgentPoolSize
    {
        get => GetProperty<TerraformProperty<string>>("build_agent_pool_size");
        set => this.WithProperty("build_agent_pool_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogStreamPublicEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_stream_public_endpoint_enabled");
        set => this.WithProperty("log_stream_public_endpoint_enabled", value);
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("managed_environment_id");
        set => this.WithProperty("managed_environment_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ServiceRegistryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("service_registry_enabled");
        set => this.WithProperty("service_registry_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string>? SkuTier
    {
        get => GetProperty<TerraformProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for config_server_git_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigServerGitSetting block(s) allowed")]
    public List<AzurermSpringCloudServiceConfigServerGitSettingBlock>? ConfigServerGitSetting
    {
        get => GetProperty<List<AzurermSpringCloudServiceConfigServerGitSettingBlock>>("config_server_git_setting");
        set => this.WithProperty("config_server_git_setting", value);
    }

    /// <summary>
    /// Block for container_registry.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSpringCloudServiceContainerRegistryBlock>? ContainerRegistry
    {
        get => GetProperty<List<AzurermSpringCloudServiceContainerRegistryBlock>>("container_registry");
        set => this.WithProperty("container_registry", value);
    }

    /// <summary>
    /// Block for default_build_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultBuildService block(s) allowed")]
    public List<AzurermSpringCloudServiceDefaultBuildServiceBlock>? DefaultBuildService
    {
        get => GetProperty<List<AzurermSpringCloudServiceDefaultBuildServiceBlock>>("default_build_service");
        set => this.WithProperty("default_build_service", value);
    }

    /// <summary>
    /// Block for marketplace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketplace block(s) allowed")]
    public List<AzurermSpringCloudServiceMarketplaceBlock>? Marketplace
    {
        get => GetProperty<List<AzurermSpringCloudServiceMarketplaceBlock>>("marketplace");
        set => this.WithProperty("marketplace", value);
    }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public List<AzurermSpringCloudServiceNetworkBlock>? Network
    {
        get => GetProperty<List<AzurermSpringCloudServiceNetworkBlock>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trace block(s) allowed")]
    public List<AzurermSpringCloudServiceTraceBlock>? Trace
    {
        get => GetProperty<List<AzurermSpringCloudServiceTraceBlock>>("trace");
        set => this.WithProperty("trace", value);
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
