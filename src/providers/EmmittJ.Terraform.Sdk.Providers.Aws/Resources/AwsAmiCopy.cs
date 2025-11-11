using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiCopyEbsBlockDeviceBlock
{









}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiCopyEphemeralBlockDeviceBlock
{


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiCopyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ami_copy resource.
/// </summary>
public class AwsAmiCopy : TerraformResource
{
    public AwsAmiCopy(string name) : base("aws_ami_copy", name)
    {
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformPropertyName("deprecation_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeprecationTime { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("destination_outpost_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationOutpostArn { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Encrypted { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_ami_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAmiId is required")]
    [TerraformPropertyName("source_ami_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceAmiId { get; set; }

    /// <summary>
    /// The source_ami_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAmiRegion is required")]
    [TerraformPropertyName("source_ami_region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceAmiRegion { get; set; }

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
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiCopyEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiCopyEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAmiCopyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Architecture => new TerraformReference(this, "architecture");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformPropertyName("boot_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootMode => new TerraformReference(this, "boot_mode");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformPropertyName("ena_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnaSupport => new TerraformReference(this, "ena_support");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformPropertyName("hypervisor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hypervisor => new TerraformReference(this, "hypervisor");

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    [TerraformPropertyName("image_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageLocation => new TerraformReference(this, "image_location");

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    [TerraformPropertyName("image_owner_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageOwnerAlias => new TerraformReference(this, "image_owner_alias");

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageType => new TerraformReference(this, "image_type");

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    [TerraformPropertyName("imds_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImdsSupport => new TerraformReference(this, "imds_support");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformPropertyName("kernel_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KernelId => new TerraformReference(this, "kernel_id");

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    [TerraformPropertyName("last_launched_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastLaunchedTime => new TerraformReference(this, "last_launched_time");

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    [TerraformPropertyName("manage_ebs_snapshots")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ManageEbsSnapshots => new TerraformReference(this, "manage_ebs_snapshots");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    [TerraformPropertyName("platform_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformDetails => new TerraformReference(this, "platform_details");

    /// <summary>
    /// The public attribute.
    /// </summary>
    [TerraformPropertyName("public")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Public => new TerraformReference(this, "public");

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    [TerraformPropertyName("ramdisk_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RamdiskId => new TerraformReference(this, "ramdisk_id");

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    [TerraformPropertyName("root_device_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootDeviceName => new TerraformReference(this, "root_device_name");

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("root_snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootSnapshotId => new TerraformReference(this, "root_snapshot_id");

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    [TerraformPropertyName("sriov_net_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SriovNetSupport => new TerraformReference(this, "sriov_net_support");

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("tpm_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TpmSupport => new TerraformReference(this, "tpm_support");

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformPropertyName("uefi_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UefiData => new TerraformReference(this, "uefi_data");

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    [TerraformPropertyName("usage_operation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UsageOperation => new TerraformReference(this, "usage_operation");

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    [TerraformPropertyName("virtualization_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualizationType => new TerraformReference(this, "virtualization_type");

}
