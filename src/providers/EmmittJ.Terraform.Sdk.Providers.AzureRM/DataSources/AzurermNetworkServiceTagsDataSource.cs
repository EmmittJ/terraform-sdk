using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkServiceTagsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    [TerraformPropertyName("location_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocationFilter { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkServiceTagsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("address_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AddressPrefixes => new TerraformReference(this, "address_prefixes");

    /// <summary>
    /// The ipv4_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_cidrs")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Ipv4Cidrs => new TerraformReference(this, "ipv4_cidrs");

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidrs")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Ipv6Cidrs => new TerraformReference(this, "ipv6_cidrs");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
