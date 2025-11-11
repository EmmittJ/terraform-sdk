using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_queue.
/// </summary>
public class AzurermServicebusQueueDataSource : TerraformDataSource
{
    public AzurermServicebusQueueDataSource(string name) : base("azurerm_servicebus_queue", name)
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
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamespaceId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusQueueDataSourceTimeoutsBlock>? Timeouts { get; set; }

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
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformPropertyName("duplicate_detection_history_time_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DuplicateDetectionHistoryTimeWindow => new TerraformReference(this, "duplicate_detection_history_time_window");

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformPropertyName("enable_batched_operations")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableBatchedOperations => new TerraformReference(this, "enable_batched_operations");

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    [TerraformPropertyName("enable_express")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableExpress => new TerraformReference(this, "enable_express");

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    [TerraformPropertyName("enable_partitioning")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnablePartitioning => new TerraformReference(this, "enable_partitioning");

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformPropertyName("express_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExpressEnabled => new TerraformReference(this, "express_enabled");

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
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformPropertyName("max_size_in_megabytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxSizeInMegabytes => new TerraformReference(this, "max_size_in_megabytes");

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("partitioning_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PartitioningEnabled => new TerraformReference(this, "partitioning_enabled");

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformPropertyName("requires_duplicate_detection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequiresDuplicateDetection => new TerraformReference(this, "requires_duplicate_detection");

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformPropertyName("requires_session")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequiresSession => new TerraformReference(this, "requires_session");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
