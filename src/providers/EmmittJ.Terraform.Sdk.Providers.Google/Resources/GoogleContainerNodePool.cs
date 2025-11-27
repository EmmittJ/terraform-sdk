using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling";

    /// <summary>
    /// Location policy specifies the algorithm used when scaling-up the node pool. &amp;quot;BALANCED&amp;quot; - Is a best effort policy that aims to balance the sizes of available zones. &amp;quot;ANY&amp;quot; - Instructs the cluster autoscaler to prioritize utilization of unused reservations, and reduces preemption risk for Spot VMs.
    /// </summary>
    public TerraformValue<string> LocationPolicy
    {
        get => new TerraformReference<string>(this, "location_policy");
        set => SetArgument("location_policy", value);
    }

    /// <summary>
    /// Maximum number of nodes per zone in the node pool. Must be &amp;gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    public TerraformValue<double>? MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes per zone in the node pool. Must be &amp;gt;=0 and &amp;lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    public TerraformValue<double>? MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

    /// <summary>
    /// Maximum number of all nodes in the node pool. Must be &amp;gt;= total_min_node_count. Cannot be used with per zone limits.
    /// </summary>
    public TerraformValue<double>? TotalMaxNodeCount
    {
        get => new TerraformReference<double>(this, "total_max_node_count");
        set => SetArgument("total_max_node_count", value);
    }

    /// <summary>
    /// Minimum number of all nodes in the node pool. Must be &amp;gt;=0 and &amp;lt;= total_max_node_count. Cannot be used with per zone limits.
    /// </summary>
    public TerraformValue<double>? TotalMinNodeCount
    {
        get => new TerraformReference<double>(this, "total_min_node_count");
        set => SetArgument("total_min_node_count", value);
    }

}


/// <summary>
/// Block type for management in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// Whether the nodes will be automatically repaired. Enabled by default.
    /// </summary>
    public TerraformValue<bool>? AutoRepair
    {
        get => new TerraformReference<bool>(this, "auto_repair");
        set => SetArgument("auto_repair", value);
    }

    /// <summary>
    /// Whether the nodes will be automatically upgraded. Enabled by default.
    /// </summary>
    public TerraformValue<bool>? AutoUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_upgrade");
        set => SetArgument("auto_upgrade", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.
    /// </summary>
    public TerraformValue<bool>? CreatePodRange
    {
        get => new TerraformReference<bool>(this, "create_pod_range");
        set => SetArgument("create_pod_range", value);
    }

    /// <summary>
    /// Whether nodes have internal IP addresses only.
    /// </summary>
    public TerraformValue<bool> EnablePrivateNodes
    {
        get => new TerraformReference<bool>(this, "enable_private_nodes");
        set => SetArgument("enable_private_nodes", value);
    }

    /// <summary>
    /// The IP address range for pod IPs in this node pool. Only applicable if create_pod_range is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.
    /// </summary>
    public TerraformValue<string> PodIpv4CidrBlock
    {
        get => new TerraformReference<string>(this, "pod_ipv4_cidr_block");
        set => SetArgument("pod_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.
    /// </summary>
    public TerraformValue<string> PodRange
    {
        get => new TerraformReference<string>(this, "pod_range");
        set => SetArgument("pod_range", value);
    }

    /// <summary>
    /// The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork} . If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
    }

    /// <summary>
    /// AdditionalNodeNetworkConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerNodePoolNetworkConfigBlockAdditionalNodeNetworkConfigsBlock>? AdditionalNodeNetworkConfigs
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNetworkConfigBlockAdditionalNodeNetworkConfigsBlock>>("additional_node_network_configs");
        set => SetArgument("additional_node_network_configs", value);
    }

    /// <summary>
    /// AdditionalPodNetworkConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerNodePoolNetworkConfigBlockAdditionalPodNetworkConfigsBlock>? AdditionalPodNetworkConfigs
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNetworkConfigBlockAdditionalPodNetworkConfigsBlock>>("additional_pod_network_configs");
        set => SetArgument("additional_pod_network_configs", value);
    }

    /// <summary>
    /// NetworkPerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNetworkConfigBlockNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNetworkConfigBlockNetworkPerformanceConfigBlock>>("network_performance_config");
        set => SetArgument("network_performance_config", value);
    }

    /// <summary>
    /// PodCidrOverprovisionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodCidrOverprovisionConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNetworkConfigBlockPodCidrOverprovisionConfigBlock>? PodCidrOverprovisionConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNetworkConfigBlockPodCidrOverprovisionConfigBlock>>("pod_cidr_overprovision_config");
        set => SetArgument("pod_cidr_overprovision_config", value);
    }

}

