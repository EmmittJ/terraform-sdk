using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_devicefarm_network_profile resource.
/// </summary>
public partial class AwsDevicefarmNetworkProfile : TerraformResource
{
    public AwsDevicefarmNetworkProfile(string name) : base("aws_devicefarm_network_profile", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    [TerraformProperty("downlink_bandwidth_bits")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DownlinkBandwidthBits { get; set; }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    [TerraformProperty("downlink_delay_ms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DownlinkDelayMs { get; set; }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    [TerraformProperty("downlink_jitter_ms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DownlinkJitterMs { get; set; }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    [TerraformProperty("downlink_loss_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DownlinkLossPercent { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectArn is required")]
    [TerraformProperty("project_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    [TerraformProperty("uplink_bandwidth_bits")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UplinkBandwidthBits { get; set; }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    [TerraformProperty("uplink_delay_ms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UplinkDelayMs { get; set; }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    [TerraformProperty("uplink_jitter_ms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UplinkJitterMs { get; set; }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    [TerraformProperty("uplink_loss_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UplinkLossPercent { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
