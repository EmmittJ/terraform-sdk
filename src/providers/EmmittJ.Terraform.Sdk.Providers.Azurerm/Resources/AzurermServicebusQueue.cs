using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicebusQueue.
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_servicebus_queue Terraform resource.
/// Manages a azurerm_servicebus_queue resource.
/// </summary>
public partial class AzurermServicebusQueue(string name) : TerraformResource("azurerm_servicebus_queue", name)
{
    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformValue<string> AutoDeleteOnIdle
    {
        get => GetArgument<TerraformValue<string>>("auto_delete_on_idle") ?? AsReference("auto_delete_on_idle");
        set => SetArgument("auto_delete_on_idle", value);
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BatchedOperationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("batched_operations_enabled");
        set => SetArgument("batched_operations_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformValue<bool>? DeadLetteringOnMessageExpiration
    {
        get => GetArgument<TerraformValue<bool>>("dead_lettering_on_message_expiration");
        set => SetArgument("dead_lettering_on_message_expiration", value);
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformValue<string> DefaultMessageTtl
    {
        get => GetArgument<TerraformValue<string>>("default_message_ttl") ?? AsReference("default_message_ttl");
        set => SetArgument("default_message_ttl", value);
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public TerraformValue<string>? DuplicateDetectionHistoryTimeWindow
    {
        get => GetArgument<TerraformValue<string>>("duplicate_detection_history_time_window");
        set => SetArgument("duplicate_detection_history_time_window", value);
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExpressEnabled
    {
        get => GetArgument<TerraformValue<bool>>("express_enabled");
        set => SetArgument("express_enabled", value);
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public TerraformValue<string>? ForwardDeadLetteredMessagesTo
    {
        get => GetArgument<TerraformValue<string>>("forward_dead_lettered_messages_to");
        set => SetArgument("forward_dead_lettered_messages_to", value);
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public TerraformValue<string>? ForwardTo
    {
        get => GetArgument<TerraformValue<string>>("forward_to");
        set => SetArgument("forward_to", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformValue<string>? LockDuration
    {
        get => GetArgument<TerraformValue<string>>("lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    public TerraformValue<double> MaxMessageSizeInKilobytes
    {
        get => GetArgument<TerraformValue<double>>("max_message_size_in_kilobytes") ?? AsReference("max_message_size_in_kilobytes");
        set => SetArgument("max_message_size_in_kilobytes", value);
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeInMegabytes
    {
        get => GetArgument<TerraformValue<double>>("max_size_in_megabytes") ?? AsReference("max_size_in_megabytes");
        set => SetArgument("max_size_in_megabytes", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformValue<string> NamespaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PartitioningEnabled
    {
        get => GetArgument<TerraformValue<bool>>("partitioning_enabled");
        set => SetArgument("partitioning_enabled", value);
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public TerraformValue<bool>? RequiresDuplicateDetection
    {
        get => GetArgument<TerraformValue<bool>>("requires_duplicate_detection");
        set => SetArgument("requires_duplicate_detection", value);
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public TerraformValue<bool>? RequiresSession
    {
        get => GetArgument<TerraformValue<bool>>("requires_session");
        set => SetArgument("requires_session", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusQueueTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusQueueTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
