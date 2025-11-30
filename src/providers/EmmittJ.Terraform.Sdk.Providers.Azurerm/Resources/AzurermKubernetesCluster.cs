using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for aci_connector_linux in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAciConnectorLinuxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aci_connector_linux";

    /// <summary>
    /// The connector_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectorIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connector_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    public required TerraformValue<string> SubnetName
    {
        get => new TerraformReference<string>(this, "subnet_name");
        set => SetArgument("subnet_name", value);
    }

}


/// <summary>
/// Block type for api_server_access_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterApiServerAccessProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_server_access_profile";

    /// <summary>
    /// The authorized_ip_ranges attribute.
    /// </summary>
    public TerraformSet<string>? AuthorizedIpRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorized_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("authorized_ip_ranges", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualNetworkIntegrationEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_integration_enabled");
        set => SetArgument("virtual_network_integration_enabled", value);
    }

}


/// <summary>
/// Block type for auto_scaler_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAutoScalerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scaler_profile";

    /// <summary>
    /// The balance_similar_node_groups attribute.
    /// </summary>
    public TerraformValue<bool>? BalanceSimilarNodeGroups
    {
        get => new TerraformReference<bool>(this, "balance_similar_node_groups");
        set => SetArgument("balance_similar_node_groups", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DaemonsetEvictionForEmptyNodesEnabled
    {
        get => new TerraformReference<bool>(this, "daemonset_eviction_for_empty_nodes_enabled");
        set => SetArgument("daemonset_eviction_for_empty_nodes_enabled", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DaemonsetEvictionForOccupiedNodesEnabled
    {
        get => new TerraformReference<bool>(this, "daemonset_eviction_for_occupied_nodes_enabled");
        set => SetArgument("daemonset_eviction_for_occupied_nodes_enabled", value);
    }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    public TerraformValue<string> EmptyBulkDeleteMax
    {
        get => new TerraformReference<string>(this, "empty_bulk_delete_max");
        set => SetArgument("empty_bulk_delete_max", value);
    }

    /// <summary>
    /// The expander attribute.
    /// </summary>
    public TerraformValue<string>? Expander
    {
        get => new TerraformReference<string>(this, "expander");
        set => SetArgument("expander", value);
    }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreDaemonsetsUtilizationEnabled
    {
        get => new TerraformReference<bool>(this, "ignore_daemonsets_utilization_enabled");
        set => SetArgument("ignore_daemonsets_utilization_enabled", value);
    }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    public TerraformValue<string> MaxGracefulTerminationSec
    {
        get => new TerraformReference<string>(this, "max_graceful_termination_sec");
        set => SetArgument("max_graceful_termination_sec", value);
    }

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    public TerraformValue<string>? MaxNodeProvisioningTime
    {
        get => new TerraformReference<string>(this, "max_node_provisioning_time");
        set => SetArgument("max_node_provisioning_time", value);
    }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnreadyNodes
    {
        get => new TerraformReference<double>(this, "max_unready_nodes");
        set => SetArgument("max_unready_nodes", value);
    }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnreadyPercentage
    {
        get => new TerraformReference<double>(this, "max_unready_percentage");
        set => SetArgument("max_unready_percentage", value);
    }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    public TerraformValue<string> NewPodScaleUpDelay
    {
        get => new TerraformReference<string>(this, "new_pod_scale_up_delay");
        set => SetArgument("new_pod_scale_up_delay", value);
    }

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownDelayAfterAdd
    {
        get => new TerraformReference<string>(this, "scale_down_delay_after_add");
        set => SetArgument("scale_down_delay_after_add", value);
    }

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownDelayAfterDelete
    {
        get => new TerraformReference<string>(this, "scale_down_delay_after_delete");
        set => SetArgument("scale_down_delay_after_delete", value);
    }

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownDelayAfterFailure
    {
        get => new TerraformReference<string>(this, "scale_down_delay_after_failure");
        set => SetArgument("scale_down_delay_after_failure", value);
    }

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownUnneeded
    {
        get => new TerraformReference<string>(this, "scale_down_unneeded");
        set => SetArgument("scale_down_unneeded", value);
    }

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownUnready
    {
        get => new TerraformReference<string>(this, "scale_down_unready");
        set => SetArgument("scale_down_unready", value);
    }

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownUtilizationThreshold
    {
        get => new TerraformReference<string>(this, "scale_down_utilization_threshold");
        set => SetArgument("scale_down_utilization_threshold", value);
    }

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    public TerraformValue<string> ScanInterval
    {
        get => new TerraformReference<string>(this, "scan_interval");
        set => SetArgument("scan_interval", value);
    }

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    public TerraformValue<bool>? SkipNodesWithLocalStorage
    {
        get => new TerraformReference<bool>(this, "skip_nodes_with_local_storage");
        set => SetArgument("skip_nodes_with_local_storage", value);
    }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    public TerraformValue<bool>? SkipNodesWithSystemPods
    {
        get => new TerraformReference<bool>(this, "skip_nodes_with_system_pods");
        set => SetArgument("skip_nodes_with_system_pods", value);
    }

}


/// <summary>
/// Block type for azure_active_directory_role_based_access_control in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_active_directory_role_based_access_control";

    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    public TerraformList<string>? AdminGroupObjectIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "admin_group_object_ids").ResolveNodes(ctx));
        set => SetArgument("admin_group_object_ids", value);
    }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AzureRbacEnabled
    {
        get => new TerraformReference<bool>(this, "azure_rbac_enabled");
        set => SetArgument("azure_rbac_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for bootstrap_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterBootstrapProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bootstrap_profile";

    /// <summary>
    /// The artifact_source attribute.
    /// </summary>
    public TerraformValue<string>? ArtifactSource
    {
        get => new TerraformReference<string>(this, "artifact_source");
        set => SetArgument("artifact_source", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformValue<string>? ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

}


/// <summary>
/// Block type for confidential_computing in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterConfidentialComputingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_computing";

    /// <summary>
    /// The sgx_quote_helper_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SgxQuoteHelperEnabled is required")]
    public required TerraformValue<bool> SgxQuoteHelperEnabled
    {
        get => new TerraformReference<bool>(this, "sgx_quote_helper_enabled");
        set => SetArgument("sgx_quote_helper_enabled", value);
    }

}


/// <summary>
/// Block type for default_node_pool in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_node_pool";

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
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformValue<string> KubeletDiskType
    {
        get => new TerraformReference<string>(this, "kubelet_disk_type");
        set => SetArgument("kubelet_disk_type", value);
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
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OnlyCriticalAddonsEnabled
    {
        get => new TerraformReference<bool>(this, "only_critical_addons_enabled");
        set => SetArgument("only_critical_addons_enabled", value);
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
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? PodSubnetId
    {
        get => new TerraformReference<string>(this, "pod_subnet_id");
        set => SetArgument("pod_subnet_id", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
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
    public TerraformValue<string> WorkloadRuntime
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
    public TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// LinuxOsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxOsConfig block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlock>? LinuxOsConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlock>>("linux_os_config");
        set => SetArgument("linux_os_config", value);
    }

    /// <summary>
    /// NodeNetworkProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeNetworkProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlock>? NodeNetworkProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlock>>("node_network_profile");
        set => SetArgument("node_network_profile", value);
    }

    /// <summary>
    /// UpgradeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockUpgradeSettingsBlock>>("upgrade_settings");
        set => SetArgument("upgrade_settings", value);
    }

}

/// <summary>
/// Block type for kubelet_config in AzurermKubernetesClusterDefaultNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlockKubeletConfigBlock : TerraformBlock
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
/// Block type for linux_os_config in AzurermKubernetesClusterDefaultNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlock : TerraformBlock
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
    public TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlockSysctlConfigBlock>? SysctlConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlockSysctlConfigBlock>>("sysctl_config");
        set => SetArgument("sysctl_config", value);
    }

}

