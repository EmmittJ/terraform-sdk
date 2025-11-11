using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_policy_attachment resource.
/// </summary>
public partial class AwsIamPolicyAttachment : TerraformResource
{
    public AwsIamPolicyAttachment(string name) : base("aws_iam_policy_attachment", name)
    {
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [TerraformProperty("groups")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Groups { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    [TerraformProperty("policy_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyArn { get; set; }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [TerraformProperty("roles")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Roles { get; set; }

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformProperty("users")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Users { get; set; }

}
