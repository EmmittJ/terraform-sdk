using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_cached_iscsi_volume resource.
/// </summary>
public partial class AwsStoragegatewayCachedIscsiVolume : TerraformResource
{
    public AwsStoragegatewayCachedIscsiVolume(string name) : base("aws_storagegateway_cached_iscsi_volume", name)
    {
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformProperty("gateway_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewayArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformProperty("kms_encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnapshotId { get; set; }

    /// <summary>
    /// The source_volume_arn attribute.
    /// </summary>
    [TerraformProperty("source_volume_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceVolumeArn { get; set; }

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
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    [TerraformProperty("target_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetName { get; set; }

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSizeInBytes is required")]
    [TerraformProperty("volume_size_in_bytes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> VolumeSizeInBytes { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The chap_enabled attribute.
    /// </summary>
    [TerraformProperty("chap_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ChapEnabled { get; }

    /// <summary>
    /// The lun_number attribute.
    /// </summary>
    [TerraformProperty("lun_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LunNumber { get; }

    /// <summary>
    /// The network_interface_port attribute.
    /// </summary>
    [TerraformProperty("network_interface_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NetworkInterfacePort { get; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [TerraformProperty("target_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetArn { get; }

    /// <summary>
    /// The volume_arn attribute.
    /// </summary>
    [TerraformProperty("volume_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeArn { get; }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformProperty("volume_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeId { get; }

}
