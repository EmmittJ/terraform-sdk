using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowPipelineBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

}

/// <summary>
/// Block type for retry in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowRetryBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        set => SetProperty("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        set => SetProperty("interval", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for trigger_dependency in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock : TerraformBlock
{
    /// <summary>
    /// The offset attribute.
    /// </summary>
    public TerraformProperty<string>? Offset
    {
        set => SetProperty("offset", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string>? Size
    {
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerName
    {
        set => SetProperty("trigger_name", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("activated");
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("data_factory_id");
        SetOutput("delay");
        SetOutput("description");
        SetOutput("end_time");
        SetOutput("frequency");
        SetOutput("id");
        SetOutput("interval");
        SetOutput("max_concurrency");
        SetOutput("name");
        SetOutput("start_time");
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformProperty<bool> Activated
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("activated");
        set => SetProperty("activated", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    public TerraformProperty<string> Delay
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delay");
        set => SetProperty("delay", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string> EndTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_time");
        set => SetProperty("end_time", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frequency");
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("interval");
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformProperty<double> MaxConcurrency
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_concurrency");
        set => SetProperty("max_concurrency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pipeline is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pipeline block(s) allowed")]
    public List<AzurermDataFactoryTriggerTumblingWindowPipelineBlock>? Pipeline
    {
        set => SetProperty("pipeline", value);
    }

    /// <summary>
    /// Block for retry.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retry block(s) allowed")]
    public List<AzurermDataFactoryTriggerTumblingWindowRetryBlock>? Retry
    {
        set => SetProperty("retry", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trigger_dependency.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock>? TriggerDependency
    {
        set => SetProperty("trigger_dependency", value);
    }

}
