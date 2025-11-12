using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for aci_connector_linux in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterAciConnectorLinuxBlock() : TerraformBlock("aci_connector_linux")
{

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    [TerraformProperty("subnet_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetName { get; set; }

}

/// <summary>
/// Block type for api_server_access_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterApiServerAccessProfileBlock() : TerraformBlock("api_server_access_profile")
{
    /// <summary>
    /// The authorized_ip_ranges attribute.
    /// </summary>
    [TerraformProperty("authorized_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AuthorizedIpRanges { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    [TerraformProperty("virtual_network_integration_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VirtualNetworkIntegrationEnabled { get; set; }

}

/// <summary>
/// Block type for auto_scaler_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterAutoScalerProfileBlock() : TerraformBlock("auto_scaler_profile")
{
    /// <summary>
    /// The balance_similar_node_groups attribute.
    /// </summary>
    [TerraformProperty("balance_similar_node_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    [TerraformProperty("daemonset_eviction_for_empty_nodes_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DaemonsetEvictionForEmptyNodesEnabled { get; set; }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    [TerraformProperty("daemonset_eviction_for_occupied_nodes_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DaemonsetEvictionForOccupiedNodesEnabled { get; set; }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    [TerraformProperty("empty_bulk_delete_max")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EmptyBulkDeleteMax { get; set; }

    /// <summary>
    /// The expander attribute.
    /// </summary>
    [TerraformProperty("expander")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Expander { get; set; }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    [TerraformProperty("ignore_daemonsets_utilization_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreDaemonsetsUtilizationEnabled { get; set; }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    [TerraformProperty("max_graceful_termination_sec")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxGracefulTerminationSec { get; set; }

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    [TerraformProperty("max_node_provisioning_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxNodeProvisioningTime { get; set; }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    [TerraformProperty("max_unready_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxUnreadyNodes { get; set; }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    [TerraformProperty("max_unready_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxUnreadyPercentage { get; set; }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    [TerraformProperty("new_pod_scale_up_delay")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NewPodScaleUpDelay { get; set; }

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    [TerraformProperty("scale_down_delay_after_add")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownDelayAfterAdd { get; set; }

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    [TerraformProperty("scale_down_delay_after_delete")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownDelayAfterDelete { get; set; }

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    [TerraformProperty("scale_down_delay_after_failure")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownDelayAfterFailure { get; set; }

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    [TerraformProperty("scale_down_unneeded")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownUnneeded { get; set; }

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    [TerraformProperty("scale_down_unready")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownUnready { get; set; }

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    [TerraformProperty("scale_down_utilization_threshold")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownUtilizationThreshold { get; set; }

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    [TerraformProperty("scan_interval")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScanInterval { get; set; }

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    [TerraformProperty("skip_nodes_with_local_storage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipNodesWithLocalStorage { get; set; }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    [TerraformProperty("skip_nodes_with_system_pods")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipNodesWithSystemPods { get; set; }

}

/// <summary>
/// Block type for azure_active_directory_role_based_access_control in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock() : TerraformBlock("azure_active_directory_role_based_access_control")
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    [TerraformProperty("admin_group_object_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    [TerraformProperty("azure_rbac_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzureRbacEnabled { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TenantId { get; set; }

}

/// <summary>
/// Block type for bootstrap_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterBootstrapProfileBlock() : TerraformBlock("bootstrap_profile")
{
    /// <summary>
    /// The artifact_source attribute.
    /// </summary>
    [TerraformProperty("artifact_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ArtifactSource { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformProperty("container_registry_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerRegistryId { get; set; }

}

/// <summary>
/// Block type for confidential_computing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterConfidentialComputingBlock() : TerraformBlock("confidential_computing")
{
    /// <summary>
    /// The sgx_quote_helper_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SgxQuoteHelperEnabled is required")]
    [TerraformProperty("sgx_quote_helper_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SgxQuoteHelperEnabled { get; set; }

}

/// <summary>
/// Block type for default_node_pool in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterDefaultNodePoolBlock() : TerraformBlock("default_node_pool")
{
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformProperty("kubelet_disk_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KubeletDiskType { get; set; }

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
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    [TerraformProperty("only_critical_addons_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OnlyCriticalAddonsEnabled { get; set; }

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
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformProperty("pod_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PodSubnetId { get; set; }

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
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WorkloadRuntime { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

}

/// <summary>
/// Block type for http_proxy_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterHttpProxyConfigBlock() : TerraformBlock("http_proxy_config")
{
    /// <summary>
    /// The http_proxy attribute.
    /// </summary>
    [TerraformProperty("http_proxy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpProxy { get; set; }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    [TerraformProperty("https_proxy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpsProxy { get; set; }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    [TerraformProperty("no_proxy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NoProxy { get; set; }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    [TerraformProperty("trusted_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrustedCa { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for ingress_application_gateway in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterIngressApplicationGatewayBlock() : TerraformBlock("ingress_application_gateway")
{

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformProperty("gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayId { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [TerraformProperty("gateway_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayName { get; set; }


    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("subnet_cidr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetCidr { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for key_management_service in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterKeyManagementServiceBlock() : TerraformBlock("key_management_service")
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformProperty("key_vault_key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    [TerraformProperty("key_vault_network_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultNetworkAccess { get; set; }

}

/// <summary>
/// Block type for key_vault_secrets_provider in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterKeyVaultSecretsProviderBlock() : TerraformBlock("key_vault_secrets_provider")
{

    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("secret_rotation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SecretRotationEnabled { get; set; }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    [TerraformProperty("secret_rotation_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretRotationInterval { get; set; }

}

/// <summary>
/// Block type for kubelet_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterKubeletIdentityBlock() : TerraformBlock("kubelet_identity")
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for linux_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterLinuxProfileBlock() : TerraformBlock("linux_profile")
{
    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformProperty("admin_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminUsername { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterMaintenanceWindowBlock() : TerraformBlock("maintenance_window")
{
}

/// <summary>
/// Block type for maintenance_window_auto_upgrade in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock() : TerraformBlock("maintenance_window_auto_upgrade")
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformProperty("day_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformProperty("day_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DayOfWeek { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDate { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformProperty("utc_offset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UtcOffset { get; set; }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformProperty("week_index")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WeekIndex { get; set; }

}

/// <summary>
/// Block type for maintenance_window_node_os in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterMaintenanceWindowNodeOsBlock() : TerraformBlock("maintenance_window_node_os")
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformProperty("day_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformProperty("day_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DayOfWeek { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDate { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformProperty("utc_offset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UtcOffset { get; set; }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformProperty("week_index")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WeekIndex { get; set; }

}

/// <summary>
/// Block type for microsoft_defender in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterMicrosoftDefenderBlock() : TerraformBlock("microsoft_defender")
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

}

/// <summary>
/// Block type for monitor_metrics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterMonitorMetricsBlock() : TerraformBlock("monitor_metrics")
{
    /// <summary>
    /// The annotations_allowed attribute.
    /// </summary>
    [TerraformProperty("annotations_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AnnotationsAllowed { get; set; }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    [TerraformProperty("labels_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LabelsAllowed { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterNetworkProfileBlock() : TerraformBlock("network_profile")
{
    /// <summary>
    /// The dns_service_ip attribute.
    /// </summary>
    [TerraformProperty("dns_service_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DnsServiceIp { get; set; }

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    [TerraformProperty("ip_versions")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> IpVersions { get; set; }

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    [TerraformProperty("load_balancer_sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LoadBalancerSku { get; set; }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    [TerraformProperty("network_data_plane")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkDataPlane { get; set; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformProperty("network_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkMode { get; set; }

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    [TerraformProperty("network_plugin")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkPlugin { get; set; }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    [TerraformProperty("network_plugin_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkPluginMode { get; set; }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    [TerraformProperty("network_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkPolicy { get; set; }

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformProperty("outbound_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutboundType { get; set; }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [TerraformProperty("pod_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PodCidr { get; set; }

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    [TerraformProperty("pod_cidrs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> PodCidrs { get; set; }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [TerraformProperty("service_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceCidr { get; set; }

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    [TerraformProperty("service_cidrs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ServiceCidrs { get; set; }

}

/// <summary>
/// Block type for oms_agent in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterOmsAgentBlock() : TerraformBlock("oms_agent")
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("msi_auth_for_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MsiAuthForMonitoringEnabled { get; set; }


}

/// <summary>
/// Block type for service_mesh_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterServiceMeshProfileBlock() : TerraformBlock("service_mesh_profile")
{
    /// <summary>
    /// The external_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformProperty("external_ingress_gateway_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExternalIngressGatewayEnabled { get; set; }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformProperty("internal_ingress_gateway_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternalIngressGatewayEnabled { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    [TerraformProperty("revisions")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Revisions { get; set; }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterServicePrincipalBlock() : TerraformBlock("service_principal")
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformProperty("client_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSecret { get; set; }

}

/// <summary>
/// Block type for storage_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterStorageProfileBlock() : TerraformBlock("storage_profile")
{
    /// <summary>
    /// The blob_driver_enabled attribute.
    /// </summary>
    [TerraformProperty("blob_driver_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BlobDriverEnabled { get; set; }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    [TerraformProperty("disk_driver_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DiskDriverEnabled { get; set; }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    [TerraformProperty("file_driver_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FileDriverEnabled { get; set; }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    [TerraformProperty("snapshot_controller_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SnapshotControllerEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for upgrade_override in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterUpgradeOverrideBlock() : TerraformBlock("upgrade_override")
{
    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    [TerraformProperty("effective_until")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EffectiveUntil { get; set; }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    [TerraformProperty("force_upgrade_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ForceUpgradeEnabled { get; set; }

}

/// <summary>
/// Block type for web_app_routing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterWebAppRoutingBlock() : TerraformBlock("web_app_routing")
{
    /// <summary>
    /// The default_nginx_controller attribute.
    /// </summary>
    [TerraformProperty("default_nginx_controller")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultNginxController { get; set; }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    [TerraformProperty("dns_zone_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DnsZoneIds { get; set; }


}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterWindowsProfileBlock() : TerraformBlock("windows_profile")
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformProperty("admin_password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformProperty("admin_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The license attribute.
    /// </summary>
    [TerraformProperty("license")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? License { get; set; }

}

/// <summary>
/// Block type for workload_autoscaler_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesClusterWorkloadAutoscalerProfileBlock() : TerraformBlock("workload_autoscaler_profile")
{
    /// <summary>
    /// The keda_enabled attribute.
    /// </summary>
    [TerraformProperty("keda_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? KedaEnabled { get; set; }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    [TerraformProperty("vertical_pod_autoscaler_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VerticalPodAutoscalerEnabled { get; set; }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKubernetesCluster : TerraformResource
{
    public AzurermKubernetesCluster(string name) : base("azurerm_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The ai_toolchain_operator_enabled attribute.
    /// </summary>
    [TerraformProperty("ai_toolchain_operator_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AiToolchainOperatorEnabled { get; set; }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_channel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutomaticUpgradeChannel { get; set; }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("azure_policy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzurePolicyEnabled { get; set; }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    [TerraformProperty("cost_analysis_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CostAnalysisEnabled { get; set; }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    [TerraformProperty("custom_ca_trust_certificates_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CustomCaTrustCertificatesBase64 { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformProperty("dns_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsPrefix { get; set; }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    [TerraformProperty("dns_prefix_private_cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsPrefixPrivateCluster { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformProperty("http_application_routing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpApplicationRoutingEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_cleaner_enabled attribute.
    /// </summary>
    [TerraformProperty("image_cleaner_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImageCleanerEnabled { get; set; }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    [TerraformProperty("image_cleaner_interval_hours")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ImageCleanerIntervalHours { get; set; }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformProperty("kubernetes_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KubernetesVersion { get; set; }

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    [TerraformProperty("local_account_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAccountDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    [TerraformProperty("node_os_upgrade_channel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeOsUpgradeChannel { get; set; }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformProperty("node_resource_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeResourceGroup { get; set; }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformProperty("oidc_issuer_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OidcIssuerEnabled { get; set; }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformProperty("open_service_mesh_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OpenServiceMeshEnabled { get; set; }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformProperty("private_cluster_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateClusterEnabled { get; set; }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    [TerraformProperty("private_cluster_public_fqdn_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateClusterPublicFqdnEnabled { get; set; }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformProperty("private_dns_zone_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateDnsZoneId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformProperty("role_based_access_control_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RoleBasedAccessControlEnabled { get; set; }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    [TerraformProperty("run_command_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RunCommandEnabled { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformProperty("sku_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuTier { get; set; }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    [TerraformProperty("support_plan")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SupportPlan { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workload_identity_enabled attribute.
    /// </summary>
    [TerraformProperty("workload_identity_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WorkloadIdentityEnabled { get; set; }

    /// <summary>
    /// Block for aci_connector_linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    [TerraformProperty("aci_connector_linux")]
    public TerraformList<AzurermKubernetesClusterAciConnectorLinuxBlock> AciConnectorLinux { get; set; } = new();

    /// <summary>
    /// Block for api_server_access_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    [TerraformProperty("api_server_access_profile")]
    public TerraformList<AzurermKubernetesClusterApiServerAccessProfileBlock> ApiServerAccessProfile { get; set; } = new();

    /// <summary>
    /// Block for auto_scaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    [TerraformProperty("auto_scaler_profile")]
    public TerraformList<AzurermKubernetesClusterAutoScalerProfileBlock> AutoScalerProfile { get; set; } = new();

    /// <summary>
    /// Block for azure_active_directory_role_based_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    [TerraformProperty("azure_active_directory_role_based_access_control")]
    public TerraformList<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock> AzureActiveDirectoryRoleBasedAccessControl { get; set; } = new();

    /// <summary>
    /// Block for bootstrap_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    [TerraformProperty("bootstrap_profile")]
    public TerraformList<AzurermKubernetesClusterBootstrapProfileBlock> BootstrapProfile { get; set; } = new();

    /// <summary>
    /// Block for confidential_computing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    [TerraformProperty("confidential_computing")]
    public TerraformList<AzurermKubernetesClusterConfidentialComputingBlock> ConfidentialComputing { get; set; } = new();

    /// <summary>
    /// Block for default_node_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    [TerraformProperty("default_node_pool")]
    public required TerraformList<AzurermKubernetesClusterDefaultNodePoolBlock> DefaultNodePool { get; set; } = new();

    /// <summary>
    /// Block for http_proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    [TerraformProperty("http_proxy_config")]
    public TerraformList<AzurermKubernetesClusterHttpProxyConfigBlock> HttpProxyConfig { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermKubernetesClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress_application_gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    [TerraformProperty("ingress_application_gateway")]
    public TerraformList<AzurermKubernetesClusterIngressApplicationGatewayBlock> IngressApplicationGateway { get; set; } = new();

    /// <summary>
    /// Block for key_management_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    [TerraformProperty("key_management_service")]
    public TerraformList<AzurermKubernetesClusterKeyManagementServiceBlock> KeyManagementService { get; set; } = new();

    /// <summary>
    /// Block for key_vault_secrets_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    [TerraformProperty("key_vault_secrets_provider")]
    public TerraformList<AzurermKubernetesClusterKeyVaultSecretsProviderBlock> KeyVaultSecretsProvider { get; set; } = new();

    /// <summary>
    /// Block for kubelet_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    [TerraformProperty("kubelet_identity")]
    public TerraformList<AzurermKubernetesClusterKubeletIdentityBlock> KubeletIdentity { get; set; } = new();

    /// <summary>
    /// Block for linux_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    [TerraformProperty("linux_profile")]
    public TerraformList<AzurermKubernetesClusterLinuxProfileBlock> LinuxProfile { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowBlock> MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_auto_upgrade.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    [TerraformProperty("maintenance_window_auto_upgrade")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock> MaintenanceWindowAutoUpgrade { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_node_os.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    [TerraformProperty("maintenance_window_node_os")]
    public TerraformList<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock> MaintenanceWindowNodeOs { get; set; } = new();

    /// <summary>
    /// Block for microsoft_defender.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    [TerraformProperty("microsoft_defender")]
    public TerraformList<AzurermKubernetesClusterMicrosoftDefenderBlock> MicrosoftDefender { get; set; } = new();

    /// <summary>
    /// Block for monitor_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    [TerraformProperty("monitor_metrics")]
    public TerraformList<AzurermKubernetesClusterMonitorMetricsBlock> MonitorMetrics { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformProperty("network_profile")]
    public TerraformList<AzurermKubernetesClusterNetworkProfileBlock> NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for oms_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    [TerraformProperty("oms_agent")]
    public TerraformList<AzurermKubernetesClusterOmsAgentBlock> OmsAgent { get; set; } = new();

    /// <summary>
    /// Block for service_mesh_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    [TerraformProperty("service_mesh_profile")]
    public TerraformList<AzurermKubernetesClusterServiceMeshProfileBlock> ServiceMeshProfile { get; set; } = new();

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformProperty("service_principal")]
    public TerraformList<AzurermKubernetesClusterServicePrincipalBlock> ServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for storage_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    [TerraformProperty("storage_profile")]
    public TerraformList<AzurermKubernetesClusterStorageProfileBlock> StorageProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKubernetesClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    [TerraformProperty("upgrade_override")]
    public TerraformList<AzurermKubernetesClusterUpgradeOverrideBlock> UpgradeOverride { get; set; } = new();

    /// <summary>
    /// Block for web_app_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    [TerraformProperty("web_app_routing")]
    public TerraformList<AzurermKubernetesClusterWebAppRoutingBlock> WebAppRouting { get; set; } = new();

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformProperty("windows_profile")]
    public TerraformList<AzurermKubernetesClusterWindowsProfileBlock> WindowsProfile { get; set; } = new();

    /// <summary>
    /// Block for workload_autoscaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    [TerraformProperty("workload_autoscaler_profile")]
    public TerraformList<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock> WorkloadAutoscalerProfile { get; set; } = new();

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformProperty("current_kubernetes_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrentKubernetesVersion { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformProperty("http_application_routing_zone_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HttpApplicationRoutingZoneName { get; }

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformProperty("kube_admin_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KubeAdminConfig { get; }

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformProperty("kube_admin_config_raw")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KubeAdminConfigRaw { get; }

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformProperty("kube_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KubeConfig { get; }

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformProperty("kube_config_raw")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KubeConfigRaw { get; }

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformProperty("node_resource_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodeResourceGroupId { get; }

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformProperty("oidc_issuer_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OidcIssuerUrl { get; }

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    [TerraformProperty("portal_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalFqdn { get; }

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformProperty("private_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateFqdn { get; }

}
