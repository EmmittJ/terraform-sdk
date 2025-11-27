using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for country in AzureadNamedLocation.
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationCountryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "country";

    /// <summary>
    /// The countries_and_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountriesAndRegions is required")]
    public TerraformList<string>? CountriesAndRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "countries_and_regions").ResolveNodes(ctx));
        set => SetArgument("countries_and_regions", value);
    }

    /// <summary>
    /// The country_lookup_method attribute.
    /// </summary>
    public TerraformValue<string>? CountryLookupMethod
    {
        get => new TerraformReference<string>(this, "country_lookup_method");
        set => SetArgument("country_lookup_method", value);
    }

    /// <summary>
    /// The include_unknown_countries_and_regions attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeUnknownCountriesAndRegions
    {
        get => new TerraformReference<bool>(this, "include_unknown_countries_and_regions");
        set => SetArgument("include_unknown_countries_and_regions", value);
    }

}


/// <summary>
/// Block type for ip in AzureadNamedLocation.
/// Nesting mode: list
/// </summary>
public class AzureadNamedLocationIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip";

    /// <summary>
    /// The ip_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRanges is required")]
    public TerraformList<string>? IpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_ranges").ResolveNodes(ctx));
        set => SetArgument("ip_ranges", value);
    }

    /// <summary>
    /// The trusted attribute.
    /// </summary>
    public TerraformValue<bool>? Trusted
    {
        get => new TerraformReference<bool>(this, "trusted");
        set => SetArgument("trusted", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadNamedLocation.
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_named_location Terraform resource.
/// Manages a azuread_named_location resource.
/// </summary>
public partial class AzureadNamedLocation(string name) : TerraformResource("azuread_named_location", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// Country block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Country block(s) allowed")]
    public TerraformList<AzureadNamedLocationCountryBlock>? Country
    {
        get => GetArgument<TerraformList<AzureadNamedLocationCountryBlock>>("country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// Ip block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ip block(s) allowed")]
    public TerraformList<AzureadNamedLocationIpBlock>? Ip
    {
        get => GetArgument<TerraformList<AzureadNamedLocationIpBlock>>("ip");
        set => SetArgument("ip", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadNamedLocationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadNamedLocationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
