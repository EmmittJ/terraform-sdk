using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_role_policies_exclusive Terraform resource.
/// Manages a aws_iam_role_policies_exclusive resource.
/// </summary>
public partial class AwsIamRolePoliciesExclusive(string name) : TerraformResource("aws_iam_role_policies_exclusive", name)
{
    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public required TerraformSet<string> PolicyNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_names").ResolveNodes(ctx));
        set => SetArgument("policy_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

}
