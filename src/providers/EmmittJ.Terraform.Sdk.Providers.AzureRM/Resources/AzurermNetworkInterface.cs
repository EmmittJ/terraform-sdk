using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkInterfaceIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The gateway_load_balancer_frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_load_balancer_frontend_ip_configuration_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GatewayLoadBalancerFrontendIpConfigurationId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "gateway_load_balancer_frontend_ip_configuration_id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Primary { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "primary");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address");

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddressAllocation is required")]
    [TerraformPropertyName("private_ip_address_allocation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateIpAddressAllocation { get; set; }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateIpAddressVersion { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_network_interface resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkInterface : TerraformResource
{
    public AzurermNetworkInterface(string name) : base("azurerm_network_interface", name)
    {
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_networking_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AcceleratedNetworkingEnabled { get; set; }

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformPropertyName("auxiliary_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuxiliaryMode { get; set; }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformPropertyName("auxiliary_sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuxiliarySku { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DnsServers { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformPropertyName("internal_dns_name_label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InternalDnsNameLabel { get; set; }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ip_forwarding_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IpForwardingEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [TerraformPropertyName("ip_configuration")]
    public TerraformList<TerraformBlock<AzurermNetworkInterfaceIpConfigurationBlock>>? IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkInterfaceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("applied_dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AppliedDnsServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "applied_dns_servers");

    /// <summary>
    /// The internal_domain_name_suffix attribute.
    /// </summary>
    [TerraformPropertyName("internal_domain_name_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InternalDomainNameSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "internal_domain_name_suffix");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformPropertyName("mac_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MacAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mac_address");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PrivateIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "private_ip_addresses");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualMachineId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_machine_id");

}
