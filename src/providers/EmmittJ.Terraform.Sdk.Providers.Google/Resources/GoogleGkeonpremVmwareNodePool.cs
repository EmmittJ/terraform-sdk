using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareNodePoolConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// VMware disk size to be used during creation.
    /// </summary>
    [TerraformProperty("boot_disk_size_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The number of CPUs for each node in the node pool.
    /// </summary>
    [TerraformProperty("cpus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Cpus { get; set; }

    /// <summary>
    /// Allow node pool traffic to be load balanced. Only works for clusters with
    /// MetalLB load balancers.
    /// </summary>
    [TerraformProperty("enable_load_balancer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableLoadBalancer { get; set; }

    /// <summary>
    /// The OS image name in vCenter, only valid when using Windows.
    /// </summary>
    [TerraformProperty("image")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The OS image to be used for each node in a node pool.
    /// Currently &#39;cos&#39;, &#39;cos_cgv2&#39;, &#39;ubuntu&#39;, &#39;ubuntu_cgv2&#39;, &#39;ubuntu_containerd&#39; and &#39;windows&#39; are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageType is required")]
    [TerraformProperty("image_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageType { get; set; }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node.
    /// These will added in addition to any default label(s) that
    /// Kubernetes may apply to the node.
    /// In case of conflict in label keys, the applied set may differ depending on
    /// the Kubernetes version -- it&#39;s best to assume the behavior is undefined
    /// and conflicts should be avoided.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Labels { get; set; }

    /// <summary>
    /// The megabytes of memory for each node in the node pool.
    /// </summary>
    [TerraformProperty("memory_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MemoryMb { get; set; }

    /// <summary>
    /// The number of nodes in the node pool.
    /// </summary>
    [TerraformProperty("replicas")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Replicas { get; set; }

}

/// <summary>
/// Block type for node_pool_autoscaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Maximum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    [TerraformProperty("max_replicas")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxReplicas { get; set; }

    /// <summary>
    /// Minimum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    [TerraformProperty("min_replicas")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinReplicas { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeonpremVmwareNodePoolTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_gkeonprem_vmware_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeonpremVmwareNodePool : TerraformResource
{
    public GoogleGkeonpremVmwareNodePool(string name) : base("google_gkeonprem_vmware_node_pool", name)
    {
    }

    /// <summary>
    /// Annotations on the node Pool.
    /// This field has the same restrictions as Kubernetes annotations.
    /// The total size of all keys and values combined is limited to 256k.
    /// Key can have 2 segments: prefix (optional) and name (required),
    /// separated by a slash (/).
    /// Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The display name for the node pool.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The vmware node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Anthos version for the node pool. Defaults to the user cluster version.
    /// </summary>
    [TerraformProperty("on_prem_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCluster is required")]
    [TerraformProperty("vmware_cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmwareCluster { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformProperty("config")]
    public partial TerraformList<TerraformBlock<GoogleGkeonpremVmwareNodePoolConfigBlock>>? Config { get; set; }

    /// <summary>
    /// Block for node_pool_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoscaling block(s) allowed")]
    [TerraformProperty("node_pool_autoscaling")]
    public partial TerraformList<TerraformBlock<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>>? NodePoolAutoscaling { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleGkeonpremVmwareNodePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the node pool.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

    /// <summary>
    /// The unique identifier of the node pool.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
