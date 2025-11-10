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
    public TerraformProperty<TerraformProperty<bool>>? AutoEnableControls { get; set; }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    [TerraformPropertyName("control_finding_generator")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ControlFindingGenerator { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_finding_generator");

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    [TerraformPropertyName("enable_default_standards")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableDefaultStandards { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
