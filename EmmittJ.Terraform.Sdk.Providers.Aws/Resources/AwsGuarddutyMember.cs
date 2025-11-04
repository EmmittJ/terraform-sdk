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
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public string? DetectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_id")?.Value;
        set => this.WithProperty("detector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    public bool? DisableEmailNotification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_email_notification")?.Value;
        set => this.WithProperty("disable_email_notification", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    public string? InvitationMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("invitation_message")?.Value;
        set => this.WithProperty("invitation_message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    public bool? Invite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("invite")?.Value;
        set => this.WithProperty("invite", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformExpression RelationshipStatus => this["relationship_status"];

}