/// <summary>
/// Block type for sysctl_config in AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlockLinuxOsConfigBlockSysctlConfigBlock : TerraformBlock
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
/// Block type for node_network_profile in AzurermKubernetesClusterDefaultNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlock : TerraformBlock
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
    public TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlockAllowedHostPortsBlock>? AllowedHostPorts
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlockAllowedHostPortsBlock>>("allowed_host_ports");
        set => SetArgument("allowed_host_ports", value);
    }

}

/// <summary>
/// Block type for allowed_host_ports in AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlockNodeNetworkProfileBlockAllowedHostPortsBlock : TerraformBlock
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
/// Block type for upgrade_settings in AzurermKubernetesClusterDefaultNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlockUpgradeSettingsBlock : TerraformBlock
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
/// Block type for http_proxy_config in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterHttpProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_proxy_config";

    /// <summary>
    /// The http_proxy attribute.
    /// </summary>
    public TerraformValue<string>? HttpProxy
    {
        get => new TerraformReference<string>(this, "http_proxy");
        set => SetArgument("http_proxy", value);
    }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    public TerraformValue<string>? HttpsProxy
    {
        get => new TerraformReference<string>(this, "https_proxy");
        set => SetArgument("https_proxy", value);
    }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    public TerraformSet<string>? NoProxy
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "no_proxy").ResolveNodes(ctx));
        set => SetArgument("no_proxy", value);
    }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    public TerraformValue<string>? TrustedCa
    {
        get => new TerraformReference<string>(this, "trusted_ca");
        set => SetArgument("trusted_ca", value);
    }

}


