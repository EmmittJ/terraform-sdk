using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_zone.
/// </summary>
public class AzurermPrivateDnsZoneDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneDataSource(string name) : base("azurerm_private_dns_zone", name)
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
    [TerraformPropertyName("resource_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_group_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPrivateDnsZoneDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxNumberOfRecordSets => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_number_of_record_sets");

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_virtual_network_links")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxNumberOfVirtualNetworkLinks => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_number_of_virtual_network_links");

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_virtual_network_links_with_registration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxNumberOfVirtualNetworkLinksWithRegistration => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_number_of_virtual_network_links_with_registration");

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("number_of_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumberOfRecordSets => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "number_of_record_sets");

}
