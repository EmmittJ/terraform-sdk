using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAdministrativeUnitDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_administrative_unit Terraform data source.
/// Retrieves information about a azuread_administrative_unit.
/// </summary>
public partial class AzureadAdministrativeUnitDataSource(string name) : TerraformDataSource("azuread_administrative_unit", name)
{
    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    public TerraformValue<string> DisplayName
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
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// A list of object IDs of members who are be present in this administrative unit.
    /// </summary>
    public TerraformList<string> Members
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "members").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public TerraformValue<string> Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAdministrativeUnitDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAdministrativeUnitDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
