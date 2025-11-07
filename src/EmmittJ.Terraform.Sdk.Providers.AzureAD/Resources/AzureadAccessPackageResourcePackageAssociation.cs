using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_access_package_resource_package_association resource.
/// </summary>
public class AzureadAccessPackageResourcePackageAssociation : TerraformResource
{
    public AzureadAccessPackageResourcePackageAssociation(string name) : base("azuread_access_package_resource_package_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The ID of access package this resource association is configured to
    /// </summary>
    public TerraformLiteralProperty<string>? AccessPackageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_package_id");
        set => this.WithProperty("access_package_id", value);
    }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    public TerraformLiteralProperty<string>? AccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_type");
        set => this.WithProperty("access_type", value);
    }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    public TerraformLiteralProperty<string>? CatalogResourceAssociationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_resource_association_id");
        set => this.WithProperty("catalog_resource_association_id", value);
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
