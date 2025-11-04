using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_function_javascript_uda resource.
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUda : TerraformResource
{
    public AzurermStreamAnalyticsFunctionJavascriptUda(string name) : base("azurerm_stream_analytics_function_javascript_uda", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    public string? Script
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script")?.Value;
        set => this.WithProperty("script", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public string? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id")?.Value;
        set => this.WithProperty("stream_analytics_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
