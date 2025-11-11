using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_approval_rule_template_association resource.
/// </summary>
public partial class AwsCodecommitApprovalRuleTemplateAssociation : TerraformResource
{
    public AwsCodecommitApprovalRuleTemplateAssociation(string name) : base("aws_codecommit_approval_rule_template_association", name)
    {
    }

    /// <summary>
    /// The approval_rule_template_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalRuleTemplateName is required")]
    [TerraformProperty("approval_rule_template_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApprovalRuleTemplateName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

}
