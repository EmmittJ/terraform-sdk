using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recording_group in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The all_supported attribute.
    /// </summary>
    [TerraformPropertyName("all_supported")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllSupported { get; set; }

    /// <summary>
    /// The include_global_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("include_global_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeGlobalResourceTypes { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformPropertyName("resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ResourceTypes { get; set; }

}

/// <summary>
/// Block type for recording_mode in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingModeBlock : ITerraformBlock
{
    /// <summary>
    /// The recording_frequency attribute.
    /// </summary>
    [TerraformPropertyName("recording_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecordingFrequency { get; set; }

}

/// <summary>
/// Manages a aws_config_configuration_recorder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigConfigurationRecorder : TerraformResource
{
    public AwsConfigConfigurationRecorder(string name) : base("aws_config_configuration_recorder", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// Block for recording_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingGroup block(s) allowed")]
    [TerraformPropertyName("recording_group")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationRecorderRecordingGroupBlock>>? RecordingGroup { get; set; } = new();

    /// <summary>
    /// Block for recording_mode.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingMode block(s) allowed")]
    [TerraformPropertyName("recording_mode")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationRecorderRecordingModeBlock>>? RecordingMode { get; set; } = new();

}
