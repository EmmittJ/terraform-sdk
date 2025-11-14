using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for auto_pause in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolAutoPauseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_pause";

    /// <summary>
    /// The delay_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelayInMinutes is required")]
    [TerraformArgument("delay_in_minutes")]
    public required TerraformValue<double> DelayInMinutes
    {
        get => new TerraformReference<double>(this, "delay_in_minutes");
        set => SetArgument("delay_in_minutes", value);
    }

}

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scale";

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformArgument("max_node_count")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformArgument("min_node_count")]
    public required TerraformValue<double> MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

}

/// <summary>
/// Block type for library_requirement in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolLibraryRequirementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "library_requirement";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformArgument("content")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformArgument("filename")]
    public required TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

}

/// <summary>
/// Block type for spark_config in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolSparkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_config";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformArgument("content")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformArgument("filename")]
    public required TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSparkPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The cache_size attribute.
    /// </summary>
    [TerraformArgument("cache_size")]
    public TerraformValue<double>? CacheSize
    {
        get => new TerraformReference<double>(this, "cache_size");
        set => SetArgument("cache_size", value);
    }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    [TerraformArgument("compute_isolation_enabled")]
    public TerraformValue<bool>? ComputeIsolationEnabled
    {
        get => new TerraformReference<bool>(this, "compute_isolation_enabled");
        set => SetArgument("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_executor_allocation_enabled")]
    public TerraformValue<bool>? DynamicExecutorAllocationEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_executor_allocation_enabled");
        set => SetArgument("dynamic_executor_allocation_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_executors attribute.
    /// </summary>
    [TerraformArgument("max_executors")]
    public TerraformValue<double>? MaxExecutors
    {
        get => new TerraformReference<double>(this, "max_executors");
        set => SetArgument("max_executors", value);
    }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    [TerraformArgument("min_executors")]
    public TerraformValue<double>? MinExecutors
    {
        get => new TerraformReference<double>(this, "min_executors");
        set => SetArgument("min_executors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformArgument("node_count")]
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    [TerraformArgument("node_size")]
    public required TerraformValue<string> NodeSize
    {
        get => new TerraformReference<string>(this, "node_size");
        set => SetArgument("node_size", value);
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSizeFamily is required")]
    [TerraformArgument("node_size_family")]
    public required TerraformValue<string> NodeSizeFamily
    {
        get => new TerraformReference<string>(this, "node_size_family");
        set => SetArgument("node_size_family", value);
    }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    [TerraformArgument("session_level_packages_enabled")]
    public TerraformValue<bool>? SessionLevelPackagesEnabled
    {
        get => new TerraformReference<bool>(this, "session_level_packages_enabled");
        set => SetArgument("session_level_packages_enabled", value);
    }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    [TerraformArgument("spark_events_folder")]
    public TerraformValue<string>? SparkEventsFolder
    {
        get => new TerraformReference<string>(this, "spark_events_folder");
        set => SetArgument("spark_events_folder", value);
    }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    [TerraformArgument("spark_log_folder")]
    public TerraformValue<string>? SparkLogFolder
    {
        get => new TerraformReference<string>(this, "spark_log_folder");
        set => SetArgument("spark_log_folder", value);
    }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkVersion is required")]
    [TerraformArgument("spark_version")]
    public required TerraformValue<string> SparkVersion
    {
        get => new TerraformReference<string>(this, "spark_version");
        set => SetArgument("spark_version", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    [TerraformArgument("synapse_workspace_id")]
    public required TerraformValue<string> SynapseWorkspaceId
    {
        get => new TerraformReference<string>(this, "synapse_workspace_id");
        set => SetArgument("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for auto_pause.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPause block(s) allowed")]
    [TerraformArgument("auto_pause")]
    public TerraformList<AzurermSynapseSparkPoolAutoPauseBlock> AutoPause { get; set; } = new();

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    [TerraformArgument("auto_scale")]
    public TerraformList<AzurermSynapseSparkPoolAutoScaleBlock> AutoScale { get; set; } = new();

    /// <summary>
    /// Block for library_requirement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LibraryRequirement block(s) allowed")]
    [TerraformArgument("library_requirement")]
    public TerraformList<AzurermSynapseSparkPoolLibraryRequirementBlock> LibraryRequirement { get; set; } = new();

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    [TerraformArgument("spark_config")]
    public TerraformList<AzurermSynapseSparkPoolSparkConfigBlock> SparkConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSynapseSparkPoolTimeoutsBlock Timeouts { get; set; } = new();

}
