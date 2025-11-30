using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auto_pause in AzurermSynapseSparkPool.
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
    public required TerraformValue<double> DelayInMinutes
    {
        get => new TerraformReference<double>(this, "delay_in_minutes");
        set => SetArgument("delay_in_minutes", value);
    }

}


/// <summary>
/// Block type for auto_scale in AzurermSynapseSparkPool.
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
    public required TerraformValue<double> MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformValue<double> MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for library_requirement in AzurermSynapseSparkPool.
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
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

}


/// <summary>
/// Block type for spark_config in AzurermSynapseSparkPool.
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
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSynapseSparkPool.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_synapse_spark_pool Terraform resource.
/// Manages a azurerm_synapse_spark_pool resource.
/// </summary>
public partial class AzurermSynapseSparkPool(string name) : TerraformResource("azurerm_synapse_spark_pool", name)
{
    /// <summary>
    /// The cache_size attribute.
    /// </summary>
    public TerraformValue<double>? CacheSize
    {
        get => new TerraformReference<double>(this, "cache_size");
        set => SetArgument("cache_size", value);
    }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ComputeIsolationEnabled
    {
        get => new TerraformReference<bool>(this, "compute_isolation_enabled");
        set => SetArgument("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicExecutorAllocationEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_executor_allocation_enabled");
        set => SetArgument("dynamic_executor_allocation_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_executors attribute.
    /// </summary>
    public TerraformValue<double>? MaxExecutors
    {
        get => new TerraformReference<double>(this, "max_executors");
        set => SetArgument("max_executors", value);
    }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    public TerraformValue<double>? MinExecutors
    {
        get => new TerraformReference<double>(this, "min_executors");
        set => SetArgument("min_executors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformValue<string> NodeSize
    {
        get => new TerraformReference<string>(this, "node_size");
        set => SetArgument("node_size", value);
    }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSizeFamily is required")]
    public required TerraformValue<string> NodeSizeFamily
    {
        get => new TerraformReference<string>(this, "node_size_family");
        set => SetArgument("node_size_family", value);
    }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SessionLevelPackagesEnabled
    {
        get => new TerraformReference<bool>(this, "session_level_packages_enabled");
        set => SetArgument("session_level_packages_enabled", value);
    }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    public TerraformValue<string>? SparkEventsFolder
    {
        get => new TerraformReference<string>(this, "spark_events_folder");
        set => SetArgument("spark_events_folder", value);
    }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    public TerraformValue<string>? SparkLogFolder
    {
        get => new TerraformReference<string>(this, "spark_log_folder");
        set => SetArgument("spark_log_folder", value);
    }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkVersion is required")]
    public required TerraformValue<string> SparkVersion
    {
        get => new TerraformReference<string>(this, "spark_version");
        set => SetArgument("spark_version", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformValue<string> SynapseWorkspaceId
    {
        get => new TerraformReference<string>(this, "synapse_workspace_id");
        set => SetArgument("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AutoPause block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPause block(s) allowed")]
    public TerraformList<AzurermSynapseSparkPoolAutoPauseBlock>? AutoPause
    {
        get => GetArgument<TerraformList<AzurermSynapseSparkPoolAutoPauseBlock>>("auto_pause");
        set => SetArgument("auto_pause", value);
    }

    /// <summary>
    /// AutoScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public TerraformList<AzurermSynapseSparkPoolAutoScaleBlock>? AutoScale
    {
        get => GetArgument<TerraformList<AzurermSynapseSparkPoolAutoScaleBlock>>("auto_scale");
        set => SetArgument("auto_scale", value);
    }

    /// <summary>
    /// LibraryRequirement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LibraryRequirement block(s) allowed")]
    public TerraformList<AzurermSynapseSparkPoolLibraryRequirementBlock>? LibraryRequirement
    {
        get => GetArgument<TerraformList<AzurermSynapseSparkPoolLibraryRequirementBlock>>("library_requirement");
        set => SetArgument("library_requirement", value);
    }

    /// <summary>
    /// SparkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    public TerraformList<AzurermSynapseSparkPoolSparkConfigBlock>? SparkConfig
    {
        get => GetArgument<TerraformList<AzurermSynapseSparkPoolSparkConfigBlock>>("spark_config");
        set => SetArgument("spark_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseSparkPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseSparkPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
