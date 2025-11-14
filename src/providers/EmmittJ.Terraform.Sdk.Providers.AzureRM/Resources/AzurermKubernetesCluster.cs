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
/// Block type for aci_connector_linux in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAciConnectorLinuxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aci_connector_linux";


    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    [TerraformArgument("subnet_name")]
    public required TerraformValue<string> SubnetName
    {
        get => new TerraformReference<string>(this, "subnet_name");
        set => SetArgument("subnet_name", value);
    }

}

/// <summary>
/// Block type for api_server_access_profile in .
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
    [TerraformArgument("authorized_ip_ranges")]
    public TerraformSet<string>? AuthorizedIpRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorized_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("authorized_ip_ranges", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    [TerraformArgument("virtual_network_integration_enabled")]
    public TerraformValue<bool>? VirtualNetworkIntegrationEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_integration_enabled");
        set => SetArgument("virtual_network_integration_enabled", value);
    }

}

/// <summary>
/// Block type for auto_scaler_profile in .
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
    [TerraformArgument("balance_similar_node_groups")]
    public TerraformValue<bool>? BalanceSimilarNodeGroups
    {
        get => new TerraformReference<bool>(this, "balance_similar_node_groups");
        set => SetArgument("balance_similar_node_groups", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    [TerraformArgument("daemonset_eviction_for_empty_nodes_enabled")]
    public TerraformValue<bool>? DaemonsetEvictionForEmptyNodesEnabled
    {
        get => new TerraformReference<bool>(this, "daemonset_eviction_for_empty_nodes_enabled");
        set => SetArgument("daemonset_eviction_for_empty_nodes_enabled", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    [TerraformArgument("daemonset_eviction_for_occupied_nodes_enabled")]
    public TerraformValue<bool>? DaemonsetEvictionForOccupiedNodesEnabled
    {
        get => new TerraformReference<bool>(this, "daemonset_eviction_for_occupied_nodes_enabled");
        set => SetArgument("daemonset_eviction_for_occupied_nodes_enabled", value);
    }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    [TerraformArgument("empty_bulk_delete_max")]
    public TerraformValue<string> EmptyBulkDeleteMax
    {
        get => new TerraformReference<string>(this, "empty_bulk_delete_max");
        set => SetArgument("empty_bulk_delete_max", value);
    }

    /// <summary>
    /// The expander attribute.
    /// </summary>
    [TerraformArgument("expander")]
    public TerraformValue<string>? Expander
    {
        get => new TerraformReference<string>(this, "expander");
        set => SetArgument("expander", value);
    }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    [TerraformArgument("ignore_daemonsets_utilization_enabled")]
    public TerraformValue<bool>? IgnoreDaemonsetsUtilizationEnabled
    {
        get => new TerraformReference<bool>(this, "ignore_daemonsets_utilization_enabled");
        set => SetArgument("ignore_daemonsets_utilization_enabled", value);
    }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    [TerraformArgument("max_graceful_termination_sec")]
    public TerraformValue<string> MaxGracefulTerminationSec
    {
        get => new TerraformReference<string>(this, "max_graceful_termination_sec");
        set => SetArgument("max_graceful_termination_sec", value);
    }

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    [TerraformArgument("max_node_provisioning_time")]
    public TerraformValue<string>? MaxNodeProvisioningTime
    {
        get => new TerraformReference<string>(this, "max_node_provisioning_time");
        set => SetArgument("max_node_provisioning_time", value);
    }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    [TerraformArgument("max_unready_nodes")]
    public TerraformValue<double>? MaxUnreadyNodes
    {
        get => new TerraformReference<double>(this, "max_unready_nodes");
        set => SetArgument("max_unready_nodes", value);
    }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    [TerraformArgument("max_unready_percentage")]
    public TerraformValue<double>? MaxUnreadyPercentage
    {
        get => new TerraformReference<double>(this, "max_unready_percentage");
        set => SetArgument("max_unready_percentage", value);
    }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    [TerraformArgument("new_pod_scale_up_delay")]
    public TerraformValue<string> NewPodScaleUpDelay
    {
        get => new TerraformReference<string>(this, "new_pod_scale_up_delay");
        set => SetArgument("new_pod_scale_up_delay", value);
    }

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    [TerraformArgument("scale_down_delay_after_add")]
    public TerraformValue<string> ScaleDownDelayAfterAdd
    {
        get => new TerraformReference<string>(this, "scale_down_delay_after_add");
        set => SetArgument("scale_down_delay_after_add", value);
    }

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    [TerraformArgument("scale_down_delay_after_delete")]
    public TerraformValue<string> ScaleDownDelayAfterDelete
    {
        get => new TerraformReference<string>(this, "scale_down_delay_after_delete");
        set => SetArgument("scale_down_delay_after_delete", value);
    }

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    [TerraformArgument("scale_down_delay_after_failure")]
    public TerraformValue<string> ScaleDownDelayAfterFailure
    {
        get => new TerraformReference<string>(this, "scale_down_delay_after_failure");
        set => SetArgument("scale_down_delay_after_failure", value);
    }

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    [TerraformArgument("scale_down_unneeded")]
    public TerraformValue<string> ScaleDownUnneeded
    {
        get => new TerraformReference<string>(this, "scale_down_unneeded");
        set => SetArgument("scale_down_unneeded", value);
    }

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    [TerraformArgument("scale_down_unready")]
    public TerraformValue<string> ScaleDownUnready
    {
        get => new TerraformReference<string>(this, "scale_down_unready");
        set => SetArgument("scale_down_unready", value);
    }

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    [TerraformArgument("scale_down_utilization_threshold")]
    public TerraformValue<string> ScaleDownUtilizationThreshold
    {
        get => new TerraformReference<string>(this, "scale_down_utilization_threshold");
        set => SetArgument("scale_down_utilization_threshold", value);
    }

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    [TerraformArgument("scan_interval")]
    public TerraformValue<string> ScanInterval
    {
        get => new TerraformReference<string>(this, "scan_interval");
        set => SetArgument("scan_interval", value);
    }

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    [TerraformArgument("skip_nodes_with_local_storage")]
    public TerraformValue<bool>? SkipNodesWithLocalStorage
    {
        get => new TerraformReference<bool>(this, "skip_nodes_with_local_storage");
        set => SetArgument("skip_nodes_with_local_storage", value);
    }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    [TerraformArgument("skip_nodes_with_system_pods")]
    public TerraformValue<bool>? SkipNodesWithSystemPods
    {
        get => new TerraformReference<bool>(this, "skip_nodes_with_system_pods");
        set => SetArgument("skip_nodes_with_system_pods", value);
    }

}

/// <summary>
/// Block type for azure_active_directory_role_based_access_control in .
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
    [TerraformArgument("admin_group_object_ids")]
    public TerraformList<string>? AdminGroupObjectIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "admin_group_object_ids").ResolveNodes(ctx));
        set => SetArgument("admin_group_object_ids", value);
    }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    [TerraformArgument("azure_rbac_enabled")]
    public TerraformValue<bool>? AzureRbacEnabled
    {
        get => new TerraformReference<bool>(this, "azure_rbac_enabled");
        set => SetArgument("azure_rbac_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for bootstrap_profile in .
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
    [TerraformArgument("artifact_source")]
    public TerraformValue<string>? ArtifactSource
    {
        get => new TerraformReference<string>(this, "artifact_source");
        set => SetArgument("artifact_source", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformArgument("container_registry_id")]
    public TerraformValue<string>? ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

}

/// <summary>
/// Block type for confidential_computing in .
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
    [TerraformArgument("sgx_quote_helper_enabled")]
    public required TerraformValue<bool> SgxQuoteHelperEnabled
    {
        get => new TerraformReference<bool>(this, "sgx_quote_helper_enabled");
        set => SetArgument("sgx_quote_helper_enabled", value);
    }

}

/// <summary>
/// Block type for default_node_pool in .
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformArgument("kubelet_disk_type")]
    public TerraformValue<string> KubeletDiskType
    {
        get => new TerraformReference<string>(this, "kubelet_disk_type");
        set => SetArgument("kubelet_disk_type", value);
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
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    [TerraformArgument("only_critical_addons_enabled")]
    public TerraformValue<bool>? OnlyCriticalAddonsEnabled
    {
        get => new TerraformReference<bool>(this, "only_critical_addons_enabled");
        set => SetArgument("only_critical_addons_enabled", value);
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
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformArgument("pod_subnet_id")]
    public TerraformValue<string>? PodSubnetId
    {
        get => new TerraformReference<string>(this, "pod_subnet_id");
        set => SetArgument("pod_subnet_id", value);
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
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
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
    public TerraformValue<string> WorkloadRuntime
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

}

/// <summary>
/// Block type for http_proxy_config in .
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
    [TerraformArgument("http_proxy")]
    public TerraformValue<string>? HttpProxy
    {
        get => new TerraformReference<string>(this, "http_proxy");
        set => SetArgument("http_proxy", value);
    }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    [TerraformArgument("https_proxy")]
    public TerraformValue<string>? HttpsProxy
    {
        get => new TerraformReference<string>(this, "https_proxy");
        set => SetArgument("https_proxy", value);
    }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    [TerraformArgument("no_proxy")]
    public TerraformSet<string>? NoProxy
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "no_proxy").ResolveNodes(ctx));
        set => SetArgument("no_proxy", value);
    }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    [TerraformArgument("trusted_ca")]
    public TerraformValue<string>? TrustedCa
    {
        get => new TerraformReference<string>(this, "trusted_ca");
        set => SetArgument("trusted_ca", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for ingress_application_gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIngressApplicationGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_application_gateway";


    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformArgument("gateway_id")]
    public TerraformValue<string>? GatewayId
    {
        get => new TerraformReference<string>(this, "gateway_id");
        set => SetArgument("gateway_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [TerraformArgument("gateway_name")]
    public TerraformValue<string>? GatewayName
    {
        get => new TerraformReference<string>(this, "gateway_name");
        set => SetArgument("gateway_name", value);
    }


    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("subnet_cidr")]
    public TerraformValue<string>? SubnetCidr
    {
        get => new TerraformReference<string>(this, "subnet_cidr");
        set => SetArgument("subnet_cidr", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for key_management_service in .
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
    [TerraformArgument("key_vault_key_id")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    [TerraformArgument("key_vault_network_access")]
    public TerraformValue<string>? KeyVaultNetworkAccess
    {
        get => new TerraformReference<string>(this, "key_vault_network_access");
        set => SetArgument("key_vault_network_access", value);
    }

}

/// <summary>
/// Block type for key_vault_secrets_provider in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyVaultSecretsProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_secrets_provider";


    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    [TerraformArgument("secret_rotation_enabled")]
    public TerraformValue<bool>? SecretRotationEnabled
    {
        get => new TerraformReference<bool>(this, "secret_rotation_enabled");
        set => SetArgument("secret_rotation_enabled", value);
    }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    [TerraformArgument("secret_rotation_interval")]
    public TerraformValue<string>? SecretRotationInterval
    {
        get => new TerraformReference<string>(this, "secret_rotation_interval");
        set => SetArgument("secret_rotation_interval", value);
    }

}

/// <summary>
/// Block type for kubelet_identity in .
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
    [TerraformArgument("client_id")]
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformArgument("object_id")]
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_id")]
    public TerraformValue<string> UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for linux_profile in .
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
    [TerraformArgument("admin_username")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

}

/// <summary>
/// Block type for maintenance_window_auto_upgrade in .
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
    [TerraformArgument("day_of_month")]
    public TerraformValue<double>? DayOfMonth
    {
        get => new TerraformReference<double>(this, "day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformArgument("day_of_week")]
    public TerraformValue<string>? DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformArgument("duration")]
    public required TerraformValue<double> Duration
    {
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformArgument("interval")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformArgument("start_date")]
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformArgument("utc_offset")]
    public TerraformValue<string>? UtcOffset
    {
        get => new TerraformReference<string>(this, "utc_offset");
        set => SetArgument("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformArgument("week_index")]
    public TerraformValue<string>? WeekIndex
    {
        get => new TerraformReference<string>(this, "week_index");
        set => SetArgument("week_index", value);
    }

}

/// <summary>
/// Block type for maintenance_window_node_os in .
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
    [TerraformArgument("day_of_month")]
    public TerraformValue<double>? DayOfMonth
    {
        get => new TerraformReference<double>(this, "day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformArgument("day_of_week")]
    public TerraformValue<string>? DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformArgument("duration")]
    public required TerraformValue<double> Duration
    {
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformArgument("interval")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformArgument("start_date")]
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformArgument("utc_offset")]
    public TerraformValue<string>? UtcOffset
    {
        get => new TerraformReference<string>(this, "utc_offset");
        set => SetArgument("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformArgument("week_index")]
    public TerraformValue<string>? WeekIndex
    {
        get => new TerraformReference<string>(this, "week_index");
        set => SetArgument("week_index", value);
    }

}

/// <summary>
/// Block type for microsoft_defender in .
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
    [TerraformArgument("log_analytics_workspace_id")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

}

/// <summary>
/// Block type for monitor_metrics in .
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
    [TerraformArgument("annotations_allowed")]
    public TerraformValue<string>? AnnotationsAllowed
    {
        get => new TerraformReference<string>(this, "annotations_allowed");
        set => SetArgument("annotations_allowed", value);
    }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    [TerraformArgument("labels_allowed")]
    public TerraformValue<string>? LabelsAllowed
    {
        get => new TerraformReference<string>(this, "labels_allowed");
        set => SetArgument("labels_allowed", value);
    }

}

/// <summary>
/// Block type for network_profile in .
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
    [TerraformArgument("dns_service_ip")]
    public TerraformValue<string> DnsServiceIp
    {
        get => new TerraformReference<string>(this, "dns_service_ip");
        set => SetArgument("dns_service_ip", value);
    }

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    [TerraformArgument("ip_versions")]
    public TerraformList<string> IpVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_versions").ResolveNodes(ctx));
        set => SetArgument("ip_versions", value);
    }

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    [TerraformArgument("load_balancer_sku")]
    public TerraformValue<string>? LoadBalancerSku
    {
        get => new TerraformReference<string>(this, "load_balancer_sku");
        set => SetArgument("load_balancer_sku", value);
    }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    [TerraformArgument("network_data_plane")]
    public TerraformValue<string>? NetworkDataPlane
    {
        get => new TerraformReference<string>(this, "network_data_plane");
        set => SetArgument("network_data_plane", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformArgument("network_mode")]
    public TerraformValue<string> NetworkMode
    {
        get => new TerraformReference<string>(this, "network_mode");
        set => SetArgument("network_mode", value);
    }

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    [TerraformArgument("network_plugin")]
    public required TerraformValue<string> NetworkPlugin
    {
        get => new TerraformReference<string>(this, "network_plugin");
        set => SetArgument("network_plugin", value);
    }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    [TerraformArgument("network_plugin_mode")]
    public TerraformValue<string>? NetworkPluginMode
    {
        get => new TerraformReference<string>(this, "network_plugin_mode");
        set => SetArgument("network_plugin_mode", value);
    }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    [TerraformArgument("network_policy")]
    public TerraformValue<string> NetworkPolicy
    {
        get => new TerraformReference<string>(this, "network_policy");
        set => SetArgument("network_policy", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformArgument("outbound_type")]
    public TerraformValue<string>? OutboundType
    {
        get => new TerraformReference<string>(this, "outbound_type");
        set => SetArgument("outbound_type", value);
    }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [TerraformArgument("pod_cidr")]
    public TerraformValue<string> PodCidr
    {
        get => new TerraformReference<string>(this, "pod_cidr");
        set => SetArgument("pod_cidr", value);
    }

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    [TerraformArgument("pod_cidrs")]
    public TerraformList<string> PodCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "pod_cidrs").ResolveNodes(ctx));
        set => SetArgument("pod_cidrs", value);
    }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [TerraformArgument("service_cidr")]
    public TerraformValue<string> ServiceCidr
    {
        get => new TerraformReference<string>(this, "service_cidr");
        set => SetArgument("service_cidr", value);
    }

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    [TerraformArgument("service_cidrs")]
    public TerraformList<string> ServiceCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_cidrs").ResolveNodes(ctx));
        set => SetArgument("service_cidrs", value);
    }

}

