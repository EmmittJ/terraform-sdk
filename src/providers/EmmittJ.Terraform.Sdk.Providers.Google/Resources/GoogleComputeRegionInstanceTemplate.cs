using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateAdvancedMachineFeaturesBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enable_nested_virtualization");
        set => SetArgument("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Whether to enable UEFI networking or not.
    /// </summary>
    public TerraformValue<bool>? EnableUefiNetworking
    {
        get => new TerraformReference<bool>(this, "enable_uefi_networking");
        set => SetArgument("enable_uefi_networking", value);
    }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    public TerraformValue<string>? PerformanceMonitoringUnit
    {
        get => new TerraformReference<string>(this, "performance_monitoring_unit");
        set => SetArgument("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    public TerraformValue<double>? ThreadsPerCore
    {
        get => new TerraformReference<double>(this, "threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TurboMode
    {
        get => new TerraformReference<string>(this, "turbo_mode");
        set => SetArgument("turbo_mode", value);
    }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    public TerraformValue<double>? VisibleCoreCount
    {
        get => new TerraformReference<double>(this, "visible_core_count");
        set => SetArgument("visible_core_count", value);
    }

}


/// <summary>
/// Block type for confidential_instance_config in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateConfidentialInstanceConfigBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release.
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialCompute
    {
        get => new TerraformReference<bool>(this, "enable_confidential_compute");
        set => SetArgument("enable_confidential_compute", value);
    }

}


/// <summary>
/// Block type for disk in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateDiskBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// Whether or not the disk should be auto-deleted. This defaults to true.
    /// </summary>
    public TerraformValue<bool>? AutoDelete
    {
        get => new TerraformReference<bool>(this, "auto_delete");
        set => SetArgument("auto_delete", value);
    }

    /// <summary>
    /// Indicates that this is a boot disk.
    /// </summary>
    public TerraformValue<bool> Boot
    {
        get => new TerraformReference<bool>(this, "boot");
        set => SetArgument("boot", value);
    }

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// Name of the disk. When not provided, this defaults to the name of the instance.
    /// </summary>
    public TerraformValue<string>? DiskName
    {
        get => new TerraformReference<string>(this, "disk_name");
        set => SetArgument("disk_name", value);
    }

    /// <summary>
    /// The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The Google Compute Engine disk type. Such as &amp;quot;pd-ssd&amp;quot;, &amp;quot;local-ssd&amp;quot;, &amp;quot;pd-balanced&amp;quot; or &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    public TerraformList<string>? GuestOsFeatures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "guest_os_features").ResolveNodes(ctx));
        set => SetArgument("guest_os_features", value);
    }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk.
    /// </summary>
    public TerraformValue<string> InterfaceAttribute
    {
        get => new TerraformReference<string>(this, "interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to disks,
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk) or the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks) depending on the selected disk_type.
    /// </summary>
    public TerraformValue<double> ProvisionedIops
    {
        get => new TerraformReference<double>(this, "provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Indicates how much throughput to provision for the disk, in MB/s. This sets the amount of data that can be read or written from the disk per second. Values must greater than or equal to 1. For more details, see the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks).
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
    {
        get => new TerraformReference<double>(this, "provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_manager_tags").ResolveNodes(ctx));
        set => SetArgument("resource_manager_tags", value);
    }

    /// <summary>
    /// A list (short name or id) of resource policies to attach to this disk. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string>? ResourcePolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_policies").ResolveNodes(ctx));
        set => SetArgument("resource_policies", value);
    }

    /// <summary>
    /// The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The image from which to initialize this disk. This can be one of: the image&#39;s self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformValue<string> SourceImage
    {
        get => new TerraformReference<string>(this, "source_image");
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
        get => new TerraformReference<string>(this, "source_snapshot");
        set => SetArgument("source_snapshot", value);
    }

    /// <summary>
    /// The type of Google Compute Engine disk, can be either &amp;quot;SCRATCH&amp;quot; or &amp;quot;PERSISTENT&amp;quot;.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// DiskEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateDiskBlockDiskEncryptionKeyBlock>? DiskEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateDiskBlockDiskEncryptionKeyBlock>>("disk_encryption_key");
        set => SetArgument("disk_encryption_key", value);
    }

    /// <summary>
    /// SourceImageEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateDiskBlockSourceImageEncryptionKeyBlock>? SourceImageEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateDiskBlockSourceImageEncryptionKeyBlock>>("source_image_encryption_key");
        set => SetArgument("source_image_encryption_key", value);
    }

    /// <summary>
    /// SourceSnapshotEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateDiskBlockSourceSnapshotEncryptionKeyBlock>? SourceSnapshotEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateDiskBlockSourceSnapshotEncryptionKeyBlock>>("source_snapshot_encryption_key");
        set => SetArgument("source_snapshot_encryption_key", value);
    }

}

