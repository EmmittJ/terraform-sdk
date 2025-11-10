using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlock : ITerraformBlock
{
    /// <summary>
    /// VMware disk size to be used during creation.
    /// </summary>
    [TerraformPropertyName("boot_disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The number of CPUs for each node in the node pool.
    /// </summary>
    [TerraformPropertyName("cpus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Cpus { get; set; }

    /// <summary>
    /// Allow node pool traffic to be load balanced. Only works for clusters with
    /// MetalLB load balancers.
    /// </summary>
    [TerraformPropertyName("enable_load_balancer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLoadBalancer { get; set; }

    /// <summary>
    /// The OS image name in vCenter, only valid when using Windows.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Image { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "image");

    /// <summary>
    /// The OS image to be used for each node in a node pool.
    /// Currently &#39;cos&#39;, &#39;cos_cgv2&#39;, &#39;ubuntu&#39;, &#39;ubuntu_cgv2&#39;, &#39;ubuntu_containerd&#39; and &#39;windows&#39; are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageType is required")]
    [TerraformPropertyName("image_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImageType { get; set; }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node.
    /// These will added in addition to any default label(s) that
    /// Kubernetes may apply to the node.
    /// In case of conflict in label keys, the applied set may differ depending on
    /// the Kubernetes version -- it&#39;s best to assume the behavior is undefined
    /// and conflicts should be avoided.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "labels");

    /// <summary>
    /// The megabytes of memory for each node in the node pool.
    /// </summary>
    [TerraformPropertyName("memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MemoryMb { get; set; }

    /// <summary>
    /// The number of nodes in the node pool.
    /// </summary>
    [TerraformPropertyName("replicas")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Replicas { get; set; }

}

/// <summary>
/// Block type for node_pool_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock : ITerraformBlock
{
    /// <summary>
    /// Maximum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    [TerraformPropertyName("max_replicas")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxReplicas { get; set; }

    /// <summary>
    /// Minimum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    [TerraformPropertyName("min_replicas")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinReplicas { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareNodePoolTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The display name for the node pool.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The vmware node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Anthos version for the node pool. Defaults to the user cluster version.
    /// </summary>
    [TerraformPropertyName("on_prem_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCluster is required")]
    [TerraformPropertyName("vmware_cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmwareCluster { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareNodePoolConfigBlock>>? Config { get; set; } = new();

    /// <summary>
    /// Block for node_pool_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoscaling block(s) allowed")]
    [TerraformPropertyName("node_pool_autoscaling")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>>? NodePoolAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeonpremVmwareNodePoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// If set, there are currently changes in flight to the node pool.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "status");

    /// <summary>
    /// The unique identifier of the node pool.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
