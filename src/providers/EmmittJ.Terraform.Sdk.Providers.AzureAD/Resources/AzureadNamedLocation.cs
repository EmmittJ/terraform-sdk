using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for country in .
/// Nesting mode: list
/// </summary>
public partial class AzureadNamedLocationCountryBlock() : TerraformBlock("country")
{
    /// <summary>
    /// The countries_and_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountriesAndRegions is required")]
    [TerraformProperty("countries_and_regions")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? CountriesAndRegions { get; set; }

    /// <summary>
    /// The country_lookup_method attribute.
    /// </summary>
    [TerraformProperty("country_lookup_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CountryLookupMethod { get; set; }

    /// <summary>
    /// The include_unknown_countries_and_regions attribute.
    /// </summary>
    [TerraformProperty("include_unknown_countries_and_regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeUnknownCountriesAndRegions { get; set; }

}

/// <summary>
/// Block type for ip in .
/// Nesting mode: list
/// </summary>
public partial class AzureadNamedLocationIpBlock() : TerraformBlock("ip")
{
    /// <summary>
    /// The ip_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRanges is required")]
    [TerraformProperty("ip_ranges")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? IpRanges { get; set; }

    /// <summary>
    /// The trusted attribute.
    /// </summary>
    [TerraformProperty("trusted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Trusted { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadNamedLocationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azuread_named_location resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadNamedLocation : TerraformResource
{
    public AzureadNamedLocation(string name) : base("azuread_named_location", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for country.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Country block(s) allowed")]
    [TerraformProperty("country")]
    public TerraformList<AzureadNamedLocationCountryBlock> Country { get; set; } = new();

    /// <summary>
    /// Block for ip.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ip block(s) allowed")]
    [TerraformProperty("ip")]
    public TerraformList<AzureadNamedLocationIpBlock> Ip { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadNamedLocationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

}
