using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for advanced_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlock
{
}

/// <summary>
/// Block type for azure_function_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock
{
    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    [TerraformPropertyName("function_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionId { get; set; }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformPropertyName("max_events_per_batch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxEventsPerBatch { get; set; }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_batch_size_in_kilobytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PreferredBatchSizeInKilobytes { get; set; }

}

/// <summary>
/// Block type for dead_letter_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeadLetterIdentityBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserAssignedIdentity { get; set; }

}

/// <summary>
/// Block type for delivery_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeliveryIdentityBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserAssignedIdentity { get; set; }

}

/// <summary>
/// Block type for delivery_property in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeliveryPropertyBlock
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    [TerraformPropertyName("header_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HeaderName { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Secret { get; set; }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    [TerraformPropertyName("source_field")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceField { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionRetryPolicyBlock
{
    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    [TerraformPropertyName("event_time_to_live")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> EventTimeToLive { get; set; }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    [TerraformPropertyName("max_delivery_attempts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxDeliveryAttempts { get; set; }

}

/// <summary>
/// Block type for storage_blob_dead_letter_destination in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock
{
    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    [TerraformPropertyName("storage_blob_container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageBlobContainerName { get; set; }

}

/// <summary>
/// Block type for storage_queue_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionStorageQueueEndpointBlock
{
    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("queue_message_time_to_live_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    [TerraformPropertyName("queue_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueueName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountId { get; set; }

}

/// <summary>
/// Block type for subject_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionSubjectFilterBlock
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    [TerraformPropertyName("case_sensitive")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CaseSensitive { get; set; }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    [TerraformPropertyName("subject_begins_with")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubjectBeginsWith { get; set; }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    [TerraformPropertyName("subject_ends_with")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubjectEndsWith { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridEventSubscriptionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for webhook_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionWebhookEndpointBlock
{
    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_app_id_or_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ActiveDirectoryTenantId { get; set; }


    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformPropertyName("max_events_per_batch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxEventsPerBatch { get; set; }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_batch_size_in_kilobytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Manages a azurerm_eventgrid_event_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridEventSubscription : TerraformResource
{
    public AzurermEventgridEventSubscription(string name) : base("azurerm_eventgrid_event_subscription", name)
    {
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    [TerraformPropertyName("advanced_filtering_on_arrays_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    [TerraformPropertyName("event_delivery_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventDeliverySchema { get; set; }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_endpoint_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EventhubEndpointId { get; set; } = default!;

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    [TerraformPropertyName("expiration_time_utc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("hybrid_connection_endpoint_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HybridConnectionEndpointId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    [TerraformPropertyName("included_event_types")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> IncludedEventTypes { get; set; } = default!;

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Labels { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("service_bus_queue_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceBusQueueEndpointId { get; set; }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("service_bus_topic_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceBusTopicEndpointId { get; set; }

    /// <summary>
    /// Block for advanced_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    [TerraformPropertyName("advanced_filter")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionAdvancedFilterBlock>>? AdvancedFilter { get; set; }

    /// <summary>
    /// Block for azure_function_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    [TerraformPropertyName("azure_function_endpoint")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock>>? AzureFunctionEndpoint { get; set; }

    /// <summary>
    /// Block for dead_letter_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    [TerraformPropertyName("dead_letter_identity")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionDeadLetterIdentityBlock>>? DeadLetterIdentity { get; set; }

    /// <summary>
    /// Block for delivery_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    [TerraformPropertyName("delivery_identity")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionDeliveryIdentityBlock>>? DeliveryIdentity { get; set; }

    /// <summary>
    /// Block for delivery_property.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delivery_property")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionDeliveryPropertyBlock>>? DeliveryProperty { get; set; }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformPropertyName("retry_policy")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionRetryPolicyBlock>>? RetryPolicy { get; set; }

    /// <summary>
    /// Block for storage_blob_dead_letter_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    [TerraformPropertyName("storage_blob_dead_letter_destination")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock>>? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>
    /// Block for storage_queue_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    [TerraformPropertyName("storage_queue_endpoint")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionStorageQueueEndpointBlock>>? StorageQueueEndpoint { get; set; }

    /// <summary>
    /// Block for subject_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    [TerraformPropertyName("subject_filter")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionSubjectFilterBlock>>? SubjectFilter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermEventgridEventSubscriptionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for webhook_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    [TerraformPropertyName("webhook_endpoint")]
    public TerraformList<TerraformBlock<AzurermEventgridEventSubscriptionWebhookEndpointBlock>>? WebhookEndpoint { get; set; }

}
