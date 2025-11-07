using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventgrid_event_subscription resource.
/// </summary>
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
    public TerraformProperty<List<string>>? IncludedEventTypes
    {
        get => GetProperty<TerraformProperty<List<string>>>("included_event_types");
        set => this.WithProperty("included_event_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Labels
    {
        get => GetProperty<TerraformProperty<List<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
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

}
