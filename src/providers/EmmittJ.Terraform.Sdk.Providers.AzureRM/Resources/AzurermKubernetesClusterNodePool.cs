using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for kubelet_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterNodePoolKubeletConfigBlock() : TerraformBlock("kubelet_config")
{
    /// <summary>
    /// The allowed_unsafe_sysctls attribute.
    /// </summary>
    [TerraformProperty("allowed_unsafe_sysctls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    [TerraformProperty("container_log_max_line")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ContainerLogMaxLine { get; set; }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    [TerraformProperty("container_log_max_size_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ContainerLogMaxSizeMb { get; set; }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    [TerraformProperty("cpu_cfs_quota_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CpuCfsQuotaEnabled { get; set; }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    [TerraformProperty("cpu_cfs_quota_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    [TerraformProperty("cpu_manager_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CpuManagerPolicy { get; set; }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    [TerraformProperty("image_gc_high_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ImageGcHighThreshold { get; set; }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    [TerraformProperty("image_gc_low_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ImageGcLowThreshold { get; set; }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    [TerraformProperty("pod_max_pid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PodMaxPid { get; set; }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    [TerraformProperty("topology_manager_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TopologyManagerPolicy { get; set; }

}

/// <summary>
/// Block type for linux_os_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterNodePoolLinuxOsConfigBlock() : TerraformBlock("linux_os_config")
{
    /// <summary>
    /// The swap_file_size_mb attribute.
    /// </summary>
    [TerraformProperty("swap_file_size_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SwapFileSizeMb { get; set; }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    [TerraformProperty("transparent_huge_page")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransparentHugePage { get; set; }

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    [TerraformProperty("transparent_huge_page_defrag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("transparent_huge_page_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransparentHugePageEnabled { get; set; }

}

/// <summary>
/// Block type for node_network_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock() : TerraformBlock("node_network_profile")
{
    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("application_security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? NodePublicIpTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesClusterNodePoolTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterNodePoolUpgradeSettingsBlock() : TerraformBlock("upgrade_settings")
{
    /// <summary>
    /// The drain_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("drain_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    [TerraformProperty("max_surge")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaxSurge { get; set; }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    [TerraformProperty("node_soak_duration_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NodeSoakDurationInMinutes { get; set; }

}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterNodePoolWindowsProfileBlock() : TerraformBlock("windows_profile")
{
    /// <summary>
    /// The outbound_nat_enabled attribute.
    /// </summary>
    [TerraformProperty("outbound_nat_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OutboundNatEnabled { get; set; }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKubernetesClusterNodePool : TerraformResource
{
    public AzurermKubernetesClusterNodePool(string name) : base("azurerm_kubernetes_cluster_node_pool", name)
    {
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoScalingEnabled { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformProperty("eviction_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformProperty("fips_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformProperty("gpu_driver")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GpuDriver { get; set; }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    [TerraformProperty("gpu_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GpuInstance { get; set; }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("host_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HostEncryptionEnabled { get; set; }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformProperty("host_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformProperty("kubelet_disk_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KubeletDiskType { get; set; }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformProperty("kubernetes_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesClusterId { get; set; }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformProperty("max_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxCount { get; set; }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformProperty("max_pods")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxPods { get; set; }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformProperty("min_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinCount { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformProperty("node_labels")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> NodeLabels { get; set; }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NodePublicIpEnabled { get; set; }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_prefix_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodePublicIpPrefixId { get; set; }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformProperty("node_taints")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NodeTaints { get; set; }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformProperty("orchestrator_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrchestratorVersion { get; set; }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("os_disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> OsDiskSizeGb { get; set; }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformProperty("os_disk_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OsDiskType { get; set; }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformProperty("os_sku")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OsSku { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformProperty("pod_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PodSubnetId { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    [TerraformProperty("scale_down_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScaleDownMode { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnapshotId { get; set; }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformProperty("spot_max_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SpotMaxPrice { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    [TerraformProperty("temporary_name_for_rotation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemporaryNameForRotation { get; set; }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformProperty("ultra_ssd_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UltraSsdEnabled { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformProperty("vm_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VmSize { get; set; }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformProperty("vnet_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VnetSubnetId { get; set; }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    [TerraformProperty("workload_runtime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkloadRuntime { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    [TerraformProperty("kubelet_config")]
    public TerraformList<AzurermKubernetesClusterNodePoolKubeletConfigBlock> KubeletConfig { get; set; } = new();

    /// <summary>
    /// Block for linux_os_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    [TerraformProperty("linux_os_config")]
    public TerraformList<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock> LinuxOsConfig { get; set; } = new();

    /// <summary>
    /// Block for node_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    [TerraformProperty("node_network_profile")]
    public TerraformList<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock> NodeNetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKubernetesClusterNodePoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformProperty("upgrade_settings")]
    public TerraformList<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock> UpgradeSettings { get; set; } = new();

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformProperty("windows_profile")]
    public TerraformList<AzurermKubernetesClusterNodePoolWindowsProfileBlock> WindowsProfile { get; set; } = new();

}
