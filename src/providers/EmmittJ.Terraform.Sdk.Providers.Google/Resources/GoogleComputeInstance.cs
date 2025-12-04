using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_machine_features";

    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    public TerraformValue<bool>? EnableNestedVirtualization
    {
        get => GetArgument<TerraformValue<bool>>("enable_nested_virtualization");
        set => SetArgument("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Whether to enable UEFI networking for the instance.
    /// </summary>
    public TerraformValue<bool>? EnableUefiNetworking
    {
        get => GetArgument<TerraformValue<bool>>("enable_uefi_networking");
        set => SetArgument("enable_uefi_networking", value);
    }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    public TerraformValue<string>? PerformanceMonitoringUnit
    {
        get => GetArgument<TerraformValue<string>>("performance_monitoring_unit");
        set => SetArgument("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    public TerraformValue<double>? ThreadsPerCore
    {
        get => GetArgument<TerraformValue<double>>("threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TurboMode
    {
        get => GetArgument<TerraformValue<string>>("turbo_mode");
        set => SetArgument("turbo_mode", value);
    }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    public TerraformValue<double>? VisibleCoreCount
    {
        get => GetArgument<TerraformValue<double>>("visible_core_count");
        set => SetArgument("visible_core_count", value);
    }

}


/// <summary>
/// Block type for attached_disk in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceAttachedDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attached_disk";

    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionKeyRaw
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_key_raw");
        set => SetArgument("disk_encryption_key_raw", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionKeyRsa
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_key_rsa");
        set => SetArgument("disk_encryption_key_rsa", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.
    /// </summary>
    public TerraformValue<string> DiskEncryptionKeySha256
        => AsReference("disk_encryption_key_sha256");

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    public TerraformValue<string>? DiskEncryptionServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_service_account");
        set => SetArgument("disk_encryption_service_account", value);
    }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    public TerraformValue<bool>? ForceAttach
    {
        get => GetArgument<TerraformValue<bool>>("force_attach");
        set => SetArgument("force_attach", value);
    }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for boot_disk in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceBootDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_disk";

    /// <summary>
    /// Whether the disk will be auto-deleted when the instance is deleted.
    /// </summary>
    public TerraformValue<bool>? AutoDelete
    {
        get => GetArgument<TerraformValue<bool>>("auto_delete");
        set => SetArgument("auto_delete", value);
    }

    /// <summary>
    /// Name with which attached disk will be accessible under /dev/disk/by-id/
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionKeyRaw
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_key_raw");
        set => SetArgument("disk_encryption_key_raw", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionKeyRsa
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_key_rsa");
        set => SetArgument("disk_encryption_key_rsa", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.
    /// </summary>
    public TerraformValue<string> DiskEncryptionKeySha256
        => AsReference("disk_encryption_key_sha256");

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    public TerraformValue<string>? DiskEncryptionServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_service_account");
        set => SetArgument("disk_encryption_service_account", value);
    }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    public TerraformValue<bool>? ForceAttach
    {
        get => GetArgument<TerraformValue<bool>>("force_attach");
        set => SetArgument("force_attach", value);
    }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    public TerraformList<string>? GuestOsFeatures
    {
        get => GetArgument<TerraformList<string>>("guest_os_features");
        set => SetArgument("guest_os_features", value);
    }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is shared with attached_disk and only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    public TerraformValue<string>? InterfaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// InitializeParams block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitializeParams block(s) allowed")]
    public TerraformList<GoogleComputeInstanceBootDiskBlockInitializeParamsBlock>? InitializeParams
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceBootDiskBlockInitializeParamsBlock>>("initialize_params");
        set => SetArgument("initialize_params", value);
    }

}

/// <summary>
/// Block type for initialize_params in GoogleComputeInstanceBootDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceBootDiskBlockInitializeParamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initialize_params";

    /// <summary>
    /// The architecture of the disk. One of &amp;quot;X86_64&amp;quot; or &amp;quot;ARM64&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Architecture
    {
        get => GetArgument<TerraformValue<string>>("architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// A flag to enable confidential compute mode on boot disk
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialCompute
    {
        get => GetArgument<TerraformValue<bool>>("enable_confidential_compute");
        set => SetArgument("enable_confidential_compute", value);
    }

    /// <summary>
    /// The image from which this disk was initialised.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// A set of key/value label pairs assigned to the disk.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle.
    /// </summary>
    public TerraformValue<double>? ProvisionedIops
    {
        get => GetArgument<TerraformValue<double>>("provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput mb per second that the disk can handle.
    /// </summary>
    public TerraformValue<double>? ProvisionedThroughput
    {
        get => GetArgument<TerraformValue<double>>("provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance&#39;s boot disk. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string>? ResourcePolicies
    {
        get => GetArgument<TerraformList<string>>("resource_policies");
        set => SetArgument("resource_policies", value);
    }

    /// <summary>
    /// The size of the image in gigabytes.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The snapshot from which this disk was initialised.
    /// </summary>
    public TerraformValue<string>? Snapshot
    {
        get => GetArgument<TerraformValue<string>>("snapshot");
        set => SetArgument("snapshot", value);
    }

    /// <summary>
    /// The URL of the storage pool in which the new disk is created
    /// </summary>
    public TerraformValue<string>? StoragePool
    {
        get => GetArgument<TerraformValue<string>>("storage_pool");
        set => SetArgument("storage_pool", value);
    }

    /// <summary>
    /// The Google Compute Engine disk type. Such as pd-standard, pd-ssd or pd-balanced.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// SourceImageEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeInstanceBootDiskBlockInitializeParamsBlockSourceImageEncryptionKeyBlock>? SourceImageEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceBootDiskBlockInitializeParamsBlockSourceImageEncryptionKeyBlock>>("source_image_encryption_key");
        set => SetArgument("source_image_encryption_key", value);
    }

    /// <summary>
    /// SourceSnapshotEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeInstanceBootDiskBlockInitializeParamsBlockSourceSnapshotEncryptionKeyBlock>? SourceSnapshotEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceBootDiskBlockInitializeParamsBlockSourceSnapshotEncryptionKeyBlock>>("source_snapshot_encryption_key");
        set => SetArgument("source_snapshot_encryption_key", value);
    }

}

/// <summary>
/// Block type for source_image_encryption_key in GoogleComputeInstanceBootDiskBlockInitializeParamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceBootDiskBlockInitializeParamsBlockSourceImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_encryption_key";

    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => GetArgument<TerraformValue<string>>("raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

    /// <summary>
    /// The SHA256 hash of the encryption key used to encrypt this disk.
    /// </summary>
    public TerraformValue<string> Sha256
        => AsReference("sha256");

}

/// <summary>
/// Block type for source_snapshot_encryption_key in GoogleComputeInstanceBootDiskBlockInitializeParamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceBootDiskBlockInitializeParamsBlockSourceSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_snapshot_encryption_key";

    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => GetArgument<TerraformValue<string>>("raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

    /// <summary>
    /// The SHA256 hash of the encryption key used to encrypt this disk.
    /// </summary>
    public TerraformValue<string> Sha256
        => AsReference("sha256");

}


/// <summary>
/// Block type for confidential_instance_config in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceConfidentialInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_instance_config";

    /// <summary>
    /// 
    /// 								The confidential computing technology the instance uses.
    /// 								SEV is an AMD feature. TDX is an Intel feature. One of the following
    /// 								values is required: SEV, SEV_SNP, TDX. If SEV_SNP, min_cpu_platform =
    /// 								&amp;quot;AMD Milan&amp;quot; is currently required.
    /// </summary>
    public TerraformValue<string>? ConfidentialInstanceType
    {
        get => GetArgument<TerraformValue<string>>("confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialCompute
    {
        get => GetArgument<TerraformValue<bool>>("enable_confidential_compute");
        set => SetArgument("enable_confidential_compute", value);
    }

}


/// <summary>
/// Block type for guest_accelerator in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGuestAcceleratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_accelerator";

    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The accelerator type resource exposed to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for instance_encryption_key in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceInstanceEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_encryption_key";

    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// The SHA256 hash of the customer&#39;s encryption key.
    /// </summary>
    public TerraformValue<string> Sha256
        => AsReference("sha256");

}


/// <summary>
/// Block type for network_interface in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    public TerraformValue<double>? InternalIpv6PrefixLength
    {
        get => GetArgument<TerraformValue<double>>("internal_ipv6_prefix_length");
        set => SetArgument("internal_ipv6_prefix_length", value);
    }

    /// <summary>
    /// One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.
    /// </summary>
    public TerraformValue<string> Ipv6AccessType
        => AsReference("ipv6_access_type");

    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    public TerraformValue<string>? Ipv6Address
    {
        get => GetArgument<TerraformValue<string>>("ipv6_address");
        set => SetArgument("ipv6_address", value);
    }

    /// <summary>
    /// The name of the interface
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The name or self_link of the network attached to this interface.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.
    /// </summary>
    public TerraformValue<string>? NetworkAttachment
    {
        get => GetArgument<TerraformValue<string>>("network_attachment");
        set => SetArgument("network_attachment", value);
    }

    /// <summary>
    /// The private IP address assigned to the instance.
    /// </summary>
    public TerraformValue<string>? NetworkIp
    {
        get => GetArgument<TerraformValue<string>>("network_ip");
        set => SetArgument("network_ip", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, IDPF, MRDMA, and IRDMA
    /// </summary>
    public TerraformValue<string>? NicType
    {
        get => GetArgument<TerraformValue<string>>("nic_type");
        set => SetArgument("nic_type", value);
    }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    public TerraformValue<double>? QueueCount
    {
        get => GetArgument<TerraformValue<double>>("queue_count");
        set => SetArgument("queue_count", value);
    }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    public TerraformValue<string>? StackType
    {
        get => GetArgument<TerraformValue<string>>("stack_type");
        set => SetArgument("stack_type", value);
    }

    /// <summary>
    /// The name or self_link of the subnetwork attached to this interface.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The project in which the subnetwork belongs.
    /// </summary>
    public TerraformValue<string>? SubnetworkProject
    {
        get => GetArgument<TerraformValue<string>>("subnetwork_project");
        set => SetArgument("subnetwork_project", value);
    }

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceNetworkInterfaceBlockAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceNetworkInterfaceBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// AliasIpRange block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceNetworkInterfaceBlockAliasIpRangeBlock>? AliasIpRange
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceNetworkInterfaceBlockAliasIpRangeBlock>>("alias_ip_range");
        set => SetArgument("alias_ip_range", value);
    }

    /// <summary>
    /// Ipv6AccessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceNetworkInterfaceBlockIpv6AccessConfigBlock>? Ipv6AccessConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceNetworkInterfaceBlockIpv6AccessConfigBlock>>("ipv6_access_config");
        set => SetArgument("ipv6_access_config", value);
    }

}

/// <summary>
/// Block type for access_config in GoogleComputeInstanceNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkInterfaceBlockAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// The IP address that is be 1:1 mapped to the instance&#39;s network ip.
    /// </summary>
    public TerraformValue<string>? NatIp
    {
        get => GetArgument<TerraformValue<string>>("nat_ip");
        set => SetArgument("nat_ip", value);
    }

    /// <summary>
    /// The networking tier used for configuring this instance. One of PREMIUM or STANDARD.
    /// </summary>
    public TerraformValue<string>? NetworkTier
    {
        get => GetArgument<TerraformValue<string>>("network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The DNS domain name for the public PTR record.
    /// </summary>
    public TerraformValue<string>? PublicPtrDomainName
    {
        get => GetArgument<TerraformValue<string>>("public_ptr_domain_name");
        set => SetArgument("public_ptr_domain_name", value);
    }

}

/// <summary>
/// Block type for alias_ip_range in GoogleComputeInstanceNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkInterfaceBlockAliasIpRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alias_ip_range";

    /// <summary>
    /// The IP CIDR range represented by this alias IP range.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformValue<string> IpCidrRange
    {
        get => GetArgument<TerraformValue<string>>("ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range.
    /// </summary>
    public TerraformValue<string>? SubnetworkRangeName
    {
        get => GetArgument<TerraformValue<string>>("subnetwork_range_name");
        set => SetArgument("subnetwork_range_name", value);
    }

}

/// <summary>
/// Block type for ipv6_access_config in GoogleComputeInstanceNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkInterfaceBlockIpv6AccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipv6_access_config";

    /// <summary>
    /// The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. To use a static external IP address, it must be unused and in the same region as the instance&#39;s zone. If not specified, Google Cloud will automatically assign an external IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    public TerraformValue<string>? ExternalIpv6
    {
        get => GetArgument<TerraformValue<string>>("external_ipv6");
        set => SetArgument("external_ipv6", value);
    }

    /// <summary>
    /// The prefix length of the external IPv6 range.
    /// </summary>
    public TerraformValue<string>? ExternalIpv6PrefixLength
    {
        get => GetArgument<TerraformValue<string>>("external_ipv6_prefix_length");
        set => SetArgument("external_ipv6_prefix_length", value);
    }

    /// <summary>
    /// The name of this access configuration. In ipv6AccessConfigs, the recommended name is External IPv6.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM tier is valid for IPv6
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformValue<string> NetworkTier
    {
        get => GetArgument<TerraformValue<string>>("network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The domain name to be used when creating DNSv6 records for the external IPv6 ranges.
    /// </summary>
    public TerraformValue<string>? PublicPtrDomainName
    {
        get => GetArgument<TerraformValue<string>>("public_ptr_domain_name");
        set => SetArgument("public_ptr_domain_name", value);
    }

}


/// <summary>
/// Block type for network_performance_config in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_performance_config";

    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformValue<string> TotalEgressBandwidthTier
    {
        get => GetArgument<TerraformValue<string>>("total_egress_bandwidth_tier");
        set => SetArgument("total_egress_bandwidth_tier", value);
    }

}


/// <summary>
/// Block type for params in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceParamsAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "params";

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

}


/// <summary>
/// Block type for reservation_affinity in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// SpecificReservation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    public TerraformList<GoogleComputeInstanceReservationAffinityBlockSpecificReservationBlock>? SpecificReservation
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceReservationAffinityBlockSpecificReservationBlock>>("specific_reservation");
        set => SetArgument("specific_reservation", value);
    }

}

/// <summary>
/// Block type for specific_reservation in GoogleComputeInstanceReservationAffinityBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceReservationAffinityBlockSpecificReservationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "specific_reservation";

    /// <summary>
    /// Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Corresponds to the label values of a reservation resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for scheduling in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduling";

    /// <summary>
    /// Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user).
    /// </summary>
    public TerraformValue<bool>? AutomaticRestart
    {
        get => GetArgument<TerraformValue<bool>>("automatic_restart");
        set => SetArgument("automatic_restart", value);
    }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    public TerraformValue<double>? AvailabilityDomain
    {
        get => GetArgument<TerraformValue<double>>("availability_domain");
        set => SetArgument("availability_domain", value);
    }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    public TerraformValue<string>? InstanceTerminationAction
    {
        get => GetArgument<TerraformValue<string>>("instance_termination_action");
        set => SetArgument("instance_termination_action", value);
    }

    /// <summary>
    /// The min_node_cpus attribute.
    /// </summary>
    public TerraformValue<double>? MinNodeCpus
    {
        get => GetArgument<TerraformValue<double>>("min_node_cpus");
        set => SetArgument("min_node_cpus", value);
    }

    /// <summary>
    /// Describes maintenance behavior for the instance. One of MIGRATE or TERMINATE,
    /// </summary>
    public TerraformValue<string>? OnHostMaintenance
    {
        get => GetArgument<TerraformValue<string>>("on_host_maintenance");
        set => SetArgument("on_host_maintenance", value);
    }

    /// <summary>
    /// Whether the instance is preemptible.
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => GetArgument<TerraformValue<bool>>("preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    public TerraformValue<string>? ProvisioningModel
    {
        get => GetArgument<TerraformValue<string>>("provisioning_model");
        set => SetArgument("provisioning_model", value);
    }

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    public TerraformValue<string>? TerminationTime
    {
        get => GetArgument<TerraformValue<string>>("termination_time");
        set => SetArgument("termination_time", value);
    }

    /// <summary>
    /// LocalSsdRecoveryTimeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalSsdRecoveryTimeout block(s) allowed")]
    public TerraformList<GoogleComputeInstanceSchedulingBlockLocalSsdRecoveryTimeoutBlock>? LocalSsdRecoveryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceSchedulingBlockLocalSsdRecoveryTimeoutBlock>>("local_ssd_recovery_timeout");
        set => SetArgument("local_ssd_recovery_timeout", value);
    }

    /// <summary>
    /// MaxRunDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxRunDuration block(s) allowed")]
    public TerraformList<GoogleComputeInstanceSchedulingBlockMaxRunDurationBlock>? MaxRunDuration
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceSchedulingBlockMaxRunDurationBlock>>("max_run_duration");
        set => SetArgument("max_run_duration", value);
    }

    /// <summary>
    /// NodeAffinities block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeInstanceSchedulingBlockNodeAffinitiesBlock>? NodeAffinities
    {
        get => GetArgument<TerraformSet<GoogleComputeInstanceSchedulingBlockNodeAffinitiesBlock>>("node_affinities");
        set => SetArgument("node_affinities", value);
    }

    /// <summary>
    /// OnInstanceStopAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnInstanceStopAction block(s) allowed")]
    public TerraformList<GoogleComputeInstanceSchedulingBlockOnInstanceStopActionBlock>? OnInstanceStopAction
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceSchedulingBlockOnInstanceStopActionBlock>>("on_instance_stop_action");
        set => SetArgument("on_instance_stop_action", value);
    }

}

/// <summary>
/// Block type for local_ssd_recovery_timeout in GoogleComputeInstanceSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSchedulingBlockLocalSsdRecoveryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_ssd_recovery_timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for max_run_duration in GoogleComputeInstanceSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSchedulingBlockMaxRunDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_run_duration";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for node_affinities in GoogleComputeInstanceSchedulingBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceSchedulingBlockNodeAffinitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_affinities";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for on_instance_stop_action in GoogleComputeInstanceSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSchedulingBlockOnInstanceStopActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_instance_stop_action";

    /// <summary>
    /// If true, the contents of any attached Local SSD disks will be discarded.
    /// </summary>
    public TerraformValue<bool>? DiscardLocalSsd
    {
        get => GetArgument<TerraformValue<bool>>("discard_local_ssd");
        set => SetArgument("discard_local_ssd", value);
    }

}


/// <summary>
/// Block type for scratch_disk in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceScratchDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scratch_disk";

    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterfaceAttribute is required")]
    public required TerraformValue<string> InterfaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// The size of the disk in gigabytes. One of 375 or 3000.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

}


/// <summary>
/// Block type for service_account in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account";

    /// <summary>
    /// The service account e-mail address.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// A list of service scopes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => GetArgument<TerraformSet<string>>("scopes");
        set => SetArgument("scopes", value);
    }

}


