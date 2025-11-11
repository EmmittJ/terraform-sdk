using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAmiDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ami.
/// </summary>
public class AwsAmiDataSource : TerraformDataSource
{
    public AwsAmiDataSource(string name) : base("aws_ami", name)
    {
    }

    /// <summary>
    /// The allow_unsafe_filter attribute.
    /// </summary>
    [TerraformPropertyName("allow_unsafe_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowUnsafeFilter { get; set; }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    [TerraformPropertyName("executable_users")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExecutableUsers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    [TerraformPropertyName("include_deprecated")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeDeprecated { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Owners { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformPropertyName("uefi_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UefiData { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsAmiDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAmiDataSourceTimeoutsBlock>? Timeouts { get; set; }

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
    /// The block_device_mappings attribute.
    /// </summary>
    [TerraformPropertyName("block_device_mappings")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> BlockDeviceMappings => new TerraformReference(this, "block_device_mappings");

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformPropertyName("boot_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootMode => new TerraformReference(this, "boot_mode");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformPropertyName("deprecation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeprecationTime => new TerraformReference(this, "deprecation_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

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
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageId => new TerraformReference(this, "image_id");

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
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

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
    /// The product_codes attribute.
    /// </summary>
    [TerraformPropertyName("product_codes")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> ProductCodes => new TerraformReference(this, "product_codes");

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
    /// The root_device_type attribute.
    /// </summary>
    [TerraformPropertyName("root_device_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootDeviceType => new TerraformReference(this, "root_device_type");

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
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [TerraformPropertyName("state_reason")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> StateReason => new TerraformReference(this, "state_reason");

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("tpm_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TpmSupport => new TerraformReference(this, "tpm_support");

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