/// <summary>
/// Block type for identity in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for ingress_application_gateway in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIngressApplicationGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_application_gateway";

    /// <summary>
    /// The effective_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> EffectiveGatewayId
    {
        get => new TerraformReference<string>(this, "effective_gateway_id");
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? GatewayId
    {
        get => new TerraformReference<string>(this, "gateway_id");
        set => SetArgument("gateway_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public TerraformValue<string>? GatewayName
    {
        get => new TerraformReference<string>(this, "gateway_name");
        set => SetArgument("gateway_name", value);
    }

    /// <summary>
    /// The ingress_application_gateway_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IngressApplicationGatewayIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ingress_application_gateway_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string>? SubnetCidr
    {
        get => new TerraformReference<string>(this, "subnet_cidr");
        set => SetArgument("subnet_cidr", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for key_management_service in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyManagementServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_management_service";

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultNetworkAccess
    {
        get => new TerraformReference<string>(this, "key_vault_network_access");
        set => SetArgument("key_vault_network_access", value);
    }

}


/// <summary>
/// Block type for key_vault_secrets_provider in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyVaultSecretsProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_secrets_provider";

    /// <summary>
    /// The secret_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecretIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secret_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecretRotationEnabled
    {
        get => new TerraformReference<bool>(this, "secret_rotation_enabled");
        set => SetArgument("secret_rotation_enabled", value);
    }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    public TerraformValue<string>? SecretRotationInterval
    {
        get => new TerraformReference<string>(this, "secret_rotation_interval");
        set => SetArgument("secret_rotation_interval", value);
    }

}


/// <summary>
/// Block type for kubelet_identity in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKubeletIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_identity";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string> UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for linux_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterLinuxProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_profile";

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// SshKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SshKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshKey block(s) allowed")]
    public required TerraformList<AzurermKubernetesClusterLinuxProfileBlockSshKeyBlock> SshKey
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesClusterLinuxProfileBlockSshKeyBlock>>("ssh_key");
        set => SetArgument("ssh_key", value);
    }

}

/// <summary>
/// Block type for ssh_key in AzurermKubernetesClusterLinuxProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterLinuxProfileBlockSshKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_key";

    /// <summary>
    /// The key_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyData is required")]
    public required TerraformValue<string> KeyData
    {
        get => new TerraformReference<string>(this, "key_data");
        set => SetArgument("key_data", value);
    }

}


/// <summary>
/// Block type for maintenance_window in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// Allowed block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermKubernetesClusterMaintenanceWindowBlockAllowedBlock>? Allowed
    {
        get => GetArgument<TerraformSet<AzurermKubernetesClusterMaintenanceWindowBlockAllowedBlock>>("allowed");
        set => SetArgument("allowed", value);
    }

    /// <summary>
    /// NotAllowed block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermKubernetesClusterMaintenanceWindowBlockNotAllowedBlock>? NotAllowed
    {
        get => GetArgument<TerraformSet<AzurermKubernetesClusterMaintenanceWindowBlockNotAllowedBlock>>("not_allowed");
        set => SetArgument("not_allowed", value);
    }

}

/// <summary>
/// Block type for allowed in AzurermKubernetesClusterMaintenanceWindowBlock.
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlockAllowedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed";

    /// <summary>
    /// The day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => new TerraformReference<string>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public required TerraformSet<double> Hours
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "hours").ResolveNodes(ctx));
        set => SetArgument("hours", value);
    }

}

