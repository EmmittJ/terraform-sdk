using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recording_group in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigConfigurationRecorderRecordingGroupBlock() : TerraformBlock("recording_group")
{
    /// <summary>
    /// The all_supported attribute.
    /// </summary>
    [TerraformProperty("all_supported")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllSupported { get; set; }

    /// <summary>
    /// The include_global_resource_types attribute.
    /// </summary>
    [TerraformProperty("include_global_resource_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeGlobalResourceTypes { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformProperty("resource_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ResourceTypes { get; set; }

}

/// <summary>
/// Block type for recording_mode in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigConfigurationRecorderRecordingModeBlock() : TerraformBlock("recording_mode")
{
    /// <summary>
    /// The recording_frequency attribute.
    /// </summary>
    [TerraformProperty("recording_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RecordingFrequency { get; set; }

}

/// <summary>
/// Manages a aws_config_configuration_recorder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConfigConfigurationRecorder : TerraformResource
{
    public AwsConfigConfigurationRecorder(string name) : base("aws_config_configuration_recorder", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// Block for recording_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingGroup block(s) allowed")]
    [TerraformProperty("recording_group")]
    public TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlock> RecordingGroup { get; set; } = new();

    /// <summary>
    /// Block for recording_mode.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingMode block(s) allowed")]
    [TerraformProperty("recording_mode")]
    public TerraformList<AwsConfigConfigurationRecorderRecordingModeBlock> RecordingMode { get; set; } = new();

}
