using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcrRegistryScanningConfigurationRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The scan_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanFrequency is required")]
    [TerraformProperty("scan_frequency")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ScanFrequency { get; set; }

}

/// <summary>
/// Manages a aws_ecr_registry_scanning_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcrRegistryScanningConfiguration : TerraformResource
{
    public AwsEcrRegistryScanningConfiguration(string name) : base("aws_ecr_registry_scanning_configuration", name)
    {
    }

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
    /// The scan_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanType is required")]
    [TerraformProperty("scan_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ScanType { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Rule block(s) allowed")]
    [TerraformProperty("rule")]
    public TerraformSet<TerraformBlock<AwsEcrRegistryScanningConfigurationRuleBlock>>? Rule { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegistryId { get; }

}
