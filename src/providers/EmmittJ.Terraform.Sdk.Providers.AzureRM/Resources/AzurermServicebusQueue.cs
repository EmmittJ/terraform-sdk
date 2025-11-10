using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_servicebus_queue resource.
/// </summary>
public class AzurermServicebusQueue : TerraformResource
{
    public AzurermServicebusQueue(string name) : base("azurerm_servicebus_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_delete_on_idle");
        SetOutput("batched_operations_enabled");
        SetOutput("dead_lettering_on_message_expiration");
        SetOutput("default_message_ttl");
        SetOutput("duplicate_detection_history_time_window");
        SetOutput("express_enabled");
        SetOutput("forward_dead_lettered_messages_to");
        SetOutput("forward_to");
        SetOutput("id");
        SetOutput("lock_duration");
        SetOutput("max_delivery_count");
        SetOutput("max_message_size_in_kilobytes");
        SetOutput("max_size_in_megabytes");
        SetOutput("name");
        SetOutput("namespace_id");
        SetOutput("partitioning_enabled");
        SetOutput("requires_duplicate_detection");
        SetOutput("requires_session");
        SetOutput("status");
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformProperty<string> AutoDeleteOnIdle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_delete_on_idle");
        set => SetProperty("auto_delete_on_idle", value);
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BatchedOperationsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("batched_operations_enabled");
        set => SetProperty("batched_operations_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformProperty<bool> DeadLetteringOnMessageExpiration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dead_lettering_on_message_expiration");
        set => SetProperty("dead_lettering_on_message_expiration", value);
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformProperty<string> DefaultMessageTtl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_message_ttl");
        set => SetProperty("default_message_ttl", value);
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public TerraformProperty<string> DuplicateDetectionHistoryTimeWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("duplicate_detection_history_time_window");
        set => SetProperty("duplicate_detection_history_time_window", value);
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ExpressEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("express_enabled");
        set => SetProperty("express_enabled", value);
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public TerraformProperty<string> ForwardDeadLetteredMessagesTo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("forward_dead_lettered_messages_to");
        set => SetProperty("forward_dead_lettered_messages_to", value);
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public TerraformProperty<string> ForwardTo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("forward_to");
        set => SetProperty("forward_to", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformProperty<string> LockDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lock_duration");
        set => SetProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double> MaxDeliveryCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_delivery_count");
        set => SetProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    public TerraformProperty<double> MaxMessageSizeInKilobytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_message_size_in_kilobytes");
        set => SetProperty("max_message_size_in_kilobytes", value);
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public TerraformProperty<double> MaxSizeInMegabytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_size_in_megabytes");
        set => SetProperty("max_size_in_megabytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformProperty<string> NamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_id");
        set => SetProperty("namespace_id", value);
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PartitioningEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("partitioning_enabled");
        set => SetProperty("partitioning_enabled", value);
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public TerraformProperty<bool> RequiresDuplicateDetection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("requires_duplicate_detection");
        set => SetProperty("requires_duplicate_detection", value);
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public TerraformProperty<bool> RequiresSession
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("requires_session");
        set => SetProperty("requires_session", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusQueueTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
