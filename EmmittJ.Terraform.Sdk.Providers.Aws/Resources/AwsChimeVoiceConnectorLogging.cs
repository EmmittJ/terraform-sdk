using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_logging resource.
/// </summary>
public class AwsChimeVoiceConnectorLogging : TerraformResource
{
    public AwsChimeVoiceConnectorLogging(string name) : base("aws_chime_voice_connector_logging", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enable_media_metric_logs attribute.
    /// </summary>
    public bool? EnableMediaMetricLogs
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_media_metric_logs")?.Value;
        set => this.WithProperty("enable_media_metric_logs", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_sip_logs attribute.
    /// </summary>
    public bool? EnableSipLogs
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_sip_logs")?.Value;
        set => this.WithProperty("enable_sip_logs", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The voice_connector_id attribute.
    /// </summary>
    public string? VoiceConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_connector_id")?.Value;
        set => this.WithProperty("voice_connector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
