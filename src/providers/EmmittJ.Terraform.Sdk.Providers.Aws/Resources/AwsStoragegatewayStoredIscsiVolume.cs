using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_stored_iscsi_volume resource.
/// </summary>
public class AwsStoragegatewayStoredIscsiVolume : TerraformResource
{
    public AwsStoragegatewayStoredIscsiVolume(string name) : base("aws_storagegateway_stored_iscsi_volume", name)
    {
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    [TerraformPropertyName("disk_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DiskId { get; set; }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformPropertyName("gateway_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GatewayArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("kms_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformPropertyName("network_interface_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// The preserve_existing_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveExistingData is required")]
    [TerraformPropertyName("preserve_existing_data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> PreserveExistingData { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotId { get; set; }

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
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    [TerraformPropertyName("target_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The chap_enabled attribute.
    /// </summary>
    [TerraformPropertyName("chap_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ChapEnabled => new TerraformReference(this, "chap_enabled");

    /// <summary>
    /// The lun_number attribute.
    /// </summary>
    [TerraformPropertyName("lun_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LunNumber => new TerraformReference(this, "lun_number");

    /// <summary>
    /// The network_interface_port attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NetworkInterfacePort => new TerraformReference(this, "network_interface_port");

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TargetArn => new TerraformReference(this, "target_arn");

    /// <summary>
    /// The volume_attachment_status attribute.
    /// </summary>
    [TerraformPropertyName("volume_attachment_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeAttachmentStatus => new TerraformReference(this, "volume_attachment_status");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeId => new TerraformReference(this, "volume_id");

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("volume_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VolumeSizeInBytes => new TerraformReference(this, "volume_size_in_bytes");

    /// <summary>
    /// The volume_status attribute.
    /// </summary>
    [TerraformPropertyName("volume_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeStatus => new TerraformReference(this, "volume_status");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeType => new TerraformReference(this, "volume_type");

}
