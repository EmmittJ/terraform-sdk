using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trace_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerObservabilityConfigurationTraceConfigurationBlock() : TerraformBlock("trace_configuration")
{
    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformProperty("vendor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Vendor { get; set; }

}

/// <summary>
/// Manages a aws_apprunner_observability_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApprunnerObservabilityConfiguration : TerraformResource
{
    public AwsApprunnerObservabilityConfiguration(string name) : base("aws_apprunner_observability_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The observability_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityConfigurationName is required")]
    [TerraformProperty("observability_configuration_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObservabilityConfigurationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for trace_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TraceConfiguration block(s) allowed")]
    [TerraformProperty("trace_configuration")]
    public TerraformList<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock> TraceConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformProperty("latest")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Latest { get; }

    /// <summary>
    /// The observability_configuration_revision attribute.
    /// </summary>
    [TerraformProperty("observability_configuration_revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ObservabilityConfigurationRevision { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
