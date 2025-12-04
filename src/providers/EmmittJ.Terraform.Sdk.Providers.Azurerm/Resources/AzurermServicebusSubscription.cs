using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for client_scoped_subscription in AzurermServicebusSubscription.
/// Nesting mode: list
/// </summary>
public class AzurermServicebusSubscriptionClientScopedSubscriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_scoped_subscription";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The is_client_scoped_subscription_durable attribute.
    /// </summary>
    public TerraformValue<bool> IsClientScopedSubscriptionDurable
        => AsReference("is_client_scoped_subscription_durable");

    /// <summary>
    /// The is_client_scoped_subscription_shareable attribute.
    /// </summary>
    public TerraformValue<bool>? IsClientScopedSubscriptionShareable
    {
        get => GetArgument<TerraformValue<bool>>("is_client_scoped_subscription_shareable");
        set => SetArgument("is_client_scoped_subscription_shareable", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermServicebusSubscription.
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_servicebus_subscription Terraform resource.
/// Manages a azurerm_servicebus_subscription resource.
/// </summary>
public partial class AzurermServicebusSubscription(string name) : TerraformResource("azurerm_servicebus_subscription", name)
{
    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformValue<string>? AutoDeleteOnIdle
    {
        get => GetArgument<TerraformValue<string>>("auto_delete_on_idle");
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
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientScopedSubscriptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("client_scoped_subscription_enabled");
        set => SetArgument("client_scoped_subscription_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public TerraformValue<bool>? DeadLetteringOnFilterEvaluationError
    {
        get => GetArgument<TerraformValue<bool>>("dead_lettering_on_filter_evaluation_error");
        set => SetArgument("dead_lettering_on_filter_evaluation_error", value);
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
    public TerraformValue<string>? DefaultMessageTtl
    {
        get => GetArgument<TerraformValue<string>>("default_message_ttl");
        set => SetArgument("default_message_ttl", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryCount is required")]
    public required TerraformValue<double> MaxDeliveryCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_delivery_count");
        set => SetArgument("max_delivery_count", value);
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
    /// The topic_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    public required TerraformValue<string> TopicId
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_id");
        set => SetArgument("topic_id", value);
    }

    /// <summary>
    /// ClientScopedSubscription block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientScopedSubscription block(s) allowed")]
    public TerraformList<AzurermServicebusSubscriptionClientScopedSubscriptionBlock>? ClientScopedSubscription
    {
        get => GetArgument<TerraformList<AzurermServicebusSubscriptionClientScopedSubscriptionBlock>>("client_scoped_subscription");
        set => SetArgument("client_scoped_subscription", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
