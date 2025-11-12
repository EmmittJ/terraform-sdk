using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for monthly_occurrence in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationScheduleMonthlyOccurrenceBlock() : TerraformBlock("monthly_occurrence")
{
    /// <summary>
    /// The day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    [TerraformProperty("day")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Day { get; set; }

    /// <summary>
    /// The occurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Occurrence is required")]
    [TerraformProperty("occurrence")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Occurrence { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationScheduleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_automation_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAutomationSchedule : TerraformResource
{
    public AzurermAutomationSchedule(string name) : base("azurerm_automation_schedule", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformProperty("automation_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutomationAccountName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    [TerraformProperty("expiry_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExpiryTime { get; set; }

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
    [TerraformProperty("interval")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The month_days attribute.
    /// </summary>
    [TerraformProperty("month_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? MonthDays { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    [TerraformProperty("week_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? WeekDays { get; set; }

    /// <summary>
    /// Block for monthly_occurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlyOccurrence block(s) allowed")]
    [TerraformProperty("monthly_occurrence")]
    public TerraformList<AzurermAutomationScheduleMonthlyOccurrenceBlock> MonthlyOccurrence { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAutomationScheduleTimeoutsBlock Timeouts { get; set; } = new();

}
