using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_platform_application resource.
/// </summary>
public class AwsSnsPlatformApplication : TerraformResource
{
    public AwsSnsPlatformApplication(string name) : base("aws_sns_platform_application", name)
    {
    }

    /// <summary>
    /// The apple_platform_bundle_id attribute.
    /// </summary>
    [TerraformPropertyName("apple_platform_bundle_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplePlatformBundleId { get; set; }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    [TerraformPropertyName("apple_platform_team_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplePlatformTeamId { get; set; }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_delivery_failure_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventDeliveryFailureTopicArn { get; set; }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_endpoint_created_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventEndpointCreatedTopicArn { get; set; }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_endpoint_deleted_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventEndpointDeletedTopicArn { get; set; }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_endpoint_updated_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventEndpointUpdatedTopicArn { get; set; }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    [TerraformPropertyName("platform")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Platform { get; set; }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformCredential is required")]
    [TerraformPropertyName("platform_credential")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PlatformCredential { get; set; }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    [TerraformPropertyName("platform_principal")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PlatformPrincipal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
