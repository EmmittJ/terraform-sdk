using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiEbsBlockDeviceBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Iops { get; set; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutpostArn { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotId { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Throughput { get; set; } = default!;

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> VolumeSize { get; set; } = default!;

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VolumeType { get; set; }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiEphemeralBlockDeviceBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualName is required")]
    [TerraformPropertyName("virtual_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiTimeoutsBlock
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
/// Manages a aws_ami resource.
/// </summary>
public class AwsAmi : TerraformResource
{
    public AwsAmi(string name) : base("aws_ami", name)
    {
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformPropertyName("boot_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BootMode { get; set; }

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
    /// The ena_support attribute.
    /// </summary>
    [TerraformPropertyName("ena_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnaSupport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    [TerraformPropertyName("image_location")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ImageLocation { get; set; } = default!;

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    [TerraformPropertyName("imds_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImdsSupport { get; set; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformPropertyName("kernel_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KernelId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    [TerraformPropertyName("ramdisk_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RamdiskId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    [TerraformPropertyName("root_device_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RootDeviceName { get; set; }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    [TerraformPropertyName("sriov_net_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SriovNetSupport { get; set; }

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
    /// The tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("tpm_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TpmSupport { get; set; }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformPropertyName("uefi_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UefiData { get; set; }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    [TerraformPropertyName("virtualization_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualizationType { get; set; }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAmiTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformPropertyName("hypervisor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hypervisor => new TerraformReference(this, "hypervisor");

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
    /// The root_snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("root_snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootSnapshotId => new TerraformReference(this, "root_snapshot_id");

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    [TerraformPropertyName("usage_operation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UsageOperation => new TerraformReference(this, "usage_operation");

}
