using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_standards_control resource.
/// </summary>
public class AwsSecurityhubStandardsControl : TerraformResource
{
    public AwsSecurityhubStandardsControl(string name) : base("aws_securityhub_standards_control", name)
    {
    }

    /// <summary>
    /// The control_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlStatus is required")]
    [TerraformPropertyName("control_status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ControlStatus { get; set; }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    [TerraformPropertyName("disabled_reason")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisabledReason { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The standards_control_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsControlArn is required")]
    [TerraformPropertyName("standards_control_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StandardsControlArn { get; set; }

    /// <summary>
    /// The control_id attribute.
    /// </summary>
    [TerraformPropertyName("control_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ControlId => new TerraformReference(this, "control_id");

    /// <summary>
    /// The control_status_updated_at attribute.
    /// </summary>
    [TerraformPropertyName("control_status_updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ControlStatusUpdatedAt => new TerraformReference(this, "control_status_updated_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The related_requirements attribute.
    /// </summary>
    [TerraformPropertyName("related_requirements")]
    // Output-only attribute - read-only reference
    public TerraformList<string> RelatedRequirements => new TerraformReference(this, "related_requirements");

    /// <summary>
    /// The remediation_url attribute.
    /// </summary>
    [TerraformPropertyName("remediation_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RemediationUrl => new TerraformReference(this, "remediation_url");

    /// <summary>
    /// The severity_rating attribute.
    /// </summary>
    [TerraformPropertyName("severity_rating")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SeverityRating => new TerraformReference(this, "severity_rating");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Title => new TerraformReference(this, "title");

}
