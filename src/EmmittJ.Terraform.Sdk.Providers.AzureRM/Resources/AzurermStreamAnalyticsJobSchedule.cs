using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobScheduleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stream_analytics_job_schedule resource.
/// </summary>
public class AzurermStreamAnalyticsJobSchedule : TerraformResource
{
    public AzurermStreamAnalyticsJobSchedule(string name) : base("azurerm_stream_analytics_job_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("last_output_time");
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
    /// The start_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartMode is required")]
    public required TerraformProperty<string> StartMode
    {
        get => GetProperty<TerraformProperty<string>>("start_mode");
        set => this.WithProperty("start_mode", value);
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformProperty<string> StreamAnalyticsJobId
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsJobScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStreamAnalyticsJobScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    public TerraformExpression LastOutputTime => this["last_output_time"];

}
