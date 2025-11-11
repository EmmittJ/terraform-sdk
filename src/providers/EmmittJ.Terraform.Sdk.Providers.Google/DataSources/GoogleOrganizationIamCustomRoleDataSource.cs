using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization_iam_custom_role.
/// </summary>
public partial class GoogleOrganizationIamCustomRoleDataSource : TerraformDataSource
{
    public GoogleOrganizationIamCustomRoleDataSource(string name) : base("google_organization_iam_custom_role", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The numeric ID of the organization in which you want to create a custom role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// The role id to use for this role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformProperty("role_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleId { get; set; }

    /// <summary>
    /// The current deleted state of the role.
    /// </summary>
    [TerraformProperty("deleted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Deleted { get; }

    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The name of the role in the format organizations/{{org_id}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    [TerraformProperty("permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Permissions { get; }

    /// <summary>
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    [TerraformProperty("stage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Stage { get; }

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    [TerraformProperty("title")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Title { get; }

}
