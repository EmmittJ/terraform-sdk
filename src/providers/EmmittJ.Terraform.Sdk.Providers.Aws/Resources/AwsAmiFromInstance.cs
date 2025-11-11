using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsAmiFromInstanceEbsBlockDeviceBlock : TerraformBlockBase
{









}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsAmiFromInstanceEphemeralBlockDeviceBlock : TerraformBlockBase
{


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAmiFromInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ami_from_instance resource.
/// </summary>
public partial class AwsAmiFromInstance : TerraformResource
{
    public AwsAmiFromInstance(string name) : base("aws_ami_from_instance", name)
    {
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformProperty("deprecation_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeprecationTime { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The snapshot_without_reboot attribute.
    /// </summary>
    [TerraformProperty("snapshot_without_reboot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SnapshotWithoutReboot { get; set; }

    /// <summary>
    /// The source_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceId is required")]
    [TerraformProperty("source_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceInstanceId { get; set; }

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
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiFromInstanceEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsAmiFromInstanceEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsAmiFromInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Architecture { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformProperty("boot_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootMode { get; }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformProperty("ena_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnaSupport { get; }

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformProperty("hypervisor")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Hypervisor { get; }

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    [TerraformProperty("image_location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageLocation { get; }

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    [TerraformProperty("image_owner_alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageOwnerAlias { get; }

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    [TerraformProperty("image_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageType { get; }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    [TerraformProperty("imds_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImdsSupport { get; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformProperty("kernel_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KernelId { get; }

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    [TerraformProperty("last_launched_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastLaunchedTime { get; }

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    [TerraformProperty("manage_ebs_snapshots")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ManageEbsSnapshots { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Platform { get; }

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    [TerraformProperty("platform_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlatformDetails { get; }

    /// <summary>
    /// The public attribute.
    /// </summary>
    [TerraformProperty("public")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Public { get; }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    [TerraformProperty("ramdisk_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RamdiskId { get; }

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    [TerraformProperty("root_device_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RootDeviceName { get; }

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    [TerraformProperty("root_snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RootSnapshotId { get; }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    [TerraformProperty("sriov_net_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SriovNetSupport { get; }

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    [TerraformProperty("tpm_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TpmSupport { get; }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformProperty("uefi_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UefiData { get; }

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    [TerraformProperty("usage_operation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UsageOperation { get; }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    [TerraformProperty("virtualization_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualizationType { get; }

}
