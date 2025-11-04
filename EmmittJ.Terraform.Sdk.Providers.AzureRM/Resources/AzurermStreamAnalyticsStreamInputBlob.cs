using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_stream_input_blob resource.
/// </summary>
public class AzurermStreamAnalyticsStreamInputBlob : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputBlob(string name) : base("azurerm_stream_analytics_stream_input_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public string? AuthenticationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_mode")?.Value;
        set => this.WithProperty("authentication_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The date_format attribute.
    /// </summary>
    public string? DateFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_format")?.Value;
        set => this.WithProperty("date_format", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The path_pattern attribute.
    /// </summary>
    public string? PathPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_pattern")?.Value;
        set => this.WithProperty("path_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_account_key attribute.
    /// </summary>
    public string? StorageAccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_key")?.Value;
        set => this.WithProperty("storage_account_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public string? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name")?.Value;
        set => this.WithProperty("storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public string? StorageContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_name")?.Value;
        set => this.WithProperty("storage_container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public string? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name")?.Value;
        set => this.WithProperty("stream_analytics_job_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_format attribute.
    /// </summary>
    public string? TimeFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_format")?.Value;
        set => this.WithProperty("time_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
