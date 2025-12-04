using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_insights_configuration in AwsChimeVoiceConnectorStreaming.
/// Nesting mode: list
/// </summary>
public class AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_insights_configuration";

    /// <summary>
    /// The configuration_arn attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("configuration_arn");
        set => SetArgument("configuration_arn", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}


/// <summary>
/// Represents a aws_chime_voice_connector_streaming Terraform resource.
/// Manages a aws_chime_voice_connector_streaming resource.
/// </summary>
public partial class AwsChimeVoiceConnectorStreaming(string name) : TerraformResource("aws_chime_voice_connector_streaming", name)
{
    /// <summary>
    /// The data_retention attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRetention is required")]
    public required TerraformValue<double> DataRetention
    {
        get => GetRequiredArgument<TerraformValue<double>>("data_retention");
        set => SetArgument("data_retention", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    public TerraformSet<string>? StreamingNotificationTargets
    {
        get => GetArgument<TerraformSet<string>>("streaming_notification_targets");
        set => SetArgument("streaming_notification_targets", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformValue<string> VoiceConnectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("voice_connector_id");
        set => SetArgument("voice_connector_id", value);
    }

    /// <summary>
    /// MediaInsightsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaInsightsConfiguration block(s) allowed")]
    public TerraformList<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>? MediaInsightsConfiguration
    {
        get => GetArgument<TerraformList<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>>("media_insights_configuration");
        set => SetArgument("media_insights_configuration", value);
    }

}
