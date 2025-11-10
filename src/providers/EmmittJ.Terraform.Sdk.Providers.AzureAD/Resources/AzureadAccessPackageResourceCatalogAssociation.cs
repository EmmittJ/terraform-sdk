using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock : TerraformBlock
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
        SetOutput("catalog_id");
        SetOutput("id");
        SetOutput("resource_origin_id");
        SetOutput("resource_origin_system");
    }

    /// <summary>
    /// The unique ID of the access package catalog
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
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
    /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginId is required")]
    public required TerraformProperty<string> ResourceOriginId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_origin_id");
        set => SetProperty("resource_origin_id", value);
    }

    /// <summary>
    /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginSystem is required")]
    public required TerraformProperty<string> ResourceOriginSystem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_origin_system");
        set => SetProperty("resource_origin_system", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
