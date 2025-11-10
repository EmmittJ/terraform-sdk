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
        set => SetProperty("delay_in_minutes", value);
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
        set => SetProperty("max_node_count", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformProperty<double> MinNodeCount
    {
        set => SetProperty("min_node_count", value);
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
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        set => SetProperty("filename", value);
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
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        set => SetProperty("filename", value);
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
        SetOutput("cache_size");
        SetOutput("compute_isolation_enabled");
        SetOutput("dynamic_executor_allocation_enabled");
        SetOutput("id");
        SetOutput("max_executors");
        SetOutput("min_executors");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("node_size");
        SetOutput("node_size_family");
        SetOutput("session_level_packages_enabled");
        SetOutput("spark_events_folder");
        SetOutput("spark_log_folder");
        SetOutput("spark_version");
        SetOutput("synapse_workspace_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The cache_size attribute.
    /// </summary>
    public TerraformProperty<double> CacheSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cache_size");
        set => SetProperty("cache_size", value);
    }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ComputeIsolationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("compute_isolation_enabled");
        set => SetProperty("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DynamicExecutorAllocationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dynamic_executor_allocation_enabled");
        set => SetProperty("dynamic_executor_allocation_enabled", value);
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
    /// The max_executors attribute.
    /// </summary>
    public TerraformProperty<double> MaxExecutors
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_executors");
        set => SetProperty("max_executors", value);
    }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    public TerraformProperty<double> MinExecutors
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_executors");
        set => SetProperty("min_executors", value);
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
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformProperty<string> NodeSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_size");
        set => SetProperty("node_size", value);
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSizeFamily is required")]
    public required TerraformProperty<string> NodeSizeFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_size_family");
        set => SetProperty("node_size_family", value);
    }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SessionLevelPackagesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("session_level_packages_enabled");
        set => SetProperty("session_level_packages_enabled", value);
    }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    public TerraformProperty<string> SparkEventsFolder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spark_events_folder");
        set => SetProperty("spark_events_folder", value);
    }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    public TerraformProperty<string> SparkLogFolder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spark_log_folder");
        set => SetProperty("spark_log_folder", value);
    }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkVersion is required")]
    public required TerraformProperty<string> SparkVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spark_version");
        set => SetProperty("spark_version", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synapse_workspace_id");
        set => SetProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for auto_pause.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPause block(s) allowed")]
    public List<AzurermSynapseSparkPoolAutoPauseBlock>? AutoPause
    {
        set => SetProperty("auto_pause", value);
    }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public List<AzurermSynapseSparkPoolAutoScaleBlock>? AutoScale
    {
        set => SetProperty("auto_scale", value);
    }

    /// <summary>
    /// Block for library_requirement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LibraryRequirement block(s) allowed")]
    public List<AzurermSynapseSparkPoolLibraryRequirementBlock>? LibraryRequirement
    {
        set => SetProperty("library_requirement", value);
    }

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    public List<AzurermSynapseSparkPoolSparkConfigBlock>? SparkConfig
    {
        set => SetProperty("spark_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSparkPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
