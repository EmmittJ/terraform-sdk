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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id") ?? AsReference("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// A list of object IDs of members who are be present in this administrative unit.
    /// </summary>
    public TerraformList<string> Members
        => AsReference("members");

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public TerraformValue<string> Visibility
        => AsReference("visibility");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAdministrativeUnitDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAdministrativeUnitDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
