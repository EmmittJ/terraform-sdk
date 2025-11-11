using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_insights_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock
{
    /// <summary>
    /// The configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationArn { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

}

/// <summary>
/// Manages a aws_chime_voice_connector_streaming resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsChimeVoiceConnectorStreaming : TerraformResource
{
    public AwsChimeVoiceConnectorStreaming(string name) : base("aws_chime_voice_connector_streaming", name)
    {
    }

    /// <summary>
    /// The data_retention attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRetention is required")]
    [TerraformPropertyName("data_retention")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DataRetention { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    [TerraformPropertyName("streaming_notification_targets")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? StreamingNotificationTargets { get; set; }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    [TerraformPropertyName("voice_connector_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VoiceConnectorId { get; set; }

    /// <summary>
    /// Block for media_insights_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaInsightsConfiguration block(s) allowed")]
    [TerraformPropertyName("media_insights_configuration")]
    public TerraformList<TerraformBlock<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>>? MediaInsightsConfiguration { get; set; }

}
