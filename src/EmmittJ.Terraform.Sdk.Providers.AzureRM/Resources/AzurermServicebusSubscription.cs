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
    public TerraformProperty<string>? AutoDeleteOnIdle
    {
        get => GetProperty<TerraformProperty<string>>("auto_delete_on_idle");
        set => this.WithProperty("auto_delete_on_idle", value);
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BatchedOperationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("batched_operations_enabled");
        set => this.WithProperty("batched_operations_enabled", value);
    }

    /// <summary>
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientScopedSubscriptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_scoped_subscription_enabled");
        set => this.WithProperty("client_scoped_subscription_enabled", value);
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public TerraformProperty<bool>? DeadLetteringOnFilterEvaluationError
    {
        get => GetProperty<TerraformProperty<bool>>("dead_lettering_on_filter_evaluation_error");
        set => this.WithProperty("dead_lettering_on_filter_evaluation_error", value);
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public TerraformProperty<bool>? DeadLetteringOnMessageExpiration
    {
        get => GetProperty<TerraformProperty<bool>>("dead_lettering_on_message_expiration");
        set => this.WithProperty("dead_lettering_on_message_expiration", value);
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultMessageTtl
    {
        get => GetProperty<TerraformProperty<string>>("default_message_ttl");
        set => this.WithProperty("default_message_ttl", value);
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public TerraformProperty<string>? ForwardDeadLetteredMessagesTo
    {
        get => GetProperty<TerraformProperty<string>>("forward_dead_lettered_messages_to");
        set => this.WithProperty("forward_dead_lettered_messages_to", value);
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public TerraformProperty<string>? ForwardTo
    {
        get => GetProperty<TerraformProperty<string>>("forward_to");
        set => this.WithProperty("forward_to", value);
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
    /// The lock_duration attribute.
    /// </summary>
    public TerraformProperty<string>? LockDuration
    {
        get => GetProperty<TerraformProperty<string>>("lock_duration");
        set => this.WithProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliveryCount
    {
        get => GetProperty<TerraformProperty<double>>("max_delivery_count");
        set => this.WithProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    public TerraformProperty<bool>? RequiresSession
    {
        get => GetProperty<TerraformProperty<bool>>("requires_session");
        set => this.WithProperty("requires_session", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public TerraformProperty<string>? TopicId
    {
        get => GetProperty<TerraformProperty<string>>("topic_id");
        set => this.WithProperty("topic_id", value);
    }

}
