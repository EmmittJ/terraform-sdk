using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recording_group in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingGroupBlock
{
    /// <summary>
    /// The all_supported attribute.
    /// </summary>
    [TerraformPropertyName("all_supported")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllSupported { get; set; }

    /// <summary>
    /// The include_global_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("include_global_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeGlobalResourceTypes { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformPropertyName("resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ResourceTypes { get; set; }

}

/// <summary>
/// Block type for recording_mode in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingModeBlock
{
    /// <summary>
    /// The recording_frequency attribute.
    /// </summary>
    [TerraformPropertyName("recording_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecordingFrequency { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// Block for recording_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingGroup block(s) allowed")]
    [TerraformPropertyName("recording_group")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationRecorderRecordingGroupBlock>>? RecordingGroup { get; set; }

    /// <summary>
    /// Block for recording_mode.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingMode block(s) allowed")]
    [TerraformPropertyName("recording_mode")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationRecorderRecordingModeBlock>>? RecordingMode { get; set; }

}
