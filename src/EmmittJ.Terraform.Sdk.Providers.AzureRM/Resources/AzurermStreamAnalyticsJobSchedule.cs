using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    public string? StartMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_mode")?.Value;
        set => this.WithProperty("start_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public string? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time")?.Value;
        set => this.WithProperty("start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public string? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id")?.Value;
        set => this.WithProperty("stream_analytics_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    public TerraformExpression LastOutputTime => this["last_output_time"];

}
