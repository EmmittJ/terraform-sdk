using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadNamedLocationDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_named_location Terraform data source.
/// Retrieves information about a azuread_named_location.
/// </summary>
public partial class AzureadNamedLocationDataSource(string name) : TerraformDataSource("azuread_named_location", name)
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
    /// The country attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Country
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "country").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ip
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip").ResolveNodes(ctx));
    }

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadNamedLocationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadNamedLocationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
