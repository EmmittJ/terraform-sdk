using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for advanced_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for azure_function_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    public required TerraformProperty<string> FunctionId
    {
        set => SetProperty("function_id", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformProperty<double>? MaxEventsPerBatch
    {
        set => SetProperty("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformProperty<double>? PreferredBatchSizeInKilobytes
    {
        set => SetProperty("preferred_batch_size_in_kilobytes", value);
    }

}

/// <summary>
/// Block type for dead_letter_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentity
    {
        set => SetProperty("user_assigned_identity", value);
    }

}

/// <summary>
/// Block type for delivery_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentity
    {
        set => SetProperty("user_assigned_identity", value);
    }

}

/// <summary>
/// Block type for delivery_property in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock : TerraformBlock
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformProperty<string> HeaderName
    {
        set => SetProperty("header_name", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformProperty<bool>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    public TerraformProperty<string>? SourceField
    {
        set => SetProperty("source_field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    public required TerraformProperty<double> EventTimeToLive
    {
        set => SetProperty("event_time_to_live", value);
    }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    public required TerraformProperty<double> MaxDeliveryAttempts
    {
        set => SetProperty("max_delivery_attempts", value);
    }

}

/// <summary>
/// Block type for storage_blob_dead_letter_destination in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    public required TerraformProperty<string> StorageBlobContainerName
    {
        set => SetProperty("storage_blob_container_name", value);
    }

}

/// <summary>
/// Block type for storage_queue_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? QueueMessageTimeToLiveInSeconds
    {
        set => SetProperty("queue_message_time_to_live_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformProperty<string> QueueName
    {
        set => SetProperty("queue_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        set => SetProperty("storage_account_id", value);
    }

}

/// <summary>
/// Block type for subject_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformProperty<bool>? CaseSensitive
    {
        set => SetProperty("case_sensitive", value);
    }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectBeginsWith
    {
        set => SetProperty("subject_begins_with", value);
    }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectEndsWith
    {
        set => SetProperty("subject_ends_with", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for webhook_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryAppIdOrUri
    {
        set => SetProperty("active_directory_app_id_or_uri", value);
    }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryTenantId
    {
        set => SetProperty("active_directory_tenant_id", value);
    }

    /// <summary>
    /// The base_url attribute.
    /// </summary>
    public TerraformProperty<string>? BaseUrl
    {
        set => SetProperty("base_url", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformProperty<double>? MaxEventsPerBatch
    {
        set => SetProperty("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformProperty<double>? PreferredBatchSizeInKilobytes
    {
        set => SetProperty("preferred_batch_size_in_kilobytes", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Manages a azurerm_eventgrid_system_topic_event_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridSystemTopicEventSubscription : TerraformResource
{
    public AzurermEventgridSystemTopicEventSubscription(string name) : base("azurerm_eventgrid_system_topic_event_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("advanced_filtering_on_arrays_enabled");
        SetOutput("event_delivery_schema");
        SetOutput("eventhub_endpoint_id");
        SetOutput("expiration_time_utc");
        SetOutput("hybrid_connection_endpoint_id");
        SetOutput("id");
        SetOutput("included_event_types");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("service_bus_queue_endpoint_id");
        SetOutput("service_bus_topic_endpoint_id");
        SetOutput("system_topic");
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AdvancedFilteringOnArraysEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("advanced_filtering_on_arrays_enabled");
        set => SetProperty("advanced_filtering_on_arrays_enabled", value);
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    public TerraformProperty<string> EventDeliverySchema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_delivery_schema");
        set => SetProperty("event_delivery_schema", value);
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> EventhubEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_endpoint_id");
        set => SetProperty("eventhub_endpoint_id", value);
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    public TerraformProperty<string> ExpirationTimeUtc
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_time_utc");
        set => SetProperty("expiration_time_utc", value);
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> HybridConnectionEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hybrid_connection_endpoint_id");
        set => SetProperty("hybrid_connection_endpoint_id", value);
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
    /// The included_event_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> IncludedEventTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("included_event_types");
        set => SetProperty("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public List<TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> ServiceBusQueueEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_bus_queue_endpoint_id");
        set => SetProperty("service_bus_queue_endpoint_id", value);
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> ServiceBusTopicEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_bus_topic_endpoint_id");
        set => SetProperty("service_bus_topic_endpoint_id", value);
    }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemTopic is required")]
    public required TerraformProperty<string> SystemTopic
    {
        get => GetRequiredOutput<TerraformProperty<string>>("system_topic");
        set => SetProperty("system_topic", value);
    }

    /// <summary>
    /// Block for advanced_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock>? AdvancedFilter
    {
        set => SetProperty("advanced_filter", value);
    }

    /// <summary>
    /// Block for azure_function_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock>? AzureFunctionEndpoint
    {
        set => SetProperty("azure_function_endpoint", value);
    }

    /// <summary>
    /// Block for dead_letter_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock>? DeadLetterIdentity
    {
        set => SetProperty("dead_letter_identity", value);
    }

    /// <summary>
    /// Block for delivery_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock>? DeliveryIdentity
    {
        set => SetProperty("delivery_identity", value);
    }

    /// <summary>
    /// Block for delivery_property.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock>? DeliveryProperty
    {
        set => SetProperty("delivery_property", value);
    }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock>? RetryPolicy
    {
        set => SetProperty("retry_policy", value);
    }

    /// <summary>
    /// Block for storage_blob_dead_letter_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock>? StorageBlobDeadLetterDestination
    {
        set => SetProperty("storage_blob_dead_letter_destination", value);
    }

    /// <summary>
    /// Block for storage_queue_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock>? StorageQueueEndpoint
    {
        set => SetProperty("storage_queue_endpoint", value);
    }

    /// <summary>
    /// Block for subject_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock>? SubjectFilter
    {
        set => SetProperty("subject_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for webhook_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    public List<AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock>? WebhookEndpoint
    {
        set => SetProperty("webhook_endpoint", value);
    }

}
