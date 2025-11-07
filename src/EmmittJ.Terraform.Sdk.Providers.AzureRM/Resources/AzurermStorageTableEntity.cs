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
    public TerraformLiteralProperty<Dictionary<string, string>>? Entity
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("entity");
        set => this.WithProperty("entity", value);
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
    /// The partition_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key");
        set => this.WithProperty("partition_key", value);
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
    /// The storage_table_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_table_id");
        set => this.WithProperty("storage_table_id", value);
    }

}
