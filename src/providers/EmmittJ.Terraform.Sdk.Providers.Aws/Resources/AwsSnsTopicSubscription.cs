using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_topic_subscription resource.
/// </summary>
public class AwsSnsTopicSubscription : TerraformResource
{
    public AwsSnsTopicSubscription(string name) : base("aws_sns_topic_subscription", name)
    {
    }

    /// <summary>
    /// The confirmation_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("confirmation_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ConfirmationTimeoutInMinutes { get; set; }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    [TerraformPropertyName("delivery_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeliveryPolicy { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_auto_confirms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EndpointAutoConfirms { get; set; }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    [TerraformPropertyName("filter_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FilterPolicy { get; set; }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    [TerraformPropertyName("filter_policy_scope")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FilterPolicyScope { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    [TerraformPropertyName("raw_message_delivery")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RawMessageDelivery { get; set; }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [TerraformPropertyName("redrive_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedrivePolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replay_policy attribute.
    /// </summary>
    [TerraformPropertyName("replay_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReplayPolicy { get; set; }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("subscription_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubscriptionRoleArn { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformPropertyName("topic_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TopicArn { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The confirmation_was_authenticated attribute.
    /// </summary>
    [TerraformPropertyName("confirmation_was_authenticated")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ConfirmationWasAuthenticated => new TerraformReference(this, "confirmation_was_authenticated");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The pending_confirmation attribute.
    /// </summary>
    [TerraformPropertyName("pending_confirmation")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PendingConfirmation => new TerraformReference(this, "pending_confirmation");

}
