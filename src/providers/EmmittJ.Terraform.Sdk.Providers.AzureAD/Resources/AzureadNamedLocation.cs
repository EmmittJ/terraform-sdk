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
        get => GetProperty<List<TerraformProperty<string>>>("countries_and_regions");
        set => WithProperty("countries_and_regions", value);
    }

    /// <summary>
    /// The country_lookup_method attribute.
    /// </summary>
    public TerraformProperty<string>? CountryLookupMethod
    {
        get => GetProperty<TerraformProperty<string>>("country_lookup_method");
        set => WithProperty("country_lookup_method", value);
    }

    /// <summary>
    /// The include_unknown_countries_and_regions attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeUnknownCountriesAndRegions
    {
        get => GetProperty<TerraformProperty<bool>>("include_unknown_countries_and_regions");
        set => WithProperty("include_unknown_countries_and_regions", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("ip_ranges");
        set => WithProperty("ip_ranges", value);
    }

    /// <summary>
    /// The trusted attribute.
    /// </summary>
    public TerraformProperty<bool>? Trusted
    {
        get => GetProperty<TerraformProperty<bool>>("trusted");
        set => WithProperty("trusted", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("object_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for country.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Country block(s) allowed")]
    public List<AzureadNamedLocationCountryBlock>? Country
    {
        get => GetProperty<List<AzureadNamedLocationCountryBlock>>("country");
        set => this.WithProperty("country", value);
    }

    /// <summary>
    /// Block for ip.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ip block(s) allowed")]
    public List<AzureadNamedLocationIpBlock>? Ip
    {
        get => GetProperty<List<AzureadNamedLocationIpBlock>>("ip");
        set => this.WithProperty("ip", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadNamedLocationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadNamedLocationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
