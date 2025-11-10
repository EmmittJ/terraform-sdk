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
        set => SetProperty("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The number of CPUs for each node in the node pool.
    /// </summary>
    public TerraformProperty<double>? Cpus
    {
        set => SetProperty("cpus", value);
    }

    /// <summary>
    /// Allow node pool traffic to be load balanced. Only works for clusters with
    /// MetalLB load balancers.
    /// </summary>
    public TerraformProperty<bool>? EnableLoadBalancer
    {
        set => SetProperty("enable_load_balancer", value);
    }

    /// <summary>
    /// The OS image name in vCenter, only valid when using Windows.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The OS image to be used for each node in a node pool.
    /// Currently &#39;cos&#39;, &#39;cos_cgv2&#39;, &#39;ubuntu&#39;, &#39;ubuntu_cgv2&#39;, &#39;ubuntu_containerd&#39; and &#39;windows&#39; are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageType is required")]
    public required TerraformProperty<string> ImageType
    {
        set => SetProperty("image_type", value);
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
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The megabytes of memory for each node in the node pool.
    /// </summary>
    public TerraformProperty<double>? MemoryMb
    {
        set => SetProperty("memory_mb", value);
    }

    /// <summary>
    /// The number of nodes in the node pool.
    /// </summary>
    public TerraformProperty<double>? Replicas
    {
        set => SetProperty("replicas", value);
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
        set => SetProperty("max_replicas", value);
    }

    /// <summary>
    /// Minimum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    public required TerraformProperty<double> MinReplicas
    {
        set => SetProperty("min_replicas", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("create_time");
        SetOutput("delete_time");
        SetOutput("effective_annotations");
        SetOutput("etag");
        SetOutput("reconciling");
        SetOutput("state");
        SetOutput("status");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("on_prem_version");
        SetOutput("project");
        SetOutput("vmware_cluster");
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
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The display name for the node pool.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The vmware node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Anthos version for the node pool. Defaults to the user cluster version.
    /// </summary>
    public TerraformProperty<string> OnPremVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("on_prem_version");
        set => SetProperty("on_prem_version", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCluster is required")]
    public required TerraformProperty<string> VmwareCluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vmware_cluster");
        set => SetProperty("vmware_cluster", value);
    }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GoogleGkeonpremVmwareNodePoolConfigBlock>? Config
    {
        set => SetProperty("config", value);
    }

    /// <summary>
    /// Block for node_pool_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoscaling block(s) allowed")]
    public List<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>? NodePoolAutoscaling
    {
        set => SetProperty("node_pool_autoscaling", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeonpremVmwareNodePoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