/// <summary>
/// Block type for not_allowed in AzurermKubernetesClusterMaintenanceWindowBlock.
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlockNotAllowedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_allowed";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<string> End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Block type for maintenance_window_auto_upgrade in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window_auto_upgrade";

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformValue<double>? DayOfMonth
    {
        get => new TerraformReference<double>(this, "day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformValue<string>? DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    public TerraformValue<string>? UtcOffset
    {
        get => new TerraformReference<string>(this, "utc_offset");
        set => SetArgument("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    public TerraformValue<string>? WeekIndex
    {
        get => new TerraformReference<string>(this, "week_index");
        set => SetArgument("week_index", value);
    }

    /// <summary>
    /// NotAllowed block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlockNotAllowedBlock>? NotAllowed
    {
        get => GetArgument<TerraformSet<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlockNotAllowedBlock>>("not_allowed");
        set => SetArgument("not_allowed", value);
    }

}

/// <summary>
/// Block type for not_allowed in AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock.
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlockNotAllowedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_allowed";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<string> End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Block type for maintenance_window_node_os in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowNodeOsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window_node_os";

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformValue<double>? DayOfMonth
    {
        get => new TerraformReference<double>(this, "day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformValue<string>? DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    public TerraformValue<string>? UtcOffset
    {
        get => new TerraformReference<string>(this, "utc_offset");
        set => SetArgument("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    public TerraformValue<string>? WeekIndex
    {
        get => new TerraformReference<string>(this, "week_index");
        set => SetArgument("week_index", value);
    }

    /// <summary>
    /// NotAllowed block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermKubernetesClusterMaintenanceWindowNodeOsBlockNotAllowedBlock>? NotAllowed
    {
        get => GetArgument<TerraformSet<AzurermKubernetesClusterMaintenanceWindowNodeOsBlockNotAllowedBlock>>("not_allowed");
        set => SetArgument("not_allowed", value);
    }

}

/// <summary>
/// Block type for not_allowed in AzurermKubernetesClusterMaintenanceWindowNodeOsBlock.
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowNodeOsBlockNotAllowedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_allowed";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<string> End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Block type for microsoft_defender in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMicrosoftDefenderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft_defender";

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

}


/// <summary>
/// Block type for monitor_metrics in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMonitorMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor_metrics";

    /// <summary>
    /// The annotations_allowed attribute.
    /// </summary>
    public TerraformValue<string>? AnnotationsAllowed
    {
        get => new TerraformReference<string>(this, "annotations_allowed");
        set => SetArgument("annotations_allowed", value);
    }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    public TerraformValue<string>? LabelsAllowed
    {
        get => new TerraformReference<string>(this, "labels_allowed");
        set => SetArgument("labels_allowed", value);
    }

}


/// <summary>
/// Block type for network_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// The dns_service_ip attribute.
    /// </summary>
    public TerraformValue<string> DnsServiceIp
    {
        get => new TerraformReference<string>(this, "dns_service_ip");
        set => SetArgument("dns_service_ip", value);
    }

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    public TerraformList<string> IpVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_versions").ResolveNodes(ctx));
        set => SetArgument("ip_versions", value);
    }

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerSku
    {
        get => new TerraformReference<string>(this, "load_balancer_sku");
        set => SetArgument("load_balancer_sku", value);
    }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    public TerraformValue<string>? NetworkDataPlane
    {
        get => new TerraformReference<string>(this, "network_data_plane");
        set => SetArgument("network_data_plane", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformValue<string> NetworkMode
    {
        get => new TerraformReference<string>(this, "network_mode");
        set => SetArgument("network_mode", value);
    }

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    public required TerraformValue<string> NetworkPlugin
    {
        get => new TerraformReference<string>(this, "network_plugin");
        set => SetArgument("network_plugin", value);
    }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    public TerraformValue<string>? NetworkPluginMode
    {
        get => new TerraformReference<string>(this, "network_plugin_mode");
        set => SetArgument("network_plugin_mode", value);
    }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    public TerraformValue<string> NetworkPolicy
    {
        get => new TerraformReference<string>(this, "network_policy");
        set => SetArgument("network_policy", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformValue<string>? OutboundType
    {
        get => new TerraformReference<string>(this, "outbound_type");
        set => SetArgument("outbound_type", value);
    }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    public TerraformValue<string> PodCidr
    {
        get => new TerraformReference<string>(this, "pod_cidr");
        set => SetArgument("pod_cidr", value);
    }

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    public TerraformList<string> PodCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "pod_cidrs").ResolveNodes(ctx));
        set => SetArgument("pod_cidrs", value);
    }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    public TerraformValue<string> ServiceCidr
    {
        get => new TerraformReference<string>(this, "service_cidr");
        set => SetArgument("service_cidr", value);
    }

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    public TerraformList<string> ServiceCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_cidrs").ResolveNodes(ctx));
        set => SetArgument("service_cidrs", value);
    }

    /// <summary>
    /// AdvancedNetworking block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedNetworking block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNetworkProfileBlockAdvancedNetworkingBlock>? AdvancedNetworking
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNetworkProfileBlockAdvancedNetworkingBlock>>("advanced_networking");
        set => SetArgument("advanced_networking", value);
    }

    /// <summary>
    /// LoadBalancerProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNetworkProfileBlockLoadBalancerProfileBlock>? LoadBalancerProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNetworkProfileBlockLoadBalancerProfileBlock>>("load_balancer_profile");
        set => SetArgument("load_balancer_profile", value);
    }

    /// <summary>
    /// NatGatewayProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NatGatewayProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNetworkProfileBlockNatGatewayProfileBlock>? NatGatewayProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNetworkProfileBlockNatGatewayProfileBlock>>("nat_gateway_profile");
        set => SetArgument("nat_gateway_profile", value);
    }

}

/// <summary>
/// Block type for advanced_networking in AzurermKubernetesClusterNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlockAdvancedNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_networking";

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ObservabilityEnabled
    {
        get => new TerraformReference<bool>(this, "observability_enabled");
        set => SetArgument("observability_enabled", value);
    }

    /// <summary>
    /// The security_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecurityEnabled
    {
        get => new TerraformReference<bool>(this, "security_enabled");
        set => SetArgument("security_enabled", value);
    }

}

