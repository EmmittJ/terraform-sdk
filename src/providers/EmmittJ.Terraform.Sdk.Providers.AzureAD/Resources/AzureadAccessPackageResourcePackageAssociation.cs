using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAccessPackageResourcePackageAssociationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azuread_access_package_resource_package_association resource.
/// </summary>
public partial class AzureadAccessPackageResourcePackageAssociation : TerraformResource
{
    public AzureadAccessPackageResourcePackageAssociation(string name) : base("azuread_access_package_resource_package_association", name)
    {
    }

    /// <summary>
    /// The ID of access package this resource association is configured to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    [TerraformProperty("access_package_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessPackageId { get; set; }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    [TerraformProperty("access_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccessType { get; set; }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogResourceAssociationId is required")]
    [TerraformProperty("catalog_resource_association_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CatalogResourceAssociationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadAccessPackageResourcePackageAssociationTimeoutsBlock>? Timeouts { get; set; }

}
