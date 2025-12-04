using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addon_node in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAddonNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "addon_node";

    /// <summary>
    /// AutoResizeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoResizeConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterAddonNodeBlockAutoResizeConfigBlock>? AutoResizeConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterAddonNodeBlockAutoResizeConfigBlock>>("auto_resize_config");
        set => SetArgument("auto_resize_config", value);
    }

}

/// <summary>
/// Block type for auto_resize_config in GoogleGkeonpremVmwareAdminClusterAddonNodeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAddonNodeBlockAutoResizeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_resize_config";

    /// <summary>
    /// Whether to enable controle plane node auto resizing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for anti_affinity_groups in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "anti_affinity_groups";

    /// <summary>
    /// Spread nodes across at least three physical hosts (requires at least three
    /// hosts).
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AagConfigDisabled is required")]
    public required TerraformValue<bool> AagConfigDisabled
    {
        get => GetArgument<TerraformValue<bool>>("aag_config_disabled");
        set => SetArgument("aag_config_disabled", value);
    }

}


/// <summary>
/// Block type for authorization in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// ViewerUsers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremVmwareAdminClusterAuthorizationBlockViewerUsersBlock>? ViewerUsers
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterAuthorizationBlockViewerUsersBlock>>("viewer_users");
        set => SetArgument("viewer_users", value);
    }

}

/// <summary>
/// Block type for viewer_users in GoogleGkeonpremVmwareAdminClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAuthorizationBlockViewerUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "viewer_users";

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
/// Block type for auto_repair_config in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_repair_config";

    /// <summary>
    /// Whether auto repair is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for control_plane_node in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_node";

    /// <summary>
    /// The number of vCPUs for the control-plane node of the admin cluster.
    /// </summary>
    public TerraformValue<double>? Cpus
    {
        get => GetArgument<TerraformValue<double>>("cpus");
        set => SetArgument("cpus", value);
    }

    /// <summary>
    /// The number of mebibytes of memory for the control-plane node of the admin cluster.
    /// </summary>
    public TerraformValue<double>? Memory
    {
        get => GetArgument<TerraformValue<double>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The number of control plane nodes for this VMware admin cluster.
    /// </summary>
    public TerraformValue<double>? Replicas
    {
        get => GetArgument<TerraformValue<double>>("replicas");
        set => SetArgument("replicas", value);
    }

}


/// <summary>
/// Block type for load_balancer in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// F5Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 F5Config block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockF5ConfigBlock>? F5Config
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockF5ConfigBlock>>("f5_config");
        set => SetArgument("f5_config", value);
    }

    /// <summary>
    /// ManualLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockManualLbConfigBlock>? ManualLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockManualLbConfigBlock>>("manual_lb_config");
        set => SetArgument("manual_lb_config", value);
    }

    /// <summary>
    /// MetalLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetalLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockMetalLbConfigBlock>? MetalLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockMetalLbConfigBlock>>("metal_lb_config");
        set => SetArgument("metal_lb_config", value);
    }

    /// <summary>
    /// VipConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VipConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VipConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VipConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockVipConfigBlock> VipConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockVipConfigBlock>>("vip_config");
        set => SetArgument("vip_config", value);
    }

}

/// <summary>
/// Block type for f5_config in GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockF5ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "f5_config";

    /// <summary>
    /// The load balancer&#39;s IP address.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// he preexisting partition to be used by the load balancer. T
    /// his partition is usually created for the admin cluster for example:
    /// &#39;my-f5-admin-partition&#39;.
    /// </summary>
    public TerraformValue<string>? Partition
    {
        get => GetArgument<TerraformValue<string>>("partition");
        set => SetArgument("partition", value);
    }

    /// <summary>
    /// The pool name. Only necessary, if using SNAT.
    /// </summary>
    public TerraformValue<string>? SnatPool
    {
        get => GetArgument<TerraformValue<string>>("snat_pool");
        set => SetArgument("snat_pool", value);
    }

}

