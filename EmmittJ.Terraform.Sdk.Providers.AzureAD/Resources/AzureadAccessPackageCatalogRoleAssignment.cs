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
    /// The object ID of the member principal
    /// </summary>
    public string? PrincipalObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_object_id")?.Value;
        set => this.WithProperty("principal_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the catalog role for this assignment
    /// </summary>
    public string? RoleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_id")?.Value;
        set => this.WithProperty("role_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
