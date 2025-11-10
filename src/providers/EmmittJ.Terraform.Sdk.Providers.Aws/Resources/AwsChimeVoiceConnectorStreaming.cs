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
        set => SetProperty("configuration_arn", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        set => SetProperty("disabled", value);
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
        SetOutput("data_retention");
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("streaming_notification_targets");
        SetOutput("voice_connector_id");
    }

    /// <summary>
    /// The data_retention attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRetention is required")]
    public required TerraformProperty<double> DataRetention
    {
        get => GetRequiredOutput<TerraformProperty<double>>("data_retention");
        set => SetProperty("data_retention", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> StreamingNotificationTargets
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("streaming_notification_targets");
        set => SetProperty("streaming_notification_targets", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformProperty<string> VoiceConnectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("voice_connector_id");
        set => SetProperty("voice_connector_id", value);
    }

    /// <summary>
    /// Block for media_insights_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaInsightsConfiguration block(s) allowed")]
    public List<AwsChimeVoiceConnectorStreamingMediaInsightsConfigurationBlock>? MediaInsightsConfiguration
    {
        set => SetProperty("media_insights_configuration", value);
    }

}
