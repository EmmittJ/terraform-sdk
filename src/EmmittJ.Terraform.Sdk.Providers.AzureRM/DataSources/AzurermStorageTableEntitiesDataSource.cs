using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_storage_table_entities.
/// </summary>
public class AzurermStorageTableEntitiesDataSource : TerraformDataSource
{
    public AzurermStorageTableEntitiesDataSource(string name) : base("azurerm_storage_table_entities", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("items");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The select attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Select
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("select");
        set => this.WithProperty("select", value);
    }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_table_id");
        set => this.WithProperty("storage_table_id", value);
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
