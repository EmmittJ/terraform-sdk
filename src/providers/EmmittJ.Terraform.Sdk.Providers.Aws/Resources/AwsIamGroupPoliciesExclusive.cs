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
        get => new TerraformReference<string>(this, "group_name");
        set => SetArgument("group_name", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    public required TerraformSet<string> PolicyNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_names").ResolveNodes(ctx));
        set => SetArgument("policy_names", value);
    }

}
