using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_platform_application resource.
/// </summary>
public partial class AwsSnsPlatformApplication : TerraformResource
{
    public AwsSnsPlatformApplication(string name) : base("aws_sns_platform_application", name)
    {
    }

    /// <summary>
    /// The apple_platform_bundle_id attribute.
    /// </summary>
    [TerraformProperty("apple_platform_bundle_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplePlatformBundleId { get; set; }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    [TerraformProperty("apple_platform_team_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplePlatformTeamId { get; set; }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    [TerraformProperty("event_delivery_failure_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventDeliveryFailureTopicArn { get; set; }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    [TerraformProperty("event_endpoint_created_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventEndpointCreatedTopicArn { get; set; }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    [TerraformProperty("event_endpoint_deleted_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventEndpointDeletedTopicArn { get; set; }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    [TerraformProperty("event_endpoint_updated_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventEndpointUpdatedTopicArn { get; set; }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("failure_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    [TerraformProperty("platform")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Platform { get; set; }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformCredential is required")]
    [TerraformProperty("platform_credential")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PlatformCredential { get; set; }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    [TerraformProperty("platform_principal")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlatformPrincipal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The success_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("success_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformProperty("success_feedback_sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
