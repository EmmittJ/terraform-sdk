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
/// Block type for client_scoped_subscription in .
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
    [TerraformArgument("client_id")]
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }


    /// <summary>
    /// The is_client_scoped_subscription_shareable attribute.
    /// </summary>
    [TerraformArgument("is_client_scoped_subscription_shareable")]
    public TerraformValue<bool>? IsClientScopedSubscriptionShareable
    {
        get => new TerraformReference<bool>(this, "is_client_scoped_subscription_shareable");
        set => SetArgument("is_client_scoped_subscription_shareable", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_servicebus_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServicebusSubscription : TerraformResource
{
    public AzurermServicebusSubscription(string name) : base("azurerm_servicebus_subscription", name)
    {
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformArgument("auto_delete_on_idle")]
    public TerraformValue<string>? AutoDeleteOnIdle
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
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    [TerraformArgument("client_scoped_subscription_enabled")]
    public TerraformValue<bool>? ClientScopedSubscriptionEnabled
    {
        get => new TerraformReference<bool>(this, "client_scoped_subscription_enabled");
        set => SetArgument("client_scoped_subscription_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    [TerraformArgument("dead_lettering_on_filter_evaluation_error")]
    public TerraformValue<bool>? DeadLetteringOnFilterEvaluationError
    {
        get => new TerraformReference<bool>(this, "dead_lettering_on_filter_evaluation_error");
        set => SetArgument("dead_lettering_on_filter_evaluation_error", value);
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
    public TerraformValue<string>? DefaultMessageTtl
    {
        get => new TerraformReference<string>(this, "default_message_ttl");
        set => SetArgument("default_message_ttl", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryCount is required")]
    [TerraformArgument("max_delivery_count")]
    public required TerraformValue<double> MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
        set => SetArgument("max_delivery_count", value);
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
    /// The topic_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    [TerraformArgument("topic_id")]
    public required TerraformValue<string> TopicId
    {
        get => new TerraformReference<string>(this, "topic_id");
        set => SetArgument("topic_id", value);
    }

    /// <summary>
    /// Block for client_scoped_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientScopedSubscription block(s) allowed")]
    [TerraformArgument("client_scoped_subscription")]
    public TerraformList<AzurermServicebusSubscriptionClientScopedSubscriptionBlock> ClientScopedSubscription { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusSubscriptionTimeoutsBlock Timeouts { get; set; } = new();

}
