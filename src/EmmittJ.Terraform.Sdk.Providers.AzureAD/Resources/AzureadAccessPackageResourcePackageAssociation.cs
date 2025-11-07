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
    public TerraformProperty<string>? AccessPackageId
    {
        get => GetProperty<TerraformProperty<string>>("access_package_id");
        set => this.WithProperty("access_package_id", value);
    }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    public TerraformProperty<string>? AccessType
    {
        get => GetProperty<TerraformProperty<string>>("access_type");
        set => this.WithProperty("access_type", value);
    }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    public TerraformProperty<string>? CatalogResourceAssociationId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_resource_association_id");
        set => this.WithProperty("catalog_resource_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
