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
    public TerraformProperty<TerraformProperty<double>>? ConfirmationTimeoutInMinutes { get; set; }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    [TerraformPropertyName("delivery_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeliveryPolicy { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Endpoint { get; set; }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_auto_confirms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EndpointAutoConfirms { get; set; }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    [TerraformPropertyName("filter_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterPolicy { get; set; }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    [TerraformPropertyName("filter_policy_scope")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FilterPolicyScope { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "filter_policy_scope");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    [TerraformPropertyName("raw_message_delivery")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RawMessageDelivery { get; set; }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [TerraformPropertyName("redrive_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RedrivePolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replay_policy attribute.
    /// </summary>
    [TerraformPropertyName("replay_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplayPolicy { get; set; }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("subscription_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubscriptionRoleArn { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformPropertyName("topic_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TopicArn { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The confirmation_was_authenticated attribute.
    /// </summary>
    [TerraformPropertyName("confirmation_was_authenticated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ConfirmationWasAuthenticated => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "confirmation_was_authenticated");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The pending_confirmation attribute.
    /// </summary>
    [TerraformPropertyName("pending_confirmation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PendingConfirmation => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "pending_confirmation");

}
