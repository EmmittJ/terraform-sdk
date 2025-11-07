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
    public TerraformProperty<double>? BatchSize
    {
        get => GetProperty<TerraformProperty<double>>("batch_size");
        set => this.WithProperty("batch_size", value);
    }

    /// <summary>
    /// The columns_to_remove attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ColumnsToRemove
    {
        get => GetProperty<TerraformProperty<List<string>>>("columns_to_remove");
        set => this.WithProperty("columns_to_remove", value);
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
    /// The partition_key attribute.
    /// </summary>
    public TerraformProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformProperty<string>>("partition_key");
        set => this.WithProperty("partition_key", value);
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
    /// The row_key attribute.
    /// </summary>
    public TerraformProperty<string>? RowKey
    {
        get => GetProperty<TerraformProperty<string>>("row_key");
        set => this.WithProperty("row_key", value);
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
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public TerraformProperty<string>? Table
    {
        get => GetProperty<TerraformProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

}