/// <summary>
/// Block type for manual_lb_config in GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockManualLbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_lb_config";

    /// <summary>
    /// NodePort for add-ons server in the admin cluster.
    /// </summary>
    public TerraformValue<double>? AddonsNodePort
    {
        get => GetArgument<TerraformValue<double>>("addons_node_port");
        set => SetArgument("addons_node_port", value);
    }

    /// <summary>
    /// NodePort for control plane service. The Kubernetes API server in the admin
    /// cluster is implemented as a Service of type NodePort (ex. 30968).
    /// </summary>
    public TerraformValue<double>? ControlPlaneNodePort
    {
        get => GetArgument<TerraformValue<double>>("control_plane_node_port");
        set => SetArgument("control_plane_node_port", value);
    }

    /// <summary>
    /// NodePort for ingress service&#39;s http. The ingress service in the admin
    /// cluster is implemented as a Service of type NodePort (ex. 32527).
    /// </summary>
    public TerraformValue<double>? IngressHttpNodePort
    {
        get => GetArgument<TerraformValue<double>>("ingress_http_node_port");
        set => SetArgument("ingress_http_node_port", value);
    }

    /// <summary>
    /// NodePort for ingress service&#39;s https. The ingress service in the admin
    /// cluster is implemented as a Service of type NodePort (ex. 30139).
    /// </summary>
    public TerraformValue<double>? IngressHttpsNodePort
    {
        get => GetArgument<TerraformValue<double>>("ingress_https_node_port");
        set => SetArgument("ingress_https_node_port", value);
    }

    /// <summary>
    /// NodePort for konnectivity server service running as a sidecar in each
    /// kube-apiserver pod (ex. 30564).
    /// </summary>
    public TerraformValue<double>? KonnectivityServerNodePort
    {
        get => GetArgument<TerraformValue<double>>("konnectivity_server_node_port");
        set => SetArgument("konnectivity_server_node_port", value);
    }

}

/// <summary>
/// Block type for metal_lb_config in GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockMetalLbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metal_lb_config";

    /// <summary>
    /// Metal LB is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for vip_config in GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlockVipConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vip_config";

    /// <summary>
    /// The VIP to configure the load balancer for add-ons.
    /// </summary>
    public TerraformValue<string>? AddonsVip
    {
        get => GetArgument<TerraformValue<string>>("addons_vip");
        set => SetArgument("addons_vip", value);
    }

    /// <summary>
    /// The VIP which you previously set aside for the Kubernetes
    /// API of this VMware Admin Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneVip is required")]
    public required TerraformValue<string> ControlPlaneVip
    {
        get => GetArgument<TerraformValue<string>>("control_plane_vip");
        set => SetArgument("control_plane_vip", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges.
    /// Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    public TerraformList<string>? PodAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("pod_address_cidr_blocks");
        set => SetArgument("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address
    /// from these ranges. Only a single range is supported.. This field
    /// cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public TerraformList<string>? ServiceAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("service_address_cidr_blocks");
        set => SetArgument("service_address_cidr_blocks", value);
    }

    /// <summary>
    /// vcenter_network specifies vCenter network name.
    /// </summary>
    public TerraformValue<string>? VcenterNetwork
    {
        get => GetArgument<TerraformValue<string>>("vcenter_network");
        set => SetArgument("vcenter_network", value);
    }

    /// <summary>
    /// DhcpIpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DhcpIpConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockDhcpIpConfigBlock>? DhcpIpConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockDhcpIpConfigBlock>>("dhcp_ip_config");
        set => SetArgument("dhcp_ip_config", value);
    }

    /// <summary>
    /// HaControlPlaneConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HaControlPlaneConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlock>? HaControlPlaneConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlock>>("ha_control_plane_config");
        set => SetArgument("ha_control_plane_config", value);
    }

    /// <summary>
    /// HostConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHostConfigBlock>? HostConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHostConfigBlock>>("host_config");
        set => SetArgument("host_config", value);
    }

    /// <summary>
    /// StaticIpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticIpConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlock>? StaticIpConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlock>>("static_ip_config");
        set => SetArgument("static_ip_config", value);
    }

}

/// <summary>
/// Block type for dhcp_ip_config in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockDhcpIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dhcp_ip_config";

    /// <summary>
    /// enabled is a flag to mark if DHCP IP allocation is
    /// used for VMware admin clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for ha_control_plane_config in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ha_control_plane_config";

    /// <summary>
    /// ControlPlaneIpBlock block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneIpBlock block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlock>? ControlPlaneIpBlock
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlock>>("control_plane_ip_block");
        set => SetArgument("control_plane_ip_block", value);
    }

}

/// <summary>
/// Block type for control_plane_ip_block in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_ip_block";

    /// <summary>
    /// The network gateway used by the VMware Admin Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    public required TerraformValue<string> Gateway
    {
        get => GetArgument<TerraformValue<string>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// The netmask used by the VMware Admin Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Netmask is required")]
    public required TerraformValue<string> Netmask
    {
        get => GetArgument<TerraformValue<string>>("netmask");
        set => SetArgument("netmask", value);
    }

    /// <summary>
    /// Ips block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ips is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ips block(s) required")]
    public required TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlockIpsBlock> Ips
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlockIpsBlock>>("ips");
        set => SetArgument("ips", value);
    }

}

