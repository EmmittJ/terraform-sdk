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
        set => SetProperty("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerLogMaxLine
    {
        set => SetProperty("container_log_max_line", value);
    }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerLogMaxSizeMb
    {
        set => SetProperty("container_log_max_size_mb", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CpuCfsQuotaEnabled
    {
        set => SetProperty("cpu_cfs_quota_enabled", value);
    }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    public TerraformProperty<string>? CpuCfsQuotaPeriod
    {
        set => SetProperty("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    public TerraformProperty<string>? CpuManagerPolicy
    {
        set => SetProperty("cpu_manager_policy", value);
    }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? ImageGcHighThreshold
    {
        set => SetProperty("image_gc_high_threshold", value);
    }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? ImageGcLowThreshold
    {
        set => SetProperty("image_gc_low_threshold", value);
    }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    public TerraformProperty<double>? PodMaxPid
    {
        set => SetProperty("pod_max_pid", value);
    }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TopologyManagerPolicy
    {
        set => SetProperty("topology_manager_policy", value);
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
        set => SetProperty("swap_file_size_mb", value);
    }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    public TerraformProperty<string>? TransparentHugePage
    {
        set => SetProperty("transparent_huge_page", value);
    }

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    public TerraformProperty<string>? TransparentHugePageDefrag
    {
        set => SetProperty("transparent_huge_page_defrag", value);
    }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? TransparentHugePageEnabled
    {
        set => SetProperty("transparent_huge_page_enabled", value);
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
        set => SetProperty("application_security_group_ids", value);
    }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NodePublicIpTags
    {
        set => SetProperty("node_public_ip_tags", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("drain_timeout_in_minutes", value);
    }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    public required TerraformProperty<string> MaxSurge
    {
        set => SetProperty("max_surge", value);
    }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? NodeSoakDurationInMinutes
    {
        set => SetProperty("node_soak_duration_in_minutes", value);
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
        set => SetProperty("outbound_nat_enabled", value);
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
        SetOutput("auto_scaling_enabled");
        SetOutput("capacity_reservation_group_id");
        SetOutput("eviction_policy");
        SetOutput("fips_enabled");
        SetOutput("gpu_driver");
        SetOutput("gpu_instance");
        SetOutput("host_encryption_enabled");
        SetOutput("host_group_id");
        SetOutput("id");
        SetOutput("kubelet_disk_type");
        SetOutput("kubernetes_cluster_id");
        SetOutput("max_count");
        SetOutput("max_pods");
        SetOutput("min_count");
        SetOutput("mode");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("node_labels");
        SetOutput("node_public_ip_enabled");
        SetOutput("node_public_ip_prefix_id");
        SetOutput("node_taints");
        SetOutput("orchestrator_version");
        SetOutput("os_disk_size_gb");
        SetOutput("os_disk_type");
        SetOutput("os_sku");
        SetOutput("os_type");
        SetOutput("pod_subnet_id");
        SetOutput("priority");
        SetOutput("proximity_placement_group_id");
        SetOutput("scale_down_mode");
        SetOutput("snapshot_id");
        SetOutput("spot_max_price");
        SetOutput("tags");
        SetOutput("temporary_name_for_rotation");
        SetOutput("ultra_ssd_enabled");
        SetOutput("vm_size");
        SetOutput("vnet_subnet_id");
        SetOutput("workload_runtime");
        SetOutput("zones");
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoScalingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_scaling_enabled");
        set => SetProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string> CapacityReservationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_reservation_group_id");
        set => SetProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string> EvictionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eviction_policy");
        set => SetProperty("eviction_policy", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FipsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fips_enabled");
        set => SetProperty("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformProperty<string> GpuDriver
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gpu_driver");
        set => SetProperty("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformProperty<string> GpuInstance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gpu_instance");
        set => SetProperty("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HostEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("host_encryption_enabled");
        set => SetProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string> HostGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_group_id");
        set => SetProperty("host_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformProperty<string> KubeletDiskType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubelet_disk_type");
        set => SetProperty("kubelet_disk_type", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformProperty<string> KubernetesClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubernetes_cluster_id");
        set => SetProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformProperty<double> MaxCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_count");
        set => SetProperty("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformProperty<double> MaxPods
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_pods");
        set => SetProperty("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformProperty<double> MinCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_count");
        set => SetProperty("min_count", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> NodeLabels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("node_labels");
        set => SetProperty("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> NodePublicIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("node_public_ip_enabled");
        set => SetProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string> NodePublicIpPrefixId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_public_ip_prefix_id");
        set => SetProperty("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    public List<TerraformProperty<string>> NodeTaints
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("node_taints");
        set => SetProperty("node_taints", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformProperty<string> OrchestratorVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("orchestrator_version");
        set => SetProperty("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double> OsDiskSizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("os_disk_size_gb");
        set => SetProperty("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformProperty<string> OsDiskType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_disk_type");
        set => SetProperty("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformProperty<string> OsSku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_sku");
        set => SetProperty("os_sku", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string> OsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_type");
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> PodSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pod_subnet_id");
        set => SetProperty("pod_subnet_id", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string> Priority
    {
        get => GetRequiredOutput<TerraformProperty<string>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string> ProximityPlacementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proximity_placement_group_id");
        set => SetProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformProperty<string> ScaleDownMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scale_down_mode");
        set => SetProperty("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_id");
        set => SetProperty("snapshot_id", value);
    }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    public TerraformProperty<double> SpotMaxPrice
    {
        get => GetRequiredOutput<TerraformProperty<double>>("spot_max_price");
        set => SetProperty("spot_max_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformProperty<string> TemporaryNameForRotation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("temporary_name_for_rotation");
        set => SetProperty("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> UltraSsdEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => SetProperty("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string> VmSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vm_size");
        set => SetProperty("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> VnetSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vnet_subnet_id");
        set => SetProperty("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformProperty<string> WorkloadRuntime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload_runtime");
        set => SetProperty("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolKubeletConfigBlock>? KubeletConfig
    {
        set => SetProperty("kubelet_config", value);
    }

    /// <summary>
    /// Block for linux_os_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>? LinuxOsConfig
    {
        set => SetProperty("linux_os_config", value);
    }

    /// <summary>
    /// Block for node_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>? NodeNetworkProfile
    {
        set => SetProperty("node_network_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterNodePoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>? UpgradeSettings
    {
        set => SetProperty("upgrade_settings", value);
    }

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public List<AzurermKubernetesClusterNodePoolWindowsProfileBlock>? WindowsProfile
    {
        set => SetProperty("windows_profile", value);
    }

}
