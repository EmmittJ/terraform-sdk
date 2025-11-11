using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The start_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDay is required")]
    [TerraformProperty("start_day")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StartDay { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformProperty("start_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The stop_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopDay is required")]
    [TerraformProperty("stop_day")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StopDay { get; set; }

    /// <summary>
    /// The stop_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopTime is required")]
    [TerraformProperty("stop_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StopTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance_start_stop_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlManagedInstanceStartStopSchedule : TerraformResource
{
    public AzurermMssqlManagedInstanceStartStopSchedule(string name) : base("azurerm_mssql_managed_instance_start_stop_schedule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformProperty("managed_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformProperty("timezone_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TimezoneId { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [TerraformProperty("schedule")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The next_execution_time attribute.
    /// </summary>
    [TerraformProperty("next_execution_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NextExecutionTime { get; }

    /// <summary>
    /// The next_run_action attribute.
    /// </summary>
    [TerraformProperty("next_run_action")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NextRunAction { get; }

}
