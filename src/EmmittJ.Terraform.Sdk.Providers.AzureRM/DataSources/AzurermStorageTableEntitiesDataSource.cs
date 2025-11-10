using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageTableEntitiesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
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
    public List<TerraformProperty<string>>? Select
    {
        get => GetProperty<List<TerraformProperty<string>>>("select");
        set => this.WithProperty("select", value);
    }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageTableId is required")]
    public required TerraformProperty<string> StorageTableId
    {
        get => GetProperty<TerraformProperty<string>>("storage_table_id");
        set => this.WithProperty("storage_table_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageTableEntitiesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageTableEntitiesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