/// <summary>
/// Block type for load_balancer_profile in AzurermKubernetesClusterNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlockLoadBalancerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer_profile";

    /// <summary>
    /// The backend_pool_type attribute.
    /// </summary>
    public TerraformValue<string>? BackendPoolType
    {
        get => new TerraformReference<string>(this, "backend_pool_type");
        set => SetArgument("backend_pool_type", value);
    }

    /// <summary>
    /// The effective_outbound_ips attribute.
    /// </summary>
    public TerraformSet<string> EffectiveOutboundIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "effective_outbound_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The managed_outbound_ip_count attribute.
    /// </summary>
    public TerraformValue<double> ManagedOutboundIpCount
    {
        get => new TerraformReference<double>(this, "managed_outbound_ip_count");
        set => SetArgument("managed_outbound_ip_count", value);
    }

    /// <summary>
    /// The managed_outbound_ipv6_count attribute.
    /// </summary>
    public TerraformValue<double> ManagedOutboundIpv6Count
    {
        get => new TerraformReference<double>(this, "managed_outbound_ipv6_count");
        set => SetArgument("managed_outbound_ipv6_count", value);
    }

    /// <summary>
    /// The outbound_ip_address_ids attribute.
    /// </summary>
    public TerraformSet<string>? OutboundIpAddressIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "outbound_ip_address_ids").ResolveNodes(ctx));
        set => SetArgument("outbound_ip_address_ids", value);
    }

    /// <summary>
    /// The outbound_ip_prefix_ids attribute.
    /// </summary>
    public TerraformSet<string>? OutboundIpPrefixIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "outbound_ip_prefix_ids").ResolveNodes(ctx));
        set => SetArgument("outbound_ip_prefix_ids", value);
    }

    /// <summary>
    /// The outbound_ports_allocated attribute.
    /// </summary>
    public TerraformValue<double>? OutboundPortsAllocated
    {
        get => new TerraformReference<double>(this, "outbound_ports_allocated");
        set => SetArgument("outbound_ports_allocated", value);
    }

}

/// <summary>
/// Block type for nat_gateway_profile in AzurermKubernetesClusterNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlockNatGatewayProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nat_gateway_profile";

    /// <summary>
    /// The effective_outbound_ips attribute.
    /// </summary>
    public TerraformSet<string> EffectiveOutboundIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "effective_outbound_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The managed_outbound_ip_count attribute.
    /// </summary>
    public TerraformValue<double> ManagedOutboundIpCount
    {
        get => new TerraformReference<double>(this, "managed_outbound_ip_count");
        set => SetArgument("managed_outbound_ip_count", value);
    }

}


/// <summary>
/// Block type for oms_agent in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterOmsAgentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oms_agent";

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MsiAuthForMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "msi_auth_for_monitoring_enabled");
        set => SetArgument("msi_auth_for_monitoring_enabled", value);
    }

    /// <summary>
    /// The oms_agent_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OmsAgentIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "oms_agent_identity").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for service_mesh_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServiceMeshProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_mesh_profile";

    /// <summary>
    /// The external_ingress_gateway_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExternalIngressGatewayEnabled
    {
        get => new TerraformReference<bool>(this, "external_ingress_gateway_enabled");
        set => SetArgument("external_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternalIngressGatewayEnabled
    {
        get => new TerraformReference<bool>(this, "internal_ingress_gateway_enabled");
        set => SetArgument("internal_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    public TerraformList<string>? Revisions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "revisions").ResolveNodes(ctx));
        set => SetArgument("revisions", value);
    }

    /// <summary>
    /// CertificateAuthority block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthority block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterServiceMeshProfileBlockCertificateAuthorityBlock>? CertificateAuthority
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterServiceMeshProfileBlockCertificateAuthorityBlock>>("certificate_authority");
        set => SetArgument("certificate_authority", value);
    }

}

/// <summary>
/// Block type for certificate_authority in AzurermKubernetesClusterServiceMeshProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServiceMeshProfileBlockCertificateAuthorityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority";

    /// <summary>
    /// The cert_chain_object_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertChainObjectName is required")]
    public required TerraformValue<string> CertChainObjectName
    {
        get => new TerraformReference<string>(this, "cert_chain_object_name");
        set => SetArgument("cert_chain_object_name", value);
    }

    /// <summary>
    /// The cert_object_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertObjectName is required")]
    public required TerraformValue<string> CertObjectName
    {
        get => new TerraformReference<string>(this, "cert_object_name");
        set => SetArgument("cert_object_name", value);
    }

    /// <summary>
    /// The key_object_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyObjectName is required")]
    public required TerraformValue<string> KeyObjectName
    {
        get => new TerraformReference<string>(this, "key_object_name");
        set => SetArgument("key_object_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The root_cert_object_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootCertObjectName is required")]
    public required TerraformValue<string> RootCertObjectName
    {
        get => new TerraformReference<string>(this, "root_cert_object_name");
        set => SetArgument("root_cert_object_name", value);
    }

}


