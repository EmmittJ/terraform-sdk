using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for aci_connector_linux in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAciConnectorLinuxBlock
{

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    [TerraformPropertyName("subnet_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetName { get; set; }

}

/// <summary>
/// Block type for api_server_access_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterApiServerAccessProfileBlock
{
    /// <summary>
    /// The authorized_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("authorized_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AuthorizedIpRanges { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_integration_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VirtualNetworkIntegrationEnabled { get; set; }

}

/// <summary>
/// Block type for auto_scaler_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAutoScalerProfileBlock
{
    /// <summary>
    /// The balance_similar_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("balance_similar_node_groups")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("daemonset_eviction_for_empty_nodes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DaemonsetEvictionForEmptyNodesEnabled { get; set; }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("daemonset_eviction_for_occupied_nodes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DaemonsetEvictionForOccupiedNodesEnabled { get; set; }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    [TerraformPropertyName("empty_bulk_delete_max")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmptyBulkDeleteMax { get; set; } = default!;

    /// <summary>
    /// The expander attribute.
    /// </summary>
    [TerraformPropertyName("expander")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Expander { get; set; }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ignore_daemonsets_utilization_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreDaemonsetsUtilizationEnabled { get; set; }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    [TerraformPropertyName("max_graceful_termination_sec")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxGracefulTerminationSec { get; set; } = default!;

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    [TerraformPropertyName("max_node_provisioning_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxNodeProvisioningTime { get; set; }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    [TerraformPropertyName("max_unready_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxUnreadyNodes { get; set; }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_unready_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxUnreadyPercentage { get; set; }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    [TerraformPropertyName("new_pod_scale_up_delay")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NewPodScaleUpDelay { get; set; } = default!;

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_delay_after_add")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownDelayAfterAdd { get; set; } = default!;

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_delay_after_delete")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownDelayAfterDelete { get; set; } = default!;

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_delay_after_failure")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownDelayAfterFailure { get; set; } = default!;

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_unneeded")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownUnneeded { get; set; } = default!;

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_unready")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownUnready { get; set; } = default!;

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_utilization_threshold")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownUtilizationThreshold { get; set; } = default!;

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    [TerraformPropertyName("scan_interval")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScanInterval { get; set; } = default!;

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    [TerraformPropertyName("skip_nodes_with_local_storage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipNodesWithLocalStorage { get; set; }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    [TerraformPropertyName("skip_nodes_with_system_pods")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipNodesWithSystemPods { get; set; }

}

/// <summary>
/// Block type for azure_active_directory_role_based_access_control in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    [TerraformPropertyName("admin_group_object_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_rbac_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AzureRbacEnabled { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TenantId { get; set; } = default!;

}

/// <summary>
/// Block type for bootstrap_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterBootstrapProfileBlock
{
    /// <summary>
    /// The artifact_source attribute.
    /// </summary>
    [TerraformPropertyName("artifact_source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ArtifactSource { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerRegistryId { get; set; }

}

/// <summary>
/// Block type for confidential_computing in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterConfidentialComputingBlock
{
    /// <summary>
    /// The sgx_quote_helper_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SgxQuoteHelperEnabled is required")]
    [TerraformPropertyName("sgx_quote_helper_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> SgxQuoteHelperEnabled { get; set; }

}

/// <summary>
/// Block type for default_node_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlock
{
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("kubelet_disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KubeletDiskType { get; set; } = default!;

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
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    [TerraformPropertyName("only_critical_addons_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OnlyCriticalAddonsEnabled { get; set; }

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
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("pod_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PodSubnetId { get; set; }

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
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WorkloadRuntime { get; set; } = default!;

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

}

/// <summary>
/// Block type for http_proxy_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterHttpProxyConfigBlock
{
    /// <summary>
    /// The http_proxy attribute.
    /// </summary>
    [TerraformPropertyName("http_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpProxy { get; set; }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    [TerraformPropertyName("https_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpsProxy { get; set; }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    [TerraformPropertyName("no_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? NoProxy { get; set; }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    [TerraformPropertyName("trusted_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrustedCa { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for ingress_application_gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIngressApplicationGatewayBlock
{

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GatewayId { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [TerraformPropertyName("gateway_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GatewayName { get; set; }


    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("subnet_cidr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetCidr { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for key_management_service in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyManagementServiceBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformPropertyName("key_vault_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultNetworkAccess { get; set; }

}

/// <summary>
/// Block type for key_vault_secrets_provider in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyVaultSecretsProviderBlock
{

    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secret_rotation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SecretRotationEnabled { get; set; }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    [TerraformPropertyName("secret_rotation_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretRotationInterval { get; set; }

}

/// <summary>
/// Block type for kubelet_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKubeletIdentityBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClientId { get; set; } = default!;

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserAssignedIdentityId { get; set; } = default!;

}

/// <summary>
/// Block type for linux_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterLinuxProfileBlock
{
    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminUsername { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlock
{
}

/// <summary>
/// Block type for maintenance_window_auto_upgrade in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformPropertyName("day_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DayOfWeek { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartDate { get; set; } = default!;

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformPropertyName("utc_offset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UtcOffset { get; set; }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformPropertyName("week_index")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WeekIndex { get; set; }

}

/// <summary>
/// Block type for maintenance_window_node_os in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowNodeOsBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformPropertyName("day_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DayOfWeek { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartDate { get; set; } = default!;

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformPropertyName("utc_offset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UtcOffset { get; set; }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformPropertyName("week_index")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WeekIndex { get; set; }

}

/// <summary>
/// Block type for microsoft_defender in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMicrosoftDefenderBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

}

/// <summary>
/// Block type for monitor_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMonitorMetricsBlock
{
    /// <summary>
    /// The annotations_allowed attribute.
    /// </summary>
    [TerraformPropertyName("annotations_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AnnotationsAllowed { get; set; }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    [TerraformPropertyName("labels_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LabelsAllowed { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlock
{
    /// <summary>
    /// The dns_service_ip attribute.
    /// </summary>
    [TerraformPropertyName("dns_service_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DnsServiceIp { get; set; } = default!;

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    [TerraformPropertyName("ip_versions")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> IpVersions { get; set; } = default!;

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancerSku { get; set; }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    [TerraformPropertyName("network_data_plane")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkDataPlane { get; set; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkMode { get; set; } = default!;

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    [TerraformPropertyName("network_plugin")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkPlugin { get; set; }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_plugin_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkPluginMode { get; set; }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    [TerraformPropertyName("network_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkPolicy { get; set; } = default!;

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformPropertyName("outbound_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundType { get; set; }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [TerraformPropertyName("pod_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PodCidr { get; set; } = default!;

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("pod_cidrs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> PodCidrs { get; set; } = default!;

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [TerraformPropertyName("service_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceCidr { get; set; } = default!;

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("service_cidrs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ServiceCidrs { get; set; } = default!;

}

/// <summary>
/// Block type for oms_agent in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterOmsAgentBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("msi_auth_for_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MsiAuthForMonitoringEnabled { get; set; }


}

/// <summary>
/// Block type for service_mesh_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServiceMeshProfileBlock
{
    /// <summary>
    /// The external_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformPropertyName("external_ingress_gateway_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExternalIngressGatewayEnabled { get; set; }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internal_ingress_gateway_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternalIngressGatewayEnabled { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    [TerraformPropertyName("revisions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Revisions { get; set; }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServicePrincipalBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientSecret { get; set; }

}

/// <summary>
/// Block type for storage_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterStorageProfileBlock
{
    /// <summary>
    /// The blob_driver_enabled attribute.
    /// </summary>
    [TerraformPropertyName("blob_driver_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BlobDriverEnabled { get; set; }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    [TerraformPropertyName("disk_driver_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DiskDriverEnabled { get; set; }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    [TerraformPropertyName("file_driver_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FileDriverEnabled { get; set; }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_controller_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SnapshotControllerEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterTimeoutsBlock
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
/// Block type for upgrade_override in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterUpgradeOverrideBlock
{
    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    [TerraformPropertyName("effective_until")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EffectiveUntil { get; set; }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    [TerraformPropertyName("force_upgrade_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ForceUpgradeEnabled { get; set; }

}

/// <summary>
/// Block type for web_app_routing in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWebAppRoutingBlock
{
    /// <summary>
    /// The default_nginx_controller attribute.
    /// </summary>
    [TerraformPropertyName("default_nginx_controller")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultNginxController { get; set; }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    [TerraformPropertyName("dns_zone_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? DnsZoneIds { get; set; }


}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWindowsProfileBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformPropertyName("admin_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The license attribute.
    /// </summary>
    [TerraformPropertyName("license")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? License { get; set; }

}

/// <summary>
/// Block type for workload_autoscaler_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWorkloadAutoscalerProfileBlock
{
    /// <summary>
    /// The keda_enabled attribute.
    /// </summary>
    [TerraformPropertyName("keda_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? KedaEnabled { get; set; }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vertical_pod_autoscaler_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VerticalPodAutoscalerEnabled { get; set; }

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
    [TerraformPropertyName("ai_toolchain_operator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AiToolchainOperatorEnabled { get; set; }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_channel")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutomaticUpgradeChannel { get; set; }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_policy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AzurePolicyEnabled { get; set; }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cost_analysis_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CostAnalysisEnabled { get; set; }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    [TerraformPropertyName("custom_ca_trust_certificates_base64")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CustomCaTrustCertificatesBase64 { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("dns_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsPrefix { get; set; }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    [TerraformPropertyName("dns_prefix_private_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsPrefixPrivateCluster { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpApplicationRoutingEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_cleaner_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_cleaner_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImageCleanerEnabled { get; set; }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    [TerraformPropertyName("image_cleaner_interval_hours")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ImageCleanerIntervalHours { get; set; }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KubernetesVersion { get; set; } = default!;

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    [TerraformPropertyName("local_account_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAccountDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    [TerraformPropertyName("node_os_upgrade_channel")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodeOsUpgradeChannel { get; set; }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeResourceGroup { get; set; } = default!;

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OidcIssuerEnabled { get; set; }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformPropertyName("open_service_mesh_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OpenServiceMeshEnabled { get; set; }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_cluster_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateClusterEnabled { get; set; }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_cluster_public_fqdn_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateClusterPublicFqdnEnabled { get; set; }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_zone_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateDnsZoneId { get; set; } = default!;

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("role_based_access_control_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RoleBasedAccessControlEnabled { get; set; }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    [TerraformPropertyName("run_command_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RunCommandEnabled { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SkuTier { get; set; }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    [TerraformPropertyName("support_plan")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SupportPlan { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workload_identity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("workload_identity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WorkloadIdentityEnabled { get; set; }

    /// <summary>
    /// Block for aci_connector_linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    [TerraformPropertyName("aci_connector_linux")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterAciConnectorLinuxBlock>>? AciConnectorLinux { get; set; }

    /// <summary>
    /// Block for api_server_access_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    [TerraformPropertyName("api_server_access_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterApiServerAccessProfileBlock>>? ApiServerAccessProfile { get; set; }

    /// <summary>
    /// Block for auto_scaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    [TerraformPropertyName("auto_scaler_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterAutoScalerProfileBlock>>? AutoScalerProfile { get; set; }

    /// <summary>
    /// Block for azure_active_directory_role_based_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    [TerraformPropertyName("azure_active_directory_role_based_access_control")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>>? AzureActiveDirectoryRoleBasedAccessControl { get; set; }

    /// <summary>
    /// Block for bootstrap_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    [TerraformPropertyName("bootstrap_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterBootstrapProfileBlock>>? BootstrapProfile { get; set; }

    /// <summary>
    /// Block for confidential_computing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    [TerraformPropertyName("confidential_computing")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterConfidentialComputingBlock>>? ConfidentialComputing { get; set; }

    /// <summary>
    /// Block for default_node_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    [TerraformPropertyName("default_node_pool")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterDefaultNodePoolBlock>>? DefaultNodePool { get; set; }

    /// <summary>
    /// Block for http_proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    [TerraformPropertyName("http_proxy_config")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterHttpProxyConfigBlock>>? HttpProxyConfig { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for ingress_application_gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    [TerraformPropertyName("ingress_application_gateway")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterIngressApplicationGatewayBlock>>? IngressApplicationGateway { get; set; }

    /// <summary>
    /// Block for key_management_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    [TerraformPropertyName("key_management_service")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterKeyManagementServiceBlock>>? KeyManagementService { get; set; }

    /// <summary>
    /// Block for key_vault_secrets_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    [TerraformPropertyName("key_vault_secrets_provider")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>>? KeyVaultSecretsProvider { get; set; }

    /// <summary>
    /// Block for kubelet_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    [TerraformPropertyName("kubelet_identity")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterKubeletIdentityBlock>>? KubeletIdentity { get; set; }

    /// <summary>
    /// Block for linux_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    [TerraformPropertyName("linux_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterLinuxProfileBlock>>? LinuxProfile { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for maintenance_window_auto_upgrade.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    [TerraformPropertyName("maintenance_window_auto_upgrade")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>>? MaintenanceWindowAutoUpgrade { get; set; }

    /// <summary>
    /// Block for maintenance_window_node_os.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    [TerraformPropertyName("maintenance_window_node_os")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>>? MaintenanceWindowNodeOs { get; set; }

    /// <summary>
    /// Block for microsoft_defender.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    [TerraformPropertyName("microsoft_defender")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMicrosoftDefenderBlock>>? MicrosoftDefender { get; set; }

    /// <summary>
    /// Block for monitor_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    [TerraformPropertyName("monitor_metrics")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMonitorMetricsBlock>>? MonitorMetrics { get; set; }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformPropertyName("network_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNetworkProfileBlock>>? NetworkProfile { get; set; }

    /// <summary>
    /// Block for oms_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    [TerraformPropertyName("oms_agent")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterOmsAgentBlock>>? OmsAgent { get; set; }

    /// <summary>
    /// Block for service_mesh_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    [TerraformPropertyName("service_mesh_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterServiceMeshProfileBlock>>? ServiceMeshProfile { get; set; }

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformPropertyName("service_principal")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterServicePrincipalBlock>>? ServicePrincipal { get; set; }

    /// <summary>
    /// Block for storage_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    [TerraformPropertyName("storage_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterStorageProfileBlock>>? StorageProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    [TerraformPropertyName("upgrade_override")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterUpgradeOverrideBlock>>? UpgradeOverride { get; set; }

    /// <summary>
    /// Block for web_app_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    [TerraformPropertyName("web_app_routing")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterWebAppRoutingBlock>>? WebAppRouting { get; set; }

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformPropertyName("windows_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterWindowsProfileBlock>>? WindowsProfile { get; set; }

    /// <summary>
    /// Block for workload_autoscaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    [TerraformPropertyName("workload_autoscaler_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>>? WorkloadAutoscalerProfile { get; set; }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("current_kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrentKubernetesVersion => new TerraformReference(this, "current_kubernetes_version");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HttpApplicationRoutingZoneName => new TerraformReference(this, "http_application_routing_zone_name");

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KubeAdminConfig => new TerraformReference(this, "kube_admin_config");

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KubeAdminConfigRaw => new TerraformReference(this, "kube_admin_config_raw");

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KubeConfig => new TerraformReference(this, "kube_config");

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KubeConfigRaw => new TerraformReference(this, "kube_config_raw");

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeResourceGroupId => new TerraformReference(this, "node_resource_group_id");

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OidcIssuerUrl => new TerraformReference(this, "oidc_issuer_url");

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("portal_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalFqdn => new TerraformReference(this, "portal_fqdn");

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("private_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateFqdn => new TerraformReference(this, "private_fqdn");

}
