using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trace_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerObservabilityConfigurationTraceConfigurationBlock
{
    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformPropertyName("vendor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Vendor { get; set; }

}

/// <summary>
/// Manages a aws_apprunner_observability_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApprunnerObservabilityConfiguration : TerraformResource
{
    public AwsApprunnerObservabilityConfiguration(string name) : base("aws_apprunner_observability_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The observability_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityConfigurationName is required")]
    [TerraformPropertyName("observability_configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ObservabilityConfigurationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for trace_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TraceConfiguration block(s) allowed")]
    [TerraformPropertyName("trace_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>>? TraceConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Latest => new TerraformReference(this, "latest");

    /// <summary>
    /// The observability_configuration_revision attribute.
    /// </summary>
    [TerraformPropertyName("observability_configuration_revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ObservabilityConfigurationRevision => new TerraformReference(this, "observability_configuration_revision");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