/// <summary>
/// Block type for oms_agent in .
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
    [TerraformArgument("log_analytics_workspace_id")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    [TerraformArgument("msi_auth_for_monitoring_enabled")]
    public TerraformValue<bool>? MsiAuthForMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "msi_auth_for_monitoring_enabled");
        set => SetArgument("msi_auth_for_monitoring_enabled", value);
    }


}

/// <summary>
/// Block type for service_mesh_profile in .
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
    [TerraformArgument("external_ingress_gateway_enabled")]
    public TerraformValue<bool>? ExternalIngressGatewayEnabled
    {
        get => new TerraformReference<bool>(this, "external_ingress_gateway_enabled");
        set => SetArgument("external_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformArgument("internal_ingress_gateway_enabled")]
    public TerraformValue<bool>? InternalIngressGatewayEnabled
    {
        get => new TerraformReference<bool>(this, "internal_ingress_gateway_enabled");
        set => SetArgument("internal_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformArgument("mode")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    [TerraformArgument("revisions")]
    public TerraformList<string>? Revisions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "revisions").ResolveNodes(ctx));
        set => SetArgument("revisions", value);
    }

}

/// <summary>
/// Block type for service_principal in .
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
    [TerraformArgument("client_id")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformArgument("client_secret")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for storage_profile in .
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
    [TerraformArgument("blob_driver_enabled")]
    public TerraformValue<bool>? BlobDriverEnabled
    {
        get => new TerraformReference<bool>(this, "blob_driver_enabled");
        set => SetArgument("blob_driver_enabled", value);
    }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    [TerraformArgument("disk_driver_enabled")]
    public TerraformValue<bool>? DiskDriverEnabled
    {
        get => new TerraformReference<bool>(this, "disk_driver_enabled");
        set => SetArgument("disk_driver_enabled", value);
    }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    [TerraformArgument("file_driver_enabled")]
    public TerraformValue<bool>? FileDriverEnabled
    {
        get => new TerraformReference<bool>(this, "file_driver_enabled");
        set => SetArgument("file_driver_enabled", value);
    }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    [TerraformArgument("snapshot_controller_enabled")]
    public TerraformValue<bool>? SnapshotControllerEnabled
    {
        get => new TerraformReference<bool>(this, "snapshot_controller_enabled");
        set => SetArgument("snapshot_controller_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Block type for upgrade_override in .
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
    [TerraformArgument("effective_until")]
    public TerraformValue<string>? EffectiveUntil
    {
        get => new TerraformReference<string>(this, "effective_until");
        set => SetArgument("effective_until", value);
    }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    [TerraformArgument("force_upgrade_enabled")]
    public required TerraformValue<bool> ForceUpgradeEnabled
    {
        get => new TerraformReference<bool>(this, "force_upgrade_enabled");
        set => SetArgument("force_upgrade_enabled", value);
    }

}

/// <summary>
/// Block type for web_app_routing in .
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
    [TerraformArgument("default_nginx_controller")]
    public TerraformValue<string>? DefaultNginxController
    {
        get => new TerraformReference<string>(this, "default_nginx_controller");
        set => SetArgument("default_nginx_controller", value);
    }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    [TerraformArgument("dns_zone_ids")]
    public TerraformList<string>? DnsZoneIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_zone_ids").ResolveNodes(ctx));
        set => SetArgument("dns_zone_ids", value);
    }


}

