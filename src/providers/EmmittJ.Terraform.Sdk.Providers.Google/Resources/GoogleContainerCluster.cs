using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "addons_config";

    /// <summary>
    /// CloudrunConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudrunConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockCloudrunConfigBlock>? CloudrunConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockCloudrunConfigBlock>>("cloudrun_config");
        set => SetArgument("cloudrun_config", value);
    }

    /// <summary>
    /// ConfigConnectorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigConnectorConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockConfigConnectorConfigBlock>? ConfigConnectorConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockConfigConnectorConfigBlock>>("config_connector_config");
        set => SetArgument("config_connector_config", value);
    }

    /// <summary>
    /// DnsCacheConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsCacheConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockDnsCacheConfigBlock>? DnsCacheConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockDnsCacheConfigBlock>>("dns_cache_config");
        set => SetArgument("dns_cache_config", value);
    }

    /// <summary>
    /// GcePersistentDiskCsiDriverConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcePersistentDiskCsiDriverConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockGcePersistentDiskCsiDriverConfigBlock>? GcePersistentDiskCsiDriverConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockGcePersistentDiskCsiDriverConfigBlock>>("gce_persistent_disk_csi_driver_config");
        set => SetArgument("gce_persistent_disk_csi_driver_config", value);
    }

    /// <summary>
    /// GcpFilestoreCsiDriverConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpFilestoreCsiDriverConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockGcpFilestoreCsiDriverConfigBlock>? GcpFilestoreCsiDriverConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockGcpFilestoreCsiDriverConfigBlock>>("gcp_filestore_csi_driver_config");
        set => SetArgument("gcp_filestore_csi_driver_config", value);
    }

    /// <summary>
    /// GcsFuseCsiDriverConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsFuseCsiDriverConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockGcsFuseCsiDriverConfigBlock>? GcsFuseCsiDriverConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockGcsFuseCsiDriverConfigBlock>>("gcs_fuse_csi_driver_config");
        set => SetArgument("gcs_fuse_csi_driver_config", value);
    }

    /// <summary>
    /// GkeBackupAgentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeBackupAgentConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockGkeBackupAgentConfigBlock>? GkeBackupAgentConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockGkeBackupAgentConfigBlock>>("gke_backup_agent_config");
        set => SetArgument("gke_backup_agent_config", value);
    }

    /// <summary>
    /// HorizontalPodAutoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HorizontalPodAutoscaling block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockHorizontalPodAutoscalingBlock>? HorizontalPodAutoscaling
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockHorizontalPodAutoscalingBlock>>("horizontal_pod_autoscaling");
        set => SetArgument("horizontal_pod_autoscaling", value);
    }

    /// <summary>
    /// HttpLoadBalancing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpLoadBalancing block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockHttpLoadBalancingBlock>? HttpLoadBalancing
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockHttpLoadBalancingBlock>>("http_load_balancing");
        set => SetArgument("http_load_balancing", value);
    }

    /// <summary>
    /// LustreCsiDriverConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LustreCsiDriverConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockLustreCsiDriverConfigBlock>? LustreCsiDriverConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockLustreCsiDriverConfigBlock>>("lustre_csi_driver_config");
        set => SetArgument("lustre_csi_driver_config", value);
    }

    /// <summary>
    /// NetworkPolicyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPolicyConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockNetworkPolicyConfigBlock>? NetworkPolicyConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockNetworkPolicyConfigBlock>>("network_policy_config");
        set => SetArgument("network_policy_config", value);
    }

    /// <summary>
    /// ParallelstoreCsiDriverConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelstoreCsiDriverConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockParallelstoreCsiDriverConfigBlock>? ParallelstoreCsiDriverConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockParallelstoreCsiDriverConfigBlock>>("parallelstore_csi_driver_config");
        set => SetArgument("parallelstore_csi_driver_config", value);
    }

    /// <summary>
    /// RayOperatorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 RayOperatorConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlock>? RayOperatorConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlock>>("ray_operator_config");
        set => SetArgument("ray_operator_config", value);
    }

    /// <summary>
    /// StatefulHaConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StatefulHaConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockStatefulHaConfigBlock>? StatefulHaConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockStatefulHaConfigBlock>>("stateful_ha_config");
        set => SetArgument("stateful_ha_config", value);
    }

}

/// <summary>
/// Block type for cloudrun_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockCloudrunConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudrun_config";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

}

/// <summary>
/// Block type for config_connector_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockConfigConnectorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_connector_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for dns_cache_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockDnsCacheConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_cache_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gce_persistent_disk_csi_driver_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockGcePersistentDiskCsiDriverConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gce_persistent_disk_csi_driver_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gcp_filestore_csi_driver_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockGcpFilestoreCsiDriverConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_filestore_csi_driver_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gcs_fuse_csi_driver_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockGcsFuseCsiDriverConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_fuse_csi_driver_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gke_backup_agent_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockGkeBackupAgentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_backup_agent_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for horizontal_pod_autoscaling in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockHorizontalPodAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "horizontal_pod_autoscaling";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}

/// <summary>
/// Block type for http_load_balancing in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockHttpLoadBalancingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_load_balancing";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}

/// <summary>
/// Block type for lustre_csi_driver_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockLustreCsiDriverConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lustre_csi_driver_config";

    /// <summary>
    /// If set to true, the Lustre CSI driver will initialize LNet (the virtual network layer for Lustre kernel module) using port 6988.
    /// 										This flag is required to workaround a port conflict with the gke-metadata-server on GKE nodes.
    /// </summary>
    public TerraformValue<bool>? EnableLegacyLustrePort
    {
        get => GetArgument<TerraformValue<bool>>("enable_legacy_lustre_port");
        set => SetArgument("enable_legacy_lustre_port", value);
    }

    /// <summary>
    /// Whether the Lustre CSI driver is enabled for this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for network_policy_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockNetworkPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_policy_config";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}

/// <summary>
/// Block type for parallelstore_csi_driver_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockParallelstoreCsiDriverConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parallelstore_csi_driver_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for ray_operator_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ray_operator_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// RayClusterLoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RayClusterLoggingConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlockRayClusterLoggingConfigBlock>? RayClusterLoggingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlockRayClusterLoggingConfigBlock>>("ray_cluster_logging_config");
        set => SetArgument("ray_cluster_logging_config", value);
    }

    /// <summary>
    /// RayClusterMonitoringConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RayClusterMonitoringConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlockRayClusterMonitoringConfigBlock>? RayClusterMonitoringConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlockRayClusterMonitoringConfigBlock>>("ray_cluster_monitoring_config");
        set => SetArgument("ray_cluster_monitoring_config", value);
    }

}

/// <summary>
/// Block type for ray_cluster_logging_config in GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlockRayClusterLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ray_cluster_logging_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for ray_cluster_monitoring_config in GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockRayOperatorConfigBlockRayClusterMonitoringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ray_cluster_monitoring_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for stateful_ha_config in GoogleContainerClusterAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlockStatefulHaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_ha_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for anonymous_authentication_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAnonymousAuthenticationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "anonymous_authentication_config";

    /// <summary>
    /// Setting this to LIMITED will restrict authentication of anonymous users to health check endpoints only.
    ///  Accepted values are:
    /// * ENABLED: Authentication of anonymous users is enabled for all endpoints.
    /// * LIMITED: Anonymous access is only allowed for health check endpoints.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for authenticator_groups_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAuthenticatorGroupsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authenticator_groups_config";

    /// <summary>
    /// The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroup is required")]
    public required TerraformValue<string> SecurityGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("security_group");
        set => SetArgument("security_group", value);
    }

}


/// <summary>
/// Block type for binary_authorization in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_authorization";

    /// <summary>
    /// Enable Binary Authorization for this cluster.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation.
    /// </summary>
    public TerraformValue<string> EvaluationMode
    {
        get => GetArgument<TerraformValue<string>>("evaluation_mode") ?? AsReference("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
    }

}


/// <summary>
/// Block type for cluster_autoscaling in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_autoscaling";

    /// <summary>
    /// The list of Google Compute Engine zones in which the NodePool&#39;s nodes can be created by NAP.
    /// </summary>
    public TerraformList<string> AutoProvisioningLocations
    {
        get => GetArgument<TerraformList<string>>("auto_provisioning_locations") ?? AsReference("auto_provisioning_locations");
        set => SetArgument("auto_provisioning_locations", value);
    }

    /// <summary>
    /// Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.
    /// </summary>
    public TerraformValue<string>? AutoscalingProfile
    {
        get => GetArgument<TerraformValue<string>>("autoscaling_profile");
        set => SetArgument("autoscaling_profile", value);
    }

    /// <summary>
    /// Specifies whether default compute class behaviour is enabled. If enabled, cluster autoscaler will use Compute Class with name default for all the workloads, if not overriden.
    /// </summary>
    public TerraformValue<bool>? DefaultComputeClassEnabled
    {
        get => GetArgument<TerraformValue<bool>>("default_compute_class_enabled");
        set => SetArgument("default_compute_class_enabled", value);
    }

    /// <summary>
    /// Whether node auto-provisioning is enabled. Resource limits for cpu and memory must be defined to enable node auto-provisioning.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? AsReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// AutoProvisioningDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoProvisioningDefaults block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlock>? AutoProvisioningDefaults
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlock>>("auto_provisioning_defaults");
        set => SetArgument("auto_provisioning_defaults", value);
    }

    /// <summary>
    /// ResourceLimits block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockResourceLimitsBlock>? ResourceLimits
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockResourceLimitsBlock>>("resource_limits");
        set => SetArgument("resource_limits", value);
    }

}

/// <summary>
/// Block type for auto_provisioning_defaults in GoogleContainerClusterClusterAutoscalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_provisioning_defaults";

    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    public TerraformValue<string>? BootDiskKmsKey
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_kms_key");
        set => SetArgument("boot_disk_kms_key", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double>? DiskSize
    {
        get => GetArgument<TerraformValue<double>>("disk_size");
        set => SetArgument("disk_size", value);
    }

    /// <summary>
    /// Type of the disk attached to each node.
    /// </summary>
    public TerraformValue<string>? DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// The default image type used by NAP once a new node pool is being created.
    /// </summary>
    public TerraformValue<string>? ImageType
    {
        get => GetArgument<TerraformValue<string>>("image_type");
        set => SetArgument("image_type", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell.
    /// </summary>
    public TerraformValue<string>? MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Scopes that are used by NAP when creating node pools.
    /// </summary>
    public TerraformList<string> OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes") ?? AsReference("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockManagementBlock>? Management
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// UpgradeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlock>>("upgrade_settings");
        set => SetArgument("upgrade_settings", value);
    }

}

/// <summary>
/// Block type for management in GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// Specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.
    /// </summary>
    public TerraformValue<bool> AutoRepair
    {
        get => GetArgument<TerraformValue<bool>>("auto_repair") ?? AsReference("auto_repair");
        set => SetArgument("auto_repair", value);
    }

    /// <summary>
    /// Specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.
    /// </summary>
    public TerraformValue<bool> AutoUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("auto_upgrade") ?? AsReference("auto_upgrade");
        set => SetArgument("auto_upgrade", value);
    }

    /// <summary>
    /// Specifies the Auto Upgrade knobs for the node pool.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradeOptions
        => AsReference("upgrade_options");

}

/// <summary>
/// Block type for shielded_instance_config in GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

}

/// <summary>
/// Block type for upgrade_settings in GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_settings";

    /// <summary>
    /// The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process.
    /// </summary>
    public TerraformValue<double>? MaxSurge
    {
        get => GetArgument<TerraformValue<double>>("max_surge");
        set => SetArgument("max_surge", value);
    }

    /// <summary>
    /// The maximum number of nodes that can be simultaneously unavailable during the upgrade process.
    /// </summary>
    public TerraformValue<double>? MaxUnavailable
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable");
        set => SetArgument("max_unavailable", value);
    }

    /// <summary>
    /// Update strategy of the node pool.
    /// </summary>
    public TerraformValue<string> Strategy
    {
        get => GetArgument<TerraformValue<string>>("strategy") ?? AsReference("strategy");
        set => SetArgument("strategy", value);
    }

    /// <summary>
    /// BlueGreenSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenSettings block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlock>? BlueGreenSettings
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlock>>("blue_green_settings");
        set => SetArgument("blue_green_settings", value);
    }

}

/// <summary>
/// Block type for blue_green_settings in GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blue_green_settings";

    /// <summary>
    /// Time needed after draining entire blue pool. After this period, blue pool will be cleaned up.
    /// 
    /// 																A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> NodePoolSoakDuration
    {
        get => GetArgument<TerraformValue<string>>("node_pool_soak_duration") ?? AsReference("node_pool_soak_duration");
        set => SetArgument("node_pool_soak_duration", value);
    }

    /// <summary>
    /// StandardRolloutPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardRolloutPolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock>? StandardRolloutPolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock>>("standard_rollout_policy");
        set => SetArgument("standard_rollout_policy", value);
    }

}

/// <summary>
/// Block type for standard_rollout_policy in GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockAutoProvisioningDefaultsBlockUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_rollout_policy";

    /// <summary>
    /// Number of blue nodes to drain in a batch.
    /// </summary>
    public TerraformValue<double> BatchNodeCount
    {
        get => GetArgument<TerraformValue<double>>("batch_node_count") ?? AsReference("batch_node_count");
        set => SetArgument("batch_node_count", value);
    }

    /// <summary>
    /// Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0].
    /// </summary>
    public TerraformValue<double> BatchPercentage
    {
        get => GetArgument<TerraformValue<double>>("batch_percentage") ?? AsReference("batch_percentage");
        set => SetArgument("batch_percentage", value);
    }

    /// <summary>
    /// Soak time after each batch gets drained.
    /// 
    /// 																			A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? BatchSoakDuration
    {
        get => GetArgument<TerraformValue<string>>("batch_soak_duration");
        set => SetArgument("batch_soak_duration", value);
    }

}

/// <summary>
/// Block type for resource_limits in GoogleContainerClusterClusterAutoscalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlockResourceLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_limits";

    /// <summary>
    /// Maximum amount of the resource in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Maximum is required")]
    public required TerraformValue<double> Maximum
    {
        get => GetRequiredArgument<TerraformValue<double>>("maximum");
        set => SetArgument("maximum", value);
    }

    /// <summary>
    /// Minimum amount of the resource in the cluster.
    /// </summary>
    public TerraformValue<double>? Minimum
    {
        get => GetArgument<TerraformValue<double>>("minimum");
        set => SetArgument("minimum", value);
    }

    /// <summary>
    /// The type of the resource. For example, cpu and memory. See the guide to using Node Auto-Provisioning for a list of types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

}


/// <summary>
/// Block type for confidential_nodes in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterConfidentialNodesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_nodes";

    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    public TerraformValue<string>? ConfidentialInstanceType
    {
        get => GetArgument<TerraformValue<string>>("confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for control_plane_endpoints_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterControlPlaneEndpointsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_endpoints_config";

    /// <summary>
    /// DnsEndpointConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsEndpointConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlockDnsEndpointConfigBlock>? DnsEndpointConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlockDnsEndpointConfigBlock>>("dns_endpoint_config");
        set => SetArgument("dns_endpoint_config", value);
    }

    /// <summary>
    /// IpEndpointsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpEndpointsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlockIpEndpointsConfigBlock>? IpEndpointsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlockIpEndpointsConfigBlock>>("ip_endpoints_config");
        set => SetArgument("ip_endpoints_config", value);
    }

}

/// <summary>
/// Block type for dns_endpoint_config in GoogleContainerClusterControlPlaneEndpointsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterControlPlaneEndpointsConfigBlockDnsEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_endpoint_config";

    /// <summary>
    /// Controls whether user traffic is allowed over this endpoint. Note that GCP-managed services may still use the endpoint even if this is false.
    /// </summary>
    public TerraformValue<bool>? AllowExternalTraffic
    {
        get => GetArgument<TerraformValue<bool>>("allow_external_traffic");
        set => SetArgument("allow_external_traffic", value);
    }

    /// <summary>
    /// Controls whether the k8s certs auth is allowed via dns.
    /// </summary>
    public TerraformValue<bool>? EnableK8sCertsViaDns
    {
        get => GetArgument<TerraformValue<bool>>("enable_k8s_certs_via_dns");
        set => SetArgument("enable_k8s_certs_via_dns", value);
    }

    /// <summary>
    /// Controls whether the k8s token auth is allowed via dns.
    /// </summary>
    public TerraformValue<bool>? EnableK8sTokensViaDns
    {
        get => GetArgument<TerraformValue<bool>>("enable_k8s_tokens_via_dns");
        set => SetArgument("enable_k8s_tokens_via_dns", value);
    }

    /// <summary>
    /// The cluster&#39;s DNS endpoint.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint") ?? AsReference("endpoint");
        set => SetArgument("endpoint", value);
    }

}

