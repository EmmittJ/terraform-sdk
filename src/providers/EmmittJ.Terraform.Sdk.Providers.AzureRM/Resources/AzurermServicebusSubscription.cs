using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for client_scoped_subscription in .
/// Nesting mode: list
/// </summary>
public class AzurermServicebusSubscriptionClientScopedSubscriptionBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The is_client_scoped_subscription_durable attribute.
    /// </summary>
    public TerraformProperty<bool>? IsClientScopedSubscriptionDurable
    {
        set => SetProperty("is_client_scoped_subscription_durable", value);
    }

    /// <summary>
    /// The is_client_scoped_subscription_shareable attribute.
    /// </summary>
    public TerraformProperty<bool>? IsClientScopedSubscriptionShareable
    {
        set => SetProperty("is_client_scoped_subscription_shareable", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_servicebus_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServicebusSubscription : TerraformResource
{
    public AzurermServicebusSubscription(string name) : base("azurerm_servicebus_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_delete_on_idle");
        SetOutput("batched_operations_enabled");
        SetOutput("client_scoped_subscription_enabled");
        SetOutput("dead_lettering_on_filter_evaluation_error");
        SetOutput("dead_lettering_on_message_expiration");
        SetOutput("default_message_ttl");
        SetOutput("forward_dead_lettered_messages_to");
        SetOutput("forward_to");
        SetOutput("id");
        SetOutput("lock_duration");
        SetOutput("max_delivery_count");
        SetOutput("name");
        SetOutput("requires_session");
        SetOutput("status");
        SetOutput("topic_id");
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
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ClientScopedSubscriptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("client_scoped_subscription_enabled");
        set => SetProperty("client_scoped_subscription_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public TerraformProperty<bool> DeadLetteringOnFilterEvaluationError
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dead_lettering_on_filter_evaluation_error");
        set => SetProperty("dead_lettering_on_filter_evaluation_error", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryCount is required")]
    public required TerraformProperty<double> MaxDeliveryCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_delivery_count");
        set => SetProperty("max_delivery_count", value);
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
    /// The topic_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    public required TerraformProperty<string> TopicId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_id");
        set => SetProperty("topic_id", value);
    }

    /// <summary>
    /// Block for client_scoped_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientScopedSubscription block(s) allowed")]
    public List<AzurermServicebusSubscriptionClientScopedSubscriptionBlock>? ClientScopedSubscription
    {
        set => SetProperty("client_scoped_subscription", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
