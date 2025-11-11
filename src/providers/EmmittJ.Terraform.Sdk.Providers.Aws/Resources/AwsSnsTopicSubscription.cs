using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_topic_subscription resource.
/// </summary>
public partial class AwsSnsTopicSubscription : TerraformResource
{
    public AwsSnsTopicSubscription(string name) : base("aws_sns_topic_subscription", name)
    {
    }

    /// <summary>
    /// The confirmation_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("confirmation_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ConfirmationTimeoutInMinutes { get; set; }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    [TerraformProperty("delivery_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeliveryPolicy { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    [TerraformProperty("endpoint_auto_confirms")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EndpointAutoConfirms { get; set; }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    [TerraformProperty("filter_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FilterPolicy { get; set; }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    [TerraformProperty("filter_policy_scope")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FilterPolicyScope { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    [TerraformProperty("raw_message_delivery")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RawMessageDelivery { get; set; }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [TerraformProperty("redrive_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RedrivePolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replay_policy attribute.
    /// </summary>
    [TerraformProperty("replay_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReplayPolicy { get; set; }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    [TerraformProperty("subscription_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubscriptionRoleArn { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformProperty("topic_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TopicArn { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The confirmation_was_authenticated attribute.
    /// </summary>
    [TerraformProperty("confirmation_was_authenticated")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ConfirmationWasAuthenticated { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The pending_confirmation attribute.
    /// </summary>
    [TerraformProperty("pending_confirmation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PendingConfirmation { get; }

}
