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
    public TerraformProperty<bool>? EnableMediaMetricLogs
    {
        get => GetProperty<TerraformProperty<bool>>("enable_media_metric_logs");
        set => this.WithProperty("enable_media_metric_logs", value);
    }

    /// <summary>
    /// The enable_sip_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSipLogs
    {
        get => GetProperty<TerraformProperty<bool>>("enable_sip_logs");
        set => this.WithProperty("enable_sip_logs", value);
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
    /// The voice_connector_id attribute.
    /// </summary>
    public TerraformProperty<string>? VoiceConnectorId
    {
        get => GetProperty<TerraformProperty<string>>("voice_connector_id");
        set => this.WithProperty("voice_connector_id", value);
    }

}
