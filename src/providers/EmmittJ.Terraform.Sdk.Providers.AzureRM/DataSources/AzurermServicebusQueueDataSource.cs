using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_queue.
/// </summary>
public class AzurermServicebusQueueDataSource : TerraformDataSource
{
    public AzurermServicebusQueueDataSource(string name) : base("azurerm_servicebus_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("auto_delete_on_idle");
        this.WithOutput("batched_operations_enabled");
        this.WithOutput("dead_lettering_on_message_expiration");
        this.WithOutput("default_message_ttl");
        this.WithOutput("duplicate_detection_history_time_window");
        this.WithOutput("enable_batched_operations");
        this.WithOutput("enable_express");
        this.WithOutput("enable_partitioning");
        this.WithOutput("express_enabled");
        this.WithOutput("forward_dead_lettered_messages_to");
        this.WithOutput("forward_to");
        this.WithOutput("lock_duration");
        this.WithOutput("max_delivery_count");
        this.WithOutput("max_size_in_megabytes");
        this.WithOutput("partitioning_enabled");
        this.WithOutput("requires_duplicate_detection");
        this.WithOutput("requires_session");
        this.WithOutput("status");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("namespace_id");
        set => this.WithProperty("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? NamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusQueueDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermServicebusQueueDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformExpression AutoDeleteOnIdle => this["auto_delete_on_idle"];

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformExpression BatchedOperationsEnabled => this["batched_operations_enabled"];

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformExpression DeadLetteringOnMessageExpiration => this["dead_lettering_on_message_expiration"];

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformExpression DefaultMessageTtl => this["default_message_ttl"];

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public TerraformExpression DuplicateDetectionHistoryTimeWindow => this["duplicate_detection_history_time_window"];

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    public TerraformExpression EnableBatchedOperations => this["enable_batched_operations"];

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    public TerraformExpression EnableExpress => this["enable_express"];

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    public TerraformExpression EnablePartitioning => this["enable_partitioning"];

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public TerraformExpression ExpressEnabled => this["express_enabled"];

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public TerraformExpression ForwardDeadLetteredMessagesTo => this["forward_dead_lettered_messages_to"];

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public TerraformExpression ForwardTo => this["forward_to"];

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformExpression LockDuration => this["lock_duration"];

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformExpression MaxDeliveryCount => this["max_delivery_count"];

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public TerraformExpression MaxSizeInMegabytes => this["max_size_in_megabytes"];

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public TerraformExpression PartitioningEnabled => this["partitioning_enabled"];

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public TerraformExpression RequiresDuplicateDetection => this["requires_duplicate_detection"];

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public TerraformExpression RequiresSession => this["requires_session"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
