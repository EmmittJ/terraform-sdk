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
    public required TerraformProperty<TerraformProperty<string>> ControlStatus { get; set; }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    [TerraformPropertyName("disabled_reason")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisabledReason { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disabled_reason");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The standards_control_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsControlArn is required")]
    [TerraformPropertyName("standards_control_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StandardsControlArn { get; set; }

    /// <summary>
    /// The control_id attribute.
    /// </summary>
    [TerraformPropertyName("control_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_id");

    /// <summary>
    /// The control_status_updated_at attribute.
    /// </summary>
    [TerraformPropertyName("control_status_updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlStatusUpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_status_updated_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The related_requirements attribute.
    /// </summary>
    [TerraformPropertyName("related_requirements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> RelatedRequirements => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "related_requirements");

    /// <summary>
    /// The remediation_url attribute.
    /// </summary>
    [TerraformPropertyName("remediation_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RemediationUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "remediation_url");

    /// <summary>
    /// The severity_rating attribute.
    /// </summary>
    [TerraformPropertyName("severity_rating")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SeverityRating => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "severity_rating");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Title => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "title");

}
