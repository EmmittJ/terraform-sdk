using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAmiDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AllowUnsafeFilter { get; set; }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    [TerraformPropertyName("executable_users")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExecutableUsers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    [TerraformPropertyName("include_deprecated")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeDeprecated { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NameRegex { get; set; }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Owners { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    [TerraformPropertyName("uefi_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UefiData { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsAmiDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAmiDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The block_device_mappings attribute.
    /// </summary>
    [TerraformPropertyName("block_device_mappings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> BlockDeviceMappings => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "block_device_mappings");

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    [TerraformPropertyName("boot_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "boot_mode");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    [TerraformPropertyName("deprecation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeprecationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deprecation_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

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
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_id");

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
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The product_codes attribute.
    /// </summary>
    [TerraformPropertyName("product_codes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ProductCodes => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "product_codes");

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
    /// The root_device_type attribute.
    /// </summary>
    [TerraformPropertyName("root_device_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootDeviceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_device_type");

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
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [TerraformPropertyName("state_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> StateReason => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "state_reason");

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    [TerraformPropertyName("tpm_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TpmSupport => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tpm_support");

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
