using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_logging resource.
/// </summary>
public partial class AwsChimeVoiceConnectorLogging : TerraformResource
{
    public AwsChimeVoiceConnectorLogging(string name) : base("aws_chime_voice_connector_logging", name)
    {
    }

    /// <summary>
    /// The enable_media_metric_logs attribute.
    /// </summary>
    [TerraformProperty("enable_media_metric_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMediaMetricLogs { get; set; }

    /// <summary>
    /// The enable_sip_logs attribute.
    /// </summary>
    [TerraformProperty("enable_sip_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSipLogs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    [TerraformProperty("voice_connector_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VoiceConnectorId { get; set; }

}
