using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_identity_group_memberships.
/// </summary>
public partial class GoogleCloudIdentityGroupMembershipsDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupMembershipsDataSource(string name) : base("google_cloud_identity_group_memberships", name)
    {
    }

    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformProperty("group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    [TerraformProperty("memberships")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Memberships { get; }

}
