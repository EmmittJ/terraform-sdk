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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("authentication_mode");
        SetOutput("container_name");
        SetOutput("cosmosdb_account_key");
        SetOutput("cosmosdb_sql_database_id");
        SetOutput("document_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("partition_key");
        SetOutput("stream_analytics_job_id");
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_mode");
        set => SetProperty("authentication_mode", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_name");
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The cosmosdb_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountKey is required")]
    public required TerraformProperty<string> CosmosdbAccountKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_account_key");
        set => SetProperty("cosmosdb_account_key", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbSqlDatabaseId is required")]
    public required TerraformProperty<string> CosmosdbSqlDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_sql_database_id");
        set => SetProperty("cosmosdb_sql_database_id", value);
    }

    /// <summary>
    /// The document_id attribute.
    /// </summary>
    public TerraformProperty<string> DocumentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_id");
        set => SetProperty("document_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformProperty<string> PartitionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partition_key");
        set => SetProperty("partition_key", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformProperty<string> StreamAnalyticsJobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_id");
        set => SetProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputCosmosdbTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
