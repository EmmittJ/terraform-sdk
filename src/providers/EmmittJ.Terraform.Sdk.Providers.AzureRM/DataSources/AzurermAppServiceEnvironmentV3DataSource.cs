using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_environment_v3.
/// </summary>
public partial class AzurermAppServiceEnvironmentV3DataSource : TerraformDataSource
{
    public AzurermAppServiceEnvironmentV3DataSource(string name) : base("azurerm_app_service_environment_v3", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    [TerraformProperty("allow_new_private_endpoint_connections")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowNewPrivateEndpointConnections { get; }

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    [TerraformProperty("cluster_setting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ClusterSetting { get; }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformProperty("dedicated_host_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DedicatedHostCount { get; }

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
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformProperty("internal_load_balancing_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InternalLoadBalancingMode { get; }

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
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformProperty("remote_debugging_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RemoteDebuggingEnabled { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("windows_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> WindowsOutboundIpAddresses { get; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ZoneRedundant { get; }

}
