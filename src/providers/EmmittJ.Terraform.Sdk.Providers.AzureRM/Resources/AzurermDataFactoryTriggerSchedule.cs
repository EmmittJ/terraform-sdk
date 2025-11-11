using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerSchedulePipelineBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerScheduleScheduleBlock
{
    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [TerraformPropertyName("days_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformList<double>? DaysOfMonth { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DaysOfWeek { get; set; }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [TerraformPropertyName("hours")]
    // Optional argument - user may or may not set a value
    public TerraformList<double>? Hours { get; set; }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [TerraformPropertyName("minutes")]
    // Optional argument - user may or may not set a value
    public TerraformList<double>? Minutes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_trigger_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryTriggerSchedule : TerraformResource
{
    public AzurermDataFactoryTriggerSchedule(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformPropertyName("activated")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Activated { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EndTime { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PipelineName { get; set; } = default!;

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_parameters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> PipelineParameters { get; set; } = default!;

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartTime { get; set; } = default!;

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("pipeline")]
    public TerraformList<TerraformBlock<AzurermDataFactoryTriggerSchedulePipelineBlock>>? Pipeline { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermDataFactoryTriggerScheduleScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryTriggerScheduleTimeoutsBlock>? Timeouts { get; set; }

}
