using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_group_policy_attachments_exclusive Terraform resource.
/// Manages a aws_iam_group_policy_attachments_exclusive resource.
/// </summary>
public partial class AwsIamGroupPolicyAttachmentsExclusive(string name) : TerraformResource("aws_iam_group_policy_attachments_exclusive", name)
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
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    public required TerraformSet<string> PolicyArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_arns").ResolveNodes(ctx));
        set => SetArgument("policy_arns", value);
    }

}
