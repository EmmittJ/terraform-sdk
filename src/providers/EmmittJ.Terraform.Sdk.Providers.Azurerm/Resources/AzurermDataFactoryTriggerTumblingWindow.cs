using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for pipeline in AzurermDataFactoryTriggerTumblingWindow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowPipelineBlock : TerraformBlock
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
/// Block type for retry in AzurermDataFactoryTriggerTumblingWindow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowRetryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryTriggerTumblingWindow.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock : TerraformBlock
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
/// Block type for trigger_dependency in AzurermDataFactoryTriggerTumblingWindow.
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_dependency";

    /// <summary>
    /// The offset attribute.
    /// </summary>
    public TerraformValue<string>? Offset
    {
        get => GetArgument<TerraformValue<string>>("offset");
        set => SetArgument("offset", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<string>? Size
    {
        get => GetArgument<TerraformValue<string>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    public TerraformValue<string>? TriggerName
    {
        get => GetArgument<TerraformValue<string>>("trigger_name");
        set => SetArgument("trigger_name", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_trigger_tumbling_window Terraform resource.
/// Manages a azurerm_data_factory_trigger_tumbling_window resource.
/// </summary>
public partial class AzurermDataFactoryTriggerTumblingWindow(string name) : TerraformResource("azurerm_data_factory_trigger_tumbling_window", name)
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
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => GetArgument<TerraformMap<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
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
    /// The delay attribute.
    /// </summary>
    public TerraformValue<string>? Delay
    {
        get => GetArgument<TerraformValue<string>>("delay");
        set => SetArgument("delay", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrency
    {
        get => GetArgument<TerraformValue<double>>("max_concurrency");
        set => SetArgument("max_concurrency", value);
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
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// Pipeline block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pipeline is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pipeline block(s) allowed")]
    public required TerraformList<AzurermDataFactoryTriggerTumblingWindowPipelineBlock> Pipeline
    {
        get => GetRequiredArgument<TerraformList<AzurermDataFactoryTriggerTumblingWindowPipelineBlock>>("pipeline");
        set => SetArgument("pipeline", value);
    }

    /// <summary>
    /// Retry block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retry block(s) allowed")]
    public TerraformList<AzurermDataFactoryTriggerTumblingWindowRetryBlock>? Retry
    {
        get => GetArgument<TerraformList<AzurermDataFactoryTriggerTumblingWindowRetryBlock>>("retry");
        set => SetArgument("retry", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TriggerDependency block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock>? TriggerDependency
    {
        get => GetArgument<TerraformSet<AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock>>("trigger_dependency");
        set => SetArgument("trigger_dependency", value);
    }

}
