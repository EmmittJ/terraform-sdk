using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusTopicDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_topic.
/// </summary>
public partial class AzurermServicebusTopicDataSource : TerraformDataSource
{
    public AzurermServicebusTopicDataSource(string name) : base("azurerm_servicebus_topic", name)
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
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespaceId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermServicebusTopicDataSourceTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformProperty("default_message_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultMessageTtl { get; }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformProperty("duplicate_detection_history_time_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DuplicateDetectionHistoryTimeWindow { get; }

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformProperty("enable_batched_operations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableBatchedOperations { get; }

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    [TerraformProperty("enable_express")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableExpress { get; }

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    [TerraformProperty("enable_partitioning")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnablePartitioning { get; }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformProperty("express_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExpressEnabled { get; }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformProperty("max_size_in_megabytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxSizeInMegabytes { get; }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformProperty("partitioning_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PartitioningEnabled { get; }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformProperty("requires_duplicate_detection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RequiresDuplicateDetection { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    [TerraformProperty("support_ordering")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportOrdering { get; }

}
