using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_group_policy_attachment Terraform resource.
/// Manages a aws_iam_group_policy_attachment resource.
/// </summary>
public partial class AwsIamGroupPolicyAttachment(string name) : TerraformResource("aws_iam_group_policy_attachment", name)
{
    /// <summary>
    /// The group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformValue<string> Group
    {
        get => new TerraformReference<string>(this, "group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformValue<string> PolicyArn
    {
        get => new TerraformReference<string>(this, "policy_arn");
        set => SetArgument("policy_arn", value);
    }

}
