using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_spark_pool resource.
/// </summary>
public class AzurermSynapseSparkPool : TerraformResource
{
    public AzurermSynapseSparkPool(string name) : base("azurerm_synapse_spark_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cache_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CacheSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cache_size");
        set => this.WithProperty("cache_size", value);
    }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ComputeIsolationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("compute_isolation_enabled");
        set => this.WithProperty("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DynamicExecutorAllocationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dynamic_executor_allocation_enabled");
        set => this.WithProperty("dynamic_executor_allocation_enabled", value);
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
    /// The max_executors attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxExecutors
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_executors");
        set => this.WithProperty("max_executors", value);
    }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinExecutors
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_executors");
        set => this.WithProperty("min_executors", value);
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
    /// The node_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_size");
        set => this.WithProperty("node_size", value);
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeSizeFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_size_family");
        set => this.WithProperty("node_size_family", value);
    }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SessionLevelPackagesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("session_level_packages_enabled");
        set => this.WithProperty("session_level_packages_enabled", value);
    }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SparkEventsFolder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spark_events_folder");
        set => this.WithProperty("spark_events_folder", value);
    }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SparkLogFolder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spark_log_folder");
        set => this.WithProperty("spark_log_folder", value);
    }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SparkVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spark_version");
        set => this.WithProperty("spark_version", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
