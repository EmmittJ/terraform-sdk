using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_factory_trigger_schedule.
/// </summary>
public partial class AzurermDataFactoryTriggerScheduleDataSource : TerraformDataSource
{
    public AzurermDataFactoryTriggerScheduleDataSource(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformProperty("activated")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Activated { get; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Annotations { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformProperty("end_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndTime { get; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformProperty("frequency")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Frequency { get; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Interval { get; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformProperty("pipeline_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PipelineName { get; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformProperty("schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Schedule { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartTime { get; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeZone { get; }

}
