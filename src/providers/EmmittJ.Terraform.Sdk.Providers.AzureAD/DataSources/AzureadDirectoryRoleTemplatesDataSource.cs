using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_directory_role_templates.
/// </summary>
public partial class AzureadDirectoryRoleTemplatesDataSource : TerraformDataSource
{
    public AzureadDirectoryRoleTemplatesDataSource(string name) : base("azuread_directory_role_templates", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object IDs of the role templates
    /// </summary>
    [TerraformProperty("object_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ObjectIds { get; }

    /// <summary>
    /// A list of role templates
    /// </summary>
    [TerraformProperty("role_templates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RoleTemplates { get; }

}
