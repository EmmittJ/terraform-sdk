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
        SetOutput("administrator_id");
        SetOutput("disabled_reason");
        SetOutput("invited_time");
        SetOutput("status");
        SetOutput("updated_time");
        SetOutput("volume_usage_in_bytes");
        SetOutput("account_id");
        SetOutput("disable_email_notification");
        SetOutput("email_address");
        SetOutput("graph_arn");
        SetOutput("id");
        SetOutput("message");
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
    /// The disable_email_notification attribute.
    /// </summary>
    public TerraformProperty<bool> DisableEmailNotification
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_email_notification");
        set => SetProperty("disable_email_notification", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformProperty<string> EmailAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_address");
        set => SetProperty("email_address", value);
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    public required TerraformProperty<string> GraphArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("graph_arn");
        set => SetProperty("graph_arn", value);
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
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string> Message
    {
        get => GetRequiredOutput<TerraformProperty<string>>("message");
        set => SetProperty("message", value);
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
