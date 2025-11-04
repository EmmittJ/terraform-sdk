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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public string? Identity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity")?.Value;
        set => this.WithProperty("identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The include_original_headers attribute.
    /// </summary>
    public bool? IncludeOriginalHeaders
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_original_headers")?.Value;
        set => this.WithProperty("include_original_headers", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    public string? NotificationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_type")?.Value;
        set => this.WithProperty("notification_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public string? TopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_arn")?.Value;
        set => this.WithProperty("topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