/// <summary>
/// Block type for disk_encryption_key in GoogleComputeRegionInstanceTemplateDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateDiskBlockDiskEncryptionKeyBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => new TerraformReference<string>(this, "kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

}

/// <summary>
/// Block type for source_image_encryption_key in GoogleComputeRegionInstanceTemplateDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateDiskBlockSourceImageEncryptionKeyBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption
    /// request for the given KMS key. If absent, the Compute
    /// Engine default service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => new TerraformReference<string>(this, "kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource.  Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => new TerraformReference<string>(this, "raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource.  Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => new TerraformReference<string>(this, "rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}

/// <summary>
/// Block type for source_snapshot_encryption_key in GoogleComputeRegionInstanceTemplateDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateDiskBlockSourceSnapshotEncryptionKeyBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption
    /// request for the given KMS key. If absent, the Compute
    /// Engine default service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => new TerraformReference<string>(this, "kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to either encrypt or decrypt this resource. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => new TerraformReference<string>(this, "raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource.  Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => new TerraformReference<string>(this, "rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}


/// <summary>
/// Block type for guest_accelerator in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateGuestAcceleratorBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_interface in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "internal_ipv6_prefix_length");
        set => SetArgument("internal_ipv6_prefix_length", value);
    }

    /// <summary>
    /// One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.
    /// </summary>
    public TerraformValue<string> Ipv6AccessType
    {
        get => new TerraformReference<string>(this, "ipv6_access_type");
    }

    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    public TerraformValue<string> Ipv6Address
    {
        get => new TerraformReference<string>(this, "ipv6_address");
        set => SetArgument("ipv6_address", value);
    }

    /// <summary>
    /// The name of the network_interface.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The private IP address to assign to the instance. If empty, the address will be automatically assigned.
    /// </summary>
    public TerraformValue<string>? NetworkIp
    {
        get => new TerraformReference<string>(this, "network_ip");
        set => SetArgument("network_ip", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, MRDMA, and IRDMA
    /// </summary>
    public TerraformValue<string>? NicType
    {
        get => new TerraformReference<string>(this, "nic_type");
        set => SetArgument("nic_type", value);
    }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    public TerraformValue<double>? QueueCount
    {
        get => new TerraformReference<double>(this, "queue_count");
        set => SetArgument("queue_count", value);
    }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    public TerraformValue<string> StackType
    {
        get => new TerraformReference<string>(this, "stack_type");
        set => SetArgument("stack_type", value);
    }

    /// <summary>
    /// The name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> SubnetworkProject
    {
        get => new TerraformReference<string>(this, "subnetwork_project");
        set => SetArgument("subnetwork_project", value);
    }

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// AliasIpRange block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockAliasIpRangeBlock>? AliasIpRange
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockAliasIpRangeBlock>>("alias_ip_range");
        set => SetArgument("alias_ip_range", value);
    }

    /// <summary>
    /// Ipv6AccessConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockIpv6AccessConfigBlock>? Ipv6AccessConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockIpv6AccessConfigBlock>>("ipv6_access_config");
        set => SetArgument("ipv6_access_config", value);
    }

}

/// <summary>
/// Block type for access_config in GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockAccessConfigBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "nat_ip");
        set => SetArgument("nat_ip", value);
    }

    /// <summary>
    /// The networking tier used for configuring this instance template. This field can take the following values: PREMIUM, STANDARD, FIXED_STANDARD. If this field is not specified, it is assumed to be PREMIUM.
    /// </summary>
    public TerraformValue<string> NetworkTier
    {
        get => new TerraformReference<string>(this, "network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The DNS domain name for the public PTR record.The DNS domain name for the public PTR record.
    /// </summary>
    public TerraformValue<string> PublicPtrDomainName
    {
        get => new TerraformReference<string>(this, "public_ptr_domain_name");
    }

}

/// <summary>
/// Block type for alias_ip_range in GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockAliasIpRangeBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.
    /// </summary>
    public TerraformValue<string>? SubnetworkRangeName
    {
        get => new TerraformReference<string>(this, "subnetwork_range_name");
        set => SetArgument("subnetwork_range_name", value);
    }

}

