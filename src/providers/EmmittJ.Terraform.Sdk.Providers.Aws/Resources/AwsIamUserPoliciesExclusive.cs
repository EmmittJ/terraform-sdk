using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policies_exclusive resource.
/// </summary>
public class AwsIamUserPoliciesExclusive : TerraformResource
{
    public AwsIamUserPoliciesExclusive(string name) : base("aws_iam_user_policies_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    [TerraformPropertyName("policy_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> PolicyNames { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

}
