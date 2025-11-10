using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network.
/// </summary>
public class AzurermVirtualNetworkDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkDataSource(string name) : base("azurerm_virtual_network", name)
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
    public TerraformBlock<AzurermVirtualNetworkDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformPropertyName("address_space")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AddressSpace => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "address_space");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DnsServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "dns_servers");

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformPropertyName("guid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Guid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "guid");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Subnets => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "subnets");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vnet_peerings attribute.
    /// </summary>
    [TerraformPropertyName("vnet_peerings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> VnetPeerings => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "vnet_peerings");

    /// <summary>
    /// The vnet_peerings_addresses attribute.
    /// </summary>
    [TerraformPropertyName("vnet_peerings_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VnetPeeringsAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vnet_peerings_addresses");

}
