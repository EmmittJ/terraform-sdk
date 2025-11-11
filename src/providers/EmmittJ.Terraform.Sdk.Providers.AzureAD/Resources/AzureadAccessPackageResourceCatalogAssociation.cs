using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_access_package_resource_catalog_association resource.
/// </summary>
public partial class AzureadAccessPackageResourceCatalogAssociation : TerraformResource
{
    public AzureadAccessPackageResourceCatalogAssociation(string name) : base("azuread_access_package_resource_catalog_association", name)
    {
    }

    /// <summary>
    /// The unique ID of the access package catalog
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    [TerraformProperty("catalog_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginId is required")]
    [TerraformProperty("resource_origin_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceOriginId { get; set; }

    /// <summary>
    /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginSystem is required")]
    [TerraformProperty("resource_origin_system")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceOriginSystem { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock>? Timeouts { get; set; }

}
