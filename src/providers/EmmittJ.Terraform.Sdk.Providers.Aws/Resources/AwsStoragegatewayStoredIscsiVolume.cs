using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_stored_iscsi_volume resource.
/// </summary>
public partial class AwsStoragegatewayStoredIscsiVolume : TerraformResource
{
    public AwsStoragegatewayStoredIscsiVolume(string name) : base("aws_storagegateway_stored_iscsi_volume", name)
    {
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    [TerraformProperty("disk_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DiskId { get; set; }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformProperty("gateway_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GatewayArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformProperty("kms_encrypted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// The preserve_existing_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveExistingData is required")]
    [TerraformProperty("preserve_existing_data")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> PreserveExistingData { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    [TerraformProperty("target_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The chap_enabled attribute.
    /// </summary>
    [TerraformProperty("chap_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ChapEnabled { get; }

    /// <summary>
    /// The lun_number attribute.
    /// </summary>
    [TerraformProperty("lun_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LunNumber { get; }

    /// <summary>
    /// The network_interface_port attribute.
    /// </summary>
    [TerraformProperty("network_interface_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NetworkInterfacePort { get; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [TerraformProperty("target_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TargetArn { get; }

    /// <summary>
    /// The volume_attachment_status attribute.
    /// </summary>
    [TerraformProperty("volume_attachment_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VolumeAttachmentStatus { get; }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformProperty("volume_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VolumeId { get; }

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("volume_size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> VolumeSizeInBytes { get; }

    /// <summary>
    /// The volume_status attribute.
    /// </summary>
    [TerraformProperty("volume_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VolumeStatus { get; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VolumeType { get; }

}
