using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codecommit_approval_rule_template.
/// </summary>
public partial class AwsCodecommitApprovalRuleTemplateDataSource : TerraformDataSource
{
    public AwsCodecommitApprovalRuleTemplateDataSource(string name) : base("aws_codecommit_approval_rule_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The approval_rule_template_id attribute.
    /// </summary>
    [TerraformProperty("approval_rule_template_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApprovalRuleTemplateId { get; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformProperty("content")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Content { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedDate { get; }

    /// <summary>
    /// The last_modified_user attribute.
    /// </summary>
    [TerraformProperty("last_modified_user")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedUser { get; }

    /// <summary>
    /// The rule_content_sha256 attribute.
    /// </summary>
    [TerraformProperty("rule_content_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RuleContentSha256 { get; }

}
