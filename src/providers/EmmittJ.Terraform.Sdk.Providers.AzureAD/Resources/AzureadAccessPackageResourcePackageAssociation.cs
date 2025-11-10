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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("access_package_id");
        SetOutput("access_type");
        SetOutput("catalog_resource_association_id");
        SetOutput("id");
    }

    /// <summary>
    /// The ID of access package this resource association is configured to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    public required TerraformProperty<string> AccessPackageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_package_id");
        set => SetProperty("access_package_id", value);
    }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    public TerraformProperty<string> AccessType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_type");
        set => SetProperty("access_type", value);
    }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogResourceAssociationId is required")]
    public required TerraformProperty<string> CatalogResourceAssociationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_resource_association_id");
        set => SetProperty("catalog_resource_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAccessPackageResourcePackageAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
