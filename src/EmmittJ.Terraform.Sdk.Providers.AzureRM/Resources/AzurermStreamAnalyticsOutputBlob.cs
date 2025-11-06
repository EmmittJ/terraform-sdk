using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_blob resource.
/// </summary>
public class AzurermStreamAnalyticsOutputBlob : TerraformResource
{
    public AzurermStreamAnalyticsOutputBlob(string name) : base("azurerm_stream_analytics_output_blob", name)
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
    /// The batch_max_wait_time attribute.
    /// </summary>
    public string? BatchMaxWaitTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("batch_max_wait_time")?.Value;
        set => this.WithProperty("batch_max_wait_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The batch_min_rows attribute.
    /// </summary>
    public double? BatchMinRows
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_min_rows")?.Value;
        set => this.WithProperty("batch_min_rows", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The blob_write_mode attribute.
    /// </summary>
    public string? BlobWriteMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_write_mode")?.Value;
        set => this.WithProperty("blob_write_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
