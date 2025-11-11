using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for country in .
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationCountryBlock
{
    /// <summary>
    /// The countries_and_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountriesAndRegions is required")]
    [TerraformPropertyName("countries_and_regions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? CountriesAndRegions { get; set; }

    /// <summary>
    /// The country_lookup_method attribute.
    /// </summary>
    [TerraformPropertyName("country_lookup_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CountryLookupMethod { get; set; }

    /// <summary>
    /// The include_unknown_countries_and_regions attribute.
    /// </summary>
    [TerraformPropertyName("include_unknown_countries_and_regions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeUnknownCountriesAndRegions { get; set; }

}

/// <summary>
/// Block type for ip in .
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationIpBlock
{
    /// <summary>
    /// The ip_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRanges is required")]
    [TerraformPropertyName("ip_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? IpRanges { get; set; }

    /// <summary>
    /// The trusted attribute.
    /// </summary>
    [TerraformPropertyName("trusted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Trusted { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_named_location resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadNamedLocation : TerraformResource
{
    public AzureadNamedLocation(string name) : base("azuread_named_location", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for country.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Country block(s) allowed")]
    [TerraformPropertyName("country")]
    public TerraformList<TerraformBlock<AzureadNamedLocationCountryBlock>>? Country { get; set; }

    /// <summary>
    /// Block for ip.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ip block(s) allowed")]
    [TerraformPropertyName("ip")]
    public TerraformList<TerraformBlock<AzureadNamedLocationIpBlock>>? Ip { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadNamedLocationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectId => new TerraformReference(this, "object_id");

}
