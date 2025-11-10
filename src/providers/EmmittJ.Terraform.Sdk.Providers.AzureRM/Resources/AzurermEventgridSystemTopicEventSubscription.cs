using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for advanced_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for azure_function_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    [TerraformPropertyName("function_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionId { get; set; }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformPropertyName("max_events_per_batch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxEventsPerBatch { get; set; }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_batch_size_in_kilobytes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PreferredBatchSizeInKilobytes { get; set; }

}

/// <summary>
/// Block type for dead_letter_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAssignedIdentity { get; set; }

}

/// <summary>
/// Block type for delivery_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAssignedIdentity { get; set; }

}

/// <summary>
/// Block type for delivery_property in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock : ITerraformBlock
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    [TerraformPropertyName("header_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HeaderName { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Secret { get; set; }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    [TerraformPropertyName("source_field")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceField { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    [TerraformPropertyName("event_time_to_live")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> EventTimeToLive { get; set; }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    [TerraformPropertyName("max_delivery_attempts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxDeliveryAttempts { get; set; }

}

/// <summary>
/// Block type for storage_blob_dead_letter_destination in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock : ITerraformBlock
{
    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    [TerraformPropertyName("storage_blob_container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageBlobContainerName { get; set; }

}

/// <summary>
/// Block type for storage_queue_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("queue_message_time_to_live_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    [TerraformPropertyName("queue_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueueName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

}

/// <summary>
/// Block type for subject_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    [TerraformPropertyName("case_sensitive")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CaseSensitive { get; set; }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    [TerraformPropertyName("subject_begins_with")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubjectBeginsWith { get; set; }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    [TerraformPropertyName("subject_ends_with")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubjectEndsWith { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock : ITerraformBlock
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
/// Block type for webhook_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_app_id_or_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActiveDirectoryTenantId { get; set; }

    /// <summary>
    /// The base_url attribute.
    /// </summary>
    [TerraformPropertyName("base_url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BaseUrl => new TerraformReferenceProperty<TerraformProperty<string>>("", "base_url");

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformPropertyName("max_events_per_batch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxEventsPerBatch { get; set; }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_batch_size_in_kilobytes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Manages a azurerm_eventgrid_system_topic_event_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridSystemTopicEventSubscription : TerraformResource
{
    public AzurermEventgridSystemTopicEventSubscription(string name) : base("azurerm_eventgrid_system_topic_event_subscription", name)
    {
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    [TerraformPropertyName("advanced_filtering_on_arrays_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    [TerraformPropertyName("event_delivery_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventDeliverySchema { get; set; }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_endpoint_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EventhubEndpointId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eventhub_endpoint_id");

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    [TerraformPropertyName("expiration_time_utc")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("hybrid_connection_endpoint_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HybridConnectionEndpointId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hybrid_connection_endpoint_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    [TerraformPropertyName("included_event_types")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> IncludedEventTypes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "included_event_types");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("service_bus_queue_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceBusQueueEndpointId { get; set; }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("service_bus_topic_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceBusTopicEndpointId { get; set; }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemTopic is required")]
    [TerraformPropertyName("system_topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SystemTopic { get; set; }

    /// <summary>
    /// Block for advanced_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    [TerraformPropertyName("advanced_filter")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock>>? AdvancedFilter { get; set; } = new();

    /// <summary>
    /// Block for azure_function_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    [TerraformPropertyName("azure_function_endpoint")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock>>? AzureFunctionEndpoint { get; set; } = new();

    /// <summary>
    /// Block for dead_letter_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    [TerraformPropertyName("dead_letter_identity")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock>>? DeadLetterIdentity { get; set; } = new();

    /// <summary>
    /// Block for delivery_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    [TerraformPropertyName("delivery_identity")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock>>? DeliveryIdentity { get; set; } = new();

    /// <summary>
    /// Block for delivery_property.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delivery_property")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock>>? DeliveryProperty { get; set; } = new();

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformPropertyName("retry_policy")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock>>? RetryPolicy { get; set; } = new();

    /// <summary>
    /// Block for storage_blob_dead_letter_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    [TerraformPropertyName("storage_blob_dead_letter_destination")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock>>? StorageBlobDeadLetterDestination { get; set; } = new();

    /// <summary>
    /// Block for storage_queue_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    [TerraformPropertyName("storage_queue_endpoint")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock>>? StorageQueueEndpoint { get; set; } = new();

    /// <summary>
    /// Block for subject_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    [TerraformPropertyName("subject_filter")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock>>? SubjectFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for webhook_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    [TerraformPropertyName("webhook_endpoint")]
    public TerraformList<TerraformBlock<AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock>>? WebhookEndpoint { get; set; } = new();

}
