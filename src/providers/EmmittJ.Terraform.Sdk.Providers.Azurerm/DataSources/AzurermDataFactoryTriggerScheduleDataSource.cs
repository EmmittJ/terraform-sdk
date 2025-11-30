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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformValue<bool> Activated
    {
        get => new TerraformReference<bool>(this, "activated");
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string> Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string> EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformValue<string> PipelineName
    {
        get => new TerraformReference<string>(this, "pipeline_name");
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Schedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
