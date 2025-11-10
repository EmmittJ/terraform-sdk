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
        SetOutput("enable_media_metric_logs");
        SetOutput("enable_sip_logs");
        SetOutput("id");
        SetOutput("region");
        SetOutput("voice_connector_id");
    }

    /// <summary>
    /// The enable_media_metric_logs attribute.
    /// </summary>
    public TerraformProperty<bool> EnableMediaMetricLogs
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_media_metric_logs");
        set => SetProperty("enable_media_metric_logs", value);
    }

    /// <summary>
    /// The enable_sip_logs attribute.
    /// </summary>
    public TerraformProperty<bool> EnableSipLogs
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_sip_logs");
        set => SetProperty("enable_sip_logs", value);
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
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformProperty<string> VoiceConnectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("voice_connector_id");
        set => SetProperty("voice_connector_id", value);
    }

}