/// <summary>
/// Block type for additional_node_network_configs in GoogleContainerNodePoolNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlockAdditionalNodeNetworkConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_node_network_configs";

    /// <summary>
    /// Name of the VPC where the additional interface belongs.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Name of the subnetwork where the additional interface belongs.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
        set => SetArgument("subnetwork", value);
    }

}

/// <summary>
/// Block type for additional_pod_network_configs in GoogleContainerNodePoolNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlockAdditionalPodNetworkConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_pod_network_configs";

    /// <summary>
    /// The maximum number of pods per node which use this pod network.
    /// </summary>
    public TerraformValue<double> MaxPodsPerNode
    {
        get => new TerraformReference<double>(this, "max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the secondary range on the subnet which provides IP address for this pod range.
    /// </summary>
    public TerraformValue<string>? SecondaryPodRange
    {
        get => new TerraformReference<string>(this, "secondary_pod_range");
        set => SetArgument("secondary_pod_range", value);
    }

    /// <summary>
    /// Name of the subnetwork where the additional pod network belongs.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
        set => SetArgument("subnetwork", value);
    }

}

/// <summary>
/// Block type for network_performance_config in GoogleContainerNodePoolNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlockNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_performance_config";

    /// <summary>
    /// Specifies the total network bandwidth tier for the NodePool. [Valid values](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters.nodePools#NodePool.Tier) include: &amp;quot;TIER_1&amp;quot; and &amp;quot;TIER_UNSPECIFIED&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformValue<string> TotalEgressBandwidthTier
    {
        get => new TerraformReference<string>(this, "total_egress_bandwidth_tier");
        set => SetArgument("total_egress_bandwidth_tier", value);
    }

}

/// <summary>
/// Block type for pod_cidr_overprovision_config in GoogleContainerNodePoolNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlockPodCidrOverprovisionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_cidr_overprovision_config";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    public TerraformValue<string>? BootDiskKmsKey
    {
        get => new TerraformReference<string>(this, "boot_disk_kms_key");
        set => SetArgument("boot_disk_kms_key", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveTaints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "effective_taints").ResolveNodes(ctx));
    }

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialStorage
    {
        get => new TerraformReference<bool>(this, "enable_confidential_storage");
        set => SetArgument("enable_confidential_storage", value);
    }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    public TerraformValue<bool>? FlexStart
    {
        get => new TerraformReference<bool>(this, "flex_start");
        set => SetArgument("flex_start", value);
    }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    public TerraformValue<string> ImageType
    {
        get => new TerraformReference<string>(this, "image_type");
        set => SetArgument("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    public TerraformValue<double> LocalSsdCount
    {
        get => new TerraformReference<double>(this, "local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    public TerraformValue<string>? LocalSsdEncryptionMode
    {
        get => new TerraformReference<string>(this, "local_ssd_encryption_mode");
        set => SetArgument("local_ssd_encryption_mode", value);
    }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    public TerraformValue<string> LoggingVariant
    {
        get => new TerraformReference<string>(this, "logging_variant");
        set => SetArgument("logging_variant", value);
    }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => new TerraformReference<string>(this, "machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxRunDuration
    {
        get => new TerraformReference<string>(this, "max_run_duration");
        set => SetArgument("max_run_duration", value);
    }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => new TerraformReference<string>(this, "min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    public TerraformValue<string>? NodeGroup
    {
        get => new TerraformReference<string>(this, "node_group");
        set => SetArgument("node_group", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    public TerraformSet<string> OauthScopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => new TerraformReference<bool>(this, "preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    public TerraformMap<string>? ResourceLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_labels").ResolveNodes(ctx));
        set => SetArgument("resource_labels", value);
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
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    public TerraformValue<bool>? Spot
    {
        get => new TerraformReference<bool>(this, "spot");
        set => SetArgument("spot", value);
    }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    public TerraformList<string>? StoragePools
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "storage_pools").ResolveNodes(ctx));
        set => SetArgument("storage_pools", value);
    }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AdvancedMachineFeatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// BootDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockBootDiskBlock>? BootDisk
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockBootDiskBlock>>("boot_disk");
        set => SetArgument("boot_disk", value);
    }

    /// <summary>
    /// ConfidentialNodes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockConfidentialNodesBlock>? ConfidentialNodes
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockConfidentialNodesBlock>>("confidential_nodes");
        set => SetArgument("confidential_nodes", value);
    }

    /// <summary>
    /// ContainerdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerdConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlock>? ContainerdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlock>>("containerd_config");
        set => SetArgument("containerd_config", value);
    }

    /// <summary>
    /// EphemeralStorageLocalSsdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorageLocalSsdConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockEphemeralStorageLocalSsdConfigBlock>? EphemeralStorageLocalSsdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockEphemeralStorageLocalSsdConfigBlock>>("ephemeral_storage_local_ssd_config");
        set => SetArgument("ephemeral_storage_local_ssd_config", value);
    }

    /// <summary>
    /// FastSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FastSocket block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockFastSocketBlock>? FastSocket
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockFastSocketBlock>>("fast_socket");
        set => SetArgument("fast_socket", value);
    }

    /// <summary>
    /// GcfsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcfsConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockGcfsConfigBlock>? GcfsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockGcfsConfigBlock>>("gcfs_config");
        set => SetArgument("gcfs_config", value);
    }

    /// <summary>
    /// GuestAccelerator block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlock>>("guest_accelerator");
        set => SetArgument("guest_accelerator", value);
    }

    /// <summary>
    /// Gvnic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gvnic block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockGvnicBlock>? Gvnic
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockGvnicBlock>>("gvnic");
        set => SetArgument("gvnic", value);
    }

    /// <summary>
    /// HostMaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostMaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockHostMaintenancePolicyBlock>? HostMaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockHostMaintenancePolicyBlock>>("host_maintenance_policy");
        set => SetArgument("host_maintenance_policy", value);
    }

    /// <summary>
    /// KubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// LinuxNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlock>? LinuxNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlock>>("linux_node_config");
        set => SetArgument("linux_node_config", value);
    }

    /// <summary>
    /// LocalNvmeSsdBlockConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalNvmeSsdBlockConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockLocalNvmeSsdBlockConfigBlock>? LocalNvmeSsdBlockConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockLocalNvmeSsdBlockConfigBlock>>("local_nvme_ssd_block_config");
        set => SetArgument("local_nvme_ssd_block_config", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// SecondaryBootDisks block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(127, ErrorMessage = "Maximum 127 SecondaryBootDisks block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockSecondaryBootDisksBlock>? SecondaryBootDisks
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockSecondaryBootDisksBlock>>("secondary_boot_disks");
        set => SetArgument("secondary_boot_disks", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// SoleTenantConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoleTenantConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlock>? SoleTenantConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlock>>("sole_tenant_config");
        set => SetArgument("sole_tenant_config", value);
    }

    /// <summary>
    /// Taint block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockTaintBlock>? Taint
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockTaintBlock>>("taint");
        set => SetArgument("taint", value);
    }

    /// <summary>
    /// WindowsNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockWindowsNodeConfigBlock>? WindowsNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockWindowsNodeConfigBlock>>("windows_node_config");
        set => SetArgument("windows_node_config", value);
    }

    /// <summary>
    /// WorkloadMetadataConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadMetadataConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockWorkloadMetadataConfigBlock>? WorkloadMetadataConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockWorkloadMetadataConfigBlock>>("workload_metadata_config");
        set => SetArgument("workload_metadata_config", value);
    }

}

