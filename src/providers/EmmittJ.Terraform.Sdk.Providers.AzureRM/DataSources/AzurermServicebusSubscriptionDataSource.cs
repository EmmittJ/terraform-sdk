using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_servicebus_subscription Terraform data source.
/// Retrieves information about a azurerm_servicebus_subscription.
/// </summary>
public partial class AzurermServicebusSubscriptionDataSource(string name) : TerraformDataSource("azurerm_servicebus_subscription", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public TerraformValue<string>? TopicId
    {
        get => new TerraformReference<string>(this, "topic_id");
        set => SetArgument("topic_id", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? TopicName
    {
        get => new TerraformReference<string>(this, "topic_name");
        set => SetArgument("topic_name", value);
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformValue<string> AutoDeleteOnIdle
    {
        get => new TerraformReference<string>(this, "auto_delete_on_idle");
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BatchedOperationsEnabled
    {
        get => new TerraformReference<bool>(this, "batched_operations_enabled");
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public TerraformValue<bool> DeadLetteringOnFilterEvaluationError
    {
        get => new TerraformReference<bool>(this, "dead_lettering_on_filter_evaluation_error");
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformValue<bool> DeadLetteringOnMessageExpiration
    {
        get => new TerraformReference<bool>(this, "dead_lettering_on_message_expiration");
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformValue<string> DefaultMessageTtl
    {
        get => new TerraformReference<string>(this, "default_message_ttl");
    }

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    public TerraformValue<bool> EnableBatchedOperations
    {
        get => new TerraformReference<bool>(this, "enable_batched_operations");
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public TerraformValue<string> ForwardDeadLetteredMessagesTo
    {
        get => new TerraformReference<string>(this, "forward_dead_lettered_messages_to");
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public TerraformValue<string> ForwardTo
    {
        get => new TerraformReference<string>(this, "forward_to");
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformValue<string> LockDuration
    {
        get => new TerraformReference<string>(this, "lock_duration");
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformValue<double> MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public TerraformValue<bool> RequiresSession
    {
        get => new TerraformReference<bool>(this, "requires_session");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusSubscriptionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
