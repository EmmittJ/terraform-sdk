using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    public TerraformProperty<bool>? EnableNestedVirtualization
    {
        get => GetProperty<TerraformProperty<bool>>("enable_nested_virtualization");
        set => WithProperty("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Whether to enable UEFI networking for the instance.
    /// </summary>
    public TerraformProperty<bool>? EnableUefiNetworking
    {
        get => GetProperty<TerraformProperty<bool>>("enable_uefi_networking");
        set => WithProperty("enable_uefi_networking", value);
    }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? PerformanceMonitoringUnit
    {
        get => GetProperty<TerraformProperty<string>>("performance_monitoring_unit");
        set => WithProperty("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    public TerraformProperty<double>? ThreadsPerCore
    {
        get => GetProperty<TerraformProperty<double>>("threads_per_core");
        set => WithProperty("threads_per_core", value);
    }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? TurboMode
    {
        get => GetProperty<TerraformProperty<string>>("turbo_mode");
        set => WithProperty("turbo_mode", value);
    }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    public TerraformProperty<double>? VisibleCoreCount
    {
        get => GetProperty<TerraformProperty<double>>("visible_core_count");
        set => WithProperty("visible_core_count", value);
    }

}

/// <summary>
/// Block type for attached_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceAttachedDiskBlock : TerraformBlock
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionKeyRaw
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_key_raw");
        set => WithProperty("disk_encryption_key_raw", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionKeyRsa
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_key_rsa");
        set => WithProperty("disk_encryption_key_rsa", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionKeySha256
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_key_sha256");
        set => WithProperty("disk_encryption_key_sha256", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_service_account");
        set => WithProperty("disk_encryption_service_account", value);
    }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    public TerraformProperty<bool>? ForceAttach
    {
        get => GetProperty<TerraformProperty<bool>>("force_attach");
        set => WithProperty("force_attach", value);
    }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_rsa and disk_encryption_key_raw may be set.
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_self_link");
        set => WithProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

}

/// <summary>
/// Block type for boot_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceBootDiskBlock : TerraformBlock
{
    /// <summary>
    /// Whether the disk will be auto-deleted when the instance is deleted.
    /// </summary>
    public TerraformProperty<bool>? AutoDelete
    {
        get => GetProperty<TerraformProperty<bool>>("auto_delete");
        set => WithProperty("auto_delete", value);
    }

    /// <summary>
    /// Name with which attached disk will be accessible under /dev/disk/by-id/
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionKeyRaw
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_key_raw");
        set => WithProperty("disk_encryption_key_raw", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionKeyRsa
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_key_rsa");
        set => WithProperty("disk_encryption_key_rsa", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionKeySha256
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_key_sha256");
        set => WithProperty("disk_encryption_key_sha256", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_service_account");
        set => WithProperty("disk_encryption_service_account", value);
    }

    /// <summary>
    /// Whether to force attach the regional disk even if it&#39;s currently attached to another instance. If you try to force attach a zonal disk to an instance, you will receive an error. Setting this parameter cause VM recreation.
    /// </summary>
    public TerraformProperty<bool>? ForceAttach
    {
        get => GetProperty<TerraformProperty<bool>>("force_attach");
        set => WithProperty("force_attach", value);
    }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    public List<TerraformProperty<string>>? GuestOsFeatures
    {
        get => GetProperty<List<TerraformProperty<string>>>("guest_os_features");
        set => WithProperty("guest_os_features", value);
    }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is shared with attached_disk and only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    public TerraformProperty<string>? Interface
    {
        get => GetProperty<TerraformProperty<string>>("interface");
        set => WithProperty("interface", value);
    }

    /// <summary>
    /// The self_link of the encryption key that is stored in Google Cloud KMS to encrypt this disk. Only one of kms_key_self_link, disk_encryption_key_raw and disk_encryption_key_rsa may be set.
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_self_link");
        set => WithProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// Read/write mode for the disk. One of &amp;quot;READ_ONLY&amp;quot; or &amp;quot;READ_WRITE&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The name or self_link of the disk attached to this instance.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceConfidentialInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// 
    /// 								The confidential computing technology the instance uses.
    /// 								SEV is an AMD feature. TDX is an Intel feature. One of the following
    /// 								values is required: SEV, SEV_SNP, TDX. If SEV_SNP, min_cpu_platform =
    /// 								&amp;quot;AMD Milan&amp;quot; is currently required.
    /// </summary>
    public TerraformProperty<string>? ConfidentialInstanceType
    {
        get => GetProperty<TerraformProperty<string>>("confidential_instance_type");
        set => WithProperty("confidential_instance_type", value);
    }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release
    /// </summary>
    public TerraformProperty<bool>? EnableConfidentialCompute
    {
        get => GetProperty<TerraformProperty<bool>>("enable_confidential_compute");
        set => WithProperty("enable_confidential_compute", value);
    }

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGuestAcceleratorBlock : TerraformBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

    /// <summary>
    /// The accelerator type resource exposed to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for instance_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceInstanceEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_self_link");
        set => WithProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_service_account");
        set => WithProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// The SHA256 hash of the customer&#39;s encryption key.
    /// </summary>
    public TerraformProperty<string>? Sha256
    {
        get => GetProperty<TerraformProperty<string>>("sha256");
        set => WithProperty("sha256", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    public TerraformProperty<double>? InternalIpv6PrefixLength
    {
        get => GetProperty<TerraformProperty<double>>("internal_ipv6_prefix_length");
        set => WithProperty("internal_ipv6_prefix_length", value);
    }

    /// <summary>
    /// One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.
    /// </summary>
    public TerraformProperty<string>? Ipv6AccessType
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_access_type");
        set => WithProperty("ipv6_access_type", value);
    }

    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    public TerraformProperty<string>? Ipv6Address
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_address");
        set => WithProperty("ipv6_address", value);
    }

    /// <summary>
    /// The name of the interface
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The name or self_link of the network attached to this interface.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.
    /// </summary>
    public TerraformProperty<string>? NetworkAttachment
    {
        get => GetProperty<TerraformProperty<string>>("network_attachment");
        set => WithProperty("network_attachment", value);
    }

    /// <summary>
    /// The private IP address assigned to the instance.
    /// </summary>
    public TerraformProperty<string>? NetworkIp
    {
        get => GetProperty<TerraformProperty<string>>("network_ip");
        set => WithProperty("network_ip", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, IDPF, MRDMA, and IRDMA
    /// </summary>
    public TerraformProperty<string>? NicType
    {
        get => GetProperty<TerraformProperty<string>>("nic_type");
        set => WithProperty("nic_type", value);
    }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    public TerraformProperty<double>? QueueCount
    {
        get => GetProperty<TerraformProperty<double>>("queue_count");
        set => WithProperty("queue_count", value);
    }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    public TerraformProperty<string>? StackType
    {
        get => GetProperty<TerraformProperty<string>>("stack_type");
        set => WithProperty("stack_type", value);
    }

    /// <summary>
    /// The name or self_link of the subnetwork attached to this interface.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => WithProperty("subnetwork", value);
    }

    /// <summary>
    /// The project in which the subnetwork belongs.
    /// </summary>
    public TerraformProperty<string>? SubnetworkProject
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork_project");
        set => WithProperty("subnetwork_project", value);
    }

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformProperty<string> TotalEgressBandwidthTier
    {
        get => GetProperty<TerraformProperty<string>>("total_egress_bandwidth_tier");
        set => WithProperty("total_egress_bandwidth_tier", value);
    }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceParamsBlock : TerraformBlock
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => WithProperty("resource_manager_tags", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user).
    /// </summary>
    public TerraformProperty<bool>? AutomaticRestart
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_restart");
        set => WithProperty("automatic_restart", value);
    }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    public TerraformProperty<double>? AvailabilityDomain
    {
        get => GetProperty<TerraformProperty<double>>("availability_domain");
        set => WithProperty("availability_domain", value);
    }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    public TerraformProperty<string>? InstanceTerminationAction
    {
        get => GetProperty<TerraformProperty<string>>("instance_termination_action");
        set => WithProperty("instance_termination_action", value);
    }

    /// <summary>
    /// The min_node_cpus attribute.
    /// </summary>
    public TerraformProperty<double>? MinNodeCpus
    {
        get => GetProperty<TerraformProperty<double>>("min_node_cpus");
        set => WithProperty("min_node_cpus", value);
    }

    /// <summary>
    /// Describes maintenance behavior for the instance. One of MIGRATE or TERMINATE,
    /// </summary>
    public TerraformProperty<string>? OnHostMaintenance
    {
        get => GetProperty<TerraformProperty<string>>("on_host_maintenance");
        set => WithProperty("on_host_maintenance", value);
    }

    /// <summary>
    /// Whether the instance is preemptible.
    /// </summary>
    public TerraformProperty<bool>? Preemptible
    {
        get => GetProperty<TerraformProperty<bool>>("preemptible");
        set => WithProperty("preemptible", value);
    }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    public TerraformProperty<string>? ProvisioningModel
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_model");
        set => WithProperty("provisioning_model", value);
    }

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    public TerraformProperty<string>? TerminationTime
    {
        get => GetProperty<TerraformProperty<string>>("termination_time");
        set => WithProperty("termination_time", value);
    }

}

/// <summary>
/// Block type for scratch_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceScratchDiskBlock : TerraformBlock
{
    /// <summary>
    /// Name with which the attached disk is accessible under /dev/disk/by-id/
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interface is required")]
    public required TerraformProperty<string> Interface
    {
        get => GetProperty<TerraformProperty<string>>("interface");
        set => WithProperty("interface", value);
    }

    /// <summary>
    /// The size of the disk in gigabytes. One of 375 or 3000.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// The service account e-mail address.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// A list of service scopes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("scopes");
        set => WithProperty("scopes", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether integrity monitoring is enabled for the instance.
    /// </summary>
    public TerraformProperty<bool>? EnableIntegrityMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("enable_integrity_monitoring");
        set => WithProperty("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Whether secure boot is enabled for the instance.
    /// </summary>
    public TerraformProperty<bool>? EnableSecureBoot
    {
        get => GetProperty<TerraformProperty<bool>>("enable_secure_boot");
        set => WithProperty("enable_secure_boot", value);
    }

    /// <summary>
    /// Whether the instance uses vTPM.
    /// </summary>
    public TerraformProperty<bool>? EnableVtpm
    {
        get => GetProperty<TerraformProperty<bool>>("enable_vtpm");
        set => WithProperty("enable_vtpm", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_instance resource.
/// </summary>
public class GoogleComputeInstance : TerraformResource
{
    public GoogleComputeInstance(string name) : base("google_compute_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cpu_platform");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("current_status");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("instance_id");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("metadata_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("tags_fingerprint");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    public TerraformProperty<bool>? AllowStoppingForUpdate
    {
        get => GetProperty<TerraformProperty<bool>>("allow_stopping_for_update");
        set => this.WithProperty("allow_stopping_for_update", value);
    }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    public TerraformProperty<bool>? CanIpForward
    {
        get => GetProperty<TerraformProperty<bool>>("can_ip_forward");
        set => this.WithProperty("can_ip_forward", value);
    }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DesiredStatus
    {
        get => GetProperty<TerraformProperty<string>>("desired_status");
        set => this.WithProperty("desired_status", value);
    }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    public TerraformProperty<bool>? EnableDisplay
    {
        get => GetProperty<TerraformProperty<bool>>("enable_display");
        set => this.WithProperty("enable_display", value);
    }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => this.WithProperty("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformProperty<string>? KeyRevocationActionType
    {
        get => GetProperty<TerraformProperty<string>>("key_revocation_action_type");
        set => this.WithProperty("key_revocation_action_type", value);
    }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformProperty<string> MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => this.WithProperty("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    public TerraformProperty<string>? MetadataStartupScript
    {
        get => GetProperty<TerraformProperty<string>>("metadata_startup_script");
        set => this.WithProperty("metadata_startup_script", value);
    }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    public TerraformProperty<string>? MinCpuPlatform
    {
        get => GetProperty<TerraformProperty<string>>("min_cpu_platform");
        set => this.WithProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public List<TerraformProperty<string>>? ResourcePolicies
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_policies");
        set => this.WithProperty("resource_policies", value);
    }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tags
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public List<GoogleComputeInstanceAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetProperty<List<GoogleComputeInstanceAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => this.WithProperty("advanced_machine_features", value);
    }

    /// <summary>
    /// Block for attached_disk.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceAttachedDiskBlock>? AttachedDisk
    {
        get => GetProperty<List<GoogleComputeInstanceAttachedDiskBlock>>("attached_disk");
        set => this.WithProperty("attached_disk", value);
    }

    /// <summary>
    /// Block for boot_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BootDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    public List<GoogleComputeInstanceBootDiskBlock>? BootDisk
    {
        get => GetProperty<List<GoogleComputeInstanceBootDiskBlock>>("boot_disk");
        set => this.WithProperty("boot_disk", value);
    }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetProperty<List<GoogleComputeInstanceConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => this.WithProperty("confidential_instance_config", value);
    }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetProperty<List<GoogleComputeInstanceGuestAcceleratorBlock>>("guest_accelerator");
        set => this.WithProperty("guest_accelerator", value);
    }

    /// <summary>
    /// Block for instance_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceEncryptionKey block(s) allowed")]
    public List<GoogleComputeInstanceInstanceEncryptionKeyBlock>? InstanceEncryptionKey
    {
        get => GetProperty<List<GoogleComputeInstanceInstanceEncryptionKeyBlock>>("instance_encryption_key");
        set => this.WithProperty("instance_encryption_key", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    public List<GoogleComputeInstanceNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<GoogleComputeInstanceNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetProperty<List<GoogleComputeInstanceNetworkPerformanceConfigBlock>>("network_performance_config");
        set => this.WithProperty("network_performance_config", value);
    }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    public List<GoogleComputeInstanceParamsBlock>? Params
    {
        get => GetProperty<List<GoogleComputeInstanceParamsBlock>>("params");
        set => this.WithProperty("params", value);
    }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public List<GoogleComputeInstanceReservationAffinityBlock>? ReservationAffinity
    {
        get => GetProperty<List<GoogleComputeInstanceReservationAffinityBlock>>("reservation_affinity");
        set => this.WithProperty("reservation_affinity", value);
    }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public List<GoogleComputeInstanceSchedulingBlock>? Scheduling
    {
        get => GetProperty<List<GoogleComputeInstanceSchedulingBlock>>("scheduling");
        set => this.WithProperty("scheduling", value);
    }

    /// <summary>
    /// Block for scratch_disk.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceScratchDiskBlock>? ScratchDisk
    {
        get => GetProperty<List<GoogleComputeInstanceScratchDiskBlock>>("scratch_disk");
        set => this.WithProperty("scratch_disk", value);
    }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public List<GoogleComputeInstanceServiceAccountBlock>? ServiceAccount
    {
        get => GetProperty<List<GoogleComputeInstanceServiceAccountBlock>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetProperty<List<GoogleComputeInstanceShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => this.WithProperty("shielded_instance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    public TerraformExpression CpuPlatform => this["cpu_platform"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    public TerraformExpression CurrentStatus => this["current_status"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    public TerraformExpression InstanceId => this["instance_id"];

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformExpression MetadataFingerprint => this["metadata_fingerprint"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformExpression TagsFingerprint => this["tags_fingerprint"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
