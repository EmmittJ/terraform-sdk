using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_streaming resource.
/// </summary>
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
    public TerraformProperty<double>? DataRetention
    {
        get => GetProperty<TerraformProperty<double>>("data_retention");
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
    public TerraformProperty<HashSet<string>>? StreamingNotificationTargets
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("streaming_notification_targets");
        set => this.WithProperty("streaming_notification_targets", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public TerraformProperty<string>? VoiceConnectorId
    {
        get => GetProperty<TerraformProperty<string>>("voice_connector_id");
        set => this.WithProperty("voice_connector_id", value);
    }

}
