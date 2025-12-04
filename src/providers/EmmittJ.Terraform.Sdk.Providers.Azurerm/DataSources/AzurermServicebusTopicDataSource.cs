using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicebusTopicDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_servicebus_topic Terraform data source.
/// Retrieves information about a azurerm_servicebus_topic.
/// </summary>
public partial class AzurermServicebusTopicDataSource(string name) : TerraformDataSource("azurerm_servicebus_topic", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceId
    {
        get => GetArgument<TerraformValue<string>>("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformValue<string> AutoDeleteOnIdle
        => AsReference("auto_delete_on_idle");

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BatchedOperationsEnabled
        => AsReference("batched_operations_enabled");

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformValue<string> DefaultMessageTtl
        => AsReference("default_message_ttl");

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public TerraformValue<string> DuplicateDetectionHistoryTimeWindow
        => AsReference("duplicate_detection_history_time_window");

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    public TerraformValue<bool> EnableBatchedOperations
        => AsReference("enable_batched_operations");

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    public TerraformValue<bool> EnableExpress
        => AsReference("enable_express");

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    public TerraformValue<bool> EnablePartitioning
        => AsReference("enable_partitioning");

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ExpressEnabled
        => AsReference("express_enabled");

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeInMegabytes
        => AsReference("max_size_in_megabytes");

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PartitioningEnabled
        => AsReference("partitioning_enabled");

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public TerraformValue<bool> RequiresDuplicateDetection
        => AsReference("requires_duplicate_detection");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    public TerraformValue<bool> SupportOrdering
        => AsReference("support_ordering");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusTopicDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusTopicDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
