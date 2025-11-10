using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiFromInstanceEbsBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeleteOnTermination => new TerraformReferenceProperty<TerraformProperty<bool>>("", "delete_on_termination");

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceName => new TerraformReferenceProperty<TerraformProperty<string>>("", "device_name");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>("", "encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Iops => new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "outpost_arn");

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotId => new TerraformReferenceProperty<TerraformProperty<string>>("", "snapshot_id");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Throughput => new TerraformReferenceProperty<TerraformProperty<double>>("", "throughput");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VolumeSize => new TerraformReferenceProperty<TerraformProperty<double>>("", "volume_size");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeType => new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_type");

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiFromInstanceEphemeralBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceName => new TerraformReferenceProperty<TerraformProperty<string>>("", "device_name");

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualName => new TerraformReferenceProperty<TerraformProperty<string>>("", "virtual_name");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiFromInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ami_from_instance resource.
/// </summary>
public class AwsAmiFromInstance : TerraformResource
{
    public AwsAmiFromInstance(string name) : base("aws_ami_from_instance", name)
    {
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformPropertyName("deprecation_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeprecationTime { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The snapshot_without_reboot attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_without_reboot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SnapshotWithoutReboot { get; set; }

    /// <summary>
    /// The source_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceId is required")]
    [TerraformPropertyName("source_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceInstanceId { get; set; }

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
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiFromInstanceEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiFromInstanceEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAmiFromInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Architecture => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "architecture");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformPropertyName("boot_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "boot_mode");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformPropertyName("ena_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnaSupport => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ena_support");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformPropertyName("hypervisor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hypervisor => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hypervisor");

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    [TerraformPropertyName("image_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_location");

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    [TerraformPropertyName("image_owner_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageOwnerAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_owner_alias");

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_type");

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    [TerraformPropertyName("imds_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImdsSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "imds_support");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformPropertyName("kernel_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KernelId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kernel_id");

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    [TerraformPropertyName("last_launched_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastLaunchedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_launched_time");

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    [TerraformPropertyName("manage_ebs_snapshots")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ManageEbsSnapshots => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "manage_ebs_snapshots");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Platform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform");

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    [TerraformPropertyName("platform_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_details");

    /// <summary>
    /// The public attribute.
    /// </summary>
    [TerraformPropertyName("public")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Public => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public");

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    [TerraformPropertyName("ramdisk_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RamdiskId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ramdisk_id");

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    [TerraformPropertyName("root_device_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootDeviceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_device_name");

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("root_snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootSnapshotId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_snapshot_id");

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    [TerraformPropertyName("sriov_net_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SriovNetSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sriov_net_support");

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("tpm_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TpmSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tpm_support");

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformPropertyName("uefi_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UefiData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uefi_data");

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    [TerraformPropertyName("usage_operation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UsageOperation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "usage_operation");

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    [TerraformPropertyName("virtualization_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualizationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtualization_type");

}
