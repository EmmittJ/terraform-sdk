using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("relationship_status");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public TerraformProperty<string>? DetectorId
    {
        get => GetProperty<TerraformProperty<string>>("detector_id");
        set => this.WithProperty("detector_id", value);
    }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableEmailNotification
    {
        get => GetProperty<TerraformProperty<bool>>("disable_email_notification");
        set => this.WithProperty("disable_email_notification", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => this.WithProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    public TerraformProperty<string>? InvitationMessage
    {
        get => GetProperty<TerraformProperty<string>>("invitation_message");
        set => this.WithProperty("invitation_message", value);
    }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    public TerraformProperty<bool>? Invite
    {
        get => GetProperty<TerraformProperty<bool>>("invite");
        set => this.WithProperty("invite", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformExpression RelationshipStatus => this["relationship_status"];

}
