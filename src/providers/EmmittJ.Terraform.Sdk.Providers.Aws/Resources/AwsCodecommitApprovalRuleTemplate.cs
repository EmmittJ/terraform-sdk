using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_approval_rule_template resource.
/// </summary>
public class AwsCodecommitApprovalRuleTemplate : TerraformResource
{
    public AwsCodecommitApprovalRuleTemplate(string name) : base("aws_codecommit_approval_rule_template", name)
    {
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    [TerraformPropertyName("approval_rule_template_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApprovalRuleTemplateId => new TerraformReference(this, "approval_rule_template_id");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedDate => new TerraformReference(this, "last_modified_date");

    /// <summary>
    /// The last_modified_user attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_user")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedUser => new TerraformReference(this, "last_modified_user");

    /// <summary>
    /// The rule_content_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("rule_content_sha256")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RuleContentSha256 => new TerraformReference(this, "rule_content_sha256");

}
