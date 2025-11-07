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
    public TerraformLiteralProperty<double>? BatchSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_size");
        set => this.WithProperty("batch_size", value);
    }

    /// <summary>
    /// The columns_to_remove attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ColumnsToRemove
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("columns_to_remove");
        set => this.WithProperty("columns_to_remove", value);
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
    /// The partition_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key");
        set => this.WithProperty("partition_key", value);
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
    /// The row_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RowKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("row_key");
        set => this.WithProperty("row_key", value);
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
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Table
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

}
