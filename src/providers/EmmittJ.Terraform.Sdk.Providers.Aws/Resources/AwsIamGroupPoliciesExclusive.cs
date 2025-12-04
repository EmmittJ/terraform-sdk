using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_group_policies_exclusive Terraform resource.
/// Manages a aws_iam_group_policies_exclusive resource.
/// </summary>
public partial class AwsIamGroupPoliciesExclusive(string name) : TerraformResource("aws_iam_group_policies_exclusive", name)
{
    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_name");
        set => SetArgument("group_name", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public required TerraformSet<string> PolicyNames
    {
        get => GetRequiredArgument<TerraformSet<string>>("policy_names");
        set => SetArgument("policy_names", value);
    }

}
