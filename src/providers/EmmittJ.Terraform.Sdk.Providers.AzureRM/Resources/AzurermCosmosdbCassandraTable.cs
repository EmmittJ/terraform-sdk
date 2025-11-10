using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableAutoscaleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    public TerraformProperty<double>? MaxThroughput
    {
        set => SetProperty("max_throughput", value);
    }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraTableTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cosmosdb_cassandra_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbCassandraTable : TerraformResource
{
    public AzurermCosmosdbCassandraTable(string name) : base("azurerm_cosmosdb_cassandra_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("analytical_storage_ttl");
        SetOutput("cassandra_keyspace_id");
        SetOutput("default_ttl");
        SetOutput("id");
        SetOutput("name");
        SetOutput("throughput");
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformProperty<double> AnalyticalStorageTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("analytical_storage_ttl");
        set => SetProperty("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The cassandra_keyspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraKeyspaceId is required")]
    public required TerraformProperty<string> CassandraKeyspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cassandra_keyspace_id");
        set => SetProperty("cassandra_keyspace_id", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double> DefaultTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_ttl");
        set => SetProperty("default_ttl", value);
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
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double> Throughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput");
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public List<AzurermCosmosdbCassandraTableAutoscaleSettingsBlock>? AutoscaleSettings
    {
        set => SetProperty("autoscale_settings", value);
    }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public List<AzurermCosmosdbCassandraTableSchemaBlock>? Schema
    {
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbCassandraTableTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
