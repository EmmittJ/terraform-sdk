using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("auto_delete_on_idle");
        this.DeclareOutput("batched_operations_enabled");
        this.DeclareOutput("dead_lettering_on_filter_evaluation_error");
        this.DeclareOutput("dead_lettering_on_message_expiration");
        this.DeclareOutput("default_message_ttl");
        this.DeclareOutput("enable_batched_operations");
        this.DeclareOutput("forward_dead_lettered_messages_to");
        this.DeclareOutput("forward_to");
        this.DeclareOutput("lock_duration");
        this.DeclareOutput("max_delivery_count");
        this.DeclareOutput("requires_session");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public string? TopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_id")?.Value;
        set => this.WithProperty("topic_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? TopicName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_name")?.Value;
        set => this.WithProperty("topic_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
