using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for daily_schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappSnapshotPolicyDailyScheduleBlock() : TerraformBlock("daily_schedule")
{
    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    [TerraformProperty("hour")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Hour { get; set; }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformProperty("minute")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Minute { get; set; }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformProperty("snapshots_to_keep")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SnapshotsToKeep { get; set; }

}

/// <summary>
/// Block type for hourly_schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappSnapshotPolicyHourlyScheduleBlock() : TerraformBlock("hourly_schedule")
{
    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformProperty("minute")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Minute { get; set; }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformProperty("snapshots_to_keep")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SnapshotsToKeep { get; set; }

}

/// <summary>
/// Block type for monthly_schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappSnapshotPolicyMonthlyScheduleBlock() : TerraformBlock("monthly_schedule")
{
    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfMonth is required")]
    [TerraformProperty("days_of_month")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<double> DaysOfMonth { get; set; }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    [TerraformProperty("hour")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Hour { get; set; }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformProperty("minute")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Minute { get; set; }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformProperty("snapshots_to_keep")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SnapshotsToKeep { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappSnapshotPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for weekly_schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappSnapshotPolicyWeeklyScheduleBlock() : TerraformBlock("weekly_schedule")
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    [TerraformProperty("days_of_week")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DaysOfWeek { get; set; }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    [TerraformProperty("hour")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Hour { get; set; }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformProperty("minute")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Minute { get; set; }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformProperty("snapshots_to_keep")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SnapshotsToKeep { get; set; }

}

/// <summary>
/// Manages a azurerm_netapp_snapshot_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetappSnapshotPolicy : TerraformResource
{
    public AzurermNetappSnapshotPolicy(string name) : base("azurerm_netapp_snapshot_policy", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for daily_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailySchedule block(s) allowed")]
    [TerraformProperty("daily_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyDailyScheduleBlock> DailySchedule { get; set; } = new();

    /// <summary>
    /// Block for hourly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlySchedule block(s) allowed")]
    [TerraformProperty("hourly_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyHourlyScheduleBlock> HourlySchedule { get; set; } = new();

    /// <summary>
    /// Block for monthly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlySchedule block(s) allowed")]
    [TerraformProperty("monthly_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyMonthlyScheduleBlock> MonthlySchedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetappSnapshotPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for weekly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    [TerraformProperty("weekly_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyWeeklyScheduleBlock> WeeklySchedule { get; set; } = new();

}
