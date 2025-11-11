using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_identity_group_memberships.
/// </summary>
public class GoogleCloudIdentityGroupMembershipsDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupMembershipsDataSource(string name) : base("google_cloud_identity_group_memberships", name)
    {
    }

    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformPropertyName("group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    [TerraformPropertyName("memberships")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Memberships => new TerraformReference(this, "memberships");

}