/// <summary>
/// Block type for ip_endpoints_config in GoogleContainerClusterControlPlaneEndpointsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterControlPlaneEndpointsConfigBlockIpEndpointsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_endpoints_config";

    /// <summary>
    /// Controls whether to allow direct IP access.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for cost_management_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterCostManagementConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_management_config";

    /// <summary>
    /// Whether to enable GKE cost allocation. When you enable GKE cost allocation, the cluster name and namespace of your GKE workloads appear in the labels field of the billing export to BigQuery. Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for database_encryption in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDatabaseEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_encryption";

    /// <summary>
    /// The key to use to encrypt/decrypt secrets.
    /// </summary>
    public TerraformValue<string>? KeyName
    {
        get => GetArgument<TerraformValue<string>>("key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// ENCRYPTED or DECRYPTED.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetRequiredArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for default_snat_status in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDefaultSnatStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_snat_status";

    /// <summary>
    /// When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}


/// <summary>
/// Block type for dns_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_config";

    /// <summary>
    /// Enable additive VPC scope DNS in a GKE cluster.
    /// </summary>
    public TerraformValue<string>? AdditiveVpcScopeDnsDomain
    {
        get => GetArgument<TerraformValue<string>>("additive_vpc_scope_dns_domain");
        set => SetArgument("additive_vpc_scope_dns_domain", value);
    }

    /// <summary>
    /// Which in-cluster DNS provider should be used.
    /// </summary>
    public TerraformValue<string>? ClusterDns
    {
        get => GetArgument<TerraformValue<string>>("cluster_dns");
        set => SetArgument("cluster_dns", value);
    }

    /// <summary>
    /// The suffix used for all cluster service records.
    /// </summary>
    public TerraformValue<string>? ClusterDnsDomain
    {
        get => GetArgument<TerraformValue<string>>("cluster_dns_domain");
        set => SetArgument("cluster_dns_domain", value);
    }

    /// <summary>
    /// The scope of access to cluster DNS records.
    /// </summary>
    public TerraformValue<string>? ClusterDnsScope
    {
        get => GetArgument<TerraformValue<string>>("cluster_dns_scope");
        set => SetArgument("cluster_dns_scope", value);
    }

}


/// <summary>
/// Block type for enable_k8s_beta_apis in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterEnableK8sBetaApisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enable_k8s_beta_apis";

    /// <summary>
    /// Enabled Kubernetes Beta APIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledApis is required")]
    public required TerraformSet<string> EnabledApis
    {
        get => GetRequiredArgument<TerraformSet<string>>("enabled_apis");
        set => SetArgument("enabled_apis", value);
    }

}


/// <summary>
/// Block type for enterprise_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleContainerClusterEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enterprise_config";

    /// <summary>
    /// Indicates the effective cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ClusterTier
        => AsReference("cluster_tier");

    /// <summary>
    /// Indicates the desired cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> DesiredTier
    {
        get => GetArgument<TerraformValue<string>>("desired_tier") ?? AsReference("desired_tier");
        set => SetArgument("desired_tier", value);
    }

}


/// <summary>
/// Block type for fleet in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet";

    /// <summary>
    /// Full resource name of the registered fleet membership of the cluster.
    /// </summary>
    public TerraformValue<string> Membership
        => AsReference("membership");

    /// <summary>
    /// Short name of the fleet membership, for example &amp;quot;member-1&amp;quot;.
    /// </summary>
    public TerraformValue<string> MembershipId
        => AsReference("membership_id");

    /// <summary>
    /// Location of the fleet membership, for example &amp;quot;us-central1&amp;quot;.
    /// </summary>
    public TerraformValue<string> MembershipLocation
        => AsReference("membership_location");

    /// <summary>
    /// The type of the cluster&#39;s fleet membership.
    /// </summary>
    public TerraformValue<string>? MembershipType
    {
        get => GetArgument<TerraformValue<string>>("membership_type");
        set => SetArgument("membership_type", value);
    }

    /// <summary>
    /// Whether the cluster has been registered via the fleet API.
    /// </summary>
    public TerraformValue<bool> PreRegistered
        => AsReference("pre_registered");

    /// <summary>
    /// The Fleet host project of the cluster.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for gateway_api_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGatewayApiConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway_api_config";

    /// <summary>
    /// The Gateway API release channel to use for Gateway API.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformValue<string> Channel
    {
        get => GetRequiredArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

}


/// <summary>
/// Block type for gke_auto_upgrade_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGkeAutoUpgradeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_auto_upgrade_config";

    /// <summary>
    /// The selected auto-upgrade patch type. Accepted values are:
    /// * ACCELERATED: Upgrades to the latest available patch version in a given minor and release channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchMode is required")]
    public required TerraformValue<string> PatchMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("patch_mode");
        set => SetArgument("patch_mode", value);
    }

}


/// <summary>
/// Block type for identity_service_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIdentityServiceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_service_config";

    /// <summary>
    /// Whether to enable the Identity Service component.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for ip_allocation_policy in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_allocation_policy";

    /// <summary>
    /// The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    public TerraformValue<string> ClusterIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cluster_ipv4_cidr_block") ?? AsReference("cluster_ipv4_cidr_block");
        set => SetArgument("cluster_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    public TerraformValue<string> ClusterSecondaryRangeName
    {
        get => GetArgument<TerraformValue<string>>("cluster_secondary_range_name") ?? AsReference("cluster_secondary_range_name");
        set => SetArgument("cluster_secondary_range_name", value);
    }

    /// <summary>
    /// The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    public TerraformValue<string> ServicesIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("services_ipv4_cidr_block") ?? AsReference("services_ipv4_cidr_block");
        set => SetArgument("services_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    public TerraformValue<string> ServicesSecondaryRangeName
    {
        get => GetArgument<TerraformValue<string>>("services_secondary_range_name") ?? AsReference("services_secondary_range_name");
        set => SetArgument("services_secondary_range_name", value);
    }

    /// <summary>
    /// The IP Stack type of the cluster. Choose between IPV4 and IPV4_IPV6. Default type is IPV4 Only if not set
    /// </summary>
    public TerraformValue<string>? StackType
    {
        get => GetArgument<TerraformValue<string>>("stack_type");
        set => SetArgument("stack_type", value);
    }

    /// <summary>
    /// AdditionalIpRangesConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlockAdditionalIpRangesConfigBlock>? AdditionalIpRangesConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIpAllocationPolicyBlockAdditionalIpRangesConfigBlock>>("additional_ip_ranges_config");
        set => SetArgument("additional_ip_ranges_config", value);
    }

    /// <summary>
    /// AdditionalPodRangesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalPodRangesConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlockAdditionalPodRangesConfigBlock>? AdditionalPodRangesConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIpAllocationPolicyBlockAdditionalPodRangesConfigBlock>>("additional_pod_ranges_config");
        set => SetArgument("additional_pod_ranges_config", value);
    }

    /// <summary>
    /// AutoIpamConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoIpamConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlockAutoIpamConfigBlock>? AutoIpamConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIpAllocationPolicyBlockAutoIpamConfigBlock>>("auto_ipam_config");
        set => SetArgument("auto_ipam_config", value);
    }

    /// <summary>
    /// NetworkTierConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkTierConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlockNetworkTierConfigBlock>? NetworkTierConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIpAllocationPolicyBlockNetworkTierConfigBlock>>("network_tier_config");
        set => SetArgument("network_tier_config", value);
    }

    /// <summary>
    /// PodCidrOverprovisionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodCidrOverprovisionConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlockPodCidrOverprovisionConfigBlock>? PodCidrOverprovisionConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIpAllocationPolicyBlockPodCidrOverprovisionConfigBlock>>("pod_cidr_overprovision_config");
        set => SetArgument("pod_cidr_overprovision_config", value);
    }

}

/// <summary>
/// Block type for additional_ip_ranges_config in GoogleContainerClusterIpAllocationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlockAdditionalIpRangesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_ip_ranges_config";

    /// <summary>
    /// List of secondary ranges names within this subnetwork that can be used for pod IPs.
    /// </summary>
    public TerraformList<string>? PodIpv4RangeNames
    {
        get => GetArgument<TerraformList<string>>("pod_ipv4_range_names");
        set => SetArgument("pod_ipv4_range_names", value);
    }

    /// <summary>
    /// Name of the subnetwork. This can be the full path of the subnetwork or just the name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnetwork is required")]
    public required TerraformValue<string> Subnetwork
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

}

/// <summary>
/// Block type for additional_pod_ranges_config in GoogleContainerClusterIpAllocationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlockAdditionalPodRangesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_pod_ranges_config";

    /// <summary>
    /// Name for pod secondary ipv4 range which has the actual range defined ahead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodRangeNames is required")]
    public required TerraformSet<string> PodRangeNames
    {
        get => GetRequiredArgument<TerraformSet<string>>("pod_range_names");
        set => SetArgument("pod_range_names", value);
    }

}

/// <summary>
/// Block type for auto_ipam_config in GoogleContainerClusterIpAllocationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlockAutoIpamConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_ipam_config";

    /// <summary>
    /// The flag that enables Auto IPAM on this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for network_tier_config in GoogleContainerClusterIpAllocationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlockNetworkTierConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_tier_config";

    /// <summary>
    /// Network tier configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformValue<string> NetworkTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_tier");
        set => SetArgument("network_tier", value);
    }

}

/// <summary>
/// Block type for pod_cidr_overprovision_config in GoogleContainerClusterIpAllocationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlockPodCidrOverprovisionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_cidr_overprovision_config";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}


/// <summary>
/// Block type for logging_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// GKE components exposing logs. Valid values include SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, KCP_CONNECTION, KCP_SSHD, KCP_HPA, SCHEDULER, and WORKLOADS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableComponents is required")]
    public TerraformList<string>? EnableComponents
    {
        get => GetArgument<TerraformList<string>>("enable_components");
        set => SetArgument("enable_components", value);
    }

}


/// <summary>
/// Block type for maintenance_policy in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_policy";

    /// <summary>
    /// DailyMaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyMaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleContainerClusterMaintenancePolicyBlockDailyMaintenanceWindowBlock>? DailyMaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMaintenancePolicyBlockDailyMaintenanceWindowBlock>>("daily_maintenance_window");
        set => SetArgument("daily_maintenance_window", value);
    }

    /// <summary>
    /// MaintenanceExclusion block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 MaintenanceExclusion block(s) allowed")]
    public TerraformSet<GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlock>? MaintenanceExclusion
    {
        get => GetArgument<TerraformSet<GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlock>>("maintenance_exclusion");
        set => SetArgument("maintenance_exclusion", value);
    }

    /// <summary>
    /// RecurringWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringWindow block(s) allowed")]
    public TerraformList<GoogleContainerClusterMaintenancePolicyBlockRecurringWindowBlock>? RecurringWindow
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMaintenancePolicyBlockRecurringWindowBlock>>("recurring_window");
        set => SetArgument("recurring_window", value);
    }

}

/// <summary>
/// Block type for daily_maintenance_window in GoogleContainerClusterMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlockDailyMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_maintenance_window";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string> Duration
        => AsReference("duration");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for maintenance_exclusion in GoogleContainerClusterMaintenancePolicyBlock.
/// Nesting mode: set
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_exclusion";

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    public required TerraformValue<string> EndTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The exclusion_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExclusionName is required")]
    public required TerraformValue<string> ExclusionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("exclusion_name");
        set => SetArgument("exclusion_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// ExclusionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExclusionOptions block(s) allowed")]
    public TerraformList<GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlockExclusionOptionsBlock>? ExclusionOptions
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlockExclusionOptionsBlock>>("exclusion_options");
        set => SetArgument("exclusion_options", value);
    }

}

/// <summary>
/// Block type for exclusion_options in GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlockMaintenanceExclusionBlockExclusionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_options";

    /// <summary>
    /// The scope of automatic upgrades to restrict in the exclusion window.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for recurring_window in GoogleContainerClusterMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlockRecurringWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurring_window";

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    public required TerraformValue<string> EndTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Recurrence is required")]
    public required TerraformValue<string> Recurrence
    {
        get => GetRequiredArgument<TerraformValue<string>>("recurrence");
        set => SetArgument("recurrence", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for master_auth in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_auth";

    /// <summary>
    /// Base64 encoded public certificate used by clients to authenticate to the cluster endpoint.
    /// </summary>
    public TerraformValue<string> ClientCertificate
        => AsReference("client_certificate");

    /// <summary>
    /// Base64 encoded private key used by clients to authenticate to the cluster endpoint.
    /// </summary>
    public TerraformValue<string> ClientKey
        => AsReference("client_key");

    /// <summary>
    /// Base64 encoded public certificate that is the root of trust for the cluster.
    /// </summary>
    public TerraformValue<string> ClusterCaCertificate
        => AsReference("cluster_ca_certificate");

    /// <summary>
    /// ClientCertificateConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientCertificateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClientCertificateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificateConfig block(s) allowed")]
    public required TerraformList<GoogleContainerClusterMasterAuthBlockClientCertificateConfigBlock> ClientCertificateConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterMasterAuthBlockClientCertificateConfigBlock>>("client_certificate_config");
        set => SetArgument("client_certificate_config", value);
    }

}

/// <summary>
/// Block type for client_certificate_config in GoogleContainerClusterMasterAuthBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthBlockClientCertificateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate_config";

    /// <summary>
    /// Whether client certificate authorization is enabled for this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssueClientCertificate is required")]
    public required TerraformValue<bool> IssueClientCertificate
    {
        get => GetRequiredArgument<TerraformValue<bool>>("issue_client_certificate");
        set => SetArgument("issue_client_certificate", value);
    }

}


/// <summary>
/// Block type for master_authorized_networks_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthorizedNetworksConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_authorized_networks_config";

    /// <summary>
    /// Whether Kubernetes master is accessible via Google Compute Engine Public IPs.
    /// </summary>
    public TerraformValue<bool> GcpPublicCidrsAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("gcp_public_cidrs_access_enabled") ?? AsReference("gcp_public_cidrs_access_enabled");
        set => SetArgument("gcp_public_cidrs_access_enabled", value);
    }

    /// <summary>
    /// Whether authorized networks is enforced on the private endpoint or not. Defaults to false.
    /// </summary>
    public TerraformValue<bool> PrivateEndpointEnforcementEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_endpoint_enforcement_enabled") ?? AsReference("private_endpoint_enforcement_enabled");
        set => SetArgument("private_endpoint_enforcement_enabled", value);
    }

    /// <summary>
    /// CidrBlocks block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleContainerClusterMasterAuthorizedNetworksConfigBlockCidrBlocksBlock>? CidrBlocks
    {
        get => GetArgument<TerraformSet<GoogleContainerClusterMasterAuthorizedNetworksConfigBlockCidrBlocksBlock>>("cidr_blocks");
        set => SetArgument("cidr_blocks", value);
    }

}

/// <summary>
/// Block type for cidr_blocks in GoogleContainerClusterMasterAuthorizedNetworksConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleContainerClusterMasterAuthorizedNetworksConfigBlockCidrBlocksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cidr_blocks";

    /// <summary>
    /// External network that can access Kubernetes master through HTTPS. Must be specified in CIDR notation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlock is required")]
    public required TerraformValue<string> CidrBlock
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// Field for users to identify CIDR blocks.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

}


/// <summary>
/// Block type for mesh_certificates in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMeshCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mesh_certificates";

    /// <summary>
    /// When enabled the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableCertificates is required")]
    public required TerraformValue<bool> EnableCertificates
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_certificates");
        set => SetArgument("enable_certificates", value);
    }

}


/// <summary>
/// Block type for monitoring_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_config";

    /// <summary>
    /// GKE components exposing metrics. Valid values include SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET.
    /// </summary>
    public TerraformList<string> EnableComponents
    {
        get => GetArgument<TerraformList<string>>("enable_components") ?? AsReference("enable_components");
        set => SetArgument("enable_components", value);
    }

    /// <summary>
    /// AdvancedDatapathObservabilityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedDatapathObservabilityConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterMonitoringConfigBlockAdvancedDatapathObservabilityConfigBlock>? AdvancedDatapathObservabilityConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMonitoringConfigBlockAdvancedDatapathObservabilityConfigBlock>>("advanced_datapath_observability_config");
        set => SetArgument("advanced_datapath_observability_config", value);
    }

    /// <summary>
    /// ManagedPrometheus block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedPrometheus block(s) allowed")]
    public TerraformList<GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlock>? ManagedPrometheus
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlock>>("managed_prometheus");
        set => SetArgument("managed_prometheus", value);
    }

}

