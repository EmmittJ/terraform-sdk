using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_authorization";

    /// <summary>
    /// Mode of operation for binauthz policy evaluation. If unspecified,
    /// defaults to DISABLED. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EvaluationMode
    {
        get => new TerraformReference<string>(this, "evaluation_mode");
        set => SetArgument("evaluation_mode", value);
    }

}


/// <summary>
/// Block type for cluster_operations in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterClusterOperationsBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enable_application_logs");
        set => SetArgument("enable_application_logs", value);
    }

}


/// <summary>
/// Block type for control_plane in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane";

    /// <summary>
    /// ApiServerArgs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockApiServerArgsBlock>? ApiServerArgs
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockApiServerArgsBlock>>("api_server_args");
        set => SetArgument("api_server_args", value);
    }

    /// <summary>
    /// ControlPlaneNodePoolConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneNodePoolConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlaneNodePoolConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNodePoolConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlock> ControlPlaneNodePoolConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlock>>("control_plane_node_pool_config");
        set => SetArgument("control_plane_node_pool_config", value);
    }

}

/// <summary>
/// Block type for api_server_args in GoogleGkeonpremBareMetalClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlockApiServerArgsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "argument");
        set => SetArgument("argument", value);
    }

    /// <summary>
    /// The value of the arg as it will be passed to the API Server command line.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for control_plane_node_pool_config in GoogleGkeonpremBareMetalClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlock : TerraformBlock
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
    public required TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock> NodePoolConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock>>("node_pool_config");
        set => SetArgument("node_pool_config", value);
    }

}

/// <summary>
/// Block type for node_pool_config in GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock : TerraformBlock
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
    public TerraformValue<string>? OperatingSystem
    {
        get => new TerraformReference<string>(this, "operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// NodeConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>? NodeConfigs
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>>("node_configs");
        set => SetArgument("node_configs", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

}

/// <summary>
/// Block type for node_configs in GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock : TerraformBlock
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
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
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
/// Block type for taints in GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlockControlPlaneNodePoolConfigBlockNodePoolConfigBlockTaintsBlock : TerraformBlock
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
/// Block type for load_balancer in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// BgpLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlock>? BgpLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlock>>("bgp_lb_config");
        set => SetArgument("bgp_lb_config", value);
    }

    /// <summary>
    /// ManualLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockManualLbConfigBlock>? ManualLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockManualLbConfigBlock>>("manual_lb_config");
        set => SetArgument("manual_lb_config", value);
    }

    /// <summary>
    /// MetalLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetalLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlock>? MetalLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlock>>("metal_lb_config");
        set => SetArgument("metal_lb_config", value);
    }

    /// <summary>
    /// PortConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockPortConfigBlock> PortConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockPortConfigBlock>>("port_config");
        set => SetArgument("port_config", value);
    }

    /// <summary>
    /// VipConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VipConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VipConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VipConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockVipConfigBlock> VipConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockVipConfigBlock>>("vip_config");
        set => SetArgument("vip_config", value);
    }

}

/// <summary>
/// Block type for bgp_lb_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_lb_config";

    /// <summary>
    /// BGP autonomous system number (ASN) of the cluster.
    /// This field can be updated after cluster creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformValue<double> Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// AddressPools block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPools is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AddressPools block(s) required")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockAddressPoolsBlock> AddressPools
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockAddressPoolsBlock>>("address_pools");
        set => SetArgument("address_pools", value);
    }

    /// <summary>
    /// BgpPeerConfigs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpPeerConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BgpPeerConfigs block(s) required")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockBgpPeerConfigsBlock> BgpPeerConfigs
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockBgpPeerConfigsBlock>>("bgp_peer_configs");
        set => SetArgument("bgp_peer_configs", value);
    }

    /// <summary>
    /// LoadBalancerNodePoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerNodePoolConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlock>? LoadBalancerNodePoolConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlock>>("load_balancer_node_pool_config");
        set => SetArgument("load_balancer_node_pool_config", value);
    }

}

