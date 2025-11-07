using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_access_package_catalog_role_assignment resource.
/// </summary>
public class AzureadAccessPackageCatalogRoleAssignment : TerraformResource
{
    public AzureadAccessPackageCatalogRoleAssignment(string name) : base("azuread_access_package_catalog_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The unique ID of the access package catalog.
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
    /// The object ID of the member principal
    /// </summary>
    public TerraformProperty<string>? PrincipalObjectId
    {
        get => GetProperty<TerraformProperty<string>>("principal_object_id");
        set => this.WithProperty("principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the catalog role for this assignment
    /// </summary>
    public TerraformProperty<string>? RoleId
    {
        get => GetProperty<TerraformProperty<string>>("role_id");
        set => this.WithProperty("role_id", value);
    }

}
