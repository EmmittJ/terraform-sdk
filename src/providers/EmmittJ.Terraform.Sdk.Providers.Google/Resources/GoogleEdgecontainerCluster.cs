using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// AdminUsers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AdminUsers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminUsers block(s) allowed")]
    public required TerraformList<GoogleEdgecontainerClusterAuthorizationBlockAdminUsersBlock> AdminUsers
    {
        get => GetRequiredArgument<TerraformList<GoogleEdgecontainerClusterAuthorizationBlockAdminUsersBlock>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}

/// <summary>
/// Block type for admin_users in GoogleEdgecontainerClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterAuthorizationBlockAdminUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_users";

    /// <summary>
    /// An active Google username.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for control_plane in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane";

    /// <summary>
    /// Local block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Local block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterControlPlaneBlockLocalBlock>? Local
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterControlPlaneBlockLocalBlock>>("local");
        set => SetArgument("local", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterControlPlaneBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterControlPlaneBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for local in GoogleEdgecontainerClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneBlockLocalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local";

    /// <summary>
    /// Only machines matching this filter will be allowed to host control
    /// plane nodes. The filtering language accepts strings like &amp;quot;name=&amp;lt;name&amp;gt;&amp;quot;,
    /// and is documented here: [AIP-160](https://google.aip.dev/160).
    /// </summary>
    public TerraformValue<string>? MachineFilter
    {
        get => new TerraformReference<string>(this, "machine_filter");
        set => SetArgument("machine_filter", value);
    }

    /// <summary>
    /// The number of nodes to serve as replicas of the Control Plane.
    /// Only 1 and 3 are supported.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// Name of the Google Distributed Cloud Edge zones where this node pool
    /// will be created. For example: &#39;us-central1-edge-customer-a&#39;.
    /// </summary>
    public TerraformValue<string> NodeLocation
    {
        get => new TerraformReference<string>(this, "node_location");
        set => SetArgument("node_location", value);
    }

    /// <summary>
    /// Policy configuration about how user applications are deployed. Possible values: [&amp;quot;SHARED_DEPLOYMENT_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;ALLOWED&amp;quot;, &amp;quot;DISALLOWED&amp;quot;]
    /// </summary>
    public TerraformValue<string> SharedDeploymentPolicy
    {
        get => new TerraformReference<string>(this, "shared_deployment_policy");
        set => SetArgument("shared_deployment_policy", value);
    }

}

/// <summary>
/// Block type for remote in GoogleEdgecontainerClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// Name of the Google Distributed Cloud Edge zones where this node pool
    /// will be created. For example: &#39;us-central1-edge-customer-a&#39;.
    /// </summary>
    public TerraformValue<string> NodeLocation
    {
        get => new TerraformReference<string>(this, "node_location");
        set => SetArgument("node_location", value);
    }

}


/// <summary>
/// Block type for control_plane_encryption in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_encryption";

    /// <summary>
    /// The Cloud KMS CryptoKey e.g.
    /// projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// to use for protecting control plane disks. If not specified, a
    /// Google-managed key will be used instead.
    /// </summary>
    public TerraformValue<string> KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The Cloud KMS CryptoKeyVersion currently in use for protecting control
    /// plane disks. Only applicable if kms_key is set.
    /// </summary>
    public TerraformValue<string> KmsKeyActiveVersion
    {
        get => new TerraformReference<string>(this, "kms_key_active_version");
    }

    /// <summary>
    /// Availability of the Cloud KMS CryptoKey. If not &#39;KEY_AVAILABLE&#39;, then
    /// nodes may go offline as they cannot access their local data. This can be
    /// caused by a lack of permissions to use the key, or if the key is disabled
    /// or deleted.
    /// </summary>
    public TerraformValue<string> KmsKeyState
    {
        get => new TerraformReference<string>(this, "kms_key_state");
    }

    /// <summary>
    /// Error status returned by Cloud KMS when using this key. This field may be
    /// populated only if &#39;kms_key_state&#39; is not &#39;KMS_KEY_STATE_KEY_AVAILABLE&#39;.
    /// If populated, this field contains the error status reported by Cloud KMS.
    /// </summary>
    public TerraformList<TerraformMap<object>> KmsStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kms_status").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for fleet in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet";

    /// <summary>
    /// The name of the managed Hub Membership resource associated to this cluster.
    /// Membership names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;&#39;.
    /// </summary>
    public TerraformValue<string> Membership
    {
        get => new TerraformReference<string>(this, "membership");
    }

    /// <summary>
    /// The name of the Fleet host project where this cluster will be registered.
    /// Project names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for maintenance_policy in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_policy";

    /// <summary>
    /// MaintenanceExclusions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlock>? MaintenanceExclusions
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlock>>("maintenance_exclusions");
        set => SetArgument("maintenance_exclusions", value);
    }

    /// <summary>
    /// Window block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Window is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Window block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    public required TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlock> Window
    {
        get => GetRequiredArgument<TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlock>>("window");
        set => SetArgument("window", value);
    }

}