/// <summary>
/// Block type for windows_profile in .
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
    [TerraformArgument("admin_password")]
    public required TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformArgument("admin_username")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The license attribute.
    /// </summary>
    [TerraformArgument("license")]
    public TerraformValue<string>? License
    {
        get => new TerraformReference<string>(this, "license");
        set => SetArgument("license", value);
    }

}

/// <summary>
/// Block type for workload_autoscaler_profile in .
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
    [TerraformArgument("keda_enabled")]
    public TerraformValue<bool>? KedaEnabled
    {
        get => new TerraformReference<bool>(this, "keda_enabled");
        set => SetArgument("keda_enabled", value);
    }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    [TerraformArgument("vertical_pod_autoscaler_enabled")]
    public TerraformValue<bool>? VerticalPodAutoscalerEnabled
    {
        get => new TerraformReference<bool>(this, "vertical_pod_autoscaler_enabled");
        set => SetArgument("vertical_pod_autoscaler_enabled", value);
    }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesCluster : TerraformResource
{
    public AzurermKubernetesCluster(string name) : base("azurerm_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The ai_toolchain_operator_enabled attribute.
    /// </summary>
    [TerraformArgument("ai_toolchain_operator_enabled")]
    public TerraformValue<bool>? AiToolchainOperatorEnabled
    {
        get => new TerraformReference<bool>(this, "ai_toolchain_operator_enabled");
        set => SetArgument("ai_toolchain_operator_enabled", value);
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformArgument("automatic_upgrade_channel")]
    public TerraformValue<string>? AutomaticUpgradeChannel
    {
        get => new TerraformReference<string>(this, "automatic_upgrade_channel");
        set => SetArgument("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("azure_policy_enabled")]
    public TerraformValue<bool>? AzurePolicyEnabled
    {
        get => new TerraformReference<bool>(this, "azure_policy_enabled");
        set => SetArgument("azure_policy_enabled", value);
    }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    [TerraformArgument("cost_analysis_enabled")]
    public TerraformValue<bool>? CostAnalysisEnabled
    {
        get => new TerraformReference<bool>(this, "cost_analysis_enabled");
        set => SetArgument("cost_analysis_enabled", value);
    }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    [TerraformArgument("custom_ca_trust_certificates_base64")]
    public TerraformList<string>? CustomCaTrustCertificatesBase64
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_ca_trust_certificates_base64").ResolveNodes(ctx));
        set => SetArgument("custom_ca_trust_certificates_base64", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformArgument("dns_prefix")]
    public TerraformValue<string>? DnsPrefix
    {
        get => new TerraformReference<string>(this, "dns_prefix");
        set => SetArgument("dns_prefix", value);
    }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    [TerraformArgument("dns_prefix_private_cluster")]
    public TerraformValue<string>? DnsPrefixPrivateCluster
    {
        get => new TerraformReference<string>(this, "dns_prefix_private_cluster");
        set => SetArgument("dns_prefix_private_cluster", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformArgument("edge_zone")]
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformArgument("http_application_routing_enabled")]
    public TerraformValue<bool>? HttpApplicationRoutingEnabled
    {
        get => new TerraformReference<bool>(this, "http_application_routing_enabled");
        set => SetArgument("http_application_routing_enabled", value);
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
    /// The image_cleaner_enabled attribute.
    /// </summary>
    [TerraformArgument("image_cleaner_enabled")]
    public TerraformValue<bool>? ImageCleanerEnabled
    {
        get => new TerraformReference<bool>(this, "image_cleaner_enabled");
        set => SetArgument("image_cleaner_enabled", value);
    }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    [TerraformArgument("image_cleaner_interval_hours")]
    public TerraformValue<double>? ImageCleanerIntervalHours
    {
        get => new TerraformReference<double>(this, "image_cleaner_interval_hours");
        set => SetArgument("image_cleaner_interval_hours", value);
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformArgument("kubernetes_version")]
    public TerraformValue<string> KubernetesVersion
    {
        get => new TerraformReference<string>(this, "kubernetes_version");
        set => SetArgument("kubernetes_version", value);
    }

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    [TerraformArgument("local_account_disabled")]
    public TerraformValue<bool>? LocalAccountDisabled
    {
        get => new TerraformReference<bool>(this, "local_account_disabled");
        set => SetArgument("local_account_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    [TerraformArgument("node_os_upgrade_channel")]
    public TerraformValue<string>? NodeOsUpgradeChannel
    {
        get => new TerraformReference<string>(this, "node_os_upgrade_channel");
        set => SetArgument("node_os_upgrade_channel", value);
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformArgument("node_resource_group")]
    public TerraformValue<string> NodeResourceGroup
    {
        get => new TerraformReference<string>(this, "node_resource_group");
        set => SetArgument("node_resource_group", value);
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformArgument("oidc_issuer_enabled")]
    public TerraformValue<bool>? OidcIssuerEnabled
    {
        get => new TerraformReference<bool>(this, "oidc_issuer_enabled");
        set => SetArgument("oidc_issuer_enabled", value);
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformArgument("open_service_mesh_enabled")]
    public TerraformValue<bool>? OpenServiceMeshEnabled
    {
        get => new TerraformReference<bool>(this, "open_service_mesh_enabled");
        set => SetArgument("open_service_mesh_enabled", value);
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformArgument("private_cluster_enabled")]
    public TerraformValue<bool>? PrivateClusterEnabled
    {
        get => new TerraformReference<bool>(this, "private_cluster_enabled");
        set => SetArgument("private_cluster_enabled", value);
    }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    [TerraformArgument("private_cluster_public_fqdn_enabled")]
    public TerraformValue<bool>? PrivateClusterPublicFqdnEnabled
    {
        get => new TerraformReference<bool>(this, "private_cluster_public_fqdn_enabled");
        set => SetArgument("private_cluster_public_fqdn_enabled", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformArgument("private_dns_zone_id")]
    public TerraformValue<string> PrivateDnsZoneId
    {
        get => new TerraformReference<string>(this, "private_dns_zone_id");
        set => SetArgument("private_dns_zone_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformArgument("role_based_access_control_enabled")]
    public TerraformValue<bool>? RoleBasedAccessControlEnabled
    {
        get => new TerraformReference<bool>(this, "role_based_access_control_enabled");
        set => SetArgument("role_based_access_control_enabled", value);
    }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    [TerraformArgument("run_command_enabled")]
    public TerraformValue<bool>? RunCommandEnabled
    {
        get => new TerraformReference<bool>(this, "run_command_enabled");
        set => SetArgument("run_command_enabled", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformArgument("sku_tier")]
    public TerraformValue<string>? SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    [TerraformArgument("support_plan")]
    public TerraformValue<string>? SupportPlan
    {
        get => new TerraformReference<string>(this, "support_plan");
        set => SetArgument("support_plan", value);
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
    /// The workload_identity_enabled attribute.
    /// </summary>
    [TerraformArgument("workload_identity_enabled")]
    public TerraformValue<bool>? WorkloadIdentityEnabled
    {
        get => new TerraformReference<bool>(this, "workload_identity_enabled");
        set => SetArgument("workload_identity_enabled", value);
    }

    /// <summary>
    /// Block for aci_connector_linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    [TerraformArgument("aci_connector_linux")]
    public TerraformList<AzurermKubernetesClusterAciConnectorLinuxBlock> AciConnectorLinux { get; set; } = new();

    /// <summary>
    /// Block for api_server_access_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    [TerraformArgument("api_server_access_profile")]
    public TerraformList<AzurermKubernetesClusterApiServerAccessProfileBlock> ApiServerAccessProfile { get; set; } = new();

    /// <summary>
    /// Block for auto_scaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    [TerraformArgument("auto_scaler_profile")]
    public TerraformList<AzurermKubernetesClusterAutoScalerProfileBlock> AutoScalerProfile { get; set; } = new();

    /// <summary>
    /// Block for azure_active_directory_role_based_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    [TerraformArgument("azure_active_directory_role_based_access_control")]
    public TerraformList<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock> AzureActiveDirectoryRoleBasedAccessControl { get; set; } = new();

    /// <summary>
    /// Block for bootstrap_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    [TerraformArgument("bootstrap_profile")]
    public TerraformList<AzurermKubernetesClusterBootstrapProfileBlock> BootstrapProfile { get; set; } = new();

    /// <summary>
    /// Block for confidential_computing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    [TerraformArgument("confidential_computing")]
    public TerraformList<AzurermKubernetesClusterConfidentialComputingBlock> ConfidentialComputing { get; set; } = new();

    /// <summary>
    /// Block for default_node_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    [TerraformArgument("default_node_pool")]
    public required TerraformList<AzurermKubernetesClusterDefaultNodePoolBlock> DefaultNodePool { get; set; } = new();

    /// <summary>
    /// Block for http_proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    [TerraformArgument("http_proxy_config")]
    public TerraformList<AzurermKubernetesClusterHttpProxyConfigBlock> HttpProxyConfig { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermKubernetesClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress_application_gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    [TerraformArgument("ingress_application_gateway")]
    public TerraformList<AzurermKubernetesClusterIngressApplicationGatewayBlock> IngressApplicationGateway { get; set; } = new();

    /// <summary>
    /// Block for key_management_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    [TerraformArgument("key_management_service")]
    public TerraformList<AzurermKubernetesClusterKeyManagementServiceBlock> KeyManagementService { get; set; } = new();

    /// <summary>
    /// Block for key_vault_secrets_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    [TerraformArgument("key_vault_secrets_provider")]
    public TerraformList<AzurermKubernetesClusterKeyVaultSecretsProviderBlock> KeyVaultSecretsProvider { get; set; } = new();

    /// <summary>
    /// Block for kubelet_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    [TerraformArgument("kubelet_identity")]
    public TerraformList<AzurermKubernetesClusterKubeletIdentityBlock> KubeletIdentity { get; set; } = new();

    /// <summary>
    /// Block for linux_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    [TerraformArgument("linux_profile")]
    public TerraformList<AzurermKubernetesClusterLinuxProfileBlock> LinuxProfile { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformArgument("maintenance_window")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowBlock> MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_auto_upgrade.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    [TerraformArgument("maintenance_window_auto_upgrade")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock> MaintenanceWindowAutoUpgrade { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_node_os.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    [TerraformArgument("maintenance_window_node_os")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock> MaintenanceWindowNodeOs { get; set; } = new();

    /// <summary>
    /// Block for microsoft_defender.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    [TerraformArgument("microsoft_defender")]
    public TerraformList<AzurermKubernetesClusterMicrosoftDefenderBlock> MicrosoftDefender { get; set; } = new();

    /// <summary>
    /// Block for monitor_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    [TerraformArgument("monitor_metrics")]
    public TerraformList<AzurermKubernetesClusterMonitorMetricsBlock> MonitorMetrics { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformArgument("network_profile")]
    public TerraformList<AzurermKubernetesClusterNetworkProfileBlock> NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for oms_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    [TerraformArgument("oms_agent")]
    public TerraformList<AzurermKubernetesClusterOmsAgentBlock> OmsAgent { get; set; } = new();

    /// <summary>
    /// Block for service_mesh_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    [TerraformArgument("service_mesh_profile")]
    public TerraformList<AzurermKubernetesClusterServiceMeshProfileBlock> ServiceMeshProfile { get; set; } = new();

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformArgument("service_principal")]
    public TerraformList<AzurermKubernetesClusterServicePrincipalBlock> ServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for storage_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    [TerraformArgument("storage_profile")]
    public TerraformList<AzurermKubernetesClusterStorageProfileBlock> StorageProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    [TerraformArgument("upgrade_override")]
    public TerraformList<AzurermKubernetesClusterUpgradeOverrideBlock> UpgradeOverride { get; set; } = new();

    /// <summary>
    /// Block for web_app_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    [TerraformArgument("web_app_routing")]
    public TerraformList<AzurermKubernetesClusterWebAppRoutingBlock> WebAppRouting { get; set; } = new();

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformArgument("windows_profile")]
    public TerraformList<AzurermKubernetesClusterWindowsProfileBlock> WindowsProfile { get; set; } = new();

    /// <summary>
    /// Block for workload_autoscaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    [TerraformArgument("workload_autoscaler_profile")]
    public TerraformList<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock> WorkloadAutoscalerProfile { get; set; } = new();

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformArgument("current_kubernetes_version")]
    public TerraformValue<string> CurrentKubernetesVersion
    {
        get => new TerraformReference<string>(this, "current_kubernetes_version");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformArgument("http_application_routing_zone_name")]
    public TerraformValue<string> HttpApplicationRoutingZoneName
    {
        get => new TerraformReference<string>(this, "http_application_routing_zone_name");
    }

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformArgument("kube_admin_config")]
    public TerraformList<object> KubeAdminConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "kube_admin_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformArgument("kube_admin_config_raw")]
    public TerraformValue<string> KubeAdminConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_admin_config_raw");
    }

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformArgument("kube_config")]
    public TerraformList<object> KubeConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "kube_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformArgument("kube_config_raw")]
    public TerraformValue<string> KubeConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_config_raw");
    }

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformArgument("node_resource_group_id")]
    public TerraformValue<string> NodeResourceGroupId
    {
        get => new TerraformReference<string>(this, "node_resource_group_id");
    }

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformArgument("oidc_issuer_url")]
    public TerraformValue<string> OidcIssuerUrl
    {
        get => new TerraformReference<string>(this, "oidc_issuer_url");
    }

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    [TerraformArgument("portal_fqdn")]
    public TerraformValue<string> PortalFqdn
    {
        get => new TerraformReference<string>(this, "portal_fqdn");
    }

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformArgument("private_fqdn")]
    public TerraformValue<string> PrivateFqdn
    {
        get => new TerraformReference<string>(this, "private_fqdn");
    }

}
