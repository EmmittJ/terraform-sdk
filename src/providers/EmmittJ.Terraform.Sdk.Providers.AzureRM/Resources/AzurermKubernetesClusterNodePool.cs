using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for kubelet_config in .
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
    [TerraformArgument("allowed_unsafe_sysctls")]
    public TerraformSet<string>? AllowedUnsafeSysctls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_unsafe_sysctls").ResolveNodes(ctx));
        set => SetArgument("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    [TerraformArgument("container_log_max_line")]
    public TerraformValue<double>? ContainerLogMaxLine
    {
        get => new TerraformReference<double>(this, "container_log_max_line");
        set => SetArgument("container_log_max_line", value);
    }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    [TerraformArgument("container_log_max_size_mb")]
    public TerraformValue<double>? ContainerLogMaxSizeMb
    {
        get => new TerraformReference<double>(this, "container_log_max_size_mb");
        set => SetArgument("container_log_max_size_mb", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    [TerraformArgument("cpu_cfs_quota_enabled")]
    public TerraformValue<bool>? CpuCfsQuotaEnabled
    {
        get => new TerraformReference<bool>(this, "cpu_cfs_quota_enabled");
        set => SetArgument("cpu_cfs_quota_enabled", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    [TerraformArgument("cpu_cfs_quota_period")]
    public TerraformValue<string>? CpuCfsQuotaPeriod
    {
        get => new TerraformReference<string>(this, "cpu_cfs_quota_period");
        set => SetArgument("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    [TerraformArgument("cpu_manager_policy")]
    public TerraformValue<string>? CpuManagerPolicy
    {
        get => new TerraformReference<string>(this, "cpu_manager_policy");
        set => SetArgument("cpu_manager_policy", value);
    }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    [TerraformArgument("image_gc_high_threshold")]
    public TerraformValue<double>? ImageGcHighThreshold
    {
        get => new TerraformReference<double>(this, "image_gc_high_threshold");
        set => SetArgument("image_gc_high_threshold", value);
    }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    [TerraformArgument("image_gc_low_threshold")]
    public TerraformValue<double>? ImageGcLowThreshold
    {
        get => new TerraformReference<double>(this, "image_gc_low_threshold");
        set => SetArgument("image_gc_low_threshold", value);
    }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    [TerraformArgument("pod_max_pid")]
    public TerraformValue<double>? PodMaxPid
    {
        get => new TerraformReference<double>(this, "pod_max_pid");
        set => SetArgument("pod_max_pid", value);
    }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    [TerraformArgument("topology_manager_policy")]
    public TerraformValue<string>? TopologyManagerPolicy
    {
        get => new TerraformReference<string>(this, "topology_manager_policy");
        set => SetArgument("topology_manager_policy", value);
    }

}

/// <summary>
/// Block type for linux_os_config in .
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
    [TerraformArgument("swap_file_size_mb")]
    public TerraformValue<double>? SwapFileSizeMb
    {
        get => new TerraformReference<double>(this, "swap_file_size_mb");
        set => SetArgument("swap_file_size_mb", value);
    }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    [TerraformArgument("transparent_huge_page")]
    public TerraformValue<string> TransparentHugePage
    {
        get => new TerraformReference<string>(this, "transparent_huge_page");
        set => SetArgument("transparent_huge_page", value);
    }

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    [TerraformArgument("transparent_huge_page_defrag")]
    public TerraformValue<string>? TransparentHugePageDefrag
    {
        get => new TerraformReference<string>(this, "transparent_huge_page_defrag");
        set => SetArgument("transparent_huge_page_defrag", value);
    }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("transparent_huge_page_enabled")]
    public TerraformValue<string> TransparentHugePageEnabled
    {
        get => new TerraformReference<string>(this, "transparent_huge_page_enabled");
        set => SetArgument("transparent_huge_page_enabled", value);
    }

}

/// <summary>
/// Block type for node_network_profile in .
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
    [TerraformArgument("application_security_group_ids")]
    public TerraformList<string>? ApplicationSecurityGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("application_security_group_ids", value);
    }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    [TerraformArgument("node_public_ip_tags")]
    public TerraformMap<string>? NodePublicIpTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "node_public_ip_tags").ResolveNodes(ctx));
        set => SetArgument("node_public_ip_tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for upgrade_settings in .
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
    [TerraformArgument("drain_timeout_in_minutes")]
    public TerraformValue<double>? DrainTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "drain_timeout_in_minutes");
        set => SetArgument("drain_timeout_in_minutes", value);
    }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    [TerraformArgument("max_surge")]
    public required TerraformValue<string> MaxSurge
    {
        get => new TerraformReference<string>(this, "max_surge");
        set => SetArgument("max_surge", value);
    }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("node_soak_duration_in_minutes")]
    public TerraformValue<double>? NodeSoakDurationInMinutes
    {
        get => new TerraformReference<double>(this, "node_soak_duration_in_minutes");
        set => SetArgument("node_soak_duration_in_minutes", value);
    }

}

