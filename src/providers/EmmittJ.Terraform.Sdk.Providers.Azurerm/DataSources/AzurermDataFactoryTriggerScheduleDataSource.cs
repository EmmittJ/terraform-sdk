using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataFactoryTriggerScheduleDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_trigger_schedule Terraform data source.
/// Retrieves information about a azurerm_data_factory_trigger_schedule.
/// </summary>
public partial class AzurermDataFactoryTriggerScheduleDataSource(string name) : TerraformDataSource("azurerm_data_factory_trigger_schedule", name)
{
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The activated attribute.
    /// </summary>
    public TerraformValue<bool> Activated
        => AsReference("activated");

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string> Annotations
        => AsReference("annotations");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string> EndTime
        => AsReference("end_time");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string> Frequency
        => AsReference("frequency");

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double> Interval
        => AsReference("interval");

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformValue<string> PipelineName
        => AsReference("pipeline_name");

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Schedule
        => AsReference("schedule");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
        => AsReference("start_time");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
        => AsReference("time_zone");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
