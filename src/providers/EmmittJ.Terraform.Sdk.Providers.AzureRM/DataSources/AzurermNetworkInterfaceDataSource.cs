using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkInterfaceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_network_interface.
/// </summary>
public partial class AzurermNetworkInterfaceDataSource : TerraformDataSource
{
    public AzurermNetworkInterfaceDataSource(string name) : base("azurerm_network_interface", name)
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
    public TerraformBlock<AzurermNetworkInterfaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformProperty("accelerated_networking_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AcceleratedNetworkingEnabled { get; }

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformProperty("applied_dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AppliedDnsServers { get; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> DnsServers { get; }

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformProperty("internal_dns_name_label")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InternalDnsNameLabel { get; }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformProperty("ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpConfiguration { get; }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformProperty("ip_forwarding_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IpForwardingEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformProperty("mac_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MacAddress { get; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformProperty("network_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkSecurityGroupId { get; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PrivateIpAddresses { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformProperty("virtual_machine_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualMachineId { get; }

}
