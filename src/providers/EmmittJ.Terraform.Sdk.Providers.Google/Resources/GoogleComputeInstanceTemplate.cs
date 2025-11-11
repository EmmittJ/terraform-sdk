using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    [TerraformProperty("enable_nested_virtualization")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNestedVirtualization { get; set; }

    /// <summary>
    /// Whether to enable UEFI networking or not.
    /// </summary>
    [TerraformProperty("enable_uefi_networking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableUefiNetworking { get; set; }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    [TerraformProperty("performance_monitoring_unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PerformanceMonitoringUnit { get; set; }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [TerraformProperty("threads_per_core")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ThreadsPerCore { get; set; }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    [TerraformProperty("turbo_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TurboMode { get; set; }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    [TerraformProperty("visible_core_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VisibleCoreCount { get; set; }

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock : TerraformBlockBase
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
    public partial TerraformValue<string>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release.
    /// </summary>
    [TerraformProperty("enable_confidential_compute")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableConfidentialCompute { get; set; }

}

/// <summary>
/// Block type for disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The architecture of the image. Allowed values are ARM64 or X86_64.
    /// </summary>
    [TerraformProperty("architecture")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Architecture { get; set; }

    /// <summary>
    /// Whether or not the disk should be auto-deleted. This defaults to true.
    /// </summary>
    [TerraformProperty("auto_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoDelete { get; set; }

    /// <summary>
    /// Indicates that this is a boot disk.
    /// </summary>
    [TerraformProperty("boot")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Boot { get; set; }

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// Name of the disk. When not provided, this defaults to the name of the instance.
    /// </summary>
    [TerraformProperty("disk_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskName { get; set; }

    /// <summary>
    /// The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The Google Compute Engine disk type. Such as &amp;quot;pd-ssd&amp;quot;, &amp;quot;local-ssd&amp;quot;, &amp;quot;pd-balanced&amp;quot; or &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    [TerraformProperty("disk_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskType { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    [TerraformProperty("guest_os_features")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk.
    /// </summary>
    [TerraformProperty("interface")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Interface { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to disks,
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk) or the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks) depending on the selected disk_type.
    /// </summary>
    [TerraformProperty("provisioned_iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ProvisionedIops { get; set; }

    /// <summary>
    /// Indicates how much throughput to provision for the disk, in MB/s. This sets the amount of data that can be read or written from the disk per second. Values must greater than or equal to 1. For more details, see the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks).
    /// </summary>
    [TerraformProperty("provisioned_throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ProvisionedThroughput { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// A list (short name or id) of resource policies to attach to this disk. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformProperty("resource_policies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// The image from which to initialize this disk. This can be one of: the image&#39;s self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    [TerraformProperty("source_image")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceImage { get; set; }

    /// <summary>
    /// The source snapshot to create this disk. When creating
    /// a new instance, one of initializeParams.sourceSnapshot,
    /// initializeParams.sourceImage, or disks.source is
    /// required except for local SSD.
    /// </summary>
    [TerraformProperty("source_snapshot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceSnapshot { get; set; }

    /// <summary>
    /// The type of Google Compute Engine disk, can be either &amp;quot;SCRATCH&amp;quot; or &amp;quot;PERSISTENT&amp;quot;.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateGuestAcceleratorBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateNetworkInterfaceBlock : TerraformBlockBase
{
    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    [TerraformProperty("internal_ipv6_prefix_length")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> InternalIpv6PrefixLength { get; set; }


    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    [TerraformProperty("ipv6_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv6Address { get; set; }


    /// <summary>
    /// The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The private IP address to assign to the instance. If empty, the address will be automatically assigned.
    /// </summary>
    [TerraformProperty("network_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkIp { get; set; }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, MRDMA, and IRDMA
    /// </summary>
    [TerraformProperty("nic_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NicType { get; set; }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    [TerraformProperty("queue_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueueCount { get; set; }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    [TerraformProperty("stack_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StackType { get; set; }

    /// <summary>
    /// The name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Subnetwork { get; set; }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("subnetwork_project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetworkProject { get; set; }

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformProperty("total_egress_bandwidth_tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateReservationAffinityBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateSchedulingBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.
    /// </summary>
    [TerraformProperty("automatic_restart")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticRestart { get; set; }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    [TerraformProperty("availability_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AvailabilityDomain { get; set; }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    [TerraformProperty("instance_termination_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceTerminationAction { get; set; }

    /// <summary>
    /// Minimum number of cpus for the instance.
    /// </summary>
    [TerraformProperty("min_node_cpus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinNodeCpus { get; set; }

    /// <summary>
    /// Defines the maintenance behavior for this instance.
    /// </summary>
    [TerraformProperty("on_host_maintenance")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OnHostMaintenance { get; set; }

    /// <summary>
    /// Allows instance to be preempted. This defaults to false.
    /// </summary>
    [TerraformProperty("preemptible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Preemptible { get; set; }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    [TerraformProperty("provisioning_model")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProvisioningModel { get; set; }

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    [TerraformProperty("termination_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TerminationTime { get; set; }

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateServiceAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The service account e-mail address. If not given, the default Google Compute Engine service account is used.
    /// </summary>
    [TerraformProperty("email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Scopes { get; set; }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInstanceTemplateShieldedInstanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.
    /// </summary>
    [TerraformProperty("enable_integrity_monitoring")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableIntegrityMonitoring { get; set; }

    /// <summary>
    /// Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.
    /// </summary>
    [TerraformProperty("enable_secure_boot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSecureBoot { get; set; }

    /// <summary>
    /// Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.
    /// </summary>
    [TerraformProperty("enable_vtpm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableVtpm { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeInstanceTemplateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_instance_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeInstanceTemplate : TerraformResource
{
    public GoogleComputeInstanceTemplate(string name) : base("google_compute_instance_template", name)
    {
    }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [TerraformProperty("can_ip_forward")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CanIpForward { get; set; }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformProperty("instance_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceDescription { get; set; }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformProperty("key_revocation_action_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    [TerraformProperty("machine_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [TerraformProperty("metadata_startup_script")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetadataStartupScript { get; set; }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    [TerraformProperty("min_cpu_platform")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinCpuPlatform { get; set; }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags.
    /// 				Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// 				The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformProperty("resource_policies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tags { get; set; }

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    [TerraformProperty("advanced_machine_features")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock>>? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    [TerraformProperty("confidential_instance_config")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock>>? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// Block for disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Disk block(s) required")]
    [TerraformProperty("disk")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateDiskBlock>>? Disk { get; set; }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("guest_accelerator")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateGuestAcceleratorBlock>>? GuestAccelerator { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_interface")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformProperty("network_performance_config")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformProperty("reservation_affinity")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateReservationAffinityBlock>>? ReservationAffinity { get; set; }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    [TerraformProperty("scheduling")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateSchedulingBlock>>? Scheduling { get; set; }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    [TerraformProperty("service_account")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateServiceAccountBlock>>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformProperty("shielded_instance_config")]
    public partial TerraformList<TerraformBlock<GoogleComputeInstanceTemplateShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeInstanceTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformProperty("metadata_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetadataFingerprint { get; }

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    [TerraformProperty("numeric_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NumericId { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// A special URI of the created resource that uniquely identifies this instance template.
    /// </summary>
    [TerraformProperty("self_link_unique")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLinkUnique { get; }

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformProperty("tags_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TagsFingerprint { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