/// <summary>
/// Block type for ips in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHaControlPlaneConfigBlockControlPlaneIpBlockBlockIpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ips";

    /// <summary>
    /// Hostname of the machine. VM&#39;s name will be used if this field is empty.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// IP could be an IP address (like 1.2.3.4) or a CIDR (like 1.2.3.0/24).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ip is required")]
    public required TerraformValue<string> Ip
    {
        get => GetArgument<TerraformValue<string>>("ip");
        set => SetArgument("ip", value);
    }

}

/// <summary>
/// Block type for host_config in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockHostConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_config";

    /// <summary>
    /// DNS search domains.
    /// </summary>
    public TerraformList<string>? DnsSearchDomains
    {
        get => GetArgument<TerraformList<string>>("dns_search_domains");
        set => SetArgument("dns_search_domains", value);
    }

    /// <summary>
    /// DNS servers.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers");
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// NTP servers.
    /// </summary>
    public TerraformList<string>? NtpServers
    {
        get => GetArgument<TerraformList<string>>("ntp_servers");
        set => SetArgument("ntp_servers", value);
    }

}

/// <summary>
/// Block type for static_ip_config in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_ip_config";

    /// <summary>
    /// IpBlocks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock>? IpBlocks
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock>>("ip_blocks");
        set => SetArgument("ip_blocks", value);
    }

}

/// <summary>
/// Block type for ip_blocks in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_blocks";

    /// <summary>
    /// The network gateway used by the VMware Admin Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    public required TerraformValue<string> Gateway
    {
        get => GetArgument<TerraformValue<string>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// The netmask used by the VMware Admin Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Netmask is required")]
    public required TerraformValue<string> Netmask
    {
        get => GetArgument<TerraformValue<string>>("netmask");
        set => SetArgument("netmask", value);
    }

    /// <summary>
    /// Ips block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ips is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ips block(s) required")]
    public required TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlockIpsBlock> Ips
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlockIpsBlock>>("ips");
        set => SetArgument("ips", value);
    }

}

/// <summary>
/// Block type for ips in GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlockIpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ips";

    /// <summary>
    /// Hostname of the machine. VM&#39;s name will be used if this field is empty.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// IP could be an IP address (like 1.2.3.4) or a CIDR (like 1.2.3.0/24).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ip is required")]
    public required TerraformValue<string> Ip
    {
        get => GetArgument<TerraformValue<string>>("ip");
        set => SetArgument("ip", value);
    }

}


/// <summary>
/// Block type for platform_config in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "platform_config";

    /// <summary>
    /// The list of bundles installed in the admin cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> Bundles
        => AsReference("bundles");

    /// <summary>
    /// The platform version e.g. 1.13.2.
    /// </summary>
    public TerraformValue<string> PlatformVersion
        => AsReference("platform_version");

    /// <summary>
    /// The required platform version e.g. 1.13.1.
    /// If the current platform version is lower than the target version,
    /// the platform version will be updated to the target version.
    /// If the target version is not installed in the platform
    /// (bundle versions), download the target version bundle.
    /// </summary>
    public TerraformValue<string>? RequiredPlatformVersion
    {
        get => GetArgument<TerraformValue<string>>("required_platform_version");
        set => SetArgument("required_platform_version", value);
    }

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

}


/// <summary>
/// Block type for private_registry_config in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_registry_config";

    /// <summary>
    /// The registry address.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The CA certificate public key for private registry.
    /// </summary>
    public TerraformValue<string>? CaCert
    {
        get => GetArgument<TerraformValue<string>>("ca_cert");
        set => SetArgument("ca_cert", value);
    }

}


