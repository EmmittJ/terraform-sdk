using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppTriggerRecurrenceScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The at_these_hours attribute.
    /// </summary>
    [TerraformProperty("at_these_hours")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<double>? AtTheseHours { get; set; }

    /// <summary>
    /// The at_these_minutes attribute.
    /// </summary>
    [TerraformProperty("at_these_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<double>? AtTheseMinutes { get; set; }

    /// <summary>
    /// The on_these_days attribute.
    /// </summary>
    [TerraformProperty("on_these_days")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? OnTheseDays { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppTriggerRecurrenceTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_logic_app_trigger_recurrence resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLogicAppTriggerRecurrence : TerraformResource
{
    public AzurermLogicAppTriggerRecurrence(string name) : base("azurerm_logic_app_trigger_recurrence", name)
    {
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    [TerraformProperty("logic_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogicAppId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public TerraformList<TerraformBlock<AzurermLogicAppTriggerRecurrenceScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogicAppTriggerRecurrenceTimeoutsBlock>? Timeouts { get; set; }

}
