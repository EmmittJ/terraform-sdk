using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_access_package_catalog.
/// </summary>
public class AzureadAccessPackageCatalogDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogDataSource(string name) : base("azuread_access_package_catalog", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("externally_visible");
        this.DeclareOutput("published");
    }

    /// <summary>
    /// The display name of the access package catalog
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ID of this access package catalog
    /// </summary>
    public string? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id")?.Value;
        set => this.WithProperty("object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    public TerraformExpression ExternallyVisible => this["externally_visible"];

    /// <summary>
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    public TerraformExpression Published => this["published"];

}