/// <summary>
/// Block type for service_principal in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_principal";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

}


/// <summary>
/// Block type for storage_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterStorageProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_profile";

    /// <summary>
    /// The blob_driver_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BlobDriverEnabled
    {
        get => new TerraformReference<bool>(this, "blob_driver_enabled");
        set => SetArgument("blob_driver_enabled", value);
    }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiskDriverEnabled
    {
        get => new TerraformReference<bool>(this, "disk_driver_enabled");
        set => SetArgument("disk_driver_enabled", value);
    }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FileDriverEnabled
    {
        get => new TerraformReference<bool>(this, "file_driver_enabled");
        set => SetArgument("file_driver_enabled", value);
    }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SnapshotControllerEnabled
    {
        get => new TerraformReference<bool>(this, "snapshot_controller_enabled");
        set => SetArgument("snapshot_controller_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesCluster.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_override in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterUpgradeOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_override";

    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    public TerraformValue<string>? EffectiveUntil
    {
        get => new TerraformReference<string>(this, "effective_until");
        set => SetArgument("effective_until", value);
    }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    public required TerraformValue<bool> ForceUpgradeEnabled
    {
        get => new TerraformReference<bool>(this, "force_upgrade_enabled");
        set => SetArgument("force_upgrade_enabled", value);
    }

}


/// <summary>
/// Block type for web_app_routing in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWebAppRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_app_routing";

    /// <summary>
    /// The default_nginx_controller attribute.
    /// </summary>
    public TerraformValue<string>? DefaultNginxController
    {
        get => new TerraformReference<string>(this, "default_nginx_controller");
        set => SetArgument("default_nginx_controller", value);
    }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    public TerraformList<string>? DnsZoneIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_zone_ids").ResolveNodes(ctx));
        set => SetArgument("dns_zone_ids", value);
    }

    /// <summary>
    /// The web_app_routing_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebAppRoutingIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "web_app_routing_identity").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for windows_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWindowsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_profile";

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    public required TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The license attribute.
    /// </summary>
    public TerraformValue<string>? License
    {
        get => new TerraformReference<string>(this, "license");
        set => SetArgument("license", value);
    }

    /// <summary>
    /// Gmsa block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gmsa block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterWindowsProfileBlockGmsaBlock>? Gmsa
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterWindowsProfileBlockGmsaBlock>>("gmsa");
        set => SetArgument("gmsa", value);
    }

}

/// <summary>
/// Block type for gmsa in AzurermKubernetesClusterWindowsProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWindowsProfileBlockGmsaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gmsa";

    /// <summary>
    /// The dns_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServer is required")]
    public required TerraformValue<string> DnsServer
    {
        get => new TerraformReference<string>(this, "dns_server");
        set => SetArgument("dns_server", value);
    }

    /// <summary>
    /// The root_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootDomain is required")]
    public required TerraformValue<string> RootDomain
    {
        get => new TerraformReference<string>(this, "root_domain");
        set => SetArgument("root_domain", value);
    }

}


