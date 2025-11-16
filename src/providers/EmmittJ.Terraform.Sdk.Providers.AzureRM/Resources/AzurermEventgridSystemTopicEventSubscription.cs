using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for advanced_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_filter";

}

/// <summary>
/// Block type for azure_function_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_function_endpoint";

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionId is required")]
    public required TerraformValue<string> FunctionId
    {
        get => new TerraformReference<string>(this, "function_id");
        set => SetArgument("function_id", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformValue<double>? MaxEventsPerBatch
    {
        get => new TerraformReference<double>(this, "max_events_per_batch");
        set => SetArgument("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformValue<double>? PreferredBatchSizeInKilobytes
    {
        get => new TerraformReference<double>(this, "preferred_batch_size_in_kilobytes");
        set => SetArgument("preferred_batch_size_in_kilobytes", value);
    }

}

/// <summary>
/// Block type for dead_letter_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_identity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentity
    {
        get => new TerraformReference<string>(this, "user_assigned_identity");
        set => SetArgument("user_assigned_identity", value);
    }

}

/// <summary>
/// Block type for delivery_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_identity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentity
    {
        get => new TerraformReference<string>(this, "user_assigned_identity");
        set => SetArgument("user_assigned_identity", value);
    }

}

/// <summary>
/// Block type for delivery_property in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_property";

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => new TerraformReference<string>(this, "header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformValue<bool>? Secret
    {
        get => new TerraformReference<bool>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    public TerraformValue<string>? SourceField
    {
        get => new TerraformReference<string>(this, "source_field");
        set => SetArgument("source_field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The event_time_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeToLive is required")]
    public required TerraformValue<double> EventTimeToLive
    {
        get => new TerraformReference<double>(this, "event_time_to_live");
        set => SetArgument("event_time_to_live", value);
    }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    public required TerraformValue<double> MaxDeliveryAttempts
    {
        get => new TerraformReference<double>(this, "max_delivery_attempts");
        set => SetArgument("max_delivery_attempts", value);
    }

}

/// <summary>
/// Block type for storage_blob_dead_letter_destination in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_blob_dead_letter_destination";

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    public required TerraformValue<string> StorageBlobContainerName
    {
        get => new TerraformReference<string>(this, "storage_blob_container_name");
        set => SetArgument("storage_blob_container_name", value);
    }

}

/// <summary>
/// Block type for storage_queue_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_queue_endpoint";

    /// <summary>
    /// The queue_message_time_to_live_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? QueueMessageTimeToLiveInSeconds
    {
        get => new TerraformReference<double>(this, "queue_message_time_to_live_in_seconds");
        set => SetArgument("queue_message_time_to_live_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformValue<string> QueueName
    {
        get => new TerraformReference<string>(this, "queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}

/// <summary>
/// Block type for subject_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_filter";

    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformValue<bool>? CaseSensitive
    {
        get => new TerraformReference<bool>(this, "case_sensitive");
        set => SetArgument("case_sensitive", value);
    }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    public TerraformValue<string>? SubjectBeginsWith
    {
        get => new TerraformReference<string>(this, "subject_begins_with");
        set => SetArgument("subject_begins_with", value);
    }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    public TerraformValue<string>? SubjectEndsWith
    {
        get => new TerraformReference<string>(this, "subject_ends_with");
        set => SetArgument("subject_ends_with", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for webhook_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "webhook_endpoint";

    /// <summary>
    /// The active_directory_app_id_or_uri attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryAppIdOrUri
    {
        get => new TerraformReference<string>(this, "active_directory_app_id_or_uri");
        set => SetArgument("active_directory_app_id_or_uri", value);
    }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryTenantId
    {
        get => new TerraformReference<string>(this, "active_directory_tenant_id");
        set => SetArgument("active_directory_tenant_id", value);
    }

    /// <summary>
    /// The base_url attribute.
    /// </summary>
    public TerraformValue<string> BaseUrl
    {
        get => new TerraformReference<string>(this, "base_url");
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    public TerraformValue<double>? MaxEventsPerBatch
    {
        get => new TerraformReference<double>(this, "max_events_per_batch");
        set => SetArgument("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    public TerraformValue<double>? PreferredBatchSizeInKilobytes
    {
        get => new TerraformReference<double>(this, "preferred_batch_size_in_kilobytes");
        set => SetArgument("preferred_batch_size_in_kilobytes", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Represents a azurerm_eventgrid_system_topic_event_subscription Terraform resource.
/// Manages a azurerm_eventgrid_system_topic_event_subscription resource.
/// </summary>
public partial class AzurermEventgridSystemTopicEventSubscription(string name) : TerraformResource("azurerm_eventgrid_system_topic_event_subscription", name)
{
    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AdvancedFilteringOnArraysEnabled
    {
        get => new TerraformReference<bool>(this, "advanced_filtering_on_arrays_enabled");
        set => SetArgument("advanced_filtering_on_arrays_enabled", value);
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    public TerraformValue<string>? EventDeliverySchema
    {
        get => new TerraformReference<string>(this, "event_delivery_schema");
        set => SetArgument("event_delivery_schema", value);
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> EventhubEndpointId
    {
        get => new TerraformReference<string>(this, "eventhub_endpoint_id");
        set => SetArgument("eventhub_endpoint_id", value);
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationTimeUtc
    {
        get => new TerraformReference<string>(this, "expiration_time_utc");
        set => SetArgument("expiration_time_utc", value);
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> HybridConnectionEndpointId
    {
        get => new TerraformReference<string>(this, "hybrid_connection_endpoint_id");
        set => SetArgument("hybrid_connection_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    public TerraformList<string> IncludedEventTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_event_types").ResolveNodes(ctx));
        set => SetArgument("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformList<string>? Labels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? ServiceBusQueueEndpointId
    {
        get => new TerraformReference<string>(this, "service_bus_queue_endpoint_id");
        set => SetArgument("service_bus_queue_endpoint_id", value);
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? ServiceBusTopicEndpointId
    {
        get => new TerraformReference<string>(this, "service_bus_topic_endpoint_id");
        set => SetArgument("service_bus_topic_endpoint_id", value);
    }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemTopic is required")]
    public required TerraformValue<string> SystemTopic
    {
        get => new TerraformReference<string>(this, "system_topic");
        set => SetArgument("system_topic", value);
    }

    /// <summary>
    /// AdvancedFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock? AdvancedFilter
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock>("advanced_filter");
        set => SetArgument("advanced_filter", value);
    }

    /// <summary>
    /// AzureFunctionEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock? AzureFunctionEndpoint
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock>("azure_function_endpoint");
        set => SetArgument("azure_function_endpoint", value);
    }

    /// <summary>
    /// DeadLetterIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock? DeadLetterIdentity
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock>("dead_letter_identity");
        set => SetArgument("dead_letter_identity", value);
    }

    /// <summary>
    /// DeliveryIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock? DeliveryIdentity
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock>("delivery_identity");
        set => SetArgument("delivery_identity", value);
    }

    /// <summary>
    /// DeliveryProperty block (nesting mode: list).
    /// </summary>
    public AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock? DeliveryProperty
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock>("delivery_property");
        set => SetArgument("delivery_property", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock? RetryPolicy
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// StorageBlobDeadLetterDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock? StorageBlobDeadLetterDestination
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock>("storage_blob_dead_letter_destination");
        set => SetArgument("storage_blob_dead_letter_destination", value);
    }

    /// <summary>
    /// StorageQueueEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock? StorageQueueEndpoint
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock>("storage_queue_endpoint");
        set => SetArgument("storage_queue_endpoint", value);
    }

    /// <summary>
    /// SubjectFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock? SubjectFilter
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock>("subject_filter");
        set => SetArgument("subject_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WebhookEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    public AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock? WebhookEndpoint
    {
        get => GetArgument<AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock>("webhook_endpoint");
        set => SetArgument("webhook_endpoint", value);
    }

}
