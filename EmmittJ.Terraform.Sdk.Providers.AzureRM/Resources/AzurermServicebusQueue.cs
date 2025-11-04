using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public string? AutoDeleteOnIdle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_delete_on_idle")?.Value;
        set => this.WithProperty("auto_delete_on_idle", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public bool? BatchedOperationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("batched_operations_enabled")?.Value;
        set => this.WithProperty("batched_operations_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public bool? DeadLetteringOnMessageExpiration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dead_lettering_on_message_expiration")?.Value;
        set => this.WithProperty("dead_lettering_on_message_expiration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public string? DefaultMessageTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_message_ttl")?.Value;
        set => this.WithProperty("default_message_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public string? DuplicateDetectionHistoryTimeWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duplicate_detection_history_time_window")?.Value;
        set => this.WithProperty("duplicate_detection_history_time_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public bool? ExpressEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_enabled")?.Value;
        set => this.WithProperty("express_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public string? ForwardDeadLetteredMessagesTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_dead_lettered_messages_to")?.Value;
        set => this.WithProperty("forward_dead_lettered_messages_to", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public string? ForwardTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_to")?.Value;
        set => this.WithProperty("forward_to", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public string? LockDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_duration")?.Value;
        set => this.WithProperty("lock_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public double? MaxDeliveryCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_delivery_count")?.Value;
        set => this.WithProperty("max_delivery_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    public double? MaxMessageSizeInKilobytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_message_size_in_kilobytes")?.Value;
        set => this.WithProperty("max_message_size_in_kilobytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public double? MaxSizeInMegabytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size_in_megabytes")?.Value;
        set => this.WithProperty("max_size_in_megabytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public string? NamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_id")?.Value;
        set => this.WithProperty("namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public bool? PartitioningEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("partitioning_enabled")?.Value;
        set => this.WithProperty("partitioning_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public bool? RequiresDuplicateDetection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_duplicate_detection")?.Value;
        set => this.WithProperty("requires_duplicate_detection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public bool? RequiresSession
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_session")?.Value;
        set => this.WithProperty("requires_session", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
