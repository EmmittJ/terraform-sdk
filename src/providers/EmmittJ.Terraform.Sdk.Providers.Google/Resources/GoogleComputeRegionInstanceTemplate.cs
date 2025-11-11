using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateAdvancedMachineFeaturesBlock
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    [TerraformPropertyName("enable_nested_virtualization")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableNestedVirtualization { get; set; }

    /// <summary>
    /// Whether to enable UEFI networking or not.
    /// </summary>
    [TerraformPropertyName("enable_uefi_networking")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableUefiNetworking { get; set; }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    [TerraformPropertyName("performance_monitoring_unit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PerformanceMonitoringUnit { get; set; }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [TerraformPropertyName("threads_per_core")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ThreadsPerCore { get; set; }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    [TerraformPropertyName("turbo_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TurboMode { get; set; }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    [TerraformPropertyName("visible_core_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VisibleCoreCount { get; set; }

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateConfidentialInstanceConfigBlock
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
    public TerraformValue<string>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release.
    /// </summary>
    [TerraformPropertyName("enable_confidential_compute")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableConfidentialCompute { get; set; }

}

/// <summary>
/// Block type for disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateDiskBlock
{
    /// <summary>
    /// The architecture of the image. Allowed values are ARM64 or X86_64.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Architecture { get; set; } = default!;

    /// <summary>
    /// Whether or not the disk should be auto-deleted. This defaults to true.
    /// </summary>
    [TerraformPropertyName("auto_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoDelete { get; set; }

    /// <summary>
    /// Indicates that this is a boot disk.
    /// </summary>
    [TerraformPropertyName("boot")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Boot { get; set; } = default!;

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DeviceName { get; set; } = default!;

    /// <summary>
    /// Name of the disk. When not provided, this defaults to the name of the instance.
    /// </summary>
    [TerraformPropertyName("disk_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskName { get; set; }

    /// <summary>
    /// The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The Google Compute Engine disk type. Such as &amp;quot;pd-ssd&amp;quot;, &amp;quot;local-ssd&amp;quot;, &amp;quot;pd-balanced&amp;quot; or &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskType { get; set; } = default!;

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    [TerraformPropertyName("guest_os_features")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk.
    /// </summary>
    [TerraformPropertyName("interface")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Interface { get; set; } = default!;

    /// <summary>
    /// A set of key/value label pairs to assign to disks,
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk) or the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks) depending on the selected disk_type.
    /// </summary>
    [TerraformPropertyName("provisioned_iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ProvisionedIops { get; set; } = default!;

    /// <summary>
    /// Indicates how much throughput to provision for the disk, in MB/s. This sets the amount of data that can be read or written from the disk per second. Values must greater than or equal to 1. For more details, see the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks).
    /// </summary>
    [TerraformPropertyName("provisioned_throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ProvisionedThroughput { get; set; } = default!;

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// A list (short name or id) of resource policies to attach to this disk. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// The image from which to initialize this disk. This can be one of: the image&#39;s self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    [TerraformPropertyName("source_image")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SourceImage { get; set; } = default!;

    /// <summary>
    /// The source snapshot to create this disk. When creating
    /// a new instance, one of initializeParams.sourceSnapshot,
    /// initializeParams.sourceImage, or disks.source is
    /// required except for local SSD.
    /// </summary>
    [TerraformPropertyName("source_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceSnapshot { get; set; }

    /// <summary>
    /// The type of Google Compute Engine disk, can be either &amp;quot;SCRATCH&amp;quot; or &amp;quot;PERSISTENT&amp;quot;.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Type { get; set; } = default!;

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateGuestAcceleratorBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock
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
    /// The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Network { get; set; } = default!;

    /// <summary>
    /// The private IP address to assign to the instance. If empty, the address will be automatically assigned.
    /// </summary>
    [TerraformPropertyName("network_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkIp { get; set; }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, MRDMA, and IRDMA
    /// </summary>
    [TerraformPropertyName("nic_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NicType { get; set; }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    [TerraformPropertyName("queue_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? QueueCount { get; set; }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StackType { get; set; } = default!;

    /// <summary>
    /// The name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Subnetwork { get; set; } = default!;

    /// <summary>
    /// The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("subnetwork_project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SubnetworkProject { get; set; } = default!;

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateNetworkPerformanceConfigBlock
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
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateReservationAffinityBlock
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
public class GoogleComputeRegionInstanceTemplateSchedulingBlock
{
    /// <summary>
    /// Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.
    /// </summary>
    [TerraformPropertyName("automatic_restart")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticRestart { get; set; }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    [TerraformPropertyName("availability_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AvailabilityDomain { get; set; }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    [TerraformPropertyName("instance_termination_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceTerminationAction { get; set; }

    /// <summary>
    /// Minimum number of cpus for the instance.
    /// </summary>
    [TerraformPropertyName("min_node_cpus")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinNodeCpus { get; set; }

    /// <summary>
    /// Defines the maintenance behavior for this instance.
    /// </summary>
    [TerraformPropertyName("on_host_maintenance")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OnHostMaintenance { get; set; } = default!;

    /// <summary>
    /// Allows instance to be preempted. This defaults to false.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Preemptible { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TerminationTime { get; set; }

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceTemplateServiceAccountBlock
{
    /// <summary>
    /// The service account e-mail address. If not given, the default Google Compute Engine service account is used.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Email { get; set; } = default!;

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.
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
public class GoogleComputeRegionInstanceTemplateShieldedInstanceConfigBlock
{
    /// <summary>
    /// Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_integrity_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableIntegrityMonitoring { get; set; }

    /// <summary>
    /// Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.
    /// </summary>
    [TerraformPropertyName("enable_secure_boot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableSecureBoot { get; set; }

    /// <summary>
    /// Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_vtpm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableVtpm { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionInstanceTemplateTimeoutsBlock
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

}

/// <summary>
/// Manages a google_compute_region_instance_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionInstanceTemplate : TerraformResource
{
    public GoogleComputeRegionInstanceTemplate(string name) : base("google_compute_region_instance_template", name)
    {
    }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CanIpForward { get; set; }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformPropertyName("instance_description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceDescription { get; set; }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    [TerraformPropertyName("machine_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetadataStartupScript { get; set; }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinCpuPlatform { get; set; }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tags { get; set; }

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    [TerraformPropertyName("advanced_machine_features")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateAdvancedMachineFeaturesBlock>>? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    [TerraformPropertyName("confidential_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateConfidentialInstanceConfigBlock>>? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// Block for disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Disk block(s) required")]
    [TerraformPropertyName("disk")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateDiskBlock>>? Disk { get; set; }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateGuestAcceleratorBlock>>? GuestAccelerator { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformPropertyName("network_performance_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformPropertyName("reservation_affinity")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateReservationAffinityBlock>>? ReservationAffinity { get; set; }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    [TerraformPropertyName("scheduling")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateSchedulingBlock>>? Scheduling { get; set; }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    [TerraformPropertyName("service_account")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateServiceAccountBlock>>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformPropertyName("shielded_instance_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionInstanceTemplateShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionInstanceTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformPropertyName("metadata_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetadataFingerprint => new TerraformReference(this, "metadata_fingerprint");

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    [TerraformPropertyName("numeric_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NumericId => new TerraformReference(this, "numeric_id");

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
