using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_identity_notification_topic resource.
/// </summary>
public class AwsSesIdentityNotificationTopic : TerraformResource
{
    public AwsSesIdentityNotificationTopic(string name) : base("aws_ses_identity_notification_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    public required TerraformProperty<string> Identity
    {
        get => GetProperty<TerraformProperty<string>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// The include_original_headers attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeOriginalHeaders
    {
        get => GetProperty<TerraformProperty<bool>>("include_original_headers");
        set => this.WithProperty("include_original_headers", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformProperty<string> NotificationType
    {
        get => GetProperty<TerraformProperty<string>>("notification_type");
        set => this.WithProperty("notification_type", value);
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
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => this.WithProperty("topic_arn", value);
    }

}
