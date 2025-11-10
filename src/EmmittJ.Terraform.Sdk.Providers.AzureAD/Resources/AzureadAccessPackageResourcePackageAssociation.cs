using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageResourcePackageAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    public required TerraformProperty<string> AccessPackageId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogResourceAssociationId is required")]
    public required TerraformProperty<string> CatalogResourceAssociationId
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

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAccessPackageResourcePackageAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadAccessPackageResourcePackageAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
