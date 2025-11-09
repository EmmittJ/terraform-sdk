using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_member resource.
/// </summary>
public class AwsMacie2Member : TerraformResource
{
    public AwsMacie2Member(string name) : base("aws_macie2_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("administrator_account_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("invited_at");
        this.DeclareOutput("master_account_id");
        this.DeclareOutput("relationship_status");
        this.DeclareOutput("updated_at");
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
    /// The invitation_disable_email_notification attribute.
    /// </summary>
    public TerraformProperty<bool>? InvitationDisableEmailNotification
    {
        get => GetProperty<TerraformProperty<bool>>("invitation_disable_email_notification");
        set => this.WithProperty("invitation_disable_email_notification", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    public TerraformExpression AdministratorAccountId => this["administrator_account_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The invited_at attribute.
    /// </summary>
    public TerraformExpression InvitedAt => this["invited_at"];

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformExpression MasterAccountId => this["master_account_id"];

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformExpression RelationshipStatus => this["relationship_status"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
