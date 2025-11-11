using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_assessment_delegation resource.
/// </summary>
public partial class AwsAuditmanagerAssessmentDelegation : TerraformResource
{
    public AwsAuditmanagerAssessmentDelegation(string name) : base("aws_auditmanager_assessment_delegation", name)
    {
    }

    /// <summary>
    /// The assessment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentId is required")]
    [TerraformProperty("assessment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AssessmentId { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The control_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlSetId is required")]
    [TerraformProperty("control_set_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ControlSetId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleType is required")]
    [TerraformProperty("role_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleType { get; set; }

    /// <summary>
    /// The delegation_id attribute.
    /// </summary>
    [TerraformProperty("delegation_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DelegationId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
