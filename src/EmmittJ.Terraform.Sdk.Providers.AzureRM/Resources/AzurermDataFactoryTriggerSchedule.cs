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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
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
        get => GetProperty<List<TerraformProperty<double>>>("days_of_month");
        set => WithProperty("days_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DaysOfWeek
    {
        get => GetProperty<List<TerraformProperty<string>>>("days_of_week");
        set => WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    public List<TerraformProperty<double>>? Hours
    {
        get => GetProperty<List<TerraformProperty<double>>>("hours");
        set => WithProperty("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public List<TerraformProperty<double>>? Minutes
    {
        get => GetProperty<List<TerraformProperty<double>>>("minutes");
        set => WithProperty("minutes", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformProperty<bool>? Activated
    {
        get => GetProperty<TerraformProperty<bool>>("activated");
        set => this.WithProperty("activated", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<string>? Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => this.WithProperty("frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => this.WithProperty("interval", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineName
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_name");
        set => this.WithProperty("pipeline_name", value);
    }

    /// <summary>
    /// The pipeline_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? PipelineParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("pipeline_parameters");
        set => this.WithProperty("pipeline_parameters", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryTriggerSchedulePipelineBlock>? Pipeline
    {
        get => GetProperty<List<AzurermDataFactoryTriggerSchedulePipelineBlock>>("pipeline");
        set => this.WithProperty("pipeline", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermDataFactoryTriggerScheduleScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermDataFactoryTriggerScheduleScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTriggerScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryTriggerScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
