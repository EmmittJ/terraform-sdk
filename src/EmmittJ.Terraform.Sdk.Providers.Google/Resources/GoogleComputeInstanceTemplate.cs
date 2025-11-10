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
        get => GetProperty<TerraformProperty<bool>>("enable_nested_virtualization");
        set => WithProperty("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Whether to enable UEFI networking or not.
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
        get => GetProperty<TerraformProperty<string>>("confidential_instance_type");
        set => WithProperty("confidential_instance_type", value);
    }

    /// <summary>
    /// Defines whether the instance should have confidential compute enabled. Field will be deprecated in a future release.
    /// </summary>
    public TerraformProperty<bool>? EnableConfidentialCompute
    {
        get => GetProperty<TerraformProperty<bool>>("enable_confidential_compute");
        set => WithProperty("enable_confidential_compute", value);
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
        get => GetProperty<TerraformProperty<string>>("architecture");
        set => WithProperty("architecture", value);
    }

    /// <summary>
    /// Whether or not the disk should be auto-deleted. This defaults to true.
    /// </summary>
    public TerraformProperty<bool>? AutoDelete
    {
        get => GetProperty<TerraformProperty<bool>>("auto_delete");
        set => WithProperty("auto_delete", value);
    }

    /// <summary>
    /// Indicates that this is a boot disk.
    /// </summary>
    public TerraformProperty<bool>? Boot
    {
        get => GetProperty<TerraformProperty<bool>>("boot");
        set => WithProperty("boot", value);
    }

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// Name of the disk. When not provided, this defaults to the name of the instance.
    /// </summary>
    public TerraformProperty<string>? DiskName
    {
        get => GetProperty<TerraformProperty<string>>("disk_name");
        set => WithProperty("disk_name", value);
    }

    /// <summary>
    /// The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The Google Compute Engine disk type. Such as &amp;quot;pd-ssd&amp;quot;, &amp;quot;local-ssd&amp;quot;, &amp;quot;pd-balanced&amp;quot; or &amp;quot;pd-standard&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        get => GetProperty<TerraformProperty<string>>("disk_type");
        set => WithProperty("disk_type", value);
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
    /// Specifies the disk interface to use for attaching this disk.
    /// </summary>
    public TerraformProperty<string>? Interface
    {
        get => GetProperty<TerraformProperty<string>>("interface");
        set => WithProperty("interface", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to disks,
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk) or the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks) depending on the selected disk_type.
    /// </summary>
    public TerraformProperty<double>? ProvisionedIops
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_iops");
        set => WithProperty("provisioned_iops", value);
    }

    /// <summary>
    /// Indicates how much throughput to provision for the disk, in MB/s. This sets the amount of data that can be read or written from the disk per second. Values must greater than or equal to 1. For more details, see the [Hyperdisk documentation](https://cloud.google.com/compute/docs/disks/hyperdisks).
    /// </summary>
    public TerraformProperty<double>? ProvisionedThroughput
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_throughput");
        set => WithProperty("provisioned_throughput", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => WithProperty("resource_manager_tags", value);
    }

    /// <summary>
    /// A list (short name or id) of resource policies to attach to this disk. Currently a max of 1 resource policy is supported.
    /// </summary>
    public List<TerraformProperty<string>>? ResourcePolicies
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_policies");
        set => WithProperty("resource_policies", value);
    }

    /// <summary>
    /// The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

    /// <summary>
    /// The image from which to initialize this disk. This can be one of: the image&#39;s self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&amp;gt; Note: Either source or source_image is required when creating a new instance except for when creating a local SSD.
    /// </summary>
    public TerraformProperty<string>? SourceImage
    {
        get => GetProperty<TerraformProperty<string>>("source_image");
        set => WithProperty("source_image", value);
    }

    /// <summary>
    /// The source snapshot to create this disk. When creating
    /// a new instance, one of initializeParams.sourceSnapshot,
    /// initializeParams.sourceImage, or disks.source is
    /// required except for local SSD.
    /// </summary>
    public TerraformProperty<string>? SourceSnapshot
    {
        get => GetProperty<TerraformProperty<string>>("source_snapshot");
        set => WithProperty("source_snapshot", value);
    }

    /// <summary>
    /// The type of Google Compute Engine disk, can be either &amp;quot;SCRATCH&amp;quot; or &amp;quot;PERSISTENT&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

    /// <summary>
    /// The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
    /// The name of the network_interface.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// The private IP address to assign to the instance. If empty, the address will be automatically assigned.
    /// </summary>
    public TerraformProperty<string>? NetworkIp
    {
        get => GetProperty<TerraformProperty<string>>("network_ip");
        set => WithProperty("network_ip", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET, MRDMA, and IRDMA
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
    /// The name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => WithProperty("subnetwork", value);
    }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.
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
public class GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformProperty<string> TotalEgressBandwidthTier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("total_egress_bandwidth_tier");
        set => WithProperty("total_egress_bandwidth_tier", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
    /// Minimum number of cpus for the instance.
    /// </summary>
    public TerraformProperty<double>? MinNodeCpus
    {
        get => GetProperty<TerraformProperty<double>>("min_node_cpus");
        set => WithProperty("min_node_cpus", value);
    }

    /// <summary>
    /// Defines the maintenance behavior for this instance.
    /// </summary>
    public TerraformProperty<string>? OnHostMaintenance
    {
        get => GetProperty<TerraformProperty<string>>("on_host_maintenance");
        set => WithProperty("on_host_maintenance", value);
    }

    /// <summary>
    /// Allows instance to be preempted. This defaults to false.
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
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.
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
public class GoogleComputeInstanceTemplateShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? EnableIntegrityMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("enable_integrity_monitoring");
        set => WithProperty("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? EnableSecureBoot
    {
        get => GetProperty<TerraformProperty<bool>>("enable_secure_boot");
        set => WithProperty("enable_secure_boot", value);
    }

    /// <summary>
    /// Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.
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
public class GoogleComputeInstanceTemplateTimeoutsBlock : TerraformBlock
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
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("metadata_fingerprint");
        this.DeclareOutput("numeric_id");
        this.DeclareOutput("self_link");
        this.DeclareOutput("self_link_unique");
        this.DeclareOutput("tags_fingerprint");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformProperty<bool>? CanIpForward
    {
        get => GetProperty<TerraformProperty<bool>>("can_ip_forward");
        set => this.WithProperty("can_ip_forward", value);
    }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// A description of the instance.
    /// </summary>
    public TerraformProperty<string>? InstanceDescription
    {
        get => GetProperty<TerraformProperty<string>>("instance_description");
        set => this.WithProperty("instance_description", value);
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
    /// A set of key/value label pairs to assign to instances created from this template.
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
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformProperty<string> MachineType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("machine_type");
        set => this.WithProperty("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformProperty<string>? MetadataStartupScript
    {
        get => GetProperty<TerraformProperty<string>>("metadata_startup_script");
        set => this.WithProperty("metadata_startup_script", value);
    }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformProperty<string>? MinCpuPlatform
    {
        get => GetProperty<TerraformProperty<string>>("min_cpu_platform");
        set => this.WithProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags.
    /// 				Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// 				The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => this.WithProperty("resource_manager_tags", value);
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
    /// Tags to attach to the instance.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tags
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for advanced_machine_features.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public List<GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => this.WithProperty("advanced_machine_features", value);
    }

    /// <summary>
    /// Block for confidential_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => this.WithProperty("confidential_instance_config", value);
    }

    /// <summary>
    /// Block for disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Disk block(s) required")]
    public List<GoogleComputeInstanceTemplateDiskBlock>? Disk
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateDiskBlock>>("disk");
        set => this.WithProperty("disk", value);
    }

    /// <summary>
    /// Block for guest_accelerator.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceTemplateGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateGuestAcceleratorBlock>>("guest_accelerator");
        set => this.WithProperty("guest_accelerator", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceTemplateNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateNetworkPerformanceConfigBlock>>("network_performance_config");
        set => this.WithProperty("network_performance_config", value);
    }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public List<GoogleComputeInstanceTemplateReservationAffinityBlock>? ReservationAffinity
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateReservationAffinityBlock>>("reservation_affinity");
        set => this.WithProperty("reservation_affinity", value);
    }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public List<GoogleComputeInstanceTemplateSchedulingBlock>? Scheduling
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateSchedulingBlock>>("scheduling");
        set => this.WithProperty("scheduling", value);
    }

    /// <summary>
    /// Block for service_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public List<GoogleComputeInstanceTemplateServiceAccountBlock>? ServiceAccount
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateServiceAccountBlock>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public List<GoogleComputeInstanceTemplateShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetProperty<List<GoogleComputeInstanceTemplateShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => this.WithProperty("shielded_instance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInstanceTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
