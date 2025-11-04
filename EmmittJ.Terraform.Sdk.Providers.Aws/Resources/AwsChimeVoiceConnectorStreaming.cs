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
    public double? DataRetention
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_retention")?.Value;
        set => this.WithProperty("data_retention", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The streaming_notification_targets attribute.
    /// </summary>
    public HashSet<string>? StreamingNotificationTargets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("streaming_notification_targets")?.Value;
        set => this.WithProperty("streaming_notification_targets", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public string? VoiceConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_connector_id")?.Value;
        set => this.WithProperty("voice_connector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
