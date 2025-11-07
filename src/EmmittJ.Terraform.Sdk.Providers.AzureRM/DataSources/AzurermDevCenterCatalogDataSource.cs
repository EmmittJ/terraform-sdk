using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_dev_center_catalog.
/// </summary>
public class AzurermDevCenterCatalogDataSource : TerraformDataSource
{
    public AzurermDevCenterCatalogDataSource(string name) : base("azurerm_dev_center_catalog", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("catalog_adogit");
        this.DeclareOutput("catalog_github");
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DevCenterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_id");
        set => this.WithProperty("dev_center_id", value);
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
    /// The catalog_adogit attribute.
    /// </summary>
    public TerraformExpression CatalogAdogit => this["catalog_adogit"];

    /// <summary>
    /// The catalog_github attribute.
    /// </summary>
    public TerraformExpression CatalogGithub => this["catalog_github"];

}
