using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsAmiEbsBlockDeviceBlock() : TerraformBlock("ebs_block_device")
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Iops { get; set; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutpostArn { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnapshotId { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VolumeType { get; set; }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsAmiEphemeralBlockDeviceBlock() : TerraformBlock("ephemeral_block_device")
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualName is required")]
    [TerraformProperty("virtual_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAmiTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ami resource.
/// </summary>
public partial class AwsAmi : TerraformResource
{
    public AwsAmi(string name) : base("aws_ami", name)
    {
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformProperty("boot_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BootMode { get; set; }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformProperty("deprecation_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeprecationTime { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformProperty("ena_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnaSupport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    [TerraformProperty("image_location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ImageLocation { get; set; }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    [TerraformProperty("imds_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImdsSupport { get; set; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformProperty("kernel_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KernelId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    [TerraformProperty("ramdisk_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RamdiskId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    [TerraformProperty("root_device_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RootDeviceName { get; set; }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    [TerraformProperty("sriov_net_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SriovNetSupport { get; set; }

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
    /// The tpm_support attribute.
    /// </summary>
    [TerraformProperty("tpm_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TpmSupport { get; set; }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformProperty("uefi_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UefiData { get; set; }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    [TerraformProperty("virtualization_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualizationType { get; set; }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    public TerraformSet<AwsAmiEbsBlockDeviceBlock> EbsBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    public TerraformSet<AwsAmiEphemeralBlockDeviceBlock> EphemeralBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsAmiTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformProperty("hypervisor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hypervisor { get; }

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    [TerraformProperty("image_owner_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageOwnerAlias { get; }

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    [TerraformProperty("image_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageType { get; }

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    [TerraformProperty("last_launched_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastLaunchedTime { get; }

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    [TerraformProperty("manage_ebs_snapshots")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ManageEbsSnapshots { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Platform { get; }

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    [TerraformProperty("platform_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformDetails { get; }

    /// <summary>
    /// The public attribute.
    /// </summary>
    [TerraformProperty("public")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Public { get; }

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    [TerraformProperty("root_snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootSnapshotId { get; }

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    [TerraformProperty("usage_operation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UsageOperation { get; }

}
