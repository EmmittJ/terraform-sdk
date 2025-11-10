using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkServiceTagsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_network_service_tags.
/// </summary>
public class AzurermNetworkServiceTagsDataSource : TerraformDataSource
{
    public AzurermNetworkServiceTagsDataSource(string name) : base("azurerm_network_service_tags", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    [TerraformPropertyName("location_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocationFilter { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkServiceTagsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("address_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AddressPrefixes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "address_prefixes");

    /// <summary>
    /// The ipv4_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_cidrs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Ipv4Cidrs => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv4_cidrs");

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidrs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Ipv6Cidrs => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv6_cidrs");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
