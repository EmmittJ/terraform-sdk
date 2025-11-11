using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusSubscriptionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_subscription.
/// </summary>
public partial class AzurermServicebusSubscriptionDataSource : TerraformDataSource
{
    public AzurermServicebusSubscriptionDataSource(string name) : base("azurerm_servicebus_subscription", name)
    {
    }

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
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("namespace_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespaceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("resource_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceGroupName { get; set; }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    [TerraformProperty("topic_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TopicId { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("topic_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TopicName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermServicebusSubscriptionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformProperty("auto_delete_on_idle")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AutoDeleteOnIdle { get; }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformProperty("batched_operations_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> BatchedOperationsEnabled { get; }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    [TerraformProperty("dead_lettering_on_filter_evaluation_error")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeadLetteringOnFilterEvaluationError { get; }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformProperty("dead_lettering_on_message_expiration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeadLetteringOnMessageExpiration { get; }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformProperty("default_message_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultMessageTtl { get; }

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformProperty("enable_batched_operations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableBatchedOperations { get; }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformProperty("forward_dead_lettered_messages_to")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ForwardDeadLetteredMessagesTo { get; }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformProperty("forward_to")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ForwardTo { get; }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformProperty("lock_duration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LockDuration { get; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformProperty("max_delivery_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxDeliveryCount { get; }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformProperty("requires_session")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RequiresSession { get; }

}
