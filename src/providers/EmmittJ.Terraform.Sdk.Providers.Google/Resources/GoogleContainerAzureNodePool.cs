using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAzureNodePoolAutoscalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Maximum number of nodes in the node pool. Must be &amp;gt;= min_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformProperty("max_node_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes in the node pool. Must be &amp;gt;= 1 and &amp;lt;= max_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformProperty("min_node_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinNodeCount { get; set; }

}

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAzureNodePoolConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. The initial labels assigned to nodes of this node pool. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Optional. A set of tags to apply to all underlying Azure resources for this node pool. This currently only includes Virtual Machine Scale Sets. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Optional. The Azure VM size name. Example: `Standard_DS2_v2`. See (/anthos/clusters/docs/azure/reference/supported-vms) for options. When unspecified, it defaults to `Standard_DS2_v2`.
    /// </summary>
    [TerraformProperty("vm_size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VmSize { get; set; }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAzureNodePoolManagementBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Whether or not the nodes will be automatically repaired.
    /// </summary>
    [TerraformProperty("auto_repair")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AutoRepair { get; set; }

}

/// <summary>
/// Block type for max_pods_constraint in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAzureNodePoolMaxPodsConstraintBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum number of pods to schedule on a single node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsPerNode is required")]
    [TerraformProperty("max_pods_per_node")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxPodsPerNode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContainerAzureNodePoolTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_container_azure_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContainerAzureNodePool : TerraformResource
{
    public GoogleContainerAzureNodePool(string name) : base("google_container_azure_node_pool", name)
    {
    }

    /// <summary>
    /// Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Optional. The Azure availability zone of the nodes in this nodepool. When unspecified, it defaults to `1`.
    /// </summary>
    [TerraformProperty("azure_availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AzureAvailabilityZone { get; set; }

    /// <summary>
    /// The azureCluster for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The ARM ID of the subnet where the node pool VMs run. Make sure it&#39;s a subnet under the virtual network in the cluster configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The Kubernetes version (e.g. `1.19.10-gke.1000`) running on this node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autoscaling is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Autoscaling block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    [TerraformProperty("autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerAzureNodePoolAutoscalingBlock>>? Autoscaling { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformProperty("config")]
    public TerraformList<TerraformBlock<GoogleContainerAzureNodePoolConfigBlock>>? Config { get; set; }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    [TerraformProperty("management")]
    public TerraformList<TerraformBlock<GoogleContainerAzureNodePoolManagementBlock>>? Management { get; set; }

    /// <summary>
    /// Block for max_pods_constraint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsConstraint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaxPodsConstraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxPodsConstraint block(s) allowed")]
    [TerraformProperty("max_pods_constraint")]
    public TerraformList<TerraformBlock<GoogleContainerAzureNodePoolMaxPodsConstraintBlock>>? MaxPodsConstraint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleContainerAzureNodePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The time at which this node pool was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. If set, there are currently pending changes to the node pool.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// Output only. The current state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. A globally unique identifier for the node pool.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The time at which this node pool was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
