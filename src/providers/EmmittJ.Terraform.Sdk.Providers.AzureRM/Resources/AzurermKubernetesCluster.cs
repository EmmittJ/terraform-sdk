using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    /// AciConnectorLinux block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    public AzurermKubernetesClusterAciConnectorLinuxBlock? AciConnectorLinux
    {
        get => GetArgument<AzurermKubernetesClusterAciConnectorLinuxBlock>("aci_connector_linux");
        set => SetArgument("aci_connector_linux", value);
    }

    /// <summary>
    /// ApiServerAccessProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    public AzurermKubernetesClusterApiServerAccessProfileBlock? ApiServerAccessProfile
    {
        get => GetArgument<AzurermKubernetesClusterApiServerAccessProfileBlock>("api_server_access_profile");
        set => SetArgument("api_server_access_profile", value);
    }

    /// <summary>
    /// AutoScalerProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    public AzurermKubernetesClusterAutoScalerProfileBlock? AutoScalerProfile
    {
        get => GetArgument<AzurermKubernetesClusterAutoScalerProfileBlock>("auto_scaler_profile");
        set => SetArgument("auto_scaler_profile", value);
    }

    /// <summary>
    /// AzureActiveDirectoryRoleBasedAccessControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    public AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock? AzureActiveDirectoryRoleBasedAccessControl
    {
        get => GetArgument<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>("azure_active_directory_role_based_access_control");
        set => SetArgument("azure_active_directory_role_based_access_control", value);
    }

    /// <summary>
    /// BootstrapProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    public AzurermKubernetesClusterBootstrapProfileBlock? BootstrapProfile
    {
        get => GetArgument<AzurermKubernetesClusterBootstrapProfileBlock>("bootstrap_profile");
        set => SetArgument("bootstrap_profile", value);
    }

    /// <summary>
    /// ConfidentialComputing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    public AzurermKubernetesClusterConfidentialComputingBlock? ConfidentialComputing
    {
        get => GetArgument<AzurermKubernetesClusterConfidentialComputingBlock>("confidential_computing");
        set => SetArgument("confidential_computing", value);
    }

    /// <summary>
    /// DefaultNodePool block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    public required AzurermKubernetesClusterDefaultNodePoolBlock DefaultNodePool
    {
        get => GetRequiredArgument<AzurermKubernetesClusterDefaultNodePoolBlock>("default_node_pool");
        set => SetArgument("default_node_pool", value);
    }

    /// <summary>
    /// HttpProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    public AzurermKubernetesClusterHttpProxyConfigBlock? HttpProxyConfig
    {
        get => GetArgument<AzurermKubernetesClusterHttpProxyConfigBlock>("http_proxy_config");
        set => SetArgument("http_proxy_config", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermKubernetesClusterIdentityBlock? Identity
    {
        get => GetArgument<AzurermKubernetesClusterIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// IngressApplicationGateway block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    public AzurermKubernetesClusterIngressApplicationGatewayBlock? IngressApplicationGateway
    {
        get => GetArgument<AzurermKubernetesClusterIngressApplicationGatewayBlock>("ingress_application_gateway");
        set => SetArgument("ingress_application_gateway", value);
    }

    /// <summary>
    /// KeyManagementService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    public AzurermKubernetesClusterKeyManagementServiceBlock? KeyManagementService
    {
        get => GetArgument<AzurermKubernetesClusterKeyManagementServiceBlock>("key_management_service");
        set => SetArgument("key_management_service", value);
    }

    /// <summary>
    /// KeyVaultSecretsProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    public AzurermKubernetesClusterKeyVaultSecretsProviderBlock? KeyVaultSecretsProvider
    {
        get => GetArgument<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>("key_vault_secrets_provider");
        set => SetArgument("key_vault_secrets_provider", value);
    }

    /// <summary>
    /// KubeletIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    public AzurermKubernetesClusterKubeletIdentityBlock? KubeletIdentity
    {
        get => GetArgument<AzurermKubernetesClusterKubeletIdentityBlock>("kubelet_identity");
        set => SetArgument("kubelet_identity", value);
    }

    /// <summary>
    /// LinuxProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    public AzurermKubernetesClusterLinuxProfileBlock? LinuxProfile
    {
        get => GetArgument<AzurermKubernetesClusterLinuxProfileBlock>("linux_profile");
        set => SetArgument("linux_profile", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public AzurermKubernetesClusterMaintenanceWindowBlock? MaintenanceWindow
    {
        get => GetArgument<AzurermKubernetesClusterMaintenanceWindowBlock>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// MaintenanceWindowAutoUpgrade block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    public AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock? MaintenanceWindowAutoUpgrade
    {
        get => GetArgument<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>("maintenance_window_auto_upgrade");
        set => SetArgument("maintenance_window_auto_upgrade", value);
    }

    /// <summary>
    /// MaintenanceWindowNodeOs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    public AzurermKubernetesClusterMaintenanceWindowNodeOsBlock? MaintenanceWindowNodeOs
    {
        get => GetArgument<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>("maintenance_window_node_os");
        set => SetArgument("maintenance_window_node_os", value);
    }

    /// <summary>
    /// MicrosoftDefender block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    public AzurermKubernetesClusterMicrosoftDefenderBlock? MicrosoftDefender
    {
        get => GetArgument<AzurermKubernetesClusterMicrosoftDefenderBlock>("microsoft_defender");
        set => SetArgument("microsoft_defender", value);
    }

    /// <summary>
    /// MonitorMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    public AzurermKubernetesClusterMonitorMetricsBlock? MonitorMetrics
    {
        get => GetArgument<AzurermKubernetesClusterMonitorMetricsBlock>("monitor_metrics");
        set => SetArgument("monitor_metrics", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public AzurermKubernetesClusterNetworkProfileBlock? NetworkProfile
    {
        get => GetArgument<AzurermKubernetesClusterNetworkProfileBlock>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// OmsAgent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    public AzurermKubernetesClusterOmsAgentBlock? OmsAgent
    {
        get => GetArgument<AzurermKubernetesClusterOmsAgentBlock>("oms_agent");
        set => SetArgument("oms_agent", value);
    }

    /// <summary>
    /// ServiceMeshProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    public AzurermKubernetesClusterServiceMeshProfileBlock? ServiceMeshProfile
    {
        get => GetArgument<AzurermKubernetesClusterServiceMeshProfileBlock>("service_mesh_profile");
        set => SetArgument("service_mesh_profile", value);
    }

    /// <summary>
    /// ServicePrincipal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public AzurermKubernetesClusterServicePrincipalBlock? ServicePrincipal
    {
        get => GetArgument<AzurermKubernetesClusterServicePrincipalBlock>("service_principal");
        set => SetArgument("service_principal", value);
    }

    /// <summary>
    /// StorageProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    public AzurermKubernetesClusterStorageProfileBlock? StorageProfile
    {
        get => GetArgument<AzurermKubernetesClusterStorageProfileBlock>("storage_profile");
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
    public AzurermKubernetesClusterUpgradeOverrideBlock? UpgradeOverride
    {
        get => GetArgument<AzurermKubernetesClusterUpgradeOverrideBlock>("upgrade_override");
        set => SetArgument("upgrade_override", value);
    }

    /// <summary>
    /// WebAppRouting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    public AzurermKubernetesClusterWebAppRoutingBlock? WebAppRouting
    {
        get => GetArgument<AzurermKubernetesClusterWebAppRoutingBlock>("web_app_routing");
        set => SetArgument("web_app_routing", value);
    }

    /// <summary>
    /// WindowsProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public AzurermKubernetesClusterWindowsProfileBlock? WindowsProfile
    {
        get => GetArgument<AzurermKubernetesClusterWindowsProfileBlock>("windows_profile");
        set => SetArgument("windows_profile", value);
    }

    /// <summary>
    /// WorkloadAutoscalerProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    public AzurermKubernetesClusterWorkloadAutoscalerProfileBlock? WorkloadAutoscalerProfile
    {
        get => GetArgument<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>("workload_autoscaler_profile");
        set => SetArgument("workload_autoscaler_profile", value);
    }

}
