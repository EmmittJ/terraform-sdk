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
    public string? ApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key")?.Value;
        set => this.WithProperty("api_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The batch_max_count attribute.
    /// </summary>
    public double? BatchMaxCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_max_count")?.Value;
        set => this.WithProperty("batch_max_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The batch_max_in_bytes attribute.
    /// </summary>
    public double? BatchMaxInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_max_in_bytes")?.Value;
        set => this.WithProperty("batch_max_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The function_app attribute.
    /// </summary>
    public string? FunctionApp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app")?.Value;
        set => this.WithProperty("function_app", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public string? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name")?.Value;
        set => this.WithProperty("stream_analytics_job_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
