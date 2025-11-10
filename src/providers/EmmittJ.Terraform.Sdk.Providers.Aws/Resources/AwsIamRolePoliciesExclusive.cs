using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_role_policies_exclusive resource.
/// </summary>
public class AwsIamRolePoliciesExclusive : TerraformResource
{
    public AwsIamRolePoliciesExclusive(string name) : base("aws_iam_role_policies_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    [TerraformPropertyName("policy_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PolicyNames { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformPropertyName("role_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleName { get; set; }

}
