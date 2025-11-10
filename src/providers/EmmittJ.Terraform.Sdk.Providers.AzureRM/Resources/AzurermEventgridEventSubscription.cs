using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for advanced_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAdvancedFilterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for azure_function_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    public required TerraformProperty<string> FunctionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_id");
        set => WithProperty("function_id", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformProperty<double>? MaxEventsPerBatch
    {
        get => GetProperty<TerraformProperty<double>>("max_events_per_batch");
        set => WithProperty("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformProperty<double>? PreferredBatchSizeInKilobytes
    {
        get => GetProperty<TerraformProperty<double>>("preferred_batch_size_in_kilobytes");
        set => WithProperty("preferred_batch_size_in_kilobytes", value);
    }

}

/// <summary>
/// Block type for dead_letter_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeadLetterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentity
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity");
        set => WithProperty("user_assigned_identity", value);
    }

}

/// <summary>
/// Block type for delivery_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeliveryIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentity
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity");
        set => WithProperty("user_assigned_identity", value);
    }

}

/// <summary>
/// Block type for delivery_property in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionDeliveryPropertyBlock : TerraformBlock
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformProperty<string> HeaderName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("header_name");
        set => WithProperty("header_name", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformProperty<bool>? Secret
    {
        get => GetProperty<TerraformProperty<bool>>("secret");
        set => WithProperty("secret", value);
    }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    public TerraformProperty<string>? SourceField
    {
        get => GetProperty<TerraformProperty<string>>("source_field");
        set => WithProperty("source_field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    public required TerraformProperty<double> EventTimeToLive
    {
        get => GetRequiredProperty<TerraformProperty<double>>("event_time_to_live");
        set => WithProperty("event_time_to_live", value);
    }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    public required TerraformProperty<double> MaxDeliveryAttempts
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_delivery_attempts");
        set => WithProperty("max_delivery_attempts", value);
    }

}

/// <summary>
/// Block type for storage_blob_dead_letter_destination in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    public required TerraformProperty<string> StorageBlobContainerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_blob_container_name");
        set => WithProperty("storage_blob_container_name", value);
    }

}

/// <summary>
/// Block type for storage_queue_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionStorageQueueEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? QueueMessageTimeToLiveInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("queue_message_time_to_live_in_seconds");
        set => WithProperty("queue_message_time_to_live_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformProperty<string> QueueName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("queue_name");
        set => WithProperty("queue_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => WithProperty("storage_account_id", value);
    }

}

