using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsIvsRecordingConfigurationDestinationConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for thumbnail_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsIvsRecordingConfigurationThumbnailConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The recording_mode attribute.
    /// </summary>
    [TerraformProperty("recording_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RecordingMode { get; set; }

    /// <summary>
    /// The target_interval_seconds attribute.
    /// </summary>
    [TerraformProperty("target_interval_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TargetIntervalSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsIvsRecordingConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ivs_recording_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIvsRecordingConfiguration : TerraformResource
{
    public AwsIvsRecordingConfiguration(string name) : base("aws_ivs_recording_configuration", name)
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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recording_reconnect_window_seconds attribute.
    /// </summary>
    [TerraformProperty("recording_reconnect_window_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RecordingReconnectWindowSeconds { get; set; }

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
    /// Block for destination_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfiguration block(s) allowed")]
    [TerraformProperty("destination_configuration")]
    public partial TerraformList<TerraformBlock<AwsIvsRecordingConfigurationDestinationConfigurationBlock>>? DestinationConfiguration { get; set; }

    /// <summary>
    /// Block for thumbnail_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfiguration block(s) allowed")]
    [TerraformProperty("thumbnail_configuration")]
    public partial TerraformList<TerraformBlock<AwsIvsRecordingConfigurationThumbnailConfigurationBlock>>? ThumbnailConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsIvsRecordingConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
