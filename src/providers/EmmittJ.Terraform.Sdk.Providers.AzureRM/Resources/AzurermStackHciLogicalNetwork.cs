using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStackHciLogicalNetworkSubnetBlock() : TerraformBlock("subnet")
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformProperty("address_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressPrefix { get; set; }

    /// <summary>
    /// The ip_allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAllocationMethod is required")]
    [TerraformProperty("ip_allocation_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpAllocationMethod { get; set; }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformProperty("vlan_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VlanId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStackHciLogicalNetworkTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_stack_hci_logical_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStackHciLogicalNetwork : TerraformResource
{
    public AzurermStackHciLogicalNetwork(string name) : base("azurerm_stack_hci_logical_network", name)
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformProperty("custom_location_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomLocationId { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_switch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualSwitchName is required")]
    [TerraformProperty("virtual_switch_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualSwitchName { get; set; }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subnet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    [TerraformProperty("subnet")]
    public required TerraformList<AzurermStackHciLogicalNetworkSubnetBlock> Subnet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStackHciLogicalNetworkTimeoutsBlock Timeouts { get; set; } = new();

}