/// <summary>
/// Block type for windows_profile in .
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
    [TerraformArgument("outbound_nat_enabled")]
    public TerraformValue<bool>? OutboundNatEnabled
    {
        get => new TerraformReference<bool>(this, "outbound_nat_enabled");
        set => SetArgument("outbound_nat_enabled", value);
    }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesClusterNodePool : TerraformResource
{
    public AzurermKubernetesClusterNodePool(string name) : base("azurerm_kubernetes_cluster_node_pool", name)
    {
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_scaling_enabled")]
    public TerraformValue<bool>? AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
        set => SetArgument("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformArgument("capacity_reservation_group_id")]
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformArgument("eviction_policy")]
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformArgument("fips_enabled")]
    public TerraformValue<bool>? FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformArgument("gpu_driver")]
    public TerraformValue<string>? GpuDriver
    {
        get => new TerraformReference<string>(this, "gpu_driver");
        set => SetArgument("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    [TerraformArgument("gpu_instance")]
    public TerraformValue<string>? GpuInstance
    {
        get => new TerraformReference<string>(this, "gpu_instance");
        set => SetArgument("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("host_encryption_enabled")]
    public TerraformValue<bool>? HostEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "host_encryption_enabled");
        set => SetArgument("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformArgument("host_group_id")]
    public TerraformValue<string>? HostGroupId
    {
        get => new TerraformReference<string>(this, "host_group_id");
        set => SetArgument("host_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformArgument("kubelet_disk_type")]
    public TerraformValue<string> KubeletDiskType
    {
        get => new TerraformReference<string>(this, "kubelet_disk_type");
        set => SetArgument("kubelet_disk_type", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformArgument("kubernetes_cluster_id")]
    public required TerraformValue<string> KubernetesClusterId
    {
        get => new TerraformReference<string>(this, "kubernetes_cluster_id");
        set => SetArgument("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformArgument("max_count")]
    public TerraformValue<double>? MaxCount
    {
        get => new TerraformReference<double>(this, "max_count");
        set => SetArgument("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformArgument("max_pods")]
    public TerraformValue<double> MaxPods
    {
        get => new TerraformReference<double>(this, "max_pods");
        set => SetArgument("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformArgument("min_count")]
    public TerraformValue<double>? MinCount
    {
        get => new TerraformReference<double>(this, "min_count");
        set => SetArgument("min_count", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformArgument("node_count")]
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformArgument("node_labels")]
    public TerraformMap<string> NodeLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "node_labels").ResolveNodes(ctx));
        set => SetArgument("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformArgument("node_public_ip_enabled")]
    public TerraformValue<bool>? NodePublicIpEnabled
    {
        get => new TerraformReference<bool>(this, "node_public_ip_enabled");
        set => SetArgument("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformArgument("node_public_ip_prefix_id")]
    public TerraformValue<string>? NodePublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "node_public_ip_prefix_id");
        set => SetArgument("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformArgument("node_taints")]
    public TerraformList<string>? NodeTaints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "node_taints").ResolveNodes(ctx));
        set => SetArgument("node_taints", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformArgument("orchestrator_version")]
    public TerraformValue<string> OrchestratorVersion
    {
        get => new TerraformReference<string>(this, "orchestrator_version");
        set => SetArgument("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("os_disk_size_gb")]
    public TerraformValue<double> OsDiskSizeGb
    {
        get => new TerraformReference<double>(this, "os_disk_size_gb");
        set => SetArgument("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformArgument("os_disk_type")]
    public TerraformValue<string>? OsDiskType
    {
        get => new TerraformReference<string>(this, "os_disk_type");
        set => SetArgument("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformArgument("os_sku")]
    public TerraformValue<string> OsSku
    {
        get => new TerraformReference<string>(this, "os_sku");
        set => SetArgument("os_sku", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string>? OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformArgument("pod_subnet_id")]
    public TerraformValue<string>? PodSubnetId
    {
        get => new TerraformReference<string>(this, "pod_subnet_id");
        set => SetArgument("pod_subnet_id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformArgument("proximity_placement_group_id")]
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    [TerraformArgument("scale_down_mode")]
    public TerraformValue<string>? ScaleDownMode
    {
        get => new TerraformReference<string>(this, "scale_down_mode");
        set => SetArgument("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformArgument("snapshot_id")]
    public TerraformValue<string>? SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformArgument("spot_max_price")]
    public TerraformValue<double>? SpotMaxPrice
    {
        get => new TerraformReference<double>(this, "spot_max_price");
        set => SetArgument("spot_max_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    [TerraformArgument("temporary_name_for_rotation")]
    public TerraformValue<string>? TemporaryNameForRotation
    {
        get => new TerraformReference<string>(this, "temporary_name_for_rotation");
        set => SetArgument("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformArgument("ultra_ssd_enabled")]
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformArgument("vm_size")]
    public TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformArgument("vnet_subnet_id")]
    public TerraformValue<string>? VnetSubnetId
    {
        get => new TerraformReference<string>(this, "vnet_subnet_id");
        set => SetArgument("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    [TerraformArgument("workload_runtime")]
    public TerraformValue<string>? WorkloadRuntime
    {
        get => new TerraformReference<string>(this, "workload_runtime");
        set => SetArgument("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    [TerraformArgument("kubelet_config")]
    public TerraformList<AzurermKubernetesClusterNodePoolKubeletConfigBlock> KubeletConfig { get; set; } = new();

    /// <summary>
    /// Block for linux_os_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    [TerraformArgument("linux_os_config")]
    public TerraformList<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock> LinuxOsConfig { get; set; } = new();

    /// <summary>
    /// Block for node_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    [TerraformArgument("node_network_profile")]
    public TerraformList<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock> NodeNetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesClusterNodePoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformArgument("upgrade_settings")]
    public TerraformList<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock> UpgradeSettings { get; set; } = new();

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformArgument("windows_profile")]
    public TerraformList<AzurermKubernetesClusterNodePoolWindowsProfileBlock> WindowsProfile { get; set; } = new();

}