/// <summary>
/// Block type for proxy in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy";

    /// <summary>
    /// A comma-separated list of IP addresses, IP address ranges,
    /// host names, and domain names that should not go through the proxy server.
    /// </summary>
    public TerraformValue<string>? NoProxy
    {
        get => GetArgument<TerraformValue<string>>("no_proxy");
        set => SetArgument("no_proxy", value);
    }

    /// <summary>
    /// The proxy url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterTimeoutsBlock : TerraformBlock
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
/// Block type for vcenter in GoogleGkeonpremVmwareAdminCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterVcenterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vcenter";

    /// <summary>
    /// The vCenter IP address.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    public TerraformValue<string>? CaCertData
    {
        get => GetArgument<TerraformValue<string>>("ca_cert_data");
        set => SetArgument("ca_cert_data", value);
    }

    /// <summary>
    /// The name of the vCenter cluster for the admin cluster.
    /// </summary>
    public TerraformValue<string>? Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The name of the virtual machine disk (VMDK) for the admin cluster.
    /// </summary>
    public TerraformValue<string>? DataDisk
    {
        get => GetArgument<TerraformValue<string>>("data_disk");
        set => SetArgument("data_disk", value);
    }

    /// <summary>
    /// The name of the vCenter datacenter for the admin cluster.
    /// </summary>
    public TerraformValue<string>? Datacenter
    {
        get => GetArgument<TerraformValue<string>>("datacenter");
        set => SetArgument("datacenter", value);
    }

    /// <summary>
    /// The name of the vCenter datastore for the admin cluster.
    /// </summary>
    public TerraformValue<string>? Datastore
    {
        get => GetArgument<TerraformValue<string>>("datastore");
        set => SetArgument("datastore", value);
    }

    /// <summary>
    /// The name of the vCenter folder for the admin cluster.
    /// </summary>
    public TerraformValue<string>? Folder
    {
        get => GetArgument<TerraformValue<string>>("folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The name of the vCenter resource pool for the admin cluster.
    /// </summary>
    public TerraformValue<string>? ResourcePool
    {
        get => GetArgument<TerraformValue<string>>("resource_pool");
        set => SetArgument("resource_pool", value);
    }

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    public TerraformValue<string>? StoragePolicyName
    {
        get => GetArgument<TerraformValue<string>>("storage_policy_name");
        set => SetArgument("storage_policy_name", value);
    }

}


/// <summary>
/// Represents a google_gkeonprem_vmware_admin_cluster Terraform resource.
/// Manages a google_gkeonprem_vmware_admin_cluster resource.
/// </summary>
public partial class GoogleGkeonpremVmwareAdminCluster(string name) : TerraformResource("google_gkeonprem_vmware_admin_cluster", name)
{
    /// <summary>
    /// Annotations on the VMware Admin Cluster.
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
    /// The bootstrap cluster this VMware admin cluster belongs to.
    /// </summary>
    public TerraformValue<string>? BootstrapClusterMembership
    {
        get => GetArgument<TerraformValue<string>>("bootstrap_cluster_membership");
        set => SetArgument("bootstrap_cluster_membership", value);
    }

    /// <summary>
    /// A human readable description of this VMware admin cluster.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If set, the advanced cluster feature is enabled.
    /// </summary>
    public TerraformValue<bool>? EnableAdvancedCluster
    {
        get => GetArgument<TerraformValue<bool>>("enable_advanced_cluster");
        set => SetArgument("enable_advanced_cluster", value);
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
    /// The OS image type for the VMware admin cluster.
    /// </summary>
    public TerraformValue<string>? ImageType
    {
        get => GetArgument<TerraformValue<string>>("image_type");
        set => SetArgument("image_type", value);
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
    /// The VMware admin cluster resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Anthos clusters on the VMware version for the admin cluster.
    /// </summary>
    public TerraformValue<string>? OnPremVersion
    {
        get => GetArgument<TerraformValue<string>>("on_prem_version");
        set => SetArgument("on_prem_version", value);
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
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// The DNS name of VMware admin cluster&#39;s API server.
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
    /// Fleet configuration for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> Fleet
        => AsReference("fleet");

    /// <summary>
    /// The object name of the VMwareAdminCluster custom resource on the
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
    /// If set, there are currently changes in flight to the VMware admin cluster.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The lifecycle state of the VMware admin cluster.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

    /// <summary>
    /// The unique identifier of the VMware Admin Cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AddonNode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonNode block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterAddonNodeBlock>? AddonNode
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterAddonNodeBlock>>("addon_node");
        set => SetArgument("addon_node", value);
    }

    /// <summary>
    /// AntiAffinityGroups block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock>? AntiAffinityGroups
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock>>("anti_affinity_groups");
        set => SetArgument("anti_affinity_groups", value);
    }

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// AutoRepairConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock>? AutoRepairConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock>>("auto_repair_config");
        set => SetArgument("auto_repair_config", value);
    }

    /// <summary>
    /// ControlPlaneNode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock>? ControlPlaneNode
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock>>("control_plane_node");
        set => SetArgument("control_plane_node", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public required TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock> NetworkConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// PlatformConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlatformConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock>? PlatformConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock>>("platform_config");
        set => SetArgument("platform_config", value);
    }

    /// <summary>
    /// PrivateRegistryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock>? PrivateRegistryConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock>>("private_registry_config");
        set => SetArgument("private_registry_config", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterProxyBlock>? Proxy
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterProxyBlock>>("proxy");
        set => SetArgument("proxy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeonpremVmwareAdminClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeonpremVmwareAdminClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Vcenter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareAdminClusterVcenterBlock>? Vcenter
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareAdminClusterVcenterBlock>>("vcenter");
        set => SetArgument("vcenter", value);
    }

}
