using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for config_server_git_setting in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudServiceConfigServerGitSettingBlock() : TerraformBlock("config_server_git_setting")
{
    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    [TerraformProperty("search_paths")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SearchPaths { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for container_registry in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudServiceContainerRegistryBlock() : TerraformBlock("container_registry")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformProperty("server")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for default_build_service in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudServiceDefaultBuildServiceBlock() : TerraformBlock("default_build_service")
{
    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    [TerraformProperty("container_registry_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerRegistryName { get; set; }

}

/// <summary>
/// Block type for marketplace in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudServiceMarketplaceBlock() : TerraformBlock("marketplace")
{
    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformProperty("plan")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Plan { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformProperty("product")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudServiceNetworkBlock() : TerraformBlock("network")
{
    /// <summary>
    /// The app_network_resource_group attribute.
    /// </summary>
    [TerraformProperty("app_network_resource_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AppNetworkResourceGroup { get; set; }

    /// <summary>
    /// The app_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSubnetId is required")]
    [TerraformProperty("app_subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppSubnetId { get; set; }

    /// <summary>
    /// The cidr_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRanges is required")]
    [TerraformProperty("cidr_ranges")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? CidrRanges { get; set; }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformProperty("outbound_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutboundType { get; set; }

    /// <summary>
    /// The read_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("read_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReadTimeoutSeconds { get; set; }

    /// <summary>
    /// The service_runtime_network_resource_group attribute.
    /// </summary>
    [TerraformProperty("service_runtime_network_resource_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>
    /// The service_runtime_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRuntimeSubnetId is required")]
    [TerraformProperty("service_runtime_subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceRuntimeSubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudServiceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for trace in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudServiceTraceBlock() : TerraformBlock("trace")
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    [TerraformProperty("sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SampleRate { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudService : TerraformResource
{
    public AzurermSpringCloudService(string name) : base("azurerm_spring_cloud_service", name)
    {
    }

    /// <summary>
    /// The build_agent_pool_size attribute.
    /// </summary>
    [TerraformProperty("build_agent_pool_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BuildAgentPoolSize { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("log_stream_public_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    [TerraformProperty("managed_environment_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedEnvironmentId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    [TerraformProperty("service_registry_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ServiceRegistryEnabled { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformProperty("sku_tier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SkuTier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundant { get; set; }

    /// <summary>
    /// Block for config_server_git_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigServerGitSetting block(s) allowed")]
    [TerraformProperty("config_server_git_setting")]
    public TerraformList<AzurermSpringCloudServiceConfigServerGitSettingBlock> ConfigServerGitSetting { get; set; } = new();

    /// <summary>
    /// Block for container_registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("container_registry")]
    public TerraformList<AzurermSpringCloudServiceContainerRegistryBlock> ContainerRegistry { get; set; } = new();

    /// <summary>
    /// Block for default_build_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultBuildService block(s) allowed")]
    [TerraformProperty("default_build_service")]
    public TerraformList<AzurermSpringCloudServiceDefaultBuildServiceBlock> DefaultBuildService { get; set; } = new();

    /// <summary>
    /// Block for marketplace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketplace block(s) allowed")]
    [TerraformProperty("marketplace")]
    public TerraformList<AzurermSpringCloudServiceMarketplaceBlock> Marketplace { get; set; } = new();

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformProperty("network")]
    public TerraformList<AzurermSpringCloudServiceNetworkBlock> Network { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trace block(s) allowed")]
    [TerraformProperty("trace")]
    public TerraformList<AzurermSpringCloudServiceTraceBlock> Trace { get; set; } = new();

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundPublicIpAddresses { get; }

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    [TerraformProperty("required_network_traffic_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RequiredNetworkTrafficRules { get; }

    /// <summary>
    /// The service_registry_id attribute.
    /// </summary>
    [TerraformProperty("service_registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceRegistryId { get; }

}
