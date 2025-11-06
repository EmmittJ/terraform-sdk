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
    public bool? AdvancedFilteringOnArraysEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("advanced_filtering_on_arrays_enabled")?.Value;
        set => this.WithProperty("advanced_filtering_on_arrays_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The event_delivery_schema attribute.
    /// </summary>
    public string? EventDeliverySchema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_delivery_schema")?.Value;
        set => this.WithProperty("event_delivery_schema", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_endpoint_id attribute.
    /// </summary>
    public string? EventhubEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_endpoint_id")?.Value;
        set => this.WithProperty("eventhub_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expiration_time_utc attribute.
    /// </summary>
    public string? ExpirationTimeUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_time_utc")?.Value;
        set => this.WithProperty("expiration_time_utc", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hybrid_connection_endpoint_id attribute.
    /// </summary>
    public string? HybridConnectionEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hybrid_connection_endpoint_id")?.Value;
        set => this.WithProperty("hybrid_connection_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The included_event_types attribute.
    /// </summary>
    public List<string>? IncludedEventTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("included_event_types")?.Value;
        set => this.WithProperty("included_event_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public List<string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_bus_queue_endpoint_id attribute.
    /// </summary>
    public string? ServiceBusQueueEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_bus_queue_endpoint_id")?.Value;
        set => this.WithProperty("service_bus_queue_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_bus_topic_endpoint_id attribute.
    /// </summary>
    public string? ServiceBusTopicEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_bus_topic_endpoint_id")?.Value;
        set => this.WithProperty("service_bus_topic_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The system_topic attribute.
    /// </summary>
    public string? SystemTopic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("system_topic")?.Value;
        set => this.WithProperty("system_topic", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
