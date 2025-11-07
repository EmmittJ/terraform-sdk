using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_access_package resource.
/// </summary>
public class AzureadAccessPackage : TerraformResource
{
    public AzureadAccessPackage(string name) : base("azuread_access_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The ID of the Catalog this access package will be created in
    /// </summary>
    public TerraformLiteralProperty<string>? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The description of the access package
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the access package
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    public TerraformLiteralProperty<bool>? Hidden
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hidden");
        set => this.WithProperty("hidden", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
