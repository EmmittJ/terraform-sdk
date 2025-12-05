using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anti_affinity_groups in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<bool>>("aag_config_disabled");
        set => SetArgument("aag_config_disabled", value);
    }

}


/// <summary>
/// Block type for authorization in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// AdminUsers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremVmwareClusterAuthorizationBlockAdminUsersBlock>? AdminUsers
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterAuthorizationBlockAdminUsersBlock>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}

/// <summary>
/// Block type for admin_users in GoogleGkeonpremVmwareClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAuthorizationBlockAdminUsersBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for auto_repair_config in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAutoRepairConfigBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for control_plane_node in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterControlPlaneNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_node";

    /// <summary>
    /// The number of CPUs for each admin cluster node that serve as control planes
    /// for this VMware User Cluster. (default: 4 CPUs)
    /// </summary>
    public TerraformValue<double>? Cpus
    {
        get => GetArgument<TerraformValue<double>>("cpus");
        set => SetArgument("cpus", value);
    }

    /// <summary>
    /// The megabytes of memory for each admin cluster node that serves as a
    /// control plane for this VMware User Cluster (default: 8192 MB memory).
    /// </summary>
    public TerraformValue<double>? Memory
    {
        get => GetArgument<TerraformValue<double>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The number of control plane nodes for this VMware User Cluster.
    /// (default: 1 replica).
    /// </summary>
    public TerraformValue<double>? Replicas
    {
        get => GetArgument<TerraformValue<double>>("replicas");
        set => SetArgument("replicas", value);
    }

    /// <summary>
    /// Vsphere-specific config.
    /// </summary>
    public TerraformList<TerraformMap<object>> VsphereConfig
        => CreateReference("vsphere_config");

    /// <summary>
    /// AutoResizeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoResizeConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterControlPlaneNodeBlockAutoResizeConfigBlock>? AutoResizeConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterControlPlaneNodeBlockAutoResizeConfigBlock>>("auto_resize_config");
        set => SetArgument("auto_resize_config", value);
    }

}

/// <summary>
/// Block type for auto_resize_config in GoogleGkeonpremVmwareClusterControlPlaneNodeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterControlPlaneNodeBlockAutoResizeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_resize_config";

    /// <summary>
    /// Whether to enable control plane node auto resizing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for dataplane_v2 in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterDataplaneV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataplane_v2";

    /// <summary>
    /// Enable advanced networking which requires dataplane_v2_enabled to be set true.
    /// </summary>
    public TerraformValue<bool>? AdvancedNetworking
    {
        get => GetArgument<TerraformValue<bool>>("advanced_networking");
        set => SetArgument("advanced_networking", value);
    }

    /// <summary>
    /// Enables Dataplane V2.
    /// </summary>
    public TerraformValue<bool>? DataplaneV2Enabled
    {
        get => GetArgument<TerraformValue<bool>>("dataplane_v2_enabled");
        set => SetArgument("dataplane_v2_enabled", value);
    }

    /// <summary>
    /// Enable Dataplane V2 for clusters with Windows nodes.
    /// </summary>
    public TerraformValue<bool>? WindowsDataplaneV2Enabled
    {
        get => GetArgument<TerraformValue<bool>>("windows_dataplane_v2_enabled");
        set => SetArgument("windows_dataplane_v2_enabled", value);
    }

}


/// <summary>
/// Block type for load_balancer in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// F5Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 F5Config block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockF5ConfigBlock>? F5Config
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockF5ConfigBlock>>("f5_config");
        set => SetArgument("f5_config", value);
    }

    /// <summary>
    /// ManualLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockManualLbConfigBlock>? ManualLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockManualLbConfigBlock>>("manual_lb_config");
        set => SetArgument("manual_lb_config", value);
    }

    /// <summary>
    /// MetalLbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetalLbConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlock>? MetalLbConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlock>>("metal_lb_config");
        set => SetArgument("metal_lb_config", value);
    }

    /// <summary>
    /// VipConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VipConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockVipConfigBlock>? VipConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockVipConfigBlock>>("vip_config");
        set => SetArgument("vip_config", value);
    }

}

