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
    public TerraformProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// The batch_max_wait_time attribute.
    /// </summary>
    public TerraformProperty<string>? BatchMaxWaitTime
    {
        get => GetProperty<TerraformProperty<string>>("batch_max_wait_time");
        set => this.WithProperty("batch_max_wait_time", value);
    }

    /// <summary>
    /// The batch_min_rows attribute.
    /// </summary>
    public TerraformProperty<double>? BatchMinRows
    {
        get => GetProperty<TerraformProperty<double>>("batch_min_rows");
        set => this.WithProperty("batch_min_rows", value);
    }

    /// <summary>
    /// The blob_write_mode attribute.
    /// </summary>
    public TerraformProperty<string>? BlobWriteMode
    {
        get => GetProperty<TerraformProperty<string>>("blob_write_mode");
        set => this.WithProperty("blob_write_mode", value);
    }

    /// <summary>
    /// The date_format attribute.
    /// </summary>
    public TerraformProperty<string>? DateFormat
    {
        get => GetProperty<TerraformProperty<string>>("date_format");
        set => this.WithProperty("date_format", value);
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
    /// The path_pattern attribute.
    /// </summary>
    public TerraformProperty<string>? PathPattern
    {
        get => GetProperty<TerraformProperty<string>>("path_pattern");
        set => this.WithProperty("path_pattern", value);
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
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_key");
        set => this.WithProperty("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageContainerName
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_name");
        set => this.WithProperty("storage_container_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The time_format attribute.
    /// </summary>
    public TerraformProperty<string>? TimeFormat
    {
        get => GetProperty<TerraformProperty<string>>("time_format");
        set => this.WithProperty("time_format", value);
    }

}
