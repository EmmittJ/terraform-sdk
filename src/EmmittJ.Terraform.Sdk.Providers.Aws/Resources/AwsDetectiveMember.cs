using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_detective_member resource.
/// </summary>
public class AwsDetectiveMember : TerraformResource
{
    public AwsDetectiveMember(string name) : base("aws_detective_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("administrator_id");
        this.DeclareOutput("disabled_reason");
        this.DeclareOutput("invited_time");
        this.DeclareOutput("status");
        this.DeclareOutput("updated_time");
        this.DeclareOutput("volume_usage_in_bytes");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableEmailNotification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_email_notification");
        set => this.WithProperty("disable_email_notification", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GraphArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("graph_arn");
        set => this.WithProperty("graph_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Message
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message");
        set => this.WithProperty("message", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The administrator_id attribute.
    /// </summary>
    public TerraformExpression AdministratorId => this["administrator_id"];

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    public TerraformExpression DisabledReason => this["disabled_reason"];

    /// <summary>
    /// The invited_time attribute.
    /// </summary>
    public TerraformExpression InvitedTime => this["invited_time"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The updated_time attribute.
    /// </summary>
    public TerraformExpression UpdatedTime => this["updated_time"];

    /// <summary>
    /// The volume_usage_in_bytes attribute.
    /// </summary>
    public TerraformExpression VolumeUsageInBytes => this["volume_usage_in_bytes"];

}
