using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageResourcePackageAssociationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_access_package_resource_package_association resource.
/// </summary>
public class AzureadAccessPackageResourcePackageAssociation : TerraformResource
{
    public AzureadAccessPackageResourcePackageAssociation(string name) : base("azuread_access_package_resource_package_association", name)
    {
    }

    /// <summary>
    /// The ID of access package this resource association is configured to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    [TerraformPropertyName("access_package_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessPackageId { get; set; }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    [TerraformPropertyName("access_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessType { get; set; }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogResourceAssociationId is required")]
    [TerraformPropertyName("catalog_resource_association_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CatalogResourceAssociationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageResourcePackageAssociationTimeoutsBlock>? Timeouts { get; set; }

}
