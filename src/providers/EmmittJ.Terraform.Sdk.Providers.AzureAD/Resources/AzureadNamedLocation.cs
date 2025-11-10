using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for country in .
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationCountryBlock : TerraformBlock
{
    /// <summary>
    /// The countries_and_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountriesAndRegions is required")]
    public List<TerraformProperty<string>>? CountriesAndRegions
    {
        set => SetProperty("countries_and_regions", value);
    }

    /// <summary>
    /// The country_lookup_method attribute.
    /// </summary>
    public TerraformProperty<string>? CountryLookupMethod
    {
        set => SetProperty("country_lookup_method", value);
    }

    /// <summary>
    /// The include_unknown_countries_and_regions attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeUnknownCountriesAndRegions
    {
        set => SetProperty("include_unknown_countries_and_regions", value);
    }

}

/// <summary>
/// Block type for ip in .
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationIpBlock : TerraformBlock
{
    /// <summary>
    /// The ip_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRanges is required")]
    public List<TerraformProperty<string>>? IpRanges
    {
        set => SetProperty("ip_ranges", value);
    }

    /// <summary>
    /// The trusted attribute.
    /// </summary>
    public TerraformProperty<bool>? Trusted
    {
        set => SetProperty("trusted", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_named_location resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadNamedLocation : TerraformResource
{
    public AzureadNamedLocation(string name) : base("azuread_named_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("object_id");
        SetOutput("display_name");
        SetOutput("id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for country.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Country block(s) allowed")]
    public List<AzureadNamedLocationCountryBlock>? Country
    {
        set => SetProperty("country", value);
    }

    /// <summary>
    /// Block for ip.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ip block(s) allowed")]
    public List<AzureadNamedLocationIpBlock>? Ip
    {
        set => SetProperty("ip", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadNamedLocationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