/// <summary>
/// Block type for address_pools in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockAddressPoolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "address_pools";

    /// <summary>
    /// The addresses that are part of this pool. Each address must be either in the CIDR form (1.2.3.0/24) or range form (1.2.3.1-1.2.3.5).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Addresses is required")]
    public TerraformList<string>? Addresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "addresses").ResolveNodes(ctx));
        set => SetArgument("addresses", value);
    }

    /// <summary>
    /// If true, avoid using IPs ending in .0 or .255.
    /// This avoids buggy consumer devices mistakenly dropping IPv4 traffic for those special IP addresses.
    /// </summary>
    public TerraformValue<bool>? AvoidBuggyIps
    {
        get => new TerraformReference<bool>(this, "avoid_buggy_ips");
        set => SetArgument("avoid_buggy_ips", value);
    }

    /// <summary>
    /// If true, prevent IP addresses from being automatically assigned.
    /// </summary>
    public TerraformValue<bool>? ManualAssign
    {
        get => new TerraformReference<bool>(this, "manual_assign");
        set => SetArgument("manual_assign", value);
    }

    /// <summary>
    /// The name of the address pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    public required TerraformValue<string> Pool
    {
        get => new TerraformReference<string>(this, "pool");
        set => SetArgument("pool", value);
    }

}

/// <summary>
/// Block type for bgp_peer_configs in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockBgpPeerConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_peer_configs";

    /// <summary>
    /// BGP autonomous system number (ASN) for the network that contains the
    /// external peer device.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformValue<double> Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The IP address of the control plane node that connects to the external
    /// peer.
    /// If you don&#39;t specify any control plane nodes, all control plane nodes
    /// can connect to the external peer. If you specify one or more IP addresses,
    /// only the nodes specified participate in peering sessions.
    /// </summary>
    public TerraformList<string>? ControlPlaneNodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "control_plane_nodes").ResolveNodes(ctx));
        set => SetArgument("control_plane_nodes", value);
    }

    /// <summary>
    /// The IP address of the external peer device.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

}

/// <summary>
/// Block type for load_balancer_node_pool_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer_node_pool_config";

    /// <summary>
    /// NodePoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock>? NodePoolConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock>>("node_pool_config");
        set => SetArgument("node_pool_config", value);
    }

}

/// <summary>
/// Block type for node_pool_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock : TerraformBlock
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Specifies the nodes operating system (default: LINUX).
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => new TerraformReference<string>(this, "operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// KubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// NodeConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>? NodeConfigs
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>>("node_configs");
        set => SetArgument("node_configs", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

}

/// <summary>
/// Block type for kubelet_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_config";

    /// <summary>
    /// The maximum size of bursty pulls, temporarily allows pulls to burst to this
    /// number, while still not exceeding registry_pull_qps.
    /// The value must not be a negative number.
    /// Updating this field may impact scalability by changing the amount of
    /// traffic produced by image pulls.
    /// Defaults to 10.
    /// </summary>
    public TerraformValue<double>? RegistryBurst
    {
        get => new TerraformReference<double>(this, "registry_burst");
        set => SetArgument("registry_burst", value);
    }

    /// <summary>
    /// The limit of registry pulls per second.
    /// Setting this value to 0 means no limit.
    /// Updating this field may impact scalability by changing the amount of
    /// traffic produced by image pulls.
    /// Defaults to 5.
    /// </summary>
    public TerraformValue<double>? RegistryPullQps
    {
        get => new TerraformReference<double>(this, "registry_pull_qps");
        set => SetArgument("registry_pull_qps", value);
    }

    /// <summary>
    /// Prevents the Kubelet from pulling multiple images at a time.
    /// We recommend *not* changing the default value on nodes that run docker
    /// daemon with version  &amp;lt; 1.9 or an Another Union File System (Aufs) storage
    /// backend. Issue https://github.com/kubernetes/kubernetes/issues/10959 has
    /// more details.
    /// </summary>
    public TerraformValue<bool>? SerializeImagePullsDisabled
    {
        get => new TerraformReference<bool>(this, "serialize_image_pulls_disabled");
        set => SetArgument("serialize_image_pulls_disabled", value);
    }

}

/// <summary>
/// Block type for node_configs in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock : TerraformBlock
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
/// Block type for taints in GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockBgpLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockTaintsBlock : TerraformBlock
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
/// Block type for manual_lb_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockManualLbConfigBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for metal_lb_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metal_lb_config";

    /// <summary>
    /// AddressPools block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPools is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AddressPools block(s) required")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockAddressPoolsBlock> AddressPools
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockAddressPoolsBlock>>("address_pools");
        set => SetArgument("address_pools", value);
    }

    /// <summary>
    /// LoadBalancerNodePoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerNodePoolConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlock>? LoadBalancerNodePoolConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlock>>("load_balancer_node_pool_config");
        set => SetArgument("load_balancer_node_pool_config", value);
    }

}

