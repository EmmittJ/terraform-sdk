using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for schedule in AzurermMssqlManagedInstanceStartStopSchedule.
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
    public required TerraformValue<string> StartDay
    {
        get => GetArgument<TerraformValue<string>>("start_day");
        set => SetArgument("start_day", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The stop_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopDay is required")]
    public required TerraformValue<string> StopDay
    {
        get => GetArgument<TerraformValue<string>>("stop_day");
        set => SetArgument("stop_day", value);
    }

    /// <summary>
    /// The stop_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopTime is required")]
    public required TerraformValue<string> StopTime
    {
        get => GetArgument<TerraformValue<string>>("stop_time");
        set => SetArgument("stop_time", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlManagedInstanceStartStopSchedule.
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
/// Represents a azurerm_mssql_managed_instance_start_stop_schedule Terraform resource.
/// Manages a azurerm_mssql_managed_instance_start_stop_schedule resource.
/// </summary>
public partial class AzurermMssqlManagedInstanceStartStopSchedule(string name) : TerraformResource("azurerm_mssql_managed_instance_start_stop_schedule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => GetArgument<TerraformValue<string>>("managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformValue<string>? TimezoneId
    {
        get => GetArgument<TerraformValue<string>>("timezone_id");
        set => SetArgument("timezone_id", value);
    }

    /// <summary>
    /// The next_execution_time attribute.
    /// </summary>
    public TerraformValue<string> NextExecutionTime
        => AsReference("next_execution_time");

    /// <summary>
    /// The next_run_action attribute.
    /// </summary>
    public TerraformValue<string> NextRunAction
        => AsReference("next_run_action");

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    public required TerraformList<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
