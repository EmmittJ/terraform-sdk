using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    [TerraformPropertyName("allow_new_private_endpoint_connections")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowNewPrivateEndpointConnections => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_new_private_endpoint_connections");

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    [TerraformPropertyName("cluster_setting")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterSetting => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_setting");

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DedicatedHostCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "dedicated_host_count");

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformPropertyName("dns_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_suffix");

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("external_inbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ExternalInboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "external_inbound_ip_addresses");

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    [TerraformPropertyName("inbound_network_dependencies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InboundNetworkDependencies => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "inbound_network_dependencies");

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("internal_inbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InternalInboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "internal_inbound_ip_addresses");

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformPropertyName("internal_load_balancing_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InternalLoadBalancingMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "internal_load_balancing_mode");

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ip_ssl_address_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IpSslAddressCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ip_ssl_address_count");

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("linux_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LinuxOutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "linux_outbound_ip_addresses");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformPropertyName("pricing_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PricingTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pricing_tier");

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RemoteDebuggingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "remote_debugging_enabled");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("windows_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> WindowsOutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "windows_outbound_ip_addresses");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ZoneRedundant => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_redundant");

}
