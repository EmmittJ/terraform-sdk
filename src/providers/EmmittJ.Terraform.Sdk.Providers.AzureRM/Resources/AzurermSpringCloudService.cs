using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public TerraformList<string>? SearchPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "search_paths").ResolveNodes(ctx));
        set => SetArgument("search_paths", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
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
    public required TerraformValue<string> Plan
    {
        get => new TerraformReference<string>(this, "plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
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
    public TerraformValue<string> AppNetworkResourceGroup
    {
        get => new TerraformReference<string>(this, "app_network_resource_group");
        set => SetArgument("app_network_resource_group", value);
    }

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    public required TerraformValue<string> AppSubnetId
    {
        get => new TerraformReference<string>(this, "app_subnet_id");
        set => SetArgument("app_subnet_id", value);
    }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    public TerraformList<string>? CidrRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_ranges").ResolveNodes(ctx));
        set => SetArgument("cidr_ranges", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformValue<string>? OutboundType
    {
        get => new TerraformReference<string>(this, "outbound_type");
        set => SetArgument("outbound_type", value);
    }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ReadTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "read_timeout_seconds");
        set => SetArgument("read_timeout_seconds", value);
    }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    public TerraformValue<string> ServiceRuntimeNetworkResourceGroup
    {
        get => new TerraformReference<string>(this, "service_runtime_network_resource_group");
        set => SetArgument("service_runtime_network_resource_group", value);
    }

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? SampleRate
    {
        get => new TerraformReference<double>(this, "sample_rate");
        set => SetArgument("sample_rate", value);
    }

}

/// <summary>
/// Represents a azurerm_spring_cloud_service Terraform resource.
/// Manages a azurerm_spring_cloud_service resource.
/// </summary>
public partial class AzurermSpringCloudService(string name) : TerraformResource("azurerm_spring_cloud_service", name)
{
    /// <summary>
    /// The build_agent_pool_size attribute.
    /// </summary>
    public TerraformValue<string>? BuildAgentPoolSize
    {
        get => new TerraformReference<string>(this, "build_agent_pool_size");
        set => SetArgument("build_agent_pool_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogStreamPublicEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "log_stream_public_endpoint_enabled");
        set => SetArgument("log_stream_public_endpoint_enabled", value);
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedEnvironmentId
    {
        get => new TerraformReference<string>(this, "managed_environment_id");
        set => SetArgument("managed_environment_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ServiceRegistryEnabled
    {
        get => new TerraformReference<bool>(this, "service_registry_enabled");
        set => SetArgument("service_registry_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// ConfigServerGitSetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigServerGitSetting block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlock>? ConfigServerGitSetting
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlock>>("config_server_git_setting");
        set => SetArgument("config_server_git_setting", value);
    }

    /// <summary>
    /// ContainerRegistry block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSpringCloudServiceContainerRegistryBlock>? ContainerRegistry
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceContainerRegistryBlock>>("container_registry");
        set => SetArgument("container_registry", value);
    }

    /// <summary>
    /// DefaultBuildService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultBuildService block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceDefaultBuildServiceBlock>? DefaultBuildService
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceDefaultBuildServiceBlock>>("default_build_service");
        set => SetArgument("default_build_service", value);
    }

    /// <summary>
    /// Marketplace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketplace block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceMarketplaceBlock>? Marketplace
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceMarketplaceBlock>>("marketplace");
        set => SetArgument("marketplace", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceNetworkBlock>? Network
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Trace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trace block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceTraceBlock>? Trace
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceTraceBlock>>("trace");
        set => SetArgument("trace", value);
    }

}
