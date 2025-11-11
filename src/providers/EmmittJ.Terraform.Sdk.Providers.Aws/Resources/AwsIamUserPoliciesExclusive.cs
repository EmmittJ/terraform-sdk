using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policies_exclusive resource.
/// </summary>
public partial class AwsIamUserPoliciesExclusive : TerraformResource
{
    public AwsIamUserPoliciesExclusive(string name) : base("aws_iam_user_policies_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    [TerraformProperty("policy_names")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> PolicyNames { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserName { get; set; }

}
