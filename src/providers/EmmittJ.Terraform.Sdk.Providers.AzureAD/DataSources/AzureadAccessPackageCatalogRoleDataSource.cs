using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_access_package_catalog_role.
/// </summary>
public partial class AzureadAccessPackageCatalogRoleDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogRoleDataSource(string name) : base("azuread_access_package_catalog_role", name)
    {
    }

    /// <summary>
    /// The display name of the catalog role
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the catalog role
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description of the catalog role
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The object ID of the template associated with the catalog role
    /// </summary>
    [TerraformProperty("template_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TemplateId { get; }

}
