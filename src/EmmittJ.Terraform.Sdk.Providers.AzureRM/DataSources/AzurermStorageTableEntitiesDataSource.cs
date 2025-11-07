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
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The select attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Select
    {
        get => GetProperty<TerraformProperty<List<string>>>("select");
        set => this.WithProperty("select", value);
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
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
