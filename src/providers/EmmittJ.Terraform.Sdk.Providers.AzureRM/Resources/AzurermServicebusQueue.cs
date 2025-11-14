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
public class AzurermServicebusQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("auto_delete_on_idle")]
    public TerraformValue<string> AutoDeleteOnIdle
    {
        get => new TerraformReference<string>(this, "auto_delete_on_idle");
        set => SetArgument("auto_delete_on_idle", value);
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformArgument("batched_operations_enabled")]
    public TerraformValue<bool>? BatchedOperationsEnabled
    {
        get => new TerraformReference<bool>(this, "batched_operations_enabled");
        set => SetArgument("batched_operations_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformArgument("dead_lettering_on_message_expiration")]
    public TerraformValue<bool>? DeadLetteringOnMessageExpiration
    {
        get => new TerraformReference<bool>(this, "dead_lettering_on_message_expiration");
        set => SetArgument("dead_lettering_on_message_expiration", value);
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformArgument("default_message_ttl")]
    public TerraformValue<string> DefaultMessageTtl
    {
        get => new TerraformReference<string>(this, "default_message_ttl");
        set => SetArgument("default_message_ttl", value);
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    [TerraformArgument("duplicate_detection_history_time_window")]
    public TerraformValue<string>? DuplicateDetectionHistoryTimeWindow
    {
        get => new TerraformReference<string>(this, "duplicate_detection_history_time_window");
        set => SetArgument("duplicate_detection_history_time_window", value);
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    [TerraformArgument("express_enabled")]
    public TerraformValue<bool>? ExpressEnabled
    {
        get => new TerraformReference<bool>(this, "express_enabled");
        set => SetArgument("express_enabled", value);
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformArgument("forward_dead_lettered_messages_to")]
    public TerraformValue<string>? ForwardDeadLetteredMessagesTo
    {
        get => new TerraformReference<string>(this, "forward_dead_lettered_messages_to");
        set => SetArgument("forward_dead_lettered_messages_to", value);
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformArgument("forward_to")]
    public TerraformValue<string>? ForwardTo
    {
        get => new TerraformReference<string>(this, "forward_to");
        set => SetArgument("forward_to", value);
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
    /// The lock_duration attribute.
    /// </summary>
    [TerraformArgument("lock_duration")]
    public TerraformValue<string>? LockDuration
    {
        get => new TerraformReference<string>(this, "lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformArgument("max_delivery_count")]
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    [TerraformArgument("max_message_size_in_kilobytes")]
    public TerraformValue<double> MaxMessageSizeInKilobytes
    {
        get => new TerraformReference<double>(this, "max_message_size_in_kilobytes");
        set => SetArgument("max_message_size_in_kilobytes", value);
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    [TerraformArgument("max_size_in_megabytes")]
    public TerraformValue<double> MaxSizeInMegabytes
    {
        get => new TerraformReference<double>(this, "max_size_in_megabytes");
        set => SetArgument("max_size_in_megabytes", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformArgument("namespace_id")]
    public required TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    [TerraformArgument("partitioning_enabled")]
    public TerraformValue<bool>? PartitioningEnabled
    {
        get => new TerraformReference<bool>(this, "partitioning_enabled");
        set => SetArgument("partitioning_enabled", value);
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    [TerraformArgument("requires_duplicate_detection")]
    public TerraformValue<bool>? RequiresDuplicateDetection
    {
        get => new TerraformReference<bool>(this, "requires_duplicate_detection");
        set => SetArgument("requires_duplicate_detection", value);
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformArgument("requires_session")]
    public TerraformValue<bool>? RequiresSession
    {
        get => new TerraformReference<bool>(this, "requires_session");
        set => SetArgument("requires_session", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusQueueTimeoutsBlock Timeouts { get; set; } = new();

}
