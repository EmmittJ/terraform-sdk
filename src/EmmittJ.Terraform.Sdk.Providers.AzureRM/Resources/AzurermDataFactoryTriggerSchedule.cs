using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_trigger_schedule resource.
/// </summary>
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
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
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
    public TerraformProperty<string>? Name
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
    public TerraformMapProperty<string>? PipelineParameters
    {
        get => GetProperty<TerraformMapProperty<string>>("pipeline_parameters");
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

}
