using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_cosmosdb resource.
/// </summary>
public class AzurermStreamAnalyticsOutputCosmosdb : TerraformResource
{
    public AzurermStreamAnalyticsOutputCosmosdb(string name) : base("azurerm_stream_analytics_output_cosmosdb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The cosmosdb_account_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbAccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_account_key");
        set => this.WithProperty("cosmosdb_account_key", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbSqlDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_sql_database_id");
        set => this.WithProperty("cosmosdb_sql_database_id", value);
    }

    /// <summary>
    /// The document_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DocumentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_id");
        set => this.WithProperty("document_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key");
        set => this.WithProperty("partition_key", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
    }

}
