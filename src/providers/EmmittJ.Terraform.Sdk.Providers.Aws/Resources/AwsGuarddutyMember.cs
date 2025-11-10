using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGuarddutyMemberTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_guardduty_member resource.
/// </summary>
public class AwsGuarddutyMember : TerraformResource
{
    public AwsGuarddutyMember(string name) : base("aws_guardduty_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("relationship_status");
        SetOutput("account_id");
        SetOutput("detector_id");
        SetOutput("disable_email_notification");
        SetOutput("email");
        SetOutput("id");
        SetOutput("invitation_message");
        SetOutput("invite");
        SetOutput("region");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformProperty<string> DetectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detector_id");
        set => SetProperty("detector_id", value);
    }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    public TerraformProperty<bool> DisableEmailNotification
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_email_notification");
        set => SetProperty("disable_email_notification", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    public TerraformProperty<string> InvitationMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("invitation_message");
        set => SetProperty("invitation_message", value);
    }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    public TerraformProperty<bool> Invite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("invite");
        set => SetProperty("invite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGuarddutyMemberTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformExpression RelationshipStatus => this["relationship_status"];

}
