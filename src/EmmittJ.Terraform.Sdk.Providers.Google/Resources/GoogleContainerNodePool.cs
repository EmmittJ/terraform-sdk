using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Location policy specifies the algorithm used when scaling-up the node pool. &amp;quot;BALANCED&amp;quot; - Is a best effort policy that aims to balance the sizes of available zones. &amp;quot;ANY&amp;quot; - Instructs the cluster autoscaler to prioritize utilization of unused reservations, and reduces preemption risk for Spot VMs.
    /// </summary>
    public TerraformProperty<string>? LocationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("location_policy");
        set => WithProperty("location_policy", value);
    }

    /// <summary>
    /// Maximum number of nodes per zone in the node pool. Must be &amp;gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    public TerraformProperty<double>? MaxNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes per zone in the node pool. Must be &amp;gt;=0 and &amp;lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    public TerraformProperty<double>? MinNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("min_node_count");
        set => WithProperty("min_node_count", value);
    }

    /// <summary>
    /// Maximum number of all nodes in the node pool. Must be &amp;gt;= total_min_node_count. Cannot be used with per zone limits.
    /// </summary>
    public TerraformProperty<double>? TotalMaxNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("total_max_node_count");
        set => WithProperty("total_max_node_count", value);
    }

    /// <summary>
    /// Minimum number of all nodes in the node pool. Must be &amp;gt;=0 and &amp;lt;= total_max_node_count. Cannot be used with per zone limits.
    /// </summary>
    public TerraformProperty<double>? TotalMinNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("total_min_node_count");
        set => WithProperty("total_min_node_count", value);
    }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolManagementBlock : TerraformBlock
{
    /// <summary>
    /// Whether the nodes will be automatically repaired. Enabled by default.
    /// </summary>
    public TerraformProperty<bool>? AutoRepair
    {
        get => GetProperty<TerraformProperty<bool>>("auto_repair");
        set => WithProperty("auto_repair", value);
    }

    /// <summary>
    /// Whether the nodes will be automatically upgraded. Enabled by default.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade");
        set => WithProperty("auto_upgrade", value);
    }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.
    /// </summary>
    public TerraformProperty<bool>? CreatePodRange
    {
        get => GetProperty<TerraformProperty<bool>>("create_pod_range");
        set => WithProperty("create_pod_range", value);
    }

    /// <summary>
    /// Whether nodes have internal IP addresses only.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateNodes
    {
        get => GetProperty<TerraformProperty<bool>>("enable_private_nodes");
        set => WithProperty("enable_private_nodes", value);
    }

    /// <summary>
    /// The IP address range for pod IPs in this node pool. Only applicable if create_pod_range is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.
    /// </summary>
    public TerraformProperty<string>? PodIpv4CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("pod_ipv4_cidr_block");
        set => WithProperty("pod_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.
    /// </summary>
    public TerraformProperty<string>? PodRange
    {
        get => GetProperty<TerraformProperty<string>>("pod_range");
        set => WithProperty("pod_range", value);
    }

    /// <summary>
    /// The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork} . If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => WithProperty("subnetwork", value);
    }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    public TerraformProperty<string>? BootDiskKmsKey
    {
        get => GetProperty<TerraformProperty<string>>("boot_disk_kms_key");
        set => WithProperty("boot_disk_kms_key", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        get => GetProperty<TerraformProperty<string>>("disk_type");
        set => WithProperty("disk_type", value);
    }

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    public List<TerraformProperty<object>>? EffectiveTaints
    {
        get => GetProperty<List<TerraformProperty<object>>>("effective_taints");
        set => WithProperty("effective_taints", value);
    }

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    public TerraformProperty<bool>? EnableConfidentialStorage
    {
        get => GetProperty<TerraformProperty<bool>>("enable_confidential_storage");
        set => WithProperty("enable_confidential_storage", value);
    }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    public TerraformProperty<bool>? FlexStart
    {
        get => GetProperty<TerraformProperty<bool>>("flex_start");
        set => WithProperty("flex_start", value);
    }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    public TerraformProperty<string>? ImageType
    {
        get => GetProperty<TerraformProperty<string>>("image_type");
        set => WithProperty("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    public TerraformProperty<double>? LocalSsdCount
    {
        get => GetProperty<TerraformProperty<double>>("local_ssd_count");
        set => WithProperty("local_ssd_count", value);
    }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    public TerraformProperty<string>? LocalSsdEncryptionMode
    {
        get => GetProperty<TerraformProperty<string>>("local_ssd_encryption_mode");
        set => WithProperty("local_ssd_encryption_mode", value);
    }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    public TerraformProperty<string>? LoggingVariant
    {
        get => GetProperty<TerraformProperty<string>>("logging_variant");
        set => WithProperty("logging_variant", value);
    }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => WithProperty("machine_type", value);
    }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MaxRunDuration
    {
        get => GetProperty<TerraformProperty<string>>("max_run_duration");
        set => WithProperty("max_run_duration", value);
    }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => WithProperty("metadata", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    public TerraformProperty<string>? MinCpuPlatform
    {
        get => GetProperty<TerraformProperty<string>>("min_cpu_platform");
        set => WithProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    public TerraformProperty<string>? NodeGroup
    {
        get => GetProperty<TerraformProperty<string>>("node_group");
        set => WithProperty("node_group", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OauthScopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("oauth_scopes");
        set => WithProperty("oauth_scopes", value);
    }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    public TerraformProperty<bool>? Preemptible
    {
        get => GetProperty<TerraformProperty<bool>>("preemptible");
        set => WithProperty("preemptible", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_labels");
        set => WithProperty("resource_labels", value);
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
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => WithProperty("service_account", value);
    }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    public TerraformProperty<bool>? Spot
    {
        get => GetProperty<TerraformProperty<bool>>("spot");
        set => WithProperty("spot", value);
    }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    public List<TerraformProperty<string>>? StoragePools
    {
        get => GetProperty<List<TerraformProperty<string>>>("storage_pools");
        set => WithProperty("storage_pools", value);
    }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        get => GetProperty<List<TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

}

/// <summary>
/// Block type for placement_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolPlacementPolicyBlock : TerraformBlock
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.
    /// </summary>
    public TerraformProperty<string>? PolicyName
    {
        get => GetProperty<TerraformProperty<string>>("policy_name");
        set => WithProperty("policy_name", value);
    }

    /// <summary>
    /// The TPU topology like &amp;quot;2x4&amp;quot; or &amp;quot;2x2x2&amp;quot;. https://cloud.google.com/kubernetes-engine/docs/concepts/plan-tpus#topology
    /// </summary>
    public TerraformProperty<string>? TpuTopology
    {
        get => GetProperty<TerraformProperty<string>>("tpu_topology");
        set => WithProperty("tpu_topology", value);
    }

    /// <summary>
    /// Type defines the type of placement policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for queued_provisioning in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolQueuedProvisioningBlock : TerraformBlock
{
    /// <summary>
    /// Whether nodes in this node pool are obtainable solely through the ProvisioningRequest API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerNodePoolTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerNodePoolUpgradeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.
    /// </summary>
    public TerraformProperty<double>? MaxSurge
    {
        get => GetProperty<TerraformProperty<double>>("max_surge");
        set => WithProperty("max_surge", value);
    }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailable
    {
        get => GetProperty<TerraformProperty<double>>("max_unavailable");
        set => WithProperty("max_unavailable", value);
    }

    /// <summary>
    /// Update strategy for the given nodepool.
    /// </summary>
    public TerraformProperty<string>? Strategy
    {
        get => GetProperty<TerraformProperty<string>>("strategy");
        set => WithProperty("strategy", value);
    }

}

/// <summary>
/// Manages a google_container_node_pool resource.
/// </summary>
public class GoogleContainerNodePool : TerraformResource
{
    public GoogleContainerNodePool(string name) : base("google_container_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("instance_group_urls");
        this.DeclareOutput("managed_instance_group_urls");
        this.DeclareOutput("operation");
    }

    /// <summary>
    /// The cluster to create the node pool for. Cluster must be present in location provided for zonal clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
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
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    public TerraformProperty<double>? InitialNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("initial_node_count");
        set => this.WithProperty("initial_node_count", value);
    }

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    public TerraformProperty<double>? MaxPodsPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_pods_per_node");
        set => this.WithProperty("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NodeLocations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("node_locations");
        set => this.WithProperty("node_locations", value);
    }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public List<GoogleContainerNodePoolAutoscalingBlock>? Autoscaling
    {
        get => GetProperty<List<GoogleContainerNodePoolAutoscalingBlock>>("autoscaling");
        set => this.WithProperty("autoscaling", value);
    }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public List<GoogleContainerNodePoolManagementBlock>? Management
    {
        get => GetProperty<List<GoogleContainerNodePoolManagementBlock>>("management");
        set => this.WithProperty("management", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleContainerNodePoolNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<GoogleContainerNodePoolNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleContainerNodePoolNodeConfigBlock>? NodeConfig
    {
        get => GetProperty<List<GoogleContainerNodePoolNodeConfigBlock>>("node_config");
        set => this.WithProperty("node_config", value);
    }

    /// <summary>
    /// Block for placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlacementPolicy block(s) allowed")]
    public List<GoogleContainerNodePoolPlacementPolicyBlock>? PlacementPolicy
    {
        get => GetProperty<List<GoogleContainerNodePoolPlacementPolicyBlock>>("placement_policy");
        set => this.WithProperty("placement_policy", value);
    }

    /// <summary>
    /// Block for queued_provisioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueuedProvisioning block(s) allowed")]
    public List<GoogleContainerNodePoolQueuedProvisioningBlock>? QueuedProvisioning
    {
        get => GetProperty<List<GoogleContainerNodePoolQueuedProvisioningBlock>>("queued_provisioning");
        set => this.WithProperty("queued_provisioning", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerNodePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerNodePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public List<GoogleContainerNodePoolUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetProperty<List<GoogleContainerNodePoolUpgradeSettingsBlock>>("upgrade_settings");
        set => this.WithProperty("upgrade_settings", value);
    }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    public TerraformExpression InstanceGroupUrls => this["instance_group_urls"];

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    public TerraformExpression ManagedInstanceGroupUrls => this["managed_instance_group_urls"];

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

}
