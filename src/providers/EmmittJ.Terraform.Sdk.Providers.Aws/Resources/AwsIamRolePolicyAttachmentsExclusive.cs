using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_role_policy_attachments_exclusive Terraform resource.
/// Manages a aws_iam_role_policy_attachments_exclusive resource.
/// </summary>
public partial class AwsIamRolePolicyAttachmentsExclusive(string name) : TerraformResource("aws_iam_role_policy_attachments_exclusive", name)
{
    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    public required TerraformSet<string> PolicyArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_arns").ResolveNodes(ctx));
        set => SetArgument("policy_arns", value);
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
