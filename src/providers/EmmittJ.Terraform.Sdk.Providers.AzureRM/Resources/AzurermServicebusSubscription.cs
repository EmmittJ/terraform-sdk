using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for client_scoped_subscription in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServicebusSubscriptionClientScopedSubscriptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }


    /// <summary>
    /// The is_client_scoped_subscription_shareable attribute.
    /// </summary>
    [TerraformProperty("is_client_scoped_subscription_shareable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsClientScopedSubscriptionShareable { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusSubscriptionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermServicebusSubscription : TerraformResource
{
    public AzurermServicebusSubscription(string name) : base("azurerm_servicebus_subscription", name)
    {
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    [TerraformProperty("auto_delete_on_idle")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoDeleteOnIdle { get; set; }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    [TerraformProperty("batched_operations_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchedOperationsEnabled { get; set; }

    /// <summary>
    /// The client_scoped_subscription_enabled attribute.
    /// </summary>
    [TerraformProperty("client_scoped_subscription_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ClientScopedSubscriptionEnabled { get; set; }

    /// <summary>
    /// The dead_lettering_on_filter_evaluation_error attribute.
    /// </summary>
    [TerraformProperty("dead_lettering_on_filter_evaluation_error")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeadLetteringOnFilterEvaluationError { get; set; }

    /// <summary>
    /// The dead_lettering_on_message_expiration attribute.
    /// </summary>
    [TerraformProperty("dead_lettering_on_message_expiration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    [TerraformProperty("default_message_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultMessageTtl { get; set; }

    /// <summary>
    /// The forward_dead_lettered_messages_to attribute.
    /// </summary>
    [TerraformProperty("forward_dead_lettered_messages_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>
    /// The forward_to attribute.
    /// </summary>
    [TerraformProperty("forward_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardTo { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformProperty("lock_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryCount is required")]
    [TerraformProperty("max_delivery_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxDeliveryCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The requires_session attribute.
    /// </summary>
    [TerraformProperty("requires_session")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequiresSession { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    [TerraformProperty("topic_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicId { get; set; }

    /// <summary>
    /// Block for client_scoped_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientScopedSubscription block(s) allowed")]
    [TerraformProperty("client_scoped_subscription")]
    public partial TerraformList<TerraformBlock<AzurermServicebusSubscriptionClientScopedSubscriptionBlock>>? ClientScopedSubscription { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermServicebusSubscriptionTimeoutsBlock>? Timeouts { get; set; }

}
