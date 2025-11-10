using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for kubelet_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_unsafe_sysctls attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedUnsafeSysctls
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_unsafe_sysctls");
        set => WithProperty("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerLogMaxLine
    {
        get => GetProperty<TerraformProperty<double>>("container_log_max_line");
        set => WithProperty("container_log_max_line", value);
    }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerLogMaxSizeMb
    {
        get => GetProperty<TerraformProperty<double>>("container_log_max_size_mb");
        set => WithProperty("container_log_max_size_mb", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CpuCfsQuotaEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cpu_cfs_quota_enabled");
        set => WithProperty("cpu_cfs_quota_enabled", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    public TerraformProperty<string>? CpuCfsQuotaPeriod
    {
        get => GetProperty<TerraformProperty<string>>("cpu_cfs_quota_period");
        set => WithProperty("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    public TerraformProperty<string>? CpuManagerPolicy
    {
        get => GetProperty<TerraformProperty<string>>("cpu_manager_policy");
        set => WithProperty("cpu_manager_policy", value);
    }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? ImageGcHighThreshold
    {
        get => GetProperty<TerraformProperty<double>>("image_gc_high_threshold");
        set => WithProperty("image_gc_high_threshold", value);
    }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? ImageGcLowThreshold
    {
        get => GetProperty<TerraformProperty<double>>("image_gc_low_threshold");
        set => WithProperty("image_gc_low_threshold", value);
    }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    public TerraformProperty<double>? PodMaxPid
    {
        get => GetProperty<TerraformProperty<double>>("pod_max_pid");
        set => WithProperty("pod_max_pid", value);
    }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TopologyManagerPolicy
    {
        get => GetProperty<TerraformProperty<string>>("topology_manager_policy");
        set => WithProperty("topology_manager_policy", value);
    }

}

/// <summary>
/// Block type for linux_os_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolLinuxOsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The swap_file_size_mb attribute.
    /// </summary>
    public TerraformProperty<double>? SwapFileSizeMb
    {
        get => GetProperty<TerraformProperty<double>>("swap_file_size_mb");
        set => WithProperty("swap_file_size_mb", value);
    }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    public TerraformProperty<string>? TransparentHugePage
    {
        get => GetProperty<TerraformProperty<string>>("transparent_huge_page");
        set => WithProperty("transparent_huge_page", value);
    }

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    public TerraformProperty<string>? TransparentHugePageDefrag
    {
        get => GetProperty<TerraformProperty<string>>("transparent_huge_page_defrag");
        set => WithProperty("transparent_huge_page_defrag", value);
    }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? TransparentHugePageEnabled
    {
        get => GetProperty<TerraformProperty<string>>("transparent_huge_page_enabled");
        set => WithProperty("transparent_huge_page_enabled", value);
    }

}

/// <summary>
/// Block type for node_network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ApplicationSecurityGroupIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("application_security_group_ids");
        set => WithProperty("application_security_group_ids", value);
    }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NodePublicIpTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("node_public_ip_tags");
        set => WithProperty("node_public_ip_tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolUpgradeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The drain_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? DrainTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("drain_timeout_in_minutes");
        set => WithProperty("drain_timeout_in_minutes", value);
    }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    public required TerraformProperty<string> MaxSurge
    {
        get => GetRequiredProperty<TerraformProperty<string>>("max_surge");
        set => WithProperty("max_surge", value);
    }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? NodeSoakDurationInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("node_soak_duration_in_minutes");
        set => WithProperty("node_soak_duration_in_minutes", value);
    }

}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolWindowsProfileBlock : TerraformBlock
{
    /// <summary>
    /// The outbound_nat_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OutboundNatEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("outbound_nat_enabled");
        set => WithProperty("outbound_nat_enabled", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_scaling_enabled");
        set => this.WithProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformProperty<string>? GpuDriver
    {
        get => GetProperty<TerraformProperty<string>>("gpu_driver");
        set => this.WithProperty("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformProperty<string>? GpuInstance
    {
        get => GetProperty<TerraformProperty<string>>("gpu_instance");
        set => this.WithProperty("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HostEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("host_encryption_enabled");
        set => this.WithProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("host_group_id");
        set => this.WithProperty("host_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? KubeletDiskType
    {
        get => GetProperty<TerraformProperty<string>>("kubelet_disk_type");
        set => this.WithProperty("kubelet_disk_type", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformProperty<string> KubernetesClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCount
    {
        get => GetProperty<TerraformProperty<double>>("max_count");
        set => this.WithProperty("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformProperty<double>? MaxPods
    {
        get => GetProperty<TerraformProperty<double>>("max_pods");
        set => this.WithProperty("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinCount
    {
        get => GetProperty<TerraformProperty<double>>("min_count");
        set => this.WithProperty("min_count", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NodeLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("node_labels");
        set => this.WithProperty("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("node_public_ip_enabled");
        set => this.WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string>? NodePublicIpPrefixId
    {
        get => GetProperty<TerraformProperty<string>>("node_public_ip_prefix_id");
        set => this.WithProperty("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NodeTaints
    {
        get => GetProperty<List<TerraformProperty<string>>>("node_taints");
        set => this.WithProperty("node_taints", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformProperty<string>? OrchestratorVersion
    {
        get => GetProperty<TerraformProperty<string>>("orchestrator_version");
        set => this.WithProperty("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? OsDiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("os_disk_size_gb");
        set => this.WithProperty("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskType
    {
        get => GetProperty<TerraformProperty<string>>("os_disk_type");
        set => this.WithProperty("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformProperty<string>? OsSku
    {
        get => GetProperty<TerraformProperty<string>>("os_sku");
        set => this.WithProperty("os_sku", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? PodSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("pod_subnet_id");
        set => this.WithProperty("pod_subnet_id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownMode
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_mode");
        set => this.WithProperty("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformProperty<double>? SpotMaxPrice
    {
        get => GetProperty<TerraformProperty<double>>("spot_max_price");
        set => this.WithProperty("spot_max_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformProperty<string>? TemporaryNameForRotation
    {
        get => GetProperty<TerraformProperty<string>>("temporary_name_for_rotation");
        set => this.WithProperty("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => this.WithProperty("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VnetSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("vnet_subnet_id");
        set => this.WithProperty("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadRuntime
    {
        get => GetProperty<TerraformProperty<string>>("workload_runtime");
        set => this.WithProperty("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolKubeletConfigBlock>? KubeletConfig
    {
        get => GetProperty<List<AzurermKubernetesClusterNodePoolKubeletConfigBlock>>("kubelet_config");
        set => this.WithProperty("kubelet_config", value);
    }

    /// <summary>
    /// Block for linux_os_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>? LinuxOsConfig
    {
        get => GetProperty<List<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>>("linux_os_config");
        set => this.WithProperty("linux_os_config", value);
    }

    /// <summary>
    /// Block for node_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>? NodeNetworkProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>>("node_network_profile");
        set => this.WithProperty("node_network_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterNodePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKubernetesClusterNodePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetProperty<List<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>>("upgrade_settings");
        set => this.WithProperty("upgrade_settings", value);
    }

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolWindowsProfileBlock>? WindowsProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterNodePoolWindowsProfileBlock>>("windows_profile");
        set => this.WithProperty("windows_profile", value);
    }

}
