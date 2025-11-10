using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_network_interface.
/// </summary>
public class AzurermNetworkInterfaceDataSource : TerraformDataSource
{
    public AzurermNetworkInterfaceDataSource(string name) : base("azurerm_network_interface", name)
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
    public TerraformBlock<AzurermNetworkInterfaceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_networking_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AcceleratedNetworkingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "accelerated_networking_enabled");

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("applied_dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AppliedDnsServers => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "applied_dns_servers");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DnsServers => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "dns_servers");

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformPropertyName("internal_dns_name_label")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InternalDnsNameLabel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "internal_dns_name_label");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip_configuration");

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ip_forwarding_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IpForwardingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ip_forwarding_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformPropertyName("mac_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MacAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mac_address");

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_security_group_id");

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualMachineId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_machine_id");

}
