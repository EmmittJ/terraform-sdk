using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerAutoscaleSettingsBlock : TerraformBlock
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
/// Block type for conflict_resolution_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The conflict_resolution_path attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictResolutionPath
    {
        set => SetProperty("conflict_resolution_path", value);
    }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictResolutionProcedure
    {
        set => SetProperty("conflict_resolution_procedure", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for indexing_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? IndexingMode
    {
        set => SetProperty("indexing_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbSqlContainerTimeoutsBlock : TerraformBlock
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
/// Block type for unique_key in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbSqlContainerUniqueKeyBlock : TerraformBlock
{
    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public HashSet<TerraformProperty<string>>? Paths
    {
        set => SetProperty("paths", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_sql_container resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbSqlContainer : TerraformResource
{
    public AzurermCosmosdbSqlContainer(string name) : base("azurerm_cosmosdb_sql_container", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_name");
        SetOutput("analytical_storage_ttl");
        SetOutput("database_name");
        SetOutput("default_ttl");
        SetOutput("id");
        SetOutput("name");
        SetOutput("partition_key_kind");
        SetOutput("partition_key_paths");
        SetOutput("partition_key_version");
        SetOutput("resource_group_name");
        SetOutput("throughput");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
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
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
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
    /// The partition_key_kind attribute.
    /// </summary>
    public TerraformProperty<string> PartitionKeyKind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partition_key_kind");
        set => SetProperty("partition_key_kind", value);
    }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPaths is required")]
    public List<TerraformProperty<string>> PartitionKeyPaths
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("partition_key_paths");
        set => SetProperty("partition_key_paths", value);
    }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    public TerraformProperty<double> PartitionKeyVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("partition_key_version");
        set => SetProperty("partition_key_version", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    public List<AzurermCosmosdbSqlContainerAutoscaleSettingsBlock>? AutoscaleSettings
    {
        set => SetProperty("autoscale_settings", value);
    }

    /// <summary>
    /// Block for conflict_resolution_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    public List<AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock>? ConflictResolutionPolicy
    {
        set => SetProperty("conflict_resolution_policy", value);
    }

    /// <summary>
    /// Block for indexing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexingPolicy block(s) allowed")]
    public List<AzurermCosmosdbSqlContainerIndexingPolicyBlock>? IndexingPolicy
    {
        set => SetProperty("indexing_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbSqlContainerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for unique_key.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbSqlContainerUniqueKeyBlock>? UniqueKey
    {
        set => SetProperty("unique_key", value);
    }

}
