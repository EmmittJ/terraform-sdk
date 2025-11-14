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
/// Block type for pipeline in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for schedule in .
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
    [TerraformArgument("days_of_month")]
    public TerraformList<double>? DaysOfMonth
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "days_of_month").ResolveNodes(ctx));
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformArgument("days_of_week")]
    public TerraformList<string>? DaysOfWeek
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [TerraformArgument("hours")]
    public TerraformList<double>? Hours
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "hours").ResolveNodes(ctx));
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [TerraformArgument("minutes")]
    public TerraformList<double>? Minutes
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "minutes").ResolveNodes(ctx));
        set => SetArgument("minutes", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_data_factory_trigger_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryTriggerSchedule : TerraformResource
{
    public AzurermDataFactoryTriggerSchedule(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformArgument("activated")]
    public TerraformValue<bool>? Activated
    {
        get => new TerraformReference<bool>(this, "activated");
        set => SetArgument("activated", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformArgument("annotations")]
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
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
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformArgument("end_time")]
    public TerraformValue<string>? EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformArgument("frequency")]
    public TerraformValue<string>? Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
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
    /// The interval attribute.
    /// </summary>
    [TerraformArgument("interval")]
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
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
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformArgument("pipeline_name")]
    public TerraformValue<string> PipelineName
    {
        get => new TerraformReference<string>(this, "pipeline_name");
        set => SetArgument("pipeline_name", value);
    }

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    [TerraformArgument("pipeline_parameters")]
    public TerraformMap<string> PipelineParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "pipeline_parameters").ResolveNodes(ctx));
        set => SetArgument("pipeline_parameters", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("pipeline")]
    public TerraformList<AzurermDataFactoryTriggerSchedulePipelineBlock> Pipeline { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformArgument("schedule")]
    public TerraformList<AzurermDataFactoryTriggerScheduleScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryTriggerScheduleTimeoutsBlock Timeouts { get; set; } = new();

}
