using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for daily_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyDailyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    public required TerraformProperty<double> Hour
    {
        get => GetProperty<TerraformProperty<double>>("hour");
        set => WithProperty("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformProperty<double> Minute
    {
        get => GetProperty<TerraformProperty<double>>("minute");
        set => WithProperty("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformProperty<double> SnapshotsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("snapshots_to_keep");
        set => WithProperty("snapshots_to_keep", value);
    }

}

/// <summary>
/// Block type for hourly_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyHourlyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformProperty<double> Minute
    {
        get => GetProperty<TerraformProperty<double>>("minute");
        set => WithProperty("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformProperty<double> SnapshotsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("snapshots_to_keep");
        set => WithProperty("snapshots_to_keep", value);
    }

}

/// <summary>
/// Block type for monthly_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyMonthlyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfMonth is required")]
    public HashSet<TerraformProperty<double>>? DaysOfMonth
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("days_of_month");
        set => WithProperty("days_of_month", value);
    }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    public required TerraformProperty<double> Hour
    {
        get => GetProperty<TerraformProperty<double>>("hour");
        set => WithProperty("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformProperty<double> Minute
    {
        get => GetProperty<TerraformProperty<double>>("minute");
        set => WithProperty("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformProperty<double> SnapshotsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("snapshots_to_keep");
        set => WithProperty("snapshots_to_keep", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappSnapshotPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for weekly_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyWeeklyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    public HashSet<TerraformProperty<string>>? DaysOfWeek
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("days_of_week");
        set => WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    public required TerraformProperty<double> Hour
    {
        get => GetProperty<TerraformProperty<double>>("hour");
        set => WithProperty("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformProperty<double> Minute
    {
        get => GetProperty<TerraformProperty<double>>("minute");
        set => WithProperty("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformProperty<double> SnapshotsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("snapshots_to_keep");
        set => WithProperty("snapshots_to_keep", value);
    }

}

/// <summary>
/// Manages a azurerm_netapp_snapshot_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetappSnapshotPolicy : TerraformResource
{
    public AzurermNetappSnapshotPolicy(string name) : base("azurerm_netapp_snapshot_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for daily_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailySchedule block(s) allowed")]
    public List<AzurermNetappSnapshotPolicyDailyScheduleBlock>? DailySchedule
    {
        get => GetProperty<List<AzurermNetappSnapshotPolicyDailyScheduleBlock>>("daily_schedule");
        set => this.WithProperty("daily_schedule", value);
    }

    /// <summary>
    /// Block for hourly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlySchedule block(s) allowed")]
    public List<AzurermNetappSnapshotPolicyHourlyScheduleBlock>? HourlySchedule
    {
        get => GetProperty<List<AzurermNetappSnapshotPolicyHourlyScheduleBlock>>("hourly_schedule");
        set => this.WithProperty("hourly_schedule", value);
    }

    /// <summary>
    /// Block for monthly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlySchedule block(s) allowed")]
    public List<AzurermNetappSnapshotPolicyMonthlyScheduleBlock>? MonthlySchedule
    {
        get => GetProperty<List<AzurermNetappSnapshotPolicyMonthlyScheduleBlock>>("monthly_schedule");
        set => this.WithProperty("monthly_schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappSnapshotPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappSnapshotPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for weekly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    public List<AzurermNetappSnapshotPolicyWeeklyScheduleBlock>? WeeklySchedule
    {
        get => GetProperty<List<AzurermNetappSnapshotPolicyWeeklyScheduleBlock>>("weekly_schedule");
        set => this.WithProperty("weekly_schedule", value);
    }

}
