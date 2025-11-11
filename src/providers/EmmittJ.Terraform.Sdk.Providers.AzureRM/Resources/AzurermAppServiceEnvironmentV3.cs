using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cluster_setting in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppServiceEnvironmentV3ClusterSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceEnvironmentV3TimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_app_service_environment_v3 resource.
/// </summary>
public partial class AzurermAppServiceEnvironmentV3 : TerraformResource
{
    public AzurermAppServiceEnvironmentV3(string name) : base("azurerm_app_service_environment_v3", name)
    {
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    [TerraformProperty("allow_new_private_endpoint_connections")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowNewPrivateEndpointConnections { get; set; }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformProperty("dedicated_host_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DedicatedHostCount { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformProperty("internal_load_balancing_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InternalLoadBalancingMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformProperty("remote_debugging_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ZoneRedundant { get; set; }

    /// <summary>
    /// Block for cluster_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cluster_setting")]
    public TerraformList<TerraformBlock<AzurermAppServiceEnvironmentV3ClusterSettingBlock>>? ClusterSetting { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAppServiceEnvironmentV3TimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformProperty("dns_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsSuffix { get; }

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("external_inbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ExternalInboundIpAddresses { get; }

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    [TerraformProperty("inbound_network_dependencies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InboundNetworkDependencies { get; }

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("internal_inbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> InternalInboundIpAddresses { get; }

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    [TerraformProperty("ip_ssl_address_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> IpSslAddressCount { get; }

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("linux_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> LinuxOutboundIpAddresses { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformProperty("pricing_tier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PricingTier { get; }

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("windows_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> WindowsOutboundIpAddresses { get; }

}
