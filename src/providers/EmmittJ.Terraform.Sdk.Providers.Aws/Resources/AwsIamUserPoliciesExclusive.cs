using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_user_policies_exclusive Terraform resource.
/// Manages a aws_iam_user_policies_exclusive resource.
/// </summary>
public partial class AwsIamUserPoliciesExclusive(string name) : TerraformResource("aws_iam_user_policies_exclusive", name)
{
    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public required TerraformSet<string> PolicyNames
    {
        get => GetRequiredArgument<TerraformSet<string>>("policy_names");
        set => SetArgument("policy_names", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

}
