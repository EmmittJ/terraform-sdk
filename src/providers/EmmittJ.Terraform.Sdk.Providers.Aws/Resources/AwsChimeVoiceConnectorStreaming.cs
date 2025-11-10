using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_insights_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("configuration_arn");
        set => WithProperty("configuration_arn", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => WithProperty("disabled", value);
    }

}

/// <summary>
/// Manages a aws_chime_voice_connector_streaming resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsChimeVoiceConnectorStreaming : TerraformResource
{
    public AwsChimeVoiceConnectorStreaming(string name) : base("aws_chime_voice_connector_streaming", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The data_retention attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRetention is required")]
    public required TerraformProperty<double> DataRetention
    {
        get => GetRequiredProperty<TerraformProperty<double>>("data_retention");
        set => this.WithProperty("data_retention", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? StreamingNotificationTargets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("streaming_notification_targets");
        set => this.WithProperty("streaming_notification_targets", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformProperty<string> VoiceConnectorId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("voice_connector_id");
        set => this.WithProperty("voice_connector_id", value);
    }

    /// <summary>
    /// Block for media_insights_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaInsightsConfiguration block(s) allowed")]
    public List<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>? MediaInsightsConfiguration
    {
        get => GetProperty<List<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>>("media_insights_configuration");
        set => this.WithProperty("media_insights_configuration", value);
    }

}
