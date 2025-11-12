using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryTriggerSchedulePipelineBlock() : TerraformBlock("pipeline")
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
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryTriggerScheduleScheduleBlock() : TerraformBlock("schedule")
{
    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [TerraformProperty("days_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<double>? DaysOfMonth { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformProperty("days_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DaysOfWeek { get; set; }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [TerraformProperty("hours")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<double>? Hours { get; set; }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [TerraformProperty("minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<double>? Minutes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryTriggerScheduleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_data_factory_trigger_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryTriggerSchedule : TerraformResource
{
    public AzurermDataFactoryTriggerSchedule(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformProperty("activated")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Activated { get; set; }

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
    [TerraformProperty("frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformProperty("pipeline_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PipelineName { get; set; }

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    [TerraformProperty("pipeline_parameters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> PipelineParameters { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("pipeline")]
    public TerraformList<AzurermDataFactoryTriggerSchedulePipelineBlock> Pipeline { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public TerraformList<AzurermDataFactoryTriggerScheduleScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryTriggerScheduleTimeoutsBlock Timeouts { get; set; } = new();

}
