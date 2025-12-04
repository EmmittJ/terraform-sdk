using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_operations in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_operations";

    /// <summary>
    /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
    /// </summary>
    public TerraformValue<bool>? EnableApplicationLogs
    {
        get => GetArgument<TerraformValue<bool>>("enable_application_logs");
        set => SetArgument("enable_application_logs", value);
    }

}


/// <summary>
/// Block type for control_plane in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane";

    /// <summary>
    /// ApiServerArgs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockApiServerArgsBlock>? ApiServerArgs
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockApiServerArgsBlock>>("api_server_args");
        set => SetArgument("api_server_args", value);
    }

    /// <summary>
    /// ControlPlaneNodePoolConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneNodePoolConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlaneNodePoolConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNodePoolConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlock> ControlPlaneNodePoolConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlock>>("control_plane_node_pool_config");
        set => SetArgument("control_plane_node_pool_config", value);
    }

}

/// <summary>
/// Block type for api_server_args in GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockApiServerArgsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_server_args";

    /// <summary>
    /// The argument name as it appears on the API Server command line please make sure to remove the leading dashes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Argument is required")]
    public required TerraformValue<string> Argument
    {
        get => GetArgument<TerraformValue<string>>("argument");
        set => SetArgument("argument", value);
    }

    /// <summary>
    /// The value of the arg as it will be passed to the API Server command line.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for control_plane_node_pool_config in GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_node_pool_config";

    /// <summary>
    /// NodePoolConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodePoolConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodePoolConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock> NodePoolConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock>>("node_pool_config");
        set => SetArgument("node_pool_config", value);
    }

}

/// <summary>
/// Block type for node_pool_config in GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock : TerraformBlock
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
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Specifies the nodes operating system (default: LINUX).
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => GetArgument<TerraformValue<string>>("operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// NodeConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>? NodeConfigs
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>>("node_configs");
        set => SetArgument("node_configs", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

}

/// <summary>
/// Block type for node_configs in GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock : TerraformBlock
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
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The default IPv4 address for SSH access and Kubernetes node.
    /// Example: 192.168.0.1
    /// </summary>
    public TerraformValue<string>? NodeIp
    {
        get => GetArgument<TerraformValue<string>>("node_ip");
        set => SetArgument("node_ip", value);
    }

}

/// <summary>
/// Block type for taints in GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockTaintsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key associated with the effect.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value associated with the effect.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for load_balancer in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// ManualLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockManualLbConfigBlock>? ManualLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockManualLbConfigBlock>>("manual_lb_config");
        set => SetArgument("manual_lb_config", value);
    }

    /// <summary>
    /// PortConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockPortConfigBlock> PortConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockPortConfigBlock>>("port_config");
        set => SetArgument("port_config", value);
    }

    /// <summary>
    /// VipConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VipConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VipConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VipConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockVipConfigBlock> VipConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockVipConfigBlock>>("vip_config");
        set => SetArgument("vip_config", value);
    }

}

/// <summary>
/// Block type for manual_lb_config in GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockManualLbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_lb_config";

    /// <summary>
    /// Whether manual load balancing is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for port_config in GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockPortConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_config";

    /// <summary>
    /// The port that control plane hosted load balancers will listen on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneLoadBalancerPort is required")]
    public required TerraformValue<double> ControlPlaneLoadBalancerPort
    {
        get => GetArgument<TerraformValue<double>>("control_plane_load_balancer_port");
        set => SetArgument("control_plane_load_balancer_port", value);
    }

}

/// <summary>
/// Block type for vip_config in GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlockVipConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vip_config";

    /// <summary>
    /// The VIP which you previously set aside for the Kubernetes API of this Bare Metal Admin Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneVip is required")]
    public required TerraformValue<string> ControlPlaneVip
    {
        get => GetArgument<TerraformValue<string>>("control_plane_vip");
        set => SetArgument("control_plane_vip", value);
    }

}


