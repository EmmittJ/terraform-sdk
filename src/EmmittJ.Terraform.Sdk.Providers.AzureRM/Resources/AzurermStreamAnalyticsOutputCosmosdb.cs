using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputCosmosdbTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The cosmosdb_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountKey is required")]
    public required TerraformProperty<string> CosmosdbAccountKey
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_account_key");
        set => this.WithProperty("cosmosdb_account_key", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbSqlDatabaseId is required")]
    public required TerraformProperty<string> CosmosdbSqlDatabaseId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformProperty<string> StreamAnalyticsJobId
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputCosmosdbTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStreamAnalyticsOutputCosmosdbTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
