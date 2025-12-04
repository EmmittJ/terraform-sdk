using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadGroupMember.
/// Nesting mode: single
/// </summary>
public class AzureadGroupMemberTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_group_member Terraform resource.
/// Manages a azuread_group_member resource.
/// </summary>
public partial class AzureadGroupMember(string name) : TerraformResource("azuread_group_member", name)
{
    /// <summary>
    /// The object ID of the group you want to add the member to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupObjectId is required")]
    public required TerraformValue<string> GroupObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_object_id");
        set => SetArgument("group_object_id", value);
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
    /// The object ID of the principal you want to add as a member to the group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberObjectId is required")]
    public required TerraformValue<string> MemberObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("member_object_id");
        set => SetArgument("member_object_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadGroupMemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadGroupMemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