/// <summary>
/// Block type for ipv6_access_config in GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkInterfaceBlockIpv6AccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipv6_access_config";

    /// <summary>
    /// The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. The field is output only, an IPv6 address from a subnetwork associated with the instance will be allocated dynamically.
    /// </summary>
    public TerraformValue<string> ExternalIpv6
    {
        get => new TerraformReference<string>(this, "external_ipv6");
    }

    /// <summary>
    /// The prefix length of the external IPv6 range.
    /// </summary>
    public TerraformValue<string> ExternalIpv6PrefixLength
    {
        get => new TerraformReference<string>(this, "external_ipv6_prefix_length");
    }

    /// <summary>
    /// The name of this access configuration.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM tier is valid for IPv6
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformValue<string> NetworkTier
    {
        get => new TerraformReference<string>(this, "network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The domain name to be used when creating DNSv6 records for the external IPv6 ranges.
    /// </summary>
    public TerraformValue<string> PublicPtrDomainName
    {
        get => new TerraformReference<string>(this, "public_ptr_domain_name");
    }

}


/// <summary>
/// Block type for network_performance_config in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkPerformanceConfigBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "total_egress_bandwidth_tier");
        set => SetArgument("total_egress_bandwidth_tier", value);
    }

}


/// <summary>
/// Block type for reservation_affinity in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateReservationAffinityBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// SpecificReservation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateReservationAffinityBlockSpecificReservationBlock>? SpecificReservation
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateReservationAffinityBlockSpecificReservationBlock>>("specific_reservation");
        set => SetArgument("specific_reservation", value);
    }

}

/// <summary>
/// Block type for specific_reservation in GoogleComputeRegionInstanceTemplateReservationAffinityBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateReservationAffinityBlockSpecificReservationBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Corresponds to the label values of a reservation resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for scheduling in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateSchedulingBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "automatic_restart");
        set => SetArgument("automatic_restart", value);
    }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    public TerraformValue<double>? AvailabilityDomain
    {
        get => new TerraformReference<double>(this, "availability_domain");
        set => SetArgument("availability_domain", value);
    }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    public TerraformValue<string>? InstanceTerminationAction
    {
        get => new TerraformReference<string>(this, "instance_termination_action");
        set => SetArgument("instance_termination_action", value);
    }

    /// <summary>
    /// Minimum number of cpus for the instance.
    /// </summary>
    public TerraformValue<double>? MinNodeCpus
    {
        get => new TerraformReference<double>(this, "min_node_cpus");
        set => SetArgument("min_node_cpus", value);
    }

    /// <summary>
    /// Defines the maintenance behavior for this instance.
    /// </summary>
    public TerraformValue<string> OnHostMaintenance
    {
        get => new TerraformReference<string>(this, "on_host_maintenance");
        set => SetArgument("on_host_maintenance", value);
    }

    /// <summary>
    /// Allows instance to be preempted. This defaults to false.
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => new TerraformReference<bool>(this, "preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    public TerraformValue<string> ProvisioningModel
    {
        get => new TerraformReference<string>(this, "provisioning_model");
        set => SetArgument("provisioning_model", value);
    }

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    public TerraformValue<string>? TerminationTime
    {
        get => new TerraformReference<string>(this, "termination_time");
        set => SetArgument("termination_time", value);
    }

    /// <summary>
    /// LocalSsdRecoveryTimeout block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlockLocalSsdRecoveryTimeoutBlock>? LocalSsdRecoveryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlockLocalSsdRecoveryTimeoutBlock>>("local_ssd_recovery_timeout");
        set => SetArgument("local_ssd_recovery_timeout", value);
    }

    /// <summary>
    /// MaxRunDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxRunDuration block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlockMaxRunDurationBlock>? MaxRunDuration
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlockMaxRunDurationBlock>>("max_run_duration");
        set => SetArgument("max_run_duration", value);
    }

    /// <summary>
    /// NodeAffinities block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRegionInstanceTemplateSchedulingBlockNodeAffinitiesBlock>? NodeAffinities
    {
        get => GetArgument<TerraformSet<GoogleComputeRegionInstanceTemplateSchedulingBlockNodeAffinitiesBlock>>("node_affinities");
        set => SetArgument("node_affinities", value);
    }

    /// <summary>
    /// OnInstanceStopAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnInstanceStopAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlockOnInstanceStopActionBlock>? OnInstanceStopAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlockOnInstanceStopActionBlock>>("on_instance_stop_action");
        set => SetArgument("on_instance_stop_action", value);
    }

}