/// <summary>
/// Block type for maintenance_config in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_config";

    /// <summary>
    /// All IPv4 address from these ranges will be placed into maintenance mode.
    /// Nodes in maintenance mode will be cordoned and drained. When both of these
    /// are true, the &amp;quot;baremetal.cluster.gke.io/maintenance&amp;quot; annotation will be set
    /// on the node resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceAddressCidrBlocks is required")]
    public TerraformList<string>? MaintenanceAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("maintenance_address_cidr_blocks");
        set => SetArgument("maintenance_address_cidr_blocks", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// IslandModeCidr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IslandModeCidr block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlockIslandModeCidrBlock>? IslandModeCidr
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlockIslandModeCidrBlock>>("island_mode_cidr");
        set => SetArgument("island_mode_cidr", value);
    }

}

/// <summary>
/// Block type for island_mode_cidr in GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlockIslandModeCidrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "island_mode_cidr";

    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    public TerraformList<string>? PodAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("pod_address_cidr_blocks");
        set => SetArgument("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public TerraformList<string>? ServiceAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("service_address_cidr_blocks");
        set => SetArgument("service_address_cidr_blocks", value);
    }

}


/// <summary>
/// Block type for node_access_config in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_access_config";

    /// <summary>
    /// LoginUser is the user name used to access node machines.
    /// It defaults to &amp;quot;root&amp;quot; if not set.
    /// </summary>
    public TerraformValue<string>? LoginUser
    {
        get => GetArgument<TerraformValue<string>>("login_user");
        set => SetArgument("login_user", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// The maximum number of pods a node can run. The size of the CIDR range
    /// assigned to the node will be derived from this parameter.
    /// </summary>
    public TerraformValue<double>? MaxPodsPerNode
    {
        get => GetArgument<TerraformValue<double>>("max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

}


/// <summary>
/// Block type for proxy in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy";

    /// <summary>
    /// A list of IPs, hostnames, and domains that should skip the proxy.
    /// For example: [&amp;quot;127.0.0.1&amp;quot;, &amp;quot;example.com&amp;quot;, &amp;quot;.corp&amp;quot;, &amp;quot;localhost&amp;quot;].
    /// </summary>
    public TerraformList<string>? NoProxy
    {
        get => GetArgument<TerraformList<string>>("no_proxy");
        set => SetArgument("no_proxy", value);
    }

    /// <summary>
    /// Specifies the address of your proxy server.
    /// For Example: http://domain
    /// WARNING: Do not provide credentials in the format
    /// of http://(username:password@)domain these will be rejected by the server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for security_config in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_config";

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

}

/// <summary>
/// Block type for authorization in GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlock : TerraformBlock
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
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlockAdminUsersBlock> AdminUsers
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlockAdminUsersBlock>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}

/// <summary>
/// Block type for admin_users in GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlockAuthorizationBlockAdminUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_users";

    /// <summary>
    /// The name of the user, e.g. &#39;my-gcp-id@gmail.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for storage in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// LvpNodeMountsConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LvpNodeMountsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LvpNodeMountsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LvpNodeMountsConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpNodeMountsConfigBlock> LvpNodeMountsConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpNodeMountsConfigBlock>>("lvp_node_mounts_config");
        set => SetArgument("lvp_node_mounts_config", value);
    }

    /// <summary>
    /// LvpShareConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LvpShareConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LvpShareConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LvpShareConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlock> LvpShareConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlock>>("lvp_share_config");
        set => SetArgument("lvp_share_config", value);
    }

}

/// <summary>
/// Block type for lvp_node_mounts_config in GoogleGkeonpremBareMetalAdminClusterStorageBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpNodeMountsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lvp_node_mounts_config";

    /// <summary>
    /// The host machine path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The StorageClass name that PVs will be created with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}

