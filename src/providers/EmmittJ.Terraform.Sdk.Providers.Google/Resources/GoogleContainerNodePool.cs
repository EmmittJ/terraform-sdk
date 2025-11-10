using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolAutoscalingBlock : ITerraformBlock
{
    /// <summary>
    /// Location policy specifies the algorithm used when scaling-up the node pool. &amp;quot;BALANCED&amp;quot; - Is a best effort policy that aims to balance the sizes of available zones. &amp;quot;ANY&amp;quot; - Instructs the cluster autoscaler to prioritize utilization of unused reservations, and reduces preemption risk for Spot VMs.
    /// </summary>
    [TerraformPropertyName("location_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LocationPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "location_policy");

    /// <summary>
    /// Maximum number of nodes per zone in the node pool. Must be &amp;gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    [TerraformPropertyName("max_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes per zone in the node pool. Must be &amp;gt;=0 and &amp;lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    [TerraformPropertyName("min_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinNodeCount { get; set; }

    /// <summary>
    /// Maximum number of all nodes in the node pool. Must be &amp;gt;= total_min_node_count. Cannot be used with per zone limits.
    /// </summary>
    [TerraformPropertyName("total_max_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TotalMaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of all nodes in the node pool. Must be &amp;gt;=0 and &amp;lt;= total_max_node_count. Cannot be used with per zone limits.
    /// </summary>
    [TerraformPropertyName("total_min_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TotalMinNodeCount { get; set; }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolManagementBlock : ITerraformBlock
{
    /// <summary>
    /// Whether the nodes will be automatically repaired. Enabled by default.
    /// </summary>
    [TerraformPropertyName("auto_repair")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoRepair { get; set; }

    /// <summary>
    /// Whether the nodes will be automatically upgraded. Enabled by default.
    /// </summary>
    [TerraformPropertyName("auto_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoUpgrade { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.
    /// </summary>
    [TerraformPropertyName("create_pod_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreatePodRange { get; set; }

    /// <summary>
    /// Whether nodes have internal IP addresses only.
    /// </summary>
    [TerraformPropertyName("enable_private_nodes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnablePrivateNodes { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable_private_nodes");

    /// <summary>
    /// The IP address range for pod IPs in this node pool. Only applicable if create_pod_range is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.
    /// </summary>
    [TerraformPropertyName("pod_ipv4_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PodIpv4CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "pod_ipv4_cidr_block");

    /// <summary>
    /// The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.
    /// </summary>
    [TerraformPropertyName("pod_range")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PodRange { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "pod_range");

    /// <summary>
    /// The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork} . If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subnetwork => new TerraformReferenceProperty<TerraformProperty<string>>("", "subnetwork");

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    [TerraformPropertyName("boot_disk_kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BootDiskKmsKey { get; set; }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_type");

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    [TerraformPropertyName("effective_taints")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EffectiveTaints => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "effective_taints");

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    [TerraformPropertyName("enable_confidential_storage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableConfidentialStorage { get; set; }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    [TerraformPropertyName("flex_start")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FlexStart { get; set; }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ImageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "image_type");

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "labels");

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> LocalSsdCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "local_ssd_count");

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocalSsdEncryptionMode { get; set; }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    [TerraformPropertyName("logging_variant")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoggingVariant { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "logging_variant");

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MachineType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "machine_type");

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("max_run_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxRunDuration { get; set; }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "metadata");

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinCpuPlatform { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_cpu_platform");

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    [TerraformPropertyName("node_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeGroup { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    [TerraformPropertyName("oauth_scopes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> OauthScopes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "oauth_scopes");

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Preemptible { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceLabels { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceManagerTags { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceAccount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_account");

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    [TerraformPropertyName("spot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Spot { get; set; }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    [TerraformPropertyName("storage_pools")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? StoragePools { get; set; }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Tags { get; set; }

}

/// <summary>
/// Block type for placement_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolPlacementPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.
    /// </summary>
    [TerraformPropertyName("policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyName { get; set; }

    /// <summary>
    /// The TPU topology like &amp;quot;2x4&amp;quot; or &amp;quot;2x2x2&amp;quot;. https://cloud.google.com/kubernetes-engine/docs/concepts/plan-tpus#topology
    /// </summary>
    [TerraformPropertyName("tpu_topology")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TpuTopology { get; set; }

    /// <summary>
    /// Type defines the type of placement policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for queued_provisioning in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolQueuedProvisioningBlock : ITerraformBlock
{
    /// <summary>
    /// Whether nodes in this node pool are obtainable solely through the ProvisioningRequest API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerNodePoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolUpgradeSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.
    /// </summary>
    [TerraformPropertyName("max_surge")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxSurge { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_surge");

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.
    /// </summary>
    [TerraformPropertyName("max_unavailable")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxUnavailable { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_unavailable");

    /// <summary>
    /// Update strategy for the given nodepool.
    /// </summary>
    [TerraformPropertyName("strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Strategy { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> InitialNodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "initial_node_count");

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Location { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("max_pods_per_node")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxPodsPerNode { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_pods_per_node");

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> NodeLocations { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "node_locations");

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    [TerraformPropertyName("autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolAutoscalingBlock>>? Autoscaling { get; set; } = new();

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    [TerraformPropertyName("management")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolManagementBlock>>? Management { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolNodeConfigBlock>>? NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlacementPolicy block(s) allowed")]
    [TerraformPropertyName("placement_policy")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolPlacementPolicyBlock>>? PlacementPolicy { get; set; } = new();

    /// <summary>
    /// Block for queued_provisioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueuedProvisioning block(s) allowed")]
    [TerraformPropertyName("queued_provisioning")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolQueuedProvisioningBlock>>? QueuedProvisioning { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerNodePoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformPropertyName("upgrade_settings")]
    public TerraformList<TerraformBlock<GoogleContainerNodePoolUpgradeSettingsBlock>>? UpgradeSettings { get; set; } = new();

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    [TerraformPropertyName("instance_group_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InstanceGroupUrls => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "instance_group_urls");

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    [TerraformPropertyName("managed_instance_group_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ManagedInstanceGroupUrls => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "managed_instance_group_urls");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Operation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "operation");

}
