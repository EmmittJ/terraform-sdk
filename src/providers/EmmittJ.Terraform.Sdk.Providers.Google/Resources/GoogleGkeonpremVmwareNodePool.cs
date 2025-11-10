using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// VMware disk size to be used during creation.
    /// </summary>
    public TerraformProperty<double>? BootDiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("boot_disk_size_gb");
        set => WithProperty("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The number of CPUs for each node in the node pool.
    /// </summary>
    public TerraformProperty<double>? Cpus
    {
        get => GetProperty<TerraformProperty<double>>("cpus");
        set => WithProperty("cpus", value);
    }

    /// <summary>
    /// Allow node pool traffic to be load balanced. Only works for clusters with
    /// MetalLB load balancers.
    /// </summary>
    public TerraformProperty<bool>? EnableLoadBalancer
    {
        get => GetProperty<TerraformProperty<bool>>("enable_load_balancer");
        set => WithProperty("enable_load_balancer", value);
    }

    /// <summary>
    /// The OS image name in vCenter, only valid when using Windows.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
    }

    /// <summary>
    /// The OS image to be used for each node in a node pool.
    /// Currently &#39;cos&#39;, &#39;cos_cgv2&#39;, &#39;ubuntu&#39;, &#39;ubuntu_cgv2&#39;, &#39;ubuntu_containerd&#39; and &#39;windows&#39; are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageType is required")]
    public required TerraformProperty<string> ImageType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("image_type");
        set => WithProperty("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node.
    /// These will added in addition to any default label(s) that
    /// Kubernetes may apply to the node.
    /// In case of conflict in label keys, the applied set may differ depending on
    /// the Kubernetes version -- it&#39;s best to assume the behavior is undefined
    /// and conflicts should be avoided.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// The megabytes of memory for each node in the node pool.
    /// </summary>
    public TerraformProperty<double>? MemoryMb
    {
        get => GetProperty<TerraformProperty<double>>("memory_mb");
        set => WithProperty("memory_mb", value);
    }

    /// <summary>
    /// The number of nodes in the node pool.
    /// </summary>
    public TerraformProperty<double>? Replicas
    {
        get => GetProperty<TerraformProperty<double>>("replicas");
        set => WithProperty("replicas", value);
    }

}

/// <summary>
/// Block type for node_pool_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Maximum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    public required TerraformProperty<double> MaxReplicas
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_replicas");
        set => WithProperty("max_replicas", value);
    }

    /// <summary>
    /// Minimum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    public required TerraformProperty<double> MinReplicas
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_replicas");
        set => WithProperty("min_replicas", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareNodePoolTimeoutsBlock : TerraformBlock
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
/// Manages a google_gkeonprem_vmware_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremVmwareNodePool : TerraformResource
{
    public GoogleGkeonpremVmwareNodePool(string name) : base("google_gkeonprem_vmware_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("etag");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
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
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The display name for the node pool.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The vmware node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Anthos version for the node pool. Defaults to the user cluster version.
    /// </summary>
    public TerraformProperty<string>? OnPremVersion
    {
        get => GetProperty<TerraformProperty<string>>("on_prem_version");
        set => this.WithProperty("on_prem_version", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCluster is required")]
    public required TerraformProperty<string> VmwareCluster
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vmware_cluster");
        set => this.WithProperty("vmware_cluster", value);
    }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GoogleGkeonpremVmwareNodePoolConfigBlock>? Config
    {
        get => GetProperty<List<GoogleGkeonpremVmwareNodePoolConfigBlock>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Block for node_pool_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoscaling block(s) allowed")]
    public List<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>? NodePoolAutoscaling
    {
        get => GetProperty<List<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>>("node_pool_autoscaling");
        set => this.WithProperty("node_pool_autoscaling", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeonpremVmwareNodePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGkeonpremVmwareNodePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// If set, there are currently changes in flight to the node pool.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The unique identifier of the node pool.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
