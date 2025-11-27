using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_chime_voice_connector_logging Terraform resource.
/// Manages a aws_chime_voice_connector_logging resource.
/// </summary>
public partial class AwsChimeVoiceConnectorLogging(string name) : TerraformResource("aws_chime_voice_connector_logging", name)
{
    /// <summary>
    /// The enable_media_metric_logs attribute.
    /// </summary>
    public TerraformValue<bool>? EnableMediaMetricLogs
    {
        get => new TerraformReference<bool>(this, "enable_media_metric_logs");
        set => SetArgument("enable_media_metric_logs", value);
    }

    /// <summary>
    /// The enable_sip_logs attribute.
    /// </summary>
    public TerraformValue<bool>? EnableSipLogs
    {
        get => new TerraformReference<bool>(this, "enable_sip_logs");
        set => SetArgument("enable_sip_logs", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformValue<string> VoiceConnectorId
    {
        get => new TerraformReference<string>(this, "voice_connector_id");
        set => SetArgument("voice_connector_id", value);
    }

}