/// <summary>
/// Block type for address_pools in GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockAddressPoolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "address_pools";

    /// <summary>
    /// The addresses that are part of this pool. Each address must be either in the CIDR form (1.2.3.0/24) or range form (1.2.3.1-1.2.3.5).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Addresses is required")]
    public TerraformList<string>? Addresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "addresses").ResolveNodes(ctx));
        set => SetArgument("addresses", value);
    }

    /// <summary>
    /// If true, avoid using IPs ending in .0 or .255.
    /// This avoids buggy consumer devices mistakenly dropping IPv4 traffic for those special IP addresses.
    /// </summary>
    public TerraformValue<bool>? AvoidBuggyIps
    {
        get => new TerraformReference<bool>(this, "avoid_buggy_ips");
        set => SetArgument("avoid_buggy_ips", value);
    }

    /// <summary>
    /// If true, prevent IP addresses from being automatically assigned.
    /// </summary>
    public TerraformValue<bool>? ManualAssign
    {
        get => new TerraformReference<bool>(this, "manual_assign");
        set => SetArgument("manual_assign", value);
    }

    /// <summary>
    /// The name of the address pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    public required TerraformValue<string> Pool
    {
        get => new TerraformReference<string>(this, "pool");
        set => SetArgument("pool", value);
    }

}

/// <summary>
/// Block type for load_balancer_node_pool_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer_node_pool_config";

    /// <summary>
    /// NodePoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock>? NodePoolConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock>>("node_pool_config");
        set => SetArgument("node_pool_config", value);
    }

}

/// <summary>
/// Block type for node_pool_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock : TerraformBlock
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
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>? NodeConfigs
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock>>("node_configs");
        set => SetArgument("node_configs", value);
    }

    /// <summary>
    /// Taints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>? Taints
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockTaintsBlock>>("taints");
        set => SetArgument("taints", value);
    }

}

/// <summary>
/// Block type for node_configs in GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockNodeConfigsBlock : TerraformBlock
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
/// Block type for taints in GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockMetalLbConfigBlockLoadBalancerNodePoolConfigBlockNodePoolConfigBlockTaintsBlock : TerraformBlock
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
/// Block type for port_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockPortConfigBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "control_plane_load_balancer_port");
        set => SetArgument("control_plane_load_balancer_port", value);
    }

}

/// <summary>
/// Block type for vip_config in GoogleGkeonpremBareMetalClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlockVipConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vip_config";

    /// <summary>
    /// The VIP which you previously set aside for the Kubernetes API of this Bare Metal User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneVip is required")]
    public required TerraformValue<string> ControlPlaneVip
    {
        get => new TerraformReference<string>(this, "control_plane_vip");
        set => SetArgument("control_plane_vip", value);
    }

    /// <summary>
    /// The VIP which you previously set aside for ingress traffic into this Bare Metal User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressVip is required")]
    public required TerraformValue<string> IngressVip
    {
        get => new TerraformReference<string>(this, "ingress_vip");
        set => SetArgument("ingress_vip", value);
    }

}


/// <summary>
/// Block type for maintenance_config in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "maintenance_address_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("maintenance_address_cidr_blocks", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Enables the use of advanced Anthos networking features, such as Bundled
    /// Load Balancing with BGP or the egress NAT gateway.
    /// Setting configuration for advanced networking features will automatically
    /// set this flag.
    /// </summary>
    public TerraformValue<bool>? AdvancedNetworking
    {
        get => new TerraformReference<bool>(this, "advanced_networking");
        set => SetArgument("advanced_networking", value);
    }

    /// <summary>
    /// IslandModeCidr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IslandModeCidr block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlockIslandModeCidrBlock>? IslandModeCidr
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlockIslandModeCidrBlock>>("island_mode_cidr");
        set => SetArgument("island_mode_cidr", value);
    }

    /// <summary>
    /// MultipleNetworkInterfacesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultipleNetworkInterfacesConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlockMultipleNetworkInterfacesConfigBlock>? MultipleNetworkInterfacesConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlockMultipleNetworkInterfacesConfigBlock>>("multiple_network_interfaces_config");
        set => SetArgument("multiple_network_interfaces_config", value);
    }

    /// <summary>
    /// SrIovConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SrIovConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlockSrIovConfigBlock>? SrIovConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlockSrIovConfigBlock>>("sr_iov_config");
        set => SetArgument("sr_iov_config", value);
    }

}

