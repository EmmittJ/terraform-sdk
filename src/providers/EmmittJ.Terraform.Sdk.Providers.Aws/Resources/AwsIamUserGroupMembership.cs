using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_group_membership resource.
/// </summary>
public partial class AwsIamUserGroupMembership : TerraformResource
{
    public AwsIamUserGroupMembership(string name) : base("aws_iam_user_group_membership", name)
    {
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Groups is required")]
    [TerraformProperty("groups")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Groups { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformProperty("user")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> User { get; set; }

}
