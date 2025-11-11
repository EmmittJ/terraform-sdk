using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolAutoscalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Location policy specifies the algorithm used when scaling-up the node pool. &amp;quot;BALANCED&amp;quot; - Is a best effort policy that aims to balance the sizes of available zones. &amp;quot;ANY&amp;quot; - Instructs the cluster autoscaler to prioritize utilization of unused reservations, and reduces preemption risk for Spot VMs.
    /// </summary>
    [TerraformProperty("location_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LocationPolicy { get; set; }

    /// <summary>
    /// Maximum number of nodes per zone in the node pool. Must be &amp;gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    [TerraformProperty("max_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes per zone in the node pool. Must be &amp;gt;=0 and &amp;lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    [TerraformProperty("min_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinNodeCount { get; set; }

    /// <summary>
    /// Maximum number of all nodes in the node pool. Must be &amp;gt;= total_min_node_count. Cannot be used with per zone limits.
    /// </summary>
    [TerraformProperty("total_max_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TotalMaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of all nodes in the node pool. Must be &amp;gt;=0 and &amp;lt;= total_max_node_count. Cannot be used with per zone limits.
    /// </summary>
    [TerraformProperty("total_min_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TotalMinNodeCount { get; set; }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolManagementBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether the nodes will be automatically repaired. Enabled by default.
    /// </summary>
    [TerraformProperty("auto_repair")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoRepair { get; set; }

    /// <summary>
    /// Whether the nodes will be automatically upgraded. Enabled by default.
    /// </summary>
    [TerraformProperty("auto_upgrade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoUpgrade { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolNetworkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.
    /// </summary>
    [TerraformProperty("create_pod_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreatePodRange { get; set; }

    /// <summary>
    /// Whether nodes have internal IP addresses only.
    /// </summary>
    [TerraformProperty("enable_private_nodes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnablePrivateNodes { get; set; }

    /// <summary>
    /// The IP address range for pod IPs in this node pool. Only applicable if create_pod_range is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.
    /// </summary>
    [TerraformProperty("pod_ipv4_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PodIpv4CidrBlock { get; set; }

    /// <summary>
    /// The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.
    /// </summary>
    [TerraformProperty("pod_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PodRange { get; set; }


}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolNodeConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    [TerraformProperty("boot_disk_kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BootDiskKmsKey { get; set; }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    [TerraformProperty("disk_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskType { get; set; }


    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    [TerraformProperty("enable_confidential_storage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableConfidentialStorage { get; set; }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    [TerraformProperty("flex_start")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FlexStart { get; set; }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    [TerraformProperty("image_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ImageType { get; set; }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Labels { get; set; }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    [TerraformProperty("local_ssd_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> LocalSsdCount { get; set; }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    [TerraformProperty("local_ssd_encryption_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalSsdEncryptionMode { get; set; }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    [TerraformProperty("logging_variant")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoggingVariant { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    [TerraformProperty("max_run_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxRunDuration { get; set; }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    [TerraformProperty("min_cpu_platform")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinCpuPlatform { get; set; }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    [TerraformProperty("node_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeGroup { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    [TerraformProperty("oauth_scopes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> OauthScopes { get; set; }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    [TerraformProperty("preemptible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Preemptible { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    [TerraformProperty("resource_labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceLabels { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    [TerraformProperty("spot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Spot { get; set; }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    [TerraformProperty("storage_pools")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? StoragePools { get; set; }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Tags { get; set; }

}

/// <summary>
/// Block type for placement_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolPlacementPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.
    /// </summary>
    [TerraformProperty("policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyName { get; set; }

    /// <summary>
    /// The TPU topology like &amp;quot;2x4&amp;quot; or &amp;quot;2x2x2&amp;quot;. https://cloud.google.com/kubernetes-engine/docs/concepts/plan-tpus#topology
    /// </summary>
    [TerraformProperty("tpu_topology")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TpuTopology { get; set; }

    /// <summary>
    /// Type defines the type of placement policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for queued_provisioning in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolQueuedProvisioningBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether nodes in this node pool are obtainable solely through the ProvisioningRequest API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContainerNodePoolTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerNodePoolUpgradeSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.
    /// </summary>
    [TerraformProperty("max_surge")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxSurge { get; set; }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.
    /// </summary>
    [TerraformProperty("max_unavailable")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxUnavailable { get; set; }

    /// <summary>
    /// Update strategy for the given nodepool.
    /// </summary>
    [TerraformProperty("strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Strategy { get; set; }

}

/// <summary>
/// Manages a google_container_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContainerNodePool : TerraformResource
{
    public GoogleContainerNodePool(string name) : base("google_container_node_pool", name)
    {
    }

    /// <summary>
    /// The cluster to create the node pool for. Cluster must be present in location provided for zonal clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    [TerraformProperty("initial_node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> InitialNodeCount { get; set; }

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    [TerraformProperty("max_pods_per_node")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxPodsPerNode { get; set; }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    [TerraformProperty("node_locations")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> NodeLocations { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    [TerraformProperty("autoscaling")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolAutoscalingBlock>>? Autoscaling { get; set; }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    [TerraformProperty("management")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolManagementBlock>>? Management { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformProperty("node_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolNodeConfigBlock>>? NodeConfig { get; set; }

    /// <summary>
    /// Block for placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlacementPolicy block(s) allowed")]
    [TerraformProperty("placement_policy")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolPlacementPolicyBlock>>? PlacementPolicy { get; set; }

    /// <summary>
    /// Block for queued_provisioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueuedProvisioning block(s) allowed")]
    [TerraformProperty("queued_provisioning")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolQueuedProvisioningBlock>>? QueuedProvisioning { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleContainerNodePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformProperty("upgrade_settings")]
    public partial TerraformList<TerraformBlock<GoogleContainerNodePoolUpgradeSettingsBlock>>? UpgradeSettings { get; set; }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    [TerraformProperty("instance_group_urls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> InstanceGroupUrls { get; }

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    [TerraformProperty("managed_instance_group_urls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ManagedInstanceGroupUrls { get; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformProperty("operation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Operation { get; }

}
