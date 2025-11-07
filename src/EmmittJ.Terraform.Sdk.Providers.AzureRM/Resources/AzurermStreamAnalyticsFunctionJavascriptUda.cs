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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The script attribute.
    /// </summary>
    public TerraformProperty<string>? Script
    {
        get => GetProperty<TerraformProperty<string>>("script");
        set => this.WithProperty("script", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
    }

}