/// <summary>
/// Block type for f5_config in GoogleGkeonpremVmwareClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlockF5ConfigBlock : TerraformBlock
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
    public TerraformValue<string> SnatPool
    {
        get => GetArgument<TerraformValue<string>>("snat_pool") ?? CreateReference("snat_pool");
        set => SetArgument("snat_pool", value);
    }

}

/// <summary>
/// Block type for manual_lb_config in GoogleGkeonpremVmwareClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlockManualLbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_lb_config";

    /// <summary>
    /// NodePort for control plane service. The Kubernetes API server in the admin
    /// cluster is implemented as a Service of type NodePort (ex. 30968).
    /// </summary>
    public TerraformValue<double> ControlPlaneNodePort
    {
        get => GetArgument<TerraformValue<double>>("control_plane_node_port") ?? CreateReference("control_plane_node_port");
        set => SetArgument("control_plane_node_port", value);
    }

    /// <summary>
    /// NodePort for ingress service&#39;s http. The ingress service in the admin
    /// cluster is implemented as a Service of type NodePort (ex. 32527).
    /// </summary>
    public TerraformValue<double> IngressHttpNodePort
    {
        get => GetArgument<TerraformValue<double>>("ingress_http_node_port") ?? CreateReference("ingress_http_node_port");
        set => SetArgument("ingress_http_node_port", value);
    }

    /// <summary>
    /// NodePort for ingress service&#39;s https. The ingress service in the admin
    /// cluster is implemented as a Service of type NodePort (ex. 30139).
    /// </summary>
    public TerraformValue<double> IngressHttpsNodePort
    {
        get => GetArgument<TerraformValue<double>>("ingress_https_node_port") ?? CreateReference("ingress_https_node_port");
        set => SetArgument("ingress_https_node_port", value);
    }

    /// <summary>
    /// NodePort for konnectivity server service running as a sidecar in each
    /// kube-apiserver pod (ex. 30564).
    /// </summary>
    public TerraformValue<double> KonnectivityServerNodePort
    {
        get => GetArgument<TerraformValue<double>>("konnectivity_server_node_port") ?? CreateReference("konnectivity_server_node_port");
        set => SetArgument("konnectivity_server_node_port", value);
    }

}

/// <summary>
/// Block type for metal_lb_config in GoogleGkeonpremVmwareClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlock : TerraformBlock
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
    public required TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlockAddressPoolsBlock> AddressPools
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlockAddressPoolsBlock>>("address_pools");
        set => SetArgument("address_pools", value);
    }

}

/// <summary>
/// Block type for address_pools in GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlockMetalLbConfigBlockAddressPoolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "address_pools";

    /// <summary>
    /// The addresses that are part of this pool. Each address
    /// must be either in the CIDR form (1.2.3.0/24) or range
    /// form (1.2.3.1-1.2.3.5).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Addresses is required")]
    public TerraformList<string>? Addresses
    {
        get => GetArgument<TerraformList<string>>("addresses");
        set => SetArgument("addresses", value);
    }

    /// <summary>
    /// If true, avoid using IPs ending in .0 or .255.
    /// This avoids buggy consumer devices mistakenly dropping IPv4 traffic for
    /// those special IP addresses.
    /// </summary>
    public TerraformValue<bool> AvoidBuggyIps
    {
        get => GetArgument<TerraformValue<bool>>("avoid_buggy_ips") ?? CreateReference("avoid_buggy_ips");
        set => SetArgument("avoid_buggy_ips", value);
    }

    /// <summary>
    /// If true, prevent IP addresses from being automatically assigned.
    /// </summary>
    public TerraformValue<bool> ManualAssign
    {
        get => GetArgument<TerraformValue<bool>>("manual_assign") ?? CreateReference("manual_assign");
        set => SetArgument("manual_assign", value);
    }

    /// <summary>
    /// The name of the address pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    public required TerraformValue<string> Pool
    {
        get => GetRequiredArgument<TerraformValue<string>>("pool");
        set => SetArgument("pool", value);
    }

}