/// <summary>
/// Block type for island_mode_cidr in GoogleGkeonpremBareMetalClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNetworkConfigBlockIslandModeCidrBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "pod_address_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public TerraformList<string>? ServiceAddressCidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_address_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("service_address_cidr_blocks", value);
    }

}

/// <summary>
/// Block type for multiple_network_interfaces_config in GoogleGkeonpremBareMetalClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNetworkConfigBlockMultipleNetworkInterfacesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiple_network_interfaces_config";

    /// <summary>
    /// Whether to enable multiple network interfaces for your pods.
    /// When set network_config.advanced_networking is automatically
    /// set to true.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for sr_iov_config in GoogleGkeonpremBareMetalClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNetworkConfigBlockSrIovConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sr_iov_config";

    /// <summary>
    /// Whether to install the SR-IOV operator.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for node_access_config in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_access_config";

    /// <summary>
    /// LoginUser is the user name used to access node machines.
    /// It defaults to &amp;quot;root&amp;quot; if not set.
    /// </summary>
    public TerraformValue<string> LoginUser
    {
        get => new TerraformReference<string>(this, "login_user");
        set => SetArgument("login_user", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// The available runtimes that can be used to run containers in a Bare Metal User Cluster. Possible values: [&amp;quot;CONTAINER_RUNTIME_UNSPECIFIED&amp;quot;, &amp;quot;DOCKER&amp;quot;, &amp;quot;CONTAINERD&amp;quot;]
    /// </summary>
    public TerraformValue<string> ContainerRuntime
    {
        get => new TerraformReference<string>(this, "container_runtime");
        set => SetArgument("container_runtime", value);
    }

    /// <summary>
    /// The maximum number of pods a node can run. The size of the CIDR range
    /// assigned to the node will be derived from this parameter.
    /// </summary>
    public TerraformValue<double> MaxPodsPerNode
    {
        get => new TerraformReference<double>(this, "max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

}


/// <summary>
/// Block type for os_environment_config in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_environment_config";

    /// <summary>
    /// Whether the package repo should not be included when initializing
    /// bare metal machines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageRepoExcluded is required")]
    public required TerraformValue<bool> PackageRepoExcluded
    {
        get => new TerraformReference<bool>(this, "package_repo_excluded");
        set => SetArgument("package_repo_excluded", value);
    }

}


/// <summary>
/// Block type for proxy in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy";

    /// <summary>
    /// A list of IPs, hostnames, and domains that should skip the proxy.
    /// For example [&amp;quot;127.0.0.1&amp;quot;, &amp;quot;example.com&amp;quot;, &amp;quot;.corp&amp;quot;, &amp;quot;localhost&amp;quot;].
    /// </summary>
    public TerraformList<string>? NoProxy
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "no_proxy").ResolveNodes(ctx));
        set => SetArgument("no_proxy", value);
    }

    /// <summary>
    /// Specifies the address of your proxy server.
    /// For example: http://domain
    /// WARNING: Do not provide credentials in the format
    /// of http://(username:password@)domain these will be rejected by the server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for security_config in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterSecurityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_config";

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

}

/// <summary>
/// Block type for authorization in GoogleGkeonpremBareMetalClusterSecurityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlock : TerraformBlock
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
    public required TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlockAdminUsersBlock> AdminUsers
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlockAdminUsersBlock>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}

/// <summary>
/// Block type for admin_users in GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterSecurityConfigBlockAuthorizationBlockAdminUsersBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for storage in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterStorageBlock : TerraformBlock
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
    public required TerraformList<GoogleGkeonpremBareMetalClusterStorageBlockLvpNodeMountsConfigBlock> LvpNodeMountsConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterStorageBlockLvpNodeMountsConfigBlock>>("lvp_node_mounts_config");
        set => SetArgument("lvp_node_mounts_config", value);
    }

    /// <summary>
    /// LvpShareConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LvpShareConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LvpShareConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LvpShareConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlock> LvpShareConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlock>>("lvp_share_config");
        set => SetArgument("lvp_share_config", value);
    }

}

/// <summary>
/// Block type for lvp_node_mounts_config in GoogleGkeonpremBareMetalClusterStorageBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterStorageBlockLvpNodeMountsConfigBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The StorageClass name that PVs will be created with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
        set => SetArgument("storage_class", value);
    }

}

