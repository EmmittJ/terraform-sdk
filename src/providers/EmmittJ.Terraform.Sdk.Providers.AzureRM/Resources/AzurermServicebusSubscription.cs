using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for client_scoped_subscription in .
/// Nesting mode: list
/// </summary>
public class AzurermServicebusSubscriptionClientScopedSubscriptionBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientId { get; set; }

    /// <summary>
    /// The is_client_scoped_subscription_durable attribute.
    /// </summary>
    [TerraformPropertyName("is_client_scoped_subscription_durable")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsClientScopedSubscriptionDurable => new TerraformReferenceProperty<TerraformProperty<bool>>("", "is_client_scoped_subscription_durable");

    /// <summary>
    /// The is_client_scoped_subscription_shareable attribute.
    /// </summary>
    [TerraformPropertyName("is_client_scoped_subscription_shareable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsClientScopedSubscriptionShareable { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("auto_delete_on_idle")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoDeleteOnIdle { get; set; }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("batched_operations_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BatchedOperationsEnabled { get; set; }

    /// <summary>
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_scoped_subscription_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ClientScopedSubscriptionEnabled { get; set; }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    [TerraformPropertyName("dead_lettering_on_filter_evaluation_error")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeadLetteringOnFilterEvaluationError { get; set; }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformPropertyName("dead_lettering_on_message_expiration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_message_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultMessageTtl { get; set; }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_dead_lettered_messages_to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformPropertyName("forward_to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardTo { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformPropertyName("lock_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryCount is required")]
    [TerraformPropertyName("max_delivery_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxDeliveryCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformPropertyName("requires_session")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequiresSession { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    [TerraformPropertyName("topic_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TopicId { get; set; }

    /// <summary>
    /// Block for client_scoped_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientScopedSubscription block(s) allowed")]
    [TerraformPropertyName("client_scoped_subscription")]
    public TerraformList<TerraformBlock<AzurermServicebusSubscriptionClientScopedSubscriptionBlock>>? ClientScopedSubscription { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusSubscriptionTimeoutsBlock>? Timeouts { get; set; } = new();

}
