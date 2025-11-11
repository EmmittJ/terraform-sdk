using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_pause in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseSparkPoolAutoPauseBlock : TerraformBlockBase
{
    /// <summary>
    /// The delay_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelayInMinutes is required")]
    [TerraformProperty("delay_in_minutes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DelayInMinutes { get; set; }

}

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseSparkPoolAutoScaleBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformProperty("max_node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxNodeCount { get; set; }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformProperty("min_node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinNodeCount { get; set; }

}

/// <summary>
/// Block type for library_requirement in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseSparkPoolLibraryRequirementBlock : TerraformBlockBase
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformProperty("filename")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filename { get; set; }

}

/// <summary>
/// Block type for spark_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseSparkPoolSparkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformProperty("filename")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filename { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseSparkPoolTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_synapse_spark_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSynapseSparkPool : TerraformResource
{
    public AzurermSynapseSparkPool(string name) : base("azurerm_synapse_spark_pool", name)
    {
    }

    /// <summary>
    /// The cache_size attribute.
    /// </summary>
    [TerraformProperty("cache_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CacheSize { get; set; }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    [TerraformProperty("compute_isolation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ComputeIsolationEnabled { get; set; }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_executor_allocation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_executors attribute.
    /// </summary>
    [TerraformProperty("max_executors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxExecutors { get; set; }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    [TerraformProperty("min_executors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinExecutors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    [TerraformProperty("node_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeSize { get; set; }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSizeFamily is required")]
    [TerraformProperty("node_size_family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeSizeFamily { get; set; }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    [TerraformProperty("session_level_packages_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SessionLevelPackagesEnabled { get; set; }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    [TerraformProperty("spark_events_folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SparkEventsFolder { get; set; }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    [TerraformProperty("spark_log_folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SparkLogFolder { get; set; }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkVersion is required")]
    [TerraformProperty("spark_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SparkVersion { get; set; }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    [TerraformProperty("synapse_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SynapseWorkspaceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for auto_pause.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPause block(s) allowed")]
    [TerraformProperty("auto_pause")]
    public partial TerraformList<TerraformBlock<AzurermSynapseSparkPoolAutoPauseBlock>>? AutoPause { get; set; }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    [TerraformProperty("auto_scale")]
    public partial TerraformList<TerraformBlock<AzurermSynapseSparkPoolAutoScaleBlock>>? AutoScale { get; set; }

    /// <summary>
    /// Block for library_requirement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LibraryRequirement block(s) allowed")]
    [TerraformProperty("library_requirement")]
    public partial TerraformList<TerraformBlock<AzurermSynapseSparkPoolLibraryRequirementBlock>>? LibraryRequirement { get; set; }

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    [TerraformProperty("spark_config")]
    public partial TerraformList<TerraformBlock<AzurermSynapseSparkPoolSparkConfigBlock>>? SparkConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSynapseSparkPoolTimeoutsBlock>? Timeouts { get; set; }

}
