using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAdministrativeUnit.
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_administrative_unit Terraform resource.
/// Manages a azuread_administrative_unit resource.
/// </summary>
public partial class AzureadAdministrativeUnit(string name) : TerraformResource("azuread_administrative_unit", name)
{
    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public TerraformValue<bool>? HiddenMembershipEnabled
    {
        get => GetArgument<TerraformValue<bool>>("hidden_membership_enabled");
        set => SetArgument("hidden_membership_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups
    /// </summary>
    public TerraformSet<string>? Members
    {
        get => GetArgument<TerraformSet<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing administrative unit is found with the same name
    /// </summary>
    public TerraformValue<bool>? PreventDuplicateNames
    {
        get => GetArgument<TerraformValue<bool>>("prevent_duplicate_names");
        set => SetArgument("prevent_duplicate_names", value);
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformValue<string> ObjectId
        => AsReference("object_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAdministrativeUnitTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAdministrativeUnitTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
