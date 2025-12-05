using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for config_server_git_setting in AzurermSpringCloudService.
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
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public TerraformList<string>? SearchPaths
    {
        get => GetArgument<TerraformList<string>>("search_paths");
        set => SetArgument("search_paths", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// HttpBasicAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpBasicAuth block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockHttpBasicAuthBlock>? HttpBasicAuth
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockHttpBasicAuthBlock>>("http_basic_auth");
        set => SetArgument("http_basic_auth", value);
    }

    /// <summary>
    /// Repository block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlock>? Repository
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlock>>("repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// SshAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshAuth block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockSshAuthBlock>? SshAuth
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockSshAuthBlock>>("ssh_auth");
        set => SetArgument("ssh_auth", value);
    }

}

/// <summary>
/// Block type for http_basic_auth in AzurermSpringCloudServiceConfigServerGitSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlockHttpBasicAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_basic_auth";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for repository in AzurermSpringCloudServiceConfigServerGitSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository";

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public TerraformList<string>? Pattern
    {
        get => GetArgument<TerraformList<string>>("pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public TerraformList<string>? SearchPaths
    {
        get => GetArgument<TerraformList<string>>("search_paths");
        set => SetArgument("search_paths", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// HttpBasicAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpBasicAuth block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlockHttpBasicAuthBlock>? HttpBasicAuth
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlockHttpBasicAuthBlock>>("http_basic_auth");
        set => SetArgument("http_basic_auth", value);
    }

    /// <summary>
    /// SshAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshAuth block(s) allowed")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlockSshAuthBlock>? SshAuth
    {
        get => GetArgument<TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlockSshAuthBlock>>("ssh_auth");
        set => SetArgument("ssh_auth", value);
    }

}

/// <summary>
/// Block type for http_basic_auth in AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlockHttpBasicAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_basic_auth";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for ssh_auth in AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlockRepositoryBlockSshAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_auth";

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformValue<string>? HostKey
    {
        get => GetArgument<TerraformValue<string>>("host_key");
        set => SetArgument("host_key", value);
    }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("host_key_algorithm");
        set => SetArgument("host_key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The strict_host_key_checking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StrictHostKeyCheckingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("strict_host_key_checking_enabled");
        set => SetArgument("strict_host_key_checking_enabled", value);
    }

}

/// <summary>
/// Block type for ssh_auth in AzurermSpringCloudServiceConfigServerGitSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlockSshAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_auth";

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformValue<string>? HostKey
    {
        get => GetArgument<TerraformValue<string>>("host_key");
        set => SetArgument("host_key", value);
    }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("host_key_algorithm");
        set => SetArgument("host_key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The strict_host_key_checking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StrictHostKeyCheckingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("strict_host_key_checking_enabled");
        set => SetArgument("strict_host_key_checking_enabled", value);
    }

}


/// <summary>
/// Block type for container_registry in AzurermSpringCloudService.
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for default_build_service in AzurermSpringCloudService.
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
        get => GetArgument<TerraformValue<string>>("container_registry_name");
        set => SetArgument("container_registry_name", value);
    }

}


/// <summary>
/// Block type for marketplace in AzurermSpringCloudService.
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
        get => GetRequiredArgument<TerraformValue<string>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => GetRequiredArgument<TerraformValue<string>>("product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

}


/// <summary>
/// Block type for network in AzurermSpringCloudService.
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
        get => GetArgument<TerraformValue<string>>("app_network_resource_group") ?? CreateReference("app_network_resource_group");
        set => SetArgument("app_network_resource_group", value);
    }

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    public required TerraformValue<string> AppSubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_subnet_id");
        set => SetArgument("app_subnet_id", value);
    }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    public TerraformList<string>? CidrRanges
    {
        get => GetArgument<TerraformList<string>>("cidr_ranges");
        set => SetArgument("cidr_ranges", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformValue<string>? OutboundType
    {
        get => GetArgument<TerraformValue<string>>("outbound_type");
        set => SetArgument("outbound_type", value);
    }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ReadTimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("read_timeout_seconds");
        set => SetArgument("read_timeout_seconds", value);
    }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    public TerraformValue<string> ServiceRuntimeNetworkResourceGroup
    {
        get => GetArgument<TerraformValue<string>>("service_runtime_network_resource_group") ?? CreateReference("service_runtime_network_resource_group");
        set => SetArgument("service_runtime_network_resource_group", value);
    }

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
    public required TerraformValue<string> ServiceRuntimeSubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_runtime_subnet_id");
        set => SetArgument("service_runtime_subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudService.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for trace in AzurermSpringCloudService.
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
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? SampleRate
    {
        get => GetArgument<TerraformValue<double>>("sample_rate");
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
        get => GetArgument<TerraformValue<string>>("build_agent_pool_size");
        set => SetArgument("build_agent_pool_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogStreamPublicEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_stream_public_endpoint_enabled");
        set => SetArgument("log_stream_public_endpoint_enabled", value);
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedEnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("managed_environment_id");
        set => SetArgument("managed_environment_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ServiceRegistryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("service_registry_enabled");
        set => SetArgument("service_registry_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
    {
        get => GetArgument<TerraformValue<string>>("sku_tier") ?? CreateReference("sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> OutboundPublicIpAddresses
        => CreateReference("outbound_public_ip_addresses");

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredNetworkTrafficRules
        => CreateReference("required_network_traffic_rules");

    /// <summary>
    /// The service_registry_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceRegistryId
        => CreateReference("service_registry_id");

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