/// <summary>
/// Block type for maintenance_exclusions in GoogleEdgecontainerClusterMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_exclusions";

    /// <summary>
    /// A unique (per cluster) id for the window.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Window block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlockWindowBlock>? Window
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlockWindowBlock>>("window");
        set => SetArgument("window", value);
    }

}

/// <summary>
/// Block type for window in GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlockMaintenanceExclusionsBlockWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "window";

    /// <summary>
    /// The time that the window ends. The end time must take place after the
    /// start time.
    /// </summary>
    public TerraformValue<string> EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The time that the window first starts.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for window in GoogleEdgecontainerClusterMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "window";

    /// <summary>
    /// RecurringWindow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurringWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecurringWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringWindow block(s) allowed")]
    public required TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlock> RecurringWindow
    {
        get => GetRequiredArgument<TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlock>>("recurring_window");
        set => SetArgument("recurring_window", value);
    }

}

/// <summary>
/// Block type for recurring_window in GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurring_window";

    /// <summary>
    /// An RRULE (https://tools.ietf.org/html/rfc5545#section-3.8.5.3) for how
    /// this window recurs. They go on for the span of time between the start and
    /// end time.
    /// </summary>
    public TerraformValue<string> Recurrence
    {
        get => new TerraformReference<string>(this, "recurrence");
        set => SetArgument("recurrence", value);
    }

    /// <summary>
    /// Window block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlockWindowBlock>? Window
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlockWindowBlock>>("window");
        set => SetArgument("window", value);
    }

}

/// <summary>
/// Block type for window in GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlockWindowBlockRecurringWindowBlockWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "window";

    /// <summary>
    /// The time that the window ends. The end time must take place after the
    /// start time.
    /// </summary>
    public TerraformValue<string> EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The time that the window first starts.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for networking in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networking";

    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIpv4CidrBlocks is required")]
    public TerraformList<string>? ClusterIpv4CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cluster_ipv4_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("cluster_ipv4_cidr_blocks", value);
    }

    /// <summary>
    /// If specified, dual stack mode is enabled and all pods in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    public TerraformList<string>? ClusterIpv6CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cluster_ipv6_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("cluster_ipv6_cidr_blocks", value);
    }

    /// <summary>
    /// IP addressing type of this cluster i.e. SINGLESTACK_V4 vs DUALSTACK_V4_V6.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicesIpv4CidrBlocks is required")]
    public TerraformList<string>? ServicesIpv4CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "services_ipv4_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("services_ipv4_cidr_blocks", value);
    }

    /// <summary>
    /// If specified, dual stack mode is enabled and all services in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    public TerraformList<string>? ServicesIpv6CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "services_ipv6_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("services_ipv6_cidr_blocks", value);
    }

}


/// <summary>
/// Block type for system_addons_config in GoogleEdgecontainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterSystemAddonsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "system_addons_config";

    /// <summary>
    /// Ingress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterSystemAddonsConfigBlockIngressBlock>? Ingress
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterSystemAddonsConfigBlockIngressBlock>>("ingress");
        set => SetArgument("ingress", value);
    }

}

