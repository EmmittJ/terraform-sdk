using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for kubelet_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolKubeletConfigBlock
{
    /// <summary>
    /// The allowed_unsafe_sysctls attribute.
    /// </summary>
    [TerraformPropertyName("allowed_unsafe_sysctls")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    [TerraformPropertyName("container_log_max_line")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerLogMaxLine { get; set; }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    [TerraformPropertyName("container_log_max_size_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerLogMaxSizeMb { get; set; }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cpu_cfs_quota_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CpuCfsQuotaEnabled { get; set; }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    [TerraformPropertyName("cpu_cfs_quota_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    [TerraformPropertyName("cpu_manager_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CpuManagerPolicy { get; set; }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    [TerraformPropertyName("image_gc_high_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ImageGcHighThreshold { get; set; }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    [TerraformPropertyName("image_gc_low_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ImageGcLowThreshold { get; set; }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    [TerraformPropertyName("pod_max_pid")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PodMaxPid { get; set; }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    [TerraformPropertyName("topology_manager_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopologyManagerPolicy { get; set; }

}

/// <summary>
/// Block type for linux_os_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolLinuxOsConfigBlock
{
    /// <summary>
    /// The swap_file_size_mb attribute.
    /// </summary>
    [TerraformPropertyName("swap_file_size_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SwapFileSizeMb { get; set; }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    [TerraformPropertyName("transparent_huge_page")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransparentHugePage { get; set; } = default!;

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    [TerraformPropertyName("transparent_huge_page_defrag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("transparent_huge_page_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransparentHugePageEnabled { get; set; } = default!;

}

/// <summary>
/// Block type for node_network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock
{
    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("application_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? NodePublicIpTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolUpgradeSettingsBlock
{
    /// <summary>
    /// The drain_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("drain_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    [TerraformPropertyName("max_surge")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MaxSurge { get; set; }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("node_soak_duration_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NodeSoakDurationInMinutes { get; set; }

}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolWindowsProfileBlock
{
    /// <summary>
    /// The outbound_nat_enabled attribute.
    /// </summary>
    [TerraformPropertyName("outbound_nat_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OutboundNatEnabled { get; set; }

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
    [TerraformPropertyName("auto_scaling_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoScalingEnabled { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformPropertyName("gpu_driver")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GpuDriver { get; set; }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    [TerraformPropertyName("gpu_instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GpuInstance { get; set; }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("host_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HostEncryptionEnabled { get; set; }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformPropertyName("host_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("kubelet_disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KubeletDiskType { get; set; } = default!;

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformPropertyName("kubernetes_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KubernetesClusterId { get; set; }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformPropertyName("max_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxCount { get; set; }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformPropertyName("max_pods")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxPods { get; set; } = default!;

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformPropertyName("min_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinCount { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NodeCount { get; set; } = default!;

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformPropertyName("node_labels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> NodeLabels { get; set; } = default!;

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NodePublicIpEnabled { get; set; }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_prefix_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodePublicIpPrefixId { get; set; }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformPropertyName("node_taints")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? NodeTaints { get; set; }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformPropertyName("orchestrator_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OrchestratorVersion { get; set; } = default!;

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> OsDiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OsDiskType { get; set; }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformPropertyName("os_sku")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OsSku { get; set; } = default!;

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("pod_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PodSubnetId { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScaleDownMode { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotId { get; set; }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_max_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SpotMaxPrice { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    [TerraformPropertyName("temporary_name_for_rotation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemporaryNameForRotation { get; set; }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UltraSsdEnabled { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformPropertyName("vm_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VmSize { get; set; } = default!;

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("vnet_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VnetSubnetId { get; set; }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    [TerraformPropertyName("workload_runtime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkloadRuntime { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    [TerraformPropertyName("kubelet_config")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolKubeletConfigBlock>>? KubeletConfig { get; set; }

    /// <summary>
    /// Block for linux_os_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    [TerraformPropertyName("linux_os_config")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>>? LinuxOsConfig { get; set; }

    /// <summary>
    /// Block for node_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    [TerraformPropertyName("node_network_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>>? NodeNetworkProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterNodePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformPropertyName("upgrade_settings")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>>? UpgradeSettings { get; set; }

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformPropertyName("windows_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolWindowsProfileBlock>>? WindowsProfile { get; set; }

}
