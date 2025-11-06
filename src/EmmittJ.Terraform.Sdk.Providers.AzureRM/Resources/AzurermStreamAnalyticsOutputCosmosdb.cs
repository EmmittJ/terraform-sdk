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
    public string? AuthenticationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_mode")?.Value;
        set => this.WithProperty("authentication_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public string? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name")?.Value;
        set => this.WithProperty("container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_account_key attribute.
    /// </summary>
    public string? CosmosdbAccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_account_key")?.Value;
        set => this.WithProperty("cosmosdb_account_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_sql_database_id attribute.
    /// </summary>
    public string? CosmosdbSqlDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_sql_database_id")?.Value;
        set => this.WithProperty("cosmosdb_sql_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The document_id attribute.
    /// </summary>
    public string? DocumentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_id")?.Value;
        set => this.WithProperty("document_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public string? PartitionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key")?.Value;
        set => this.WithProperty("partition_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public string? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id")?.Value;
        set => this.WithProperty("stream_analytics_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
