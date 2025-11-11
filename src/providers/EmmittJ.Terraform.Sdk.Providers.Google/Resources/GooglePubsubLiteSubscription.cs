using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for delivery_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubLiteSubscriptionDeliveryConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// When this subscription should send messages to subscribers relative to messages persistence in storage. Possible values: [&amp;quot;DELIVER_IMMEDIATELY&amp;quot;, &amp;quot;DELIVER_AFTER_STORED&amp;quot;, &amp;quot;DELIVERY_REQUIREMENT_UNSPECIFIED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryRequirement is required")]
    [TerraformProperty("delivery_requirement")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DeliveryRequirement { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePubsubLiteSubscriptionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_pubsub_lite_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePubsubLiteSubscription : TerraformResource
{
    public GooglePubsubLiteSubscription(string name) : base("google_pubsub_lite_subscription", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region of the pubsub lite topic.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// A reference to a Topic resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Topic { get; set; }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for delivery_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryConfig block(s) allowed")]
    [TerraformProperty("delivery_config")]
    public TerraformList<TerraformBlock<GooglePubsubLiteSubscriptionDeliveryConfigBlock>>? DeliveryConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GooglePubsubLiteSubscriptionTimeoutsBlock>? Timeouts { get; set; }

}
