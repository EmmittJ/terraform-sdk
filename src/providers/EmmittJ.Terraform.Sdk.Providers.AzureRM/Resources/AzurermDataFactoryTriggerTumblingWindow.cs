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
/// Block type for retry in .
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformArgument("count")]
    public required TerraformValue<double> Count
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
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

}

/// <summary>
/// Block type for timeouts in .
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
/// Block type for trigger_dependency in .
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
    [TerraformArgument("offset")]
    public TerraformValue<string>? Offset
    {
        get => new TerraformReference<string>(this, "offset");
        set => SetArgument("offset", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformArgument("size")]
    public TerraformValue<string>? Size
    {
        get => new TerraformReference<string>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [TerraformArgument("trigger_name")]
    public TerraformValue<string>? TriggerName
    {
        get => new TerraformReference<string>(this, "trigger_name");
        set => SetArgument("trigger_name", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory_trigger_tumbling_window resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryTriggerTumblingWindow : TerraformResource
{
    public AzurermDataFactoryTriggerTumblingWindow(string name) : base("azurerm_data_factory_trigger_tumbling_window", name)
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
    /// The additional_properties attribute.
    /// </summary>
    [TerraformArgument("additional_properties")]
    public TerraformMap<string>? AdditionalProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_properties").ResolveNodes(ctx));
        set => SetArgument("additional_properties", value);
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
    /// The delay attribute.
    /// </summary>
    [TerraformArgument("delay")]
    public TerraformValue<string>? Delay
    {
        get => new TerraformReference<string>(this, "delay");
        set => SetArgument("delay", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<string> Frequency
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformArgument("interval")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformArgument("max_concurrency")]
    public TerraformValue<double>? MaxConcurrency
    {
        get => new TerraformReference<double>(this, "max_concurrency");
        set => SetArgument("max_concurrency", value);
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
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pipeline is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pipeline block(s) allowed")]
    [TerraformArgument("pipeline")]
    public required TerraformList<AzurermDataFactoryTriggerTumblingWindowPipelineBlock> Pipeline { get; set; } = new();

    /// <summary>
    /// Block for retry.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retry block(s) allowed")]
    [TerraformArgument("retry")]
    public TerraformList<AzurermDataFactoryTriggerTumblingWindowRetryBlock> Retry { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trigger_dependency.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("trigger_dependency")]
    public TerraformSet<AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock> TriggerDependency { get; set; } = new();

}
