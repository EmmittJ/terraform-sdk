using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDirectoryRoleMember.
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleMemberTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_directory_role_member Terraform resource.
/// Manages a azuread_directory_role_member resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzureadDirectoryRoleMember(string name) : TerraformResource("azuread_directory_role_member", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    public TerraformValue<string>? MemberObjectId
    {
        get => GetArgument<TerraformValue<string>>("member_object_id");
        set => SetArgument("member_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformValue<string>? RoleObjectId
    {
        get => GetArgument<TerraformValue<string>>("role_object_id");
        set => SetArgument("role_object_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRoleMemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRoleMemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
