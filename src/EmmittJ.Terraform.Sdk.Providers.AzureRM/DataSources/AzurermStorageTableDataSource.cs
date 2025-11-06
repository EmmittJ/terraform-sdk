using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_storage_table.
/// </summary>
public class AzurermStorageTableDataSource : TerraformDataSource
{
    public AzurermStorageTableDataSource(string name) : base("azurerm_storage_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("acl");
        this.DeclareOutput("id");
        this.DeclareOutput("resource_manager_id");
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
    /// The storage_account_name attribute.
    /// </summary>
    public string? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name")?.Value;
        set => this.WithProperty("storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    public TerraformExpression Acl => this["acl"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

}
