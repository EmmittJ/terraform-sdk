using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusTopicDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_topic.
/// </summary>
public class AzurermServicebusTopicDataSource : TerraformDataSource
{
    public AzurermServicebusTopicDataSource(string name) : base("azurerm_servicebus_topic", name)
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
    public TerraformBlock<AzurermServicebusTopicDataSourceTimeoutsBlock>? Timeouts { get; set; }

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
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    [TerraformPropertyName("support_ordering")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportOrdering => new TerraformReference(this, "support_ordering");

}
