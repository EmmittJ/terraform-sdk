using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_access_package_catalog_role.
/// </summary>
public class AzureadAccessPackageCatalogRoleDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogRoleDataSource(string name) : base("azuread_access_package_catalog_role", name)
    {
    }

    /// <summary>
    /// The display name of the catalog role
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object ID of the catalog role
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The description of the catalog role
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The object ID of the template associated with the catalog role
    /// </summary>
    [TerraformPropertyName("template_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TemplateId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_id");

}
