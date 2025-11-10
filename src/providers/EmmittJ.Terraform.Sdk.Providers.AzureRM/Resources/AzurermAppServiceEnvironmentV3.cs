using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cluster_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceEnvironmentV3ClusterSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3TimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AllowNewPrivateEndpointConnections { get; set; }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DedicatedHostCount { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformPropertyName("internal_load_balancing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InternalLoadBalancingMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneRedundant { get; set; }

    /// <summary>
    /// Block for cluster_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cluster_setting")]
    public TerraformList<TerraformBlock<AzurermAppServiceEnvironmentV3ClusterSettingBlock>>? ClusterSetting { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceEnvironmentV3TimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("windows_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> WindowsOutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "windows_outbound_ip_addresses");

}
