using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock : TerraformBlock
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
    /// Whether to enable UEFI networking or not.
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
/// Block type for confidential_instance_config in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock : TerraformBlock
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
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release.
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialCompute
    {
        get => GetArgument<TerraformValue<bool>>("enable_confidential_compute");
        set => SetArgument("enable_confidential_compute", value);
    }

}


/// <summary>
/// Block type for disk in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk";

    /// <summary>
    /// The architecture of the image. Allowed values are ARM64 or X86_64.
    /// </summary>
    public TerraformValue<string> Architecture
    {
        get => GetArgument<TerraformValue<string>>("architecture") ?? AsReference("architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// Whether or not the disk should be auto-deleted. This defaults to true.
    /// </summary>
    public TerraformValue<bool>? AutoDelete
    {
        get => GetArgument<TerraformValue<bool>>("auto_delete");
        set => SetArgument("auto_delete", value);
    }

    /// <summary>
    /// Indicates that this is a boot disk.
    /// </summary>
    public TerraformValue<bool> Boot
    {
        get => GetArgument<TerraformValue<bool>>("boot") ?? AsReference("boot");
        set => SetArgument("boot", value);
    }

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name") ?? AsReference("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// Name of the disk. When not provided, this defaults to the name of the instance.
    /// </summary>
    public TerraformValue<string>? DiskName
    {
        get => GetArgument<TerraformValue<string>>("disk_name");
        set => SetArgument("disk_name", value);
    }

    /// <summary>
    /// The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The Google Compute Engine disk type. Such as &amp;quot;pd-ssd&amp;quot;, &amp;quot;local-ssd&amp;quot;, &amp;quot;pd-balanced&amp;quot; or &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? AsReference("disk_type");
        set => SetArgument("disk_type", value);
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
    /// Specifies the disk interface to use for attaching this disk.
    /// </summary>
    public TerraformValue<string> InterfaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("interface") ?? AsReference("interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to disks,
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode") ?? AsReference("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk) or the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks) depending on the selected disk_type.
    /// </summary>
    public TerraformValue<double> ProvisionedIops
    {
        get => GetArgument<TerraformValue<double>>("provisioned_iops") ?? AsReference("provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Indicates how much throughput to provision for the disk, in MB/s. This sets the amount of data that can be read or written from the disk per second. Values must greater than or equal to 1. For more details, see the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks).
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
    {
        get => GetArgument<TerraformValue<double>>("provisioned_throughput") ?? AsReference("provisioned_throughput");
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
    /// A list (short name or id) of resource policies to attach to this disk. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string>? ResourcePolicies
    {
        get => GetArgument<TerraformList<string>>("resource_policies");
        set => SetArgument("resource_policies", value);
    }

    /// <summary>
    /// The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The image from which to initialize this disk. This can be one of: the image&#39;s self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformValue<string> SourceImage
    {
        get => GetArgument<TerraformValue<string>>("source_image") ?? AsReference("source_image");
        set => SetArgument("source_image", value);
    }

    /// <summary>
    /// The source snapshot to create this disk. When creating
    /// a new instance, one of initializeParams.sourceSnapshot,
    /// initializeParams.sourceImage, or disks.source is
    /// required except for local SSD.
    /// </summary>
    public TerraformValue<string>? SourceSnapshot
    {
        get => GetArgument<TerraformValue<string>>("source_snapshot");
        set => SetArgument("source_snapshot", value);
    }

    /// <summary>
    /// The type of Google Compute Engine disk, can be either &amp;quot;SCRATCH&amp;quot; or &amp;quot;PERSISTENT&amp;quot;.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? AsReference("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// DiskEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateDiskBlockDiskEncryptionKeyBlock>? DiskEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateDiskBlockDiskEncryptionKeyBlock>>("disk_encryption_key");
        set => SetArgument("disk_encryption_key", value);
    }

    /// <summary>
    /// SourceImageEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateDiskBlockSourceImageEncryptionKeyBlock>? SourceImageEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateDiskBlockSourceImageEncryptionKeyBlock>>("source_image_encryption_key");
        set => SetArgument("source_image_encryption_key", value);
    }

    /// <summary>
    /// SourceSnapshotEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateDiskBlockSourceSnapshotEncryptionKeyBlock>? SourceSnapshotEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateDiskBlockSourceSnapshotEncryptionKeyBlock>>("source_snapshot_encryption_key");
        set => SetArgument("source_snapshot_encryption_key", value);
    }

}

