using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for config_server_git_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceConfigServerGitSettingBlock
{
    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    [TerraformPropertyName("search_paths")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SearchPaths { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for container_registry in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceContainerRegistryBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformPropertyName("server")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for default_build_service in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceDefaultBuildServiceBlock
{
    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerRegistryName { get; set; }

}

/// <summary>
/// Block type for marketplace in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceMarketplaceBlock
{
    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformPropertyName("plan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Plan { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformPropertyName("product")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceNetworkBlock
{
    /// <summary>
    /// The app_network_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("app_network_resource_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AppNetworkResourceGroup { get; set; } = default!;

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    [TerraformPropertyName("app_subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppSubnetId { get; set; }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    [TerraformPropertyName("cidr_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? CidrRanges { get; set; }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformPropertyName("outbound_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundType { get; set; }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("read_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReadTimeoutSeconds { get; set; }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("service_runtime_network_resource_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceRuntimeNetworkResourceGroup { get; set; } = default!;

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
    [TerraformPropertyName("service_runtime_subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceRuntimeSubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudServiceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for trace in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudServiceTraceBlock
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SampleRate { get; set; }

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
    [TerraformPropertyName("build_agent_pool_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BuildAgentPoolSize { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("log_stream_public_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_environment_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedEnvironmentId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    [TerraformPropertyName("service_registry_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ServiceRegistryEnabled { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SkuTier { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ZoneRedundant { get; set; }

    /// <summary>
    /// Block for config_server_git_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigServerGitSetting block(s) allowed")]
    [TerraformPropertyName("config_server_git_setting")]
    public TerraformList<TerraformBlock<AzurermSpringCloudServiceConfigServerGitSettingBlock>>? ConfigServerGitSetting { get; set; }

    /// <summary>
    /// Block for container_registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("container_registry")]
    public TerraformList<TerraformBlock<AzurermSpringCloudServiceContainerRegistryBlock>>? ContainerRegistry { get; set; }

    /// <summary>
    /// Block for default_build_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultBuildService block(s) allowed")]
    [TerraformPropertyName("default_build_service")]
    public TerraformList<TerraformBlock<AzurermSpringCloudServiceDefaultBuildServiceBlock>>? DefaultBuildService { get; set; }

    /// <summary>
    /// Block for marketplace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketplace block(s) allowed")]
    [TerraformPropertyName("marketplace")]
    public TerraformList<TerraformBlock<AzurermSpringCloudServiceMarketplaceBlock>>? Marketplace { get; set; }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformPropertyName("network")]
    public TerraformList<TerraformBlock<AzurermSpringCloudServiceNetworkBlock>>? Network { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trace block(s) allowed")]
    [TerraformPropertyName("trace")]
    public TerraformList<TerraformBlock<AzurermSpringCloudServiceTraceBlock>>? Trace { get; set; }

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> OutboundPublicIpAddresses => new TerraformReference(this, "outbound_public_ip_addresses");

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    [TerraformPropertyName("required_network_traffic_rules")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RequiredNetworkTrafficRules => new TerraformReference(this, "required_network_traffic_rules");

    /// <summary>
    /// The service_registry_id attribute.
    /// </summary>
    [TerraformPropertyName("service_registry_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceRegistryId => new TerraformReference(this, "service_registry_id");

}
