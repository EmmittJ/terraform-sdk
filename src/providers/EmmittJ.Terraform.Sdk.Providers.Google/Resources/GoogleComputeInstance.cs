using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceAdvancedMachineFeaturesBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    [TerraformPropertyName("enable_nested_virtualization")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableNestedVirtualization { get; set; }

    /// <summary>
    /// Whether to enable UEFI networking for the instance.
    /// </summary>
    [TerraformPropertyName("enable_uefi_networking")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableUefiNetworking { get; set; }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    [TerraformPropertyName("performance_monitoring_unit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PerformanceMonitoringUnit { get; set; }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [TerraformPropertyName("threads_per_core")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThreadsPerCore { get; set; }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    [TerraformPropertyName("turbo_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TurboMode { get; set; }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    [TerraformPropertyName("visible_core_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VisibleCoreCount { get; set; }

}

/// <summary>
/// Block type for attached_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceAttachedDiskBlock : ITerraformBlock
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeviceName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "device_name");

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_raw")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionKeyRaw { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_rsa")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionKeyRsa { get; set; }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_sha256")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskEncryptionKeySha256 => new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_encryption_key_sha256");

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    [TerraformPropertyName("disk_encryption_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionServiceAccount { get; set; }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    [TerraformPropertyName("force_attach")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceAttach { get; set; }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeySelfLink { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_self_link");

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

}

/// <summary>
/// Block type for boot_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceBootDiskBlock : ITerraformBlock
{
    /// <summary>
    /// Whether the disk will be auto-deleted when the instance is deleted.
    /// </summary>
    [TerraformPropertyName("auto_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoDelete { get; set; }

    /// <summary>
    /// Name with which attached disk will be accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeviceName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "device_name");

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_raw")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionKeyRaw { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_rsa")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionKeyRsa { get; set; }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_sha256")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskEncryptionKeySha256 => new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_encryption_key_sha256");

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    [TerraformPropertyName("disk_encryption_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionServiceAccount { get; set; }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    [TerraformPropertyName("force_attach")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceAttach { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    [TerraformPropertyName("guest_os_features")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> GuestOsFeatures { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "guest_os_features");

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is shared with attached_disk and only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    [TerraformPropertyName("interface")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Interface { get; set; }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeySelfLink { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_self_link");

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Source { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "source");

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceConfidentialInstanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// 
    /// 								The confidential computing technology the instance uses.
    /// 								SEV is an AMD feature. TDX is an Intel feature. One of the following
    /// 								values is required: SEV, SEV_SNP, TDX. If SEV_SNP, min_cpu_platform =
    /// 								&amp;quot;AMD Milan&amp;quot; is currently required.
    /// </summary>
    [TerraformPropertyName("confidential_instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release
    /// </summary>
    [TerraformPropertyName("enable_confidential_compute")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableConfidentialCompute { get; set; }

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGuestAcceleratorBlock : ITerraformBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

    /// <summary>
    /// The accelerator type resource exposed to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for instance_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceInstanceEncryptionKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeySelfLink { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_self_link");

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// The SHA256 hash of the customer&#39;s encryption key.
    /// </summary>
    [TerraformPropertyName("sha256")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sha256 => new TerraformReferenceProperty<TerraformProperty<string>>("", "sha256");

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkInterfaceBlock : ITerraformBlock
{
    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_prefix_length")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> InternalIpv6PrefixLength { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "internal_ipv6_prefix_length");

    /// <summary>
    /// One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.
    /// </summary>
    [TerraformPropertyName("ipv6_access_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6AccessType => new TerraformReferenceProperty<TerraformProperty<string>>("", "ipv6_access_type");

    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    [TerraformPropertyName("ipv6_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ipv6Address { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ipv6_address");

    /// <summary>
    /// The name of the interface
    /// </summary>
    [TerraformPropertyName("name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The name or self_link of the network attached to this interface.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Network { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "network");

    /// <summary>
    /// The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.
    /// </summary>
    [TerraformPropertyName("network_attachment")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkAttachment { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "network_attachment");

    /// <summary>
    /// The private IP address assigned to the instance.
    /// </summary>
    [TerraformPropertyName("network_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "network_ip");

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, IDPF, MRDMA, and IRDMA
    /// </summary>
    [TerraformPropertyName("nic_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NicType { get; set; }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    [TerraformPropertyName("queue_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QueueCount { get; set; }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StackType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "stack_type");

    /// <summary>
    /// The name or self_link of the subnetwork attached to this interface.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Subnetwork { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "subnetwork");

    /// <summary>
    /// The project in which the subnetwork belongs.
    /// </summary>
    [TerraformPropertyName("subnetwork_project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetworkProject { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "subnetwork_project");

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkPerformanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformPropertyName("total_egress_bandwidth_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceParamsBlock : ITerraformBlock
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceReservationAffinityBlock : ITerraformBlock
{
    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSchedulingBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user).
    /// </summary>
    [TerraformPropertyName("automatic_restart")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticRestart { get; set; }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    [TerraformPropertyName("availability_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AvailabilityDomain { get; set; }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    [TerraformPropertyName("instance_termination_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceTerminationAction { get; set; }

    /// <summary>
    /// The min_node_cpus attribute.
    /// </summary>
    [TerraformPropertyName("min_node_cpus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinNodeCpus { get; set; }

    /// <summary>
    /// Describes maintenance behavior for the instance. One of MIGRATE or TERMINATE,
    /// </summary>
    [TerraformPropertyName("on_host_maintenance")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OnHostMaintenance { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "on_host_maintenance");

    /// <summary>
    /// Whether the instance is preemptible.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Preemptible { get; set; }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    [TerraformPropertyName("provisioning_model")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProvisioningModel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "provisioning_model");

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    [TerraformPropertyName("termination_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TerminationTime { get; set; }

}

/// <summary>
/// Block type for scratch_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceScratchDiskBlock : ITerraformBlock
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeviceName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "device_name");

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interface is required")]
    [TerraformPropertyName("interface")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Interface { get; set; }

    /// <summary>
    /// The size of the disk in gigabytes. One of 375 or 3000.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Size { get; set; }

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceServiceAccountBlock : ITerraformBlock
{
    /// <summary>
    /// The service account e-mail address.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Email { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "email");

    /// <summary>
    /// A list of service scopes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Scopes { get; set; }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceShieldedInstanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether integrity monitoring is enabled for the instance.
    /// </summary>
    [TerraformPropertyName("enable_integrity_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableIntegrityMonitoring { get; set; }

    /// <summary>
    /// Whether secure boot is enabled for the instance.
    /// </summary>
    [TerraformPropertyName("enable_secure_boot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSecureBoot { get; set; }

    /// <summary>
    /// Whether the instance uses vTPM.
    /// </summary>
    [TerraformPropertyName("enable_vtpm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableVtpm { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInstance : TerraformResource
{
    public GoogleComputeInstance(string name) : base("google_compute_instance", name)
    {
    }

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    [TerraformPropertyName("allow_stopping_for_update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowStoppingForUpdate { get; set; }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CanIpForward { get; set; }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    [TerraformPropertyName("desired_status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DesiredStatus { get; set; }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    [TerraformPropertyName("enable_display")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableDisplay { get; set; }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    [TerraformPropertyName("machine_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetadataStartupScript { get; set; }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinCpuPlatform { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "min_cpu_platform");

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ResourcePolicies { get; set; }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    [TerraformPropertyName("advanced_machine_features")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceAdvancedMachineFeaturesBlock>>? AdvancedMachineFeatures { get; set; } = new();

    /// <summary>
    /// Block for attached_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("attached_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceAttachedDiskBlock>>? AttachedDisk { get; set; } = new();

    /// <summary>
    /// Block for boot_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    [TerraformPropertyName("boot_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceBootDiskBlock>>? BootDisk { get; set; } = new();

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    [TerraformPropertyName("confidential_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceConfidentialInstanceConfigBlock>>? ConfidentialInstanceConfig { get; set; } = new();

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGuestAcceleratorBlock>>? GuestAccelerator { get; set; } = new();

    /// <summary>
    /// Block for instance_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceEncryptionKey block(s) allowed")]
    [TerraformPropertyName("instance_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceInstanceEncryptionKeyBlock>>? InstanceEncryptionKey { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceNetworkInterfaceBlock>>? NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformPropertyName("network_performance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; } = new();

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceParamsBlock>>? Params { get; set; } = new();

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformPropertyName("reservation_affinity")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceReservationAffinityBlock>>? ReservationAffinity { get; set; } = new();

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    [TerraformPropertyName("scheduling")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceSchedulingBlock>>? Scheduling { get; set; } = new();

    /// <summary>
    /// Block for scratch_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scratch_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceScratchDiskBlock>>? ScratchDisk { get; set; } = new();

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    [TerraformPropertyName("service_account")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceServiceAccountBlock>>? ServiceAccount { get; set; } = new();

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformPropertyName("shielded_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    [TerraformPropertyName("cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CpuPlatform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cpu_platform");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    [TerraformPropertyName("current_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformPropertyName("metadata_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetadataFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata_fingerprint");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformPropertyName("tags_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TagsFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tags_fingerprint");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
