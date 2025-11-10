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
        set => SetProperty("connector_identity", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    public required TerraformProperty<string> SubnetName
    {
        set => SetProperty("subnet_name", value);
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
        set => SetProperty("authorized_ip_ranges", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VirtualNetworkIntegrationEnabled
    {
        set => SetProperty("virtual_network_integration_enabled", value);
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
        set => SetProperty("balance_similar_node_groups", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DaemonsetEvictionForEmptyNodesEnabled
    {
        set => SetProperty("daemonset_eviction_for_empty_nodes_enabled", value);
    }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DaemonsetEvictionForOccupiedNodesEnabled
    {
        set => SetProperty("daemonset_eviction_for_occupied_nodes_enabled", value);
    }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    public TerraformProperty<string>? EmptyBulkDeleteMax
    {
        set => SetProperty("empty_bulk_delete_max", value);
    }

    /// <summary>
    /// The expander attribute.
    /// </summary>
    public TerraformProperty<string>? Expander
    {
        set => SetProperty("expander", value);
    }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreDaemonsetsUtilizationEnabled
    {
        set => SetProperty("ignore_daemonsets_utilization_enabled", value);
    }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    public TerraformProperty<string>? MaxGracefulTerminationSec
    {
        set => SetProperty("max_graceful_termination_sec", value);
    }

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    public TerraformProperty<string>? MaxNodeProvisioningTime
    {
        set => SetProperty("max_node_provisioning_time", value);
    }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnreadyNodes
    {
        set => SetProperty("max_unready_nodes", value);
    }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnreadyPercentage
    {
        set => SetProperty("max_unready_percentage", value);
    }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    public TerraformProperty<string>? NewPodScaleUpDelay
    {
        set => SetProperty("new_pod_scale_up_delay", value);
    }

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownDelayAfterAdd
    {
        set => SetProperty("scale_down_delay_after_add", value);
    }

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownDelayAfterDelete
    {
        set => SetProperty("scale_down_delay_after_delete", value);
    }

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownDelayAfterFailure
    {
        set => SetProperty("scale_down_delay_after_failure", value);
    }

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownUnneeded
    {
        set => SetProperty("scale_down_unneeded", value);
    }

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownUnready
    {
        set => SetProperty("scale_down_unready", value);
    }

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownUtilizationThreshold
    {
        set => SetProperty("scale_down_utilization_threshold", value);
    }

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    public TerraformProperty<string>? ScanInterval
    {
        set => SetProperty("scan_interval", value);
    }

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipNodesWithLocalStorage
    {
        set => SetProperty("skip_nodes_with_local_storage", value);
    }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipNodesWithSystemPods
    {
        set => SetProperty("skip_nodes_with_system_pods", value);
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
        set => SetProperty("admin_group_object_ids", value);
    }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureRbacEnabled
    {
        set => SetProperty("azure_rbac_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("artifact_source", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryId
    {
        set => SetProperty("container_registry_id", value);
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
        set => SetProperty("sgx_quote_helper_enabled", value);
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
        set => SetProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        set => SetProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        set => SetProperty("fips_enabled", value);
    }

    /// <summary>
    /// The gpu_driver attribute.
    /// </summary>
    public TerraformProperty<string>? GpuDriver
    {
        set => SetProperty("gpu_driver", value);
    }

    /// <summary>
    /// The gpu_instance attribute.
    /// </summary>
    public TerraformProperty<string>? GpuInstance
    {
        set => SetProperty("gpu_instance", value);
    }

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HostEncryptionEnabled
    {
        set => SetProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostGroupId
    {
        set => SetProperty("host_group_id", value);
    }

    /// <summary>
    /// The kubelet_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? KubeletDiskType
    {
        set => SetProperty("kubelet_disk_type", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCount
    {
        set => SetProperty("max_count", value);
    }

    /// <summary>
    /// The max_pods attribute.
    /// </summary>
    public TerraformProperty<double>? MaxPods
    {
        set => SetProperty("max_pods", value);
    }

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinCount
    {
        set => SetProperty("min_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NodeLabels
    {
        set => SetProperty("node_labels", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpEnabled
    {
        set => SetProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The node_public_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string>? NodePublicIpPrefixId
    {
        set => SetProperty("node_public_ip_prefix_id", value);
    }

    /// <summary>
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OnlyCriticalAddonsEnabled
    {
        set => SetProperty("only_critical_addons_enabled", value);
    }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    public TerraformProperty<string>? OrchestratorVersion
    {
        set => SetProperty("orchestrator_version", value);
    }

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? OsDiskSizeGb
    {
        set => SetProperty("os_disk_size_gb", value);
    }

    /// <summary>
    /// The os_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskType
    {
        set => SetProperty("os_disk_type", value);
    }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    public TerraformProperty<string>? OsSku
    {
        set => SetProperty("os_sku", value);
    }

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? PodSubnetId
    {
        set => SetProperty("pod_subnet_id", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        set => SetProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The scale_down_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownMode
    {
        set => SetProperty("scale_down_mode", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        set => SetProperty("snapshot_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The temporary_name_for_rotation attribute.
    /// </summary>
    public TerraformProperty<string>? TemporaryNameForRotation
    {
        set => SetProperty("temporary_name_for_rotation", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        set => SetProperty("ultra_ssd_enabled", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        set => SetProperty("vm_size", value);
    }

    /// <summary>
    /// The vnet_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VnetSubnetId
    {
        set => SetProperty("vnet_subnet_id", value);
    }

    /// <summary>
    /// The workload_runtime attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadRuntime
    {
        set => SetProperty("workload_runtime", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        set => SetProperty("zones", value);
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
        set => SetProperty("http_proxy", value);
    }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsProxy
    {
        set => SetProperty("https_proxy", value);
    }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NoProxy
    {
        set => SetProperty("no_proxy", value);
    }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    public TerraformProperty<string>? TrustedCa
    {
        set => SetProperty("trusted_ca", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("effective_gateway_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayId
    {
        set => SetProperty("gateway_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayName
    {
        set => SetProperty("gateway_name", value);
    }

    /// <summary>
    /// The ingress_application_gateway_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? IngressApplicationGatewayIdentity
    {
        set => SetProperty("ingress_application_gateway_identity", value);
    }

    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetCidr
    {
        set => SetProperty("subnet_cidr", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
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
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultNetworkAccess
    {
        set => SetProperty("key_vault_network_access", value);
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
        set => SetProperty("secret_identity", value);
    }

    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecretRotationEnabled
    {
        set => SetProperty("secret_rotation_enabled", value);
    }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    public TerraformProperty<string>? SecretRotationInterval
    {
        set => SetProperty("secret_rotation_interval", value);
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
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
        set => SetProperty("admin_username", value);
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
        set => SetProperty("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    public TerraformProperty<string>? UtcOffset
    {
        set => SetProperty("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    public TerraformProperty<string>? WeekIndex
    {
        set => SetProperty("week_index", value);
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
        set => SetProperty("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    public TerraformProperty<string>? UtcOffset
    {
        set => SetProperty("utc_offset", value);
    }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    public TerraformProperty<string>? WeekIndex
    {
        set => SetProperty("week_index", value);
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
        set => SetProperty("log_analytics_workspace_id", value);
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
        set => SetProperty("annotations_allowed", value);
    }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? LabelsAllowed
    {
        set => SetProperty("labels_allowed", value);
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
        set => SetProperty("dns_service_ip", value);
    }

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IpVersions
    {
        set => SetProperty("ip_versions", value);
    }

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerSku
    {
        set => SetProperty("load_balancer_sku", value);
    }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkDataPlane
    {
        set => SetProperty("network_data_plane", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkMode
    {
        set => SetProperty("network_mode", value);
    }

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    public required TerraformProperty<string> NetworkPlugin
    {
        set => SetProperty("network_plugin", value);
    }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkPluginMode
    {
        set => SetProperty("network_plugin_mode", value);
    }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkPolicy
    {
        set => SetProperty("network_policy", value);
    }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundType
    {
        set => SetProperty("outbound_type", value);
    }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? PodCidr
    {
        set => SetProperty("pod_cidr", value);
    }

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PodCidrs
    {
        set => SetProperty("pod_cidrs", value);
    }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceCidr
    {
        set => SetProperty("service_cidr", value);
    }

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ServiceCidrs
    {
        set => SetProperty("service_cidrs", value);
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
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MsiAuthForMonitoringEnabled
    {
        set => SetProperty("msi_auth_for_monitoring_enabled", value);
    }

    /// <summary>
    /// The oms_agent_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? OmsAgentIdentity
    {
        set => SetProperty("oms_agent_identity", value);
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
        set => SetProperty("external_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternalIngressGatewayEnabled
    {
        set => SetProperty("internal_ingress_gateway_enabled", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    public List<TerraformProperty<string>>? Revisions
    {
        set => SetProperty("revisions", value);
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
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        set => SetProperty("client_secret", value);
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
        set => SetProperty("blob_driver_enabled", value);
    }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiskDriverEnabled
    {
        set => SetProperty("disk_driver_enabled", value);
    }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FileDriverEnabled
    {
        set => SetProperty("file_driver_enabled", value);
    }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SnapshotControllerEnabled
    {
        set => SetProperty("snapshot_controller_enabled", value);
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
        set => SetProperty("effective_until", value);
    }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    public required TerraformProperty<bool> ForceUpgradeEnabled
    {
        set => SetProperty("force_upgrade_enabled", value);
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
        set => SetProperty("default_nginx_controller", value);
    }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    public List<TerraformProperty<string>>? DnsZoneIds
    {
        set => SetProperty("dns_zone_ids", value);
    }

    /// <summary>
    /// The web_app_routing_identity attribute.
    /// </summary>
    public List<TerraformProperty<object>>? WebAppRoutingIdentity
    {
        set => SetProperty("web_app_routing_identity", value);
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
        set => SetProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        set => SetProperty("admin_username", value);
    }

    /// <summary>
    /// The license attribute.
    /// </summary>
    public TerraformProperty<string>? License
    {
        set => SetProperty("license", value);
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
        set => SetProperty("keda_enabled", value);
    }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VerticalPodAutoscalerEnabled
    {
        set => SetProperty("vertical_pod_autoscaler_enabled", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("current_kubernetes_version");
        SetOutput("fqdn");
        SetOutput("http_application_routing_zone_name");
        SetOutput("kube_admin_config");
        SetOutput("kube_admin_config_raw");
        SetOutput("kube_config");
        SetOutput("kube_config_raw");
        SetOutput("node_resource_group_id");
        SetOutput("oidc_issuer_url");
        SetOutput("portal_fqdn");
        SetOutput("private_fqdn");
        SetOutput("ai_toolchain_operator_enabled");
        SetOutput("automatic_upgrade_channel");
        SetOutput("azure_policy_enabled");
        SetOutput("cost_analysis_enabled");
        SetOutput("custom_ca_trust_certificates_base64");
        SetOutput("disk_encryption_set_id");
        SetOutput("dns_prefix");
        SetOutput("dns_prefix_private_cluster");
        SetOutput("edge_zone");
        SetOutput("http_application_routing_enabled");
        SetOutput("id");
        SetOutput("image_cleaner_enabled");
        SetOutput("image_cleaner_interval_hours");
        SetOutput("kubernetes_version");
        SetOutput("local_account_disabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("node_os_upgrade_channel");
        SetOutput("node_resource_group");
        SetOutput("oidc_issuer_enabled");
        SetOutput("open_service_mesh_enabled");
        SetOutput("private_cluster_enabled");
        SetOutput("private_cluster_public_fqdn_enabled");
        SetOutput("private_dns_zone_id");
        SetOutput("resource_group_name");
        SetOutput("role_based_access_control_enabled");
        SetOutput("run_command_enabled");
        SetOutput("sku_tier");
        SetOutput("support_plan");
        SetOutput("tags");
        SetOutput("workload_identity_enabled");
    }

    /// <summary>
    /// The ai_toolchain_operator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AiToolchainOperatorEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ai_toolchain_operator_enabled");
        set => SetProperty("ai_toolchain_operator_enabled", value);
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformProperty<string> AutomaticUpgradeChannel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automatic_upgrade_channel");
        set => SetProperty("automatic_upgrade_channel", value);
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AzurePolicyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("azure_policy_enabled");
        set => SetProperty("azure_policy_enabled", value);
    }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CostAnalysisEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cost_analysis_enabled");
        set => SetProperty("cost_analysis_enabled", value);
    }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    public List<TerraformProperty<string>> CustomCaTrustCertificatesBase64
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("custom_ca_trust_certificates_base64");
        set => SetProperty("custom_ca_trust_certificates_base64", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string> DiskEncryptionSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_encryption_set_id");
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformProperty<string> DnsPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_prefix");
        set => SetProperty("dns_prefix", value);
    }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    public TerraformProperty<string> DnsPrefixPrivateCluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_prefix_private_cluster");
        set => SetProperty("dns_prefix_private_cluster", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HttpApplicationRoutingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("http_application_routing_enabled");
        set => SetProperty("http_application_routing_enabled", value);
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
    /// The image_cleaner_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ImageCleanerEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("image_cleaner_enabled");
        set => SetProperty("image_cleaner_enabled", value);
    }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    public TerraformProperty<double> ImageCleanerIntervalHours
    {
        get => GetRequiredOutput<TerraformProperty<double>>("image_cleaner_interval_hours");
        set => SetProperty("image_cleaner_interval_hours", value);
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformProperty<string> KubernetesVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubernetes_version");
        set => SetProperty("kubernetes_version", value);
    }

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAccountDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_account_disabled");
        set => SetProperty("local_account_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    public TerraformProperty<string> NodeOsUpgradeChannel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_os_upgrade_channel");
        set => SetProperty("node_os_upgrade_channel", value);
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformProperty<string> NodeResourceGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_resource_group");
        set => SetProperty("node_resource_group", value);
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OidcIssuerEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("oidc_issuer_enabled");
        set => SetProperty("oidc_issuer_enabled", value);
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OpenServiceMeshEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("open_service_mesh_enabled");
        set => SetProperty("open_service_mesh_enabled", value);
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateClusterEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_cluster_enabled");
        set => SetProperty("private_cluster_enabled", value);
    }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateClusterPublicFqdnEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_cluster_public_fqdn_enabled");
        set => SetProperty("private_cluster_public_fqdn_enabled", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string> PrivateDnsZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_dns_zone_id");
        set => SetProperty("private_dns_zone_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RoleBasedAccessControlEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("role_based_access_control_enabled");
        set => SetProperty("role_based_access_control_enabled", value);
    }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RunCommandEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("run_command_enabled");
        set => SetProperty("run_command_enabled", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string> SkuTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_tier");
        set => SetProperty("sku_tier", value);
    }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    public TerraformProperty<string> SupportPlan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("support_plan");
        set => SetProperty("support_plan", value);
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
    /// The workload_identity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> WorkloadIdentityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("workload_identity_enabled");
        set => SetProperty("workload_identity_enabled", value);
    }

    /// <summary>
    /// Block for aci_connector_linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    public List<AzurermKubernetesClusterAciConnectorLinuxBlock>? AciConnectorLinux
    {
        set => SetProperty("aci_connector_linux", value);
    }

    /// <summary>
    /// Block for api_server_access_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    public List<AzurermKubernetesClusterApiServerAccessProfileBlock>? ApiServerAccessProfile
    {
        set => SetProperty("api_server_access_profile", value);
    }

    /// <summary>
    /// Block for auto_scaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    public List<AzurermKubernetesClusterAutoScalerProfileBlock>? AutoScalerProfile
    {
        set => SetProperty("auto_scaler_profile", value);
    }

    /// <summary>
    /// Block for azure_active_directory_role_based_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    public List<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>? AzureActiveDirectoryRoleBasedAccessControl
    {
        set => SetProperty("azure_active_directory_role_based_access_control", value);
    }

    /// <summary>
    /// Block for bootstrap_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    public List<AzurermKubernetesClusterBootstrapProfileBlock>? BootstrapProfile
    {
        set => SetProperty("bootstrap_profile", value);
    }

    /// <summary>
    /// Block for confidential_computing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    public List<AzurermKubernetesClusterConfidentialComputingBlock>? ConfidentialComputing
    {
        set => SetProperty("confidential_computing", value);
    }

    /// <summary>
    /// Block for default_node_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    public List<AzurermKubernetesClusterDefaultNodePoolBlock>? DefaultNodePool
    {
        set => SetProperty("default_node_pool", value);
    }

    /// <summary>
    /// Block for http_proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    public List<AzurermKubernetesClusterHttpProxyConfigBlock>? HttpProxyConfig
    {
        set => SetProperty("http_proxy_config", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermKubernetesClusterIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for ingress_application_gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    public List<AzurermKubernetesClusterIngressApplicationGatewayBlock>? IngressApplicationGateway
    {
        set => SetProperty("ingress_application_gateway", value);
    }

    /// <summary>
    /// Block for key_management_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    public List<AzurermKubernetesClusterKeyManagementServiceBlock>? KeyManagementService
    {
        set => SetProperty("key_management_service", value);
    }

    /// <summary>
    /// Block for key_vault_secrets_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    public List<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>? KeyVaultSecretsProvider
    {
        set => SetProperty("key_vault_secrets_provider", value);
    }

    /// <summary>
    /// Block for kubelet_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    public List<AzurermKubernetesClusterKubeletIdentityBlock>? KubeletIdentity
    {
        set => SetProperty("kubelet_identity", value);
    }

    /// <summary>
    /// Block for linux_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    public List<AzurermKubernetesClusterLinuxProfileBlock>? LinuxProfile
    {
        set => SetProperty("linux_profile", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermKubernetesClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for maintenance_window_auto_upgrade.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    public List<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>? MaintenanceWindowAutoUpgrade
    {
        set => SetProperty("maintenance_window_auto_upgrade", value);
    }

    /// <summary>
    /// Block for maintenance_window_node_os.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    public List<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>? MaintenanceWindowNodeOs
    {
        set => SetProperty("maintenance_window_node_os", value);
    }

    /// <summary>
    /// Block for microsoft_defender.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    public List<AzurermKubernetesClusterMicrosoftDefenderBlock>? MicrosoftDefender
    {
        set => SetProperty("microsoft_defender", value);
    }

    /// <summary>
    /// Block for monitor_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    public List<AzurermKubernetesClusterMonitorMetricsBlock>? MonitorMetrics
    {
        set => SetProperty("monitor_metrics", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public List<AzurermKubernetesClusterNetworkProfileBlock>? NetworkProfile
    {
        set => SetProperty("network_profile", value);
    }

    /// <summary>
    /// Block for oms_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    public List<AzurermKubernetesClusterOmsAgentBlock>? OmsAgent
    {
        set => SetProperty("oms_agent", value);
    }

    /// <summary>
    /// Block for service_mesh_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    public List<AzurermKubernetesClusterServiceMeshProfileBlock>? ServiceMeshProfile
    {
        set => SetProperty("service_mesh_profile", value);
    }

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public List<AzurermKubernetesClusterServicePrincipalBlock>? ServicePrincipal
    {
        set => SetProperty("service_principal", value);
    }

    /// <summary>
    /// Block for storage_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    public List<AzurermKubernetesClusterStorageProfileBlock>? StorageProfile
    {
        set => SetProperty("storage_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    public List<AzurermKubernetesClusterUpgradeOverrideBlock>? UpgradeOverride
    {
        set => SetProperty("upgrade_override", value);
    }

    /// <summary>
    /// Block for web_app_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    public List<AzurermKubernetesClusterWebAppRoutingBlock>? WebAppRouting
    {
        set => SetProperty("web_app_routing", value);
    }

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    public List<AzurermKubernetesClusterWindowsProfileBlock>? WindowsProfile
    {
        set => SetProperty("windows_profile", value);
    }

    /// <summary>
    /// Block for workload_autoscaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    public List<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>? WorkloadAutoscalerProfile
    {
        set => SetProperty("workload_autoscaler_profile", value);
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
