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
    public double? CacheSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cache_size")?.Value;
        set => this.WithProperty("cache_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public bool? ComputeIsolationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("compute_isolation_enabled")?.Value;
        set => this.WithProperty("compute_isolation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    public bool? DynamicExecutorAllocationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dynamic_executor_allocation_enabled")?.Value;
        set => this.WithProperty("dynamic_executor_allocation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The max_executors attribute.
    /// </summary>
    public double? MaxExecutors
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_executors")?.Value;
        set => this.WithProperty("max_executors", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    public double? MinExecutors
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_executors")?.Value;
        set => this.WithProperty("min_executors", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The node_count attribute.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    public string? NodeSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_size")?.Value;
        set => this.WithProperty("node_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    public string? NodeSizeFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_size_family")?.Value;
        set => this.WithProperty("node_size_family", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    public bool? SessionLevelPackagesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("session_level_packages_enabled")?.Value;
        set => this.WithProperty("session_level_packages_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    public string? SparkEventsFolder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spark_events_folder")?.Value;
        set => this.WithProperty("spark_events_folder", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    public string? SparkLogFolder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spark_log_folder")?.Value;
        set => this.WithProperty("spark_log_folder", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    public string? SparkVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spark_version")?.Value;
        set => this.WithProperty("spark_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public string? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id")?.Value;
        set => this.WithProperty("synapse_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
