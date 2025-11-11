using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_policy.
/// </summary>
public class AwsIamPolicyDataSource : TerraformDataSource
{
    public AwsIamPolicyDataSource(string name) : base("aws_iam_policy", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    [TerraformPropertyName("path_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PathPrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The attachment_count attribute.
    /// </summary>
    [TerraformPropertyName("attachment_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AttachmentCount => new TerraformReference(this, "attachment_count");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Path => new TerraformReference(this, "path");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Policy => new TerraformReference(this, "policy");

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyId => new TerraformReference(this, "policy_id");

}
