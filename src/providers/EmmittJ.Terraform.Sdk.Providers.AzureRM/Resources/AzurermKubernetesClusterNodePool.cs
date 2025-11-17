using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for kubelet_config in AzurermKubernetesClusterNodePool.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_config";

    /// <summary>
    /// The allowed_unsafe_sysctls attribute.
    /// </summary>
    public TerraformSet<string>? AllowedUnsafeSysctls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_unsafe_sysctls").ResolveNodes(ctx));
        set => SetArgument("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    public TerraformValue<double>? ContainerLogMaxLine
    {
        get => new TerraformReference<double>(this, "container_log_max_line");
        set => SetArgument("container_log_max_line", value);
    }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    public TerraformValue<double>? ContainerLogMaxSizeMb
    {
        get => new TerraformReference<double>(this, "container_log_max_size_mb");
        set => SetArgument("container_log_max_size_mb", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CpuCfsQuotaEnabled
    {
        get => new TerraformReference<bool>(this, "cpu_cfs_quota_enabled");
        set => SetArgument("cpu_cfs_quota_enabled", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    public TerraformValue<string>? CpuCfsQuotaPeriod
    {
        get => new TerraformReference<string>(this, "cpu_cfs_quota_period");
        set => SetArgument("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    public TerraformValue<string>? CpuManagerPolicy
    {
        get => new TerraformReference<string>(this, "cpu_manager_policy");
        set => SetArgument("cpu_manager_policy", value);
    }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    public TerraformValue<double>? ImageGcHighThreshold
    {
        get => new TerraformReference<double>(this, "image_gc_high_threshold");
        set => SetArgument("image_gc_high_threshold", value);
    }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    public TerraformValue<double>? ImageGcLowThreshold
    {
        get => new TerraformReference<double>(this, "image_gc_low_threshold");
        set => SetArgument("image_gc_low_threshold", value);
    }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    public TerraformValue<double>? PodMaxPid
    {
        get => new TerraformReference<double>(this, "pod_max_pid");
        set => SetArgument("pod_max_pid", value);
    }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    public TerraformValue<string>? TopologyManagerPolicy
    {
        get => new TerraformReference<string>(this, "topology_manager_policy");
        set => SetArgument("topology_manager_policy", value);
    }

}


/// <summary>
/// Block type for linux_os_config in AzurermKubernetesClusterNodePool.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolLinuxOsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_os_config";

    /// <summary>
    /// The swap_file_size_mb attribute.
    /// </summary>
    public TerraformValue<double>? SwapFileSizeMb
    {
        get => new TerraformReference<double>(this, "swap_file_size_mb");
        set => SetArgument("swap_file_size_mb", value);
    }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    public TerraformValue<string> TransparentHugePage
    {
        get => new TerraformReference<string>(this, "transparent_huge_page");
        set => SetArgument("transparent_huge_page", value);
    }

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    public TerraformValue<string>? TransparentHugePageDefrag
    {
        get => new TerraformReference<string>(this, "transparent_huge_page_defrag");
        set => SetArgument("transparent_huge_page_defrag", value);
    }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> TransparentHugePageEnabled
    {
        get => new TerraformReference<string>(this, "transparent_huge_page_enabled");
        set => SetArgument("transparent_huge_page_enabled", value);
    }

    /// <summary>
    /// SysctlConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SysctlConfig block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNodePoolLinuxOsConfigBlockSysctlConfigBlock>? SysctlConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolLinuxOsConfigBlockSysctlConfigBlock>>("sysctl_config");
        set => SetArgument("sysctl_config", value);
    }

}

/// <summary>
/// Block type for sysctl_config in AzurermKubernetesClusterNodePoolLinuxOsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolLinuxOsConfigBlockSysctlConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sysctl_config";

    /// <summary>
    /// The fs_aio_max_nr attribute.
    /// </summary>
    public TerraformValue<double>? FsAioMaxNr
    {
        get => new TerraformReference<double>(this, "fs_aio_max_nr");
        set => SetArgument("fs_aio_max_nr", value);
    }

    /// <summary>
    /// The fs_file_max attribute.
    /// </summary>
    public TerraformValue<double>? FsFileMax
    {
        get => new TerraformReference<double>(this, "fs_file_max");
        set => SetArgument("fs_file_max", value);
    }

    /// <summary>
    /// The fs_inotify_max_user_watches attribute.
    /// </summary>
    public TerraformValue<double>? FsInotifyMaxUserWatches
    {
        get => new TerraformReference<double>(this, "fs_inotify_max_user_watches");
        set => SetArgument("fs_inotify_max_user_watches", value);
    }

    /// <summary>
    /// The fs_nr_open attribute.
    /// </summary>
    public TerraformValue<double>? FsNrOpen
    {
        get => new TerraformReference<double>(this, "fs_nr_open");
        set => SetArgument("fs_nr_open", value);
    }

    /// <summary>
    /// The kernel_threads_max attribute.
    /// </summary>
    public TerraformValue<double>? KernelThreadsMax
    {
        get => new TerraformReference<double>(this, "kernel_threads_max");
        set => SetArgument("kernel_threads_max", value);
    }

    /// <summary>
    /// The net_core_netdev_max_backlog attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreNetdevMaxBacklog
    {
        get => new TerraformReference<double>(this, "net_core_netdev_max_backlog");
        set => SetArgument("net_core_netdev_max_backlog", value);
    }

    /// <summary>
    /// The net_core_optmem_max attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreOptmemMax
    {
        get => new TerraformReference<double>(this, "net_core_optmem_max");
        set => SetArgument("net_core_optmem_max", value);
    }

    /// <summary>
    /// The net_core_rmem_default attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreRmemDefault
    {
        get => new TerraformReference<double>(this, "net_core_rmem_default");
        set => SetArgument("net_core_rmem_default", value);
    }

    /// <summary>
    /// The net_core_rmem_max attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreRmemMax
    {
        get => new TerraformReference<double>(this, "net_core_rmem_max");
        set => SetArgument("net_core_rmem_max", value);
    }

    /// <summary>
    /// The net_core_somaxconn attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreSomaxconn
    {
        get => new TerraformReference<double>(this, "net_core_somaxconn");
        set => SetArgument("net_core_somaxconn", value);
    }

    /// <summary>
    /// The net_core_wmem_default attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreWmemDefault
    {
        get => new TerraformReference<double>(this, "net_core_wmem_default");
        set => SetArgument("net_core_wmem_default", value);
    }

    /// <summary>
    /// The net_core_wmem_max attribute.
    /// </summary>
    public TerraformValue<double>? NetCoreWmemMax
    {
        get => new TerraformReference<double>(this, "net_core_wmem_max");
        set => SetArgument("net_core_wmem_max", value);
    }

    /// <summary>
    /// The net_ipv4_ip_local_port_range_max attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4IpLocalPortRangeMax
    {
        get => new TerraformReference<double>(this, "net_ipv4_ip_local_port_range_max");
        set => SetArgument("net_ipv4_ip_local_port_range_max", value);
    }

    /// <summary>
    /// The net_ipv4_ip_local_port_range_min attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4IpLocalPortRangeMin
    {
        get => new TerraformReference<double>(this, "net_ipv4_ip_local_port_range_min");
        set => SetArgument("net_ipv4_ip_local_port_range_min", value);
    }

    /// <summary>
    /// The net_ipv4_neigh_default_gc_thresh1 attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4NeighDefaultGcThresh1
    {
        get => new TerraformReference<double>(this, "net_ipv4_neigh_default_gc_thresh1");
        set => SetArgument("net_ipv4_neigh_default_gc_thresh1", value);
    }

    /// <summary>
    /// The net_ipv4_neigh_default_gc_thresh2 attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4NeighDefaultGcThresh2
    {
        get => new TerraformReference<double>(this, "net_ipv4_neigh_default_gc_thresh2");
        set => SetArgument("net_ipv4_neigh_default_gc_thresh2", value);
    }

    /// <summary>
    /// The net_ipv4_neigh_default_gc_thresh3 attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4NeighDefaultGcThresh3
    {
        get => new TerraformReference<double>(this, "net_ipv4_neigh_default_gc_thresh3");
        set => SetArgument("net_ipv4_neigh_default_gc_thresh3", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_fin_timeout attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4TcpFinTimeout
    {
        get => new TerraformReference<double>(this, "net_ipv4_tcp_fin_timeout");
        set => SetArgument("net_ipv4_tcp_fin_timeout", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_keepalive_intvl attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4TcpKeepaliveIntvl
    {
        get => new TerraformReference<double>(this, "net_ipv4_tcp_keepalive_intvl");
        set => SetArgument("net_ipv4_tcp_keepalive_intvl", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_keepalive_probes attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4TcpKeepaliveProbes
    {
        get => new TerraformReference<double>(this, "net_ipv4_tcp_keepalive_probes");
        set => SetArgument("net_ipv4_tcp_keepalive_probes", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_keepalive_time attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4TcpKeepaliveTime
    {
        get => new TerraformReference<double>(this, "net_ipv4_tcp_keepalive_time");
        set => SetArgument("net_ipv4_tcp_keepalive_time", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_max_syn_backlog attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4TcpMaxSynBacklog
    {
        get => new TerraformReference<double>(this, "net_ipv4_tcp_max_syn_backlog");
        set => SetArgument("net_ipv4_tcp_max_syn_backlog", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_max_tw_buckets attribute.
    /// </summary>
    public TerraformValue<double>? NetIpv4TcpMaxTwBuckets
    {
        get => new TerraformReference<double>(this, "net_ipv4_tcp_max_tw_buckets");
        set => SetArgument("net_ipv4_tcp_max_tw_buckets", value);
    }

    /// <summary>
    /// The net_ipv4_tcp_tw_reuse attribute.
    /// </summary>
    public TerraformValue<bool>? NetIpv4TcpTwReuse
    {
        get => new TerraformReference<bool>(this, "net_ipv4_tcp_tw_reuse");
        set => SetArgument("net_ipv4_tcp_tw_reuse", value);
    }

    /// <summary>
    /// The net_netfilter_nf_conntrack_buckets attribute.
    /// </summary>
    public TerraformValue<double>? NetNetfilterNfConntrackBuckets
    {
        get => new TerraformReference<double>(this, "net_netfilter_nf_conntrack_buckets");
        set => SetArgument("net_netfilter_nf_conntrack_buckets", value);
    }

    /// <summary>
    /// The net_netfilter_nf_conntrack_max attribute.
    /// </summary>
    public TerraformValue<double>? NetNetfilterNfConntrackMax
    {
        get => new TerraformReference<double>(this, "net_netfilter_nf_conntrack_max");
        set => SetArgument("net_netfilter_nf_conntrack_max", value);
    }

    /// <summary>
    /// The vm_max_map_count attribute.
    /// </summary>
    public TerraformValue<double>? VmMaxMapCount
    {
        get => new TerraformReference<double>(this, "vm_max_map_count");
        set => SetArgument("vm_max_map_count", value);
    }

    /// <summary>
    /// The vm_swappiness attribute.
    /// </summary>
    public TerraformValue<double>? VmSwappiness
    {
        get => new TerraformReference<double>(this, "vm_swappiness");
        set => SetArgument("vm_swappiness", value);
    }

    /// <summary>
    /// The vm_vfs_cache_pressure attribute.
    /// </summary>
    public TerraformValue<double>? VmVfsCachePressure
    {
        get => new TerraformReference<double>(this, "vm_vfs_cache_pressure");
        set => SetArgument("vm_vfs_cache_pressure", value);
    }

}


/// <summary>
/// Block type for node_network_profile in AzurermKubernetesClusterNodePool.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_network_profile";

    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    public TerraformList<string>? ApplicationSecurityGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("application_security_group_ids", value);
    }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    public TerraformMap<string>? NodePublicIpTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "node_public_ip_tags").ResolveNodes(ctx));
        set => SetArgument("node_public_ip_tags", value);
    }

    /// <summary>
    /// AllowedHostPorts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlockAllowedHostPortsBlock>? AllowedHostPorts
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlockAllowedHostPortsBlock>>("allowed_host_ports");
        set => SetArgument("allowed_host_ports", value);
    }

}

/// <summary>
/// Block type for allowed_host_ports in AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolNodeNetworkProfileBlockAllowedHostPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_host_ports";

    /// <summary>
    /// The port_end attribute.
    /// </summary>
    public TerraformValue<double>? PortEnd
    {
        get => new TerraformReference<double>(this, "port_end");
        set => SetArgument("port_end", value);
    }

    /// <summary>
    /// The port_start attribute.
    /// </summary>
    public TerraformValue<double>? PortStart
    {
        get => new TerraformReference<double>(this, "port_start");
        set => SetArgument("port_start", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesClusterNodePool.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Block type for upgrade_settings in AzurermKubernetesClusterNodePool.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolUpgradeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_settings";

    /// <summary>
    /// The drain_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? DrainTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "drain_timeout_in_minutes");
        set => SetArgument("drain_timeout_in_minutes", value);
    }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    public required TerraformValue<string> MaxSurge
    {
        get => new TerraformReference<string>(this, "max_surge");
        set => SetArgument("max_surge", value);
    }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? NodeSoakDurationInMinutes
    {
        get => new TerraformReference<double>(this, "node_soak_duration_in_minutes");
        set => SetArgument("node_soak_duration_in_minutes", value);
    }

}


/// <summary>
/// Block type for windows_profile in AzurermKubernetesClusterNodePool.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolWindowsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_profile";

    /// <summary>
    /// The outbound_nat_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OutboundNatEnabled
    {
        get => new TerraformReference<bool>(this, "outbound_nat_enabled");
        set => SetArgument("outbound_nat_enabled", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_cluster_node_pool Terraform resource.
/// Manages a azurerm_kubernetes_cluster_node_pool resource.
/// </summary>
public partial class AzurermKubernetesClusterNodePool(string name) : TerraformResource("azurerm_kubernetes_cluster_node_pool", name)
{
    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
        set => SetArgument("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformValue<string>? GpuDriver
    {
        get => new TerraformReference<string>(this, "gpu_driver");
        set => SetArgument("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformValue<string>? GpuInstance
    {
        get => new TerraformReference<string>(this, "gpu_instance");
        set => SetArgument("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HostEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "host_encryption_enabled");
        set => SetArgument("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformValue<string>? HostGroupId
    {
        get => new TerraformReference<string>(this, "host_group_id");
        set => SetArgument("host_group_id", value);
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformValue<string> KubeletDiskType
    {
        get => new TerraformReference<string>(this, "kubelet_disk_type");
        set => SetArgument("kubelet_disk_type", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformValue<string> KubernetesClusterId
    {
        get => new TerraformReference<string>(this, "kubernetes_cluster_id");
        set => SetArgument("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxCount
    {
        get => new TerraformReference<double>(this, "max_count");
        set => SetArgument("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformValue<double> MaxPods
    {
        get => new TerraformReference<double>(this, "max_pods");
        set => SetArgument("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformValue<double>? MinCount
    {
        get => new TerraformReference<double>(this, "min_count");
        set => SetArgument("min_count", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public TerraformMap<string> NodeLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "node_labels").ResolveNodes(ctx));
        set => SetArgument("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NodePublicIpEnabled
    {
        get => new TerraformReference<bool>(this, "node_public_ip_enabled");
        set => SetArgument("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string>? NodePublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "node_public_ip_prefix_id");
        set => SetArgument("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public TerraformList<string>? NodeTaints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "node_taints").ResolveNodes(ctx));
        set => SetArgument("node_taints", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformValue<string> OrchestratorVersion
    {
        get => new TerraformReference<string>(this, "orchestrator_version");
        set => SetArgument("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> OsDiskSizeGb
    {
        get => new TerraformReference<double>(this, "os_disk_size_gb");
        set => SetArgument("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskType
    {
        get => new TerraformReference<string>(this, "os_disk_type");
        set => SetArgument("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformValue<string> OsSku
    {
        get => new TerraformReference<string>(this, "os_sku");
        set => SetArgument("os_sku", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string>? OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? PodSubnetId
    {
        get => new TerraformReference<string>(this, "pod_subnet_id");
        set => SetArgument("pod_subnet_id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformValue<string>? ScaleDownMode
    {
        get => new TerraformReference<string>(this, "scale_down_mode");
        set => SetArgument("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformValue<double>? SpotMaxPrice
    {
        get => new TerraformReference<double>(this, "spot_max_price");
        set => SetArgument("spot_max_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformValue<string>? TemporaryNameForRotation
    {
        get => new TerraformReference<string>(this, "temporary_name_for_rotation");
        set => SetArgument("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? VnetSubnetId
    {
        get => new TerraformReference<string>(this, "vnet_subnet_id");
        set => SetArgument("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformValue<string>? WorkloadRuntime
    {
        get => new TerraformReference<string>(this, "workload_runtime");
        set => SetArgument("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// KubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNodePoolKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// LinuxOsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>? LinuxOsConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>>("linux_os_config");
        set => SetArgument("linux_os_config", value);
    }

    /// <summary>
    /// NodeNetworkProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>? NodeNetworkProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>>("node_network_profile");
        set => SetArgument("node_network_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>>("upgrade_settings");
        set => SetArgument("upgrade_settings", value);
    }

    /// <summary>
    /// WindowsProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNodePoolWindowsProfileBlock>? WindowsProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNodePoolWindowsProfileBlock>>("windows_profile");
        set => SetArgument("windows_profile", value);
    }

}
