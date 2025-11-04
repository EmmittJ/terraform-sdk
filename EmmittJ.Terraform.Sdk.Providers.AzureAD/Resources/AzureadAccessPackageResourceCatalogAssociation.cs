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
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group
    /// </summary>
    public string? ResourceOriginId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_origin_id")?.Value;
        set => this.WithProperty("resource_origin_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup
    /// </summary>
    public string? ResourceOriginSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_origin_system")?.Value;
        set => this.WithProperty("resource_origin_system", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
