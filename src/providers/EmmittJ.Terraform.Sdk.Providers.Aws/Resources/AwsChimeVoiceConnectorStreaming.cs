using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_insights_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The configuration_arn attribute.
    /// </summary>
    [TerraformProperty("configuration_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationArn { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

}

/// <summary>
/// Manages a aws_chime_voice_connector_streaming resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsChimeVoiceConnectorStreaming : TerraformResource
{
    public AwsChimeVoiceConnectorStreaming(string name) : base("aws_chime_voice_connector_streaming", name)
    {
    }

    /// <summary>
    /// The data_retention attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRetention is required")]
    [TerraformProperty("data_retention")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DataRetention { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    [TerraformProperty("streaming_notification_targets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? StreamingNotificationTargets { get; set; }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    [TerraformProperty("voice_connector_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VoiceConnectorId { get; set; }

    /// <summary>
    /// Block for media_insights_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaInsightsConfiguration block(s) allowed")]
    [TerraformProperty("media_insights_configuration")]
    public partial TerraformList<TerraformBlock<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>>? MediaInsightsConfiguration { get; set; }

}
