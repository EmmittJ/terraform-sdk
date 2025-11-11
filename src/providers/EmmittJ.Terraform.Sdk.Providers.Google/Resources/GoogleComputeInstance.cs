using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceAdvancedMachineFeaturesBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    [TerraformProperty("enable_nested_virtualization")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableNestedVirtualization { get; set; }

    /// <summary>
    /// Whether to enable UEFI networking for the instance.
    /// </summary>
    [TerraformProperty("enable_uefi_networking")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableUefiNetworking { get; set; }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    [TerraformProperty("performance_monitoring_unit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PerformanceMonitoringUnit { get; set; }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [TerraformProperty("threads_per_core")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ThreadsPerCore { get; set; }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    [TerraformProperty("turbo_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TurboMode { get; set; }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    [TerraformProperty("visible_core_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? VisibleCoreCount { get; set; }

}

/// <summary>
/// Block type for attached_disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceAttachedDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformProperty("disk_encryption_key_raw")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionKeyRaw { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformProperty("disk_encryption_key_rsa")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionKeyRsa { get; set; }


    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    [TerraformProperty("disk_encryption_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionServiceAccount { get; set; }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    [TerraformProperty("force_attach")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceAttach { get; set; }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeySelfLink { get; set; }

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for boot_disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceBootDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether the disk will be auto-deleted when the instance is deleted.
    /// </summary>
    [TerraformProperty("auto_delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoDelete { get; set; }

    /// <summary>
    /// Name with which attached disk will be accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformProperty("disk_encryption_key_raw")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionKeyRaw { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformProperty("disk_encryption_key_rsa")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionKeyRsa { get; set; }


    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    [TerraformProperty("disk_encryption_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionServiceAccount { get; set; }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    [TerraformProperty("force_attach")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceAttach { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    [TerraformProperty("guest_os_features")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> GuestOsFeatures { get; set; }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is shared with attached_disk and only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    [TerraformProperty("interface")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Interface { get; set; }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeySelfLink { get; set; }

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [TerraformProperty("source")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceConfidentialInstanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// 
    /// 								The confidential computing technology the instance uses.
    /// 								SEV is an AMD feature. TDX is an Intel feature. One of the following
    /// 								values is required: SEV, SEV_SNP, TDX. If SEV_SNP, min_cpu_platform =
    /// 								&amp;quot;AMD Milan&amp;quot; is currently required.
    /// </summary>
    [TerraformProperty("confidential_instance_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release
    /// </summary>
    [TerraformProperty("enable_confidential_compute")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableConfidentialCompute { get; set; }

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceGuestAcceleratorBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The accelerator type resource exposed to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for instance_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceInstanceEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    [TerraformProperty("kms_key_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }


}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceNetworkInterfaceBlock : TerraformBlockBase
{
    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    [TerraformProperty("internal_ipv6_prefix_length")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> InternalIpv6PrefixLength { get; set; }


    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    [TerraformProperty("ipv6_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Ipv6Address { get; set; }


    /// <summary>
    /// The name or self_link of the network attached to this interface.
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.
    /// </summary>
    [TerraformProperty("network_attachment")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkAttachment { get; set; }

    /// <summary>
    /// The private IP address assigned to the instance.
    /// </summary>
    [TerraformProperty("network_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkIp { get; set; }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, IDPF, MRDMA, and IRDMA
    /// </summary>
    [TerraformProperty("nic_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NicType { get; set; }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    [TerraformProperty("queue_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? QueueCount { get; set; }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    [TerraformProperty("stack_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StackType { get; set; }

    /// <summary>
    /// The name or self_link of the subnetwork attached to this interface.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Subnetwork { get; set; }

    /// <summary>
    /// The project in which the subnetwork belongs.
    /// </summary>
    [TerraformProperty("subnetwork_project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubnetworkProject { get; set; }

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceNetworkPerformanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformProperty("total_egress_bandwidth_tier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceParamsBlock : TerraformBlockBase
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceReservationAffinityBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceSchedulingBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user).
    /// </summary>
    [TerraformProperty("automatic_restart")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticRestart { get; set; }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    [TerraformProperty("availability_domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AvailabilityDomain { get; set; }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    [TerraformProperty("instance_termination_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceTerminationAction { get; set; }

    /// <summary>
    /// The min_node_cpus attribute.
    /// </summary>
    [TerraformProperty("min_node_cpus")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinNodeCpus { get; set; }

    /// <summary>
    /// Describes maintenance behavior for the instance. One of MIGRATE or TERMINATE,
    /// </summary>
    [TerraformProperty("on_host_maintenance")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OnHostMaintenance { get; set; }

    /// <summary>
    /// Whether the instance is preemptible.
    /// </summary>
    [TerraformProperty("preemptible")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Preemptible { get; set; }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    [TerraformProperty("provisioning_model")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ProvisioningModel { get; set; }

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    [TerraformProperty("termination_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TerminationTime { get; set; }

}

/// <summary>
/// Block type for scratch_disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceScratchDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interface is required")]
    [TerraformProperty("interface")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Interface { get; set; }

    /// <summary>
    /// The size of the disk in gigabytes. One of 375 or 3000.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Size { get; set; }

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceServiceAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The service account e-mail address.
    /// </summary>
    [TerraformProperty("email")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Email { get; set; }

    /// <summary>
    /// A list of service scopes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Scopes { get; set; }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceShieldedInstanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether integrity monitoring is enabled for the instance.
    /// </summary>
    [TerraformProperty("enable_integrity_monitoring")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableIntegrityMonitoring { get; set; }

    /// <summary>
    /// Whether secure boot is enabled for the instance.
    /// </summary>
    [TerraformProperty("enable_secure_boot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableSecureBoot { get; set; }

    /// <summary>
    /// Whether the instance uses vTPM.
    /// </summary>
    [TerraformProperty("enable_vtpm")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableVtpm { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeInstance : TerraformResource
{
    public GoogleComputeInstance(string name) : base("google_compute_instance", name)
    {
    }

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    [TerraformProperty("allow_stopping_for_update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowStoppingForUpdate { get; set; }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    [TerraformProperty("can_ip_forward")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CanIpForward { get; set; }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    [TerraformProperty("desired_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DesiredStatus { get; set; }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    [TerraformProperty("enable_display")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableDisplay { get; set; }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformProperty("hostname")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformProperty("key_revocation_action_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    [TerraformProperty("machine_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    [TerraformProperty("metadata_startup_script")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetadataStartupScript { get; set; }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    [TerraformProperty("min_cpu_platform")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MinCpuPlatform { get; set; }

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformProperty("resource_policies")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Tags { get; set; }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    [TerraformProperty("advanced_machine_features")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceAdvancedMachineFeaturesBlock>>? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Block for attached_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("attached_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceAttachedDiskBlock>>? AttachedDisk { get; set; }

    /// <summary>
    /// Block for boot_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    [TerraformProperty("boot_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceBootDiskBlock>>? BootDisk { get; set; }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    [TerraformProperty("confidential_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceConfidentialInstanceConfigBlock>>? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("guest_accelerator")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGuestAcceleratorBlock>>? GuestAccelerator { get; set; }

    /// <summary>
    /// Block for instance_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceEncryptionKey block(s) allowed")]
    [TerraformProperty("instance_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceInstanceEncryptionKeyBlock>>? InstanceEncryptionKey { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    [TerraformProperty("network_interface")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformProperty("network_performance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformProperty("params")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformProperty("reservation_affinity")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceReservationAffinityBlock>>? ReservationAffinity { get; set; }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    [TerraformProperty("scheduling")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceSchedulingBlock>>? Scheduling { get; set; }

    /// <summary>
    /// Block for scratch_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("scratch_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceScratchDiskBlock>>? ScratchDisk { get; set; }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    [TerraformProperty("service_account")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceServiceAccountBlock>>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformProperty("shielded_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    [TerraformProperty("cpu_platform")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CpuPlatform { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    [TerraformProperty("current_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CurrentStatus { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceId { get; }

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformProperty("metadata_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MetadataFingerprint { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformProperty("tags_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TagsFingerprint { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
