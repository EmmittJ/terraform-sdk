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
    public TerraformProperty<double>? CacheSize
    {
        get => GetProperty<TerraformProperty<double>>("cache_size");
        set => this.WithProperty("cache_size", value);
    }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ComputeIsolationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("compute_isolation_enabled");
        set => this.WithProperty("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicExecutorAllocationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_executor_allocation_enabled");
        set => this.WithProperty("dynamic_executor_allocation_enabled", value);
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
    /// The max_executors attribute.
    /// </summary>
    public TerraformProperty<double>? MaxExecutors
    {
        get => GetProperty<TerraformProperty<double>>("max_executors");
        set => this.WithProperty("max_executors", value);
    }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    public TerraformProperty<double>? MinExecutors
    {
        get => GetProperty<TerraformProperty<double>>("min_executors");
        set => this.WithProperty("min_executors", value);
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
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    public TerraformProperty<string>? NodeSize
    {
        get => GetProperty<TerraformProperty<string>>("node_size");
        set => this.WithProperty("node_size", value);
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    public TerraformProperty<string>? NodeSizeFamily
    {
        get => GetProperty<TerraformProperty<string>>("node_size_family");
        set => this.WithProperty("node_size_family", value);
    }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SessionLevelPackagesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("session_level_packages_enabled");
        set => this.WithProperty("session_level_packages_enabled", value);
    }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    public TerraformProperty<string>? SparkEventsFolder
    {
        get => GetProperty<TerraformProperty<string>>("spark_events_folder");
        set => this.WithProperty("spark_events_folder", value);
    }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    public TerraformProperty<string>? SparkLogFolder
    {
        get => GetProperty<TerraformProperty<string>>("spark_log_folder");
        set => this.WithProperty("spark_log_folder", value);
    }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    public TerraformProperty<string>? SparkVersion
    {
        get => GetProperty<TerraformProperty<string>>("spark_version");
        set => this.WithProperty("spark_version", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
