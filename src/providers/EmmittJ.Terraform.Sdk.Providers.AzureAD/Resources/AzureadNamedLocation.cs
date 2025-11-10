using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for country in .
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationCountryBlock : ITerraformBlock
{
    /// <summary>
    /// The countries_and_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountriesAndRegions is required")]
    [TerraformPropertyName("countries_and_regions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? CountriesAndRegions { get; set; }

    /// <summary>
    /// The country_lookup_method attribute.
    /// </summary>
    [TerraformPropertyName("country_lookup_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CountryLookupMethod { get; set; }

    /// <summary>
    /// The include_unknown_countries_and_regions attribute.
    /// </summary>
    [TerraformPropertyName("include_unknown_countries_and_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeUnknownCountriesAndRegions { get; set; }

}

/// <summary>
/// Block type for ip in .
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationIpBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRanges is required")]
    [TerraformPropertyName("ip_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? IpRanges { get; set; }

    /// <summary>
    /// The trusted attribute.
    /// </summary>
    [TerraformPropertyName("trusted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Trusted { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for country.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Country block(s) allowed")]
    [TerraformPropertyName("country")]
    public TerraformList<TerraformBlock<AzureadNamedLocationCountryBlock>>? Country { get; set; } = new();

    /// <summary>
    /// Block for ip.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ip block(s) allowed")]
    [TerraformPropertyName("ip")]
    public TerraformList<TerraformBlock<AzureadNamedLocationIpBlock>>? Ip { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadNamedLocationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

}
