using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerSchedulePipelineBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerScheduleScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [TerraformPropertyName("days_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<double>>>? DaysOfMonth { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DaysOfWeek { get; set; }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [TerraformPropertyName("hours")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<double>>>? Hours { get; set; }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [TerraformPropertyName("minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<double>>>? Minutes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<TerraformProperty<bool>>? Activated { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndTime { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Interval { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PipelineName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pipeline_name");

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_parameters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> PipelineParameters { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "pipeline_parameters");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeZone { get; set; }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("pipeline")]
    public TerraformList<TerraformBlock<AzurermDataFactoryTriggerSchedulePipelineBlock>>? Pipeline { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermDataFactoryTriggerScheduleScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryTriggerScheduleTimeoutsBlock>? Timeouts { get; set; } = new();

}
