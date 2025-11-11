using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_standards_control resource.
/// </summary>
public partial class AwsSecurityhubStandardsControl : TerraformResource
{
    public AwsSecurityhubStandardsControl(string name) : base("aws_securityhub_standards_control", name)
    {
    }

    /// <summary>
    /// The control_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlStatus is required")]
    [TerraformProperty("control_status")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ControlStatus { get; set; }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    [TerraformProperty("disabled_reason")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisabledReason { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The standards_control_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsControlArn is required")]
    [TerraformProperty("standards_control_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StandardsControlArn { get; set; }

    /// <summary>
    /// The control_id attribute.
    /// </summary>
    [TerraformProperty("control_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlId { get; }

    /// <summary>
    /// The control_status_updated_at attribute.
    /// </summary>
    [TerraformProperty("control_status_updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlStatusUpdatedAt { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The related_requirements attribute.
    /// </summary>
    [TerraformProperty("related_requirements")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> RelatedRequirements { get; }

    /// <summary>
    /// The remediation_url attribute.
    /// </summary>
    [TerraformProperty("remediation_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RemediationUrl { get; }

    /// <summary>
    /// The severity_rating attribute.
    /// </summary>
    [TerraformProperty("severity_rating")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SeverityRating { get; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Title { get; }

}