/// <summary>
/// Block type for subject_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionSubjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformProperty<bool>? CaseSensitive
    {
        get => GetProperty<TerraformProperty<bool>>("case_sensitive");
        set => WithProperty("case_sensitive", value);
    }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectBeginsWith
    {
        get => GetProperty<TerraformProperty<string>>("subject_begins_with");
        set => WithProperty("subject_begins_with", value);
    }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectEndsWith
    {
        get => GetProperty<TerraformProperty<string>>("subject_ends_with");
        set => WithProperty("subject_ends_with", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridEventSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for webhook_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridEventSubscriptionWebhookEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryAppIdOrUri
    {
        get => GetProperty<TerraformProperty<string>>("active_directory_app_id_or_uri");
        set => WithProperty("active_directory_app_id_or_uri", value);
    }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryTenantId
    {
        get => GetProperty<TerraformProperty<string>>("active_directory_tenant_id");
        set => WithProperty("active_directory_tenant_id", value);
    }

    /// <summary>
    /// The base_url attribute.
    /// </summary>
    public TerraformProperty<string>? BaseUrl
    {
        get => GetProperty<TerraformProperty<string>>("base_url");
        set => WithProperty("base_url", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformProperty<double>? MaxEventsPerBatch
    {
        get => GetProperty<TerraformProperty<double>>("max_events_per_batch");
        set => WithProperty("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformProperty<double>? PreferredBatchSizeInKilobytes
    {
        get => GetProperty<TerraformProperty<double>>("preferred_batch_size_in_kilobytes");
        set => WithProperty("preferred_batch_size_in_kilobytes", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Manages a azurerm_eventgrid_event_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridEventSubscription : TerraformResource
{
    public AzurermEventgridEventSubscription(string name) : base("azurerm_eventgrid_event_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AdvancedFilteringOnArraysEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("advanced_filtering_on_arrays_enabled");
        set => this.WithProperty("advanced_filtering_on_arrays_enabled", value);
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    public TerraformProperty<string>? EventDeliverySchema
    {
        get => GetProperty<TerraformProperty<string>>("event_delivery_schema");
        set => this.WithProperty("event_delivery_schema", value);
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_endpoint_id");
        set => this.WithProperty("eventhub_endpoint_id", value);
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationTimeUtc
    {
        get => GetProperty<TerraformProperty<string>>("expiration_time_utc");
        set => this.WithProperty("expiration_time_utc", value);
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? HybridConnectionEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("hybrid_connection_endpoint_id");
        set => this.WithProperty("hybrid_connection_endpoint_id", value);
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
    /// The included_event_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedEventTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("included_event_types");
        set => this.WithProperty("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Labels
    {
        get => GetProperty<List<TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceBusQueueEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("service_bus_queue_endpoint_id");
        set => this.WithProperty("service_bus_queue_endpoint_id", value);
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceBusTopicEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("service_bus_topic_endpoint_id");
        set => this.WithProperty("service_bus_topic_endpoint_id", value);
    }

    /// <summary>
    /// Block for advanced_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionAdvancedFilterBlock>? AdvancedFilter
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionAdvancedFilterBlock>>("advanced_filter");
        set => this.WithProperty("advanced_filter", value);
    }

    /// <summary>
    /// Block for azure_function_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock>? AzureFunctionEndpoint
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionAzureFunctionEndpointBlock>>("azure_function_endpoint");
        set => this.WithProperty("azure_function_endpoint", value);
    }

    /// <summary>
    /// Block for dead_letter_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionDeadLetterIdentityBlock>? DeadLetterIdentity
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionDeadLetterIdentityBlock>>("dead_letter_identity");
        set => this.WithProperty("dead_letter_identity", value);
    }

    /// <summary>
    /// Block for delivery_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionDeliveryIdentityBlock>? DeliveryIdentity
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionDeliveryIdentityBlock>>("delivery_identity");
        set => this.WithProperty("delivery_identity", value);
    }

    /// <summary>
    /// Block for delivery_property.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermEventgridEventSubscriptionDeliveryPropertyBlock>? DeliveryProperty
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionDeliveryPropertyBlock>>("delivery_property");
        set => this.WithProperty("delivery_property", value);
    }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionRetryPolicyBlock>? RetryPolicy
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionRetryPolicyBlock>>("retry_policy");
        set => this.WithProperty("retry_policy", value);
    }

    /// <summary>
    /// Block for storage_blob_dead_letter_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock>? StorageBlobDeadLetterDestination
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionStorageBlobDeadLetterDestinationBlock>>("storage_blob_dead_letter_destination");
        set => this.WithProperty("storage_blob_dead_letter_destination", value);
    }

    /// <summary>
    /// Block for storage_queue_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionStorageQueueEndpointBlock>? StorageQueueEndpoint
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionStorageQueueEndpointBlock>>("storage_queue_endpoint");
        set => this.WithProperty("storage_queue_endpoint", value);
    }

    /// <summary>
    /// Block for subject_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionSubjectFilterBlock>? SubjectFilter
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionSubjectFilterBlock>>("subject_filter");
        set => this.WithProperty("subject_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventgridEventSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermEventgridEventSubscriptionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for webhook_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    public List<AzurermEventgridEventSubscriptionWebhookEndpointBlock>? WebhookEndpoint
    {
        get => GetProperty<List<AzurermEventgridEventSubscriptionWebhookEndpointBlock>>("webhook_endpoint");
        set => this.WithProperty("webhook_endpoint", value);
    }

}
