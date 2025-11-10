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
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    [TerraformPropertyName("approval_rule_template_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApprovalRuleTemplateId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "approval_rule_template_id");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_date");

    /// <summary>
    /// The last_modified_user attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_user")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedUser => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_user");

    /// <summary>
    /// The rule_content_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("rule_content_sha256")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RuleContentSha256 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rule_content_sha256");

}