/// <summary>
/// Block type for advanced_datapath_observability_config in GoogleContainerClusterMonitoringConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlockAdvancedDatapathObservabilityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_datapath_observability_config";

    /// <summary>
    /// Whether or not the advanced datapath metrics are enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableMetrics is required")]
    public required TerraformValue<bool> EnableMetrics
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_metrics");
        set => SetArgument("enable_metrics", value);
    }

    /// <summary>
    /// Whether or not Relay is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableRelay is required")]
    public required TerraformValue<bool> EnableRelay
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_relay");
        set => SetArgument("enable_relay", value);
    }

}

/// <summary>
/// Block type for managed_prometheus in GoogleContainerClusterMonitoringConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_prometheus";

    /// <summary>
    /// Whether or not the managed collection is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// AutoMonitoringConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoMonitoringConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlockAutoMonitoringConfigBlock>? AutoMonitoringConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlockAutoMonitoringConfigBlock>>("auto_monitoring_config");
        set => SetArgument("auto_monitoring_config", value);
    }

}

/// <summary>
/// Block type for auto_monitoring_config in GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlockManagedPrometheusBlockAutoMonitoringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_monitoring_config";

    /// <summary>
    /// The scope of auto-monitoring.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Block type for network_performance_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_performance_config";

    /// <summary>
    /// Specifies the total network bandwidth tier for NodePools in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformValue<string> TotalEgressBandwidthTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("total_egress_bandwidth_tier");
        set => SetArgument("total_egress_bandwidth_tier", value);
    }

}


/// <summary>
/// Block type for network_policy in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_policy";

    /// <summary>
    /// Whether network policy is enabled on the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The selected network policy provider.
    /// </summary>
    public TerraformValue<string>? ProviderAttribute
    {
        get => GetArgument<TerraformValue<string>>("provider");
        set => SetArgument("provider", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    public TerraformValue<string>? BootDiskKmsKey
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_kms_key");
        set => SetArgument("boot_disk_kms_key", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? AsReference("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveTaints
        => AsReference("effective_taints");

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialStorage
    {
        get => GetArgument<TerraformValue<bool>>("enable_confidential_storage");
        set => SetArgument("enable_confidential_storage", value);
    }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    public TerraformValue<bool>? FlexStart
    {
        get => GetArgument<TerraformValue<bool>>("flex_start");
        set => SetArgument("flex_start", value);
    }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    public TerraformValue<string> ImageType
    {
        get => GetArgument<TerraformValue<string>>("image_type") ?? AsReference("image_type");
        set => SetArgument("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    public TerraformValue<double> LocalSsdCount
    {
        get => GetArgument<TerraformValue<double>>("local_ssd_count") ?? AsReference("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    public TerraformValue<string>? LocalSsdEncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("local_ssd_encryption_mode");
        set => SetArgument("local_ssd_encryption_mode", value);
    }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    public TerraformValue<string> LoggingVariant
    {
        get => GetArgument<TerraformValue<string>>("logging_variant") ?? AsReference("logging_variant");
        set => SetArgument("logging_variant", value);
    }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? AsReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxRunDuration
    {
        get => GetArgument<TerraformValue<string>>("max_run_duration");
        set => SetArgument("max_run_duration", value);
    }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata") ?? AsReference("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? AsReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    public TerraformValue<string>? NodeGroup
    {
        get => GetArgument<TerraformValue<string>>("node_group");
        set => SetArgument("node_group", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    public TerraformSet<string> OauthScopes
    {
        get => GetArgument<TerraformSet<string>>("oauth_scopes") ?? AsReference("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => GetArgument<TerraformValue<bool>>("preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    public TerraformMap<string>? ResourceLabels
    {
        get => GetArgument<TerraformMap<string>>("resource_labels");
        set => SetArgument("resource_labels", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? AsReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    public TerraformValue<bool>? Spot
    {
        get => GetArgument<TerraformValue<bool>>("spot");
        set => SetArgument("spot", value);
    }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    public TerraformList<string>? StoragePools
    {
        get => GetArgument<TerraformList<string>>("storage_pools");
        set => SetArgument("storage_pools", value);
    }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AdvancedMachineFeatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// BootDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockBootDiskBlock>? BootDisk
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockBootDiskBlock>>("boot_disk");
        set => SetArgument("boot_disk", value);
    }

    /// <summary>
    /// ConfidentialNodes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockConfidentialNodesBlock>? ConfidentialNodes
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockConfidentialNodesBlock>>("confidential_nodes");
        set => SetArgument("confidential_nodes", value);
    }

    /// <summary>
    /// ContainerdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerdConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlock>? ContainerdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlock>>("containerd_config");
        set => SetArgument("containerd_config", value);
    }

    /// <summary>
    /// EphemeralStorageLocalSsdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorageLocalSsdConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockEphemeralStorageLocalSsdConfigBlock>? EphemeralStorageLocalSsdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockEphemeralStorageLocalSsdConfigBlock>>("ephemeral_storage_local_ssd_config");
        set => SetArgument("ephemeral_storage_local_ssd_config", value);
    }

    /// <summary>
    /// FastSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FastSocket block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockFastSocketBlock>? FastSocket
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockFastSocketBlock>>("fast_socket");
        set => SetArgument("fast_socket", value);
    }

    /// <summary>
    /// GcfsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcfsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockGcfsConfigBlock>? GcfsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockGcfsConfigBlock>>("gcfs_config");
        set => SetArgument("gcfs_config", value);
    }

    /// <summary>
    /// GuestAccelerator block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlock>>("guest_accelerator");
        set => SetArgument("guest_accelerator", value);
    }

    /// <summary>
    /// Gvnic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gvnic block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockGvnicBlock>? Gvnic
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockGvnicBlock>>("gvnic");
        set => SetArgument("gvnic", value);
    }

    /// <summary>
    /// HostMaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostMaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockHostMaintenancePolicyBlock>? HostMaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockHostMaintenancePolicyBlock>>("host_maintenance_policy");
        set => SetArgument("host_maintenance_policy", value);
    }

    /// <summary>
    /// KubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// LinuxNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlock>? LinuxNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlock>>("linux_node_config");
        set => SetArgument("linux_node_config", value);
    }

    /// <summary>
    /// LocalNvmeSsdBlockConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalNvmeSsdBlockConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockLocalNvmeSsdBlockConfigBlock>? LocalNvmeSsdBlockConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockLocalNvmeSsdBlockConfigBlock>>("local_nvme_ssd_block_config");
        set => SetArgument("local_nvme_ssd_block_config", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// SecondaryBootDisks block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(127, ErrorMessage = "Maximum 127 SecondaryBootDisks block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockSecondaryBootDisksBlock>? SecondaryBootDisks
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockSecondaryBootDisksBlock>>("secondary_boot_disks");
        set => SetArgument("secondary_boot_disks", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// SoleTenantConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoleTenantConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlock>? SoleTenantConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlock>>("sole_tenant_config");
        set => SetArgument("sole_tenant_config", value);
    }

    /// <summary>
    /// Taint block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodeConfigBlockTaintBlock>? Taint
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockTaintBlock>>("taint");
        set => SetArgument("taint", value);
    }

    /// <summary>
    /// WindowsNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockWindowsNodeConfigBlock>? WindowsNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockWindowsNodeConfigBlock>>("windows_node_config");
        set => SetArgument("windows_node_config", value);
    }

    /// <summary>
    /// WorkloadMetadataConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadMetadataConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockWorkloadMetadataConfigBlock>? WorkloadMetadataConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockWorkloadMetadataConfigBlock>>("workload_metadata_config");
        set => SetArgument("workload_metadata_config", value);
    }

}

/// <summary>
/// Block type for advanced_machine_features in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_machine_features";

    /// <summary>
    /// Whether the node should have nested virtualization enabled.
    /// </summary>
    public TerraformValue<bool>? EnableNestedVirtualization
    {
        get => GetArgument<TerraformValue<bool>>("enable_nested_virtualization");
        set => SetArgument("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Level of Performance Monitoring Unit (PMU) requested. If unset, no access to the PMU is assumed.
    /// </summary>
    public TerraformValue<string>? PerformanceMonitoringUnit
    {
        get => GetArgument<TerraformValue<string>>("performance_monitoring_unit");
        set => SetArgument("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreadsPerCore is required")]
    public required TerraformValue<double> ThreadsPerCore
    {
        get => GetRequiredArgument<TerraformValue<double>>("threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

}

/// <summary>
/// Block type for boot_disk in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockBootDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_disk";

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? AsReference("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// Configured IOPs provisioning. Only valid with disk type hyperdisk-balanced.
    /// </summary>
    public TerraformValue<double> ProvisionedIops
    {
        get => GetArgument<TerraformValue<double>>("provisioned_iops") ?? AsReference("provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Configured throughput provisioning. Only valid with disk type hyperdisk-balanced.
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
    {
        get => GetArgument<TerraformValue<double>>("provisioned_throughput") ?? AsReference("provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double> SizeGb
    {
        get => GetArgument<TerraformValue<double>>("size_gb") ?? AsReference("size_gb");
        set => SetArgument("size_gb", value);
    }

}

/// <summary>
/// Block type for confidential_nodes in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockConfidentialNodesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_nodes";

    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    public TerraformValue<string>? ConfidentialInstanceType
    {
        get => GetArgument<TerraformValue<string>>("confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for containerd_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockContainerdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containerd_config";

    /// <summary>
    /// PrivateRegistryAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccessConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>? PrivateRegistryAccessConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>>("private_registry_access_config");
        set => SetArgument("private_registry_access_config", value);
    }

}

/// <summary>
/// Block type for private_registry_access_config in GoogleContainerClusterNodeConfigBlockContainerdConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_registry_access_config";

    /// <summary>
    /// Whether or not private registries are configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// CertificateAuthorityDomainConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>? CertificateAuthorityDomainConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>>("certificate_authority_domain_config");
        set => SetArgument("certificate_authority_domain_config", value);
    }

}

/// <summary>
/// Block type for certificate_authority_domain_config in GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_domain_config";

    /// <summary>
    /// List of fully-qualified-domain-names. IPv4s and port specification are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdns is required")]
    public TerraformList<string>? Fqdns
    {
        get => GetArgument<TerraformList<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// GcpSecretManagerCertificateConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpSecretManagerCertificateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpSecretManagerCertificateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpSecretManagerCertificateConfig block(s) allowed")]
    public required TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock> GcpSecretManagerCertificateConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock>>("gcp_secret_manager_certificate_config");
        set => SetArgument("gcp_secret_manager_certificate_config", value);
    }

}

/// <summary>
/// Block type for gcp_secret_manager_certificate_config in GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_secret_manager_certificate_config";

    /// <summary>
    /// URI for the secret that hosts a certificate. Must be in the format &#39;projects/PROJECT_NUM/secrets/SECRET_NAME/versions/VERSION_OR_LATEST&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUri is required")]
    public required TerraformValue<string> SecretUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_uri");
        set => SetArgument("secret_uri", value);
    }

}

/// <summary>
/// Block type for ephemeral_storage_local_ssd_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockEphemeralStorageLocalSsdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_storage_local_ssd_config";

    /// <summary>
    /// Number of local SSDs to be utilized for GKE Data Cache. Uses NVMe interfaces.
    /// </summary>
    public TerraformValue<double>? DataCacheCount
    {
        get => GetArgument<TerraformValue<double>>("data_cache_count");
        set => SetArgument("data_cache_count", value);
    }

    /// <summary>
    /// Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalSsdCount is required")]
    public required TerraformValue<double> LocalSsdCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

}

/// <summary>
/// Block type for fast_socket in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockFastSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fast_socket";

    /// <summary>
    /// Whether or not NCCL Fast Socket is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gcfs_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockGcfsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcfs_config";

    /// <summary>
    /// Whether or not GCFS is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for guest_accelerator in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_accelerator";

    /// <summary>
    /// The number of the accelerator cards exposed to an instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide (https://docs.nvidia.com/datacenter/tesla/mig-user-guide/#partitioning)
    /// </summary>
    public TerraformValue<string>? GpuPartitionSize
    {
        get => GetArgument<TerraformValue<string>>("gpu_partition_size");
        set => SetArgument("gpu_partition_size", value);
    }

    /// <summary>
    /// The accelerator type resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// GpuDriverInstallationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GpuDriverInstallationConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock>? GpuDriverInstallationConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock>>("gpu_driver_installation_config");
        set => SetArgument("gpu_driver_installation_config", value);
    }

    /// <summary>
    /// GpuSharingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GpuSharingConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock>? GpuSharingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock>>("gpu_sharing_config");
        set => SetArgument("gpu_sharing_config", value);
    }

}

/// <summary>
/// Block type for gpu_driver_installation_config in GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gpu_driver_installation_config";

    /// <summary>
    /// Mode for how the GPU driver is installed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GpuDriverVersion is required")]
    public required TerraformValue<string> GpuDriverVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("gpu_driver_version");
        set => SetArgument("gpu_driver_version", value);
    }

}

/// <summary>
/// Block type for gpu_sharing_config in GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gpu_sharing_config";

    /// <summary>
    /// The type of GPU sharing strategy to enable on the GPU node. Possible values are described in the API package (https://pkg.go.dev/google.golang.org/api/container/v1#GPUSharingConfig)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GpuSharingStrategy is required")]
    public required TerraformValue<string> GpuSharingStrategy
    {
        get => GetRequiredArgument<TerraformValue<string>>("gpu_sharing_strategy");
        set => SetArgument("gpu_sharing_strategy", value);
    }

    /// <summary>
    /// The maximum number of containers that can share a GPU.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSharedClientsPerGpu is required")]
    public required TerraformValue<double> MaxSharedClientsPerGpu
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_shared_clients_per_gpu");
        set => SetArgument("max_shared_clients_per_gpu", value);
    }

}

/// <summary>
/// Block type for gvnic in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockGvnicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gvnic";

    /// <summary>
    /// Whether or not gvnic is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for host_maintenance_policy in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockHostMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_maintenance_policy";

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceInterval is required")]
    public required TerraformValue<string> MaintenanceInterval
    {
        get => GetRequiredArgument<TerraformValue<string>>("maintenance_interval");
        set => SetArgument("maintenance_interval", value);
    }

}

