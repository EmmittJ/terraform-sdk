using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for aci_connector_linux in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAciConnectorLinuxBlock : ITerraformBlock
{
    /// <summary>
    /// The connector_identity attribute.
    /// </summary>
    [TerraformPropertyName("connector_identity")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectorIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "connector_identity");

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetName is required")]
    [TerraformPropertyName("subnet_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetName { get; set; }

}

/// <summary>
/// Block type for api_server_access_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterApiServerAccessProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The authorized_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("authorized_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AuthorizedIpRanges { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

    /// <summary>
    /// The virtual_network_integration_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_integration_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VirtualNetworkIntegrationEnabled { get; set; }

}

/// <summary>
/// Block type for auto_scaler_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAutoScalerProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The balance_similar_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("balance_similar_node_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// The daemonset_eviction_for_empty_nodes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("daemonset_eviction_for_empty_nodes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DaemonsetEvictionForEmptyNodesEnabled { get; set; }

    /// <summary>
    /// The daemonset_eviction_for_occupied_nodes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("daemonset_eviction_for_occupied_nodes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DaemonsetEvictionForOccupiedNodesEnabled { get; set; }

    /// <summary>
    /// The empty_bulk_delete_max attribute.
    /// </summary>
    [TerraformPropertyName("empty_bulk_delete_max")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EmptyBulkDeleteMax { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "empty_bulk_delete_max");

    /// <summary>
    /// The expander attribute.
    /// </summary>
    [TerraformPropertyName("expander")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expander { get; set; }

    /// <summary>
    /// The ignore_daemonsets_utilization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ignore_daemonsets_utilization_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreDaemonsetsUtilizationEnabled { get; set; }

    /// <summary>
    /// The max_graceful_termination_sec attribute.
    /// </summary>
    [TerraformPropertyName("max_graceful_termination_sec")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaxGracefulTerminationSec { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "max_graceful_termination_sec");

    /// <summary>
    /// The max_node_provisioning_time attribute.
    /// </summary>
    [TerraformPropertyName("max_node_provisioning_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxNodeProvisioningTime { get; set; }

    /// <summary>
    /// The max_unready_nodes attribute.
    /// </summary>
    [TerraformPropertyName("max_unready_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnreadyNodes { get; set; }

    /// <summary>
    /// The max_unready_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_unready_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnreadyPercentage { get; set; }

    /// <summary>
    /// The new_pod_scale_up_delay attribute.
    /// </summary>
    [TerraformPropertyName("new_pod_scale_up_delay")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NewPodScaleUpDelay { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "new_pod_scale_up_delay");

    /// <summary>
    /// The scale_down_delay_after_add attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_delay_after_add")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScaleDownDelayAfterAdd { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scale_down_delay_after_add");

    /// <summary>
    /// The scale_down_delay_after_delete attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_delay_after_delete")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScaleDownDelayAfterDelete { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scale_down_delay_after_delete");

    /// <summary>
    /// The scale_down_delay_after_failure attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_delay_after_failure")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScaleDownDelayAfterFailure { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scale_down_delay_after_failure");

    /// <summary>
    /// The scale_down_unneeded attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_unneeded")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScaleDownUnneeded { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scale_down_unneeded");

    /// <summary>
    /// The scale_down_unready attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_unready")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScaleDownUnready { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scale_down_unready");

    /// <summary>
    /// The scale_down_utilization_threshold attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_utilization_threshold")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScaleDownUtilizationThreshold { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scale_down_utilization_threshold");

    /// <summary>
    /// The scan_interval attribute.
    /// </summary>
    [TerraformPropertyName("scan_interval")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScanInterval { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scan_interval");

    /// <summary>
    /// The skip_nodes_with_local_storage attribute.
    /// </summary>
    [TerraformPropertyName("skip_nodes_with_local_storage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipNodesWithLocalStorage { get; set; }

    /// <summary>
    /// The skip_nodes_with_system_pods attribute.
    /// </summary>
    [TerraformPropertyName("skip_nodes_with_system_pods")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipNodesWithSystemPods { get; set; }

}

/// <summary>
/// Block type for azure_active_directory_role_based_access_control in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock : ITerraformBlock
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    [TerraformPropertyName("admin_group_object_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdminGroupObjectIds { get; set; }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_rbac_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AzureRbacEnabled { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TenantId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

}

/// <summary>
/// Block type for bootstrap_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterBootstrapProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The artifact_source attribute.
    /// </summary>
    [TerraformPropertyName("artifact_source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ArtifactSource { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerRegistryId { get; set; }

}

/// <summary>
/// Block type for confidential_computing in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterConfidentialComputingBlock : ITerraformBlock
{
    /// <summary>
    /// The sgx_quote_helper_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SgxQuoteHelperEnabled is required")]
    [TerraformPropertyName("sgx_quote_helper_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> SgxQuoteHelperEnabled { get; set; }

}

/// <summary>
/// Block type for default_node_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterDefaultNodePoolBlock : ITerraformBlock
{
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
    /// The kubelet_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("kubelet_disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KubeletDiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kubelet_disk_type");

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
    public TerraformProperty<TerraformProperty<double>> MaxPods { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_pods");

    /// <summary>
    /// The min_count attribute.
    /// </summary>
    [TerraformPropertyName("min_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinCount { get; set; }

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
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "node_count");

    /// <summary>
    /// The node_labels attribute.
    /// </summary>
    [TerraformPropertyName("node_labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> NodeLabels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "node_labels");

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
    /// The only_critical_addons_enabled attribute.
    /// </summary>
    [TerraformPropertyName("only_critical_addons_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OnlyCriticalAddonsEnabled { get; set; }

    /// <summary>
    /// The orchestrator_version attribute.
    /// </summary>
    [TerraformPropertyName("orchestrator_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrchestratorVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "orchestrator_version");

    /// <summary>
    /// The os_disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> OsDiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "os_disk_size_gb");

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
    public TerraformProperty<TerraformProperty<string>> OsSku { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "os_sku");

    /// <summary>
    /// The pod_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("pod_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PodSubnetId { get; set; }

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
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

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
    public TerraformProperty<TerraformProperty<string>> VmSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "vm_size");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WorkloadRuntime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "workload_runtime");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

}

/// <summary>
/// Block type for http_proxy_config in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterHttpProxyConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The http_proxy attribute.
    /// </summary>
    [TerraformPropertyName("http_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpProxy { get; set; }

    /// <summary>
    /// The https_proxy attribute.
    /// </summary>
    [TerraformPropertyName("https_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpsProxy { get; set; }

    /// <summary>
    /// The no_proxy attribute.
    /// </summary>
    [TerraformPropertyName("no_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NoProxy { get; set; }

    /// <summary>
    /// The trusted_ca attribute.
    /// </summary>
    [TerraformPropertyName("trusted_ca")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrustedCa { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for ingress_application_gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterIngressApplicationGatewayBlock : ITerraformBlock
{
    /// <summary>
    /// The effective_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("effective_gateway_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>("", "effective_gateway_id");

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GatewayId { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [TerraformPropertyName("gateway_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GatewayName { get; set; }

    /// <summary>
    /// The ingress_application_gateway_identity attribute.
    /// </summary>
    [TerraformPropertyName("ingress_application_gateway_identity")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IngressApplicationGatewayIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "ingress_application_gateway_identity");

    /// <summary>
    /// The subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("subnet_cidr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetCidr { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

}

/// <summary>
/// Block type for key_management_service in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyManagementServiceBlock : ITerraformBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformPropertyName("key_vault_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_network_access attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultNetworkAccess { get; set; }

}

/// <summary>
/// Block type for key_vault_secrets_provider in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKeyVaultSecretsProviderBlock : ITerraformBlock
{
    /// <summary>
    /// The secret_identity attribute.
    /// </summary>
    [TerraformPropertyName("secret_identity")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecretIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "secret_identity");

    /// <summary>
    /// The secret_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secret_rotation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SecretRotationEnabled { get; set; }

    /// <summary>
    /// The secret_rotation_interval attribute.
    /// </summary>
    [TerraformPropertyName("secret_rotation_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretRotationInterval { get; set; }

}

/// <summary>
/// Block type for kubelet_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterKubeletIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClientId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "client_id");

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "object_id");

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserAssignedIdentityId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "user_assigned_identity_id");

}

/// <summary>
/// Block type for linux_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterLinuxProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdminUsername { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for maintenance_window_auto_upgrade in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformPropertyName("day_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DayOfWeek { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Duration { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Interval { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "start_date");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartTime { get; set; }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformPropertyName("utc_offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UtcOffset { get; set; }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformPropertyName("week_index")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WeekIndex { get; set; }

}

/// <summary>
/// Block type for maintenance_window_node_os in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMaintenanceWindowNodeOsBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformPropertyName("day_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DayOfWeek { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Duration { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Interval { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "start_date");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartTime { get; set; }

    /// <summary>
    /// The utc_offset attribute.
    /// </summary>
    [TerraformPropertyName("utc_offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UtcOffset { get; set; }

    /// <summary>
    /// The week_index attribute.
    /// </summary>
    [TerraformPropertyName("week_index")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WeekIndex { get; set; }

}

/// <summary>
/// Block type for microsoft_defender in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMicrosoftDefenderBlock : ITerraformBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogAnalyticsWorkspaceId { get; set; }

}

/// <summary>
/// Block type for monitor_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterMonitorMetricsBlock : ITerraformBlock
{
    /// <summary>
    /// The annotations_allowed attribute.
    /// </summary>
    [TerraformPropertyName("annotations_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AnnotationsAllowed { get; set; }

    /// <summary>
    /// The labels_allowed attribute.
    /// </summary>
    [TerraformPropertyName("labels_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LabelsAllowed { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterNetworkProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The dns_service_ip attribute.
    /// </summary>
    [TerraformPropertyName("dns_service_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DnsServiceIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "dns_service_ip");

    /// <summary>
    /// The ip_versions attribute.
    /// </summary>
    [TerraformPropertyName("ip_versions")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> IpVersions { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "ip_versions");

    /// <summary>
    /// The load_balancer_sku attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoadBalancerSku { get; set; }

    /// <summary>
    /// The network_data_plane attribute.
    /// </summary>
    [TerraformPropertyName("network_data_plane")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkDataPlane { get; set; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "network_mode");

    /// <summary>
    /// The network_plugin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkPlugin is required")]
    [TerraformPropertyName("network_plugin")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkPlugin { get; set; }

    /// <summary>
    /// The network_plugin_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_plugin_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkPluginMode { get; set; }

    /// <summary>
    /// The network_policy attribute.
    /// </summary>
    [TerraformPropertyName("network_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "network_policy");

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformPropertyName("outbound_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutboundType { get; set; }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [TerraformPropertyName("pod_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PodCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "pod_cidr");

    /// <summary>
    /// The pod_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("pod_cidrs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> PodCidrs { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "pod_cidrs");

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [TerraformPropertyName("service_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_cidr");

    /// <summary>
    /// The service_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("service_cidrs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ServiceCidrs { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "service_cidrs");

}

/// <summary>
/// Block type for oms_agent in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterOmsAgentBlock : ITerraformBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The msi_auth_for_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("msi_auth_for_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MsiAuthForMonitoringEnabled { get; set; }

    /// <summary>
    /// The oms_agent_identity attribute.
    /// </summary>
    [TerraformPropertyName("oms_agent_identity")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OmsAgentIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "oms_agent_identity");

}

/// <summary>
/// Block type for service_mesh_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServiceMeshProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The external_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformPropertyName("external_ingress_gateway_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExternalIngressGatewayEnabled { get; set; }

    /// <summary>
    /// The internal_ingress_gateway_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internal_ingress_gateway_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternalIngressGatewayEnabled { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

    /// <summary>
    /// The revisions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revisions is required")]
    [TerraformPropertyName("revisions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Revisions { get; set; }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterServicePrincipalBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientSecret { get; set; }

}

/// <summary>
/// Block type for storage_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterStorageProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The blob_driver_enabled attribute.
    /// </summary>
    [TerraformPropertyName("blob_driver_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BlobDriverEnabled { get; set; }

    /// <summary>
    /// The disk_driver_enabled attribute.
    /// </summary>
    [TerraformPropertyName("disk_driver_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DiskDriverEnabled { get; set; }

    /// <summary>
    /// The file_driver_enabled attribute.
    /// </summary>
    [TerraformPropertyName("file_driver_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FileDriverEnabled { get; set; }

    /// <summary>
    /// The snapshot_controller_enabled attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_controller_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SnapshotControllerEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterTimeoutsBlock : ITerraformBlock
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
/// Block type for upgrade_override in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterUpgradeOverrideBlock : ITerraformBlock
{
    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    [TerraformPropertyName("effective_until")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EffectiveUntil { get; set; }

    /// <summary>
    /// The force_upgrade_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceUpgradeEnabled is required")]
    [TerraformPropertyName("force_upgrade_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ForceUpgradeEnabled { get; set; }

}

/// <summary>
/// Block type for web_app_routing in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWebAppRoutingBlock : ITerraformBlock
{
    /// <summary>
    /// The default_nginx_controller attribute.
    /// </summary>
    [TerraformPropertyName("default_nginx_controller")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultNginxController { get; set; }

    /// <summary>
    /// The dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneIds is required")]
    [TerraformPropertyName("dns_zone_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? DnsZoneIds { get; set; }

    /// <summary>
    /// The web_app_routing_identity attribute.
    /// </summary>
    [TerraformPropertyName("web_app_routing_identity")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WebAppRoutingIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "web_app_routing_identity");

}

/// <summary>
/// Block type for windows_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWindowsProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformPropertyName("admin_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdminUsername { get; set; }

    /// <summary>
    /// The license attribute.
    /// </summary>
    [TerraformPropertyName("license")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? License { get; set; }

}

/// <summary>
/// Block type for workload_autoscaler_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterWorkloadAutoscalerProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The keda_enabled attribute.
    /// </summary>
    [TerraformPropertyName("keda_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? KedaEnabled { get; set; }

    /// <summary>
    /// The vertical_pod_autoscaler_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vertical_pod_autoscaler_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VerticalPodAutoscalerEnabled { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AiToolchainOperatorEnabled { get; set; }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_channel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutomaticUpgradeChannel { get; set; }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_policy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AzurePolicyEnabled { get; set; }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cost_analysis_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CostAnalysisEnabled { get; set; }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    [TerraformPropertyName("custom_ca_trust_certificates_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CustomCaTrustCertificatesBase64 { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("dns_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsPrefix { get; set; }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    [TerraformPropertyName("dns_prefix_private_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsPrefixPrivateCluster { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HttpApplicationRoutingEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_cleaner_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_cleaner_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ImageCleanerEnabled { get; set; }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    [TerraformPropertyName("image_cleaner_interval_hours")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ImageCleanerIntervalHours { get; set; }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KubernetesVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kubernetes_version");

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    [TerraformPropertyName("local_account_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalAccountDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    [TerraformPropertyName("node_os_upgrade_channel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeOsUpgradeChannel { get; set; }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NodeResourceGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_resource_group");

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OidcIssuerEnabled { get; set; }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformPropertyName("open_service_mesh_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OpenServiceMeshEnabled { get; set; }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_cluster_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateClusterEnabled { get; set; }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_cluster_public_fqdn_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateClusterPublicFqdnEnabled { get; set; }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_zone_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateDnsZoneId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns_zone_id");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("role_based_access_control_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RoleBasedAccessControlEnabled { get; set; }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    [TerraformPropertyName("run_command_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunCommandEnabled { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SkuTier { get; set; }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    [TerraformPropertyName("support_plan")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SupportPlan { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The workload_identity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("workload_identity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WorkloadIdentityEnabled { get; set; }

    /// <summary>
    /// Block for aci_connector_linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AciConnectorLinux block(s) allowed")]
    [TerraformPropertyName("aci_connector_linux")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterAciConnectorLinuxBlock>>? AciConnectorLinux { get; set; } = new();

    /// <summary>
    /// Block for api_server_access_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerAccessProfile block(s) allowed")]
    [TerraformPropertyName("api_server_access_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterApiServerAccessProfileBlock>>? ApiServerAccessProfile { get; set; } = new();

    /// <summary>
    /// Block for auto_scaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalerProfile block(s) allowed")]
    [TerraformPropertyName("auto_scaler_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterAutoScalerProfileBlock>>? AutoScalerProfile { get; set; } = new();

    /// <summary>
    /// Block for azure_active_directory_role_based_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryRoleBasedAccessControl block(s) allowed")]
    [TerraformPropertyName("azure_active_directory_role_based_access_control")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterAzureActiveDirectoryRoleBasedAccessControlBlock>>? AzureActiveDirectoryRoleBasedAccessControl { get; set; } = new();

    /// <summary>
    /// Block for bootstrap_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootstrapProfile block(s) allowed")]
    [TerraformPropertyName("bootstrap_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterBootstrapProfileBlock>>? BootstrapProfile { get; set; } = new();

    /// <summary>
    /// Block for confidential_computing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialComputing block(s) allowed")]
    [TerraformPropertyName("confidential_computing")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterConfidentialComputingBlock>>? ConfidentialComputing { get; set; } = new();

    /// <summary>
    /// Block for default_node_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNodePool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultNodePool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultNodePool block(s) allowed")]
    [TerraformPropertyName("default_node_pool")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterDefaultNodePoolBlock>>? DefaultNodePool { get; set; } = new();

    /// <summary>
    /// Block for http_proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpProxyConfig block(s) allowed")]
    [TerraformPropertyName("http_proxy_config")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterHttpProxyConfigBlock>>? HttpProxyConfig { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress_application_gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressApplicationGateway block(s) allowed")]
    [TerraformPropertyName("ingress_application_gateway")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterIngressApplicationGatewayBlock>>? IngressApplicationGateway { get; set; } = new();

    /// <summary>
    /// Block for key_management_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyManagementService block(s) allowed")]
    [TerraformPropertyName("key_management_service")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterKeyManagementServiceBlock>>? KeyManagementService { get; set; } = new();

    /// <summary>
    /// Block for key_vault_secrets_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultSecretsProvider block(s) allowed")]
    [TerraformPropertyName("key_vault_secrets_provider")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterKeyVaultSecretsProviderBlock>>? KeyVaultSecretsProvider { get; set; } = new();

    /// <summary>
    /// Block for kubelet_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletIdentity block(s) allowed")]
    [TerraformPropertyName("kubelet_identity")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterKubeletIdentityBlock>>? KubeletIdentity { get; set; } = new();

    /// <summary>
    /// Block for linux_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxProfile block(s) allowed")]
    [TerraformPropertyName("linux_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterLinuxProfileBlock>>? LinuxProfile { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_auto_upgrade.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowAutoUpgrade block(s) allowed")]
    [TerraformPropertyName("maintenance_window_auto_upgrade")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMaintenanceWindowAutoUpgradeBlock>>? MaintenanceWindowAutoUpgrade { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_node_os.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowNodeOs block(s) allowed")]
    [TerraformPropertyName("maintenance_window_node_os")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMaintenanceWindowNodeOsBlock>>? MaintenanceWindowNodeOs { get; set; } = new();

    /// <summary>
    /// Block for microsoft_defender.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftDefender block(s) allowed")]
    [TerraformPropertyName("microsoft_defender")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMicrosoftDefenderBlock>>? MicrosoftDefender { get; set; } = new();

    /// <summary>
    /// Block for monitor_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorMetrics block(s) allowed")]
    [TerraformPropertyName("monitor_metrics")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterMonitorMetricsBlock>>? MonitorMetrics { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformPropertyName("network_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterNetworkProfileBlock>>? NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for oms_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OmsAgent block(s) allowed")]
    [TerraformPropertyName("oms_agent")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterOmsAgentBlock>>? OmsAgent { get; set; } = new();

    /// <summary>
    /// Block for service_mesh_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceMeshProfile block(s) allowed")]
    [TerraformPropertyName("service_mesh_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterServiceMeshProfileBlock>>? ServiceMeshProfile { get; set; } = new();

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformPropertyName("service_principal")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterServicePrincipalBlock>>? ServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for storage_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfile block(s) allowed")]
    [TerraformPropertyName("storage_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterStorageProfileBlock>>? StorageProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeOverride block(s) allowed")]
    [TerraformPropertyName("upgrade_override")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterUpgradeOverrideBlock>>? UpgradeOverride { get; set; } = new();

    /// <summary>
    /// Block for web_app_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAppRouting block(s) allowed")]
    [TerraformPropertyName("web_app_routing")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterWebAppRoutingBlock>>? WebAppRouting { get; set; } = new();

    /// <summary>
    /// Block for windows_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsProfile block(s) allowed")]
    [TerraformPropertyName("windows_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterWindowsProfileBlock>>? WindowsProfile { get; set; } = new();

    /// <summary>
    /// Block for workload_autoscaler_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadAutoscalerProfile block(s) allowed")]
    [TerraformPropertyName("workload_autoscaler_profile")]
    public TerraformList<TerraformBlock<AzurermKubernetesClusterWorkloadAutoscalerProfileBlock>>? WorkloadAutoscalerProfile { get; set; } = new();

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("current_kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentKubernetesVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_kubernetes_version");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpApplicationRoutingZoneName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "http_application_routing_zone_name");

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KubeAdminConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kube_admin_config");

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubeAdminConfigRaw => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kube_admin_config_raw");

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KubeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kube_config");

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubeConfigRaw => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kube_config_raw");

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeResourceGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_resource_group_id");

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OidcIssuerUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oidc_issuer_url");

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("portal_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PortalFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "portal_fqdn");

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("private_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_fqdn");

}
