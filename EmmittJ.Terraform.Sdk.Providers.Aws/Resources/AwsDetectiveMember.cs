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
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The email_address attribute.
    /// </summary>
    public string? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address")?.Value;
        set => this.WithProperty("email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    public string? GraphArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("graph_arn")?.Value;
        set => this.WithProperty("graph_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The message attribute.
    /// </summary>
    public string? Message
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message")?.Value;
        set => this.WithProperty("message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
