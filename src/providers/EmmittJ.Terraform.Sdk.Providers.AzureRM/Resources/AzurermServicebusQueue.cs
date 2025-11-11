using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusQueueTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_queue resource.
/// </summary>
public partial class AzurermServicebusQueue : TerraformResource
{
    public AzurermServicebusQueue(string name) : base("azurerm_servicebus_queue", name)
    {
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformProperty("auto_delete_on_idle")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AutoDeleteOnIdle { get; set; }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformProperty("batched_operations_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchedOperationsEnabled { get; set; }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformProperty("dead_lettering_on_message_expiration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformProperty("default_message_ttl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultMessageTtl { get; set; }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformProperty("duplicate_detection_history_time_window")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformProperty("express_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExpressEnabled { get; set; }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformProperty("forward_dead_lettered_messages_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformProperty("forward_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardTo { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformProperty("lock_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformProperty("max_delivery_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxDeliveryCount { get; set; }

    /// <summary>
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    [TerraformProperty("max_message_size_in_kilobytes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxMessageSizeInKilobytes { get; set; }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformProperty("max_size_in_megabytes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxSizeInMegabytes { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformProperty("namespace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespaceId { get; set; }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformProperty("partitioning_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PartitioningEnabled { get; set; }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformProperty("requires_duplicate_detection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequiresDuplicateDetection { get; set; }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformProperty("requires_session")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequiresSession { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermServicebusQueueTimeoutsBlock>? Timeouts { get; set; }

}
