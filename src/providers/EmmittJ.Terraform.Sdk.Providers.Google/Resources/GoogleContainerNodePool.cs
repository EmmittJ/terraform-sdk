using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolAutoscalingBlock
{
    /// <summary>
    /// Location policy specifies the algorithm used when scaling-up the node pool. &amp;quot;BALANCED&amp;quot; - Is a best effort policy that aims to balance the sizes of available zones. &amp;quot;ANY&amp;quot; - Instructs the cluster autoscaler to prioritize utilization of unused reservations, and reduces preemption risk for Spot VMs.
    /// </summary>
    [TerraformPropertyName("location_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LocationPolicy { get; set; } = default!;

    /// <summary>
    /// Maximum number of nodes per zone in the node pool. Must be &amp;gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    [TerraformPropertyName("max_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes per zone in the node pool. Must be &amp;gt;=0 and &amp;lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    [TerraformPropertyName("min_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinNodeCount { get; set; }

    /// <summary>
    /// Maximum number of all nodes in the node pool. Must be &amp;gt;= total_min_node_count. Cannot be used with per zone limits.
    /// </summary>
    [TerraformPropertyName("total_max_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TotalMaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of all nodes in the node pool. Must be &amp;gt;=0 and &amp;lt;= total_max_node_count. Cannot be used with per zone limits.
    /// </summary>
    [TerraformPropertyName("total_min_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TotalMinNodeCount { get; set; }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolManagementBlock
{
    /// <summary>
    /// Whether the nodes will be automatically repaired. Enabled by default.
    /// </summary>
    [TerraformPropertyName("auto_repair")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoRepair { get; set; }

    /// <summary>
    /// Whether the nodes will be automatically upgraded. Enabled by default.
    /// </summary>
    [TerraformPropertyName("auto_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoUpgrade { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlock
{
    /// <summary>
    /// Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.
    /// </summary>
    [TerraformPropertyName("create_pod_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreatePodRange { get; set; }

    /// <summary>
    /// Whether nodes have internal IP addresses only.
    /// </summary>
    [TerraformPropertyName("enable_private_nodes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnablePrivateNodes { get; set; } = default!;

    /// <summary>
    /// The IP address range for pod IPs in this node pool. Only applicable if create_pod_range is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.
    /// </summary>
    [TerraformPropertyName("pod_ipv4_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PodIpv4CidrBlock { get; set; } = default!;

    /// <summary>
    /// The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.
    /// </summary>
    [TerraformPropertyName("pod_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PodRange { get; set; } = default!;


}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlock
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    [TerraformPropertyName("boot_disk_kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BootDiskKmsKey { get; set; }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskType { get; set; } = default!;


    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    [TerraformPropertyName("enable_confidential_storage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableConfidentialStorage { get; set; }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    [TerraformPropertyName("flex_start")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FlexStart { get; set; }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ImageType { get; set; } = default!;

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Labels { get; set; } = default!;

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> LocalSsdCount { get; set; } = default!;

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalSsdEncryptionMode { get; set; }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    [TerraformPropertyName("logging_variant")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoggingVariant { get; set; } = default!;

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MachineType { get; set; } = default!;

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("max_run_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxRunDuration { get; set; }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Metadata { get; set; } = default!;

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MinCpuPlatform { get; set; } = default!;

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    [TerraformPropertyName("node_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodeGroup { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    [TerraformPropertyName("oauth_scopes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> OauthScopes { get; set; } = default!;

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Preemptible { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceLabels { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccount { get; set; } = default!;

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    [TerraformPropertyName("spot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Spot { get; set; }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    [TerraformPropertyName("storage_pools")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? StoragePools { get; set; }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Tags { get; set; }

}

/// <summary>
/// Block type for placement_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolPlacementPolicyBlock
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.
    /// </summary>
    [TerraformPropertyName("policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyName { get; set; }

    /// <summary>
    /// The TPU topology like &amp;quot;2x4&amp;quot; or &amp;quot;2x2x2&amp;quot;. https://cloud.google.com/kubernetes-engine/docs/concepts/plan-tpus#topology
    /// </summary>
    [TerraformPropertyName("tpu_topology")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TpuTopology { get; set; }

    /// <summary>
    /// Type defines the type of placement policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for queued_provisioning in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolQueuedProvisioningBlock
{
    /// <summary>
    /// Whether nodes in this node pool are obtainable solely through the ProvisioningRequest API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerNodePoolTimeoutsBlock
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
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolUpgradeSettingsBlock
{
    /// <summary>
    /// The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.
    /// </summary>
    [TerraformPropertyName("max_surge")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxSurge { get; set; } = default!;

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.
    /// </summary>
    [TerraformPropertyName("max_unavailable")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxUnavailable { get; set; } = default!;

    /// <summary>
    /// Update strategy for the given nodepool.
    /// </summary>
    [TerraformPropertyName("strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Strategy { get; set; }

}

/// <summary>
/// Manages a google_container_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerNodePool : TerraformResource
{
    public GoogleContainerNodePool(string name) : base("google_container_node_pool", name)
    {
    }

    /// <summary>
    /// The cluster to create the node pool for. Cluster must be present in location provided for zonal clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> InitialNodeCount { get; set; } = default!;

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Location { get; set; } = default!;

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("max_pods_per_node")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxPodsPerNode { get; set; } = default!;

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NodeCount { get; set; } = default!;

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> NodeLocations { get; set; } = default!;

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    [TerraformPropertyName("autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolAutoscalingBlock>>? Autoscaling { get; set; }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    [TerraformPropertyName("management")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolManagementBlock>>? Management { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolNodeConfigBlock>>? NodeConfig { get; set; }

    /// <summary>
    /// Block for placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlacementPolicy block(s) allowed")]
    [TerraformPropertyName("placement_policy")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolPlacementPolicyBlock>>? PlacementPolicy { get; set; }

    /// <summary>
    /// Block for queued_provisioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueuedProvisioning block(s) allowed")]
    [TerraformPropertyName("queued_provisioning")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolQueuedProvisioningBlock>>? QueuedProvisioning { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerNodePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformPropertyName("upgrade_settings")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolUpgradeSettingsBlock>>? UpgradeSettings { get; set; }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    [TerraformPropertyName("instance_group_urls")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InstanceGroupUrls => new TerraformReference(this, "instance_group_urls");

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    [TerraformPropertyName("managed_instance_group_urls")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ManagedInstanceGroupUrls => new TerraformReference(this, "managed_instance_group_urls");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Operation => new TerraformReference(this, "operation");

}
