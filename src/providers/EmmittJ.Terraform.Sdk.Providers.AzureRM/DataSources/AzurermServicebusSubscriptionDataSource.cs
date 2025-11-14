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
public class AzurermServicebusSubscriptionDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_servicebus_subscription.
/// </summary>
public class AzurermServicebusSubscriptionDataSource : TerraformDataSource
{
    public AzurermServicebusSubscriptionDataSource(string name) : base("azurerm_servicebus_subscription", name)
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
    /// The topic_id attribute.
    /// </summary>
    [TerraformArgument("topic_id")]
    public TerraformValue<string>? TopicId
    {
        get => new TerraformReference<string>(this, "topic_id");
        set => SetArgument("topic_id", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("topic_name")]
    public TerraformValue<string>? TopicName
    {
        get => new TerraformReference<string>(this, "topic_name");
        set => SetArgument("topic_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusSubscriptionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    [TerraformArgument("dead_lettering_on_filter_evaluation_error")]
    public TerraformValue<bool> DeadLetteringOnFilterEvaluationError
    {
        get => new TerraformReference<bool>(this, "dead_lettering_on_filter_evaluation_error");
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformArgument("dead_lettering_on_message_expiration")]
    public TerraformValue<bool> DeadLetteringOnMessageExpiration
    {
        get => new TerraformReference<bool>(this, "dead_lettering_on_message_expiration");
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
    /// The enable_batched_operations attribute.
    /// </summary>
    [TerraformArgument("enable_batched_operations")]
    public TerraformValue<bool> EnableBatchedOperations
    {
        get => new TerraformReference<bool>(this, "enable_batched_operations");
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformArgument("forward_dead_lettered_messages_to")]
    public TerraformValue<string> ForwardDeadLetteredMessagesTo
    {
        get => new TerraformReference<string>(this, "forward_dead_lettered_messages_to");
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformArgument("forward_to")]
    public TerraformValue<string> ForwardTo
    {
        get => new TerraformReference<string>(this, "forward_to");
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformArgument("lock_duration")]
    public TerraformValue<string> LockDuration
    {
        get => new TerraformReference<string>(this, "lock_duration");
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformArgument("max_delivery_count")]
    public TerraformValue<double> MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformArgument("requires_session")]
    public TerraformValue<bool> RequiresSession
    {
        get => new TerraformReference<bool>(this, "requires_session");
    }

}
