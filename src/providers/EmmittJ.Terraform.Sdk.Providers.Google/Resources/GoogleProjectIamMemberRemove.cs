using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_iam_member_remove resource.
/// </summary>
public partial class GoogleProjectIamMemberRemove : TerraformResource
{
    public GoogleProjectIamMemberRemove(string name) : base("google_project_iam_member_remove", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The IAM principal that should not have the target role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Member is required")]
    [TerraformProperty("member")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Member { get; set; }

    /// <summary>
    /// The project id of the target project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The target role that should be removed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

}
