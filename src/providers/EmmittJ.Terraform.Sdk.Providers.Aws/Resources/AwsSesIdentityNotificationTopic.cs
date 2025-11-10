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
        SetOutput("id");
        SetOutput("identity");
        SetOutput("include_original_headers");
        SetOutput("notification_type");
        SetOutput("region");
        SetOutput("topic_arn");
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
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    public required TerraformProperty<string> Identity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity");
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The include_original_headers attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeOriginalHeaders
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_original_headers");
        set => SetProperty("include_original_headers", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    public required TerraformProperty<string> NotificationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_type");
        set => SetProperty("notification_type", value);
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
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> TopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_arn");
        set => SetProperty("topic_arn", value);
    }

}
