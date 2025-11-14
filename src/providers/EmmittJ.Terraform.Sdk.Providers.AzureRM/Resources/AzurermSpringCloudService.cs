using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for config_server_git_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_server_git_setting";

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformArgument("label")]
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    [TerraformArgument("search_paths")]
    public TerraformList<string>? SearchPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "search_paths").ResolveNodes(ctx));
        set => SetArgument("search_paths", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformArgument("uri")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for container_registry in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceContainerRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_registry";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformArgument("password")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformArgument("server")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformArgument("username")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for default_build_service in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceDefaultBuildServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_build_service";

    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    [TerraformArgument("container_registry_name")]
    public TerraformValue<string>? ContainerRegistryName
    {
        get => new TerraformReference<string>(this, "container_registry_name");
        set => SetArgument("container_registry_name", value);
    }

}

/// <summary>
/// Block type for marketplace in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceMarketplaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "marketplace";

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformArgument("plan")]
    public required TerraformValue<string> Plan
    {
        get => new TerraformReference<string>(this, "plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformArgument("product")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network";

    /// <summary>
    /// The app_network_resource_group attribute.
    /// </summary>
    [TerraformArgument("app_network_resource_group")]
    public TerraformValue<string> AppNetworkResourceGroup
    {
        get => new TerraformReference<string>(this, "app_network_resource_group");
        set => SetArgument("app_network_resource_group", value);
    }

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    [TerraformArgument("app_subnet_id")]
    public required TerraformValue<string> AppSubnetId
    {
        get => new TerraformReference<string>(this, "app_subnet_id");
        set => SetArgument("app_subnet_id", value);
    }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    [TerraformArgument("cidr_ranges")]
    public TerraformList<string>? CidrRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_ranges").ResolveNodes(ctx));
        set => SetArgument("cidr_ranges", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformArgument("outbound_type")]
    public TerraformValue<string>? OutboundType
    {
        get => new TerraformReference<string>(this, "outbound_type");
        set => SetArgument("outbound_type", value);
    }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    [TerraformArgument("read_timeout_seconds")]
    public TerraformValue<double>? ReadTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "read_timeout_seconds");
        set => SetArgument("read_timeout_seconds", value);
    }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    [TerraformArgument("service_runtime_network_resource_group")]
    public TerraformValue<string> ServiceRuntimeNetworkResourceGroup
    {
        get => new TerraformReference<string>(this, "service_runtime_network_resource_group");
        set => SetArgument("service_runtime_network_resource_group", value);
    }

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
    [TerraformArgument("service_runtime_subnet_id")]
    public required TerraformValue<string> ServiceRuntimeSubnetId
    {
        get => new TerraformReference<string>(this, "service_runtime_subnet_id");
        set => SetArgument("service_runtime_subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for trace in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceTraceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trace";

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformArgument("connection_string")]
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    [TerraformArgument("sample_rate")]
    public TerraformValue<double>? SampleRate
    {
        get => new TerraformReference<double>(this, "sample_rate");
        set => SetArgument("sample_rate", value);
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
    }

    /// <summary>
    /// The build_agent_pool_size attribute.
    /// </summary>
    [TerraformArgument("build_agent_pool_size")]
    public TerraformValue<string>? BuildAgentPoolSize
    {
        get => new TerraformReference<string>(this, "build_agent_pool_size");
        set => SetArgument("build_agent_pool_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("log_stream_public_endpoint_enabled")]
    public TerraformValue<bool>? LogStreamPublicEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "log_stream_public_endpoint_enabled");
        set => SetArgument("log_stream_public_endpoint_enabled", value);
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    [TerraformArgument("managed_environment_id")]
    public TerraformValue<string>? ManagedEnvironmentId
    {
        get => new TerraformReference<string>(this, "managed_environment_id");
        set => SetArgument("managed_environment_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    [TerraformArgument("service_registry_enabled")]
    public TerraformValue<bool>? ServiceRegistryEnabled
    {
        get => new TerraformReference<bool>(this, "service_registry_enabled");
        set => SetArgument("service_registry_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformArgument("sku_tier")]
    public TerraformValue<string> SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool>? ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// Block for config_server_git_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigServerGitSetting block(s) allowed")]
    [TerraformArgument("config_server_git_setting")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlock> ConfigServerGitSetting { get; set; } = new();

    /// <summary>
    /// Block for container_registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("container_registry")]
    public TerraformList<AzurermSpringCloudServiceContainerRegistryBlock> ContainerRegistry { get; set; } = new();

    /// <summary>
    /// Block for default_build_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultBuildService block(s) allowed")]
    [TerraformArgument("default_build_service")]
    public TerraformList<AzurermSpringCloudServiceDefaultBuildServiceBlock> DefaultBuildService { get; set; } = new();

    /// <summary>
    /// Block for marketplace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketplace block(s) allowed")]
    [TerraformArgument("marketplace")]
    public TerraformList<AzurermSpringCloudServiceMarketplaceBlock> Marketplace { get; set; } = new();

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformArgument("network")]
    public TerraformList<AzurermSpringCloudServiceNetworkBlock> Network { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trace block(s) allowed")]
    [TerraformArgument("trace")]
    public TerraformList<AzurermSpringCloudServiceTraceBlock> Trace { get; set; } = new();

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("outbound_public_ip_addresses")]
    public TerraformList<string> OutboundPublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    [TerraformArgument("required_network_traffic_rules")]
    public TerraformList<object> RequiredNetworkTrafficRules
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "required_network_traffic_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_registry_id attribute.
    /// </summary>
    [TerraformArgument("service_registry_id")]
    public TerraformValue<string> ServiceRegistryId
    {
        get => new TerraformReference<string>(this, "service_registry_id");
    }

}
