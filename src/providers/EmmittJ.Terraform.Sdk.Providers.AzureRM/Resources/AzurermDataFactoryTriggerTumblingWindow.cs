using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryTriggerTumblingWindowPipelineBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for retry in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryTriggerTumblingWindowRetryBlock : TerraformBlockBase
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Interval { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock : TerraformBlockBase
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
/// Block type for trigger_dependency in .
/// Nesting mode: set
/// </summary>
public partial class AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock : TerraformBlockBase
{
    /// <summary>
    /// The offset attribute.
    /// </summary>
    [TerraformProperty("offset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Offset { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Size { get; set; }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [TerraformProperty("trigger_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TriggerName { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_trigger_tumbling_window resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryTriggerTumblingWindow : TerraformResource
{
    public AzurermDataFactoryTriggerTumblingWindow(string name) : base("azurerm_data_factory_trigger_tumbling_window", name)
    {
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformProperty("activated")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Activated { get; set; }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [TerraformProperty("delay")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delay { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndTime { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformProperty("max_concurrency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformProperty("start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pipeline is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pipeline block(s) allowed")]
    [TerraformProperty("pipeline")]
    public partial TerraformList<TerraformBlock<AzurermDataFactoryTriggerTumblingWindowPipelineBlock>>? Pipeline { get; set; }

    /// <summary>
    /// Block for retry.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retry block(s) allowed")]
    [TerraformProperty("retry")]
    public partial TerraformList<TerraformBlock<AzurermDataFactoryTriggerTumblingWindowRetryBlock>>? Retry { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for trigger_dependency.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("trigger_dependency")]
    public partial TerraformSet<TerraformBlock<AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock>>? TriggerDependency { get; set; }

}
