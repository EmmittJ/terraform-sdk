using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for aci_connector_linux in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAciConnectorLinuxBlock : TerraformBlock
{
    /// <summary>
    /// The connector_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? ConnectorIdentity
    {
        get => GetProperty<List<TerraformProperty<object>>>("connector_identity");
        set => WithProperty("connector_identity", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    public required TerraformProperty<string> SubnetName
    {
        get => GetProperty<TerraformProperty<string>>("subnet_name");
        set => WithProperty("subnet_name", value);
    }

}

/// <summary>
/// Block type for api_server_access_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterApiServerAccessProfileBlock : TerraformBlock
{
    /// <summary>
    /// The authorized_ip_ranges attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AuthorizedIpRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("authorized_ip_ranges");
        set => WithProperty("authorized_ip_ranges", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VirtualNetworkIntegrationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("virtual_network_integration_enabled");
        set => WithProperty("virtual_network_integration_enabled", value);
    }

}

/// <summary>
/// Block type for auto_scaler_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAutoScalerProfileBlock : TerraformBlock
{
    /// <summary>
    /// The balance_similar_node_groups attribute.
    /// </summary>
    public TerraformProperty<bool>? BalanceSimilarNodeGroups
    {
        get => GetProperty<TerraformProperty<bool>>("balance_similar_node_groups");
        set => WithProperty("balance_similar_node_groups", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DaemonsetEvictionForEmptyNodesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("daemonset_eviction_for_empty_nodes_enabled");
        set => WithProperty("daemonset_eviction_for_empty_nodes_enabled", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DaemonsetEvictionForOccupiedNodesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("daemonset_eviction_for_occupied_nodes_enabled");
        set => WithProperty("daemonset_eviction_for_occupied_nodes_enabled", value);
    }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    public TerraformProperty<string>? EmptyBulkDeleteMax
    {
        get => GetProperty<TerraformProperty<string>>("empty_bulk_delete_max");
        set => WithProperty("empty_bulk_delete_max", value);
    }

    /// <summary>
    /// The expander attribute.
    /// </summary>
    public TerraformProperty<string>? Expander
    {
        get => GetProperty<TerraformProperty<string>>("expander");
        set => WithProperty("expander", value);
    }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreDaemonsetsUtilizationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_daemonsets_utilization_enabled");
        set => WithProperty("ignore_daemonsets_utilization_enabled", value);
    }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    public TerraformProperty<string>? MaxGracefulTerminationSec
    {
        get => GetProperty<TerraformProperty<string>>("max_graceful_termination_sec");
        set => WithProperty("max_graceful_termination_sec", value);
    }

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    public TerraformProperty<string>? MaxNodeProvisioningTime
    {
        get => GetProperty<TerraformProperty<string>>("max_node_provisioning_time");
        set => WithProperty("max_node_provisioning_time", value);
    }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnreadyNodes
    {
        get => GetProperty<TerraformProperty<double>>("max_unready_nodes");
        set => WithProperty("max_unready_nodes", value);
    }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnreadyPercentage
    {
        get => GetProperty<TerraformProperty<double>>("max_unready_percentage");
        set => WithProperty("max_unready_percentage", value);
    }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    public TerraformProperty<string>? NewPodScaleUpDelay
    {
        get => GetProperty<TerraformProperty<string>>("new_pod_scale_up_delay");
        set => WithProperty("new_pod_scale_up_delay", value);
    }

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownDelayAfterAdd
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_delay_after_add");
        set => WithProperty("scale_down_delay_after_add", value);
    }

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownDelayAfterDelete
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_delay_after_delete");
        set => WithProperty("scale_down_delay_after_delete", value);
    }

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownDelayAfterFailure
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_delay_after_failure");
        set => WithProperty("scale_down_delay_after_failure", value);
    }

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownUnneeded
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_unneeded");
        set => WithProperty("scale_down_unneeded", value);
    }

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownUnready
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_unready");
        set => WithProperty("scale_down_unready", value);
    }

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownUtilizationThreshold
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_utilization_threshold");
        set => WithProperty("scale_down_utilization_threshold", value);
    }

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    public TerraformProperty<string>? ScanInterval
    {
        get => GetProperty<TerraformProperty<string>>("scan_interval");
        set => WithProperty("scan_interval", value);
    }

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipNodesWithLocalStorage
    {
        get => GetProperty<TerraformProperty<bool>>("skip_nodes_with_local_storage");
        set => WithProperty("skip_nodes_with_local_storage", value);
    }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipNodesWithSystemPods
    {
        get => GetProperty<TerraformProperty<bool>>("skip_nodes_with_system_pods");
        set => WithProperty("skip_nodes_with_system_pods", value);
    }

}

