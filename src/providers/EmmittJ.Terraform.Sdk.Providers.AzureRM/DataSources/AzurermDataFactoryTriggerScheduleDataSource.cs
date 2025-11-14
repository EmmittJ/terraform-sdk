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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_data_factory_trigger_schedule.
/// </summary>
public class AzurermDataFactoryTriggerScheduleDataSource : TerraformDataSource
{
    public AzurermDataFactoryTriggerScheduleDataSource(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformArgument("data_factory_id")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformArgument("activated")]
    public TerraformValue<bool> Activated
    {
        get => new TerraformReference<bool>(this, "activated");
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformArgument("annotations")]
    public TerraformList<string> Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformArgument("end_time")]
    public TerraformValue<string> EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformArgument("frequency")]
    public TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformArgument("interval")]
    public TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformArgument("pipeline_name")]
    public TerraformValue<string> PipelineName
    {
        get => new TerraformReference<string>(this, "pipeline_name");
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformArgument("schedule")]
    public TerraformList<object> Schedule
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
    }

}
