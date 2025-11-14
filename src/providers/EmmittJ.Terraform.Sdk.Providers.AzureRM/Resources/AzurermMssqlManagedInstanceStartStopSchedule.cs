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
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The start_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDay is required")]
    [TerraformArgument("start_day")]
    public required TerraformValue<string> StartDay
    {
        get => new TerraformReference<string>(this, "start_day");
        set => SetArgument("start_day", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformArgument("start_time")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The stop_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopDay is required")]
    [TerraformArgument("stop_day")]
    public required TerraformValue<string> StopDay
    {
        get => new TerraformReference<string>(this, "stop_day");
        set => SetArgument("stop_day", value);
    }

    /// <summary>
    /// The stop_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopTime is required")]
    [TerraformArgument("stop_time")]
    public required TerraformValue<string> StopTime
    {
        get => new TerraformReference<string>(this, "stop_time");
        set => SetArgument("stop_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_managed_instance_start_stop_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedInstanceStartStopSchedule : TerraformResource
{
    public AzurermMssqlManagedInstanceStartStopSchedule(string name) : base("azurerm_mssql_managed_instance_start_stop_schedule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformArgument("managed_instance_id")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformArgument("timezone_id")]
    public TerraformValue<string>? TimezoneId
    {
        get => new TerraformReference<string>(this, "timezone_id");
        set => SetArgument("timezone_id", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [TerraformArgument("schedule")]
    public required TerraformList<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The next_execution_time attribute.
    /// </summary>
    [TerraformArgument("next_execution_time")]
    public TerraformValue<string> NextExecutionTime
    {
        get => new TerraformReference<string>(this, "next_execution_time");
    }

    /// <summary>
    /// The next_run_action attribute.
    /// </summary>
    [TerraformArgument("next_run_action")]
    public TerraformValue<string> NextRunAction
    {
        get => new TerraformReference<string>(this, "next_run_action");
    }

}
