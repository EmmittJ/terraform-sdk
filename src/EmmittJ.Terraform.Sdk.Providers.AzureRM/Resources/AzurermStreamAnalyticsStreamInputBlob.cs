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
    public TerraformLiteralProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// The date_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DateFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_format");
        set => this.WithProperty("date_format", value);
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
    /// The path_pattern attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PathPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_pattern");
        set => this.WithProperty("path_pattern", value);
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
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_key");
        set => this.WithProperty("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_name");
        set => this.WithProperty("storage_container_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The time_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimeFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_format");
        set => this.WithProperty("time_format", value);
    }

}
