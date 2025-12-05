using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for daily_schedule in AzurermNetappSnapshotPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyDailyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_schedule";

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    public required TerraformValue<double> Hour
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformValue<double> Minute
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => GetRequiredArgument<TerraformValue<double>>("snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}


/// <summary>
/// Block type for hourly_schedule in AzurermNetappSnapshotPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyHourlyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hourly_schedule";

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformValue<double> Minute
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => GetRequiredArgument<TerraformValue<double>>("snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}


/// <summary>
/// Block type for monthly_schedule in AzurermNetappSnapshotPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyMonthlyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly_schedule";

    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfMonth is required")]
    public required TerraformSet<double> DaysOfMonth
    {
        get => GetRequiredArgument<TerraformSet<double>>("days_of_month");
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    public required TerraformValue<double> Hour
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformValue<double> Minute
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => GetRequiredArgument<TerraformValue<double>>("snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetappSnapshotPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermNetappSnapshotPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for weekly_schedule in AzurermNetappSnapshotPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermNetappSnapshotPolicyWeeklyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_schedule";

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    public required TerraformSet<string> DaysOfWeek
    {
        get => GetRequiredArgument<TerraformSet<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    public required TerraformValue<double> Hour
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformValue<double> Minute
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => GetRequiredArgument<TerraformValue<double>>("snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_snapshot_policy Terraform resource.
/// Manages a azurerm_netapp_snapshot_policy resource.
/// </summary>
public partial class AzurermNetappSnapshotPolicy(string name) : TerraformResource("azurerm_netapp_snapshot_policy", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// DailySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailySchedule block(s) allowed")]
    public TerraformList<AzurermNetappSnapshotPolicyDailyScheduleBlock>? DailySchedule
    {
        get => GetArgument<TerraformList<AzurermNetappSnapshotPolicyDailyScheduleBlock>>("daily_schedule");
        set => SetArgument("daily_schedule", value);
    }

    /// <summary>
    /// HourlySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlySchedule block(s) allowed")]
    public TerraformList<AzurermNetappSnapshotPolicyHourlyScheduleBlock>? HourlySchedule
    {
        get => GetArgument<TerraformList<AzurermNetappSnapshotPolicyHourlyScheduleBlock>>("hourly_schedule");
        set => SetArgument("hourly_schedule", value);
    }

    /// <summary>
    /// MonthlySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlySchedule block(s) allowed")]
    public TerraformList<AzurermNetappSnapshotPolicyMonthlyScheduleBlock>? MonthlySchedule
    {
        get => GetArgument<TerraformList<AzurermNetappSnapshotPolicyMonthlyScheduleBlock>>("monthly_schedule");
        set => SetArgument("monthly_schedule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappSnapshotPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappSnapshotPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WeeklySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    public TerraformList<AzurermNetappSnapshotPolicyWeeklyScheduleBlock>? WeeklySchedule
    {
        get => GetArgument<TerraformList<AzurermNetappSnapshotPolicyWeeklyScheduleBlock>>("weekly_schedule");
        set => SetArgument("weekly_schedule", value);
    }

}