/// <summary>
/// Block type for shielded_instance_config in GoogleComputeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Whether integrity monitoring is enabled for the instance.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Whether secure boot is enabled for the instance.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Whether the instance uses vTPM.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => GetArgument<TerraformValue<bool>>("enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInstance.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_instance Terraform resource.
/// Manages a google_compute_instance resource.
/// </summary>
public partial class GoogleComputeInstance(string name) : TerraformResource("google_compute_instance", name)
{
    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    public TerraformValue<bool>? AllowStoppingForUpdate
    {
        get => GetArgument<TerraformValue<bool>>("allow_stopping_for_update");
        set => SetArgument("allow_stopping_for_update", value);
    }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    public TerraformValue<bool>? CanIpForward
    {
        get => GetArgument<TerraformValue<bool>>("can_ip_forward");
        set => SetArgument("can_ip_forward", value);
    }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DesiredStatus
    {
        get => GetArgument<TerraformValue<string>>("desired_status");
        set => SetArgument("desired_status", value);
    }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    public TerraformValue<bool>? EnableDisplay
    {
        get => GetArgument<TerraformValue<bool>>("enable_display");
        set => SetArgument("enable_display", value);
    }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformValue<string>? KeyRevocationActionType
    {
        get => GetArgument<TerraformValue<string>>("key_revocation_action_type");
        set => SetArgument("key_revocation_action_type", value);
    }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    public TerraformValue<string>? MetadataStartupScript
    {
        get => GetArgument<TerraformValue<string>>("metadata_startup_script");
        set => SetArgument("metadata_startup_script", value);
    }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    public TerraformValue<string>? MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string>? ResourcePolicies
    {
        get => GetArgument<TerraformList<string>>("resource_policies");
        set => SetArgument("resource_policies", value);
    }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => GetArgument<TerraformSet<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    public TerraformValue<string> CpuPlatform
        => AsReference("cpu_platform");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    public TerraformValue<string> CurrentStatus
        => AsReference("current_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    public TerraformValue<string> InstanceId
        => AsReference("instance_id");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformValue<string> MetadataFingerprint
        => AsReference("metadata_fingerprint");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformValue<string> TagsFingerprint
        => AsReference("tags_fingerprint");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// AdvancedMachineFeatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public TerraformList<GoogleComputeInstanceAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// AttachedDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceAttachedDiskBlock>? AttachedDisk
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceAttachedDiskBlock>>("attached_disk");
        set => SetArgument("attached_disk", value);
    }

