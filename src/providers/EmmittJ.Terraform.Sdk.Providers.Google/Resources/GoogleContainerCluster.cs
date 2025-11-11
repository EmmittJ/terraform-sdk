using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlock
{
}

/// <summary>
/// Block type for anonymous_authentication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAnonymousAuthenticationConfigBlock
{
    /// <summary>
    /// Setting this to LIMITED will restrict authentication of anonymous users to health check endpoints only.
    ///  Accepted values are:
    /// * ENABLED: Authentication of anonymous users is enabled for all endpoints.
    /// * LIMITED: Anonymous access is only allowed for health check endpoints.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for authenticator_groups_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAuthenticatorGroupsConfigBlock
{
    /// <summary>
    /// The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroup is required")]
    [TerraformPropertyName("security_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecurityGroup { get; set; }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterBinaryAuthorizationBlock
{
    /// <summary>
    /// Enable Binary Authorization for this cluster.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation.
    /// </summary>
    [TerraformPropertyName("evaluation_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EvaluationMode { get; set; } = default!;

}

/// <summary>
/// Block type for cluster_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlock
{
    /// <summary>
    /// The list of Google Compute Engine zones in which the NodePool&#39;s nodes can be created by NAP.
    /// </summary>
    [TerraformPropertyName("auto_provisioning_locations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> AutoProvisioningLocations { get; set; } = default!;

    /// <summary>
    /// Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.
    /// </summary>
    [TerraformPropertyName("autoscaling_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoscalingProfile { get; set; }

    /// <summary>
    /// Specifies whether default compute class behaviour is enabled. If enabled, cluster autoscaler will use Compute Class with name default for all the workloads, if not overriden.
    /// </summary>
    [TerraformPropertyName("default_compute_class_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefaultComputeClassEnabled { get; set; }

    /// <summary>
    /// Whether node auto-provisioning is enabled. Resource limits for cpu and memory must be defined to enable node auto-provisioning.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Enabled { get; set; } = default!;

}

/// <summary>
/// Block type for confidential_nodes in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterConfidentialNodesBlock
{
    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    [TerraformPropertyName("confidential_instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for control_plane_endpoints_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterControlPlaneEndpointsConfigBlock
{
}

/// <summary>
/// Block type for cost_management_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterCostManagementConfigBlock
{
    /// <summary>
    /// Whether to enable GKE cost allocation. When you enable GKE cost allocation, the cluster name and namespace of your GKE workloads appear in the labels field of the billing export to BigQuery. Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for database_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDatabaseEncryptionBlock
{
    /// <summary>
    /// The key to use to encrypt/decrypt secrets.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// ENCRYPTED or DECRYPTED.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for default_snat_status in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDefaultSnatStatusBlock
{
    /// <summary>
    /// When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    [TerraformPropertyName("disabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Disabled { get; set; }

}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDnsConfigBlock
{
    /// <summary>
    /// Enable additive VPC scope DNS in a GKE cluster.
    /// </summary>
    [TerraformPropertyName("additive_vpc_scope_dns_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdditiveVpcScopeDnsDomain { get; set; }

    /// <summary>
    /// Which in-cluster DNS provider should be used.
    /// </summary>
    [TerraformPropertyName("cluster_dns")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterDns { get; set; }

    /// <summary>
    /// The suffix used for all cluster service records.
    /// </summary>
    [TerraformPropertyName("cluster_dns_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterDnsDomain { get; set; }

    /// <summary>
    /// The scope of access to cluster DNS records.
    /// </summary>
    [TerraformPropertyName("cluster_dns_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterDnsScope { get; set; }

}

/// <summary>
/// Block type for enable_k8s_beta_apis in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterEnableK8sBetaApisBlock
{
    /// <summary>
    /// Enabled Kubernetes Beta APIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledApis is required")]
    [TerraformPropertyName("enabled_apis")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> EnabledApis { get; set; }

}

/// <summary>
/// Block type for enterprise_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleContainerClusterEnterpriseConfigBlock
{

    /// <summary>
    /// Indicates the desired cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("desired_tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DesiredTier { get; set; } = default!;

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterFleetBlock
{



    /// <summary>
    /// The type of the cluster&#39;s fleet membership.
    /// </summary>
    [TerraformPropertyName("membership_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MembershipType { get; set; }


    /// <summary>
    /// The Fleet host project of the cluster.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

}

/// <summary>
/// Block type for gateway_api_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGatewayApiConfigBlock
{
    /// <summary>
    /// The Gateway API release channel to use for Gateway API.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformPropertyName("channel")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Channel { get; set; }

}

/// <summary>
/// Block type for gke_auto_upgrade_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGkeAutoUpgradeConfigBlock
{
    /// <summary>
    /// The selected auto-upgrade patch type. Accepted values are:
    /// * ACCELERATED: Upgrades to the latest available patch version in a given minor and release channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchMode is required")]
    [TerraformPropertyName("patch_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PatchMode { get; set; }

}

/// <summary>
/// Block type for identity_service_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIdentityServiceConfigBlock
{
    /// <summary>
    /// Whether to enable the Identity Service component.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for ip_allocation_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlock
{
    /// <summary>
    /// The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    [TerraformPropertyName("cluster_ipv4_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterIpv4CidrBlock { get; set; } = default!;

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    [TerraformPropertyName("cluster_secondary_range_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterSecondaryRangeName { get; set; } = default!;

    /// <summary>
    /// The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    [TerraformPropertyName("services_ipv4_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServicesIpv4CidrBlock { get; set; } = default!;

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    [TerraformPropertyName("services_secondary_range_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServicesSecondaryRangeName { get; set; } = default!;

    /// <summary>
    /// The IP Stack type of the cluster. Choose between IPV4 and IPV4_IPV6. Default type is IPV4 Only if not set
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StackType { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterLoggingConfigBlock
{
    /// <summary>
    /// GKE components exposing logs. Valid values include SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, KCP_CONNECTION, KCP_SSHD, KCP_HPA, SCHEDULER, and WORKLOADS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableComponents is required")]
    [TerraformPropertyName("enable_components")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? EnableComponents { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlock
{
}

/// <summary>
/// Block type for master_auth in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthBlock
{



}

/// <summary>
/// Block type for master_authorized_networks_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthorizedNetworksConfigBlock
{
    /// <summary>
    /// Whether Kubernetes master is accessible via Google Compute Engine Public IPs.
    /// </summary>
    [TerraformPropertyName("gcp_public_cidrs_access_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> GcpPublicCidrsAccessEnabled { get; set; } = default!;

    /// <summary>
    /// Whether authorized networks is enforced on the private endpoint or not. Defaults to false.
    /// </summary>
    [TerraformPropertyName("private_endpoint_enforcement_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> PrivateEndpointEnforcementEnabled { get; set; } = default!;

}

/// <summary>
/// Block type for mesh_certificates in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMeshCertificatesBlock
{
    /// <summary>
    /// When enabled the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableCertificates is required")]
    [TerraformPropertyName("enable_certificates")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EnableCertificates { get; set; }

}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlock
{
    /// <summary>
    /// GKE components exposing metrics. Valid values include SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET.
    /// </summary>
    [TerraformPropertyName("enable_components")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> EnableComponents { get; set; } = default!;

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPerformanceConfigBlock
{
    /// <summary>
    /// Specifies the total network bandwidth tier for NodePools in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformPropertyName("total_egress_bandwidth_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for network_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPolicyBlock
{
    /// <summary>
    /// Whether network policy is enabled on the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The selected network policy provider.
    /// </summary>
    [TerraformPropertyName("provider")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Provider { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlock
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    [TerraformPropertyName("boot_disk_kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BootDiskKmsKey { get; set; }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskType { get; set; } = default!;


    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    [TerraformPropertyName("enable_confidential_storage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableConfidentialStorage { get; set; }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    [TerraformPropertyName("flex_start")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FlexStart { get; set; }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ImageType { get; set; } = default!;

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Labels { get; set; } = default!;

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> LocalSsdCount { get; set; } = default!;

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalSsdEncryptionMode { get; set; }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    [TerraformPropertyName("logging_variant")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoggingVariant { get; set; } = default!;

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MachineType { get; set; } = default!;

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("max_run_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxRunDuration { get; set; }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Metadata { get; set; } = default!;

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MinCpuPlatform { get; set; } = default!;

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    [TerraformPropertyName("node_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodeGroup { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    [TerraformPropertyName("oauth_scopes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> OauthScopes { get; set; } = default!;

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Preemptible { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceLabels { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccount { get; set; } = default!;

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    [TerraformPropertyName("spot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Spot { get; set; }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    [TerraformPropertyName("storage_pools")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? StoragePools { get; set; }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Tags { get; set; }

}

/// <summary>
/// Block type for node_pool in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlock
{
    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> InitialNodeCount { get; set; } = default!;



    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("max_pods_per_node")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxPodsPerNode { get; set; } = default!;

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NodeCount { get; set; } = default!;

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> NodeLocations { get; set; } = default!;

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

}

/// <summary>
/// Block type for node_pool_auto_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlock
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for node_pool_defaults in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlock
{
}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNotificationConfigBlock
{
}

/// <summary>
/// Block type for pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPodAutoscalingBlock
{
    /// <summary>
    /// 
    /// 								HPA Profile is used to configure the Horizontal Pod Autoscaler (HPA) profile for the cluster.
    /// 								Available options include:
    /// 								- NONE: Customers explicitly opt-out of HPA profiles.
    /// 								- PERFORMANCE: PERFORMANCE is used when customers opt-in to the performance HPA profile. In this profile we support a higher number of HPAs per cluster and faster metrics collection for workload autoscaling.
    /// 							
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpaProfile is required")]
    [TerraformPropertyName("hpa_profile")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HpaProfile { get; set; }

}

/// <summary>
/// Block type for private_cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPrivateClusterConfigBlock
{
    /// <summary>
    /// When true, the cluster&#39;s private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used.
    /// </summary>
    [TerraformPropertyName("enable_private_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePrivateEndpoint { get; set; }

    /// <summary>
    /// Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master&#39;s private endpoint via private networking.
    /// </summary>
    [TerraformPropertyName("enable_private_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePrivateNodes { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster&#39;s network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.
    /// </summary>
    [TerraformPropertyName("master_ipv4_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MasterIpv4CidrBlock { get; set; } = default!;



    /// <summary>
    /// Subnetwork in cluster&#39;s network where master&#39;s endpoint will be provisioned.
    /// </summary>
    [TerraformPropertyName("private_endpoint_subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateEndpointSubnetwork { get; set; }


}

/// <summary>
/// Block type for rbac_binding_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterRbacBindingConfigBlock
{
    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:authenticated.
    /// </summary>
    [TerraformPropertyName("enable_insecure_binding_system_authenticated")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableInsecureBindingSystemAuthenticated { get; set; }

    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:anonymous or system:unauthenticated.
    /// </summary>
    [TerraformPropertyName("enable_insecure_binding_system_unauthenticated")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableInsecureBindingSystemUnauthenticated { get; set; }

}

/// <summary>
/// Block type for release_channel in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterReleaseChannelBlock
{
    /// <summary>
    /// The selected release channel. Accepted values are:
    /// * UNSPECIFIED: Not set.
    /// * RAPID: Weekly upgrade cadence; Early testers and developers who requires new features.
    /// * REGULAR: Multiple per month upgrade cadence; Production users who need features not yet offered in the Stable channel.
    /// * STABLE: Every few months upgrade cadence; Production users who need stability above all else, and for whom frequent upgrades are too risky.
    /// * EXTENDED: GKE provides extended support for Kubernetes minor versions through the Extended channel. With this channel, you can stay on a minor version for up to 24 months.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformPropertyName("channel")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Channel { get; set; }

}

/// <summary>
/// Block type for resource_usage_export_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterResourceUsageExportConfigBlock
{
    /// <summary>
    /// Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.
    /// </summary>
    [TerraformPropertyName("enable_network_egress_metering")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableNetworkEgressMetering { get; set; }

    /// <summary>
    /// Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_resource_consumption_metering")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableResourceConsumptionMetering { get; set; }

}

/// <summary>
/// Block type for secret_manager_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecretManagerConfigBlock
{
    /// <summary>
    /// Enable the Secret manager csi component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecurityPostureConfigBlock
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.
    /// </summary>
    [TerraformPropertyName("vulnerability_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VulnerabilityMode { get; set; } = default!;

}

/// <summary>
/// Block type for service_external_ips_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterServiceExternalIpsConfigBlock
{
    /// <summary>
    /// When enabled, services with external ips specified will be allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerClusterTimeoutsBlock
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
/// Block type for user_managed_keys_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterUserManagedKeysConfigBlock
{
    /// <summary>
    /// The Certificate Authority Service caPool to use for the aggreation CA in this cluster.
    /// </summary>
    [TerraformPropertyName("aggregation_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AggregationCa { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the cluster CA in this cluster.
    /// </summary>
    [TerraformPropertyName("cluster_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterCa { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.
    /// </summary>
    [TerraformPropertyName("control_plane_disk_encryption_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ControlPlaneDiskEncryptionKey { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd API CA in this cluster.
    /// </summary>
    [TerraformPropertyName("etcd_api_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EtcdApiCa { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.
    /// </summary>
    [TerraformPropertyName("etcd_peer_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EtcdPeerCa { get; set; }

    /// <summary>
    /// Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.
    /// </summary>
    [TerraformPropertyName("gkeops_etcd_backup_encryption_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GkeopsEtcdBackupEncryptionKey { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.
    /// </summary>
    [TerraformPropertyName("service_account_signing_keys")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ServiceAccountSigningKeys { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.
    /// </summary>
    [TerraformPropertyName("service_account_verification_keys")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ServiceAccountVerificationKeys { get; set; }

}

/// <summary>
/// Block type for vertical_pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterVerticalPodAutoscalingBlock
{
    /// <summary>
    /// Enables vertical pod autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for workload_identity_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterWorkloadIdentityConfigBlock
{
    /// <summary>
    /// The workload pool to attach all Kubernetes service accounts to.
    /// </summary>
    [TerraformPropertyName("workload_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkloadPool { get; set; }

}

/// <summary>
/// Manages a google_container_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerCluster : TerraformResource
{
    public GoogleContainerCluster(string name) : base("google_container_cluster", name)
    {
    }

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    [TerraformPropertyName("allow_net_admin")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowNetAdmin { get; set; }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    [TerraformPropertyName("cluster_ipv4_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterIpv4Cidr { get; set; } = default!;

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    [TerraformPropertyName("datapath_provider")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatapathProvider { get; set; } = default!;

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("default_max_pods_per_node")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DefaultMaxPodsPerNode { get; set; } = default!;

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    [TerraformPropertyName("disable_l4_lb_firewall_reconciliation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableL4LbFirewallReconciliation { get; set; }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_autopilot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutopilot { get; set; }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    [TerraformPropertyName("enable_cilium_clusterwide_network_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableCiliumClusterwideNetworkPolicy { get; set; }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    [TerraformPropertyName("enable_fqdn_network_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    [TerraformPropertyName("enable_intranode_visibility")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableIntranodeVisibility { get; set; } = default!;

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    [TerraformPropertyName("enable_kubernetes_alpha")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableKubernetesAlpha { get; set; }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_l4_ilb_subsetting")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableL4IlbSubsetting { get; set; }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    [TerraformPropertyName("enable_legacy_abac")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableLegacyAbac { get; set; }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_multi_networking")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableMultiNetworking { get; set; }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_shielded_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableShieldedNodes { get; set; }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    [TerraformPropertyName("enable_tpu")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableTpu { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    [TerraformPropertyName("in_transit_encryption_config")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InTransitEncryptionConfig { get; set; }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InitialNodeCount { get; set; }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Location { get; set; } = default!;

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    [TerraformPropertyName("logging_service")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoggingService { get; set; } = default!;

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    [TerraformPropertyName("min_master_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinMasterVersion { get; set; }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    [TerraformPropertyName("monitoring_service")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MonitoringService { get; set; } = default!;

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    [TerraformPropertyName("networking_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkingMode { get; set; } = default!;

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> NodeLocations { get; set; } = default!;

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    [TerraformPropertyName("node_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeVersion { get; set; } = default!;

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    [TerraformPropertyName("private_ipv6_google_access")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateIpv6GoogleAccess { get; set; } = default!;

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    [TerraformPropertyName("remove_default_node_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RemoveDefaultNodePool { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceLabels { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Subnetwork { get; set; } = default!;

    /// <summary>
    /// Block for addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    [TerraformPropertyName("addons_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterAddonsConfigBlock>>? AddonsConfig { get; set; }

    /// <summary>
    /// Block for anonymous_authentication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnonymousAuthenticationConfig block(s) allowed")]
    [TerraformPropertyName("anonymous_authentication_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterAnonymousAuthenticationConfigBlock>>? AnonymousAuthenticationConfig { get; set; }

    /// <summary>
    /// Block for authenticator_groups_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticatorGroupsConfig block(s) allowed")]
    [TerraformPropertyName("authenticator_groups_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterAuthenticatorGroupsConfigBlock>>? AuthenticatorGroupsConfig { get; set; }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformPropertyName("binary_authorization")]
    public TerraformList<TerraformBlock<GoogleContainerClusterBinaryAuthorizationBlock>>? BinaryAuthorization { get; set; }

    /// <summary>
    /// Block for cluster_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterAutoscaling block(s) allowed")]
    [TerraformPropertyName("cluster_autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerClusterClusterAutoscalingBlock>>? ClusterAutoscaling { get; set; }

    /// <summary>
    /// Block for confidential_nodes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    [TerraformPropertyName("confidential_nodes")]
    public TerraformList<TerraformBlock<GoogleContainerClusterConfidentialNodesBlock>>? ConfidentialNodes { get; set; }

    /// <summary>
    /// Block for control_plane_endpoints_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEndpointsConfig block(s) allowed")]
    [TerraformPropertyName("control_plane_endpoints_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterControlPlaneEndpointsConfigBlock>>? ControlPlaneEndpointsConfig { get; set; }

    /// <summary>
    /// Block for cost_management_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostManagementConfig block(s) allowed")]
    [TerraformPropertyName("cost_management_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterCostManagementConfigBlock>>? CostManagementConfig { get; set; }

    /// <summary>
    /// Block for database_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    [TerraformPropertyName("database_encryption")]
    public TerraformList<TerraformBlock<GoogleContainerClusterDatabaseEncryptionBlock>>? DatabaseEncryption { get; set; }

    /// <summary>
    /// Block for default_snat_status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSnatStatus block(s) allowed")]
    [TerraformPropertyName("default_snat_status")]
    public TerraformList<TerraformBlock<GoogleContainerClusterDefaultSnatStatusBlock>>? DefaultSnatStatus { get; set; }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformPropertyName("dns_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterDnsConfigBlock>>? DnsConfig { get; set; }

    /// <summary>
    /// Block for enable_k8s_beta_apis.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnableK8sBetaApis block(s) allowed")]
    [TerraformPropertyName("enable_k8s_beta_apis")]
    public TerraformList<TerraformBlock<GoogleContainerClusterEnableK8sBetaApisBlock>>? EnableK8sBetaApis { get; set; }

    /// <summary>
    /// Block for enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnterpriseConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("enterprise_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterEnterpriseConfigBlock>>? EnterpriseConfig { get; set; }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformPropertyName("fleet")]
    public TerraformList<TerraformBlock<GoogleContainerClusterFleetBlock>>? Fleet { get; set; }

    /// <summary>
    /// Block for gateway_api_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GatewayApiConfig block(s) allowed")]
    [TerraformPropertyName("gateway_api_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterGatewayApiConfigBlock>>? GatewayApiConfig { get; set; }

    /// <summary>
    /// Block for gke_auto_upgrade_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeAutoUpgradeConfig block(s) allowed")]
    [TerraformPropertyName("gke_auto_upgrade_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterGkeAutoUpgradeConfigBlock>>? GkeAutoUpgradeConfig { get; set; }

    /// <summary>
    /// Block for identity_service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityServiceConfig block(s) allowed")]
    [TerraformPropertyName("identity_service_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterIdentityServiceConfigBlock>>? IdentityServiceConfig { get; set; }

    /// <summary>
    /// Block for ip_allocation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAllocationPolicy block(s) allowed")]
    [TerraformPropertyName("ip_allocation_policy")]
    public TerraformList<TerraformBlock<GoogleContainerClusterIpAllocationPolicyBlock>>? IpAllocationPolicy { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMaintenancePolicyBlock>>? MaintenancePolicy { get; set; }

    /// <summary>
    /// Block for master_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuth block(s) allowed")]
    [TerraformPropertyName("master_auth")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMasterAuthBlock>>? MasterAuth { get; set; }

    /// <summary>
    /// Block for master_authorized_networks_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuthorizedNetworksConfig block(s) allowed")]
    [TerraformPropertyName("master_authorized_networks_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMasterAuthorizedNetworksConfigBlock>>? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>
    /// Block for mesh_certificates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MeshCertificates block(s) allowed")]
    [TerraformPropertyName("mesh_certificates")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMeshCertificatesBlock>>? MeshCertificates { get; set; }

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    [TerraformPropertyName("monitoring_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMonitoringConfigBlock>>? MonitoringConfig { get; set; }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformPropertyName("network_performance_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// Block for network_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPolicy block(s) allowed")]
    [TerraformPropertyName("network_policy")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNetworkPolicyBlock>>? NetworkPolicy { get; set; }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodeConfigBlock>>? NodeConfig { get; set; }

    /// <summary>
    /// Block for node_pool.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("node_pool")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodePoolBlock>>? NodePool { get; set; }

    /// <summary>
    /// Block for node_pool_auto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoConfig block(s) allowed")]
    [TerraformPropertyName("node_pool_auto_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodePoolAutoConfigBlock>>? NodePoolAutoConfig { get; set; }

    /// <summary>
    /// Block for node_pool_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolDefaults block(s) allowed")]
    [TerraformPropertyName("node_pool_defaults")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodePoolDefaultsBlock>>? NodePoolDefaults { get; set; }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformPropertyName("notification_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNotificationConfigBlock>>? NotificationConfig { get; set; }

    /// <summary>
    /// Block for pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodAutoscaling block(s) allowed")]
    [TerraformPropertyName("pod_autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerClusterPodAutoscalingBlock>>? PodAutoscaling { get; set; }

    /// <summary>
    /// Block for private_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateClusterConfig block(s) allowed")]
    [TerraformPropertyName("private_cluster_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterPrivateClusterConfigBlock>>? PrivateClusterConfig { get; set; }

    /// <summary>
    /// Block for rbac_binding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RbacBindingConfig block(s) allowed")]
    [TerraformPropertyName("rbac_binding_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterRbacBindingConfigBlock>>? RbacBindingConfig { get; set; }

    /// <summary>
    /// Block for release_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseChannel block(s) allowed")]
    [TerraformPropertyName("release_channel")]
    public TerraformList<TerraformBlock<GoogleContainerClusterReleaseChannelBlock>>? ReleaseChannel { get; set; }

    /// <summary>
    /// Block for resource_usage_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceUsageExportConfig block(s) allowed")]
    [TerraformPropertyName("resource_usage_export_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterResourceUsageExportConfigBlock>>? ResourceUsageExportConfig { get; set; }

    /// <summary>
    /// Block for secret_manager_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerConfig block(s) allowed")]
    [TerraformPropertyName("secret_manager_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterSecretManagerConfigBlock>>? SecretManagerConfig { get; set; }

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    [TerraformPropertyName("security_posture_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterSecurityPostureConfigBlock>>? SecurityPostureConfig { get; set; }

    /// <summary>
    /// Block for service_external_ips_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceExternalIpsConfig block(s) allowed")]
    [TerraformPropertyName("service_external_ips_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterServiceExternalIpsConfigBlock>>? ServiceExternalIpsConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_managed_keys_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedKeysConfig block(s) allowed")]
    [TerraformPropertyName("user_managed_keys_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterUserManagedKeysConfigBlock>>? UserManagedKeysConfig { get; set; }

    /// <summary>
    /// Block for vertical_pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerticalPodAutoscaling block(s) allowed")]
    [TerraformPropertyName("vertical_pod_autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerClusterVerticalPodAutoscalingBlock>>? VerticalPodAutoscaling { get; set; }

    /// <summary>
    /// Block for workload_identity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadIdentityConfig block(s) allowed")]
    [TerraformPropertyName("workload_identity_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterWorkloadIdentityConfigBlock>>? WorkloadIdentityConfig { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    [TerraformPropertyName("master_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterVersion => new TerraformReference(this, "master_version");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Operation => new TerraformReference(this, "operation");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    [TerraformPropertyName("services_ipv4_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServicesIpv4Cidr => new TerraformReference(this, "services_ipv4_cidr");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    [TerraformPropertyName("tpu_ipv4_cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TpuIpv4CidrBlock => new TerraformReference(this, "tpu_ipv4_cidr_block");

}
