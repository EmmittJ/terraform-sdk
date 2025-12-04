using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsMacie2Member.
/// Nesting mode: single
/// </summary>
public class AwsMacie2MemberTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_macie2_member Terraform resource.
/// Manages a aws_macie2_member resource.
/// </summary>
public partial class AwsMacie2Member(string name) : TerraformResource("aws_macie2_member", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
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
    /// The invitation_disable_email_notification attribute.
    /// </summary>
    public TerraformValue<bool>? InvitationDisableEmailNotification
    {
        get => GetArgument<TerraformValue<bool>>("invitation_disable_email_notification");
        set => SetArgument("invitation_disable_email_notification", value);
    }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    public TerraformValue<string>? InvitationMessage
    {
        get => GetArgument<TerraformValue<string>>("invitation_message");
        set => SetArgument("invitation_message", value);
    }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    public TerraformValue<bool> Invite
    {
        get => GetArgument<TerraformValue<bool>>("invite") ?? AsReference("invite");
        set => SetArgument("invite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? AsReference("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    public TerraformValue<string> AdministratorAccountId
        => AsReference("administrator_account_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The invited_at attribute.
    /// </summary>
    public TerraformValue<string> InvitedAt
        => AsReference("invited_at");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountId
        => AsReference("master_account_id");

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformValue<string> RelationshipStatus
        => AsReference("relationship_status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2MemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2MemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