/// <summary>
/// Block type for vip_config in GoogleGkeonpremVmwareClusterLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlockVipConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vip_config";

    /// <summary>
    /// The VIP which you previously set aside for the Kubernetes API of this cluster.
    /// </summary>
    public TerraformValue<string>? ControlPlaneVip
    {
        get => GetArgument<TerraformValue<string>>("control_plane_vip");
        set => SetArgument("control_plane_vip", value);
    }

    /// <summary>
    /// The VIP which you previously set aside for ingress traffic into this cluster.
    /// </summary>
    public TerraformValue<string>? IngressVip
    {
        get => GetArgument<TerraformValue<string>>("ingress_vip");
        set => SetArgument("ingress_vip", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlock : TerraformBlock
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
    /// vcenter_network specifies vCenter network name. Inherited from the admin cluster.
    /// </summary>
    public TerraformValue<string> VcenterNetwork
    {
        get => GetArgument<TerraformValue<string>>("vcenter_network") ?? CreateReference("vcenter_network");
        set => SetArgument("vcenter_network", value);
    }

    /// <summary>
    /// ControlPlaneV2Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneV2Config block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlock>? ControlPlaneV2Config
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlock>>("control_plane_v2_config");
        set => SetArgument("control_plane_v2_config", value);
    }

    /// <summary>
    /// DhcpIpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DhcpIpConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockDhcpIpConfigBlock>? DhcpIpConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockDhcpIpConfigBlock>>("dhcp_ip_config");
        set => SetArgument("dhcp_ip_config", value);
    }

    /// <summary>
    /// HostConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockHostConfigBlock>? HostConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockHostConfigBlock>>("host_config");
        set => SetArgument("host_config", value);
    }

    /// <summary>
    /// StaticIpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticIpConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlock>? StaticIpConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlock>>("static_ip_config");
        set => SetArgument("static_ip_config", value);
    }

}

/// <summary>
/// Block type for control_plane_v2_config in GoogleGkeonpremVmwareClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_v2_config";

    /// <summary>
    /// ControlPlaneIpBlock block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneIpBlock block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlock>? ControlPlaneIpBlock
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlock>>("control_plane_ip_block");
        set => SetArgument("control_plane_ip_block", value);
    }

}

/// <summary>
/// Block type for control_plane_ip_block in GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_ip_block";

    /// <summary>
    /// The network gateway used by the VMware User Cluster.
    /// </summary>
    public TerraformValue<string>? Gateway
    {
        get => GetArgument<TerraformValue<string>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// The netmask used by the VMware User Cluster.
    /// </summary>
    public TerraformValue<string>? Netmask
    {
        get => GetArgument<TerraformValue<string>>("netmask");
        set => SetArgument("netmask", value);
    }

    /// <summary>
    /// Ips block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlockIpsBlock>? Ips
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlockIpsBlock>>("ips");
        set => SetArgument("ips", value);
    }

}

/// <summary>
/// Block type for ips in GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockControlPlaneV2ConfigBlockControlPlaneIpBlockBlockIpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ips";

    /// <summary>
    /// Hostname of the machine. VM&#39;s name will be used if this field is empty.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname") ?? CreateReference("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// IP could be an IP address (like 1.2.3.4) or a CIDR (like 1.2.3.0/24).
    /// </summary>
    public TerraformValue<string>? Ip
    {
        get => GetArgument<TerraformValue<string>>("ip");
        set => SetArgument("ip", value);
    }

}

/// <summary>
/// Block type for dhcp_ip_config in GoogleGkeonpremVmwareClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockDhcpIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dhcp_ip_config";

    /// <summary>
    /// enabled is a flag to mark if DHCP IP allocation is
    /// used for VMware user clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for host_config in GoogleGkeonpremVmwareClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockHostConfigBlock : TerraformBlock
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
/// Block type for static_ip_config in GoogleGkeonpremVmwareClusterNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_ip_config";

    /// <summary>
    /// IpBlocks block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpBlocks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpBlocks block(s) required")]
    public required TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock> IpBlocks
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock>>("ip_blocks");
        set => SetArgument("ip_blocks", value);
    }

}

