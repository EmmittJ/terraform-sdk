using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_table_entity resource.
/// </summary>
public class AzurermStorageTableEntity : TerraformResource
{
    public AzurermStorageTableEntity(string name) : base("azurerm_storage_table_entity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The entity attribute.
    /// </summary>
    public Dictionary<string, string>? Entity
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("entity")?.Value;
        set => this.WithProperty("entity", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The partition_key attribute.
    /// </summary>
    public string? PartitionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key")?.Value;
        set => this.WithProperty("partition_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_table_id attribute.
    /// </summary>
    public string? StorageTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_table_id")?.Value;
        set => this.WithProperty("storage_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
