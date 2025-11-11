using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateAdvancedMachineFeaturesBlock
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    [TerraformPropertyName("enable_nested_virtualization")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableNestedVirtualization { get; set; } = default!;

    /// <summary>
    /// Whether to enable UEFI networking for the instance.
    /// </summary>
    [TerraformPropertyName("enable_uefi_networking")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableUefiNetworking { get; set; } = default!;

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    [TerraformPropertyName("performance_monitoring_unit")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PerformanceMonitoringUnit { get; set; } = default!;

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [TerraformPropertyName("threads_per_core")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ThreadsPerCore { get; set; } = default!;

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    [TerraformPropertyName("turbo_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TurboMode { get; set; } = default!;

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    [TerraformPropertyName("visible_core_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> VisibleCoreCount { get; set; } = default!;

}

/// <summary>
/// Block type for attached_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateAttachedDiskBlock
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DeviceName { get; set; } = default!;

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_raw")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskEncryptionKeyRaw { get; set; } = default!;

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_rsa")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskEncryptionKeyRsa { get; set; } = default!;


    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    [TerraformPropertyName("disk_encryption_service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskEncryptionServiceAccount { get; set; } = default!;

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    [TerraformPropertyName("force_attach")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ForceAttach { get; set; } = default!;

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeySelfLink { get; set; } = default!;

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for boot_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateBootDiskBlock
{
    /// <summary>
    /// Whether the disk will be auto-deleted when the instance is deleted.
    /// </summary>
    [TerraformPropertyName("auto_delete")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AutoDelete { get; set; } = default!;

    /// <summary>
    /// Name with which attached disk will be accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DeviceName { get; set; } = default!;

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_raw")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskEncryptionKeyRaw { get; set; } = default!;

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_rsa")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskEncryptionKeyRsa { get; set; } = default!;


    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    [TerraformPropertyName("disk_encryption_service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskEncryptionServiceAccount { get; set; } = default!;

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    [TerraformPropertyName("force_attach")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ForceAttach { get; set; } = default!;

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    [TerraformPropertyName("guest_os_features")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> GuestOsFeatures { get; set; } = default!;

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is shared with attached_disk and only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    [TerraformPropertyName("interface")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Interface { get; set; } = default!;

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeySelfLink { get; set; } = default!;

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Source { get; set; } = default!;

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateConfidentialInstanceConfigBlock
{
    /// <summary>
    /// 
    /// 								The confidential computing technology the instance uses.
    /// 								SEV is an AMD feature. TDX is an Intel feature. One of the following
    /// 								values is required: SEV, SEV_SNP, TDX. If SEV_SNP, min_cpu_platform =
    /// 								&amp;quot;AMD Milan&amp;quot; is currently required.
    /// </summary>
    [TerraformPropertyName("confidential_instance_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ConfidentialInstanceType { get; set; } = default!;

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release
    /// </summary>
    [TerraformPropertyName("enable_confidential_compute")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableConfidentialCompute { get; set; } = default!;

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateGuestAcceleratorBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The accelerator type resource exposed to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for instance_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateInstanceEncryptionKeyBlock
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeySelfLink { get; set; } = default!;

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyServiceAccount { get; set; } = default!;


}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateNetworkInterfaceBlock
{
    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_prefix_length")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> InternalIpv6PrefixLength { get; set; } = default!;


    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    [TerraformPropertyName("ipv6_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ipv6Address { get; set; } = default!;


    /// <summary>
    /// The name or self_link of the network attached to this interface.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Network { get; set; } = default!;

    /// <summary>
    /// The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.
    /// </summary>
    [TerraformPropertyName("network_attachment")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkAttachment { get; set; } = default!;

    /// <summary>
    /// The private IP address assigned to the instance.
    /// </summary>
    [TerraformPropertyName("network_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkIp { get; set; } = default!;

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, IDPF, MRDMA, and IRDMA
    /// </summary>
    [TerraformPropertyName("nic_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NicType { get; set; } = default!;

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    [TerraformPropertyName("queue_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> QueueCount { get; set; } = default!;

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StackType { get; set; } = default!;

    /// <summary>
    /// The name or self_link of the subnetwork attached to this interface.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Subnetwork { get; set; } = default!;

    /// <summary>
    /// The project in which the subnetwork belongs.
    /// </summary>
    [TerraformPropertyName("subnetwork_project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SubnetworkProject { get; set; } = default!;

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateNetworkPerformanceConfigBlock
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformPropertyName("total_egress_bandwidth_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateParamsBlock
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> ResourceManagerTags { get; set; } = default!;

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateReservationAffinityBlock
{
    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateSchedulingBlock
{
    /// <summary>
    /// Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user).
    /// </summary>
    [TerraformPropertyName("automatic_restart")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AutomaticRestart { get; set; } = default!;

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    [TerraformPropertyName("availability_domain")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AvailabilityDomain { get; set; } = default!;

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    [TerraformPropertyName("instance_termination_action")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceTerminationAction { get; set; } = default!;

    /// <summary>
    /// The min_node_cpus attribute.
    /// </summary>
    [TerraformPropertyName("min_node_cpus")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MinNodeCpus { get; set; } = default!;

    /// <summary>
    /// Describes maintenance behavior for the instance. One of MIGRATE or TERMINATE,
    /// </summary>
    [TerraformPropertyName("on_host_maintenance")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OnHostMaintenance { get; set; } = default!;

    /// <summary>
    /// Whether the instance is preemptible.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Preemptible { get; set; } = default!;

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    [TerraformPropertyName("provisioning_model")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProvisioningModel { get; set; } = default!;

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    [TerraformPropertyName("termination_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TerminationTime { get; set; } = default!;

}

/// <summary>
/// Block type for scratch_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateScratchDiskBlock
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DeviceName { get; set; } = default!;

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interface is required")]
    [TerraformPropertyName("interface")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Interface { get; set; }

    /// <summary>
    /// The size of the disk in gigabytes. One of 375 or 3000.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Size { get; set; } = default!;

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateServiceAccountBlock
{
    /// <summary>
    /// The service account e-mail address.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Email { get; set; } = default!;

    /// <summary>
    /// A list of service scopes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Scopes { get; set; }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceFromTemplateShieldedInstanceConfigBlock
{
    /// <summary>
    /// Whether integrity monitoring is enabled for the instance.
    /// </summary>
    [TerraformPropertyName("enable_integrity_monitoring")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableIntegrityMonitoring { get; set; } = default!;

    /// <summary>
    /// Whether secure boot is enabled for the instance.
    /// </summary>
    [TerraformPropertyName("enable_secure_boot")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableSecureBoot { get; set; } = default!;

    /// <summary>
    /// Whether the instance uses vTPM.
    /// </summary>
    [TerraformPropertyName("enable_vtpm")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableVtpm { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceFromTemplateTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_instance_from_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInstanceFromTemplate : TerraformResource
{
    public GoogleComputeInstanceFromTemplate(string name) : base("google_compute_instance_from_template", name)
    {
    }

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    [TerraformPropertyName("allow_stopping_for_update")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AllowStoppingForUpdate { get; set; } = default!;

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> CanIpForward { get; set; } = default!;

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DeletionProtection { get; set; } = default!;

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    [TerraformPropertyName("desired_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DesiredStatus { get; set; } = default!;

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    [TerraformPropertyName("enable_display")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableDisplay { get; set; } = default!;

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Hostname { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyRevocationActionType { get; set; } = default!;

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Labels { get; set; } = default!;

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MachineType { get; set; } = default!;

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Metadata { get; set; } = default!;

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MetadataStartupScript { get; set; } = default!;

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MinCpuPlatform { get; set; } = default!;

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ResourcePolicies { get; set; } = default!;

    /// <summary>
    /// Name or self link of an instance template to create the instance based on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceTemplate is required")]
    [TerraformPropertyName("source_instance_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceInstanceTemplate { get; set; }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Tags { get; set; } = default!;

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Zone { get; set; } = default!;

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    [TerraformPropertyName("advanced_machine_features")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateAdvancedMachineFeaturesBlock>>? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Block for attached_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("attached_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateAttachedDiskBlock>>? AttachedDisk { get; set; }

    /// <summary>
    /// Block for boot_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    [TerraformPropertyName("boot_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateBootDiskBlock>>? BootDisk { get; set; }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    [TerraformPropertyName("confidential_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateConfidentialInstanceConfigBlock>>? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateGuestAcceleratorBlock>>? GuestAccelerator { get; set; }

    /// <summary>
    /// Block for instance_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceEncryptionKey block(s) allowed")]
    [TerraformPropertyName("instance_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateInstanceEncryptionKeyBlock>>? InstanceEncryptionKey { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformPropertyName("network_performance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformPropertyName("reservation_affinity")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateReservationAffinityBlock>>? ReservationAffinity { get; set; }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    [TerraformPropertyName("scheduling")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateSchedulingBlock>>? Scheduling { get; set; }

    /// <summary>
    /// Block for scratch_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scratch_disk")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateScratchDiskBlock>>? ScratchDisk { get; set; }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    [TerraformPropertyName("service_account")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateServiceAccountBlock>>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformPropertyName("shielded_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceFromTemplateShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeInstanceFromTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    [TerraformPropertyName("cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CpuPlatform => new TerraformReference(this, "cpu_platform");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    [TerraformPropertyName("current_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrentStatus => new TerraformReference(this, "current_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceId => new TerraformReference(this, "instance_id");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformPropertyName("metadata_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetadataFingerprint => new TerraformReference(this, "metadata_fingerprint");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformPropertyName("tags_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TagsFingerprint => new TerraformReference(this, "tags_fingerprint");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
