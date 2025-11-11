using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policy_attachments_exclusive resource.
/// </summary>
public class AwsIamUserPolicyAttachmentsExclusive : TerraformResource
{
    public AwsIamUserPolicyAttachmentsExclusive(string name) : base("aws_iam_user_policy_attachments_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    [TerraformPropertyName("policy_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> PolicyArns { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

}
