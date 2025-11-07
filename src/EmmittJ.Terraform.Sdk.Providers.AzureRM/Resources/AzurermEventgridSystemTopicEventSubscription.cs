using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventgrid_system_topic_event_subscription resource.
/// </summary>
public class AzurermEventgridSystemTopicEventSubscription : TerraformResource
{
    public AzurermEventgridSystemTopicEventSubscription(string name) : base("azurerm_eventgrid_system_topic_event_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The advanced_filtering_on_arrays_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AdvancedFilteringOnArraysEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("advanced_filtering_on_arrays_enabled");
        set => this.WithProperty("advanced_filtering_on_arrays_enabled", value);
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventDeliverySchema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_delivery_schema");
        set => this.WithProperty("event_delivery_schema", value);
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventhubEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_endpoint_id");
        set => this.WithProperty("eventhub_endpoint_id", value);
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpirationTimeUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_time_utc");
        set => this.WithProperty("expiration_time_utc", value);
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HybridConnectionEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hybrid_connection_endpoint_id");
        set => this.WithProperty("hybrid_connection_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? IncludedEventTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("included_event_types");
        set => this.WithProperty("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceBusQueueEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_bus_queue_endpoint_id");
        set => this.WithProperty("service_bus_queue_endpoint_id", value);
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceBusTopicEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_bus_topic_endpoint_id");
        set => this.WithProperty("service_bus_topic_endpoint_id", value);
    }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SystemTopic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("system_topic");
        set => this.WithProperty("system_topic", value);
    }

}
