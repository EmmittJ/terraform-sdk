using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_function resource.
/// </summary>
public class AzurermStreamAnalyticsOutputFunction : TerraformResource
{
    public AzurermStreamAnalyticsOutputFunction(string name) : base("azurerm_stream_analytics_output_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key");
        set => this.WithProperty("api_key", value);
    }

    /// <summary>
    /// The batch_max_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BatchMaxCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_max_count");
        set => this.WithProperty("batch_max_count", value);
    }

    /// <summary>
    /// The batch_max_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BatchMaxInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_max_in_bytes");
        set => this.WithProperty("batch_max_in_bytes", value);
    }

    /// <summary>
    /// The function_app attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionApp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app");
        set => this.WithProperty("function_app", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

}
