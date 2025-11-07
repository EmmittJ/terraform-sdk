using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_access_package_catalog_role.
/// </summary>
public class AzureadAccessPackageCatalogRoleDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogRoleDataSource(string name) : base("azuread_access_package_catalog_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("template_id");
    }

    /// <summary>
    /// The display name of the catalog role
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The object ID of the catalog role
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// The description of the catalog role
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The object ID of the template associated with the catalog role
    /// </summary>
    public TerraformExpression TemplateId => this["template_id"];

}
