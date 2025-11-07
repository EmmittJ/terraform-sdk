using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_function_javascript_udf resource.
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdf : TerraformResource
{
    public AzurermStreamAnalyticsFunctionJavascriptUdf(string name) : base("azurerm_stream_analytics_function_javascript_udf", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

}
