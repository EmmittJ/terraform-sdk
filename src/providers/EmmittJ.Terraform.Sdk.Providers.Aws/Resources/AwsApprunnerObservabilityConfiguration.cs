using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trace_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerObservabilityConfigurationTraceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformPropertyName("vendor")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Vendor { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The observability_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityConfigurationName is required")]
    [TerraformPropertyName("observability_configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ObservabilityConfigurationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for trace_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TraceConfiguration block(s) allowed")]
    [TerraformPropertyName("trace_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>>? TraceConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Latest => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "latest");

    /// <summary>
    /// The observability_configuration_revision attribute.
    /// </summary>
    [TerraformPropertyName("observability_configuration_revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ObservabilityConfigurationRevision => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "observability_configuration_revision");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