/// <summary>
/// Block type for kubelet_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_config";

    /// <summary>
    /// Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods.
    /// </summary>
    public TerraformList<string>? AllowedUnsafeSysctls
    {
        get => GetArgument<TerraformList<string>>("allowed_unsafe_sysctls");
        set => SetArgument("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// Defines the maximum number of container log files that can be present for a container.
    /// </summary>
    public TerraformValue<double>? ContainerLogMaxFiles
    {
        get => GetArgument<TerraformValue<double>>("container_log_max_files");
        set => SetArgument("container_log_max_files", value);
    }

    /// <summary>
    /// Defines the maximum size of the container log file before it is rotated.
    /// </summary>
    public TerraformValue<string>? ContainerLogMaxSize
    {
        get => GetArgument<TerraformValue<string>>("container_log_max_size");
        set => SetArgument("container_log_max_size", value);
    }

    /// <summary>
    /// Enable CPU CFS quota enforcement for containers that specify CPU limits.
    /// </summary>
    public TerraformValue<bool> CpuCfsQuota
    {
        get => GetArgument<TerraformValue<bool>>("cpu_cfs_quota") ?? AsReference("cpu_cfs_quota");
        set => SetArgument("cpu_cfs_quota", value);
    }

    /// <summary>
    /// Set the CPU CFS quota period value &#39;cpu.cfs_period_us&#39;.
    /// </summary>
    public TerraformValue<string>? CpuCfsQuotaPeriod
    {
        get => GetArgument<TerraformValue<string>>("cpu_cfs_quota_period");
        set => SetArgument("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// Control the CPU management policy on the node.
    /// </summary>
    public TerraformValue<string>? CpuManagerPolicy
    {
        get => GetArgument<TerraformValue<string>>("cpu_manager_policy");
        set => SetArgument("cpu_manager_policy", value);
    }

    /// <summary>
    /// Defines the maximum allowed grace period (in seconds) to use when terminating pods in response to a soft eviction threshold being met.
    /// </summary>
    public TerraformValue<double>? EvictionMaxPodGracePeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("eviction_max_pod_grace_period_seconds");
        set => SetArgument("eviction_max_pod_grace_period_seconds", value);
    }

    /// <summary>
    /// Defines the percent of disk usage after which image garbage collection is always run.
    /// </summary>
    public TerraformValue<double>? ImageGcHighThresholdPercent
    {
        get => GetArgument<TerraformValue<double>>("image_gc_high_threshold_percent");
        set => SetArgument("image_gc_high_threshold_percent", value);
    }

    /// <summary>
    /// Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to.
    /// </summary>
    public TerraformValue<double>? ImageGcLowThresholdPercent
    {
        get => GetArgument<TerraformValue<double>>("image_gc_low_threshold_percent");
        set => SetArgument("image_gc_low_threshold_percent", value);
    }

    /// <summary>
    /// Defines the maximum age an image can be unused before it is garbage collected.
    /// </summary>
    public TerraformValue<string>? ImageMaximumGcAge
    {
        get => GetArgument<TerraformValue<string>>("image_maximum_gc_age");
        set => SetArgument("image_maximum_gc_age", value);
    }

    /// <summary>
    /// Defines the minimum age for an unused image before it is garbage collected.
    /// </summary>
    public TerraformValue<string>? ImageMinimumGcAge
    {
        get => GetArgument<TerraformValue<string>>("image_minimum_gc_age");
        set => SetArgument("image_minimum_gc_age", value);
    }

    /// <summary>
    /// Controls whether the kubelet read-only port is enabled. It is strongly recommended to set this to `FALSE`. Possible values: `TRUE`, `FALSE`.
    /// </summary>
    public TerraformValue<string> InsecureKubeletReadonlyPortEnabled
    {
        get => GetArgument<TerraformValue<string>>("insecure_kubelet_readonly_port_enabled") ?? AsReference("insecure_kubelet_readonly_port_enabled");
        set => SetArgument("insecure_kubelet_readonly_port_enabled", value);
    }

    /// <summary>
    /// Set the maximum number of image pulls in parallel.
    /// </summary>
    public TerraformValue<double> MaxParallelImagePulls
    {
        get => GetArgument<TerraformValue<double>>("max_parallel_image_pulls") ?? AsReference("max_parallel_image_pulls");
        set => SetArgument("max_parallel_image_pulls", value);
    }

    /// <summary>
    /// Controls the maximum number of processes allowed to run in a pod.
    /// </summary>
    public TerraformValue<double>? PodPidsLimit
    {
        get => GetArgument<TerraformValue<double>>("pod_pids_limit");
        set => SetArgument("pod_pids_limit", value);
    }

    /// <summary>
    /// Defines whether to enable single process OOM killer.
    /// </summary>
    public TerraformValue<bool>? SingleProcessOomKill
    {
        get => GetArgument<TerraformValue<bool>>("single_process_oom_kill");
        set => SetArgument("single_process_oom_kill", value);
    }

    /// <summary>
    /// EvictionMinimumReclaim block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionMinimumReclaim block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock>? EvictionMinimumReclaim
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock>>("eviction_minimum_reclaim");
        set => SetArgument("eviction_minimum_reclaim", value);
    }

    /// <summary>
    /// EvictionSoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionSoft block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionSoftBlock>? EvictionSoft
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionSoftBlock>>("eviction_soft");
        set => SetArgument("eviction_soft", value);
    }

    /// <summary>
    /// EvictionSoftGracePeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionSoftGracePeriod block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock>? EvictionSoftGracePeriod
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock>>("eviction_soft_grace_period");
        set => SetArgument("eviction_soft_grace_period", value);
    }

    /// <summary>
    /// MemoryManager block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryManager block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockMemoryManagerBlock>? MemoryManager
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockMemoryManagerBlock>>("memory_manager");
        set => SetArgument("memory_manager", value);
    }

    /// <summary>
    /// TopologyManager block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TopologyManager block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockTopologyManagerBlock>? TopologyManager
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockKubeletConfigBlockTopologyManagerBlock>>("topology_manager");
        set => SetArgument("topology_manager", value);
    }

}

/// <summary>
/// Block type for eviction_minimum_reclaim in GoogleContainerClusterNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_minimum_reclaim";

    /// <summary>
    /// Defines percentage of minimum reclaim for imagefs.available.
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for imagefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for memory.available.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => GetArgument<TerraformValue<string>>("memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for nodefs.available.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for nodefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for pid.available.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => GetArgument<TerraformValue<string>>("pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for eviction_soft in GoogleContainerClusterNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionSoftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_soft";

    /// <summary>
    /// Defines percentage of soft eviction threshold for imagefs.available.
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for imagefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines quantity of soft eviction threshold for memory.available.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => GetArgument<TerraformValue<string>>("memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for nodefs.available.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for nodefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for pid.available.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => GetArgument<TerraformValue<string>>("pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for eviction_soft_grace_period in GoogleContainerClusterNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_soft_grace_period";

    /// <summary>
    /// Defines grace period for the imagefs.available soft eviction threshold
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines grace period for the imagefs.inodesFree soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines grace period for the memory.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => GetArgument<TerraformValue<string>>("memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines grace period for the nodefs.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines grace period for the nodefs.inodesFree soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines grace period for the pid.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => GetArgument<TerraformValue<string>>("pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for memory_manager in GoogleContainerClusterNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockKubeletConfigBlockMemoryManagerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_manager";

    /// <summary>
    /// The Memory Manager policy to use. This policy guides how memory and hugepages are allocated and managed for pods on the node, influencing NUMA affinity.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

}

/// <summary>
/// Block type for topology_manager in GoogleContainerClusterNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockKubeletConfigBlockTopologyManagerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topology_manager";

    /// <summary>
    /// The Topology Manager policy to use. This policy dictates how resource alignment is handled on the node.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The Topology Manager scope, defining the granularity at which policy decisions are applied. Valid values are &amp;quot;container&amp;quot; (resources are aligned per container within a pod) or &amp;quot;pod&amp;quot; (resources are aligned for the entire pod).
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope") ?? AsReference("scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for linux_node_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_node_config";

    /// <summary>
    /// cgroupMode specifies the cgroup mode to be used on the node.
    /// </summary>
    public TerraformValue<string> CgroupMode
    {
        get => GetArgument<TerraformValue<string>>("cgroup_mode") ?? AsReference("cgroup_mode");
        set => SetArgument("cgroup_mode", value);
    }

    /// <summary>
    /// The Linux kernel parameters to be applied to the nodes and all pods running on the nodes.
    /// </summary>
    public TerraformMap<string>? Sysctls
    {
        get => GetArgument<TerraformMap<string>>("sysctls");
        set => SetArgument("sysctls", value);
    }

    /// <summary>
    /// The Linux kernel transparent hugepage defrag setting.
    /// </summary>
    public TerraformValue<string>? TransparentHugepageDefrag
    {
        get => GetArgument<TerraformValue<string>>("transparent_hugepage_defrag");
        set => SetArgument("transparent_hugepage_defrag", value);
    }

    /// <summary>
    /// The Linux kernel transparent hugepage setting.
    /// </summary>
    public TerraformValue<string> TransparentHugepageEnabled
    {
        get => GetArgument<TerraformValue<string>>("transparent_hugepage_enabled") ?? AsReference("transparent_hugepage_enabled");
        set => SetArgument("transparent_hugepage_enabled", value);
    }

    /// <summary>
    /// HugepagesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HugepagesConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock>? HugepagesConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock>>("hugepages_config");
        set => SetArgument("hugepages_config", value);
    }

}

/// <summary>
/// Block type for hugepages_config in GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hugepages_config";

    /// <summary>
    /// Amount of 1G hugepages.
    /// </summary>
    public TerraformValue<double>? HugepageSize1g
    {
        get => GetArgument<TerraformValue<double>>("hugepage_size_1g");
        set => SetArgument("hugepage_size_1g", value);
    }

    /// <summary>
    /// Amount of 2M hugepages.
    /// </summary>
    public TerraformValue<double>? HugepageSize2m
    {
        get => GetArgument<TerraformValue<double>>("hugepage_size_2m");
        set => SetArgument("hugepage_size_2m", value);
    }

}

/// <summary>
/// Block type for local_nvme_ssd_block_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockLocalNvmeSsdBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_nvme_ssd_block_config";

    /// <summary>
    /// Number of raw-block local NVMe SSD disks to be attached to the node. Each local SSD is 375 GB in size.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalSsdCount is required")]
    public required TerraformValue<double> LocalSsdCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Corresponds to the type of reservation consumption.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumeReservationType is required")]
    public required TerraformValue<string> ConsumeReservationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// The label key of a reservation resource.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label values of the reservation resource.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for secondary_boot_disks in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockSecondaryBootDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_boot_disks";

    /// <summary>
    /// Disk image to create the secondary boot disk from
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskImage is required")]
    public required TerraformValue<string> DiskImage
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk_image");
        set => SetArgument("disk_image", value);
    }

    /// <summary>
    /// Mode for how the secondary boot disk is used.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

}

/// <summary>
/// Block type for sole_tenant_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sole_tenant_config";

    /// <summary>
    /// Specifies the minimum number of vCPUs that each sole tenant node must have to use CPU overcommit. If not specified, the CPU overcommit feature is disabled.
    /// </summary>
    public TerraformValue<double>? MinNodeCpus
    {
        get => GetArgument<TerraformValue<double>>("min_node_cpus");
        set => SetArgument("min_node_cpus", value);
    }

    /// <summary>
    /// NodeAffinity block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAffinity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeAffinity block(s) required")]
    public required TerraformSet<GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock> NodeAffinity
    {
        get => GetRequiredArgument<TerraformSet<GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock>>("node_affinity");
        set => SetArgument("node_affinity", value);
    }

}

/// <summary>
/// Block type for node_affinity in GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleContainerClusterNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_affinity";

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for taint in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockTaintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taint";

    /// <summary>
    /// Effect for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformValue<string> Effect
    {
        get => GetRequiredArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for windows_node_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockWindowsNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_node_config";

    /// <summary>
    /// The OS Version of the windows nodepool.Values are OS_VERSION_UNSPECIFIED,OS_VERSION_LTSC2019 and OS_VERSION_LTSC2022
    /// </summary>
    public TerraformValue<string>? Osversion
    {
        get => GetArgument<TerraformValue<string>>("osversion");
        set => SetArgument("osversion", value);
    }

}

/// <summary>
/// Block type for workload_metadata_config in GoogleContainerClusterNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlockWorkloadMetadataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_metadata_config";

    /// <summary>
    /// Mode is the configuration for how to expose metadata to workloads running on the node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for node_pool in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool";

    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    public TerraformValue<double> InitialNodeCount
    {
        get => GetArgument<TerraformValue<double>>("initial_node_count") ?? AsReference("initial_node_count");
        set => SetArgument("initial_node_count", value);
    }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    public TerraformList<string> InstanceGroupUrls
        => AsReference("instance_group_urls");

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    public TerraformList<string> ManagedInstanceGroupUrls
        => AsReference("managed_instance_group_urls");

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    public TerraformValue<double> MaxPodsPerNode
    {
        get => GetArgument<TerraformValue<double>>("max_pods_per_node") ?? AsReference("max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count") ?? AsReference("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    public TerraformSet<string> NodeLocations
    {
        get => GetArgument<TerraformSet<string>>("node_locations") ?? AsReference("node_locations");
        set => SetArgument("node_locations", value);
    }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? AsReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Autoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockAutoscalingBlock>? Autoscaling
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockAutoscalingBlock>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockManagementBlock>? Management
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// PlacementPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlacementPolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockPlacementPolicyBlock>? PlacementPolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockPlacementPolicyBlock>>("placement_policy");
        set => SetArgument("placement_policy", value);
    }

    /// <summary>
    /// QueuedProvisioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueuedProvisioning block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockQueuedProvisioningBlock>? QueuedProvisioning
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockQueuedProvisioningBlock>>("queued_provisioning");
        set => SetArgument("queued_provisioning", value);
    }

    /// <summary>
    /// UpgradeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradeSettings block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockUpgradeSettingsBlock>? UpgradeSettings
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockUpgradeSettingsBlock>>("upgrade_settings");
        set => SetArgument("upgrade_settings", value);
    }

}

/// <summary>
/// Block type for autoscaling in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling";

    /// <summary>
    /// Location policy specifies the algorithm used when scaling-up the node pool. &amp;quot;BALANCED&amp;quot; - Is a best effort policy that aims to balance the sizes of available zones. &amp;quot;ANY&amp;quot; - Instructs the cluster autoscaler to prioritize utilization of unused reservations, and reduces preemption risk for Spot VMs.
    /// </summary>
    public TerraformValue<string> LocationPolicy
    {
        get => GetArgument<TerraformValue<string>>("location_policy") ?? AsReference("location_policy");
        set => SetArgument("location_policy", value);
    }

    /// <summary>
    /// Maximum number of nodes per zone in the node pool. Must be &amp;gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    public TerraformValue<double>? MaxNodeCount
    {
        get => GetArgument<TerraformValue<double>>("max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes per zone in the node pool. Must be &amp;gt;=0 and &amp;lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    public TerraformValue<double>? MinNodeCount
    {
        get => GetArgument<TerraformValue<double>>("min_node_count");
        set => SetArgument("min_node_count", value);
    }

    /// <summary>
    /// Maximum number of all nodes in the node pool. Must be &amp;gt;= total_min_node_count. Cannot be used with per zone limits.
    /// </summary>
    public TerraformValue<double>? TotalMaxNodeCount
    {
        get => GetArgument<TerraformValue<double>>("total_max_node_count");
        set => SetArgument("total_max_node_count", value);
    }

    /// <summary>
    /// Minimum number of all nodes in the node pool. Must be &amp;gt;=0 and &amp;lt;= total_max_node_count. Cannot be used with per zone limits.
    /// </summary>
    public TerraformValue<double>? TotalMinNodeCount
    {
        get => GetArgument<TerraformValue<double>>("total_min_node_count");
        set => SetArgument("total_min_node_count", value);
    }

}

/// <summary>
/// Block type for management in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// Whether the nodes will be automatically repaired. Enabled by default.
    /// </summary>
    public TerraformValue<bool>? AutoRepair
    {
        get => GetArgument<TerraformValue<bool>>("auto_repair");
        set => SetArgument("auto_repair", value);
    }

    /// <summary>
    /// Whether the nodes will be automatically upgraded. Enabled by default.
    /// </summary>
    public TerraformValue<bool>? AutoUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("auto_upgrade");
        set => SetArgument("auto_upgrade", value);
    }

}

/// <summary>
/// Block type for network_config in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.
    /// </summary>
    public TerraformValue<bool>? CreatePodRange
    {
        get => GetArgument<TerraformValue<bool>>("create_pod_range");
        set => SetArgument("create_pod_range", value);
    }

    /// <summary>
    /// Whether nodes have internal IP addresses only.
    /// </summary>
    public TerraformValue<bool> EnablePrivateNodes
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_nodes") ?? AsReference("enable_private_nodes");
        set => SetArgument("enable_private_nodes", value);
    }

    /// <summary>
    /// The IP address range for pod IPs in this node pool. Only applicable if create_pod_range is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.
    /// </summary>
    public TerraformValue<string> PodIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("pod_ipv4_cidr_block") ?? AsReference("pod_ipv4_cidr_block");
        set => SetArgument("pod_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.
    /// </summary>
    public TerraformValue<string> PodRange
    {
        get => GetArgument<TerraformValue<string>>("pod_range") ?? AsReference("pod_range");
        set => SetArgument("pod_range", value);
    }

    /// <summary>
    /// The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork} . If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable.
    /// </summary>
    public TerraformValue<string> Subnetwork
        => AsReference("subnetwork");

    /// <summary>
    /// AdditionalNodeNetworkConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockAdditionalNodeNetworkConfigsBlock>? AdditionalNodeNetworkConfigs
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockAdditionalNodeNetworkConfigsBlock>>("additional_node_network_configs");
        set => SetArgument("additional_node_network_configs", value);
    }

    /// <summary>
    /// AdditionalPodNetworkConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockAdditionalPodNetworkConfigsBlock>? AdditionalPodNetworkConfigs
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockAdditionalPodNetworkConfigsBlock>>("additional_pod_network_configs");
        set => SetArgument("additional_pod_network_configs", value);
    }

    /// <summary>
    /// NetworkPerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockNetworkPerformanceConfigBlock>>("network_performance_config");
        set => SetArgument("network_performance_config", value);
    }

    /// <summary>
    /// PodCidrOverprovisionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodCidrOverprovisionConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockPodCidrOverprovisionConfigBlock>? PodCidrOverprovisionConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNetworkConfigBlockPodCidrOverprovisionConfigBlock>>("pod_cidr_overprovision_config");
        set => SetArgument("pod_cidr_overprovision_config", value);
    }

}