/// <summary>
/// Block type for ingress in GoogleEdgecontainerClusterSystemAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterSystemAddonsConfigBlockIngressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress";

    /// <summary>
    /// Whether Ingress is disabled.
    /// </summary>
    public TerraformValue<bool> Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Ingress VIP.
    /// </summary>
    public TerraformValue<string> Ipv4Vip
    {
        get => new TerraformReference<string>(this, "ipv4_vip");
        set => SetArgument("ipv4_vip", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleEdgecontainerCluster.
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerClusterTimeoutsBlock : TerraformBlock
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
/// Represents a google_edgecontainer_cluster Terraform resource.
/// Manages a google_edgecontainer_cluster resource.
/// </summary>
public partial class GoogleEdgecontainerCluster(string name) : TerraformResource("google_edgecontainer_cluster", name)
{
    /// <summary>
    /// The default maximum number of pods per node used if a maximum value is not
    /// specified explicitly for a node pool in this cluster. If unspecified, the
    /// Kubernetes default value will be used.
    /// </summary>
    public TerraformValue<double> DefaultMaxPodsPerNode
    {
        get => new TerraformReference<double>(this, "default_max_pods_per_node");
        set => SetArgument("default_max_pods_per_node", value);
    }

    /// <summary>
    /// Address pools for cluster data plane external load balancing.
    /// </summary>
    public TerraformList<string> ExternalLoadBalancerIpv4AddressPools
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_load_balancer_ipv4_address_pools").ResolveNodes(ctx));
        set => SetArgument("external_load_balancer_ipv4_address_pools", value);
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
    /// User-defined labels for the edgecloud cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
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
    /// The GDCE cluster name.
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
    /// The release channel a cluster is subscribed to. Possible values: [&amp;quot;RELEASE_CHANNEL_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;REGULAR&amp;quot;]
    /// </summary>
    public TerraformValue<string> ReleaseChannel
    {
        get => new TerraformReference<string>(this, "release_channel");
        set => SetArgument("release_channel", value);
    }

    /// <summary>
    /// The target cluster version. For example: &amp;quot;1.5.0&amp;quot;.
    /// </summary>
    public TerraformValue<string> TargetVersion
    {
        get => new TerraformReference<string>(this, "target_version");
        set => SetArgument("target_version", value);
    }

    /// <summary>
    /// The PEM-encoded public certificate of the cluster&#39;s CA.
    /// </summary>
    public TerraformValue<string> ClusterCaCertificate
    {
        get => new TerraformReference<string>(this, "cluster_ca_certificate");
    }

    /// <summary>
    /// The control plane release version.
    /// </summary>
    public TerraformValue<string> ControlPlaneVersion
    {
        get => new TerraformReference<string>(this, "control_plane_version");
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The IP address of the Kubernetes API server.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// All the maintenance events scheduled for the cluster, including the ones
    /// ongoing, planned for the future and done in the past (up to 90 days).
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceEvents
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_events").ResolveNodes(ctx));
    }

    /// <summary>
    /// The lowest release version among all worker nodes. This field can be empty
    /// if the cluster does not have any worker nodes.
    /// </summary>
    public TerraformValue<string> NodeVersion
    {
        get => new TerraformReference<string>(this, "node_version");
    }

    /// <summary>
    /// The port number of the Kubernetes API server.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// Indicates the status of the cluster.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public required TerraformList<GoogleEdgecontainerClusterAuthorizationBlock> Authorization
    {
        get => GetRequiredArgument<TerraformList<GoogleEdgecontainerClusterAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// ControlPlane block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterControlPlaneBlock>? ControlPlane
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterControlPlaneBlock>>("control_plane");
        set => SetArgument("control_plane", value);
    }

    /// <summary>
    /// ControlPlaneEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEncryption block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterControlPlaneEncryptionBlock>? ControlPlaneEncryption
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterControlPlaneEncryptionBlock>>("control_plane_encryption");
        set => SetArgument("control_plane_encryption", value);
    }

    /// <summary>
    /// Fleet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public required TerraformList<GoogleEdgecontainerClusterFleetBlock> Fleet
    {
        get => GetRequiredArgument<TerraformList<GoogleEdgecontainerClusterFleetBlock>>("fleet");
        set => SetArgument("fleet", value);
    }

    /// <summary>
    /// MaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlock>? MaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterMaintenancePolicyBlock>>("maintenance_policy");
        set => SetArgument("maintenance_policy", value);
    }

    /// <summary>
    /// Networking block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networking is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    public required TerraformList<GoogleEdgecontainerClusterNetworkingBlock> Networking
    {
        get => GetRequiredArgument<TerraformList<GoogleEdgecontainerClusterNetworkingBlock>>("networking");
        set => SetArgument("networking", value);
    }

    /// <summary>
    /// SystemAddonsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemAddonsConfig block(s) allowed")]
    public TerraformList<GoogleEdgecontainerClusterSystemAddonsConfigBlock>? SystemAddonsConfig
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerClusterSystemAddonsConfigBlock>>("system_addons_config");
        set => SetArgument("system_addons_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEdgecontainerClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEdgecontainerClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
