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
        SetOutput("last_output_time");
        SetOutput("id");
        SetOutput("start_mode");
        SetOutput("start_time");
        SetOutput("stream_analytics_job_id");
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
    /// The start_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartMode is required")]
    public required TerraformProperty<string> StartMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_mode");
        set => SetProperty("start_mode", value);
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformProperty<string> StreamAnalyticsJobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_id");
        set => SetProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsJobScheduleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    public TerraformExpression LastOutputTime => this["last_output_time"];

}
