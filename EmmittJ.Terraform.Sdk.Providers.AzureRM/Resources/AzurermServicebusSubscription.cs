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
    public string? AutoDeleteOnIdle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_delete_on_idle")?.Value;
        set => this.WithProperty("auto_delete_on_idle", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public bool? BatchedOperationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("batched_operations_enabled")?.Value;
        set => this.WithProperty("batched_operations_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    public bool? ClientScopedSubscriptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_scoped_subscription_enabled")?.Value;
        set => this.WithProperty("client_scoped_subscription_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    public bool? DeadLetteringOnFilterEvaluationError
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dead_lettering_on_filter_evaluation_error")?.Value;
        set => this.WithProperty("dead_lettering_on_filter_evaluation_error", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    public bool? DeadLetteringOnMessageExpiration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dead_lettering_on_message_expiration")?.Value;
        set => this.WithProperty("dead_lettering_on_message_expiration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public string? DefaultMessageTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_message_ttl")?.Value;
        set => this.WithProperty("default_message_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    public string? ForwardDeadLetteredMessagesTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_dead_lettered_messages_to")?.Value;
        set => this.WithProperty("forward_dead_lettered_messages_to", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    public string? ForwardTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_to")?.Value;
        set => this.WithProperty("forward_to", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lock_duration attribute.
    /// </summary>
    public string? LockDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_duration")?.Value;
        set => this.WithProperty("lock_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public double? MaxDeliveryCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_delivery_count")?.Value;
        set => this.WithProperty("max_delivery_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The requires_session attribute.
    /// </summary>
    public bool? RequiresSession
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_session")?.Value;
        set => this.WithProperty("requires_session", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public string? TopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_id")?.Value;
        set => this.WithProperty("topic_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