/// <summary>
/// Block type for additional_node_network_configs in GoogleContainerClusterNodePoolBlockNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNetworkConfigBlockAdditionalNodeNetworkConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_node_network_configs";

    /// <summary>
    /// Name of the VPC where the additional interface belongs.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Name of the subnetwork where the additional interface belongs.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

}

/// <summary>
/// Block type for additional_pod_network_configs in GoogleContainerClusterNodePoolBlockNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNetworkConfigBlockAdditionalPodNetworkConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_pod_network_configs";

    /// <summary>
    /// The maximum number of pods per node which use this pod network.
    /// </summary>
    public TerraformValue<double> MaxPodsPerNode
    {
        get => GetArgument<TerraformValue<double>>("max_pods_per_node") ?? AsReference("max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the secondary range on the subnet which provides IP address for this pod range.
    /// </summary>
    public TerraformValue<string>? SecondaryPodRange
    {
        get => GetArgument<TerraformValue<string>>("secondary_pod_range");
        set => SetArgument("secondary_pod_range", value);
    }

    /// <summary>
    /// Name of the subnetwork where the additional pod network belongs.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

}

/// <summary>
/// Block type for network_performance_config in GoogleContainerClusterNodePoolBlockNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNetworkConfigBlockNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_performance_config";

    /// <summary>
    /// Specifies the total network bandwidth tier for the NodePool. [Valid values](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters.nodePools#NodePool.Tier) include: &amp;quot;TIER_1&amp;quot; and &amp;quot;TIER_UNSPECIFIED&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformValue<string> TotalEgressBandwidthTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("total_egress_bandwidth_tier");
        set => SetArgument("total_egress_bandwidth_tier", value);
    }

}

/// <summary>
/// Block type for pod_cidr_overprovision_config in GoogleContainerClusterNodePoolBlockNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNetworkConfigBlockPodCidrOverprovisionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_cidr_overprovision_config";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

}

/// <summary>
/// Block type for node_config in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    public TerraformValue<string>? BootDiskKmsKey
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_kms_key");
        set => SetArgument("boot_disk_kms_key", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? AsReference("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveTaints
        => AsReference("effective_taints");

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    public TerraformValue<bool>? EnableConfidentialStorage
    {
        get => GetArgument<TerraformValue<bool>>("enable_confidential_storage");
        set => SetArgument("enable_confidential_storage", value);
    }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    public TerraformValue<bool>? FlexStart
    {
        get => GetArgument<TerraformValue<bool>>("flex_start");
        set => SetArgument("flex_start", value);
    }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    public TerraformValue<string> ImageType
    {
        get => GetArgument<TerraformValue<string>>("image_type") ?? AsReference("image_type");
        set => SetArgument("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    public TerraformValue<double> LocalSsdCount
    {
        get => GetArgument<TerraformValue<double>>("local_ssd_count") ?? AsReference("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    public TerraformValue<string>? LocalSsdEncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("local_ssd_encryption_mode");
        set => SetArgument("local_ssd_encryption_mode", value);
    }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    public TerraformValue<string> LoggingVariant
    {
        get => GetArgument<TerraformValue<string>>("logging_variant") ?? AsReference("logging_variant");
        set => SetArgument("logging_variant", value);
    }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? AsReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxRunDuration
    {
        get => GetArgument<TerraformValue<string>>("max_run_duration");
        set => SetArgument("max_run_duration", value);
    }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata") ?? AsReference("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? AsReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    public TerraformValue<string>? NodeGroup
    {
        get => GetArgument<TerraformValue<string>>("node_group");
        set => SetArgument("node_group", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    public TerraformSet<string> OauthScopes
    {
        get => GetArgument<TerraformSet<string>>("oauth_scopes") ?? AsReference("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    public TerraformValue<bool>? Preemptible
    {
        get => GetArgument<TerraformValue<bool>>("preemptible");
        set => SetArgument("preemptible", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    public TerraformMap<string>? ResourceLabels
    {
        get => GetArgument<TerraformMap<string>>("resource_labels");
        set => SetArgument("resource_labels", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? AsReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    public TerraformValue<bool>? Spot
    {
        get => GetArgument<TerraformValue<bool>>("spot");
        set => SetArgument("spot", value);
    }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    public TerraformList<string>? StoragePools
    {
        get => GetArgument<TerraformList<string>>("storage_pools");
        set => SetArgument("storage_pools", value);
    }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AdvancedMachineFeatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedMachineFeatures block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockAdvancedMachineFeaturesBlock>? AdvancedMachineFeatures
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockAdvancedMachineFeaturesBlock>>("advanced_machine_features");
        set => SetArgument("advanced_machine_features", value);
    }

    /// <summary>
    /// BootDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockBootDiskBlock>? BootDisk
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockBootDiskBlock>>("boot_disk");
        set => SetArgument("boot_disk", value);
    }

    /// <summary>
    /// ConfidentialNodes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockConfidentialNodesBlock>? ConfidentialNodes
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockConfidentialNodesBlock>>("confidential_nodes");
        set => SetArgument("confidential_nodes", value);
    }

    /// <summary>
    /// ContainerdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerdConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlock>? ContainerdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlock>>("containerd_config");
        set => SetArgument("containerd_config", value);
    }

    /// <summary>
    /// EphemeralStorageLocalSsdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorageLocalSsdConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockEphemeralStorageLocalSsdConfigBlock>? EphemeralStorageLocalSsdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockEphemeralStorageLocalSsdConfigBlock>>("ephemeral_storage_local_ssd_config");
        set => SetArgument("ephemeral_storage_local_ssd_config", value);
    }

    /// <summary>
    /// FastSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FastSocket block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockFastSocketBlock>? FastSocket
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockFastSocketBlock>>("fast_socket");
        set => SetArgument("fast_socket", value);
    }

    /// <summary>
    /// GcfsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcfsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGcfsConfigBlock>? GcfsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGcfsConfigBlock>>("gcfs_config");
        set => SetArgument("gcfs_config", value);
    }

    /// <summary>
    /// GuestAccelerator block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlock>? GuestAccelerator
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlock>>("guest_accelerator");
        set => SetArgument("guest_accelerator", value);
    }

    /// <summary>
    /// Gvnic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gvnic block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGvnicBlock>? Gvnic
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGvnicBlock>>("gvnic");
        set => SetArgument("gvnic", value);
    }

    /// <summary>
    /// HostMaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostMaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockHostMaintenancePolicyBlock>? HostMaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockHostMaintenancePolicyBlock>>("host_maintenance_policy");
        set => SetArgument("host_maintenance_policy", value);
    }

    /// <summary>
    /// KubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock>? KubeletConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock>>("kubelet_config");
        set => SetArgument("kubelet_config", value);
    }

    /// <summary>
    /// LinuxNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlock>? LinuxNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlock>>("linux_node_config");
        set => SetArgument("linux_node_config", value);
    }

    /// <summary>
    /// LocalNvmeSsdBlockConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalNvmeSsdBlockConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockLocalNvmeSsdBlockConfigBlock>? LocalNvmeSsdBlockConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockLocalNvmeSsdBlockConfigBlock>>("local_nvme_ssd_block_config");
        set => SetArgument("local_nvme_ssd_block_config", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// SecondaryBootDisks block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(127, ErrorMessage = "Maximum 127 SecondaryBootDisks block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockSecondaryBootDisksBlock>? SecondaryBootDisks
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockSecondaryBootDisksBlock>>("secondary_boot_disks");
        set => SetArgument("secondary_boot_disks", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// SoleTenantConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoleTenantConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlock>? SoleTenantConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlock>>("sole_tenant_config");
        set => SetArgument("sole_tenant_config", value);
    }

    /// <summary>
    /// Taint block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockTaintBlock>? Taint
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockTaintBlock>>("taint");
        set => SetArgument("taint", value);
    }

    /// <summary>
    /// WindowsNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockWindowsNodeConfigBlock>? WindowsNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockWindowsNodeConfigBlock>>("windows_node_config");
        set => SetArgument("windows_node_config", value);
    }

    /// <summary>
    /// WorkloadMetadataConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadMetadataConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockWorkloadMetadataConfigBlock>? WorkloadMetadataConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockWorkloadMetadataConfigBlock>>("workload_metadata_config");
        set => SetArgument("workload_metadata_config", value);
    }

}

/// <summary>
/// Block type for advanced_machine_features in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockAdvancedMachineFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_machine_features";

    /// <summary>
    /// Whether the node should have nested virtualization enabled.
    /// </summary>
    public TerraformValue<bool>? EnableNestedVirtualization
    {
        get => GetArgument<TerraformValue<bool>>("enable_nested_virtualization");
        set => SetArgument("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Level of Performance Monitoring Unit (PMU) requested. If unset, no access to the PMU is assumed.
    /// </summary>
    public TerraformValue<string>? PerformanceMonitoringUnit
    {
        get => GetArgument<TerraformValue<string>>("performance_monitoring_unit");
        set => SetArgument("performance_monitoring_unit", value);
    }

    /// <summary>
    /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreadsPerCore is required")]
    public required TerraformValue<double> ThreadsPerCore
    {
        get => GetRequiredArgument<TerraformValue<double>>("threads_per_core");
        set => SetArgument("threads_per_core", value);
    }

}

/// <summary>
/// Block type for boot_disk in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockBootDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_disk";

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? AsReference("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// Configured IOPs provisioning. Only valid with disk type hyperdisk-balanced.
    /// </summary>
    public TerraformValue<double> ProvisionedIops
    {
        get => GetArgument<TerraformValue<double>>("provisioned_iops") ?? AsReference("provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Configured throughput provisioning. Only valid with disk type hyperdisk-balanced.
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
    {
        get => GetArgument<TerraformValue<double>>("provisioned_throughput") ?? AsReference("provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformValue<double> SizeGb
    {
        get => GetArgument<TerraformValue<double>>("size_gb") ?? AsReference("size_gb");
        set => SetArgument("size_gb", value);
    }

}

/// <summary>
/// Block type for confidential_nodes in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockConfidentialNodesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_nodes";

    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    public TerraformValue<string>? ConfidentialInstanceType
    {
        get => GetArgument<TerraformValue<string>>("confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for containerd_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containerd_config";

    /// <summary>
    /// PrivateRegistryAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccessConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>? PrivateRegistryAccessConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>>("private_registry_access_config");
        set => SetArgument("private_registry_access_config", value);
    }

}

/// <summary>
/// Block type for private_registry_access_config in GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_registry_access_config";

    /// <summary>
    /// Whether or not private registries are configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// CertificateAuthorityDomainConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>? CertificateAuthorityDomainConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>>("certificate_authority_domain_config");
        set => SetArgument("certificate_authority_domain_config", value);
    }

}

/// <summary>
/// Block type for certificate_authority_domain_config in GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_domain_config";

    /// <summary>
    /// List of fully-qualified-domain-names. IPv4s and port specification are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdns is required")]
    public TerraformList<string>? Fqdns
    {
        get => GetArgument<TerraformList<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// GcpSecretManagerCertificateConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpSecretManagerCertificateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpSecretManagerCertificateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpSecretManagerCertificateConfig block(s) allowed")]
    public required TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock> GcpSecretManagerCertificateConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock>>("gcp_secret_manager_certificate_config");
        set => SetArgument("gcp_secret_manager_certificate_config", value);
    }

}

/// <summary>
/// Block type for gcp_secret_manager_certificate_config in GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_secret_manager_certificate_config";

    /// <summary>
    /// URI for the secret that hosts a certificate. Must be in the format &#39;projects/PROJECT_NUM/secrets/SECRET_NAME/versions/VERSION_OR_LATEST&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUri is required")]
    public required TerraformValue<string> SecretUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_uri");
        set => SetArgument("secret_uri", value);
    }

}

/// <summary>
/// Block type for ephemeral_storage_local_ssd_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockEphemeralStorageLocalSsdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_storage_local_ssd_config";

    /// <summary>
    /// Number of local SSDs to be utilized for GKE Data Cache. Uses NVMe interfaces.
    /// </summary>
    public TerraformValue<double>? DataCacheCount
    {
        get => GetArgument<TerraformValue<double>>("data_cache_count");
        set => SetArgument("data_cache_count", value);
    }

    /// <summary>
    /// Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalSsdCount is required")]
    public required TerraformValue<double> LocalSsdCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

}

/// <summary>
/// Block type for fast_socket in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockFastSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fast_socket";

    /// <summary>
    /// Whether or not NCCL Fast Socket is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for gcfs_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockGcfsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcfs_config";

    /// <summary>
    /// Whether or not GCFS is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for guest_accelerator in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_accelerator";

    /// <summary>
    /// The number of the accelerator cards exposed to an instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide (https://docs.nvidia.com/datacenter/tesla/mig-user-guide/#partitioning)
    /// </summary>
    public TerraformValue<string>? GpuPartitionSize
    {
        get => GetArgument<TerraformValue<string>>("gpu_partition_size");
        set => SetArgument("gpu_partition_size", value);
    }

    /// <summary>
    /// The accelerator type resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// GpuDriverInstallationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GpuDriverInstallationConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock>? GpuDriverInstallationConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock>>("gpu_driver_installation_config");
        set => SetArgument("gpu_driver_installation_config", value);
    }

    /// <summary>
    /// GpuSharingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GpuSharingConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock>? GpuSharingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock>>("gpu_sharing_config");
        set => SetArgument("gpu_sharing_config", value);
    }

}

/// <summary>
/// Block type for gpu_driver_installation_config in GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlockGpuDriverInstallationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gpu_driver_installation_config";

    /// <summary>
    /// Mode for how the GPU driver is installed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GpuDriverVersion is required")]
    public required TerraformValue<string> GpuDriverVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("gpu_driver_version");
        set => SetArgument("gpu_driver_version", value);
    }

}

/// <summary>
/// Block type for gpu_sharing_config in GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockGuestAcceleratorBlockGpuSharingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gpu_sharing_config";

    /// <summary>
    /// The type of GPU sharing strategy to enable on the GPU node. Possible values are described in the API package (https://pkg.go.dev/google.golang.org/api/container/v1#GPUSharingConfig)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GpuSharingStrategy is required")]
    public required TerraformValue<string> GpuSharingStrategy
    {
        get => GetRequiredArgument<TerraformValue<string>>("gpu_sharing_strategy");
        set => SetArgument("gpu_sharing_strategy", value);
    }

    /// <summary>
    /// The maximum number of containers that can share a GPU.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSharedClientsPerGpu is required")]
    public required TerraformValue<double> MaxSharedClientsPerGpu
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_shared_clients_per_gpu");
        set => SetArgument("max_shared_clients_per_gpu", value);
    }

}

/// <summary>
/// Block type for gvnic in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockGvnicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gvnic";

    /// <summary>
    /// Whether or not gvnic is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for host_maintenance_policy in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockHostMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_maintenance_policy";

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceInterval is required")]
    public required TerraformValue<string> MaintenanceInterval
    {
        get => GetRequiredArgument<TerraformValue<string>>("maintenance_interval");
        set => SetArgument("maintenance_interval", value);
    }

}