/// <summary>
/// Block type for lvp_share_config in GoogleGkeonpremBareMetalAdminClusterStorageBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lvp_share_config";

    /// <summary>
    /// The number of subdirectories to create under path.
    /// </summary>
    public TerraformValue<double>? SharedPathPvCount
    {
        get => GetArgument<TerraformValue<double>>("shared_path_pv_count");
        set => SetArgument("shared_path_pv_count", value);
    }

    /// <summary>
    /// LvpConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LvpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LvpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LvpConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlockLvpConfigBlock> LvpConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlockLvpConfigBlock>>("lvp_config");
        set => SetArgument("lvp_config", value);
    }

}

/// <summary>
/// Block type for lvp_config in GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterStorageBlockLvpShareConfigBlockLvpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lvp_config";

    /// <summary>
    /// The host machine path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The StorageClass name that PVs will be created with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeonpremBareMetalAdminCluster.
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock : TerraformBlock
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
/// Represents a google_gkeonprem_bare_metal_admin_cluster Terraform resource.
/// Manages a google_gkeonprem_bare_metal_admin_cluster resource.
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminCluster(string name) : TerraformResource("google_gkeonprem_bare_metal_admin_cluster", name)
{
    /// <summary>
    /// Annotations on the Bare Metal Admin Cluster.
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
    /// A human readable description of this Bare Metal Admin Cluster.
    /// </summary>
    public TerraformValue<string>? BareMetalVersion
    {
        get => GetArgument<TerraformValue<string>>("bare_metal_version");
        set => SetArgument("bare_metal_version", value);
    }

    /// <summary>
    /// A human readable description of this Bare Metal Admin Cluster.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The bare metal admin cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// The IP address name of Bare Metal Admin Cluster&#39;s API server.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Fleet related configuration.
    /// Fleets are a Google Cloud concept for logically organizing clusters,
    /// letting you use and manage multi-cluster capabilities and apply
    /// consistent policies across your systems.
    /// See [Anthos Fleets](https://cloud.google.com/anthos/multicluster-management/fleets) for
    /// more details on Anthos multi-cluster capabilities using Fleets.
    /// </summary>
    public TerraformList<TerraformMap<object>> Fleet
        => AsReference("fleet");

    /// <summary>
    /// The object name of the Bare Metal Admin Cluster custom resource on the
    /// associated admin cluster. This field is used to support conflicting
    /// names when enrolling existing clusters to the API. When used as a part of
    /// cluster enrollment, this field will differ from the ID in the resource
    /// name. For new clusters, this field will match the user provided cluster ID
    /// and be visible in the last component of the resource name. It is not
    /// modifiable.
    /// All users should use this name to access their cluster using gkectl or
    /// kubectl and should expect to see the local name when viewing admin
    /// cluster controller logs.
    /// </summary>
    public TerraformValue<string> LocalName
        => AsReference("local_name");

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal Admin Cluster.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Specifies detailed cluster status.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

    /// <summary>
    /// The unique identifier of the Bare Metal Admin Cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Specifies the security related settings for the Bare Metal Admin Cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationCheck
        => AsReference("validation_check");

    /// <summary>
    /// ClusterOperations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterOperations block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock>? ClusterOperations
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock>>("cluster_operations");
        set => SetArgument("cluster_operations", value);
    }

    /// <summary>
    /// ControlPlane block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock>? ControlPlane
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock>>("control_plane");
        set => SetArgument("control_plane", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// MaintenanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock>? MaintenanceConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock>>("maintenance_config");
        set => SetArgument("maintenance_config", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// NodeAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeAccessConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock>? NodeAccessConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock>>("node_access_config");
        set => SetArgument("node_access_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterProxyBlock>? Proxy
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterProxyBlock>>("proxy");
        set => SetArgument("proxy", value);
    }

    /// <summary>
    /// SecurityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock>? SecurityConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock>>("security_config");
        set => SetArgument("security_config", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalAdminClusterStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
