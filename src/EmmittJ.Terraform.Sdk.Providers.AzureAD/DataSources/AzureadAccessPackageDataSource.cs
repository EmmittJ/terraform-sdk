using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_access_package.
/// </summary>
public class AzureadAccessPackageDataSource : TerraformDataSource
{
    public AzureadAccessPackageDataSource(string name) : base("azuread_access_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("hidden");
    }

    /// <summary>
    /// The ID of the Catalog this access package is in
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the access package
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
    /// The ID of this access package
    /// </summary>
    public string? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id")?.Value;
        set => this.WithProperty("object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the access package
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    public TerraformExpression Hidden => this["hidden"];

}