/// <summary>
/// Block type for kubelet_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubelet_config";

    /// <summary>
    /// Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods.
    /// </summary>
    public TerraformList<string>? AllowedUnsafeSysctls
    {
        get => GetArgument<TerraformList<string>>("allowed_unsafe_sysctls");
        set => SetArgument("allowed_unsafe_sysctls", value);
    }

    /// <summary>
    /// Defines the maximum number of container log files that can be present for a container.
    /// </summary>
    public TerraformValue<double>? ContainerLogMaxFiles
    {
        get => GetArgument<TerraformValue<double>>("container_log_max_files");
        set => SetArgument("container_log_max_files", value);
    }

    /// <summary>
    /// Defines the maximum size of the container log file before it is rotated.
    /// </summary>
    public TerraformValue<string>? ContainerLogMaxSize
    {
        get => GetArgument<TerraformValue<string>>("container_log_max_size");
        set => SetArgument("container_log_max_size", value);
    }

    /// <summary>
    /// Enable CPU CFS quota enforcement for containers that specify CPU limits.
    /// </summary>
    public TerraformValue<bool> CpuCfsQuota
    {
        get => GetArgument<TerraformValue<bool>>("cpu_cfs_quota") ?? AsReference("cpu_cfs_quota");
        set => SetArgument("cpu_cfs_quota", value);
    }

    /// <summary>
    /// Set the CPU CFS quota period value &#39;cpu.cfs_period_us&#39;.
    /// </summary>
    public TerraformValue<string>? CpuCfsQuotaPeriod
    {
        get => GetArgument<TerraformValue<string>>("cpu_cfs_quota_period");
        set => SetArgument("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// Control the CPU management policy on the node.
    /// </summary>
    public TerraformValue<string>? CpuManagerPolicy
    {
        get => GetArgument<TerraformValue<string>>("cpu_manager_policy");
        set => SetArgument("cpu_manager_policy", value);
    }

    /// <summary>
    /// Defines the maximum allowed grace period (in seconds) to use when terminating pods in response to a soft eviction threshold being met.
    /// </summary>
    public TerraformValue<double>? EvictionMaxPodGracePeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("eviction_max_pod_grace_period_seconds");
        set => SetArgument("eviction_max_pod_grace_period_seconds", value);
    }

    /// <summary>
    /// Defines the percent of disk usage after which image garbage collection is always run.
    /// </summary>
    public TerraformValue<double>? ImageGcHighThresholdPercent
    {
        get => GetArgument<TerraformValue<double>>("image_gc_high_threshold_percent");
        set => SetArgument("image_gc_high_threshold_percent", value);
    }

    /// <summary>
    /// Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to.
    /// </summary>
    public TerraformValue<double>? ImageGcLowThresholdPercent
    {
        get => GetArgument<TerraformValue<double>>("image_gc_low_threshold_percent");
        set => SetArgument("image_gc_low_threshold_percent", value);
    }

    /// <summary>
    /// Defines the maximum age an image can be unused before it is garbage collected.
    /// </summary>
    public TerraformValue<string>? ImageMaximumGcAge
    {
        get => GetArgument<TerraformValue<string>>("image_maximum_gc_age");
        set => SetArgument("image_maximum_gc_age", value);
    }

    /// <summary>
    /// Defines the minimum age for an unused image before it is garbage collected.
    /// </summary>
    public TerraformValue<string>? ImageMinimumGcAge
    {
        get => GetArgument<TerraformValue<string>>("image_minimum_gc_age");
        set => SetArgument("image_minimum_gc_age", value);
    }

    /// <summary>
    /// Controls whether the kubelet read-only port is enabled. It is strongly recommended to set this to `FALSE`. Possible values: `TRUE`, `FALSE`.
    /// </summary>
    public TerraformValue<string> InsecureKubeletReadonlyPortEnabled
    {
        get => GetArgument<TerraformValue<string>>("insecure_kubelet_readonly_port_enabled") ?? AsReference("insecure_kubelet_readonly_port_enabled");
        set => SetArgument("insecure_kubelet_readonly_port_enabled", value);
    }

    /// <summary>
    /// Set the maximum number of image pulls in parallel.
    /// </summary>
    public TerraformValue<double> MaxParallelImagePulls
    {
        get => GetArgument<TerraformValue<double>>("max_parallel_image_pulls") ?? AsReference("max_parallel_image_pulls");
        set => SetArgument("max_parallel_image_pulls", value);
    }

    /// <summary>
    /// Controls the maximum number of processes allowed to run in a pod.
    /// </summary>
    public TerraformValue<double>? PodPidsLimit
    {
        get => GetArgument<TerraformValue<double>>("pod_pids_limit");
        set => SetArgument("pod_pids_limit", value);
    }

    /// <summary>
    /// Defines whether to enable single process OOM killer.
    /// </summary>
    public TerraformValue<bool>? SingleProcessOomKill
    {
        get => GetArgument<TerraformValue<bool>>("single_process_oom_kill");
        set => SetArgument("single_process_oom_kill", value);
    }

    /// <summary>
    /// EvictionMinimumReclaim block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionMinimumReclaim block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock>? EvictionMinimumReclaim
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock>>("eviction_minimum_reclaim");
        set => SetArgument("eviction_minimum_reclaim", value);
    }

    /// <summary>
    /// EvictionSoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionSoft block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionSoftBlock>? EvictionSoft
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionSoftBlock>>("eviction_soft");
        set => SetArgument("eviction_soft", value);
    }

    /// <summary>
    /// EvictionSoftGracePeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvictionSoftGracePeriod block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock>? EvictionSoftGracePeriod
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock>>("eviction_soft_grace_period");
        set => SetArgument("eviction_soft_grace_period", value);
    }

    /// <summary>
    /// MemoryManager block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryManager block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockMemoryManagerBlock>? MemoryManager
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockMemoryManagerBlock>>("memory_manager");
        set => SetArgument("memory_manager", value);
    }

    /// <summary>
    /// TopologyManager block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TopologyManager block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockTopologyManagerBlock>? TopologyManager
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockTopologyManagerBlock>>("topology_manager");
        set => SetArgument("topology_manager", value);
    }

}

/// <summary>
/// Block type for eviction_minimum_reclaim in GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionMinimumReclaimBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_minimum_reclaim";

    /// <summary>
    /// Defines percentage of minimum reclaim for imagefs.available.
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for imagefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for memory.available.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => GetArgument<TerraformValue<string>>("memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for nodefs.available.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for nodefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of minimum reclaim for pid.available.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => GetArgument<TerraformValue<string>>("pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for eviction_soft in GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionSoftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_soft";

    /// <summary>
    /// Defines percentage of soft eviction threshold for imagefs.available.
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for imagefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines quantity of soft eviction threshold for memory.available.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => GetArgument<TerraformValue<string>>("memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for nodefs.available.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for nodefs.inodesFree.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines percentage of soft eviction threshold for pid.available.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => GetArgument<TerraformValue<string>>("pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for eviction_soft_grace_period in GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockEvictionSoftGracePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eviction_soft_grace_period";

    /// <summary>
    /// Defines grace period for the imagefs.available soft eviction threshold
    /// </summary>
    public TerraformValue<string>? ImagefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("imagefs_available");
        set => SetArgument("imagefs_available", value);
    }

    /// <summary>
    /// Defines grace period for the imagefs.inodesFree soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? ImagefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("imagefs_inodes_free");
        set => SetArgument("imagefs_inodes_free", value);
    }

    /// <summary>
    /// Defines grace period for the memory.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? MemoryAvailable
    {
        get => GetArgument<TerraformValue<string>>("memory_available");
        set => SetArgument("memory_available", value);
    }

    /// <summary>
    /// Defines grace period for the nodefs.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? NodefsAvailable
    {
        get => GetArgument<TerraformValue<string>>("nodefs_available");
        set => SetArgument("nodefs_available", value);
    }

    /// <summary>
    /// Defines grace period for the nodefs.inodesFree soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? NodefsInodesFree
    {
        get => GetArgument<TerraformValue<string>>("nodefs_inodes_free");
        set => SetArgument("nodefs_inodes_free", value);
    }

    /// <summary>
    /// Defines grace period for the pid.available soft eviction threshold.
    /// </summary>
    public TerraformValue<string>? PidAvailable
    {
        get => GetArgument<TerraformValue<string>>("pid_available");
        set => SetArgument("pid_available", value);
    }

}

/// <summary>
/// Block type for memory_manager in GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockMemoryManagerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_manager";

    /// <summary>
    /// The Memory Manager policy to use. This policy guides how memory and hugepages are allocated and managed for pods on the node, influencing NUMA affinity.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

}

/// <summary>
/// Block type for topology_manager in GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockKubeletConfigBlockTopologyManagerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topology_manager";

    /// <summary>
    /// The Topology Manager policy to use. This policy dictates how resource alignment is handled on the node.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The Topology Manager scope, defining the granularity at which policy decisions are applied. Valid values are &amp;quot;container&amp;quot; (resources are aligned per container within a pod) or &amp;quot;pod&amp;quot; (resources are aligned for the entire pod).
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope") ?? AsReference("scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for linux_node_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_node_config";

    /// <summary>
    /// cgroupMode specifies the cgroup mode to be used on the node.
    /// </summary>
    public TerraformValue<string> CgroupMode
    {
        get => GetArgument<TerraformValue<string>>("cgroup_mode") ?? AsReference("cgroup_mode");
        set => SetArgument("cgroup_mode", value);
    }

    /// <summary>
    /// The Linux kernel parameters to be applied to the nodes and all pods running on the nodes.
    /// </summary>
    public TerraformMap<string>? Sysctls
    {
        get => GetArgument<TerraformMap<string>>("sysctls");
        set => SetArgument("sysctls", value);
    }

    /// <summary>
    /// The Linux kernel transparent hugepage defrag setting.
    /// </summary>
    public TerraformValue<string>? TransparentHugepageDefrag
    {
        get => GetArgument<TerraformValue<string>>("transparent_hugepage_defrag");
        set => SetArgument("transparent_hugepage_defrag", value);
    }

    /// <summary>
    /// The Linux kernel transparent hugepage setting.
    /// </summary>
    public TerraformValue<string> TransparentHugepageEnabled
    {
        get => GetArgument<TerraformValue<string>>("transparent_hugepage_enabled") ?? AsReference("transparent_hugepage_enabled");
        set => SetArgument("transparent_hugepage_enabled", value);
    }

    /// <summary>
    /// HugepagesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HugepagesConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock>? HugepagesConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock>>("hugepages_config");
        set => SetArgument("hugepages_config", value);
    }

}

/// <summary>
/// Block type for hugepages_config in GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockLinuxNodeConfigBlockHugepagesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hugepages_config";

    /// <summary>
    /// Amount of 1G hugepages.
    /// </summary>
    public TerraformValue<double>? HugepageSize1g
    {
        get => GetArgument<TerraformValue<double>>("hugepage_size_1g");
        set => SetArgument("hugepage_size_1g", value);
    }

    /// <summary>
    /// Amount of 2M hugepages.
    /// </summary>
    public TerraformValue<double>? HugepageSize2m
    {
        get => GetArgument<TerraformValue<double>>("hugepage_size_2m");
        set => SetArgument("hugepage_size_2m", value);
    }

}

/// <summary>
/// Block type for local_nvme_ssd_block_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockLocalNvmeSsdBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_nvme_ssd_block_config";

    /// <summary>
    /// Number of raw-block local NVMe SSD disks to be attached to the node. Each local SSD is 375 GB in size.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalSsdCount is required")]
    public required TerraformValue<double> LocalSsdCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("local_ssd_count");
        set => SetArgument("local_ssd_count", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Corresponds to the type of reservation consumption.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumeReservationType is required")]
    public required TerraformValue<string> ConsumeReservationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// The label key of a reservation resource.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label values of the reservation resource.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for secondary_boot_disks in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockSecondaryBootDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_boot_disks";

    /// <summary>
    /// Disk image to create the secondary boot disk from
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskImage is required")]
    public required TerraformValue<string> DiskImage
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk_image");
        set => SetArgument("disk_image", value);
    }

    /// <summary>
    /// Mode for how the secondary boot disk is used.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

}

/// <summary>
/// Block type for sole_tenant_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sole_tenant_config";

    /// <summary>
    /// Specifies the minimum number of vCPUs that each sole tenant node must have to use CPU overcommit. If not specified, the CPU overcommit feature is disabled.
    /// </summary>
    public TerraformValue<double>? MinNodeCpus
    {
        get => GetArgument<TerraformValue<double>>("min_node_cpus");
        set => SetArgument("min_node_cpus", value);
    }

    /// <summary>
    /// NodeAffinity block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAffinity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeAffinity block(s) required")]
    public required TerraformSet<GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock> NodeAffinity
    {
        get => GetRequiredArgument<TerraformSet<GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock>>("node_affinity");
        set => SetArgument("node_affinity", value);
    }

}

/// <summary>
/// Block type for node_affinity in GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockSoleTenantConfigBlockNodeAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_affinity";

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for taint in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockTaintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taint";

    /// <summary>
    /// Effect for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformValue<string> Effect
    {
        get => GetRequiredArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Key for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value for taint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for windows_node_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockWindowsNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_node_config";

    /// <summary>
    /// The OS Version of the windows nodepool.Values are OS_VERSION_UNSPECIFIED,OS_VERSION_LTSC2019 and OS_VERSION_LTSC2022
    /// </summary>
    public TerraformValue<string>? Osversion
    {
        get => GetArgument<TerraformValue<string>>("osversion");
        set => SetArgument("osversion", value);
    }

}

/// <summary>
/// Block type for workload_metadata_config in GoogleContainerClusterNodePoolBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockNodeConfigBlockWorkloadMetadataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_metadata_config";

    /// <summary>
    /// Mode is the configuration for how to expose metadata to workloads running on the node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for placement_policy in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockPlacementPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_policy";

    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => GetArgument<TerraformValue<string>>("policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The TPU topology like &amp;quot;2x4&amp;quot; or &amp;quot;2x2x2&amp;quot;. https://cloud.google.com/kubernetes-engine/docs/concepts/plan-tpus#topology
    /// </summary>
    public TerraformValue<string>? TpuTopology
    {
        get => GetArgument<TerraformValue<string>>("tpu_topology");
        set => SetArgument("tpu_topology", value);
    }

    /// <summary>
    /// Type defines the type of placement policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for queued_provisioning in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockQueuedProvisioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queued_provisioning";

    /// <summary>
    /// Whether nodes in this node pool are obtainable solely through the ProvisioningRequest API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for upgrade_settings in GoogleContainerClusterNodePoolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockUpgradeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_settings";

    /// <summary>
    /// The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.
    /// </summary>
    public TerraformValue<double> MaxSurge
    {
        get => GetArgument<TerraformValue<double>>("max_surge") ?? AsReference("max_surge");
        set => SetArgument("max_surge", value);
    }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.
    /// </summary>
    public TerraformValue<double> MaxUnavailable
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable") ?? AsReference("max_unavailable");
        set => SetArgument("max_unavailable", value);
    }

    /// <summary>
    /// Update strategy for the given nodepool.
    /// </summary>
    public TerraformValue<string>? Strategy
    {
        get => GetArgument<TerraformValue<string>>("strategy");
        set => SetArgument("strategy", value);
    }

    /// <summary>
    /// BlueGreenSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenSettings block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlock>? BlueGreenSettings
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlock>>("blue_green_settings");
        set => SetArgument("blue_green_settings", value);
    }

}

/// <summary>
/// Block type for blue_green_settings in GoogleContainerClusterNodePoolBlockUpgradeSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blue_green_settings";

    /// <summary>
    /// Time needed after draining entire blue pool. After this period, blue pool will be cleaned up.
    /// </summary>
    public TerraformValue<string> NodePoolSoakDuration
    {
        get => GetArgument<TerraformValue<string>>("node_pool_soak_duration") ?? AsReference("node_pool_soak_duration");
        set => SetArgument("node_pool_soak_duration", value);
    }

    /// <summary>
    /// StandardRolloutPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardRolloutPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StandardRolloutPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardRolloutPolicy block(s) allowed")]
    public required TerraformList<GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock> StandardRolloutPolicy
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock>>("standard_rollout_policy");
        set => SetArgument("standard_rollout_policy", value);
    }

}

/// <summary>
/// Block type for standard_rollout_policy in GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlockUpgradeSettingsBlockBlueGreenSettingsBlockStandardRolloutPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_rollout_policy";

    /// <summary>
    /// Number of blue nodes to drain in a batch.
    /// </summary>
    public TerraformValue<double> BatchNodeCount
    {
        get => GetArgument<TerraformValue<double>>("batch_node_count") ?? AsReference("batch_node_count");
        set => SetArgument("batch_node_count", value);
    }

    /// <summary>
    /// Percentage of the blue pool nodes to drain in a batch.
    /// </summary>
    public TerraformValue<double> BatchPercentage
    {
        get => GetArgument<TerraformValue<double>>("batch_percentage") ?? AsReference("batch_percentage");
        set => SetArgument("batch_percentage", value);
    }

    /// <summary>
    /// Soak time after each batch gets drained.
    /// </summary>
    public TerraformValue<string> BatchSoakDuration
    {
        get => GetArgument<TerraformValue<string>>("batch_soak_duration") ?? AsReference("batch_soak_duration");
        set => SetArgument("batch_soak_duration", value);
    }

}


