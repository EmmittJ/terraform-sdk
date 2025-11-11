using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlock
{
    /// <summary>
    /// VMware disk size to be used during creation.
    /// </summary>
    [TerraformPropertyName("boot_disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The number of CPUs for each node in the node pool.
    /// </summary>
    [TerraformPropertyName("cpus")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Cpus { get; set; }

    /// <summary>
    /// Allow node pool traffic to be load balanced. Only works for clusters with
    /// MetalLB load balancers.
    /// </summary>
    [TerraformPropertyName("enable_load_balancer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableLoadBalancer { get; set; }

    /// <summary>
    /// The OS image name in vCenter, only valid when using Windows.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Image { get; set; } = default!;

    /// <summary>
    /// The OS image to be used for each node in a node pool.
    /// Currently &#39;cos&#39;, &#39;cos_cgv2&#39;, &#39;ubuntu&#39;, &#39;ubuntu_cgv2&#39;, &#39;ubuntu_containerd&#39; and &#39;windows&#39; are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageType is required")]
    [TerraformPropertyName("image_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageType { get; set; }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node.
    /// These will added in addition to any default label(s) that
    /// Kubernetes may apply to the node.
    /// In case of conflict in label keys, the applied set may differ depending on
    /// the Kubernetes version -- it&#39;s best to assume the behavior is undefined
    /// and conflicts should be avoided.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Labels { get; set; } = default!;

    /// <summary>
    /// The megabytes of memory for each node in the node pool.
    /// </summary>
    [TerraformPropertyName("memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MemoryMb { get; set; }

    /// <summary>
    /// The number of nodes in the node pool.
    /// </summary>
    [TerraformPropertyName("replicas")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Replicas { get; set; }

}

/// <summary>
/// Block type for node_pool_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock
{
    /// <summary>
    /// Maximum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    [TerraformPropertyName("max_replicas")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxReplicas { get; set; }

    /// <summary>
    /// Minimum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    [TerraformPropertyName("min_replicas")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinReplicas { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareNodePoolTimeoutsBlock
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
/// Manages a google_gkeonprem_vmware_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremVmwareNodePool : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The display name for the node pool.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The vmware node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Anthos version for the node pool. Defaults to the user cluster version.
    /// </summary>
    [TerraformPropertyName("on_prem_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCluster is required")]
    [TerraformPropertyName("vmware_cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VmwareCluster { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareNodePoolConfigBlock>>? Config { get; set; }

    /// <summary>
    /// Block for node_pool_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoscaling block(s) allowed")]
    [TerraformPropertyName("node_pool_autoscaling")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>>? NodePoolAutoscaling { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeonpremVmwareNodePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeleteTime => new TerraformReference(this, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// If set, there are currently changes in flight to the node pool.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The unique identifier of the node pool.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
