using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_digital_twins_time_series_database_connection resource.
/// </summary>
public class AzurermDigitalTwinsTimeSeriesDatabaseConnection : TerraformResource
{
    public AzurermDigitalTwinsTimeSeriesDatabaseConnection(string name) : base("azurerm_digital_twins_time_series_database_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    public TerraformProperty<string>? DigitalTwinsId
    {
        get => GetProperty<TerraformProperty<string>>("digital_twins_id");
        set => this.WithProperty("digital_twins_id", value);
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
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_name");
        set => this.WithProperty("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubNamespaceEndpointUri
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_namespace_endpoint_uri");
        set => this.WithProperty("eventhub_namespace_endpoint_uri", value);
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubNamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_namespace_id");
        set => this.WithProperty("eventhub_namespace_id", value);
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? KustoClusterId
    {
        get => GetProperty<TerraformProperty<string>>("kusto_cluster_id");
        set => this.WithProperty("kusto_cluster_id", value);
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    public TerraformProperty<string>? KustoClusterUri
    {
        get => GetProperty<TerraformProperty<string>>("kusto_cluster_uri");
        set => this.WithProperty("kusto_cluster_uri", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    public TerraformProperty<string>? KustoDatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("kusto_database_name");
        set => this.WithProperty("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    public TerraformProperty<string>? KustoTableName
    {
        get => GetProperty<TerraformProperty<string>>("kusto_table_name");
        set => this.WithProperty("kusto_table_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
