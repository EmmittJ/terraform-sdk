using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_access_package_resource_catalog_association resource.
/// </summary>
public class AzureadAccessPackageResourceCatalogAssociation : TerraformResource
{
    public AzureadAccessPackageResourceCatalogAssociation(string name) : base("azuread_access_package_resource_catalog_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The unique ID of the access package catalog
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
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
    /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group
    /// </summary>
    public TerraformProperty<string>? ResourceOriginId
    {
        get => GetProperty<TerraformProperty<string>>("resource_origin_id");
        set => this.WithProperty("resource_origin_id", value);
    }

    /// <summary>
    /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup
    /// </summary>
    public TerraformProperty<string>? ResourceOriginSystem
    {
        get => GetProperty<TerraformProperty<string>>("resource_origin_system");
        set => this.WithProperty("resource_origin_system", value);
    }

}
