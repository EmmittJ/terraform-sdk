using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for advanced_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock() : TerraformBlock("advanced_filter")
{
}

/// <summary>
/// Block type for azure_function_endpoint in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock() : TerraformBlock("azure_function_endpoint")
{
    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    [TerraformProperty("function_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionId { get; set; }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformProperty("max_events_per_batch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxEventsPerBatch { get; set; }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformProperty("preferred_batch_size_in_kilobytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PreferredBatchSizeInKilobytes { get; set; }

}

/// <summary>
/// Block type for dead_letter_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock() : TerraformBlock("dead_letter_identity")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentity { get; set; }

}

/// <summary>
/// Block type for delivery_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock() : TerraformBlock("delivery_identity")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentity { get; set; }

}

/// <summary>
/// Block type for delivery_property in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock() : TerraformBlock("delivery_property")
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    [TerraformProperty("header_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HeaderName { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformProperty("secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Secret { get; set; }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    [TerraformProperty("source_field")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceField { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock() : TerraformBlock("retry_policy")
{
    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    [TerraformProperty("event_time_to_live")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> EventTimeToLive { get; set; }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    [TerraformProperty("max_delivery_attempts")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxDeliveryAttempts { get; set; }

}

/// <summary>
/// Block type for storage_blob_dead_letter_destination in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock() : TerraformBlock("storage_blob_dead_letter_destination")
{
    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    [TerraformProperty("storage_blob_container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageBlobContainerName { get; set; }

}

/// <summary>
/// Block type for storage_queue_endpoint in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock() : TerraformBlock("storage_queue_endpoint")
{
    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    [TerraformProperty("queue_message_time_to_live_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    [TerraformProperty("queue_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueueName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

}

/// <summary>
/// Block type for subject_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock() : TerraformBlock("subject_filter")
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    [TerraformProperty("case_sensitive")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CaseSensitive { get; set; }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    [TerraformProperty("subject_begins_with")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubjectBeginsWith { get; set; }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    [TerraformProperty("subject_ends_with")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubjectEndsWith { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for webhook_endpoint in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock() : TerraformBlock("webhook_endpoint")
{
    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    [TerraformProperty("active_directory_app_id_or_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    [TerraformProperty("active_directory_tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ActiveDirectoryTenantId { get; set; }


    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformProperty("max_events_per_batch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxEventsPerBatch { get; set; }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformProperty("preferred_batch_size_in_kilobytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Manages a azurerm_eventgrid_system_topic_event_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermEventgridSystemTopicEventSubscription : TerraformResource
{
    public AzurermEventgridSystemTopicEventSubscription(string name) : base("azurerm_eventgrid_system_topic_event_subscription", name)
    {
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    [TerraformProperty("advanced_filtering_on_arrays_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    [TerraformProperty("event_delivery_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventDeliverySchema { get; set; }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("eventhub_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EventhubEndpointId { get; set; }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    [TerraformProperty("expiration_time_utc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("hybrid_connection_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HybridConnectionEndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    [TerraformProperty("included_event_types")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> IncludedEventTypes { get; set; }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Labels { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("service_bus_queue_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceBusQueueEndpointId { get; set; }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("service_bus_topic_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceBusTopicEndpointId { get; set; }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemTopic is required")]
    [TerraformProperty("system_topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SystemTopic { get; set; }

    /// <summary>
    /// Block for advanced_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    [TerraformProperty("advanced_filter")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock> AdvancedFilter { get; set; } = new();

    /// <summary>
    /// Block for azure_function_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    [TerraformProperty("azure_function_endpoint")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock> AzureFunctionEndpoint { get; set; } = new();

    /// <summary>
    /// Block for dead_letter_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    [TerraformProperty("dead_letter_identity")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock> DeadLetterIdentity { get; set; } = new();

    /// <summary>
    /// Block for delivery_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    [TerraformProperty("delivery_identity")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock> DeliveryIdentity { get; set; } = new();

    /// <summary>
    /// Block for delivery_property.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("delivery_property")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock> DeliveryProperty { get; set; } = new();

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformProperty("retry_policy")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock> RetryPolicy { get; set; } = new();

    /// <summary>
    /// Block for storage_blob_dead_letter_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    [TerraformProperty("storage_blob_dead_letter_destination")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock> StorageBlobDeadLetterDestination { get; set; } = new();

    /// <summary>
    /// Block for storage_queue_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    [TerraformProperty("storage_queue_endpoint")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock> StorageQueueEndpoint { get; set; } = new();

    /// <summary>
    /// Block for subject_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    [TerraformProperty("subject_filter")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock> SubjectFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for webhook_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    [TerraformProperty("webhook_endpoint")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock> WebhookEndpoint { get; set; } = new();

}