/// <summary>
/// Block type for workload_autoscaler_profile in AzurermKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWorkloadAutoscalerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_autoscaler_profile";

    /// <summary>
    /// The keda_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? KedaEnabled
    {
        get => new TerraformReference<bool>(this, "keda_enabled");
        set => SetArgument("keda_enabled", value);
    }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VerticalPodAutoscalerEnabled
    {
        get => new TerraformReference<bool>(this, "vertical_pod_autoscaler_enabled");
        set => SetArgument("vertical_pod_autoscaler_enabled", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_cluster Terraform resource.
/// Manages a azurerm_kubernetes_cluster resource.
/// </summary>
public partial class AzurermKubernetesCluster(string name) : TerraformResource("azurerm_kubernetes_cluster", name)
{
    /// <summary>
    /// The ai_toolchain_operator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AiToolchainOperatorEnabled
    {
        get => new TerraformReference<bool>(this, "ai_toolchain_operator_enabled");
        set => SetArgument("ai_toolchain_operator_enabled", value);
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformValue<string>? AutomaticUpgradeChannel
    {
        get => new TerraformReference<string>(this, "automatic_upgrade_channel");
        set => SetArgument("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AzurePolicyEnabled
    {
        get => new TerraformReference<bool>(this, "azure_policy_enabled");
        set => SetArgument("azure_policy_enabled", value);
    }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CostAnalysisEnabled
    {
        get => new TerraformReference<bool>(this, "cost_analysis_enabled");
        set => SetArgument("cost_analysis_enabled", value);
    }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    public TerraformList<string>? CustomCaTrustCertificatesBase64
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_ca_trust_certificates_base64").ResolveNodes(ctx));
        set => SetArgument("custom_ca_trust_certificates_base64", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DnsPrefix
    {
        get => new TerraformReference<string>(this, "dns_prefix");
        set => SetArgument("dns_prefix", value);
    }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    public TerraformValue<string>? DnsPrefixPrivateCluster
    {
        get => new TerraformReference<string>(this, "dns_prefix_private_cluster");
        set => SetArgument("dns_prefix_private_cluster", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpApplicationRoutingEnabled
    {
        get => new TerraformReference<bool>(this, "http_application_routing_enabled");
        set => SetArgument("http_application_routing_enabled", value);
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
    /// The image_cleaner_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ImageCleanerEnabled
    {
        get => new TerraformReference<bool>(this, "image_cleaner_enabled");
        set => SetArgument("image_cleaner_enabled", value);
    }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    public TerraformValue<double>? ImageCleanerIntervalHours
    {
        get => new TerraformReference<double>(this, "image_cleaner_interval_hours");
        set => SetArgument("image_cleaner_interval_hours", value);
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
    {
        get => new TerraformReference<string>(this, "kubernetes_version");
        set => SetArgument("kubernetes_version", value);
    }

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAccountDisabled
    {
        get => new TerraformReference<bool>(this, "local_account_disabled");
        set => SetArgument("local_account_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    public TerraformValue<string>? NodeOsUpgradeChannel
    {
        get => new TerraformReference<string>(this, "node_os_upgrade_channel");
        set => SetArgument("node_os_upgrade_channel", value);
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroup
    {
        get => new TerraformReference<string>(this, "node_resource_group");
        set => SetArgument("node_resource_group", value);
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OidcIssuerEnabled
    {
        get => new TerraformReference<bool>(this, "oidc_issuer_enabled");
        set => SetArgument("oidc_issuer_enabled", value);
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OpenServiceMeshEnabled
    {
        get => new TerraformReference<bool>(this, "open_service_mesh_enabled");
        set => SetArgument("open_service_mesh_enabled", value);
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateClusterEnabled
    {
        get => new TerraformReference<bool>(this, "private_cluster_enabled");
        set => SetArgument("private_cluster_enabled", value);
    }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateClusterPublicFqdnEnabled
    {
        get => new TerraformReference<bool>(this, "private_cluster_public_fqdn_enabled");
        set => SetArgument("private_cluster_public_fqdn_enabled", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsZoneId
    {
        get => new TerraformReference<string>(this, "private_dns_zone_id");
        set => SetArgument("private_dns_zone_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RoleBasedAccessControlEnabled
    {
        get => new TerraformReference<bool>(this, "role_based_access_control_enabled");
        set => SetArgument("role_based_access_control_enabled", value);
    }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RunCommandEnabled
    {
        get => new TerraformReference<bool>(this, "run_command_enabled");
        set => SetArgument("run_command_enabled", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string>? SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    public TerraformValue<string>? SupportPlan
    {
        get => new TerraformReference<string>(this, "support_plan");
        set => SetArgument("support_plan", value);
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
    /// The workload_identity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WorkloadIdentityEnabled
    {
        get => new TerraformReference<bool>(this, "workload_identity_enabled");
        set => SetArgument("workload_identity_enabled", value);
    }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentKubernetesVersion
    {
        get => new TerraformReference<string>(this, "current_kubernetes_version");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformValue<string> HttpApplicationRoutingZoneName
    {
        get => new TerraformReference<string>(this, "http_application_routing_zone_name");
    }

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeAdminConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kube_admin_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeAdminConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_admin_config_raw");
    }

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kube_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_config_raw");
    }

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroupId
    {
        get => new TerraformReference<string>(this, "node_resource_group_id");
    }

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformValue<string> OidcIssuerUrl
    {
        get => new TerraformReference<string>(this, "oidc_issuer_url");
    }

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    public TerraformValue<string> PortalFqdn
    {
        get => new TerraformReference<string>(this, "portal_fqdn");
    }

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformValue<string> PrivateFqdn
    {
        get => new TerraformReference<string>(this, "private_fqdn");
    }

    /// <summary>
    /// AciConnectorLinux block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterAciConnectorLinuxBlock>? AciConnectorLinux
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterAciConnectorLinuxBlock>>("aci_connector_linux");
        set => SetArgument("aci_connector_linux", value);
    }

    /// <summary>
    /// ApiServerAccessProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterApiServerAccessProfileBlock>? ApiServerAccessProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterApiServerAccessProfileBlock>>("api_server_access_profile");
        set => SetArgument("api_server_access_profile", value);
    }

    /// <summary>
    /// AutoScalerProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterAutoScalerProfileBlock>? AutoScalerProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterAutoScalerProfileBlock>>("auto_scaler_profile");
        set => SetArgument("auto_scaler_profile", value);
    }

    /// <summary>
    /// AzureActiveDirectoryRoleBasedAccessControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>? AzureActiveDirectoryRoleBasedAccessControl
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>>("azure_active_directory_role_based_access_control");
        set => SetArgument("azure_active_directory_role_based_access_control", value);
    }

    /// <summary>
    /// BootstrapProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterBootstrapProfileBlock>? BootstrapProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterBootstrapProfileBlock>>("bootstrap_profile");
        set => SetArgument("bootstrap_profile", value);
    }

    /// <summary>
    /// ConfidentialComputing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterConfidentialComputingBlock>? ConfidentialComputing
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterConfidentialComputingBlock>>("confidential_computing");
        set => SetArgument("confidential_computing", value);
    }

    /// <summary>
    /// DefaultNodePool block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    public required TerraformList<AzurermKubernetesClusterDefaultNodePoolBlock> DefaultNodePool
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesClusterDefaultNodePoolBlock>>("default_node_pool");
        set => SetArgument("default_node_pool", value);
    }

    /// <summary>
    /// HttpProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterHttpProxyConfigBlock>? HttpProxyConfig
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterHttpProxyConfigBlock>>("http_proxy_config");
        set => SetArgument("http_proxy_config", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// IngressApplicationGateway block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterIngressApplicationGatewayBlock>? IngressApplicationGateway
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterIngressApplicationGatewayBlock>>("ingress_application_gateway");
        set => SetArgument("ingress_application_gateway", value);
    }

    /// <summary>
    /// KeyManagementService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterKeyManagementServiceBlock>? KeyManagementService
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterKeyManagementServiceBlock>>("key_management_service");
        set => SetArgument("key_management_service", value);
    }

    /// <summary>
    /// KeyVaultSecretsProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>? KeyVaultSecretsProvider
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>>("key_vault_secrets_provider");
        set => SetArgument("key_vault_secrets_provider", value);
    }

    /// <summary>
    /// KubeletIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterKubeletIdentityBlock>? KubeletIdentity
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterKubeletIdentityBlock>>("kubelet_identity");
        set => SetArgument("kubelet_identity", value);
    }

    /// <summary>
    /// LinuxProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterLinuxProfileBlock>? LinuxProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterLinuxProfileBlock>>("linux_profile");
        set => SetArgument("linux_profile", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// MaintenanceWindowAutoUpgrade block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>? MaintenanceWindowAutoUpgrade
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>>("maintenance_window_auto_upgrade");
        set => SetArgument("maintenance_window_auto_upgrade", value);
    }

    /// <summary>
    /// MaintenanceWindowNodeOs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>? MaintenanceWindowNodeOs
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>>("maintenance_window_node_os");
        set => SetArgument("maintenance_window_node_os", value);
    }

    /// <summary>
    /// MicrosoftDefender block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterMicrosoftDefenderBlock>? MicrosoftDefender
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterMicrosoftDefenderBlock>>("microsoft_defender");
        set => SetArgument("microsoft_defender", value);
    }

    /// <summary>
    /// MonitorMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterMonitorMetricsBlock>? MonitorMetrics
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterMonitorMetricsBlock>>("monitor_metrics");
        set => SetArgument("monitor_metrics", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterNetworkProfileBlock>? NetworkProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterNetworkProfileBlock>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// OmsAgent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterOmsAgentBlock>? OmsAgent
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterOmsAgentBlock>>("oms_agent");
        set => SetArgument("oms_agent", value);
    }

    /// <summary>
    /// ServiceMeshProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterServiceMeshProfileBlock>? ServiceMeshProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterServiceMeshProfileBlock>>("service_mesh_profile");
        set => SetArgument("service_mesh_profile", value);
    }

    /// <summary>
    /// ServicePrincipal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterServicePrincipalBlock>? ServicePrincipal
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterServicePrincipalBlock>>("service_principal");
        set => SetArgument("service_principal", value);
    }

    /// <summary>
    /// StorageProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterStorageProfileBlock>? StorageProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterStorageProfileBlock>>("storage_profile");
        set => SetArgument("storage_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradeOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterUpgradeOverrideBlock>? UpgradeOverride
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterUpgradeOverrideBlock>>("upgrade_override");
        set => SetArgument("upgrade_override", value);
    }

    /// <summary>
    /// WebAppRouting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterWebAppRoutingBlock>? WebAppRouting
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterWebAppRoutingBlock>>("web_app_routing");
        set => SetArgument("web_app_routing", value);
    }

    /// <summary>
    /// WindowsProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterWindowsProfileBlock>? WindowsProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterWindowsProfileBlock>>("windows_profile");
        set => SetArgument("windows_profile", value);
    }

    /// <summary>
    /// WorkloadAutoscalerProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>? WorkloadAutoscalerProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>>("workload_autoscaler_profile");
        set => SetArgument("workload_autoscaler_profile", value);
    }

}
