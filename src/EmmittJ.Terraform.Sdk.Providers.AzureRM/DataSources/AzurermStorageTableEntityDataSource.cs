using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_storage_table_entity.
/// </summary>
public class AzurermStorageTableEntityDataSource : TerraformDataSource
{
    public AzurermStorageTableEntityDataSource(string name) : base("azurerm_storage_table_entity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("entity");
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
    /// The partition_key attribute.
    /// </summary>
    public TerraformProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformProperty<string>>("partition_key");
        set => this.WithProperty("partition_key", value);
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
    /// The storage_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageTableId
    {
        get => GetProperty<TerraformProperty<string>>("storage_table_id");
        set => this.WithProperty("storage_table_id", value);
    }

    /// <summary>
    /// The entity attribute.
    /// </summary>
    public TerraformExpression Entity => this["entity"];

}
