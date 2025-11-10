using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_subscription.
/// </summary>
public class AzurermServicebusSubscriptionDataSource : TerraformDataSource
{
    public AzurermServicebusSubscriptionDataSource(string name) : base("azurerm_servicebus_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_delete_on_idle");
        SetOutput("batched_operations_enabled");
        SetOutput("dead_lettering_on_filter_evaluation_error");
        SetOutput("dead_lettering_on_message_expiration");
        SetOutput("default_message_ttl");
        SetOutput("enable_batched_operations");
        SetOutput("forward_dead_lettered_messages_to");
        SetOutput("forward_to");
        SetOutput("lock_duration");
        SetOutput("max_delivery_count");
        SetOutput("requires_session");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_name");
        SetOutput("resource_group_name");
        SetOutput("topic_id");
        SetOutput("topic_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public TerraformProperty<string> TopicId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_id");
        set => SetProperty("topic_id", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> TopicName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_name");
        set => SetProperty("topic_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public TerraformExpression DeadLetteringOnFilterEvaluationError => this["dead_lettering_on_filter_evaluation_error"];

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformExpression DeadLetteringOnMessageExpiration => this["dead_lettering_on_message_expiration"];

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformExpression DefaultMessageTtl => this["default_message_ttl"];

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    public TerraformExpression EnableBatchedOperations => this["enable_batched_operations"];

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
    /// The requires_session attribute.
    /// </summary>
    public TerraformExpression RequiresSession => this["requires_session"];

}
