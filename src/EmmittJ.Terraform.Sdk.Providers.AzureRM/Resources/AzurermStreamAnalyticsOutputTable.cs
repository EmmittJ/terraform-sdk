using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_table resource.
/// </summary>
public class AzurermStreamAnalyticsOutputTable : TerraformResource
{
    public AzurermStreamAnalyticsOutputTable(string name) : base("azurerm_stream_analytics_output_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public double? BatchSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_size")?.Value;
        set => this.WithProperty("batch_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The columns_to_remove attribute.
    /// </summary>
    public List<string>? ColumnsToRemove
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("columns_to_remove")?.Value;
        set => this.WithProperty("columns_to_remove", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The partition_key attribute.
    /// </summary>
    public string? PartitionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key")?.Value;
        set => this.WithProperty("partition_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The row_key attribute.
    /// </summary>
    public string? RowKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("row_key")?.Value;
        set => this.WithProperty("row_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public string? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name")?.Value;
        set => this.WithProperty("stream_analytics_job_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public string? Table
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table")?.Value;
        set => this.WithProperty("table", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
