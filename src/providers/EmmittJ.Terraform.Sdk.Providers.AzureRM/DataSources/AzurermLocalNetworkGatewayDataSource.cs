using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLocalNetworkGatewayDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_local_network_gateway.
/// </summary>
public class AzurermLocalNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermLocalNetworkGatewayDataSource(string name) : base("azurerm_local_network_gateway", name)
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
    public TerraformBlock<AzurermLocalNetworkGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformPropertyName("address_space")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AddressSpace => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "address_space");

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformPropertyName("bgp_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BgpSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bgp_settings");

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformPropertyName("gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_address");

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("gateway_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_fqdn");

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

}