/// <summary>
/// Block type for disk_encryption_key in GoogleComputeInstanceTemplateDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateDiskBlockDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption_key";

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

}

/// <summary>
/// Block type for source_image_encryption_key in GoogleComputeInstanceTemplateDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateDiskBlockSourceImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_encryption_key";

    /// <summary>
    /// The self link of the encryption key that is stored in
    /// Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption
    /// request for the given KMS key. If absent, the Compute
    /// Engine default service account is used.
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

}

/// <summary>
/// Block type for source_snapshot_encryption_key in GoogleComputeInstanceTemplateDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateDiskBlockSourceSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_snapshot_encryption_key";

    /// <summary>
    /// The self link of the encryption key that is stored in
    /// Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption
    /// request for the given KMS key. If absent, the Compute
    /// Engine default service account is used.
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

}


/// <summary>
/// Block type for guest_accelerator in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateGuestAcceleratorBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_interface in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    public TerraformValue<double> InternalIpv6PrefixLength
    {
        get => GetArgument<TerraformValue<double>>("internal_ipv6_prefix_length") ?? AsReference("internal_ipv6_prefix_length");
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
    public TerraformValue<string> Ipv6Address
    {
        get => GetArgument<TerraformValue<string>>("ipv6_address") ?? AsReference("ipv6_address");
        set => SetArgument("ipv6_address", value);
    }

    /// <summary>
    /// The name of the network_interface.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The private IP address to assign to the instance. If empty, the address will be automatically assigned.
    /// </summary>
    public TerraformValue<string>? NetworkIp
    {
        get => GetArgument<TerraformValue<string>>("network_ip");
        set => SetArgument("network_ip", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, MRDMA, and IRDMA
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
    public TerraformValue<string> StackType
    {
        get => GetArgument<TerraformValue<string>>("stack_type") ?? AsReference("stack_type");
        set => SetArgument("stack_type", value);
    }

    /// <summary>
    /// The name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork") ?? AsReference("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> SubnetworkProject
    {
        get => GetArgument<TerraformValue<string>>("subnetwork_project") ?? AsReference("subnetwork_project");
        set => SetArgument("subnetwork_project", value);
    }

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlockAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// AliasIpRange block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlockAliasIpRangeBlock>? AliasIpRange
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlockAliasIpRangeBlock>>("alias_ip_range");
        set => SetArgument("alias_ip_range", value);
    }

    /// <summary>
    /// Ipv6AccessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlockIpv6AccessConfigBlock>? Ipv6AccessConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlockIpv6AccessConfigBlock>>("ipv6_access_config");
        set => SetArgument("ipv6_access_config", value);
    }

}

/// <summary>
/// Block type for access_config in GoogleComputeInstanceTemplateNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkInterfaceBlockAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// The IP address that will be 1:1 mapped to the instance&#39;s network ip. If not given, one will be generated.
    /// </summary>
    public TerraformValue<string> NatIp
    {
        get => GetArgument<TerraformValue<string>>("nat_ip") ?? AsReference("nat_ip");
        set => SetArgument("nat_ip", value);
    }

    /// <summary>
    /// The networking tier used for configuring this instance template. This field can take the following values: PREMIUM, STANDARD, FIXED_STANDARD. If this field is not specified, it is assumed to be PREMIUM.
    /// </summary>
    public TerraformValue<string> NetworkTier
    {
        get => GetArgument<TerraformValue<string>>("network_tier") ?? AsReference("network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The DNS domain name for the public PTR record.The DNS domain name for the public PTR record.
    /// </summary>
    public TerraformValue<string> PublicPtrDomainName
        => AsReference("public_ptr_domain_name");

}

/// <summary>
/// Block type for alias_ip_range in GoogleComputeInstanceTemplateNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkInterfaceBlockAliasIpRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alias_ip_range";

    /// <summary>
    /// The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. At the time of writing only a netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API error.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformValue<string> IpCidrRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.
    /// </summary>
    public TerraformValue<string>? SubnetworkRangeName
    {
        get => GetArgument<TerraformValue<string>>("subnetwork_range_name");
        set => SetArgument("subnetwork_range_name", value);
    }

}

