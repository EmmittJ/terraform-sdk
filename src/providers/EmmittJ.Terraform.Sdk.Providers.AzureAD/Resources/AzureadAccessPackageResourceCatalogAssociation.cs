using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_access_package_resource_catalog_association resource.
/// </summary>
public class AzureadAccessPackageResourceCatalogAssociation : TerraformResource
{
    public AzureadAccessPackageResourceCatalogAssociation(string name) : base("azuread_access_package_resource_catalog_association", name)
    {
    }

    /// <summary>
    /// The unique ID of the access package catalog
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    [TerraformPropertyName("catalog_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CatalogId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginId is required")]
    [TerraformPropertyName("resource_origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceOriginId { get; set; }

    /// <summary>
    /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginSystem is required")]
    [TerraformPropertyName("resource_origin_system")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceOriginSystem { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

}
