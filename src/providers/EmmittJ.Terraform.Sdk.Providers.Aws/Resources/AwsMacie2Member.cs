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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
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
    /// The invitation_disable_email_notification attribute.
    /// </summary>
    public TerraformValue<bool>? InvitationDisableEmailNotification
    {
        get => new TerraformReference<bool>(this, "invitation_disable_email_notification");
        set => SetArgument("invitation_disable_email_notification", value);
    }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    public TerraformValue<string>? InvitationMessage
    {
        get => new TerraformReference<string>(this, "invitation_message");
        set => SetArgument("invitation_message", value);
    }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    public TerraformValue<bool> Invite
    {
        get => new TerraformReference<bool>(this, "invite");
        set => SetArgument("invite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    public TerraformValue<string> AdministratorAccountId
    {
        get => new TerraformReference<string>(this, "administrator_account_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The invited_at attribute.
    /// </summary>
    public TerraformValue<string> InvitedAt
    {
        get => new TerraformReference<string>(this, "invited_at");
    }

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountId
    {
        get => new TerraformReference<string>(this, "master_account_id");
    }

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformValue<string> RelationshipStatus
    {
        get => new TerraformReference<string>(this, "relationship_status");
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2MemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2MemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
