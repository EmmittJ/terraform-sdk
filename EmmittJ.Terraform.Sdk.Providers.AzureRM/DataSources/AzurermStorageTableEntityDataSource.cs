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

    /// <summary>
    /// The entity attribute.
    /// </summary>
    public TerraformExpression Entity => this["entity"];

}