/// <summary>
/// Block type for ipv6_access_config in GoogleComputeInstanceTemplateNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkInterfaceBlockIpv6AccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipv6_access_config";

    /// <summary>
    /// The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. The field is output only, an IPv6 address from a subnetwork associated with the instance will be allocated dynamically.
    /// </summary>
    public TerraformValue<string> ExternalIpv6
        => AsReference("external_ipv6");

    /// <summary>
    /// The prefix length of the external IPv6 range.
    /// </summary>
    public TerraformValue<string> ExternalIpv6PrefixLength
        => AsReference("external_ipv6_prefix_length");

    /// <summary>
    /// The name of this access configuration.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM tier is valid for IPv6
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformValue<string> NetworkTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The domain name to be used when creating DNSv6 records for the external IPv6 ranges.
    /// </summary>
    public TerraformValue<string> PublicPtrDomainName
        => AsReference("public_ptr_domain_name");

}


/// <summary>
/// Block type for network_performance_config in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("total_egress_bandwidth_tier");
        set => SetArgument("total_egress_bandwidth_tier", value);
    }

}


/// <summary>
/// Block type for reservation_affinity in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateReservationAffinityBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// SpecificReservation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateReservationAffinityBlockSpecificReservationBlock>? SpecificReservation
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateReservationAffinityBlockSpecificReservationBlock>>("specific_reservation");
        set => SetArgument("specific_reservation", value);
    }

}

/// <summary>
/// Block type for specific_reservation in GoogleComputeInstanceTemplateReservationAffinityBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateReservationAffinityBlockSpecificReservationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("key");
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
/// Block type for scheduling in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduling";

    /// <summary>
    /// Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.
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
    /// Minimum number of cpus for the instance.
    /// </summary>
    public TerraformValue<double>? MinNodeCpus
    {
        get => GetArgument<TerraformValue<double>>("min_node_cpus");
        set => SetArgument("min_node_cpus", value);
    }

    /// <summary>
    /// Defines the maintenance behavior for this instance.
    /// </summary>
    public TerraformValue<string> OnHostMaintenance
    {
        get => GetArgument<TerraformValue<string>>("on_host_maintenance") ?? AsReference("on_host_maintenance");
        set => SetArgument("on_host_maintenance", value);
    }

    /// <summary>
    /// Allows instance to be preempted. This defaults to false.
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => GetArgument<TerraformValue<bool>>("preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    public TerraformValue<string> ProvisioningModel
    {
        get => GetArgument<TerraformValue<string>>("provisioning_model") ?? AsReference("provisioning_model");
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
    public TerraformList<GoogleComputeInstanceTemplateSchedulingBlockLocalSsdRecoveryTimeoutBlock>? LocalSsdRecoveryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateSchedulingBlockLocalSsdRecoveryTimeoutBlock>>("local_ssd_recovery_timeout");
        set => SetArgument("local_ssd_recovery_timeout", value);
    }

    /// <summary>
    /// MaxRunDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxRunDuration block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateSchedulingBlockMaxRunDurationBlock>? MaxRunDuration
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateSchedulingBlockMaxRunDurationBlock>>("max_run_duration");
        set => SetArgument("max_run_duration", value);
    }

    /// <summary>
    /// NodeAffinities block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeInstanceTemplateSchedulingBlockNodeAffinitiesBlock>? NodeAffinities
    {
        get => GetArgument<TerraformSet<GoogleComputeInstanceTemplateSchedulingBlockNodeAffinitiesBlock>>("node_affinities");
        set => SetArgument("node_affinities", value);
    }

    /// <summary>
    /// OnInstanceStopAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnInstanceStopAction block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateSchedulingBlockOnInstanceStopActionBlock>? OnInstanceStopAction
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateSchedulingBlockOnInstanceStopActionBlock>>("on_instance_stop_action");
        set => SetArgument("on_instance_stop_action", value);
    }

}

