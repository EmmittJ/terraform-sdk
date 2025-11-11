using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_policies_exclusive resource.
/// </summary>
public class AwsIamGroupPoliciesExclusive : TerraformResource
{
    public AwsIamGroupPoliciesExclusive(string name) : base("aws_iam_group_policies_exclusive", name)
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    [TerraformPropertyName("group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupName { get; set; }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    [TerraformPropertyName("policy_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> PolicyNames { get; set; }

}
