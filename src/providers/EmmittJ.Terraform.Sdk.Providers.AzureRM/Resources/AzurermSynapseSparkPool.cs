using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_pause in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolAutoPauseBlock : ITerraformBlock
{
    /// <summary>
    /// The delay_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelayInMinutes is required")]
    [TerraformPropertyName("delay_in_minutes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DelayInMinutes { get; set; }

}

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolAutoScaleBlock : ITerraformBlock
{
    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformPropertyName("max_node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxNodeCount { get; set; }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformPropertyName("min_node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinNodeCount { get; set; }

}

/// <summary>
/// Block type for library_requirement in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolLibraryRequirementBlock : ITerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformPropertyName("filename")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filename { get; set; }

}

/// <summary>
/// Block type for spark_config in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSparkPoolSparkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformPropertyName("filename")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filename { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSparkPoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("cache_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CacheSize { get; set; }

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("compute_isolation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ComputeIsolationEnabled { get; set; }

    /// <summary>
    /// The dynamic_executor_allocation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_executor_allocation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_executors attribute.
    /// </summary>
    [TerraformPropertyName("max_executors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxExecutors { get; set; }

    /// <summary>
    /// The min_executors attribute.
    /// </summary>
    [TerraformPropertyName("min_executors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinExecutors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    [TerraformPropertyName("node_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeSize { get; set; }

    /// <summary>
    /// The node_size_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSizeFamily is required")]
    [TerraformPropertyName("node_size_family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeSizeFamily { get; set; }

    /// <summary>
    /// The session_level_packages_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_level_packages_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SessionLevelPackagesEnabled { get; set; }

    /// <summary>
    /// The spark_events_folder attribute.
    /// </summary>
    [TerraformPropertyName("spark_events_folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SparkEventsFolder { get; set; }

    /// <summary>
    /// The spark_log_folder attribute.
    /// </summary>
    [TerraformPropertyName("spark_log_folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SparkLogFolder { get; set; }

    /// <summary>
    /// The spark_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkVersion is required")]
    [TerraformPropertyName("spark_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SparkVersion { get; set; }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    [TerraformPropertyName("synapse_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SynapseWorkspaceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for auto_pause.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoPause block(s) allowed")]
    [TerraformPropertyName("auto_pause")]
    public TerraformList<TerraformBlock<AzurermSynapseSparkPoolAutoPauseBlock>>? AutoPause { get; set; } = new();

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    [TerraformPropertyName("auto_scale")]
    public TerraformList<TerraformBlock<AzurermSynapseSparkPoolAutoScaleBlock>>? AutoScale { get; set; } = new();

    /// <summary>
    /// Block for library_requirement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LibraryRequirement block(s) allowed")]
    [TerraformPropertyName("library_requirement")]
    public TerraformList<TerraformBlock<AzurermSynapseSparkPoolLibraryRequirementBlock>>? LibraryRequirement { get; set; } = new();

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    [TerraformPropertyName("spark_config")]
    public TerraformList<TerraformBlock<AzurermSynapseSparkPoolSparkConfigBlock>>? SparkConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSynapseSparkPoolTimeoutsBlock>? Timeouts { get; set; } = new();

}
