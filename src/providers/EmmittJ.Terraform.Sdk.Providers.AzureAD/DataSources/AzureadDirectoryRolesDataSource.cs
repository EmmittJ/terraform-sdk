using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRolesDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_directory_roles.
/// </summary>
public class AzureadDirectoryRolesDataSource : TerraformDataSource
{
    public AzureadDirectoryRolesDataSource(string name) : base("azuread_directory_roles", name)
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
    public TerraformBlock<AzureadDirectoryRolesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object IDs of the roles
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ObjectIds => new TerraformReference(this, "object_ids");

    /// <summary>
    /// A list of roles
    /// </summary>
    [TerraformPropertyName("roles")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Roles => new TerraformReference(this, "roles");

    /// <summary>
    /// The template IDs of the roles
    /// </summary>
    [TerraformPropertyName("template_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> TemplateIds => new TerraformReference(this, "template_ids");

}
