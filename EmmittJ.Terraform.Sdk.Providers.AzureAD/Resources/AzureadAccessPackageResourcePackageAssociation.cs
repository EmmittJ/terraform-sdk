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
    public string? AccessPackageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_package_id")?.Value;
        set => this.WithProperty("access_package_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    public string? AccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_type")?.Value;
        set => this.WithProperty("access_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    public string? CatalogResourceAssociationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_resource_association_id")?.Value;
        set => this.WithProperty("catalog_resource_association_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
