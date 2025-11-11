using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_environment_v3.
/// </summary>
public class AzurermAppServiceEnvironmentV3DataSource : TerraformDataSource
{
    public AzurermAppServiceEnvironmentV3DataSource(string name) : base("azurerm_app_service_environment_v3", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    [TerraformPropertyName("allow_new_private_endpoint_connections")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowNewPrivateEndpointConnections => new TerraformReference(this, "allow_new_private_endpoint_connections");

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    [TerraformPropertyName("cluster_setting")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClusterSetting => new TerraformReference(this, "cluster_setting");

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DedicatedHostCount => new TerraformReference(this, "dedicated_host_count");

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformPropertyName("dns_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsSuffix => new TerraformReference(this, "dns_suffix");

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("external_inbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ExternalInboundIpAddresses => new TerraformReference(this, "external_inbound_ip_addresses");

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    [TerraformPropertyName("inbound_network_dependencies")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InboundNetworkDependencies => new TerraformReference(this, "inbound_network_dependencies");

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("internal_inbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InternalInboundIpAddresses => new TerraformReference(this, "internal_inbound_ip_addresses");

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformPropertyName("internal_load_balancing_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InternalLoadBalancingMode => new TerraformReference(this, "internal_load_balancing_mode");

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ip_ssl_address_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IpSslAddressCount => new TerraformReference(this, "ip_ssl_address_count");

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("linux_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> LinuxOutboundIpAddresses => new TerraformReference(this, "linux_outbound_ip_addresses");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformPropertyName("pricing_tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PricingTier => new TerraformReference(this, "pricing_tier");

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RemoteDebuggingEnabled => new TerraformReference(this, "remote_debugging_enabled");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("windows_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> WindowsOutboundIpAddresses => new TerraformReference(this, "windows_outbound_ip_addresses");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ZoneRedundant => new TerraformReference(this, "zone_redundant");

}
