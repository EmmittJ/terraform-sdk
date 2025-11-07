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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Identity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// The include_original_headers attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeOriginalHeaders
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_original_headers");
        set => this.WithProperty("include_original_headers", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_type");
        set => this.WithProperty("notification_type", value);
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
    /// The topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_arn");
        set => this.WithProperty("topic_arn", value);
    }

}
