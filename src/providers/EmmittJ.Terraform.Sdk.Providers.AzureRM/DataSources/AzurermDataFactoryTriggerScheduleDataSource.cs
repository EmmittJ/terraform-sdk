using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_data_factory_trigger_schedule.
/// </summary>
public class AzurermDataFactoryTriggerScheduleDataSource : TerraformDataSource
{
    public AzurermDataFactoryTriggerScheduleDataSource(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("activated");
        this.WithOutput("annotations");
        this.WithOutput("description");
        this.WithOutput("end_time");
        this.WithOutput("frequency");
        this.WithOutput("interval");
        this.WithOutput("pipeline_name");
        this.WithOutput("schedule");
        this.WithOutput("start_time");
        this.WithOutput("time_zone");
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformExpression Activated => this["activated"];

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformExpression Annotations => this["annotations"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformExpression EndTime => this["end_time"];

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformExpression Frequency => this["frequency"];

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformExpression Interval => this["interval"];

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformExpression PipelineName => this["pipeline_name"];

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformExpression Schedule => this["schedule"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformExpression TimeZone => this["time_zone"];

}
