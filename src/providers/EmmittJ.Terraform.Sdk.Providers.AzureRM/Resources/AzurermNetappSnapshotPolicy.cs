using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for daily_schedule in .
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
    [TerraformArgument("hour")]
    public required TerraformValue<double> Hour
    {
        get => new TerraformReference<double>(this, "hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformArgument("minute")]
    public required TerraformValue<double> Minute
    {
        get => new TerraformReference<double>(this, "minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformArgument("snapshots_to_keep")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => new TerraformReference<double>(this, "snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}

/// <summary>
/// Block type for hourly_schedule in .
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
    [TerraformArgument("minute")]
    public required TerraformValue<double> Minute
    {
        get => new TerraformReference<double>(this, "minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformArgument("snapshots_to_keep")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => new TerraformReference<double>(this, "snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}

/// <summary>
/// Block type for monthly_schedule in .
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
    [TerraformArgument("days_of_month")]
    public required TerraformSet<double> DaysOfMonth
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "days_of_month").ResolveNodes(ctx));
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    [TerraformArgument("hour")]
    public required TerraformValue<double> Hour
    {
        get => new TerraformReference<double>(this, "hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformArgument("minute")]
    public required TerraformValue<double> Minute
    {
        get => new TerraformReference<double>(this, "minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformArgument("snapshots_to_keep")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => new TerraformReference<double>(this, "snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for weekly_schedule in .
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
    [TerraformArgument("days_of_week")]
    public required TerraformSet<string> DaysOfWeek
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hour is required")]
    [TerraformArgument("hour")]
    public required TerraformValue<double> Hour
    {
        get => new TerraformReference<double>(this, "hour");
        set => SetArgument("hour", value);
    }

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformArgument("minute")]
    public required TerraformValue<double> Minute
    {
        get => new TerraformReference<double>(this, "minute");
        set => SetArgument("minute", value);
    }

    /// <summary>
    /// The snapshots_to_keep attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsToKeep is required")]
    [TerraformArgument("snapshots_to_keep")]
    public required TerraformValue<double> SnapshotsToKeep
    {
        get => new TerraformReference<double>(this, "snapshots_to_keep");
        set => SetArgument("snapshots_to_keep", value);
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
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for daily_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailySchedule block(s) allowed")]
    [TerraformArgument("daily_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyDailyScheduleBlock> DailySchedule { get; set; } = new();

    /// <summary>
    /// Block for hourly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlySchedule block(s) allowed")]
    [TerraformArgument("hourly_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyHourlyScheduleBlock> HourlySchedule { get; set; } = new();

    /// <summary>
    /// Block for monthly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlySchedule block(s) allowed")]
    [TerraformArgument("monthly_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyMonthlyScheduleBlock> MonthlySchedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetappSnapshotPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for weekly_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    [TerraformArgument("weekly_schedule")]
    public TerraformList<AzurermNetappSnapshotPolicyWeeklyScheduleBlock> WeeklySchedule { get; set; } = new();

}
