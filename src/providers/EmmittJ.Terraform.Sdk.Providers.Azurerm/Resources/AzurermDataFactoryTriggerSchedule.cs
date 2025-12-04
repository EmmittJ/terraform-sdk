using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for pipeline in AzurermDataFactoryTriggerSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerSchedulePipelineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

}


/// <summary>
/// Block type for schedule in AzurermDataFactoryTriggerSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerScheduleScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    public TerraformList<double>? DaysOfMonth
    {
        get => GetArgument<TerraformList<double>>("days_of_month");
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformList<string>? DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    public TerraformList<double>? Hours
    {
        get => GetArgument<TerraformList<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public TerraformList<double>? Minutes
    {
        get => GetArgument<TerraformList<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Monthly block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryTriggerScheduleScheduleBlockMonthlyBlock>? Monthly
    {
        get => GetArgument<TerraformList<AzurermDataFactoryTriggerScheduleScheduleBlockMonthlyBlock>>("monthly");
        set => SetArgument("monthly", value);
    }

}

/// <summary>
/// Block type for monthly in AzurermDataFactoryTriggerScheduleScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerScheduleScheduleBlockMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly";

    /// <summary>
    /// The week attribute.
    /// </summary>
    public TerraformValue<double>? Week
    {
        get => GetArgument<TerraformValue<double>>("week");
        set => SetArgument("week", value);
    }

    /// <summary>
    /// The weekday attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekday is required")]
    public required TerraformValue<string> Weekday
    {
        get => GetArgument<TerraformValue<string>>("weekday");
        set => SetArgument("weekday", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryTriggerSchedule.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_factory_trigger_schedule Terraform resource.
/// Manages a azurerm_data_factory_trigger_schedule resource.
/// </summary>
public partial class AzurermDataFactoryTriggerSchedule(string name) : TerraformResource("azurerm_data_factory_trigger_schedule", name)
{
    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformValue<bool>? Activated
    {
        get => GetArgument<TerraformValue<bool>>("activated");
        set => SetArgument("activated", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
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
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformValue<string>? PipelineName
    {
        get => GetArgument<TerraformValue<string>>("pipeline_name");
        set => SetArgument("pipeline_name", value);
    }

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    public TerraformMap<string>? PipelineParameters
    {
        get => GetArgument<TerraformMap<string>>("pipeline_parameters");
        set => SetArgument("pipeline_parameters", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// Pipeline block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryTriggerSchedulePipelineBlock>? Pipeline
    {
        get => GetArgument<TerraformList<AzurermDataFactoryTriggerSchedulePipelineBlock>>("pipeline");
        set => SetArgument("pipeline", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AzurermDataFactoryTriggerScheduleScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermDataFactoryTriggerScheduleScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryTriggerScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryTriggerScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
