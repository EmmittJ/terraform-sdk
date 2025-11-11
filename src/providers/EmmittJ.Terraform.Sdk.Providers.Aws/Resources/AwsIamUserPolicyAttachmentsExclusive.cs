using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policy_attachments_exclusive resource.
/// </summary>
public partial class AwsIamUserPolicyAttachmentsExclusive : TerraformResource
{
    public AwsIamUserPolicyAttachmentsExclusive(string name) : base("aws_iam_user_policy_attachments_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    [TerraformProperty("policy_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> PolicyArns { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserName { get; set; }

}
