using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_servicebus_subscription resource.
/// </summary>
public class AzurermServicebusSubscription : TerraformResource
{
    public AzurermServicebusSubscription(string name) : base("azurerm_servicebus_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutoDeleteOnIdle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_delete_on_idle");
        set => this.WithProperty("auto_delete_on_idle", value);
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BatchedOperationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("batched_operations_enabled");
        set => this.WithProperty("batched_operations_enabled", value);
    }

    /// <summary>
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ClientScopedSubscriptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_scoped_subscription_enabled");
        set => this.WithProperty("client_scoped_subscription_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeadLetteringOnFilterEvaluationError
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dead_lettering_on_filter_evaluation_error");
        set => this.WithProperty("dead_lettering_on_filter_evaluation_error", value);
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeadLetteringOnMessageExpiration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dead_lettering_on_message_expiration");
        set => this.WithProperty("dead_lettering_on_message_expiration", value);
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultMessageTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_message_ttl");
        set => this.WithProperty("default_message_ttl", value);
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ForwardDeadLetteredMessagesTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_dead_lettered_messages_to");
        set => this.WithProperty("forward_dead_lettered_messages_to", value);
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ForwardTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_to");
        set => this.WithProperty("forward_to", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LockDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_duration");
        set => this.WithProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxDeliveryCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_delivery_count");
        set => this.WithProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequiresSession
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_session");
        set => this.WithProperty("requires_session", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_id");
        set => this.WithProperty("topic_id", value);
    }

}
