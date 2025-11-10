using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_pause in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolAutoPauseBlock : TerraformBlock
{
    /// <summary>
    /// The delay_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelayInMinutes is required")]
    public required TerraformProperty<double> DelayInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("delay_in_minutes");
        set => WithProperty("delay_in_minutes", value);
    }

}

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformProperty<double> MaxNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformProperty<double> MinNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("min_node_count");
        set => WithProperty("min_node_count", value);
    }

}

/// <summary>
/// Block type for library_requirement in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolLibraryRequirementBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => WithProperty("filename", value);
    }

}

/// <summary>
/// Block type for spark_config in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolSparkConfigBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => WithProperty("filename", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSparkPoolTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_spark_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformProperty<string> NodeSize
    {
        get => GetProperty<TerraformProperty<string>>("node_size");
        set => this.WithProperty("node_size", value);
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSizeFamily is required")]
    public required TerraformProperty<string> NodeSizeFamily
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkVersion is required")]
    public required TerraformProperty<string> SparkVersion
    {
        get => GetProperty<TerraformProperty<string>>("spark_version");
        set => this.WithProperty("spark_version", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for auto_pause.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPause block(s) allowed")]
    public List<AzurermSynapseSparkPoolAutoPauseBlock>? AutoPause
    {
        get => GetProperty<List<AzurermSynapseSparkPoolAutoPauseBlock>>("auto_pause");
        set => this.WithProperty("auto_pause", value);
    }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public List<AzurermSynapseSparkPoolAutoScaleBlock>? AutoScale
    {
        get => GetProperty<List<AzurermSynapseSparkPoolAutoScaleBlock>>("auto_scale");
        set => this.WithProperty("auto_scale", value);
    }

    /// <summary>
    /// Block for library_requirement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LibraryRequirement block(s) allowed")]
    public List<AzurermSynapseSparkPoolLibraryRequirementBlock>? LibraryRequirement
    {
        get => GetProperty<List<AzurermSynapseSparkPoolLibraryRequirementBlock>>("library_requirement");
        set => this.WithProperty("library_requirement", value);
    }

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    public List<AzurermSynapseSparkPoolSparkConfigBlock>? SparkConfig
    {
        get => GetProperty<List<AzurermSynapseSparkPoolSparkConfigBlock>>("spark_config");
        set => this.WithProperty("spark_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSparkPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSynapseSparkPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
