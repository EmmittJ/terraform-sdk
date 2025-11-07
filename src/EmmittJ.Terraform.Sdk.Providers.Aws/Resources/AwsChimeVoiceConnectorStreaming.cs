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
    public TerraformLiteralProperty<double>? DataRetention
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_retention");
        set => this.WithProperty("data_retention", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? StreamingNotificationTargets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("streaming_notification_targets");
        set => this.WithProperty("streaming_notification_targets", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VoiceConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_connector_id");
        set => this.WithProperty("voice_connector_id", value);
    }

}
