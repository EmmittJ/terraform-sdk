using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in GoogleGkeonpremVmwareNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// VMware disk size to be used during creation.
    /// </summary>
    public TerraformValue<double>? BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// The number of CPUs for each node in the node pool.
    /// </summary>
    public TerraformValue<double>? Cpus
    {
        get => GetArgument<TerraformValue<double>>("cpus");
        set => SetArgument("cpus", value);
    }

    /// <summary>
    /// Allow node pool traffic to be load balanced. Only works for clusters with
    /// MetalLB load balancers.
    /// </summary>
    public TerraformValue<bool>? EnableLoadBalancer
    {
        get => GetArgument<TerraformValue<bool>>("enable_load_balancer");
        set => SetArgument("enable_load_balancer", value);
    }

    /// <summary>
    /// The OS image name in vCenter, only valid when using Windows.
    /// </summary>
    public TerraformValue<string> Image
    {
        get => GetArgument<TerraformValue<string>>("image") ?? CreateReference("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The OS image to be used for each node in a node pool.
    /// Currently &#39;cos&#39;, &#39;cos_cgv2&#39;, &#39;ubuntu&#39;, &#39;ubuntu_cgv2&#39;, &#39;ubuntu_containerd&#39; and &#39;windows&#39; are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageType is required")]
    public required TerraformValue<string> ImageType
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_type");
        set => SetArgument("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node.
    /// These will added in addition to any default label(s) that
    /// Kubernetes may apply to the node.
    /// In case of conflict in label keys, the applied set may differ depending on
    /// the Kubernetes version -- it&#39;s best to assume the behavior is undefined
    /// and conflicts should be avoided.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? CreateReference("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The megabytes of memory for each node in the node pool.
    /// </summary>
    public TerraformValue<double>? MemoryMb
    {
        get => GetArgument<TerraformValue<double>>("memory_mb");
        set => SetArgument("memory_mb", value);
    }

    /// <summary>
    /// The number of nodes in the node pool.
    /// </summary>
    public TerraformValue<double>? Replicas
    {
        get => GetArgument<TerraformValue<double>>("replicas");
        set => SetArgument("replicas", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

    /// <summary>
    /// VsphereConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VsphereConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlock>? VsphereConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlock>>("vsphere_config");
        set => SetArgument("vsphere_config", value);
    }

}

/// <summary>
/// Block type for taints in GoogleGkeonpremVmwareNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlockTaintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taints";

    /// <summary>
    /// Available taint effects. Possible values: [&amp;quot;EFFECT_UNSPECIFIED&amp;quot;, &amp;quot;NO_SCHEDULE&amp;quot;, &amp;quot;PREFER_NO_SCHEDULE&amp;quot;, &amp;quot;NO_EXECUTE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Effect
    {
        get => GetArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key associated with the effect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value associated with the effect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for vsphere_config in GoogleGkeonpremVmwareNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vsphere_config";

    /// <summary>
    /// The name of the vCenter datastore. Inherited from the user cluster.
    /// </summary>
    public TerraformValue<string>? Datastore
    {
        get => GetArgument<TerraformValue<string>>("datastore");
        set => SetArgument("datastore", value);
    }

    /// <summary>
    /// Vsphere host groups to apply to all VMs in the node pool
    /// </summary>
    public TerraformList<string>? HostGroups
    {
        get => GetArgument<TerraformList<string>>("host_groups");
        set => SetArgument("host_groups", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tags in GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolConfigBlockVsphereConfigBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The Vsphere tag category.
    /// </summary>
    public TerraformValue<string>? Category
    {
        get => GetArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The Vsphere tag name.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

}


/// <summary>
/// Block type for node_pool_autoscaling in GoogleGkeonpremVmwareNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool_autoscaling";

    /// <summary>
    /// Maximum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    public required TerraformValue<double> MaxReplicas
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_replicas");
        set => SetArgument("max_replicas", value);
    }

    /// <summary>
    /// Minimum number of replicas in the NodePool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    public required TerraformValue<double> MinReplicas
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_replicas");
        set => SetArgument("min_replicas", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeonpremVmwareNodePool.
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareNodePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_gkeonprem_vmware_node_pool Terraform resource.
/// Manages a google_gkeonprem_vmware_node_pool resource.
/// </summary>
public partial class GoogleGkeonpremVmwareNodePool(string name) : TerraformResource("google_gkeonprem_vmware_node_pool", name)
{
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
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The display name for the node pool.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The vmware node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Anthos version for the node pool. Defaults to the user cluster version.
    /// </summary>
    public TerraformValue<string>? OnPremVersion
    {
        get => GetArgument<TerraformValue<string>>("on_prem_version");
        set => SetArgument("on_prem_version", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCluster is required")]
    public required TerraformValue<string> VmwareCluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("vmware_cluster");
        set => SetArgument("vmware_cluster", value);
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => CreateReference("delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// If set, there are currently changes in flight to the node pool.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => CreateReference("status");

    /// <summary>
    /// The unique identifier of the node pool.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareNodePoolConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// NodePoolAutoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoscaling block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>? NodePoolAutoscaling
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareNodePoolNodePoolAutoscalingBlock>>("node_pool_autoscaling");
        set => SetArgument("node_pool_autoscaling", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeonpremVmwareNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeonpremVmwareNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
