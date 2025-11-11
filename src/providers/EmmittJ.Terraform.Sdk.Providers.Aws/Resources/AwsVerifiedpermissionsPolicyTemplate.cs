using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedpermissions_policy_template resource.
/// </summary>
public partial class AwsVerifiedpermissionsPolicyTemplate : TerraformResource
{
    public AwsVerifiedpermissionsPolicyTemplate(string name) : base("aws_verifiedpermissions_policy_template", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    [TerraformProperty("policy_store_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The statement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statement is required")]
    [TerraformProperty("statement")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Statement { get; set; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The policy_template_id attribute.
    /// </summary>
    [TerraformProperty("policy_template_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyTemplateId { get; }

}
