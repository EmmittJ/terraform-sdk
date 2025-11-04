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
    public string? DigitalTwinsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("digital_twins_id")?.Value;
        set => this.WithProperty("digital_twins_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The eventhub_name attribute.
    /// </summary>
    public string? EventhubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_name")?.Value;
        set => this.WithProperty("eventhub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    public string? EventhubNamespaceEndpointUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_namespace_endpoint_uri")?.Value;
        set => this.WithProperty("eventhub_namespace_endpoint_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    public string? EventhubNamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_namespace_id")?.Value;
        set => this.WithProperty("eventhub_namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    public string? KustoClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_cluster_id")?.Value;
        set => this.WithProperty("kusto_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    public string? KustoClusterUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_cluster_uri")?.Value;
        set => this.WithProperty("kusto_cluster_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    public string? KustoDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_database_name")?.Value;
        set => this.WithProperty("kusto_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    public string? KustoTableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_table_name")?.Value;
        set => this.WithProperty("kusto_table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
