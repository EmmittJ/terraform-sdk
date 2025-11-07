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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_mode");
        set => this.WithProperty("start_mode", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    public TerraformExpression LastOutputTime => this["last_output_time"];

}
