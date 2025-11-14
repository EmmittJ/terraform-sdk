using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusTopicDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformArgument("namespace_id")]
    public TerraformValue<string>? NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("namespace_name")]
    public TerraformValue<string>? NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("resource_group_name")]
    public TerraformValue<string>? ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusTopicDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformArgument("auto_delete_on_idle")]
    public TerraformValue<string> AutoDeleteOnIdle
    {
        get => new TerraformReference<string>(this, "auto_delete_on_idle");
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformArgument("batched_operations_enabled")]
    public TerraformValue<bool> BatchedOperationsEnabled
    {
        get => new TerraformReference<bool>(this, "batched_operations_enabled");
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformArgument("default_message_ttl")]
    public TerraformValue<string> DefaultMessageTtl
    {
        get => new TerraformReference<string>(this, "default_message_ttl");
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformArgument("duplicate_detection_history_time_window")]
    public TerraformValue<string> DuplicateDetectionHistoryTimeWindow
    {
        get => new TerraformReference<string>(this, "duplicate_detection_history_time_window");
    }

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformArgument("enable_batched_operations")]
    public TerraformValue<bool> EnableBatchedOperations
    {
        get => new TerraformReference<bool>(this, "enable_batched_operations");
    }

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    [TerraformArgument("enable_express")]
    public TerraformValue<bool> EnableExpress
    {
        get => new TerraformReference<bool>(this, "enable_express");
    }

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    [TerraformArgument("enable_partitioning")]
    public TerraformValue<bool> EnablePartitioning
    {
        get => new TerraformReference<bool>(this, "enable_partitioning");
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformArgument("express_enabled")]
    public TerraformValue<bool> ExpressEnabled
    {
        get => new TerraformReference<bool>(this, "express_enabled");
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformArgument("max_size_in_megabytes")]
    public TerraformValue<double> MaxSizeInMegabytes
    {
        get => new TerraformReference<double>(this, "max_size_in_megabytes");
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformArgument("partitioning_enabled")]
    public TerraformValue<bool> PartitioningEnabled
    {
        get => new TerraformReference<bool>(this, "partitioning_enabled");
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformArgument("requires_duplicate_detection")]
    public TerraformValue<bool> RequiresDuplicateDetection
    {
        get => new TerraformReference<bool>(this, "requires_duplicate_detection");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    [TerraformArgument("support_ordering")]
    public TerraformValue<bool> SupportOrdering
    {
        get => new TerraformReference<bool>(this, "support_ordering");
    }

}
