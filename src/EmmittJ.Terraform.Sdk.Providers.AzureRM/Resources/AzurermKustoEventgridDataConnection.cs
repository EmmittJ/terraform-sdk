using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_eventgrid_data_connection resource.
/// </summary>
public class AzurermKustoEventgridDataConnection : TerraformResource
{
    public AzurermKustoEventgridDataConnection(string name) : base("azurerm_kusto_eventgrid_data_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The blob_storage_event_type attribute.
    /// </summary>
    public TerraformProperty<string>? BlobStorageEventType
    {
        get => GetProperty<TerraformProperty<string>>("blob_storage_event_type");
        set => this.WithProperty("blob_storage_event_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string>? DataFormat
    {
        get => GetProperty<TerraformProperty<string>>("data_format");
        set => this.WithProperty("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseRoutingType
    {
        get => GetProperty<TerraformProperty<string>>("database_routing_type");
        set => this.WithProperty("database_routing_type", value);
    }

    /// <summary>
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventgridEventSubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_event_subscription_id");
        set => this.WithProperty("eventgrid_event_subscription_id", value);
    }

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? EventgridResourceId
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_resource_id");
        set => this.WithProperty("eventgrid_resource_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubConsumerGroupName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_consumer_group_name");
        set => this.WithProperty("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_id");
        set => this.WithProperty("eventhub_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("managed_identity_id");
        set => this.WithProperty("managed_identity_id", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ManagedIdentityResourceId
    {
        get => GetProperty<TerraformProperty<string>>("managed_identity_resource_id");
        set => this.WithProperty("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformProperty<string>? MappingRuleName
    {
        get => GetProperty<TerraformProperty<string>>("mapping_rule_name");
        set => this.WithProperty("mapping_rule_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The skip_first_record attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFirstRecord
    {
        get => GetProperty<TerraformProperty<bool>>("skip_first_record");
        set => this.WithProperty("skip_first_record", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformProperty<string>? TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

}
