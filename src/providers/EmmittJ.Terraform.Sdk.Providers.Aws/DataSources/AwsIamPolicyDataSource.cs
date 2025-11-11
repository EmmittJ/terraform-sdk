using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_policy.
/// </summary>
public partial class AwsIamPolicyDataSource : TerraformDataSource
{
    public AwsIamPolicyDataSource(string name) : base("aws_iam_policy", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    [TerraformProperty("path_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PathPrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The attachment_count attribute.
    /// </summary>
    [TerraformProperty("attachment_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AttachmentCount { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Path { get; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Policy { get; }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [TerraformProperty("policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyId { get; }

}
