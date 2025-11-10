using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerSchedulePipelineBlock : TerraformBlock
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
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerScheduleScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    public List<TerraformProperty<double>>? DaysOfMonth
    {
        set => SetProperty("days_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DaysOfWeek
    {
        set => SetProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    public List<TerraformProperty<double>>? Hours
    {
        set => SetProperty("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public List<TerraformProperty<double>>? Minutes
    {
        set => SetProperty("minutes", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_trigger_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryTriggerSchedule : TerraformResource
{
    public AzurermDataFactoryTriggerSchedule(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("activated");
        SetOutput("annotations");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("end_time");
        SetOutput("frequency");
        SetOutput("id");
        SetOutput("interval");
        SetOutput("name");
        SetOutput("pipeline_name");
        SetOutput("pipeline_parameters");
        SetOutput("start_time");
        SetOutput("time_zone");
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
    public TerraformProperty<string> Frequency
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
    public TerraformProperty<double> Interval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("interval");
        set => SetProperty("interval", value);
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
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformProperty<string> PipelineName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_name");
        set => SetProperty("pipeline_name", value);
    }

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> PipelineParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("pipeline_parameters");
        set => SetProperty("pipeline_parameters", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryTriggerSchedulePipelineBlock>? Pipeline
    {
        set => SetProperty("pipeline", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermDataFactoryTriggerScheduleScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTriggerScheduleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
