using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsGuarddutyMember.
/// Nesting mode: single
/// </summary>
public class AwsGuarddutyMemberTimeoutsBlock : TerraformBlock
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
/// Represents a aws_guardduty_member Terraform resource.
/// Manages a aws_guardduty_member resource.
/// </summary>
public partial class AwsGuarddutyMember(string name) : TerraformResource("aws_guardduty_member", name)
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
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("detector_id");
        set => SetArgument("detector_id", value);
    }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    public TerraformValue<bool>? DisableEmailNotification
    {
        get => GetArgument<TerraformValue<bool>>("disable_email_notification");
        set => SetArgument("disable_email_notification", value);
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    public TerraformValue<bool>? Invite
    {
        get => GetArgument<TerraformValue<bool>>("invite");
        set => SetArgument("invite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformValue<string> RelationshipStatus
        => CreateReference("relationship_status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGuarddutyMemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGuarddutyMemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