    /// <summary>
    /// BootDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    public required TerraformList<GoogleComputeInstanceBootDiskBlock> BootDisk
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInstanceBootDiskBlock>>("boot_disk");
        set => SetArgument("boot_disk", value);
    }

    /// <summary>
    /// ConfidentialInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => SetArgument("confidential_instance_config", value);
    }

    /// <summary>
    /// GuestAccelerator block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGuestAcceleratorBlock>>("guest_accelerator");
        set => SetArgument("guest_accelerator", value);
    }

    /// <summary>
    /// InstanceEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeInstanceInstanceEncryptionKeyBlock>? InstanceEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceInstanceEncryptionKeyBlock>>("instance_encryption_key");
        set => SetArgument("instance_encryption_key", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    public required TerraformList<GoogleComputeInstanceNetworkInterfaceBlock> NetworkInterface
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInstanceNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// NetworkPerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceNetworkPerformanceConfigBlock>>("network_performance_config");
        set => SetArgument("network_performance_config", value);
    }

    /// <summary>
    /// ParamsAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParamsAttribute block(s) allowed")]
    public TerraformList<GoogleComputeInstanceParamsAttributeBlock>? ParamsAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceParamsAttributeBlock>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleComputeInstanceReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// Scheduling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public TerraformList<GoogleComputeInstanceSchedulingBlock>? Scheduling
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceSchedulingBlock>>("scheduling");
        set => SetArgument("scheduling", value);
    }

    /// <summary>
    /// ScratchDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceScratchDiskBlock>? ScratchDisk
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceScratchDiskBlock>>("scratch_disk");
        set => SetArgument("scratch_disk", value);
    }

    /// <summary>
    /// ServiceAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public TerraformList<GoogleComputeInstanceServiceAccountBlock>? ServiceAccount
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceServiceAccountBlock>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