/// <summary>
/// Block type for advanced_machine_features in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_machine_features";

    /// <summary>
    /// Whether the node should have nested virtualization enabled.
    /// </summary>
    public TerraformValue<bool>? EnableNestedVirtualization
    {
        get => new TerraformReference<bool>(this, "enable_nested_virtualization");
        set => SetArgument("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Level of Performance Monitoring Unit (PMU) requested. If unset, no access to the PMU is assumed.
    /// </summary>
    public TerraformValue<string>? PerformanceMonitoringUnit
    {
        get => new TerraformReference<string>(this, "performance_monitoring_unit");
        set => SetArgument("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreadsPerCore is required")]
    public required TerraformValue<double> ThreadsPerCore
    {
        get => new TerraformReference<double>(this, "threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

}

/// <summary>
/// Block type for boot_disk in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockBootDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_disk";

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// Configured IOPs provisioning. Only valid with disk type hyperdisk-balanced.
    /// </summary>
    public TerraformValue<double> ProvisionedIops
    {
        get => new TerraformReference<double>(this, "provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Configured throughput provisioning. Only valid with disk type hyperdisk-balanced.
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
    {
        get => new TerraformReference<double>(this, "provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double> SizeGb
    {
        get => new TerraformReference<double>(this, "size_gb");
        set => SetArgument("size_gb", value);
    }

}

/// <summary>
/// Block type for confidential_nodes in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockConfidentialNodesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_nodes";

    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    public TerraformValue<string>? ConfidentialInstanceType
    {
        get => new TerraformReference<string>(this, "confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for containerd_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containerd_config";

    /// <summary>
    /// PrivateRegistryAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccessConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>? PrivateRegistryAccessConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>>("private_registry_access_config");
        set => SetArgument("private_registry_access_config", value);
    }

}

/// <summary>
/// Block type for private_registry_access_config in GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_registry_access_config";

    /// <summary>
    /// Whether or not private registries are configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// CertificateAuthorityDomainConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>? CertificateAuthorityDomainConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>>("certificate_authority_domain_config");
        set => SetArgument("certificate_authority_domain_config", value);
    }

}

/// <summary>
/// Block type for certificate_authority_domain_config in GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_domain_config";

    /// <summary>
    /// List of fully-qualified-domain-names. IPv4s and port specification are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdns is required")]
    public TerraformList<string>? Fqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// GcpSecretManagerCertificateConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpSecretManagerCertificateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpSecretManagerCertificateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpSecretManagerCertificateConfig block(s) allowed")]
    public required TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock> GcpSecretManagerCertificateConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock>>("gcp_secret_manager_certificate_config");
        set => SetArgument("gcp_secret_manager_certificate_config", value);
    }

}

/// <summary>
/// Block type for gcp_secret_manager_certificate_config in GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_secret_manager_certificate_config";

    /// <summary>
    /// URI for the secret that hosts a certificate. Must be in the format &#39;projects/PROJECT_NUM/secrets/SECRET_NAME/versions/VERSION_OR_LATEST&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUri is required")]
    public required TerraformValue<string> SecretUri
    {
        get => new TerraformReference<string>(this, "secret_uri");
        set => SetArgument("secret_uri", value);
    }

}

/// <summary>
/// Block type for ephemeral_storage_local_ssd_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockEphemeralStorageLocalSsdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_storage_local_ssd_config";

    /// <summary>
    /// Number of local SSDs to be utilized for GKE Data Cache. Uses NVMe interfaces.
    /// </summary>
    public TerraformValue<double>? DataCacheCount
    {
        get => new TerraformReference<double>(this, "data_cache_count");
        set => SetArgument("data_cache_count", value);
    }

    /// <summary>
    /// Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalSsdCount is required")]
    public required TerraformValue<double> LocalSsdCount
    {
        get => new TerraformReference<double>(this, "local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

}

/// <summary>
/// Block type for fast_socket in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockFastSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fast_socket";

    /// <summary>
    /// Whether or not NCCL Fast Socket is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gcfs_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockGcfsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcfs_config";

    /// <summary>
    /// Whether or not GCFS is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for guest_accelerator in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_accelerator";

    /// <summary>
    /// The number of the accelerator cards exposed to an instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide (https://docs.nvidia.com/datacenter/tesla/mig-user-guide/#partitioning)
    /// </summary>
    public TerraformValue<string>? GpuPartitionSize
    {
        get => new TerraformReference<string>(this, "gpu_partition_size");
        set => SetArgument("gpu_partition_size", value);
    }

    /// <summary>
    /// The accelerator type resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// GpuDriverInstallationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GpuDriverInstallationConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock>? GpuDriverInstallationConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock>>("gpu_driver_installation_config");
        set => SetArgument("gpu_driver_installation_config", value);
    }

    /// <summary>
    /// GpuSharingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GpuSharingConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock>? GpuSharingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock>>("gpu_sharing_config");
        set => SetArgument("gpu_sharing_config", value);
    }

}

