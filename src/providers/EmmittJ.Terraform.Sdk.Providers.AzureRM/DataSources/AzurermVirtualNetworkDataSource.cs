using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network.
/// </summary>
public partial class AzurermVirtualNetworkDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkDataSource(string name) : base("azurerm_virtual_network", name)
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
    public TerraformBlock<AzurermVirtualNetworkDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformProperty("address_space")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AddressSpace { get; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> DnsServers { get; }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformProperty("guid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Guid { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformProperty("subnets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Subnets { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The vnet_peerings attribute.
    /// </summary>
    [TerraformProperty("vnet_peerings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> VnetPeerings { get; }

    /// <summary>
    /// The vnet_peerings_addresses attribute.
    /// </summary>
    [TerraformProperty("vnet_peerings_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> VnetPeeringsAddresses { get; }

}
