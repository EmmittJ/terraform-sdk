using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermNetworkInterfaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_networking_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AcceleratedNetworkingEnabled => new TerraformReference(this, "accelerated_networking_enabled");

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("applied_dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AppliedDnsServers => new TerraformReference(this, "applied_dns_servers");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> DnsServers => new TerraformReference(this, "dns_servers");

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformPropertyName("internal_dns_name_label")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InternalDnsNameLabel => new TerraformReference(this, "internal_dns_name_label");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpConfiguration => new TerraformReference(this, "ip_configuration");

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ip_forwarding_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IpForwardingEnabled => new TerraformReference(this, "ip_forwarding_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformPropertyName("mac_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MacAddress => new TerraformReference(this, "mac_address");

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkSecurityGroupId => new TerraformReference(this, "network_security_group_id");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIpAddress => new TerraformReference(this, "private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PrivateIpAddresses => new TerraformReference(this, "private_ip_addresses");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualMachineId => new TerraformReference(this, "virtual_machine_id");

}
