using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_queue resource.
/// </summary>
public class AzurermServicebusQueue : TerraformResource
{
    public AzurermServicebusQueue(string name) : base("azurerm_servicebus_queue", name)
    {
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformPropertyName("auto_delete_on_idle")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoDeleteOnIdle { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_delete_on_idle");

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("batched_operations_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BatchedOperationsEnabled { get; set; }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformPropertyName("dead_lettering_on_message_expiration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_message_ttl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultMessageTtl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_message_ttl");

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformPropertyName("duplicate_detection_history_time_window")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformPropertyName("express_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExpressEnabled { get; set; }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_dead_lettered_messages_to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardTo { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformPropertyName("lock_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformPropertyName("max_delivery_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxDeliveryCount { get; set; }

    /// <summary>
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    [TerraformPropertyName("max_message_size_in_kilobytes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxMessageSizeInKilobytes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_message_size_in_kilobytes");

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformPropertyName("max_size_in_megabytes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxSizeInMegabytes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size_in_megabytes");

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformPropertyName("namespace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NamespaceId { get; set; }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("partitioning_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PartitioningEnabled { get; set; }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformPropertyName("requires_duplicate_detection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequiresDuplicateDetection { get; set; }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformPropertyName("requires_session")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequiresSession { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusQueueTimeoutsBlock>? Timeouts { get; set; } = new();

}
