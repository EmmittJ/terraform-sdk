using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsAmiDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAmiDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ami.
/// </summary>
public partial class AwsAmiDataSource : TerraformDataSource
{
    public AwsAmiDataSource(string name) : base("aws_ami", name)
    {
    }

    /// <summary>
    /// The allow_unsafe_filter attribute.
    /// </summary>
    [TerraformProperty("allow_unsafe_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowUnsafeFilter { get; set; }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    [TerraformProperty("executable_users")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExecutableUsers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    [TerraformProperty("include_deprecated")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeDeprecated { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformProperty("name_regex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformProperty("owners")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Owners { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformProperty("uefi_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UefiData { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsAmiDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsAmiDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Architecture { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    [TerraformProperty("block_device_mappings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> BlockDeviceMappings { get; }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformProperty("boot_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootMode { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformProperty("deprecation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeprecationTime { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    [TerraformProperty("ena_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnaSupport { get; }

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    [TerraformProperty("hypervisor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hypervisor { get; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageId { get; }

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    [TerraformProperty("image_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageLocation { get; }

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
    /// The imds_support attribute.
    /// </summary>
    [TerraformProperty("imds_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImdsSupport { get; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformProperty("kernel_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KernelId { get; }

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    [TerraformProperty("last_launched_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastLaunchedTime { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

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
    /// The product_codes attribute.
    /// </summary>
    [TerraformProperty("product_codes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ProductCodes { get; }

    /// <summary>
    /// The public attribute.
    /// </summary>
    [TerraformProperty("public")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Public { get; }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    [TerraformProperty("ramdisk_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RamdiskId { get; }

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    [TerraformProperty("root_device_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootDeviceName { get; }

    /// <summary>
    /// The root_device_type attribute.
    /// </summary>
    [TerraformProperty("root_device_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootDeviceType { get; }

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    [TerraformProperty("root_snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootSnapshotId { get; }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    [TerraformProperty("sriov_net_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SriovNetSupport { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [TerraformProperty("state_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> StateReason { get; }

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    [TerraformProperty("tpm_support")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TpmSupport { get; }

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    [TerraformProperty("usage_operation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UsageOperation { get; }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    [TerraformProperty("virtualization_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualizationType { get; }

}
