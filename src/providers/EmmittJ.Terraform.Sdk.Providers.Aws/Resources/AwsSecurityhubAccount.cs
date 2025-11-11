using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_account resource.
/// </summary>
public partial class AwsSecurityhubAccount : TerraformResource
{
    public AwsSecurityhubAccount(string name) : base("aws_securityhub_account", name)
    {
    }

    /// <summary>
    /// The auto_enable_controls attribute.
    /// </summary>
    [TerraformProperty("auto_enable_controls")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoEnableControls { get; set; }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    [TerraformProperty("control_finding_generator")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ControlFindingGenerator { get; set; }

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    [TerraformProperty("enable_default_standards")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableDefaultStandards { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
