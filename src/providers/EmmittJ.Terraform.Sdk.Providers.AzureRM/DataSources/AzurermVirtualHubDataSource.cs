using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_hub.
/// </summary>
public class AzurermVirtualHubDataSource : TerraformDataSource
{
    public AzurermVirtualHubDataSource(string name) : base("azurerm_virtual_hub", name)
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
    public TerraformBlock<AzurermVirtualHubDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_prefix");

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_route_table_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    [TerraformPropertyName("virtual_router_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VirtualRouterAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "virtual_router_asn");

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    [TerraformPropertyName("virtual_router_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VirtualRouterIps => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "virtual_router_ips");

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_wan_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualWanId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_wan_id");

}
