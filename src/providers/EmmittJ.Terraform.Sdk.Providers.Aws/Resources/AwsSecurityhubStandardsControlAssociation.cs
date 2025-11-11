using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_standards_control_association resource.
/// </summary>
public partial class AwsSecurityhubStandardsControlAssociation : TerraformResource
{
    public AwsSecurityhubStandardsControlAssociation(string name) : base("aws_securityhub_standards_control_association", name)
    {
    }

    /// <summary>
    /// The association_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociationStatus is required")]
    [TerraformProperty("association_status")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AssociationStatus { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    [TerraformProperty("security_control_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecurityControlId { get; set; }

    /// <summary>
    /// The standards_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsArn is required")]
    [TerraformProperty("standards_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StandardsArn { get; set; }

    /// <summary>
    /// The updated_reason attribute.
    /// </summary>
    [TerraformProperty("updated_reason")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UpdatedReason { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