/// <summary>
/// Block type for lvp_share_config in GoogleGkeonpremBareMetalClusterStorageBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "shared_path_pv_count");
        set => SetArgument("shared_path_pv_count", value);
    }

    /// <summary>
    /// LvpConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LvpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LvpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LvpConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlockLvpConfigBlock> LvpConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlockLvpConfigBlock>>("lvp_config");
        set => SetArgument("lvp_config", value);
    }

}

/// <summary>
/// Block type for lvp_config in GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterStorageBlockLvpShareConfigBlockLvpConfigBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The StorageClass name that PVs will be created with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
        set => SetArgument("storage_class", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremBareMetalClusterTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_policy in GoogleGkeonpremBareMetalCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_policy";

    /// <summary>
    /// Specifies which upgrade policy to use. Possible values: [&amp;quot;SERIAL&amp;quot;, &amp;quot;CONCURRENT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

}


/// <summary>
/// Represents a google_gkeonprem_bare_metal_cluster Terraform resource.
/// Manages a google_gkeonprem_bare_metal_cluster resource.
/// </summary>
public partial class GoogleGkeonpremBareMetalCluster(string name) : TerraformResource("google_gkeonprem_bare_metal_cluster", name)
{
    /// <summary>
    /// The Admin Cluster this Bare Metal User Cluster belongs to.
    /// This is the full resource name of the Admin Cluster&#39;s hub membership.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminClusterMembership is required")]
    public required TerraformValue<string> AdminClusterMembership
    {
        get => new TerraformReference<string>(this, "admin_cluster_membership");
        set => SetArgument("admin_cluster_membership", value);
    }

    /// <summary>
    /// Annotations on the Bare Metal User Cluster.
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
    /// A human readable description of this Bare Metal User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BareMetalVersion is required")]
    public required TerraformValue<string> BareMetalVersion
    {
        get => new TerraformReference<string>(this, "bare_metal_version");
        set => SetArgument("bare_metal_version", value);
    }

    /// <summary>
    /// A human readable description of this Bare Metal User Cluster.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The bare metal cluster name.
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
    /// The IP address name of Bare Metal User Cluster&#39;s API server.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
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
    /// Fleet related configuration.
    /// Fleets are a Google Cloud concept for logically organizing clusters,
    /// letting you use and manage multi-cluster capabilities and apply
    /// consistent policies across your systems.
    /// See [Anthos Fleets](https://cloud.google.com/anthos/multicluster-management/fleets) for
    /// more details on Anthos multi-cluster capabilities using Fleets.
    /// </summary>
    public TerraformList<TerraformMap<object>> Fleet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "fleet").ResolveNodes(ctx));
    }

    /// <summary>
    /// The object name of the Bare Metal Cluster custom resource on the
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
    {
        get => new TerraformReference<string>(this, "local_name");
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
    /// Specifies detailed cluster status.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique identifier of the Bare Metal User Cluster.
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
    /// Specifies the security related settings for the Bare Metal User Cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "validation_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// ClusterOperations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterOperations block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterClusterOperationsBlock>? ClusterOperations
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterClusterOperationsBlock>>("cluster_operations");
        set => SetArgument("cluster_operations", value);
    }

    /// <summary>
    /// ControlPlane block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlane is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlane block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlock> ControlPlane
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlock>>("control_plane");
        set => SetArgument("control_plane", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlock> LoadBalancer
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// MaintenanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock>? MaintenanceConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock>>("maintenance_config");
        set => SetArgument("maintenance_config", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlock> NetworkConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// NodeAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeAccessConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock>? NodeAccessConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock>>("node_access_config");
        set => SetArgument("node_access_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// OsEnvironmentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsEnvironmentConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock>? OsEnvironmentConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock>>("os_environment_config");
        set => SetArgument("os_environment_config", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterProxyBlock>? Proxy
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterProxyBlock>>("proxy");
        set => SetArgument("proxy", value);
    }

    /// <summary>
    /// SecurityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlock>? SecurityConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlock>>("security_config");
        set => SetArgument("security_config", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Storage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Storage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterStorageBlock> Storage
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremBareMetalClusterStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeonpremBareMetalClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeonpremBareMetalClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public TerraformList<GoogleGkeonpremBareMetalClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetArgument<TerraformList<GoogleGkeonpremBareMetalClusterUpgradePolicyBlock>>("upgrade_policy");
        set => SetArgument("upgrade_policy", value);
    }

}
