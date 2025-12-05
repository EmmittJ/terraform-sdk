using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ses_identity_notification_topic Terraform resource.
/// Manages a aws_ses_identity_notification_topic resource.
/// </summary>
public partial class AwsSesIdentityNotificationTopic(string name) : TerraformResource("aws_ses_identity_notification_topic", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    public required TerraformValue<string> Identity
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The include_original_headers attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeOriginalHeaders
    {
        get => GetArgument<TerraformValue<bool>>("include_original_headers");
        set => SetArgument("include_original_headers", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformValue<string> NotificationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_type");
        set => SetArgument("notification_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}
