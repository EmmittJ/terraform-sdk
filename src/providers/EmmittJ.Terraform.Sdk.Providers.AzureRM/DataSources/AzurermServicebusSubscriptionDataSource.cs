using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_subscription.
/// </summary>
public class AzurermServicebusSubscriptionDataSource : TerraformDataSource
{
    public AzurermServicebusSubscriptionDataSource(string name) : base("azurerm_servicebus_subscription", name)
    {
    }

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
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("namespace_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamespaceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("resource_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceGroupName { get; set; }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    [TerraformPropertyName("topic_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicId { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("topic_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusSubscriptionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformPropertyName("auto_delete_on_idle")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutoDeleteOnIdle => new TerraformReference(this, "auto_delete_on_idle");

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("batched_operations_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> BatchedOperationsEnabled => new TerraformReference(this, "batched_operations_enabled");

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    [TerraformPropertyName("dead_lettering_on_filter_evaluation_error")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeadLetteringOnFilterEvaluationError => new TerraformReference(this, "dead_lettering_on_filter_evaluation_error");

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformPropertyName("dead_lettering_on_message_expiration")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeadLetteringOnMessageExpiration => new TerraformReference(this, "dead_lettering_on_message_expiration");

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_message_ttl")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultMessageTtl => new TerraformReference(this, "default_message_ttl");

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformPropertyName("enable_batched_operations")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableBatchedOperations => new TerraformReference(this, "enable_batched_operations");

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_dead_lettered_messages_to")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ForwardDeadLetteredMessagesTo => new TerraformReference(this, "forward_dead_lettered_messages_to");

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_to")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ForwardTo => new TerraformReference(this, "forward_to");

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformPropertyName("lock_duration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LockDuration => new TerraformReference(this, "lock_duration");

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformPropertyName("max_delivery_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDeliveryCount => new TerraformReference(this, "max_delivery_count");

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformPropertyName("requires_session")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequiresSession => new TerraformReference(this, "requires_session");

}