/// <summary>
/// Block type for local_ssd_recovery_timeout in GoogleComputeRegionInstanceTemplateSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateSchedulingBlockLocalSsdRecoveryTimeoutBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for max_run_duration in GoogleComputeRegionInstanceTemplateSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateSchedulingBlockMaxRunDurationBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for node_affinities in GoogleComputeRegionInstanceTemplateSchedulingBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionInstanceTemplateSchedulingBlockNodeAffinitiesBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for on_instance_stop_action in GoogleComputeRegionInstanceTemplateSchedulingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateSchedulingBlockOnInstanceStopActionBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "discard_local_ssd");
        set => SetArgument("discard_local_ssd", value);
    }

}


/// <summary>
/// Block type for service_account in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateServiceAccountBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

}


/// <summary>
/// Block type for shielded_instance_config in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateShieldedInstanceConfigBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => new TerraformReference<bool>(this, "enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => new TerraformReference<bool>(this, "enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionInstanceTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionInstanceTemplateTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_compute_region_instance_template Terraform resource.
/// Manages a google_compute_region_instance_template resource.
/// </summary>
public partial class GoogleComputeRegionInstanceTemplate(string name) : TerraformResource("google_compute_region_instance_template", name)
{
    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformValue<bool>? CanIpForward
    {
        get => new TerraformReference<bool>(this, "can_ip_forward");
        set => SetArgument("can_ip_forward", value);
    }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformValue<string>? InstanceDescription
    {
        get => new TerraformReference<string>(this, "instance_description");
        set => SetArgument("instance_description", value);
    }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformValue<string>? KeyRevocationActionType
    {
        get => new TerraformReference<string>(this, "key_revocation_action_type");
        set => SetArgument("key_revocation_action_type", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => new TerraformReference<string>(this, "machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformValue<string>? MetadataStartupScript
    {
        get => new TerraformReference<string>(this, "metadata_startup_script");
        set => SetArgument("metadata_startup_script", value);
    }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformValue<string>? MinCpuPlatform
    {
        get => new TerraformReference<string>(this, "min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_manager_tags").ResolveNodes(ctx));
        set => SetArgument("resource_manager_tags", value);
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string>? ResourcePolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_policies").ResolveNodes(ctx));
        set => SetArgument("resource_policies", value);
    }

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformValue<string> MetadataFingerprint
    {
        get => new TerraformReference<string>(this, "metadata_fingerprint");
    }

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformValue<string> NumericId
    {
        get => new TerraformReference<string>(this, "numeric_id");
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformValue<string> TagsFingerprint
    {
        get => new TerraformReference<string>(this, "tags_fingerprint");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// AdvancedMachineFeatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// ConfidentialInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => SetArgument("confidential_instance_config", value);
    }

    /// <summary>
    /// Disk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Disk block(s) required")]
    public required TerraformList<GoogleComputeRegionInstanceTemplateDiskBlock> Disk
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRegionInstanceTemplateDiskBlock>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// GuestAccelerator block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionInstanceTemplateGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateGuestAcceleratorBlock>>("guest_accelerator");
        set => SetArgument("guest_accelerator", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// NetworkPerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateNetworkPerformanceConfigBlock>>("network_performance_config");
        set => SetArgument("network_performance_config", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// Scheduling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlock>? Scheduling
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateSchedulingBlock>>("scheduling");
        set => SetArgument("scheduling", value);
    }

    /// <summary>
    /// ServiceAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateServiceAccountBlock>? ServiceAccount
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateServiceAccountBlock>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionInstanceTemplateShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionInstanceTemplateShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionInstanceTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionInstanceTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
