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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    [TerraformPropertyName("downlink_bandwidth_bits")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DownlinkBandwidthBits { get; set; }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    [TerraformPropertyName("downlink_delay_ms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DownlinkDelayMs { get; set; }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    [TerraformPropertyName("downlink_jitter_ms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DownlinkJitterMs { get; set; }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    [TerraformPropertyName("downlink_loss_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DownlinkLossPercent { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectArn is required")]
    [TerraformPropertyName("project_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    [TerraformPropertyName("uplink_bandwidth_bits")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UplinkBandwidthBits { get; set; }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    [TerraformPropertyName("uplink_delay_ms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UplinkDelayMs { get; set; }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    [TerraformPropertyName("uplink_jitter_ms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UplinkJitterMs { get; set; }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    [TerraformPropertyName("uplink_loss_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UplinkLossPercent { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
