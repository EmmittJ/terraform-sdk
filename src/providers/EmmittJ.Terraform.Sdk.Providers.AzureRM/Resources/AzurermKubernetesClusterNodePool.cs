using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for kubelet_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolKubeletConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_unsafe_sysctls attribute.
    /// </summary>
    [TerraformPropertyName("allowed_unsafe_sysctls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedUnsafeSysctls { get; set; }

    /// <summary>
    /// The container_log_max_line attribute.
    /// </summary>
    [TerraformPropertyName("container_log_max_line")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ContainerLogMaxLine { get; set; }

    /// <summary>
    /// The container_log_max_size_mb attribute.
    /// </summary>
    [TerraformPropertyName("container_log_max_size_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ContainerLogMaxSizeMb { get; set; }

    /// <summary>
    /// The cpu_cfs_quota_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cpu_cfs_quota_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CpuCfsQuotaEnabled { get; set; }

    /// <summary>
    /// The cpu_cfs_quota_period attribute.
    /// </summary>
    [TerraformPropertyName("cpu_cfs_quota_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// The cpu_manager_policy attribute.
    /// </summary>
    [TerraformPropertyName("cpu_manager_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CpuManagerPolicy { get; set; }

    /// <summary>
    /// The image_gc_high_threshold attribute.
    /// </summary>
    [TerraformPropertyName("image_gc_high_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ImageGcHighThreshold { get; set; }

    /// <summary>
    /// The image_gc_low_threshold attribute.
    /// </summary>
    [TerraformPropertyName("image_gc_low_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ImageGcLowThreshold { get; set; }

    /// <summary>
    /// The pod_max_pid attribute.
    /// </summary>
    [TerraformPropertyName("pod_max_pid")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PodMaxPid { get; set; }

    /// <summary>
    /// The topology_manager_policy attribute.
    /// </summary>
    [TerraformPropertyName("topology_manager_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TopologyManagerPolicy { get; set; }

}

/// <summary>
/// Block type for linux_os_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolLinuxOsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The swap_file_size_mb attribute.
    /// </summary>
    [TerraformPropertyName("swap_file_size_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SwapFileSizeMb { get; set; }

    /// <summary>
    /// The transparent_huge_page attribute.
    /// </summary>
    [TerraformPropertyName("transparent_huge_page")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransparentHugePage { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "transparent_huge_page");

    /// <summary>
    /// The transparent_huge_page_defrag attribute.
    /// </summary>
    [TerraformPropertyName("transparent_huge_page_defrag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// The transparent_huge_page_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("transparent_huge_page_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransparentHugePageEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "transparent_huge_page_enabled");

}

/// <summary>
/// Block type for node_network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("application_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The node_public_ip_tags attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? NodePublicIpTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterNodePoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolUpgradeSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The drain_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("drain_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// The max_surge attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSurge is required")]
    [TerraformPropertyName("max_surge")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MaxSurge { get; set; }

    /// <summary>
    /// The node_soak_duration_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("node_soak_duration_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NodeSoakDurationInMinutes { get; set; }

}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNodePoolWindowsProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The outbound_nat_enabled attribute.
    /// </summary>
    [TerraformPropertyName("outbound_nat_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OutboundNatEnabled { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AutoScalingEnabled { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvictionPolicy { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FipsEnabled { get; set; }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    [TerraformPropertyName("gpu_driver")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GpuDriver { get; set; }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    [TerraformPropertyName("gpu_instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GpuInstance { get; set; }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("host_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HostEncryptionEnabled { get; set; }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformPropertyName("host_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("kubelet_disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KubeletDiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kubelet_disk_type");

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformPropertyName("kubernetes_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KubernetesClusterId { get; set; }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformPropertyName("max_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxCount { get; set; }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    [TerraformPropertyName("max_pods")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxPods { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_pods");

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformPropertyName("min_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinCount { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformPropertyName("node_labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> NodeLabels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "node_labels");

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NodePublicIpEnabled { get; set; }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_prefix_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodePublicIpPrefixId { get; set; }

    /// <summary>
    /// The node_taints attribute.
    /// </summary>
    [TerraformPropertyName("node_taints")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NodeTaints { get; set; }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformPropertyName("orchestrator_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrchestratorVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "orchestrator_version");

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> OsDiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "os_disk_size_gb");

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OsDiskType { get; set; }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformPropertyName("os_sku")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OsSku { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_sku");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OsType { get; set; }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("pod_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PodSubnetId { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Priority { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScaleDownMode { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotId { get; set; }

    /// <summary>
    /// The spot_max_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_max_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SpotMaxPrice { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    [TerraformPropertyName("temporary_name_for_rotation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemporaryNameForRotation { get; set; }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UltraSsdEnabled { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformPropertyName("vm_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VmSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vm_size");

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("vnet_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VnetSubnetId { get; set; }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    [TerraformPropertyName("workload_runtime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkloadRuntime { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    [TerraformPropertyName("kubelet_config")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolKubeletConfigBlock>>? KubeletConfig { get; set; } = new();

    /// <summary>
    /// Block for linux_os_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    [TerraformPropertyName("linux_os_config")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolLinuxOsConfigBlock>>? LinuxOsConfig { get; set; } = new();

    /// <summary>
    /// Block for node_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    [TerraformPropertyName("node_network_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolNodeNetworkProfileBlock>>? NodeNetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterNodePoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    [TerraformPropertyName("upgrade_settings")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolUpgradeSettingsBlock>>? UpgradeSettings { get; set; } = new();

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformPropertyName("windows_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNodePoolWindowsProfileBlock>>? WindowsProfile { get; set; } = new();

}
