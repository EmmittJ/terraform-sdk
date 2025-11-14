using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("function_id")]
    public required TerraformValue<string> FunctionId
    {
        get => new TerraformReference<string>(this, "function_id");
        set => SetArgument("function_id", value);
    }

    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformArgument("max_events_per_batch")]
    public TerraformValue<double>? MaxEventsPerBatch
    {
        get => new TerraformReference<double>(this, "max_events_per_batch");
        set => SetArgument("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformArgument("preferred_batch_size_in_kilobytes")]
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
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity")]
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
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assigned_identity attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity")]
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
    [TerraformArgument("header_name")]
    public required TerraformValue<string> HeaderName
    {
        get => new TerraformReference<string>(this, "header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformArgument("secret")]
    public TerraformValue<bool>? Secret
    {
        get => new TerraformReference<bool>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The source_field attribute.
    /// </summary>
    [TerraformArgument("source_field")]
    public TerraformValue<string>? SourceField
    {
        get => new TerraformReference<string>(this, "source_field");
        set => SetArgument("source_field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformArgument("value")]
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
    [TerraformArgument("event_time_to_live")]
    public required TerraformValue<double> EventTimeToLive
    {
        get => new TerraformReference<double>(this, "event_time_to_live");
        set => SetArgument("event_time_to_live", value);
    }

    /// <summary>
    /// The max_delivery_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxDeliveryAttempts is required")]
    [TerraformArgument("max_delivery_attempts")]
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
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageBlobContainerName is required")]
    [TerraformArgument("storage_blob_container_name")]
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
    [TerraformArgument("queue_message_time_to_live_in_seconds")]
    public TerraformValue<double>? QueueMessageTimeToLiveInSeconds
    {
        get => new TerraformReference<double>(this, "queue_message_time_to_live_in_seconds");
        set => SetArgument("queue_message_time_to_live_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    [TerraformArgument("queue_name")]
    public required TerraformValue<string> QueueName
    {
        get => new TerraformReference<string>(this, "queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
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
    [TerraformArgument("case_sensitive")]
    public TerraformValue<bool>? CaseSensitive
    {
        get => new TerraformReference<bool>(this, "case_sensitive");
        set => SetArgument("case_sensitive", value);
    }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    [TerraformArgument("subject_begins_with")]
    public TerraformValue<string>? SubjectBeginsWith
    {
        get => new TerraformReference<string>(this, "subject_begins_with");
        set => SetArgument("subject_begins_with", value);
    }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    [TerraformArgument("subject_ends_with")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
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
    [TerraformArgument("active_directory_app_id_or_uri")]
    public TerraformValue<string>? ActiveDirectoryAppIdOrUri
    {
        get => new TerraformReference<string>(this, "active_directory_app_id_or_uri");
        set => SetArgument("active_directory_app_id_or_uri", value);
    }

    /// <summary>
    /// The active_directory_tenant_id attribute.
    /// </summary>
    [TerraformArgument("active_directory_tenant_id")]
    public TerraformValue<string>? ActiveDirectoryTenantId
    {
        get => new TerraformReference<string>(this, "active_directory_tenant_id");
        set => SetArgument("active_directory_tenant_id", value);
    }


    /// <summary>
    /// The max_events_per_batch attribute.
    /// </summary>
    [TerraformArgument("max_events_per_batch")]
    public TerraformValue<double>? MaxEventsPerBatch
    {
        get => new TerraformReference<double>(this, "max_events_per_batch");
        set => SetArgument("max_events_per_batch", value);
    }

    /// <summary>
    /// The preferred_batch_size_in_kilobytes attribute.
    /// </summary>
    [TerraformArgument("preferred_batch_size_in_kilobytes")]
    public TerraformValue<double>? PreferredBatchSizeInKilobytes
    {
        get => new TerraformReference<double>(this, "preferred_batch_size_in_kilobytes");
        set => SetArgument("preferred_batch_size_in_kilobytes", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
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
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    [TerraformArgument("advanced_filtering_on_arrays_enabled")]
    public TerraformValue<bool>? AdvancedFilteringOnArraysEnabled
    {
        get => new TerraformReference<bool>(this, "advanced_filtering_on_arrays_enabled");
        set => SetArgument("advanced_filtering_on_arrays_enabled", value);
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    [TerraformArgument("event_delivery_schema")]
    public TerraformValue<string>? EventDeliverySchema
    {
        get => new TerraformReference<string>(this, "event_delivery_schema");
        set => SetArgument("event_delivery_schema", value);
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    [TerraformArgument("eventhub_endpoint_id")]
    public TerraformValue<string> EventhubEndpointId
    {
        get => new TerraformReference<string>(this, "eventhub_endpoint_id");
        set => SetArgument("eventhub_endpoint_id", value);
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    [TerraformArgument("expiration_time_utc")]
    public TerraformValue<string>? ExpirationTimeUtc
    {
        get => new TerraformReference<string>(this, "expiration_time_utc");
        set => SetArgument("expiration_time_utc", value);
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    [TerraformArgument("hybrid_connection_endpoint_id")]
    public TerraformValue<string> HybridConnectionEndpointId
    {
        get => new TerraformReference<string>(this, "hybrid_connection_endpoint_id");
        set => SetArgument("hybrid_connection_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    [TerraformArgument("included_event_types")]
    public TerraformList<string> IncludedEventTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_event_types").ResolveNodes(ctx));
        set => SetArgument("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformArgument("labels")]
    public TerraformList<string>? Labels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    [TerraformArgument("service_bus_queue_endpoint_id")]
    public TerraformValue<string>? ServiceBusQueueEndpointId
    {
        get => new TerraformReference<string>(this, "service_bus_queue_endpoint_id");
        set => SetArgument("service_bus_queue_endpoint_id", value);
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    [TerraformArgument("service_bus_topic_endpoint_id")]
    public TerraformValue<string>? ServiceBusTopicEndpointId
    {
        get => new TerraformReference<string>(this, "service_bus_topic_endpoint_id");
        set => SetArgument("service_bus_topic_endpoint_id", value);
    }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemTopic is required")]
    [TerraformArgument("system_topic")]
    public required TerraformValue<string> SystemTopic
    {
        get => new TerraformReference<string>(this, "system_topic");
        set => SetArgument("system_topic", value);
    }

    /// <summary>
    /// Block for advanced_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedFilter block(s) allowed")]
    [TerraformArgument("advanced_filter")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionAdvancedFilterBlock> AdvancedFilter { get; set; } = new();

    /// <summary>
    /// Block for azure_function_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFunctionEndpoint block(s) allowed")]
    [TerraformArgument("azure_function_endpoint")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionAzureFunctionEndpointBlock> AzureFunctionEndpoint { get; set; } = new();

    /// <summary>
    /// Block for dead_letter_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterIdentity block(s) allowed")]
    [TerraformArgument("dead_letter_identity")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionDeadLetterIdentityBlock> DeadLetterIdentity { get; set; } = new();

    /// <summary>
    /// Block for delivery_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryIdentity block(s) allowed")]
    [TerraformArgument("delivery_identity")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionDeliveryIdentityBlock> DeliveryIdentity { get; set; } = new();

    /// <summary>
    /// Block for delivery_property.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("delivery_property")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionDeliveryPropertyBlock> DeliveryProperty { get; set; } = new();

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformArgument("retry_policy")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionRetryPolicyBlock> RetryPolicy { get; set; } = new();

    /// <summary>
    /// Block for storage_blob_dead_letter_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageBlobDeadLetterDestination block(s) allowed")]
    [TerraformArgument("storage_blob_dead_letter_destination")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationBlock> StorageBlobDeadLetterDestination { get; set; } = new();

    /// <summary>
    /// Block for storage_queue_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageQueueEndpoint block(s) allowed")]
    [TerraformArgument("storage_queue_endpoint")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionStorageQueueEndpointBlock> StorageQueueEndpoint { get; set; } = new();

    /// <summary>
    /// Block for subject_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectFilter block(s) allowed")]
    [TerraformArgument("subject_filter")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionSubjectFilterBlock> SubjectFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventgridSystemTopicEventSubscriptionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for webhook_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebhookEndpoint block(s) allowed")]
    [TerraformArgument("webhook_endpoint")]
    public TerraformList<AzurermEventgridSystemTopicEventSubscriptionWebhookEndpointBlock> WebhookEndpoint { get; set; } = new();

}
