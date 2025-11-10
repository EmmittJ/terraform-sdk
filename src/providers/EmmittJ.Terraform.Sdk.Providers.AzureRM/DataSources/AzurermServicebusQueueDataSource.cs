using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NamespaceId { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("namespace_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NamespaceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("resource_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusQueueDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformPropertyName("auto_delete_on_idle")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutoDeleteOnIdle => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_delete_on_idle");

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("batched_operations_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BatchedOperationsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "batched_operations_enabled");

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformPropertyName("dead_lettering_on_message_expiration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeadLetteringOnMessageExpiration => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "dead_lettering_on_message_expiration");

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_message_ttl")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultMessageTtl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_message_ttl");

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformPropertyName("duplicate_detection_history_time_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DuplicateDetectionHistoryTimeWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "duplicate_detection_history_time_window");

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformPropertyName("enable_batched_operations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableBatchedOperations => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_batched_operations");

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    [TerraformPropertyName("enable_express")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableExpress => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_express");

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    [TerraformPropertyName("enable_partitioning")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnablePartitioning => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_partitioning");

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformPropertyName("express_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExpressEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "express_enabled");

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_dead_lettered_messages_to")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ForwardDeadLetteredMessagesTo => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "forward_dead_lettered_messages_to");

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_to")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ForwardTo => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "forward_to");

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformPropertyName("lock_duration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LockDuration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lock_duration");

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformPropertyName("max_delivery_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDeliveryCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_delivery_count");

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformPropertyName("max_size_in_megabytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxSizeInMegabytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size_in_megabytes");

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("partitioning_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PartitioningEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "partitioning_enabled");

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformPropertyName("requires_duplicate_detection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequiresDuplicateDetection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "requires_duplicate_detection");

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformPropertyName("requires_session")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequiresSession => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "requires_session");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