/// <summary>
/// Block type for gpu_driver_installation_config in GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gpu_driver_installation_config";

    /// <summary>
    /// Mode for how the GPU driver is installed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GpuDriverVersion is required")]
    public required TerraformValue<string> GpuDriverVersion
    {
        get => new TerraformReference<string>(this, "gpu_driver_version");
        set => SetArgument("gpu_driver_version", value);
    }

}

/// <summary>
/// Block type for gpu_sharing_config in GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gpu_sharing_config";

    /// <summary>
    /// The type of GPU sharing strategy to enable on the GPU node. Possible values are described in the API package (https://pkg.go.dev/google.golang.org/api/container/v1#GPUSharingConfig)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GpuSharingStrategy is required")]
    public required TerraformValue<string> GpuSharingStrategy
    {
        get => new TerraformReference<string>(this, "gpu_sharing_strategy");
        set => SetArgument("gpu_sharing_strategy", value);
    }

    /// <summary>
    /// The maximum number of containers that can share a GPU.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSharedClientsPerGpu is required")]
    public required TerraformValue<double> MaxSharedClientsPerGpu
    {
        get => new TerraformReference<double>(this, "max_shared_clients_per_gpu");
        set => SetArgument("max_shared_clients_per_gpu", value);
    }

}

/// <summary>
/// Block type for gvnic in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockGvnicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gvnic";

    /// <summary>
    /// Whether or not gvnic is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for host_maintenance_policy in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockHostMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_maintenance_policy";

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceInterval is required")]
    public required TerraformValue<string> MaintenanceInterval
    {
        get => new TerraformReference<string>(this, "maintenance_interval");
        set => SetArgument("maintenance_interval", value);
    }

}

