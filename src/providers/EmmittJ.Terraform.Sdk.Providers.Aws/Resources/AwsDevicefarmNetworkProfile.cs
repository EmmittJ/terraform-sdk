using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_devicefarm_network_profile resource.
/// </summary>
public class AwsDevicefarmNetworkProfile : TerraformResource
{
    public AwsDevicefarmNetworkProfile(string name) : base("aws_devicefarm_network_profile", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    [TerraformPropertyName("downlink_bandwidth_bits")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DownlinkBandwidthBits { get; set; }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    [TerraformPropertyName("downlink_delay_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DownlinkDelayMs { get; set; }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    [TerraformPropertyName("downlink_jitter_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DownlinkJitterMs { get; set; }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    [TerraformPropertyName("downlink_loss_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DownlinkLossPercent { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectArn is required")]
    [TerraformPropertyName("project_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProjectArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    [TerraformPropertyName("uplink_bandwidth_bits")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UplinkBandwidthBits { get; set; }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    [TerraformPropertyName("uplink_delay_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UplinkDelayMs { get; set; }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    [TerraformPropertyName("uplink_jitter_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UplinkJitterMs { get; set; }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    [TerraformPropertyName("uplink_loss_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UplinkLossPercent { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
