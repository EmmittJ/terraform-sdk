using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization_iam_custom_roles.
/// </summary>
public class GoogleOrganizationIamCustomRolesDataSource : TerraformDataSource
{
    public GoogleOrganizationIamCustomRolesDataSource(string name) : base("google_organization_iam_custom_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrgId { get; set; }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    [TerraformPropertyName("show_deleted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ShowDeleted { get; set; }

    /// <summary>
    /// The view attribute.
    /// </summary>
    [TerraformPropertyName("view")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? View { get; set; }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [TerraformPropertyName("roles")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Roles => new TerraformReference(this, "roles");

}