/// <summary>
/// Block type for kubelet_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_config";

    /// <summary>
    /// Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods.
    /// </summary>
    public TerraformList<string>? AllowedUnsafeSysctls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_unsafe_sysctls").ResolveNodes(ctx));
        set => SetArgument("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// Defines the maximum number of container log files that can be present for a container.
    /// </summary>
    public TerraformValue<double>? ContainerLogMaxFiles
    {
        get => new TerraformReference<double>(this, "container_log_max_files");
        set => SetArgument("container_log_max_files", value);
    }

    /// <summary>
    /// Defines the maximum size of the container log file before it is rotated.
    /// </summary>
    public TerraformValue<string>? ContainerLogMaxSize
    {
        get => new TerraformReference<string>(this, "container_log_max_size");
        set => SetArgument("container_log_max_size", value);
    }

    /// <summary>
    /// Enable CPU CFS quota enforcement for containers that specify CPU limits.
    /// </summary>
    public TerraformValue<bool> CpuCfsQuota
    {
        get => new TerraformReference<bool>(this, "cpu_cfs_quota");
        set => SetArgument("cpu_cfs_quota", value);
    }

    /// <summary>
    /// Set the CPU CFS quota period value &#39;cpu.cfs_period_us&#39;.
    /// </summary>
    public TerraformValue<string>? CpuCfsQuotaPeriod
    {
        get => new TerraformReference<string>(this, "cpu_cfs_quota_period");
        set => SetArgument("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// Control the CPU management policy on the node.
    /// </summary>
    public TerraformValue<string>? CpuManagerPolicy
    {
        get => new TerraformReference<string>(this, "cpu_manager_policy");
        set => SetArgument("cpu_manager_policy", value);
    }

    /// <summary>
    /// Defines the maximum allowed grace period (in seconds) to use when terminating pods in response to a soft eviction threshold being met.
    /// </summary>
    public TerraformValue<double>? EvictionMaxPodGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "eviction_max_pod_grace_period_seconds");
        set => SetArgument("eviction_max_pod_grace_period_seconds", value);
    }

    /// <summary>
    /// Defines the percent of disk usage after which image garbage collection is always run.
    /// </summary>
    public TerraformValue<double>? ImageGcHighThresholdPercent
    {
        get => new TerraformReference<double>(this, "image_gc_high_threshold_percent");
        set => SetArgument("image_gc_high_threshold_percent", value);
    }

    /// <summary>
    /// Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to.
    /// </summary>
    public TerraformValue<double>? ImageGcLowThresholdPercent
    {
        get => new TerraformReference<double>(this, "image_gc_low_threshold_percent");
        set => SetArgument("image_gc_low_threshold_percent", value);
    }

    /// <summary>
    /// Defines the maximum age an image can be unused before it is garbage collected.
    /// </summary>
    public TerraformValue<string>? ImageMaximumGcAge
    {
        get => new TerraformReference<string>(this, "image_maximum_gc_age");
        set => SetArgument("image_maximum_gc_age", value);
    }

    /// <summary>
    /// Defines the minimum age for an unused image before it is garbage collected.
    /// </summary>
    public TerraformValue<string>? ImageMinimumGcAge
    {
        get => new TerraformReference<string>(this, "image_minimum_gc_age");
        set => SetArgument("image_minimum_gc_age", value);
    }

    /// <summary>
    /// Controls whether the kubelet read-only port is enabled. It is strongly recommended to set this to `FALSE`. Possible values: `TRUE`, `FALSE`.
    /// </summary>
    public TerraformValue<string> InsecureKubeletReadonlyPortEnabled
    {
        get => new TerraformReference<string>(this, "insecure_kubelet_readonly_port_enabled");
        set => SetArgument("insecure_kubelet_readonly_port_enabled", value);
    }

    /// <summary>
    /// Set the maximum number of image pulls in parallel.
    /// </summary>
    public TerraformValue<double> MaxParallelImagePulls
    {
        get => new TerraformReference<double>(this, "max_parallel_image_pulls");
        set => SetArgument("max_parallel_image_pulls", value);
    }

    /// <summary>
    /// Controls the maximum number of processes allowed to run in a pod.
    /// </summary>
    public TerraformValue<double>? PodPidsLimit
    {
        get => new TerraformReference<double>(this, "pod_pids_limit");
        set => SetArgument("pod_pids_limit", value);
    }

    /// <summary>
    /// Defines whether to enable single process OOM killer.
    /// </summary>
    public TerraformValue<bool>? SingleProcessOomKill
    {
        get => new TerraformReference<bool>(this, "single_process_oom_kill");
        set => SetArgument("single_process_oom_kill", value);
    }

    /// <summary>
    /// EvictionMinimumReclaim block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionMinimumReclaim block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock>? EvictionMinimumReclaim
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock>>("eviction_minimum_reclaim");
        set => SetArgument("eviction_minimum_reclaim", value);
    }

    /// <summary>
    /// EvictionSoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionSoft block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionSoftBlock>? EvictionSoft
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionSoftBlock>>("eviction_soft");
        set => SetArgument("eviction_soft", value);
    }

    /// <summary>
    /// EvictionSoftGracePeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionSoftGracePeriod block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock>? EvictionSoftGracePeriod
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock>>("eviction_soft_grace_period");
        set => SetArgument("eviction_soft_grace_period", value);
    }

    /// <summary>
    /// MemoryManager block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryManager block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockMemoryManagerBlock>? MemoryManager
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockMemoryManagerBlock>>("memory_manager");
        set => SetArgument("memory_manager", value);
    }

    /// <summary>
    /// TopologyManager block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TopologyManager block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockTopologyManagerBlock>? TopologyManager
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockTopologyManagerBlock>>("topology_manager");
        set => SetArgument("topology_manager", value);
    }

}

