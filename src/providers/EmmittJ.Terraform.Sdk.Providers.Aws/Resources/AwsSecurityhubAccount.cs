using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_account resource.
/// </summary>
public class AwsSecurityhubAccount : TerraformResource
{
    public AwsSecurityhubAccount(string name) : base("aws_securityhub_account", name)
    {
    }

    /// <summary>
    /// The auto_enable_controls attribute.
    /// </summary>
    [TerraformPropertyName("auto_enable_controls")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoEnableControls { get; set; }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    [TerraformPropertyName("control_finding_generator")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ControlFindingGenerator { get; set; } = default!;

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    [TerraformPropertyName("enable_default_standards")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableDefaultStandards { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