/// <summary>
/// Block type for node_pool_auto_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool_auto_config";

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

    /// <summary>
    /// LinuxNodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxNodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolAutoConfigBlockLinuxNodeConfigBlock>? LinuxNodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolAutoConfigBlockLinuxNodeConfigBlock>>("linux_node_config");
        set => SetArgument("linux_node_config", value);
    }

    /// <summary>
    /// NetworkTags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkTags block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolAutoConfigBlockNetworkTagsBlock>? NetworkTags
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolAutoConfigBlockNetworkTagsBlock>>("network_tags");
        set => SetArgument("network_tags", value);
    }

    /// <summary>
    /// NodeKubeletConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeKubeletConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolAutoConfigBlockNodeKubeletConfigBlock>? NodeKubeletConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolAutoConfigBlockNodeKubeletConfigBlock>>("node_kubelet_config");
        set => SetArgument("node_kubelet_config", value);
    }

}

/// <summary>
/// Block type for linux_node_config in GoogleContainerClusterNodePoolAutoConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlockLinuxNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_node_config";

    /// <summary>
    /// cgroupMode specifies the cgroup mode to be used on the node.
    /// </summary>
    public TerraformValue<string> CgroupMode
    {
        get => GetArgument<TerraformValue<string>>("cgroup_mode") ?? AsReference("cgroup_mode");
        set => SetArgument("cgroup_mode", value);
    }

}

/// <summary>
/// Block type for network_tags in GoogleContainerClusterNodePoolAutoConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlockNetworkTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_tags";

    /// <summary>
    /// List of network tags applied to auto-provisioned node pools.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for node_kubelet_config in GoogleContainerClusterNodePoolAutoConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlockNodeKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_kubelet_config";

    /// <summary>
    /// Controls whether the kubelet read-only port is enabled. It is strongly recommended to set this to `FALSE`. Possible values: `TRUE`, `FALSE`.
    /// </summary>
    public TerraformValue<string> InsecureKubeletReadonlyPortEnabled
    {
        get => GetArgument<TerraformValue<string>>("insecure_kubelet_readonly_port_enabled") ?? AsReference("insecure_kubelet_readonly_port_enabled");
        set => SetArgument("insecure_kubelet_readonly_port_enabled", value);
    }

}


/// <summary>
/// Block type for node_pool_defaults in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_pool_defaults";

    /// <summary>
    /// NodeConfigDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfigDefaults block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlock>? NodeConfigDefaults
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlock>>("node_config_defaults");
        set => SetArgument("node_config_defaults", value);
    }

}

/// <summary>
/// Block type for node_config_defaults in GoogleContainerClusterNodePoolDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config_defaults";

    /// <summary>
    /// Controls whether the kubelet read-only port is enabled. It is strongly recommended to set this to `FALSE`. Possible values: `TRUE`, `FALSE`.
    /// </summary>
    public TerraformValue<string> InsecureKubeletReadonlyPortEnabled
    {
        get => GetArgument<TerraformValue<string>>("insecure_kubelet_readonly_port_enabled") ?? AsReference("insecure_kubelet_readonly_port_enabled");
        set => SetArgument("insecure_kubelet_readonly_port_enabled", value);
    }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    public TerraformValue<string> LoggingVariant
    {
        get => GetArgument<TerraformValue<string>>("logging_variant") ?? AsReference("logging_variant");
        set => SetArgument("logging_variant", value);
    }

    /// <summary>
    /// ContainerdConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerdConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlock>? ContainerdConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlock>>("containerd_config");
        set => SetArgument("containerd_config", value);
    }

    /// <summary>
    /// GcfsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcfsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockGcfsConfigBlock>? GcfsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockGcfsConfigBlock>>("gcfs_config");
        set => SetArgument("gcfs_config", value);
    }

}

/// <summary>
/// Block type for containerd_config in GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containerd_config";

    /// <summary>
    /// PrivateRegistryAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccessConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>? PrivateRegistryAccessConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock>>("private_registry_access_config");
        set => SetArgument("private_registry_access_config", value);
    }

}

/// <summary>
/// Block type for private_registry_access_config in GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_registry_access_config";

    /// <summary>
    /// Whether or not private registries are configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// CertificateAuthorityDomainConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>? CertificateAuthorityDomainConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock>>("certificate_authority_domain_config");
        set => SetArgument("certificate_authority_domain_config", value);
    }

}

/// <summary>
/// Block type for certificate_authority_domain_config in GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_domain_config";

    /// <summary>
    /// List of fully-qualified-domain-names. IPv4s and port specification are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdns is required")]
    public TerraformList<string>? Fqdns
    {
        get => GetArgument<TerraformList<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// GcpSecretManagerCertificateConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpSecretManagerCertificateConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpSecretManagerCertificateConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpSecretManagerCertificateConfig block(s) allowed")]
    public required TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock> GcpSecretManagerCertificateConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock>>("gcp_secret_manager_certificate_config");
        set => SetArgument("gcp_secret_manager_certificate_config", value);
    }

}

/// <summary>
/// Block type for gcp_secret_manager_certificate_config in GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockContainerdConfigBlockPrivateRegistryAccessConfigBlockCertificateAuthorityDomainConfigBlockGcpSecretManagerCertificateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_secret_manager_certificate_config";

    /// <summary>
    /// URI for the secret that hosts a certificate. Must be in the format &#39;projects/PROJECT_NUM/secrets/SECRET_NAME/versions/VERSION_OR_LATEST&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUri is required")]
    public required TerraformValue<string> SecretUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_uri");
        set => SetArgument("secret_uri", value);
    }

}

/// <summary>
/// Block type for gcfs_config in GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlockNodeConfigDefaultsBlockGcfsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcfs_config";

    /// <summary>
    /// Whether or not GCFS is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for notification_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// Pubsub block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pubsub is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pubsub block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pubsub block(s) allowed")]
    public required TerraformList<GoogleContainerClusterNotificationConfigBlockPubsubBlock> Pubsub
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterNotificationConfigBlockPubsubBlock>>("pubsub");
        set => SetArgument("pubsub", value);
    }

}

/// <summary>
/// Block type for pubsub in GoogleContainerClusterNotificationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNotificationConfigBlockPubsubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub";

    /// <summary>
    /// Whether or not the notification config is enabled
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The pubsub topic to push upgrade notifications to. Must be in the same project as the cluster. Must be in the format: projects/{project}/topics/{topic}.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<GoogleContainerClusterNotificationConfigBlockPubsubBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNotificationConfigBlockPubsubBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in GoogleContainerClusterNotificationConfigBlockPubsubBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNotificationConfigBlockPubsubBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// Can be used to filter what notifications are sent. Valid values include include UPGRADE_AVAILABLE_EVENT, UPGRADE_EVENT, SECURITY_BULLETIN_EVENT, and UPGRADE_INFO_EVENT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public TerraformList<string>? EventType
    {
        get => GetArgument<TerraformList<string>>("event_type");
        set => SetArgument("event_type", value);
    }

}


/// <summary>
/// Block type for pod_autoscaling in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPodAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_autoscaling";

    /// <summary>
    /// 
    /// 								HPA Profile is used to configure the Horizontal Pod Autoscaler (HPA) profile for the cluster.
    /// 								Available options include:
    /// 								- NONE: Customers explicitly opt-out of HPA profiles.
    /// 								- PERFORMANCE: PERFORMANCE is used when customers opt-in to the performance HPA profile. In this profile we support a higher number of HPAs per cluster and faster metrics collection for workload autoscaling.
    /// 							
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpaProfile is required")]
    public required TerraformValue<string> HpaProfile
    {
        get => GetRequiredArgument<TerraformValue<string>>("hpa_profile");
        set => SetArgument("hpa_profile", value);
    }

}


/// <summary>
/// Block type for private_cluster_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPrivateClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_cluster_config";

    /// <summary>
    /// When true, the cluster&#39;s private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used.
    /// </summary>
    public TerraformValue<bool>? EnablePrivateEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_endpoint");
        set => SetArgument("enable_private_endpoint", value);
    }

    /// <summary>
    /// Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master&#39;s private endpoint via private networking.
    /// </summary>
    public TerraformValue<bool>? EnablePrivateNodes
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_nodes");
        set => SetArgument("enable_private_nodes", value);
    }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster&#39;s network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.
    /// </summary>
    public TerraformValue<string> MasterIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("master_ipv4_cidr_block") ?? AsReference("master_ipv4_cidr_block");
        set => SetArgument("master_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the peering between this cluster and the Google owned VPC.
    /// </summary>
    public TerraformValue<string> PeeringName
        => AsReference("peering_name");

    /// <summary>
    /// The internal IP address of this cluster&#39;s master endpoint.
    /// </summary>
    public TerraformValue<string> PrivateEndpoint
        => AsReference("private_endpoint");

    /// <summary>
    /// Subnetwork in cluster&#39;s network where master&#39;s endpoint will be provisioned.
    /// </summary>
    public TerraformValue<string>? PrivateEndpointSubnetwork
    {
        get => GetArgument<TerraformValue<string>>("private_endpoint_subnetwork");
        set => SetArgument("private_endpoint_subnetwork", value);
    }

    /// <summary>
    /// The external IP address of this cluster&#39;s master endpoint.
    /// </summary>
    public TerraformValue<string> PublicEndpoint
        => AsReference("public_endpoint");

    /// <summary>
    /// MasterGlobalAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterGlobalAccessConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterPrivateClusterConfigBlockMasterGlobalAccessConfigBlock>? MasterGlobalAccessConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterPrivateClusterConfigBlockMasterGlobalAccessConfigBlock>>("master_global_access_config");
        set => SetArgument("master_global_access_config", value);
    }

}

/// <summary>
/// Block type for master_global_access_config in GoogleContainerClusterPrivateClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPrivateClusterConfigBlockMasterGlobalAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_global_access_config";

    /// <summary>
    /// Whether the cluster master is accessible globally or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for rbac_binding_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterRbacBindingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rbac_binding_config";

    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:authenticated.
    /// </summary>
    public TerraformValue<bool>? EnableInsecureBindingSystemAuthenticated
    {
        get => GetArgument<TerraformValue<bool>>("enable_insecure_binding_system_authenticated");
        set => SetArgument("enable_insecure_binding_system_authenticated", value);
    }

    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:anonymous or system:unauthenticated.
    /// </summary>
    public TerraformValue<bool>? EnableInsecureBindingSystemUnauthenticated
    {
        get => GetArgument<TerraformValue<bool>>("enable_insecure_binding_system_unauthenticated");
        set => SetArgument("enable_insecure_binding_system_unauthenticated", value);
    }

}


/// <summary>
/// Block type for release_channel in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterReleaseChannelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "release_channel";

    /// <summary>
    /// The selected release channel. Accepted values are:
    /// * UNSPECIFIED: Not set.
    /// * RAPID: Weekly upgrade cadence; Early testers and developers who requires new features.
    /// * REGULAR: Multiple per month upgrade cadence; Production users who need features not yet offered in the Stable channel.
    /// * STABLE: Every few months upgrade cadence; Production users who need stability above all else, and for whom frequent upgrades are too risky.
    /// * EXTENDED: GKE provides extended support for Kubernetes minor versions through the Extended channel. With this channel, you can stay on a minor version for up to 24 months.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformValue<string> Channel
    {
        get => GetRequiredArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

}


/// <summary>
/// Block type for resource_usage_export_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterResourceUsageExportConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_usage_export_config";

    /// <summary>
    /// Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.
    /// </summary>
    public TerraformValue<bool>? EnableNetworkEgressMetering
    {
        get => GetArgument<TerraformValue<bool>>("enable_network_egress_metering");
        set => SetArgument("enable_network_egress_metering", value);
    }

    /// <summary>
    /// Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? EnableResourceConsumptionMetering
    {
        get => GetArgument<TerraformValue<bool>>("enable_resource_consumption_metering");
        set => SetArgument("enable_resource_consumption_metering", value);
    }

    /// <summary>
    /// BigqueryDestination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BigqueryDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BigqueryDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDestination block(s) allowed")]
    public required TerraformList<GoogleContainerClusterResourceUsageExportConfigBlockBigqueryDestinationBlock> BigqueryDestination
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerClusterResourceUsageExportConfigBlockBigqueryDestinationBlock>>("bigquery_destination");
        set => SetArgument("bigquery_destination", value);
    }

}

/// <summary>
/// Block type for bigquery_destination in GoogleContainerClusterResourceUsageExportConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterResourceUsageExportConfigBlockBigqueryDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_destination";

    /// <summary>
    /// The ID of a BigQuery Dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

}


/// <summary>
/// Block type for secret_manager_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecretManagerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_manager_config";

    /// <summary>
    /// Enable the Secret manager csi component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// RotationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterSecretManagerConfigBlockRotationConfigBlock>? RotationConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterSecretManagerConfigBlockRotationConfigBlock>>("rotation_config");
        set => SetArgument("rotation_config", value);
    }

}

/// <summary>
/// Block type for rotation_config in GoogleContainerClusterSecretManagerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecretManagerConfigBlockRotationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rotation_config";

    /// <summary>
    /// Enable the Secret manager auto rotation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The interval between two consecutive rotations. Default rotation interval is 2 minutes
    /// </summary>
    public TerraformValue<string> RotationInterval
    {
        get => GetArgument<TerraformValue<string>>("rotation_interval") ?? AsReference("rotation_interval");
        set => SetArgument("rotation_interval", value);
    }

}


/// <summary>
/// Block type for security_posture_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecurityPostureConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_posture_config";

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode") ?? AsReference("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.
    /// </summary>
    public TerraformValue<string> VulnerabilityMode
    {
        get => GetArgument<TerraformValue<string>>("vulnerability_mode") ?? AsReference("vulnerability_mode");
        set => SetArgument("vulnerability_mode", value);
    }

}


/// <summary>
/// Block type for service_external_ips_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterServiceExternalIpsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_external_ips_config";

    /// <summary>
    /// When enabled, services with external ips specified will be allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerCluster.
/// Nesting mode: single
/// </summary>
public class GoogleContainerClusterTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_managed_keys_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterUserManagedKeysConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_managed_keys_config";

    /// <summary>
    /// The Certificate Authority Service caPool to use for the aggreation CA in this cluster.
    /// </summary>
    public TerraformValue<string>? AggregationCa
    {
        get => GetArgument<TerraformValue<string>>("aggregation_ca");
        set => SetArgument("aggregation_ca", value);
    }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the cluster CA in this cluster.
    /// </summary>
    public TerraformValue<string>? ClusterCa
    {
        get => GetArgument<TerraformValue<string>>("cluster_ca");
        set => SetArgument("cluster_ca", value);
    }

    /// <summary>
    /// The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.
    /// </summary>
    public TerraformValue<string>? ControlPlaneDiskEncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("control_plane_disk_encryption_key");
        set => SetArgument("control_plane_disk_encryption_key", value);
    }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd API CA in this cluster.
    /// </summary>
    public TerraformValue<string>? EtcdApiCa
    {
        get => GetArgument<TerraformValue<string>>("etcd_api_ca");
        set => SetArgument("etcd_api_ca", value);
    }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.
    /// </summary>
    public TerraformValue<string>? EtcdPeerCa
    {
        get => GetArgument<TerraformValue<string>>("etcd_peer_ca");
        set => SetArgument("etcd_peer_ca", value);
    }

    /// <summary>
    /// Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.
    /// </summary>
    public TerraformValue<string>? GkeopsEtcdBackupEncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("gkeops_etcd_backup_encryption_key");
        set => SetArgument("gkeops_etcd_backup_encryption_key", value);
    }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.
    /// </summary>
    public TerraformSet<string>? ServiceAccountSigningKeys
    {
        get => GetArgument<TerraformSet<string>>("service_account_signing_keys");
        set => SetArgument("service_account_signing_keys", value);
    }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.
    /// </summary>
    public TerraformSet<string>? ServiceAccountVerificationKeys
    {
        get => GetArgument<TerraformSet<string>>("service_account_verification_keys");
        set => SetArgument("service_account_verification_keys", value);
    }

}


