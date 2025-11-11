using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_policy_attachment resource.
/// </summary>
public partial class AwsIamGroupPolicyAttachment : TerraformResource
{
    public AwsIamGroupPolicyAttachment(string name) : base("aws_iam_group_policy_attachment", name)
    {
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformProperty("group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    [TerraformProperty("policy_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyArn { get; set; }

}
