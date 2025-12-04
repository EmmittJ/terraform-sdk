using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAdministrativeUnitRoleMember.
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitRoleMemberTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azuread_administrative_unit_role_member Terraform resource.
/// Manages a azuread_administrative_unit_role_member resource.
/// </summary>
public partial class AzureadAdministrativeUnitRoleMember(string name) : TerraformResource("azuread_administrative_unit_role_member", name)
{
    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministrativeUnitObjectId is required")]
    public required TerraformValue<string> AdministrativeUnitObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("administrative_unit_object_id");
        set => SetArgument("administrative_unit_object_id", value);
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
    /// The object ID of the member
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberObjectId is required")]
    public required TerraformValue<string> MemberObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("member_object_id");
        set => SetArgument("member_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleObjectId is required")]
    public required TerraformValue<string> RoleObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_object_id");
        set => SetArgument("role_object_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAdministrativeUnitRoleMemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAdministrativeUnitRoleMemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
