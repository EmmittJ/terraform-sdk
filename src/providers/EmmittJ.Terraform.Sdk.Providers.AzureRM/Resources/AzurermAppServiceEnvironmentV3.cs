using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cluster_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceEnvironmentV3ClusterSettingBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3TimeoutsBlock
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
/// Manages a azurerm_app_service_environment_v3 resource.
/// </summary>
public class AzurermAppServiceEnvironmentV3 : TerraformResource
{
    public AzurermAppServiceEnvironmentV3(string name) : base("azurerm_app_service_environment_v3", name)
    {
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    [TerraformPropertyName("allow_new_private_endpoint_connections")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowNewPrivateEndpointConnections { get; set; }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DedicatedHostCount { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformPropertyName("internal_load_balancing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InternalLoadBalancingMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

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
    /// Block for cluster_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cluster_setting")]
    public TerraformList<TerraformBlock<AzurermAppServiceEnvironmentV3ClusterSettingBlock>>? ClusterSetting { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceEnvironmentV3TimeoutsBlock>? Timeouts { get; set; }

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
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("windows_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> WindowsOutboundIpAddresses => new TerraformReference(this, "windows_outbound_ip_addresses");

}