/// <summary>
/// Block type for eviction_minimum_reclaim in GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_minimum_reclaim";

    /// <summary>
    /// Defines percentage of minimum reclaim for imagefs.available.
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => new TerraformReference<string>(this, "imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for imagefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => new TerraformReference<string>(this, "imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for memory.available.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => new TerraformReference<string>(this, "memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for nodefs.available.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => new TerraformReference<string>(this, "nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for nodefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => new TerraformReference<string>(this, "nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for pid.available.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => new TerraformReference<string>(this, "pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for eviction_soft in GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionSoftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_soft";

    /// <summary>
    /// Defines percentage of soft eviction threshold for imagefs.available.
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => new TerraformReference<string>(this, "imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for imagefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => new TerraformReference<string>(this, "imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines quantity of soft eviction threshold for memory.available.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => new TerraformReference<string>(this, "memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for nodefs.available.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => new TerraformReference<string>(this, "nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for nodefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => new TerraformReference<string>(this, "nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for pid.available.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => new TerraformReference<string>(this, "pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for eviction_soft_grace_period in GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_soft_grace_period";

    /// <summary>
    /// Defines grace period for the imagefs.available soft eviction threshold
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => new TerraformReference<string>(this, "imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines grace period for the imagefs.inodesFree soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => new TerraformReference<string>(this, "imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines grace period for the memory.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => new TerraformReference<string>(this, "memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines grace period for the nodefs.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => new TerraformReference<string>(this, "nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines grace period for the nodefs.inodesFree soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => new TerraformReference<string>(this, "nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines grace period for the pid.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => new TerraformReference<string>(this, "pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for memory_manager in GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockMemoryManagerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_manager";

    /// <summary>
    /// The Memory Manager policy to use. This policy guides how memory and hugepages are allocated and managed for pods on the node, influencing NUMA affinity.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

}

/// <summary>
/// Block type for topology_manager in GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockKubeletConfigBlockTopologyManagerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topology_manager";

    /// <summary>
    /// The Topology Manager policy to use. This policy dictates how resource alignment is handled on the node.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The Topology Manager scope, defining the granularity at which policy decisions are applied. Valid values are &amp;quot;container&amp;quot; (resources are aligned per container within a pod) or &amp;quot;pod&amp;quot; (resources are aligned for the entire pod).
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for linux_node_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_node_config";

    /// <summary>
    /// cgroupMode specifies the cgroup mode to be used on the node.
    /// </summary>
    public TerraformValue<string> CgroupMode
    {
        get => new TerraformReference<string>(this, "cgroup_mode");
        set => SetArgument("cgroup_mode", value);
    }

    /// <summary>
    /// The Linux kernel parameters to be applied to the nodes and all pods running on the nodes.
    /// </summary>
    public TerraformMap<string>? Sysctls
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "sysctls").ResolveNodes(ctx));
        set => SetArgument("sysctls", value);
    }

    /// <summary>
    /// The Linux kernel transparent hugepage defrag setting.
    /// </summary>
    public TerraformValue<string>? TransparentHugepageDefrag
    {
        get => new TerraformReference<string>(this, "transparent_hugepage_defrag");
        set => SetArgument("transparent_hugepage_defrag", value);
    }

    /// <summary>
    /// The Linux kernel transparent hugepage setting.
    /// </summary>
    public TerraformValue<string> TransparentHugepageEnabled
    {
        get => new TerraformReference<string>(this, "transparent_hugepage_enabled");
        set => SetArgument("transparent_hugepage_enabled", value);
    }

    /// <summary>
    /// HugepagesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HugepagesConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock>? HugepagesConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock>>("hugepages_config");
        set => SetArgument("hugepages_config", value);
    }

}

/// <summary>
/// Block type for hugepages_config in GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hugepages_config";

    /// <summary>
    /// Amount of 1G hugepages.
    /// </summary>
    public TerraformValue<double>? HugepageSize1g
    {
        get => new TerraformReference<double>(this, "hugepage_size_1g");
        set => SetArgument("hugepage_size_1g", value);
    }

    /// <summary>
    /// Amount of 2M hugepages.
    /// </summary>
    public TerraformValue<double>? HugepageSize2m
    {
        get => new TerraformReference<double>(this, "hugepage_size_2m");
        set => SetArgument("hugepage_size_2m", value);
    }

}

/// <summary>
/// Block type for local_nvme_ssd_block_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockLocalNvmeSsdBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_nvme_ssd_block_config";

    /// <summary>
    /// Number of raw-block local NVMe SSD disks to be attached to the node. Each local SSD is 375 GB in size.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalSsdCount is required")]
    public required TerraformValue<double> LocalSsdCount
    {
        get => new TerraformReference<double>(this, "local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Corresponds to the type of reservation consumption.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumeReservationType is required")]
    public required TerraformValue<string> ConsumeReservationType
    {
        get => new TerraformReference<string>(this, "consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// The label key of a reservation resource.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label values of the reservation resource.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for secondary_boot_disks in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockSecondaryBootDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_boot_disks";

    /// <summary>
    /// Disk image to create the secondary boot disk from
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskImage is required")]
    public required TerraformValue<string> DiskImage
    {
        get => new TerraformReference<string>(this, "disk_image");
        set => SetArgument("disk_image", value);
    }

    /// <summary>
    /// Mode for how the secondary boot disk is used.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => new TerraformReference<bool>(this, "enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => new TerraformReference<bool>(this, "enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

}

/// <summary>
/// Block type for sole_tenant_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sole_tenant_config";

    /// <summary>
    /// Specifies the minimum number of vCPUs that each sole tenant node must have to use CPU overcommit. If not specified, the CPU overcommit feature is disabled.
    /// </summary>
    public TerraformValue<double>? MinNodeCpus
    {
        get => new TerraformReference<double>(this, "min_node_cpus");
        set => SetArgument("min_node_cpus", value);
    }

    /// <summary>
    /// NodeAffinity block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAffinity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeAffinity block(s) required")]
    public required TerraformSet<GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock> NodeAffinity
    {
        get => GetRequiredArgument<TerraformSet<GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock>>("node_affinity");
        set => SetArgument("node_affinity", value);
    }

}

/// <summary>
/// Block type for node_affinity in GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_affinity";

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for taint in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockTaintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taint";

    /// <summary>
    /// Effect for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformValue<string> Effect
    {
        get => new TerraformReference<string>(this, "effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for windows_node_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockWindowsNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_node_config";

    /// <summary>
    /// The OS Version of the windows nodepool.Values are OS_VERSION_UNSPECIFIED,OS_VERSION_LTSC2019 and OS_VERSION_LTSC2022
    /// </summary>
    public TerraformValue<string>? Osversion
    {
        get => new TerraformReference<string>(this, "osversion");
        set => SetArgument("osversion", value);
    }

}

/// <summary>
/// Block type for workload_metadata_config in GoogleContainerNodePoolNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlockWorkloadMetadataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_metadata_config";

    /// <summary>
    /// Mode is the configuration for how to expose metadata to workloads running on the node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for placement_policy in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolPlacementPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_policy";

    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => new TerraformReference<string>(this, "policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The TPU topology like &amp;quot;2x4&amp;quot; or &amp;quot;2x2x2&amp;quot;. https://cloud.google.com/kubernetes-engine/docs/concepts/plan-tpus#topology
    /// </summary>
    public TerraformValue<string>? TpuTopology
    {
        get => new TerraformReference<string>(this, "tpu_topology");
        set => SetArgument("tpu_topology", value);
    }

    /// <summary>
    /// Type defines the type of placement policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for queued_provisioning in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolQueuedProvisioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queued_provisioning";

    /// <summary>
    /// Whether nodes in this node pool are obtainable solely through the ProvisioningRequest API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerNodePool.
/// Nesting mode: single
/// </summary>
public class GoogleContainerNodePoolTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for upgrade_settings in GoogleContainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolUpgradeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_settings";

    /// <summary>
    /// The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.
    /// </summary>
    public TerraformValue<double> MaxSurge
    {
        get => new TerraformReference<double>(this, "max_surge");
        set => SetArgument("max_surge", value);
    }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.
    /// </summary>
    public TerraformValue<double> MaxUnavailable
    {
        get => new TerraformReference<double>(this, "max_unavailable");
        set => SetArgument("max_unavailable", value);
    }

    /// <summary>
    /// Update strategy for the given nodepool.
    /// </summary>
    public TerraformValue<string>? Strategy
    {
        get => new TerraformReference<string>(this, "strategy");
        set => SetArgument("strategy", value);
    }

    /// <summary>
    /// BlueGreenSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenSettings block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlock>? BlueGreenSettings
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlock>>("blue_green_settings");
        set => SetArgument("blue_green_settings", value);
    }

}

/// <summary>
/// Block type for blue_green_settings in GoogleContainerNodePoolUpgradeSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blue_green_settings";

    /// <summary>
    /// Time needed after draining entire blue pool. After this period, blue pool will be cleaned up.
    /// </summary>
    public TerraformValue<string> NodePoolSoakDuration
    {
        get => new TerraformReference<string>(this, "node_pool_soak_duration");
        set => SetArgument("node_pool_soak_duration", value);
    }

    /// <summary>
    /// StandardRolloutPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardRolloutPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StandardRolloutPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardRolloutPolicy block(s) allowed")]
    public required TerraformList<GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock> StandardRolloutPolicy
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock>>("standard_rollout_policy");
        set => SetArgument("standard_rollout_policy", value);
    }

}

