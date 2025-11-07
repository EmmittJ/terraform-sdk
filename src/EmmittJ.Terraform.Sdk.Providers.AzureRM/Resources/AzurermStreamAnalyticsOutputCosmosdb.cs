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
    public TerraformProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The cosmosdb_account_key attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbAccountKey
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_account_key");
        set => this.WithProperty("cosmosdb_account_key", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbSqlDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_sql_database_id");
        set => this.WithProperty("cosmosdb_sql_database_id", value);
    }

    /// <summary>
    /// The document_id attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentId
    {
        get => GetProperty<TerraformProperty<string>>("document_id");
        set => this.WithProperty("document_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformProperty<string>>("partition_key");
        set => this.WithProperty("partition_key", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
    }

}
