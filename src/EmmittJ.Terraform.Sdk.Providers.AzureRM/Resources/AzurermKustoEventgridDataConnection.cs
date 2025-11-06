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
    public string? BlobStorageEventType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_storage_event_type")?.Value;
        set => this.WithProperty("blob_storage_event_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public string? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format")?.Value;
        set => this.WithProperty("data_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public string? DatabaseRoutingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_routing_type")?.Value;
        set => this.WithProperty("database_routing_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    public string? EventgridEventSubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventgrid_event_subscription_id")?.Value;
        set => this.WithProperty("eventgrid_event_subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? EventgridResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventgrid_resource_id")?.Value;
        set => this.WithProperty("eventgrid_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public string? EventhubConsumerGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_consumer_group_name")?.Value;
        set => this.WithProperty("eventhub_consumer_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    public string? EventhubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_id")?.Value;
        set => this.WithProperty("eventhub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    public string? ManagedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_identity_id")?.Value;
        set => this.WithProperty("managed_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? ManagedIdentityResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_identity_resource_id")?.Value;
        set => this.WithProperty("managed_identity_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public string? MappingRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mapping_rule_name")?.Value;
        set => this.WithProperty("mapping_rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The skip_first_record attribute.
    /// </summary>
    public bool? SkipFirstRecord
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_first_record")?.Value;
        set => this.WithProperty("skip_first_record", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