/// <summary>
/// Block type for local_ssd_recovery_timeout in GoogleComputeInstanceTemplateSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateSchedulingBlockLocalSsdRecoveryTimeoutBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for max_run_duration in GoogleComputeInstanceTemplateSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateSchedulingBlockMaxRunDurationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for node_affinities in GoogleComputeInstanceTemplateSchedulingBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceTemplateSchedulingBlockNodeAffinitiesBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for on_instance_stop_action in GoogleComputeInstanceTemplateSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateSchedulingBlockOnInstanceStopActionBlock : TerraformBlock
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
/// Block type for service_account in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account";

    /// <summary>
    /// The service account e-mail address. If not given, the default Google Compute Engine service account is used.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email") ?? AsReference("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => GetRequiredArgument<TerraformSet<string>>("scopes");
        set => SetArgument("scopes", value);
    }

}


/// <summary>
/// Block type for shielded_instance_config in GoogleComputeInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => GetArgument<TerraformValue<bool>>("enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInstanceTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceTemplateTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_instance_template Terraform resource.
/// Manages a google_compute_instance_template resource.
/// </summary>
public partial class GoogleComputeInstanceTemplate(string name) : TerraformResource("google_compute_instance_template", name)
{
    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformValue<bool>? CanIpForward
    {
        get => GetArgument<TerraformValue<bool>>("can_ip_forward");
        set => SetArgument("can_ip_forward", value);
    }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformValue<string>? InstanceDescription
    {
        get => GetArgument<TerraformValue<string>>("instance_description");
        set => SetArgument("instance_description", value);
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
    /// A set of key/value label pairs to assign to instances created from this template.
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
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => GetRequiredArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformValue<string>? MetadataStartupScript
    {
        get => GetArgument<TerraformValue<string>>("metadata_startup_script");
        set => SetArgument("metadata_startup_script", value);
    }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformValue<string>? MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags.
    /// 				Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// 				The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
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
    /// Tags to attach to the instance.
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => GetArgument<TerraformSet<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformValue<string> MetadataFingerprint
        => AsReference("metadata_fingerprint");

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformValue<string> NumericId
        => AsReference("numeric_id");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// A special URI of the created resource that uniquely identifies this instance template.
    /// </summary>
    public TerraformValue<string> SelfLinkUnique
        => AsReference("self_link_unique");

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
    public TerraformList<GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// ConfidentialInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => SetArgument("confidential_instance_config", value);
    }

    /// <summary>
    /// Disk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Disk block(s) required")]
    public required TerraformList<GoogleComputeInstanceTemplateDiskBlock> Disk
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInstanceTemplateDiskBlock>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// GuestAccelerator block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceTemplateGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateGuestAcceleratorBlock>>("guest_accelerator");
        set => SetArgument("guest_accelerator", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// NetworkPerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock>>("network_performance_config");
        set => SetArgument("network_performance_config", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// Scheduling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateSchedulingBlock>? Scheduling
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateSchedulingBlock>>("scheduling");
        set => SetArgument("scheduling", value);
    }

    /// <summary>
    /// ServiceAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateServiceAccountBlock>? ServiceAccount
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateServiceAccountBlock>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceTemplateShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceTemplateShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInstanceTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInstanceTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
