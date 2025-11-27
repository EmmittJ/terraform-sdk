using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for node_pool_config in GoogleGkeonpremBareMetalNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool_config";

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to
    /// each node. These will added in addition to any default label(s)
    /// that Kubernetes may apply to the node. In case of conflict in
    /// label keys, the applied set may differ depending on the Kubernetes
    /// version -- it&#39;s best to assume the behavior is undefined and
    /// conflicts should be avoided. For more information, including usage
    /// and the valid values, see:
    ///   - http://kubernetes.io/v1.1/docs/user-guide/labels.html
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// For example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Specifies the nodes operating system (default: LINUX).
    /// </summary>
    public TerraformValue<string> OperatingSystem
    {
        get => new TerraformReference<string>(this, "operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// NodeConfigs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeConfigs block(s) required")]
    public required TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlockNodeConfigsBlock> NodeConfigs
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlockNodeConfigsBlock>>("node_configs");
        set => SetArgument("node_configs", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

}

/// <summary>
/// Block type for node_configs in GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlockNodeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_configs";

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to
    /// each node. These will added in addition to any default label(s)
    /// that Kubernetes may apply to the node. In case of conflict in
    /// label keys, the applied set may differ depending on the Kubernetes
    /// version -- it&#39;s best to assume the behavior is undefined and
    /// conflicts should be avoided. For more information, including usage
    /// and the valid values, see:
    ///   - http://kubernetes.io/v1.1/docs/user-guide/labels.html
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// For example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The default IPv4 address for SSH access and Kubernetes node.
    /// Example: 192.168.0.1
    /// </summary>
    public TerraformValue<string>? NodeIp
    {
        get => new TerraformReference<string>(this, "node_ip");
        set => SetArgument("node_ip", value);
    }

}

/// <summary>
/// Block type for taints in GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlockTaintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taints";

    /// <summary>
    /// Specifies the nodes operating system (default: LINUX). Possible values: [&amp;quot;EFFECT_UNSPECIFIED&amp;quot;, &amp;quot;PREFER_NO_SCHEDULE&amp;quot;, &amp;quot;NO_EXECUTE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Effect
    {
        get => new TerraformReference<string>(this, "effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key associated with the effect.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value associated with the effect.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeonpremBareMetalNodePool.
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremBareMetalNodePoolTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_gkeonprem_bare_metal_node_pool Terraform resource.
/// Manages a google_gkeonprem_bare_metal_node_pool resource.
/// </summary>
public partial class GoogleGkeonpremBareMetalNodePool(string name) : TerraformResource("google_gkeonprem_bare_metal_node_pool", name)
{
    /// <summary>
    /// Annotations on the Bare Metal Node Pool.
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BareMetalCluster is required")]
    public required TerraformValue<string> BareMetalCluster
    {
        get => new TerraformReference<string>(this, "bare_metal_cluster");
        set => SetArgument("bare_metal_cluster", value);
    }

    /// <summary>
    /// The display name for the Bare Metal Node Pool.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The bare metal node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal User Cluster.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Specifies detailed node pool status.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique identifier of the Bare Metal Node Pool.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// NodePoolConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodePoolConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodePoolConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock> NodePoolConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock>>("node_pool_config");
        set => SetArgument("node_pool_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeonpremBareMetalNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeonpremBareMetalNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
