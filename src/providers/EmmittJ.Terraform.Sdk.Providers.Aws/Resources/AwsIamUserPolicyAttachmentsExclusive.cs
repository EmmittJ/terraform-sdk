using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_user_policy_attachments_exclusive Terraform resource.
/// Manages a aws_iam_user_policy_attachments_exclusive resource.
/// </summary>
public partial class AwsIamUserPolicyAttachmentsExclusive(string name) : TerraformResource("aws_iam_user_policy_attachments_exclusive", name)
{
    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    public required TerraformSet<string> PolicyArns
    {
        get => GetArgument<TerraformSet<string>>("policy_arns");
        set => SetArgument("policy_arns", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

}
