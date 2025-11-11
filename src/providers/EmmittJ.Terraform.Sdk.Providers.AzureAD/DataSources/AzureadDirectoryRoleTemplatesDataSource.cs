using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_directory_role_templates.
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSource : TerraformDataSource
{
    public AzureadDirectoryRoleTemplatesDataSource(string name) : base("azuread_directory_role_templates", name)
    {
    }

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
    public TerraformBlock<AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object IDs of the role templates
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ObjectIds => new TerraformReference(this, "object_ids");

    /// <summary>
    /// A list of role templates
    /// </summary>
    [TerraformPropertyName("role_templates")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RoleTemplates => new TerraformReference(this, "role_templates");

}
