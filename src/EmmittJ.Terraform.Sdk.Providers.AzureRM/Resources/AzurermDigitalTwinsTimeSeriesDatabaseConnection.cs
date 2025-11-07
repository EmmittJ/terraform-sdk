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
    public TerraformLiteralProperty<string>? DigitalTwinsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("digital_twins_id");
        set => this.WithProperty("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventhubConsumerGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_consumer_group_name");
        set => this.WithProperty("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventhubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_name");
        set => this.WithProperty("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventhubNamespaceEndpointUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_namespace_endpoint_uri");
        set => this.WithProperty("eventhub_namespace_endpoint_uri", value);
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventhubNamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_namespace_id");
        set => this.WithProperty("eventhub_namespace_id", value);
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_cluster_id");
        set => this.WithProperty("kusto_cluster_id", value);
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoClusterUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_cluster_uri");
        set => this.WithProperty("kusto_cluster_uri", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_database_name");
        set => this.WithProperty("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoTableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_table_name");
        set => this.WithProperty("kusto_table_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