/// <summary>
/// Block type for standard_rollout_policy in GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_rollout_policy";

    /// <summary>
    /// Number of blue nodes to drain in a batch.
    /// </summary>
    public TerraformValue<double> BatchNodeCount
    {
        get => new TerraformReference<double>(this, "batch_node_count");
        set => SetArgument("batch_node_count", value);
    }

    /// <summary>
    /// Percentage of the blue pool nodes to drain in a batch.
    /// </summary>
    public TerraformValue<double> BatchPercentage
    {
        get => new TerraformReference<double>(this, "batch_percentage");
        set => SetArgument("batch_percentage", value);
    }

    /// <summary>
    /// Soak time after each batch gets drained.
    /// </summary>
    public TerraformValue<string> BatchSoakDuration
    {
        get => new TerraformReference<string>(this, "batch_soak_duration");
        set => SetArgument("batch_soak_duration", value);
    }

}


/// <summary>
/// Represents a google_container_node_pool Terraform resource.
/// Manages a google_container_node_pool resource.
/// </summary>
public partial class GoogleContainerNodePool(string name) : TerraformResource("google_container_node_pool", name)
{
    /// <summary>
    /// The cluster to create the node pool for. Cluster must be present in location provided for zonal clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
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
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    public TerraformValue<double> InitialNodeCount
    {
        get => new TerraformReference<double>(this, "initial_node_count");
        set => SetArgument("initial_node_count", value);
    }

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    public TerraformValue<double> MaxPodsPerNode
    {
        get => new TerraformReference<double>(this, "max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    public TerraformSet<string> NodeLocations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "node_locations").ResolveNodes(ctx));
        set => SetArgument("node_locations", value);
    }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    public TerraformList<string> InstanceGroupUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "instance_group_urls").ResolveNodes(ctx));
    }

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    public TerraformList<string> ManagedInstanceGroupUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "managed_instance_group_urls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string> Operation
    {
        get => new TerraformReference<string>(this, "operation");
    }

    /// <summary>
    /// Autoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolAutoscalingBlock>? Autoscaling
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolAutoscalingBlock>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolManagementBlock>? Management
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// PlacementPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlacementPolicy block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolPlacementPolicyBlock>? PlacementPolicy
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolPlacementPolicyBlock>>("placement_policy");
        set => SetArgument("placement_policy", value);
    }

    /// <summary>
    /// QueuedProvisioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueuedProvisioning block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolQueuedProvisioningBlock>? QueuedProvisioning
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolQueuedProvisioningBlock>>("queued_provisioning");
        set => SetArgument("queued_provisioning", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public TerraformList<GoogleContainerNodePoolUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetArgument<TerraformList<GoogleContainerNodePoolUpgradeSettingsBlock>>("upgrade_settings");
        set => SetArgument("upgrade_settings", value);
    }

}