/// <summary>
/// Block type for ip_blocks in GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_blocks";

    /// <summary>
    /// The network gateway used by the VMware User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    public required TerraformValue<string> Gateway
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// The netmask used by the VMware User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Netmask is required")]
    public required TerraformValue<string> Netmask
    {
        get => GetRequiredArgument<TerraformValue<string>>("netmask");
        set => SetArgument("netmask", value);
    }

    /// <summary>
    /// Ips block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ips is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ips block(s) required")]
    public required TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlockIpsBlock> Ips
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlockIpsBlock>>("ips");
        set => SetArgument("ips", value);
    }

}

/// <summary>
/// Block type for ips in GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlockStaticIpConfigBlockIpBlocksBlockIpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ips";

    /// <summary>
    /// Hostname of the machine. VM&#39;s name will be used if this field is empty.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname") ?? CreateReference("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// IP could be an IP address (like 1.2.3.4) or a CIDR (like 1.2.3.0/24).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ip is required")]
    public required TerraformValue<string> Ip
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip");
        set => SetArgument("ip", value);
    }

}


/// <summary>
/// Block type for storage in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// Whether or not to deploy vSphere CSI components in the VMware User Cluster.
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VsphereCsiDisabled is required")]
    public required TerraformValue<bool> VsphereCsiDisabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("vsphere_csi_disabled");
        set => SetArgument("vsphere_csi_disabled", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeonpremVmwareCluster.
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareClusterTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_policy in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_policy";

    /// <summary>
    /// Controls whether the upgrade applies to the control plane only.
    /// </summary>
    public TerraformValue<bool>? ControlPlaneOnly
    {
        get => GetArgument<TerraformValue<bool>>("control_plane_only");
        set => SetArgument("control_plane_only", value);
    }

}