/// <summary>
/// Block type for vertical_pod_autoscaling in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterVerticalPodAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vertical_pod_autoscaling";

    /// <summary>
    /// Enables vertical pod autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for workload_identity_config in GoogleContainerCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterWorkloadIdentityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_identity_config";

    /// <summary>
    /// The workload pool to attach all Kubernetes service accounts to.
    /// </summary>
    public TerraformValue<string>? WorkloadPool
    {
        get => GetArgument<TerraformValue<string>>("workload_pool");
        set => SetArgument("workload_pool", value);
    }

}


/// <summary>
/// Represents a google_container_cluster Terraform resource.
/// Manages a google_container_cluster resource.
/// </summary>
public partial class GoogleContainerCluster(string name) : TerraformResource("google_container_cluster", name)
{
    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    public TerraformValue<bool>? AllowNetAdmin
    {
        get => GetArgument<TerraformValue<bool>>("allow_net_admin");
        set => SetArgument("allow_net_admin", value);
    }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    public TerraformValue<string> ClusterIpv4Cidr
    {
        get => GetArgument<TerraformValue<string>>("cluster_ipv4_cidr") ?? AsReference("cluster_ipv4_cidr");
        set => SetArgument("cluster_ipv4_cidr", value);
    }

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    public TerraformValue<string> DatapathProvider
    {
        get => GetArgument<TerraformValue<string>>("datapath_provider") ?? AsReference("datapath_provider");
        set => SetArgument("datapath_provider", value);
    }

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    public TerraformValue<double> DefaultMaxPodsPerNode
    {
        get => GetArgument<TerraformValue<double>>("default_max_pods_per_node") ?? AsReference("default_max_pods_per_node");
        set => SetArgument("default_max_pods_per_node", value);
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    public TerraformValue<bool>? DisableL4LbFirewallReconciliation
    {
        get => GetArgument<TerraformValue<bool>>("disable_l4_lb_firewall_reconciliation");
        set => SetArgument("disable_l4_lb_firewall_reconciliation", value);
    }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableAutopilot
    {
        get => GetArgument<TerraformValue<bool>>("enable_autopilot");
        set => SetArgument("enable_autopilot", value);
    }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableCiliumClusterwideNetworkPolicy
    {
        get => GetArgument<TerraformValue<bool>>("enable_cilium_clusterwide_network_policy");
        set => SetArgument("enable_cilium_clusterwide_network_policy", value);
    }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableFqdnNetworkPolicy
    {
        get => GetArgument<TerraformValue<bool>>("enable_fqdn_network_policy");
        set => SetArgument("enable_fqdn_network_policy", value);
    }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    public TerraformValue<bool> EnableIntranodeVisibility
    {
        get => GetArgument<TerraformValue<bool>>("enable_intranode_visibility") ?? AsReference("enable_intranode_visibility");
        set => SetArgument("enable_intranode_visibility", value);
    }

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    public TerraformValue<bool>? EnableKubernetesAlpha
    {
        get => GetArgument<TerraformValue<bool>>("enable_kubernetes_alpha");
        set => SetArgument("enable_kubernetes_alpha", value);
    }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableL4IlbSubsetting
    {
        get => GetArgument<TerraformValue<bool>>("enable_l4_ilb_subsetting");
        set => SetArgument("enable_l4_ilb_subsetting", value);
    }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? EnableLegacyAbac
    {
        get => GetArgument<TerraformValue<bool>>("enable_legacy_abac");
        set => SetArgument("enable_legacy_abac", value);
    }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableMultiNetworking
    {
        get => GetArgument<TerraformValue<bool>>("enable_multi_networking");
        set => SetArgument("enable_multi_networking", value);
    }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? EnableShieldedNodes
    {
        get => GetArgument<TerraformValue<bool>>("enable_shielded_nodes");
        set => SetArgument("enable_shielded_nodes", value);
    }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableTpu
    {
        get => GetArgument<TerraformValue<bool>>("enable_tpu");
        set => SetArgument("enable_tpu", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    public TerraformValue<string>? InTransitEncryptionConfig
    {
        get => GetArgument<TerraformValue<string>>("in_transit_encryption_config");
        set => SetArgument("in_transit_encryption_config", value);
    }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    public TerraformValue<double>? InitialNodeCount
    {
        get => GetArgument<TerraformValue<double>>("initial_node_count");
        set => SetArgument("initial_node_count", value);
    }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? AsReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    public TerraformValue<string> LoggingService
    {
        get => GetArgument<TerraformValue<string>>("logging_service") ?? AsReference("logging_service");
        set => SetArgument("logging_service", value);
    }

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    public TerraformValue<string>? MinMasterVersion
    {
        get => GetArgument<TerraformValue<string>>("min_master_version");
        set => SetArgument("min_master_version", value);
    }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    public TerraformValue<string> MonitoringService
    {
        get => GetArgument<TerraformValue<string>>("monitoring_service") ?? AsReference("monitoring_service");
        set => SetArgument("monitoring_service", value);
    }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    public TerraformValue<string> NetworkingMode
    {
        get => GetArgument<TerraformValue<string>>("networking_mode") ?? AsReference("networking_mode");
        set => SetArgument("networking_mode", value);
    }

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    public TerraformSet<string> NodeLocations
    {
        get => GetArgument<TerraformSet<string>>("node_locations") ?? AsReference("node_locations");
        set => SetArgument("node_locations", value);
    }

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    public TerraformValue<string> NodeVersion
    {
        get => GetArgument<TerraformValue<string>>("node_version") ?? AsReference("node_version");
        set => SetArgument("node_version", value);
    }

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    public TerraformValue<string> PrivateIpv6GoogleAccess
    {
        get => GetArgument<TerraformValue<string>>("private_ipv6_google_access") ?? AsReference("private_ipv6_google_access");
        set => SetArgument("private_ipv6_google_access", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    public TerraformValue<bool>? RemoveDefaultNodePool
    {
        get => GetArgument<TerraformValue<bool>>("remove_default_node_pool");
        set => SetArgument("remove_default_node_pool", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? ResourceLabels
    {
        get => GetArgument<TerraformMap<string>>("resource_labels");
        set => SetArgument("resource_labels", value);
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork") ?? AsReference("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    public TerraformValue<string> MasterVersion
        => AsReference("master_version");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string> Operation
        => AsReference("operation");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    public TerraformValue<string> ServicesIpv4Cidr
        => AsReference("services_ipv4_cidr");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    public TerraformValue<string> TpuIpv4CidrBlock
        => AsReference("tpu_ipv4_cidr_block");

    /// <summary>
    /// AddonsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlock>? AddonsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAddonsConfigBlock>>("addons_config");
        set => SetArgument("addons_config", value);
    }

    /// <summary>
    /// AnonymousAuthenticationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnonymousAuthenticationConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAnonymousAuthenticationConfigBlock>? AnonymousAuthenticationConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAnonymousAuthenticationConfigBlock>>("anonymous_authentication_config");
        set => SetArgument("anonymous_authentication_config", value);
    }

    /// <summary>
    /// AuthenticatorGroupsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticatorGroupsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterAuthenticatorGroupsConfigBlock>? AuthenticatorGroupsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterAuthenticatorGroupsConfigBlock>>("authenticator_groups_config");
        set => SetArgument("authenticator_groups_config", value);
    }

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleContainerClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleContainerClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// ClusterAutoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterAutoscaling block(s) allowed")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlock>? ClusterAutoscaling
    {
        get => GetArgument<TerraformList<GoogleContainerClusterClusterAutoscalingBlock>>("cluster_autoscaling");
        set => SetArgument("cluster_autoscaling", value);
    }

    /// <summary>
    /// ConfidentialNodes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    public TerraformList<GoogleContainerClusterConfidentialNodesBlock>? ConfidentialNodes
    {
        get => GetArgument<TerraformList<GoogleContainerClusterConfidentialNodesBlock>>("confidential_nodes");
        set => SetArgument("confidential_nodes", value);
    }

    /// <summary>
    /// ControlPlaneEndpointsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEndpointsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlock>? ControlPlaneEndpointsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlock>>("control_plane_endpoints_config");
        set => SetArgument("control_plane_endpoints_config", value);
    }

    /// <summary>
    /// CostManagementConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostManagementConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterCostManagementConfigBlock>? CostManagementConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterCostManagementConfigBlock>>("cost_management_config");
        set => SetArgument("cost_management_config", value);
    }

    /// <summary>
    /// DatabaseEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    public TerraformList<GoogleContainerClusterDatabaseEncryptionBlock>? DatabaseEncryption
    {
        get => GetArgument<TerraformList<GoogleContainerClusterDatabaseEncryptionBlock>>("database_encryption");
        set => SetArgument("database_encryption", value);
    }

    /// <summary>
    /// DefaultSnatStatus block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSnatStatus block(s) allowed")]
    public TerraformList<GoogleContainerClusterDefaultSnatStatusBlock>? DefaultSnatStatus
    {
        get => GetArgument<TerraformList<GoogleContainerClusterDefaultSnatStatusBlock>>("default_snat_status");
        set => SetArgument("default_snat_status", value);
    }

    /// <summary>
    /// DnsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterDnsConfigBlock>? DnsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterDnsConfigBlock>>("dns_config");
        set => SetArgument("dns_config", value);
    }

    /// <summary>
    /// EnableK8sBetaApis block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnableK8sBetaApis block(s) allowed")]
    public TerraformList<GoogleContainerClusterEnableK8sBetaApisBlock>? EnableK8sBetaApis
    {
        get => GetArgument<TerraformList<GoogleContainerClusterEnableK8sBetaApisBlock>>("enable_k8s_beta_apis");
        set => SetArgument("enable_k8s_beta_apis", value);
    }

    /// <summary>
    /// EnterpriseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnterpriseConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<GoogleContainerClusterEnterpriseConfigBlock>? EnterpriseConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterEnterpriseConfigBlock>>("enterprise_config");
        set => SetArgument("enterprise_config", value);
    }

    /// <summary>
    /// Fleet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public TerraformList<GoogleContainerClusterFleetBlock>? Fleet
    {
        get => GetArgument<TerraformList<GoogleContainerClusterFleetBlock>>("fleet");
        set => SetArgument("fleet", value);
    }

    /// <summary>
    /// GatewayApiConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GatewayApiConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterGatewayApiConfigBlock>? GatewayApiConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterGatewayApiConfigBlock>>("gateway_api_config");
        set => SetArgument("gateway_api_config", value);
    }

    /// <summary>
    /// GkeAutoUpgradeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeAutoUpgradeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterGkeAutoUpgradeConfigBlock>? GkeAutoUpgradeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterGkeAutoUpgradeConfigBlock>>("gke_auto_upgrade_config");
        set => SetArgument("gke_auto_upgrade_config", value);
    }

    /// <summary>
    /// IdentityServiceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityServiceConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterIdentityServiceConfigBlock>? IdentityServiceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIdentityServiceConfigBlock>>("identity_service_config");
        set => SetArgument("identity_service_config", value);
    }

    /// <summary>
    /// IpAllocationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAllocationPolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlock>? IpAllocationPolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterIpAllocationPolicyBlock>>("ip_allocation_policy");
        set => SetArgument("ip_allocation_policy", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// MaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterMaintenancePolicyBlock>? MaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMaintenancePolicyBlock>>("maintenance_policy");
        set => SetArgument("maintenance_policy", value);
    }

    /// <summary>
    /// MasterAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuth block(s) allowed")]
    public TerraformList<GoogleContainerClusterMasterAuthBlock>? MasterAuth
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMasterAuthBlock>>("master_auth");
        set => SetArgument("master_auth", value);
    }

    /// <summary>
    /// MasterAuthorizedNetworksConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuthorizedNetworksConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterMasterAuthorizedNetworksConfigBlock>? MasterAuthorizedNetworksConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMasterAuthorizedNetworksConfigBlock>>("master_authorized_networks_config");
        set => SetArgument("master_authorized_networks_config", value);
    }

    /// <summary>
    /// MeshCertificates block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MeshCertificates block(s) allowed")]
    public TerraformList<GoogleContainerClusterMeshCertificatesBlock>? MeshCertificates
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMeshCertificatesBlock>>("mesh_certificates");
        set => SetArgument("mesh_certificates", value);
    }

    /// <summary>
    /// MonitoringConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterMonitoringConfigBlock>? MonitoringConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterMonitoringConfigBlock>>("monitoring_config");
        set => SetArgument("monitoring_config", value);
    }

    /// <summary>
    /// NetworkPerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNetworkPerformanceConfigBlock>>("network_performance_config");
        set => SetArgument("network_performance_config", value);
    }

    /// <summary>
    /// NetworkPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPolicy block(s) allowed")]
    public TerraformList<GoogleContainerClusterNetworkPolicyBlock>? NetworkPolicy
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNetworkPolicyBlock>>("network_policy");
        set => SetArgument("network_policy", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// NodePool block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerClusterNodePoolBlock>? NodePool
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolBlock>>("node_pool");
        set => SetArgument("node_pool", value);
    }

    /// <summary>
    /// NodePoolAutoConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolAutoConfigBlock>? NodePoolAutoConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolAutoConfigBlock>>("node_pool_auto_config");
        set => SetArgument("node_pool_auto_config", value);
    }

    /// <summary>
    /// NodePoolDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolDefaults block(s) allowed")]
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlock>? NodePoolDefaults
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNodePoolDefaultsBlock>>("node_pool_defaults");
        set => SetArgument("node_pool_defaults", value);
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// PodAutoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodAutoscaling block(s) allowed")]
    public TerraformList<GoogleContainerClusterPodAutoscalingBlock>? PodAutoscaling
    {
        get => GetArgument<TerraformList<GoogleContainerClusterPodAutoscalingBlock>>("pod_autoscaling");
        set => SetArgument("pod_autoscaling", value);
    }

    /// <summary>
    /// PrivateClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateClusterConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterPrivateClusterConfigBlock>? PrivateClusterConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterPrivateClusterConfigBlock>>("private_cluster_config");
        set => SetArgument("private_cluster_config", value);
    }

    /// <summary>
    /// RbacBindingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RbacBindingConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterRbacBindingConfigBlock>? RbacBindingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterRbacBindingConfigBlock>>("rbac_binding_config");
        set => SetArgument("rbac_binding_config", value);
    }

    /// <summary>
    /// ReleaseChannel block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseChannel block(s) allowed")]
    public TerraformList<GoogleContainerClusterReleaseChannelBlock>? ReleaseChannel
    {
        get => GetArgument<TerraformList<GoogleContainerClusterReleaseChannelBlock>>("release_channel");
        set => SetArgument("release_channel", value);
    }

    /// <summary>
    /// ResourceUsageExportConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceUsageExportConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterResourceUsageExportConfigBlock>? ResourceUsageExportConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterResourceUsageExportConfigBlock>>("resource_usage_export_config");
        set => SetArgument("resource_usage_export_config", value);
    }

    /// <summary>
    /// SecretManagerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterSecretManagerConfigBlock>? SecretManagerConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterSecretManagerConfigBlock>>("secret_manager_config");
        set => SetArgument("secret_manager_config", value);
    }

    /// <summary>
    /// SecurityPostureConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterSecurityPostureConfigBlock>? SecurityPostureConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterSecurityPostureConfigBlock>>("security_posture_config");
        set => SetArgument("security_posture_config", value);
    }

    /// <summary>
    /// ServiceExternalIpsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceExternalIpsConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterServiceExternalIpsConfigBlock>? ServiceExternalIpsConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterServiceExternalIpsConfigBlock>>("service_external_ips_config");
        set => SetArgument("service_external_ips_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserManagedKeysConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedKeysConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterUserManagedKeysConfigBlock>? UserManagedKeysConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterUserManagedKeysConfigBlock>>("user_managed_keys_config");
        set => SetArgument("user_managed_keys_config", value);
    }

    /// <summary>
    /// VerticalPodAutoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerticalPodAutoscaling block(s) allowed")]
    public TerraformList<GoogleContainerClusterVerticalPodAutoscalingBlock>? VerticalPodAutoscaling
    {
        get => GetArgument<TerraformList<GoogleContainerClusterVerticalPodAutoscalingBlock>>("vertical_pod_autoscaling");
        set => SetArgument("vertical_pod_autoscaling", value);
    }

    /// <summary>
    /// WorkloadIdentityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadIdentityConfig block(s) allowed")]
    public TerraformList<GoogleContainerClusterWorkloadIdentityConfigBlock>? WorkloadIdentityConfig
    {
        get => GetArgument<TerraformList<GoogleContainerClusterWorkloadIdentityConfigBlock>>("workload_identity_config");
        set => SetArgument("workload_identity_config", value);
    }

}