/// <summary>
/// Block type for azure_active_directory_role_based_access_control in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock : TerraformBlock
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdminGroupObjectIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("admin_group_object_ids");
        set => WithProperty("admin_group_object_ids", value);
    }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureRbacEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("azure_rbac_enabled");
        set => WithProperty("azure_rbac_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for bootstrap_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterBootstrapProfileBlock : TerraformBlock
{
    /// <summary>
    /// The artifact_source attribute.
    /// </summary>
    public TerraformProperty<string>? ArtifactSource
    {
        get => GetProperty<TerraformProperty<string>>("artifact_source");
        set => WithProperty("artifact_source", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => WithProperty("container_registry_id", value);
    }

}

/// <summary>
/// Block type for confidential_computing in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterConfidentialComputingBlock : TerraformBlock
{
    /// <summary>
    /// The sgx_quote_helper_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SgxQuoteHelperEnabled is required")]
    public required TerraformProperty<bool> SgxQuoteHelperEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sgx_quote_helper_enabled");
        set => WithProperty("sgx_quote_helper_enabled", value);
    }

}

/// <summary>
/// Block type for default_node_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlock : TerraformBlock
{
    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_scaling_enabled");
        set => WithProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformProperty<string>? GpuDriver
    {
        get => GetProperty<TerraformProperty<string>>("gpu_driver");
        set => WithProperty("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformProperty<string>? GpuInstance
    {
        get => GetProperty<TerraformProperty<string>>("gpu_instance");
        set => WithProperty("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HostEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("host_encryption_enabled");
        set => WithProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("host_group_id");
        set => WithProperty("host_group_id", value);
    }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? KubeletDiskType
    {
        get => GetProperty<TerraformProperty<string>>("kubelet_disk_type");
        set => WithProperty("kubelet_disk_type", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCount
    {
        get => GetProperty<TerraformProperty<double>>("max_count");
        set => WithProperty("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformProperty<double>? MaxPods
    {
        get => GetProperty<TerraformProperty<double>>("max_pods");
        set => WithProperty("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinCount
    {
        get => GetProperty<TerraformProperty<double>>("min_count");
        set => WithProperty("min_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NodeLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("node_labels");
        set => WithProperty("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("node_public_ip_enabled");
        set => WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string>? NodePublicIpPrefixId
    {
        get => GetProperty<TerraformProperty<string>>("node_public_ip_prefix_id");
        set => WithProperty("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OnlyCriticalAddonsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("only_critical_addons_enabled");
        set => WithProperty("only_critical_addons_enabled", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformProperty<string>? OrchestratorVersion
    {
        get => GetProperty<TerraformProperty<string>>("orchestrator_version");
        set => WithProperty("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? OsDiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("os_disk_size_gb");
        set => WithProperty("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskType
    {
        get => GetProperty<TerraformProperty<string>>("os_disk_type");
        set => WithProperty("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformProperty<string>? OsSku
    {
        get => GetProperty<TerraformProperty<string>>("os_sku");
        set => WithProperty("os_sku", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? PodSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("pod_subnet_id");
        set => WithProperty("pod_subnet_id", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownMode
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_mode");
        set => WithProperty("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformProperty<string>? TemporaryNameForRotation
    {
        get => GetProperty<TerraformProperty<string>>("temporary_name_for_rotation");
        set => WithProperty("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => WithProperty("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => WithProperty("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VnetSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("vnet_subnet_id");
        set => WithProperty("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadRuntime
    {
        get => GetProperty<TerraformProperty<string>>("workload_runtime");
        set => WithProperty("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => WithProperty("zones", value);
    }

}

/// <summary>
/// Block type for http_proxy_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterHttpProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// The http_proxy attribute.
    /// </summary>
    public TerraformProperty<string>? HttpProxy
    {
        get => GetProperty<TerraformProperty<string>>("http_proxy");
        set => WithProperty("http_proxy", value);
    }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsProxy
    {
        get => GetProperty<TerraformProperty<string>>("https_proxy");
        set => WithProperty("https_proxy", value);
    }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NoProxy
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("no_proxy");
        set => WithProperty("no_proxy", value);
    }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    public TerraformProperty<string>? TrustedCa
    {
        get => GetProperty<TerraformProperty<string>>("trusted_ca");
        set => WithProperty("trusted_ca", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for ingress_application_gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIngressApplicationGatewayBlock : TerraformBlock
{
    /// <summary>
    /// The effective_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("effective_gateway_id");
        set => WithProperty("effective_gateway_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayId
    {
        get => GetProperty<TerraformProperty<string>>("gateway_id");
        set => WithProperty("gateway_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayName
    {
        get => GetProperty<TerraformProperty<string>>("gateway_name");
        set => WithProperty("gateway_name", value);
    }

    /// <summary>
    /// The ingress_application_gateway_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? IngressApplicationGatewayIdentity
    {
        get => GetProperty<List<TerraformProperty<object>>>("ingress_application_gateway_identity");
        set => WithProperty("ingress_application_gateway_identity", value);
    }

    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetCidr
    {
        get => GetProperty<TerraformProperty<string>>("subnet_cidr");
        set => WithProperty("subnet_cidr", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for key_management_service in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyManagementServiceBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_network_access");
        set => WithProperty("key_vault_network_access", value);
    }

}

/// <summary>
/// Block type for key_vault_secrets_provider in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyVaultSecretsProviderBlock : TerraformBlock
{
    /// <summary>
    /// The secret_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? SecretIdentity
    {
        get => GetProperty<List<TerraformProperty<object>>>("secret_identity");
        set => WithProperty("secret_identity", value);
    }

    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecretRotationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("secret_rotation_enabled");
        set => WithProperty("secret_rotation_enabled", value);
    }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    public TerraformProperty<string>? SecretRotationInterval
    {
        get => GetProperty<TerraformProperty<string>>("secret_rotation_interval");
        set => WithProperty("secret_rotation_interval", value);
    }

}

/// <summary>
/// Block type for kubelet_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKubeletIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => WithProperty("object_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for linux_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterLinuxProfileBlock : TerraformBlock
{
    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => WithProperty("admin_username", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlock : TerraformBlock
{
}

/// <summary>
/// Block type for maintenance_window_auto_upgrade in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformProperty<double>? DayOfMonth
    {
        get => GetProperty<TerraformProperty<double>>("day_of_month");
        set => WithProperty("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfWeek
    {
        get => GetProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        get => GetProperty<TerraformProperty<double>>("duration");
        set => WithProperty("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => WithProperty("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => WithProperty("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    public TerraformProperty<string>? UtcOffset
    {
        get => GetProperty<TerraformProperty<string>>("utc_offset");
        set => WithProperty("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    public TerraformProperty<string>? WeekIndex
    {
        get => GetProperty<TerraformProperty<string>>("week_index");
        set => WithProperty("week_index", value);
    }

}

/// <summary>
/// Block type for maintenance_window_node_os in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowNodeOsBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformProperty<double>? DayOfMonth
    {
        get => GetProperty<TerraformProperty<double>>("day_of_month");
        set => WithProperty("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfWeek
    {
        get => GetProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        get => GetProperty<TerraformProperty<double>>("duration");
        set => WithProperty("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => WithProperty("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => WithProperty("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    public TerraformProperty<string>? UtcOffset
    {
        get => GetProperty<TerraformProperty<string>>("utc_offset");
        set => WithProperty("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    public TerraformProperty<string>? WeekIndex
    {
        get => GetProperty<TerraformProperty<string>>("week_index");
        set => WithProperty("week_index", value);
    }

}

/// <summary>
/// Block type for microsoft_defender in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMicrosoftDefenderBlock : TerraformBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => WithProperty("log_analytics_workspace_id", value);
    }

}

/// <summary>
/// Block type for monitor_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMonitorMetricsBlock : TerraformBlock
{
    /// <summary>
    /// The annotations_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? AnnotationsAllowed
    {
        get => GetProperty<TerraformProperty<string>>("annotations_allowed");
        set => WithProperty("annotations_allowed", value);
    }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? LabelsAllowed
    {
        get => GetProperty<TerraformProperty<string>>("labels_allowed");
        set => WithProperty("labels_allowed", value);
    }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The dns_service_ip attribute.
    /// </summary>
    public TerraformProperty<string>? DnsServiceIp
    {
        get => GetProperty<TerraformProperty<string>>("dns_service_ip");
        set => WithProperty("dns_service_ip", value);
    }

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IpVersions
    {
        get => GetProperty<List<TerraformProperty<string>>>("ip_versions");
        set => WithProperty("ip_versions", value);
    }

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerSku
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_sku");
        set => WithProperty("load_balancer_sku", value);
    }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkDataPlane
    {
        get => GetProperty<TerraformProperty<string>>("network_data_plane");
        set => WithProperty("network_data_plane", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkMode
    {
        get => GetProperty<TerraformProperty<string>>("network_mode");
        set => WithProperty("network_mode", value);
    }

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    public required TerraformProperty<string> NetworkPlugin
    {
        get => GetProperty<TerraformProperty<string>>("network_plugin");
        set => WithProperty("network_plugin", value);
    }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkPluginMode
    {
        get => GetProperty<TerraformProperty<string>>("network_plugin_mode");
        set => WithProperty("network_plugin_mode", value);
    }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkPolicy
    {
        get => GetProperty<TerraformProperty<string>>("network_policy");
        set => WithProperty("network_policy", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundType
    {
        get => GetProperty<TerraformProperty<string>>("outbound_type");
        set => WithProperty("outbound_type", value);
    }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? PodCidr
    {
        get => GetProperty<TerraformProperty<string>>("pod_cidr");
        set => WithProperty("pod_cidr", value);
    }

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PodCidrs
    {
        get => GetProperty<List<TerraformProperty<string>>>("pod_cidrs");
        set => WithProperty("pod_cidrs", value);
    }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceCidr
    {
        get => GetProperty<TerraformProperty<string>>("service_cidr");
        set => WithProperty("service_cidr", value);
    }

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ServiceCidrs
    {
        get => GetProperty<List<TerraformProperty<string>>>("service_cidrs");
        set => WithProperty("service_cidrs", value);
    }

}

/// <summary>
/// Block type for oms_agent in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterOmsAgentBlock : TerraformBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MsiAuthForMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("msi_auth_for_monitoring_enabled");
        set => WithProperty("msi_auth_for_monitoring_enabled", value);
    }

    /// <summary>
    /// The oms_agent_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? OmsAgentIdentity
    {
        get => GetProperty<List<TerraformProperty<object>>>("oms_agent_identity");
        set => WithProperty("oms_agent_identity", value);
    }

}

/// <summary>
/// Block type for service_mesh_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServiceMeshProfileBlock : TerraformBlock
{
    /// <summary>
    /// The external_ingress_gateway_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExternalIngressGatewayEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("external_ingress_gateway_enabled");
        set => WithProperty("external_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternalIngressGatewayEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internal_ingress_gateway_enabled");
        set => WithProperty("internal_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    public List<TerraformProperty<string>>? Revisions
    {
        get => GetProperty<List<TerraformProperty<string>>>("revisions");
        set => WithProperty("revisions", value);
    }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

}

/// <summary>
/// Block type for storage_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterStorageProfileBlock : TerraformBlock
{
    /// <summary>
    /// The blob_driver_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BlobDriverEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("blob_driver_enabled");
        set => WithProperty("blob_driver_enabled", value);
    }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiskDriverEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("disk_driver_enabled");
        set => WithProperty("disk_driver_enabled", value);
    }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FileDriverEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("file_driver_enabled");
        set => WithProperty("file_driver_enabled", value);
    }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SnapshotControllerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("snapshot_controller_enabled");
        set => WithProperty("snapshot_controller_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_override in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterUpgradeOverrideBlock : TerraformBlock
{
    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveUntil
    {
        get => GetProperty<TerraformProperty<string>>("effective_until");
        set => WithProperty("effective_until", value);
    }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    public required TerraformProperty<bool> ForceUpgradeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("force_upgrade_enabled");
        set => WithProperty("force_upgrade_enabled", value);
    }

}

/// <summary>
/// Block type for web_app_routing in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWebAppRoutingBlock : TerraformBlock
{
    /// <summary>
    /// The default_nginx_controller attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultNginxController
    {
        get => GetProperty<TerraformProperty<string>>("default_nginx_controller");
        set => WithProperty("default_nginx_controller", value);
    }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    public List<TerraformProperty<string>>? DnsZoneIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_zone_ids");
        set => WithProperty("dns_zone_ids", value);
    }

    /// <summary>
    /// The web_app_routing_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? WebAppRoutingIdentity
    {
        get => GetProperty<List<TerraformProperty<object>>>("web_app_routing_identity");
        set => WithProperty("web_app_routing_identity", value);
    }

}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWindowsProfileBlock : TerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    public required TerraformProperty<string> AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => WithProperty("admin_username", value);
    }

    /// <summary>
    /// The license attribute.
    /// </summary>
    public TerraformProperty<string>? License
    {
        get => GetProperty<TerraformProperty<string>>("license");
        set => WithProperty("license", value);
    }

}

/// <summary>
/// Block type for workload_autoscaler_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWorkloadAutoscalerProfileBlock : TerraformBlock
{
    /// <summary>
    /// The keda_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? KedaEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("keda_enabled");
        set => WithProperty("keda_enabled", value);
    }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VerticalPodAutoscalerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vertical_pod_autoscaler_enabled");
        set => WithProperty("vertical_pod_autoscaler_enabled", value);
    }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster resource.
/// </summary>
public class AzurermKubernetesCluster : TerraformResource
{
    public AzurermKubernetesCluster(string name) : base("azurerm_kubernetes_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("current_kubernetes_version");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("http_application_routing_zone_name");
        this.DeclareOutput("kube_admin_config");
        this.DeclareOutput("kube_admin_config_raw");
        this.DeclareOutput("kube_config");
        this.DeclareOutput("kube_config_raw");
        this.DeclareOutput("node_resource_group_id");
        this.DeclareOutput("oidc_issuer_url");
        this.DeclareOutput("portal_fqdn");
        this.DeclareOutput("private_fqdn");
    }

    /// <summary>
    /// The ai_toolchain_operator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AiToolchainOperatorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ai_toolchain_operator_enabled");
        set => this.WithProperty("ai_toolchain_operator_enabled", value);
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformProperty<string>? AutomaticUpgradeChannel
    {
        get => GetProperty<TerraformProperty<string>>("automatic_upgrade_channel");
        set => this.WithProperty("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzurePolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("azure_policy_enabled");
        set => this.WithProperty("azure_policy_enabled", value);
    }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CostAnalysisEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cost_analysis_enabled");
        set => this.WithProperty("cost_analysis_enabled", value);
    }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomCaTrustCertificatesBase64
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_ca_trust_certificates_base64");
        set => this.WithProperty("custom_ca_trust_certificates_base64", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => this.WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? DnsPrefix
    {
        get => GetProperty<TerraformProperty<string>>("dns_prefix");
        set => this.WithProperty("dns_prefix", value);
    }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    public TerraformProperty<string>? DnsPrefixPrivateCluster
    {
        get => GetProperty<TerraformProperty<string>>("dns_prefix_private_cluster");
        set => this.WithProperty("dns_prefix_private_cluster", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpApplicationRoutingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("http_application_routing_enabled");
        set => this.WithProperty("http_application_routing_enabled", value);
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
    /// The image_cleaner_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageCleanerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("image_cleaner_enabled");
        set => this.WithProperty("image_cleaner_enabled", value);
    }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    public TerraformProperty<double>? ImageCleanerIntervalHours
    {
        get => GetProperty<TerraformProperty<double>>("image_cleaner_interval_hours");
        set => this.WithProperty("image_cleaner_interval_hours", value);
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformProperty<string>? KubernetesVersion
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_version");
        set => this.WithProperty("kubernetes_version", value);
    }

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAccountDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_account_disabled");
        set => this.WithProperty("local_account_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    public TerraformProperty<string>? NodeOsUpgradeChannel
    {
        get => GetProperty<TerraformProperty<string>>("node_os_upgrade_channel");
        set => this.WithProperty("node_os_upgrade_channel", value);
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformProperty<string>? NodeResourceGroup
    {
        get => GetProperty<TerraformProperty<string>>("node_resource_group");
        set => this.WithProperty("node_resource_group", value);
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OidcIssuerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("oidc_issuer_enabled");
        set => this.WithProperty("oidc_issuer_enabled", value);
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OpenServiceMeshEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("open_service_mesh_enabled");
        set => this.WithProperty("open_service_mesh_enabled", value);
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateClusterEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_cluster_enabled");
        set => this.WithProperty("private_cluster_enabled", value);
    }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateClusterPublicFqdnEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_cluster_public_fqdn_enabled");
        set => this.WithProperty("private_cluster_public_fqdn_enabled", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateDnsZoneId
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_zone_id");
        set => this.WithProperty("private_dns_zone_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RoleBasedAccessControlEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("role_based_access_control_enabled");
        set => this.WithProperty("role_based_access_control_enabled", value);
    }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RunCommandEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("run_command_enabled");
        set => this.WithProperty("run_command_enabled", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string>? SkuTier
    {
        get => GetProperty<TerraformProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
    }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    public TerraformProperty<string>? SupportPlan
    {
        get => GetProperty<TerraformProperty<string>>("support_plan");
        set => this.WithProperty("support_plan", value);
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
    /// The workload_identity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WorkloadIdentityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("workload_identity_enabled");
        set => this.WithProperty("workload_identity_enabled", value);
    }

    /// <summary>
    /// Block for aci_connector_linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    public List<AzurermKubernetesClusterAciConnectorLinuxBlock>? AciConnectorLinux
    {
        get => GetProperty<List<AzurermKubernetesClusterAciConnectorLinuxBlock>>("aci_connector_linux");
        set => this.WithProperty("aci_connector_linux", value);
    }

    /// <summary>
    /// Block for api_server_access_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    public List<AzurermKubernetesClusterApiServerAccessProfileBlock>? ApiServerAccessProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterApiServerAccessProfileBlock>>("api_server_access_profile");
        set => this.WithProperty("api_server_access_profile", value);
    }

    /// <summary>
    /// Block for auto_scaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    public List<AzurermKubernetesClusterAutoScalerProfileBlock>? AutoScalerProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterAutoScalerProfileBlock>>("auto_scaler_profile");
        set => this.WithProperty("auto_scaler_profile", value);
    }

    /// <summary>
    /// Block for azure_active_directory_role_based_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    public List<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>? AzureActiveDirectoryRoleBasedAccessControl
    {
        get => GetProperty<List<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>>("azure_active_directory_role_based_access_control");
        set => this.WithProperty("azure_active_directory_role_based_access_control", value);
    }

    /// <summary>
    /// Block for bootstrap_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    public List<AzurermKubernetesClusterBootstrapProfileBlock>? BootstrapProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterBootstrapProfileBlock>>("bootstrap_profile");
        set => this.WithProperty("bootstrap_profile", value);
    }

    /// <summary>
    /// Block for confidential_computing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    public List<AzurermKubernetesClusterConfidentialComputingBlock>? ConfidentialComputing
    {
        get => GetProperty<List<AzurermKubernetesClusterConfidentialComputingBlock>>("confidential_computing");
        set => this.WithProperty("confidential_computing", value);
    }

    /// <summary>
    /// Block for default_node_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    public List<AzurermKubernetesClusterDefaultNodePoolBlock>? DefaultNodePool
    {
        get => GetProperty<List<AzurermKubernetesClusterDefaultNodePoolBlock>>("default_node_pool");
        set => this.WithProperty("default_node_pool", value);
    }

    /// <summary>
    /// Block for http_proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    public List<AzurermKubernetesClusterHttpProxyConfigBlock>? HttpProxyConfig
    {
        get => GetProperty<List<AzurermKubernetesClusterHttpProxyConfigBlock>>("http_proxy_config");
        set => this.WithProperty("http_proxy_config", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermKubernetesClusterIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermKubernetesClusterIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for ingress_application_gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    public List<AzurermKubernetesClusterIngressApplicationGatewayBlock>? IngressApplicationGateway
    {
        get => GetProperty<List<AzurermKubernetesClusterIngressApplicationGatewayBlock>>("ingress_application_gateway");
        set => this.WithProperty("ingress_application_gateway", value);
    }

    /// <summary>
    /// Block for key_management_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    public List<AzurermKubernetesClusterKeyManagementServiceBlock>? KeyManagementService
    {
        get => GetProperty<List<AzurermKubernetesClusterKeyManagementServiceBlock>>("key_management_service");
        set => this.WithProperty("key_management_service", value);
    }

    /// <summary>
    /// Block for key_vault_secrets_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    public List<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>? KeyVaultSecretsProvider
    {
        get => GetProperty<List<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>>("key_vault_secrets_provider");
        set => this.WithProperty("key_vault_secrets_provider", value);
    }

    /// <summary>
    /// Block for kubelet_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    public List<AzurermKubernetesClusterKubeletIdentityBlock>? KubeletIdentity
    {
        get => GetProperty<List<AzurermKubernetesClusterKubeletIdentityBlock>>("kubelet_identity");
        set => this.WithProperty("kubelet_identity", value);
    }

    /// <summary>
    /// Block for linux_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    public List<AzurermKubernetesClusterLinuxProfileBlock>? LinuxProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterLinuxProfileBlock>>("linux_profile");
        set => this.WithProperty("linux_profile", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermKubernetesClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<AzurermKubernetesClusterMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for maintenance_window_auto_upgrade.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    public List<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>? MaintenanceWindowAutoUpgrade
    {
        get => GetProperty<List<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>>("maintenance_window_auto_upgrade");
        set => this.WithProperty("maintenance_window_auto_upgrade", value);
    }

    /// <summary>
    /// Block for maintenance_window_node_os.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    public List<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>? MaintenanceWindowNodeOs
    {
        get => GetProperty<List<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>>("maintenance_window_node_os");
        set => this.WithProperty("maintenance_window_node_os", value);
    }

    /// <summary>
    /// Block for microsoft_defender.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    public List<AzurermKubernetesClusterMicrosoftDefenderBlock>? MicrosoftDefender
    {
        get => GetProperty<List<AzurermKubernetesClusterMicrosoftDefenderBlock>>("microsoft_defender");
        set => this.WithProperty("microsoft_defender", value);
    }

    /// <summary>
    /// Block for monitor_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    public List<AzurermKubernetesClusterMonitorMetricsBlock>? MonitorMetrics
    {
        get => GetProperty<List<AzurermKubernetesClusterMonitorMetricsBlock>>("monitor_metrics");
        set => this.WithProperty("monitor_metrics", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public List<AzurermKubernetesClusterNetworkProfileBlock>? NetworkProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterNetworkProfileBlock>>("network_profile");
        set => this.WithProperty("network_profile", value);
    }

    /// <summary>
    /// Block for oms_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    public List<AzurermKubernetesClusterOmsAgentBlock>? OmsAgent
    {
        get => GetProperty<List<AzurermKubernetesClusterOmsAgentBlock>>("oms_agent");
        set => this.WithProperty("oms_agent", value);
    }

    /// <summary>
    /// Block for service_mesh_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    public List<AzurermKubernetesClusterServiceMeshProfileBlock>? ServiceMeshProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterServiceMeshProfileBlock>>("service_mesh_profile");
        set => this.WithProperty("service_mesh_profile", value);
    }

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public List<AzurermKubernetesClusterServicePrincipalBlock>? ServicePrincipal
    {
        get => GetProperty<List<AzurermKubernetesClusterServicePrincipalBlock>>("service_principal");
        set => this.WithProperty("service_principal", value);
    }

    /// <summary>
    /// Block for storage_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    public List<AzurermKubernetesClusterStorageProfileBlock>? StorageProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterStorageProfileBlock>>("storage_profile");
        set => this.WithProperty("storage_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKubernetesClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    public List<AzurermKubernetesClusterUpgradeOverrideBlock>? UpgradeOverride
    {
        get => GetProperty<List<AzurermKubernetesClusterUpgradeOverrideBlock>>("upgrade_override");
        set => this.WithProperty("upgrade_override", value);
    }

    /// <summary>
    /// Block for web_app_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    public List<AzurermKubernetesClusterWebAppRoutingBlock>? WebAppRouting
    {
        get => GetProperty<List<AzurermKubernetesClusterWebAppRoutingBlock>>("web_app_routing");
        set => this.WithProperty("web_app_routing", value);
    }

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public List<AzurermKubernetesClusterWindowsProfileBlock>? WindowsProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterWindowsProfileBlock>>("windows_profile");
        set => this.WithProperty("windows_profile", value);
    }

    /// <summary>
    /// Block for workload_autoscaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    public List<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>? WorkloadAutoscalerProfile
    {
        get => GetProperty<List<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>>("workload_autoscaler_profile");
        set => this.WithProperty("workload_autoscaler_profile", value);
    }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformExpression CurrentKubernetesVersion => this["current_kubernetes_version"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformExpression HttpApplicationRoutingZoneName => this["http_application_routing_zone_name"];

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    public TerraformExpression KubeAdminConfig => this["kube_admin_config"];

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    public TerraformExpression KubeAdminConfigRaw => this["kube_admin_config_raw"];

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    public TerraformExpression KubeConfig => this["kube_config"];

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    public TerraformExpression KubeConfigRaw => this["kube_config_raw"];

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformExpression NodeResourceGroupId => this["node_resource_group_id"];

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformExpression OidcIssuerUrl => this["oidc_issuer_url"];

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    public TerraformExpression PortalFqdn => this["portal_fqdn"];

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformExpression PrivateFqdn => this["private_fqdn"];

}
