using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_machine_features in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Whether to enable nested virtualization or not.
    /// </summary>
    public TerraformProperty<bool>? EnableNestedVirtualization
    {
        set => SetProperty("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Whether to enable UEFI networking or not.
    /// </summary>
    public TerraformProperty<bool>? EnableUefiNetworking
    {
        set => SetProperty("enable_uefi_networking", value);
    }

    /// <summary>
    /// The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are &amp;quot;STANDARD&amp;quot;, &amp;quot;ENHANCED&amp;quot;, and &amp;quot;ARCHITECTURAL&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? PerformanceMonitoringUnit
    {
        set => SetProperty("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    public TerraformProperty<double>? ThreadsPerCore
    {
        set => SetProperty("threads_per_core", value);
    }

    /// <summary>
    /// Turbo frequency mode to use for the instance. Currently supported modes is &amp;quot;ALL_CORE_MAX&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? TurboMode
    {
        set => SetProperty("turbo_mode", value);
    }

    /// <summary>
    /// The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\&#39;s nominal CPU count and the underlying platform\&#39;s SMT width.
    /// </summary>
    public TerraformProperty<double>? VisibleCoreCount
    {
        set => SetProperty("visible_core_count", value);
    }

}

/// <summary>
/// Block type for confidential_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock : TerraformBlock
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
        set => SetProperty("confidential_instance_type", value);
    }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release.
    /// </summary>
    public TerraformProperty<bool>? EnableConfidentialCompute
    {
        set => SetProperty("enable_confidential_compute", value);
    }

}

/// <summary>
/// Block type for disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateDiskBlock : TerraformBlock
{
    /// <summary>
    /// The architecture of the image. Allowed values are ARM64 or X86_64.
    /// </summary>
    public TerraformProperty<string>? Architecture
    {
        set => SetProperty("architecture", value);
    }

    /// <summary>
    /// Whether or not the disk should be auto-deleted. This defaults to true.
    /// </summary>
    public TerraformProperty<bool>? AutoDelete
    {
        set => SetProperty("auto_delete", value);
    }

    /// <summary>
    /// Indicates that this is a boot disk.
    /// </summary>
    public TerraformProperty<bool>? Boot
    {
        set => SetProperty("boot", value);
    }

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// Name of the disk. When not provided, this defaults to the name of the instance.
    /// </summary>
    public TerraformProperty<string>? DiskName
    {
        set => SetProperty("disk_name", value);
    }

    /// <summary>
    /// The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The Google Compute Engine disk type. Such as &amp;quot;pd-ssd&amp;quot;, &amp;quot;local-ssd&amp;quot;, &amp;quot;pd-balanced&amp;quot; or &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        set => SetProperty("disk_type", value);
    }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images.
    /// </summary>
    public List<TerraformProperty<string>>? GuestOsFeatures
    {
        set => SetProperty("guest_os_features", value);
    }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk.
    /// </summary>
    public TerraformProperty<string>? Interface
    {
        set => SetProperty("interface", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to disks,
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk) or the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks) depending on the selected disk_type.
    /// </summary>
    public TerraformProperty<double>? ProvisionedIops
    {
        set => SetProperty("provisioned_iops", value);
    }

    /// <summary>
    /// Indicates how much throughput to provision for the disk, in MB/s. This sets the amount of data that can be read or written from the disk per second. Values must greater than or equal to 1. For more details, see the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks).
    /// </summary>
    public TerraformProperty<double>? ProvisionedThroughput
    {
        set => SetProperty("provisioned_throughput", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        set => SetProperty("resource_manager_tags", value);
    }

    /// <summary>
    /// A list (short name or id) of resource policies to attach to this disk. Currently a max of 1 resource policy is supported.
    /// </summary>
    public List<TerraformProperty<string>>? ResourcePolicies
    {
        set => SetProperty("resource_policies", value);
    }

    /// <summary>
    /// The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The image from which to initialize this disk. This can be one of: the image&#39;s self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformProperty<string>? SourceImage
    {
        set => SetProperty("source_image", value);
    }

    /// <summary>
    /// The source snapshot to create this disk. When creating
    /// a new instance, one of initializeParams.sourceSnapshot,
    /// initializeParams.sourceImage, or disks.source is
    /// required except for local SSD.
    /// </summary>
    public TerraformProperty<string>? SourceSnapshot
    {
        set => SetProperty("source_snapshot", value);
    }

    /// <summary>
    /// The type of Google Compute Engine disk, can be either &amp;quot;SCRATCH&amp;quot; or &amp;quot;PERSISTENT&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for guest_accelerator in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateGuestAcceleratorBlock : TerraformBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        set => SetProperty("count", value);
    }

    /// <summary>
    /// The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The prefix length of the primary internal IPv6 range.
    /// </summary>
    public TerraformProperty<double>? InternalIpv6PrefixLength
    {
        set => SetProperty("internal_ipv6_prefix_length", value);
    }

    /// <summary>
    /// One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.
    /// </summary>
    public TerraformProperty<string>? Ipv6AccessType
    {
        set => SetProperty("ipv6_access_type", value);
    }

    /// <summary>
    /// An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance&#39;s subnetwork.
    /// </summary>
    public TerraformProperty<string>? Ipv6Address
    {
        set => SetProperty("ipv6_address", value);
    }

    /// <summary>
    /// The name of the network_interface.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The private IP address to assign to the instance. If empty, the address will be automatically assigned.
    /// </summary>
    public TerraformProperty<string>? NetworkIp
    {
        set => SetProperty("network_ip", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, MRDMA, and IRDMA
    /// </summary>
    public TerraformProperty<string>? NicType
    {
        set => SetProperty("nic_type", value);
    }

    /// <summary>
    /// The networking queue count that&#39;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.
    /// </summary>
    public TerraformProperty<double>? QueueCount
    {
        set => SetProperty("queue_count", value);
    }

    /// <summary>
    /// The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// </summary>
    public TerraformProperty<string>? StackType
    {
        set => SetProperty("stack_type", value);
    }

    /// <summary>
    /// The name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        set => SetProperty("subnetwork", value);
    }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? SubnetworkProject
    {
        set => SetProperty("subnetwork_project", value);
    }

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformProperty<string> TotalEgressBandwidthTier
    {
        set => SetProperty("total_egress_bandwidth_tier", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// The type of reservation from which this instance can consume resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.
    /// </summary>
    public TerraformProperty<bool>? AutomaticRestart
    {
        set => SetProperty("automatic_restart", value);
    }

    /// <summary>
    /// Specifies the availability domain, which this instance should be scheduled on.
    /// </summary>
    public TerraformProperty<double>? AvailabilityDomain
    {
        set => SetProperty("availability_domain", value);
    }

    /// <summary>
    /// Specifies the action GCE should take when SPOT VM is preempted.
    /// </summary>
    public TerraformProperty<string>? InstanceTerminationAction
    {
        set => SetProperty("instance_termination_action", value);
    }

    /// <summary>
    /// Minimum number of cpus for the instance.
    /// </summary>
    public TerraformProperty<double>? MinNodeCpus
    {
        set => SetProperty("min_node_cpus", value);
    }

    /// <summary>
    /// Defines the maintenance behavior for this instance.
    /// </summary>
    public TerraformProperty<string>? OnHostMaintenance
    {
        set => SetProperty("on_host_maintenance", value);
    }

    /// <summary>
    /// Allows instance to be preempted. This defaults to false.
    /// </summary>
    public TerraformProperty<bool>? Preemptible
    {
        set => SetProperty("preemptible", value);
    }

    /// <summary>
    /// Whether the instance is spot. If this is set as SPOT.
    /// </summary>
    public TerraformProperty<string>? ProvisioningModel
    {
        set => SetProperty("provisioning_model", value);
    }

    /// <summary>
    /// Specifies the timestamp, when the instance will be terminated,
    /// in RFC3339 text format. If specified, the instance termination action
    /// will be performed at the termination time.
    /// </summary>
    public TerraformProperty<string>? TerminationTime
    {
        set => SetProperty("termination_time", value);
    }

}

/// <summary>
/// Block type for service_account in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// The service account e-mail address. If not given, the default Google Compute Engine service account is used.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>>? Scopes
    {
        set => SetProperty("scopes", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceTemplateShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? EnableIntegrityMonitoring
    {
        set => SetProperty("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? EnableSecureBoot
    {
        set => SetProperty("enable_secure_boot", value);
    }

    /// <summary>
    /// Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? EnableVtpm
    {
        set => SetProperty("enable_vtpm", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_instance_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInstanceTemplate : TerraformResource
{
    public GoogleComputeInstanceTemplate(string name) : base("google_compute_instance_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_timestamp");
        SetOutput("effective_labels");
        SetOutput("metadata_fingerprint");
        SetOutput("numeric_id");
        SetOutput("self_link");
        SetOutput("self_link_unique");
        SetOutput("tags_fingerprint");
        SetOutput("terraform_labels");
        SetOutput("can_ip_forward");
        SetOutput("description");
        SetOutput("id");
        SetOutput("instance_description");
        SetOutput("key_revocation_action_type");
        SetOutput("labels");
        SetOutput("machine_type");
        SetOutput("metadata");
        SetOutput("metadata_startup_script");
        SetOutput("min_cpu_platform");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("project");
        SetOutput("region");
        SetOutput("resource_manager_tags");
        SetOutput("resource_policies");
        SetOutput("tags");
    }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformProperty<bool> CanIpForward
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("can_ip_forward");
        set => SetProperty("can_ip_forward", value);
    }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformProperty<string> InstanceDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_description");
        set => SetProperty("instance_description", value);
    }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformProperty<string> KeyRevocationActionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_revocation_action_type");
        set => SetProperty("key_revocation_action_type", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformProperty<string> MachineType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("machine_type");
        set => SetProperty("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformProperty<string> MetadataStartupScript
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata_startup_script");
        set => SetProperty("metadata_startup_script", value);
    }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformProperty<string> MinCpuPlatform
    {
        get => GetRequiredOutput<TerraformProperty<string>>("min_cpu_platform");
        set => SetProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags.
    /// 				Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// 				The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResourceManagerTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => SetProperty("resource_manager_tags", value);
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public List<TerraformProperty<string>> ResourcePolicies
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("resource_policies");
        set => SetProperty("resource_policies", value);
    }

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public List<GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        set => SetProperty("advanced_machine_features", value);
    }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        set => SetProperty("confidential_instance_config", value);
    }

    /// <summary>
    /// Block for disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Disk block(s) required")]
    public List<GoogleComputeInstanceTemplateDiskBlock>? Disk
    {
        set => SetProperty("disk", value);
    }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceTemplateGuestAcceleratorBlock>? GuestAccelerator
    {
        set => SetProperty("guest_accelerator", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceTemplateNetworkInterfaceBlock>? NetworkInterface
    {
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        set => SetProperty("network_performance_config", value);
    }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public List<GoogleComputeInstanceTemplateReservationAffinityBlock>? ReservationAffinity
    {
        set => SetProperty("reservation_affinity", value);
    }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public List<GoogleComputeInstanceTemplateSchedulingBlock>? Scheduling
    {
        set => SetProperty("scheduling", value);
    }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public List<GoogleComputeInstanceTemplateServiceAccountBlock>? ServiceAccount
    {
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceTemplateShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        set => SetProperty("shielded_instance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceTemplateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformExpression MetadataFingerprint => this["metadata_fingerprint"];

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformExpression NumericId => this["numeric_id"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// A special URI of the created resource that uniquely identifies this instance template.
    /// </summary>
    public TerraformExpression SelfLinkUnique => this["self_link_unique"];

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformExpression TagsFingerprint => this["tags_fingerprint"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
