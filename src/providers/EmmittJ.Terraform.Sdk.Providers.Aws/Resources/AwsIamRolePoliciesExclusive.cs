using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_role_policies_exclusive resource.
/// </summary>
public partial class AwsIamRolePoliciesExclusive : TerraformResource
{
    public AwsIamRolePoliciesExclusive(string name) : base("aws_iam_role_policies_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    [TerraformProperty("policy_names")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> PolicyNames { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformProperty("role_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleName { get; set; }

}