/// <summary>
/// Block type for vcenter in GoogleGkeonpremVmwareCluster.
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterVcenterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vcenter";

    /// <summary>
    /// The vCenter IP address.
    /// </summary>
    public TerraformValue<string> Address
        => CreateReference("address");

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    public TerraformValue<string> CaCertData
    {
        get => GetArgument<TerraformValue<string>>("ca_cert_data") ?? CreateReference("ca_cert_data");
        set => SetArgument("ca_cert_data", value);
    }

    /// <summary>
    /// The name of the vCenter cluster for the user cluster.
    /// </summary>
    public TerraformValue<string> Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster") ?? CreateReference("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The name of the vCenter datacenter for the user cluster.
    /// </summary>
    public TerraformValue<string> Datacenter
    {
        get => GetArgument<TerraformValue<string>>("datacenter") ?? CreateReference("datacenter");
        set => SetArgument("datacenter", value);
    }

    /// <summary>
    /// The name of the vCenter datastore for the user cluster.
    /// </summary>
    public TerraformValue<string> Datastore
    {
        get => GetArgument<TerraformValue<string>>("datastore") ?? CreateReference("datastore");
        set => SetArgument("datastore", value);
    }

    /// <summary>
    /// The name of the vCenter folder for the user cluster.
    /// </summary>
    public TerraformValue<string> Folder
    {
        get => GetArgument<TerraformValue<string>>("folder") ?? CreateReference("folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The name of the vCenter resource pool for the user cluster.
    /// </summary>
    public TerraformValue<string> ResourcePool
    {
        get => GetArgument<TerraformValue<string>>("resource_pool") ?? CreateReference("resource_pool");
        set => SetArgument("resource_pool", value);
    }

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    public TerraformValue<string> StoragePolicyName
    {
        get => GetArgument<TerraformValue<string>>("storage_policy_name") ?? CreateReference("storage_policy_name");
        set => SetArgument("storage_policy_name", value);
    }

}


/// <summary>
/// Represents a google_gkeonprem_vmware_cluster Terraform resource.
/// Manages a google_gkeonprem_vmware_cluster resource.
/// </summary>
public partial class GoogleGkeonpremVmwareCluster(string name) : TerraformResource("google_gkeonprem_vmware_cluster", name)
{
    /// <summary>
    /// The admin cluster this VMware User Cluster belongs to.
    /// This is the full resource name of the admin cluster&#39;s hub membership.
    /// In the future, references to other resource types might be allowed if
    /// admin clusters are modeled as their own resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminClusterMembership is required")]
    public required TerraformValue<string> AdminClusterMembership
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_cluster_membership");
        set => SetArgument("admin_cluster_membership", value);
    }

    /// <summary>
    /// Annotations on the VMware User Cluster.
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
    /// A human readable description of this VMware User Cluster.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Disable bundled ingress.
    /// </summary>
    public TerraformValue<bool>? DisableBundledIngress
    {
        get => GetArgument<TerraformValue<bool>>("disable_bundled_ingress");
        set => SetArgument("disable_bundled_ingress", value);
    }

    /// <summary>
    /// Enable advanced cluster. Default to false.
    /// </summary>
    public TerraformValue<bool>? EnableAdvancedCluster
    {
        get => GetArgument<TerraformValue<bool>>("enable_advanced_cluster");
        set => SetArgument("enable_advanced_cluster", value);
    }

    /// <summary>
    /// Enable control plane V2. Default to false.
    /// </summary>
    public TerraformValue<bool>? EnableControlPlaneV2
    {
        get => GetArgument<TerraformValue<bool>>("enable_control_plane_v2");
        set => SetArgument("enable_control_plane_v2", value);
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
    /// The VMware cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Anthos clusters on the VMware version for your user cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnPremVersion is required")]
    public required TerraformValue<string> OnPremVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("on_prem_version");
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
    /// Enable VM tracking.
    /// </summary>
    public TerraformValue<bool> VmTrackingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vm_tracking_enabled") ?? CreateReference("vm_tracking_enabled");
        set => SetArgument("vm_tracking_enabled", value);
    }

    /// <summary>
    /// The time at which VMware User Cluster was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The time at which VMware User Cluster was deleted.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => CreateReference("delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// The DNS name of VMware User Cluster&#39;s API server.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

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
    /// Fleet configuration for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> Fleet
        => CreateReference("fleet");

    /// <summary>
    /// The object name of the VMware OnPremUserCluster custom resource on the
    /// associated admin cluster. This field is used to support conflicting
    /// names when enrolling existing clusters to the API. When used as a part of
    /// cluster enrollment, this field will differ from the ID in the resource
    /// name. For new clusters, this field will match the user provided cluster ID
    /// and be visible in the last component of the resource name. It is not
    /// modifiable.
    /// 
    /// All users should use this name to access their cluster using gkectl or
    /// kubectl and should expect to see the local name when viewing admin
    /// cluster controller logs.
    /// </summary>
    public TerraformValue<string> LocalName
        => CreateReference("local_name");

    /// <summary>
    /// If set, there are currently changes in flight to the VMware User Cluster.
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
    /// The unique identifier of the VMware User Cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The time at which VMware User Cluster was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// ValidationCheck represents the result of the preflight check job.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationCheck
        => CreateReference("validation_check");

    /// <summary>
    /// AntiAffinityGroups block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock>? AntiAffinityGroups
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock>>("anti_affinity_groups");
        set => SetArgument("anti_affinity_groups", value);
    }

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// AutoRepairConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterAutoRepairConfigBlock>? AutoRepairConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterAutoRepairConfigBlock>>("auto_repair_config");
        set => SetArgument("auto_repair_config", value);
    }

    /// <summary>
    /// ControlPlaneNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlaneNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    public required TerraformList<GoogleGkeonpremVmwareClusterControlPlaneNodeBlock> ControlPlaneNode
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeonpremVmwareClusterControlPlaneNodeBlock>>("control_plane_node");
        set => SetArgument("control_plane_node", value);
    }

    /// <summary>
    /// DataplaneV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataplaneV2 block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterDataplaneV2Block>? DataplaneV2
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterDataplaneV2Block>>("dataplane_v2");
        set => SetArgument("dataplane_v2", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeonpremVmwareClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeonpremVmwareClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterUpgradePolicyBlock>>("upgrade_policy");
        set => SetArgument("upgrade_policy", value);
    }

    /// <summary>
    /// Vcenter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    public TerraformList<GoogleGkeonpremVmwareClusterVcenterBlock>? Vcenter
    {
        get => GetArgument<TerraformList<GoogleGkeonpremVmwareClusterVcenterBlock>>("vcenter");
        set => SetArgument("vcenter", value);
    }

}
