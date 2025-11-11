using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_identity_notification_topic resource.
/// </summary>
public partial class AwsSesIdentityNotificationTopic : TerraformResource
{
    public AwsSesIdentityNotificationTopic(string name) : base("aws_ses_identity_notification_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [TerraformProperty("identity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Identity { get; set; }

    /// <summary>
    /// The include_original_headers attribute.
    /// </summary>
    [TerraformProperty("include_original_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeOriginalHeaders { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationType is required")]
    [TerraformProperty("notification_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NotificationType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformProperty("topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TopicArn { get; set; }

}
