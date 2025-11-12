using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterAddonsConfigBlock() : TerraformBlock("addons_config")
{
}

/// <summary>
/// Block type for anonymous_authentication_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterAnonymousAuthenticationConfigBlock() : TerraformBlock("anonymous_authentication_config")
{
    /// <summary>
    /// Setting this to LIMITED will restrict authentication of anonymous users to health check endpoints only.
    ///  Accepted values are:
    /// * ENABLED: Authentication of anonymous users is enabled for all endpoints.
    /// * LIMITED: Anonymous access is only allowed for health check endpoints.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for authenticator_groups_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterAuthenticatorGroupsConfigBlock() : TerraformBlock("authenticator_groups_config")
{
    /// <summary>
    /// The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroup is required")]
    [TerraformProperty("security_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecurityGroup { get; set; }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterBinaryAuthorizationBlock() : TerraformBlock("binary_authorization")
{
    /// <summary>
    /// Enable Binary Authorization for this cluster.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation.
    /// </summary>
    [TerraformProperty("evaluation_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EvaluationMode { get; set; }

}

/// <summary>
/// Block type for cluster_autoscaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterClusterAutoscalingBlock() : TerraformBlock("cluster_autoscaling")
{
    /// <summary>
    /// The list of Google Compute Engine zones in which the NodePool&#39;s nodes can be created by NAP.
    /// </summary>
    [TerraformProperty("auto_provisioning_locations")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> AutoProvisioningLocations { get; set; }

    /// <summary>
    /// Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.
    /// </summary>
    [TerraformProperty("autoscaling_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoscalingProfile { get; set; }

    /// <summary>
    /// Specifies whether default compute class behaviour is enabled. If enabled, cluster autoscaler will use Compute Class with name default for all the workloads, if not overriden.
    /// </summary>
    [TerraformProperty("default_compute_class_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultComputeClassEnabled { get; set; }

    /// <summary>
    /// Whether node auto-provisioning is enabled. Resource limits for cpu and memory must be defined to enable node auto-provisioning.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for confidential_nodes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterConfidentialNodesBlock() : TerraformBlock("confidential_nodes")
{
    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    [TerraformProperty("confidential_instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for control_plane_endpoints_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterControlPlaneEndpointsConfigBlock() : TerraformBlock("control_plane_endpoints_config")
{
}

/// <summary>
/// Block type for cost_management_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterCostManagementConfigBlock() : TerraformBlock("cost_management_config")
{
    /// <summary>
    /// Whether to enable GKE cost allocation. When you enable GKE cost allocation, the cluster name and namespace of your GKE workloads appear in the labels field of the billing export to BigQuery. Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for database_encryption in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterDatabaseEncryptionBlock() : TerraformBlock("database_encryption")
{
    /// <summary>
    /// The key to use to encrypt/decrypt secrets.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// ENCRYPTED or DECRYPTED.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for default_snat_status in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterDefaultSnatStatusBlock() : TerraformBlock("default_snat_status")
{
    /// <summary>
    /// When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    [TerraformProperty("disabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Disabled { get; set; }

}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterDnsConfigBlock() : TerraformBlock("dns_config")
{
    /// <summary>
    /// Enable additive VPC scope DNS in a GKE cluster.
    /// </summary>
    [TerraformProperty("additive_vpc_scope_dns_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditiveVpcScopeDnsDomain { get; set; }

    /// <summary>
    /// Which in-cluster DNS provider should be used.
    /// </summary>
    [TerraformProperty("cluster_dns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterDns { get; set; }

    /// <summary>
    /// The suffix used for all cluster service records.
    /// </summary>
    [TerraformProperty("cluster_dns_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterDnsDomain { get; set; }

    /// <summary>
    /// The scope of access to cluster DNS records.
    /// </summary>
    [TerraformProperty("cluster_dns_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterDnsScope { get; set; }

}

/// <summary>
/// Block type for enable_k8s_beta_apis in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterEnableK8sBetaApisBlock() : TerraformBlock("enable_k8s_beta_apis")
{
    /// <summary>
    /// Enabled Kubernetes Beta APIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledApis is required")]
    [TerraformProperty("enabled_apis")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> EnabledApis { get; set; }

}

/// <summary>
/// Block type for enterprise_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class GoogleContainerClusterEnterpriseConfigBlock() : TerraformBlock("enterprise_config")
{

    /// <summary>
    /// Indicates the desired cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("desired_tier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DesiredTier { get; set; }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterFleetBlock() : TerraformBlock("fleet")
{



    /// <summary>
    /// The type of the cluster&#39;s fleet membership.
    /// </summary>
    [TerraformProperty("membership_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MembershipType { get; set; }


    /// <summary>
    /// The Fleet host project of the cluster.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

}

/// <summary>
/// Block type for gateway_api_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterGatewayApiConfigBlock() : TerraformBlock("gateway_api_config")
{
    /// <summary>
    /// The Gateway API release channel to use for Gateway API.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformProperty("channel")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Channel { get; set; }

}

/// <summary>
/// Block type for gke_auto_upgrade_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterGkeAutoUpgradeConfigBlock() : TerraformBlock("gke_auto_upgrade_config")
{
    /// <summary>
    /// The selected auto-upgrade patch type. Accepted values are:
    /// * ACCELERATED: Upgrades to the latest available patch version in a given minor and release channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchMode is required")]
    [TerraformProperty("patch_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PatchMode { get; set; }

}

/// <summary>
/// Block type for identity_service_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterIdentityServiceConfigBlock() : TerraformBlock("identity_service_config")
{
    /// <summary>
    /// Whether to enable the Identity Service component.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for ip_allocation_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterIpAllocationPolicyBlock() : TerraformBlock("ip_allocation_policy")
{
    /// <summary>
    /// The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    [TerraformProperty("cluster_ipv4_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    [TerraformProperty("cluster_secondary_range_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterSecondaryRangeName { get; set; }

    /// <summary>
    /// The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    [TerraformProperty("services_ipv4_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServicesIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    [TerraformProperty("services_secondary_range_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServicesSecondaryRangeName { get; set; }

    /// <summary>
    /// The IP Stack type of the cluster. Choose between IPV4 and IPV4_IPV6. Default type is IPV4 Only if not set
    /// </summary>
    [TerraformProperty("stack_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StackType { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterLoggingConfigBlock() : TerraformBlock("logging_config")
{
    /// <summary>
    /// GKE components exposing logs. Valid values include SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, KCP_CONNECTION, KCP_SSHD, KCP_HPA, SCHEDULER, and WORKLOADS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableComponents is required")]
    [TerraformProperty("enable_components")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? EnableComponents { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterMaintenancePolicyBlock() : TerraformBlock("maintenance_policy")
{
}

/// <summary>
/// Block type for master_auth in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterMasterAuthBlock() : TerraformBlock("master_auth")
{



}

/// <summary>
/// Block type for master_authorized_networks_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterMasterAuthorizedNetworksConfigBlock() : TerraformBlock("master_authorized_networks_config")
{
    /// <summary>
    /// Whether Kubernetes master is accessible via Google Compute Engine Public IPs.
    /// </summary>
    [TerraformProperty("gcp_public_cidrs_access_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> GcpPublicCidrsAccessEnabled { get; set; }

    /// <summary>
    /// Whether authorized networks is enforced on the private endpoint or not. Defaults to false.
    /// </summary>
    [TerraformProperty("private_endpoint_enforcement_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PrivateEndpointEnforcementEnabled { get; set; }

}

/// <summary>
/// Block type for mesh_certificates in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterMeshCertificatesBlock() : TerraformBlock("mesh_certificates")
{
    /// <summary>
    /// When enabled the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableCertificates is required")]
    [TerraformProperty("enable_certificates")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> EnableCertificates { get; set; }

}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterMonitoringConfigBlock() : TerraformBlock("monitoring_config")
{
    /// <summary>
    /// GKE components exposing metrics. Valid values include SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET.
    /// </summary>
    [TerraformProperty("enable_components")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> EnableComponents { get; set; }

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNetworkPerformanceConfigBlock() : TerraformBlock("network_performance_config")
{
    /// <summary>
    /// Specifies the total network bandwidth tier for NodePools in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformProperty("total_egress_bandwidth_tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for network_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNetworkPolicyBlock() : TerraformBlock("network_policy")
{
    /// <summary>
    /// Whether network policy is enabled on the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The selected network policy provider.
    /// </summary>
    [TerraformProperty("provider")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Provider { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNodeConfigBlock() : TerraformBlock("node_config")
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    [TerraformProperty("boot_disk_kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BootDiskKmsKey { get; set; }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    [TerraformProperty("disk_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskType { get; set; }


    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    [TerraformProperty("enable_confidential_storage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableConfidentialStorage { get; set; }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    [TerraformProperty("flex_start")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FlexStart { get; set; }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    [TerraformProperty("image_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ImageType { get; set; }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Labels { get; set; }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    [TerraformProperty("local_ssd_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> LocalSsdCount { get; set; }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    [TerraformProperty("local_ssd_encryption_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalSsdEncryptionMode { get; set; }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    [TerraformProperty("logging_variant")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoggingVariant { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    [TerraformProperty("max_run_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxRunDuration { get; set; }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    [TerraformProperty("min_cpu_platform")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinCpuPlatform { get; set; }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    [TerraformProperty("node_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeGroup { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    [TerraformProperty("oauth_scopes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> OauthScopes { get; set; }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    [TerraformProperty("preemptible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Preemptible { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    [TerraformProperty("resource_labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceLabels { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceManagerTags { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    [TerraformProperty("spot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Spot { get; set; }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    [TerraformProperty("storage_pools")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? StoragePools { get; set; }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Tags { get; set; }

}

/// <summary>
/// Block type for node_pool in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNodePoolBlock() : TerraformBlock("node_pool")
{
    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    [TerraformProperty("initial_node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> InitialNodeCount { get; set; }



    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    [TerraformProperty("max_pods_per_node")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxPodsPerNode { get; set; }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    [TerraformProperty("node_locations")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> NodeLocations { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for node_pool_auto_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNodePoolAutoConfigBlock() : TerraformBlock("node_pool_auto_config")
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for node_pool_defaults in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNodePoolDefaultsBlock() : TerraformBlock("node_pool_defaults")
{
}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterNotificationConfigBlock() : TerraformBlock("notification_config")
{
}

/// <summary>
/// Block type for pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterPodAutoscalingBlock() : TerraformBlock("pod_autoscaling")
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
    [TerraformProperty("hpa_profile")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HpaProfile { get; set; }

}

/// <summary>
/// Block type for private_cluster_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterPrivateClusterConfigBlock() : TerraformBlock("private_cluster_config")
{
    /// <summary>
    /// When true, the cluster&#39;s private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used.
    /// </summary>
    [TerraformProperty("enable_private_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePrivateEndpoint { get; set; }

    /// <summary>
    /// Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master&#39;s private endpoint via private networking.
    /// </summary>
    [TerraformProperty("enable_private_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePrivateNodes { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster&#39;s network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.
    /// </summary>
    [TerraformProperty("master_ipv4_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MasterIpv4CidrBlock { get; set; }



    /// <summary>
    /// Subnetwork in cluster&#39;s network where master&#39;s endpoint will be provisioned.
    /// </summary>
    [TerraformProperty("private_endpoint_subnetwork")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateEndpointSubnetwork { get; set; }


}

/// <summary>
/// Block type for rbac_binding_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterRbacBindingConfigBlock() : TerraformBlock("rbac_binding_config")
{
    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:authenticated.
    /// </summary>
    [TerraformProperty("enable_insecure_binding_system_authenticated")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableInsecureBindingSystemAuthenticated { get; set; }

    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:anonymous or system:unauthenticated.
    /// </summary>
    [TerraformProperty("enable_insecure_binding_system_unauthenticated")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableInsecureBindingSystemUnauthenticated { get; set; }

}

/// <summary>
/// Block type for release_channel in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterReleaseChannelBlock() : TerraformBlock("release_channel")
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
    [TerraformProperty("channel")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Channel { get; set; }

}

/// <summary>
/// Block type for resource_usage_export_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterResourceUsageExportConfigBlock() : TerraformBlock("resource_usage_export_config")
{
    /// <summary>
    /// Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.
    /// </summary>
    [TerraformProperty("enable_network_egress_metering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNetworkEgressMetering { get; set; }

    /// <summary>
    /// Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.
    /// </summary>
    [TerraformProperty("enable_resource_consumption_metering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableResourceConsumptionMetering { get; set; }

}

/// <summary>
/// Block type for secret_manager_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterSecretManagerConfigBlock() : TerraformBlock("secret_manager_config")
{
    /// <summary>
    /// Enable the Secret manager csi component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterSecurityPostureConfigBlock() : TerraformBlock("security_posture_config")
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.
    /// </summary>
    [TerraformProperty("vulnerability_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VulnerabilityMode { get; set; }

}

/// <summary>
/// Block type for service_external_ips_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterServiceExternalIpsConfigBlock() : TerraformBlock("service_external_ips_config")
{
    /// <summary>
    /// When enabled, services with external ips specified will be allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContainerClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for user_managed_keys_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterUserManagedKeysConfigBlock() : TerraformBlock("user_managed_keys_config")
{
    /// <summary>
    /// The Certificate Authority Service caPool to use for the aggreation CA in this cluster.
    /// </summary>
    [TerraformProperty("aggregation_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AggregationCa { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the cluster CA in this cluster.
    /// </summary>
    [TerraformProperty("cluster_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterCa { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.
    /// </summary>
    [TerraformProperty("control_plane_disk_encryption_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ControlPlaneDiskEncryptionKey { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd API CA in this cluster.
    /// </summary>
    [TerraformProperty("etcd_api_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EtcdApiCa { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.
    /// </summary>
    [TerraformProperty("etcd_peer_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EtcdPeerCa { get; set; }

    /// <summary>
    /// Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.
    /// </summary>
    [TerraformProperty("gkeops_etcd_backup_encryption_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GkeopsEtcdBackupEncryptionKey { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.
    /// </summary>
    [TerraformProperty("service_account_signing_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ServiceAccountSigningKeys { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.
    /// </summary>
    [TerraformProperty("service_account_verification_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ServiceAccountVerificationKeys { get; set; }

}

/// <summary>
/// Block type for vertical_pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterVerticalPodAutoscalingBlock() : TerraformBlock("vertical_pod_autoscaling")
{
    /// <summary>
    /// Enables vertical pod autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for workload_identity_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerClusterWorkloadIdentityConfigBlock() : TerraformBlock("workload_identity_config")
{
    /// <summary>
    /// The workload pool to attach all Kubernetes service accounts to.
    /// </summary>
    [TerraformProperty("workload_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkloadPool { get; set; }

}

/// <summary>
/// Manages a google_container_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContainerCluster : TerraformResource
{
    public GoogleContainerCluster(string name) : base("google_container_cluster", name)
    {
    }

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    [TerraformProperty("allow_net_admin")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowNetAdmin { get; set; }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    [TerraformProperty("cluster_ipv4_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterIpv4Cidr { get; set; }

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    [TerraformProperty("datapath_provider")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DatapathProvider { get; set; }

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    [TerraformProperty("default_max_pods_per_node")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DefaultMaxPodsPerNode { get; set; }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    [TerraformProperty("disable_l4_lb_firewall_reconciliation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableL4LbFirewallReconciliation { get; set; }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    [TerraformProperty("enable_autopilot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAutopilot { get; set; }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    [TerraformProperty("enable_cilium_clusterwide_network_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableCiliumClusterwideNetworkPolicy { get; set; }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    [TerraformProperty("enable_fqdn_network_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    [TerraformProperty("enable_intranode_visibility")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableIntranodeVisibility { get; set; }

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    [TerraformProperty("enable_kubernetes_alpha")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableKubernetesAlpha { get; set; }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    [TerraformProperty("enable_l4_ilb_subsetting")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableL4IlbSubsetting { get; set; }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    [TerraformProperty("enable_legacy_abac")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableLegacyAbac { get; set; }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    [TerraformProperty("enable_multi_networking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMultiNetworking { get; set; }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    [TerraformProperty("enable_shielded_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableShieldedNodes { get; set; }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    [TerraformProperty("enable_tpu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableTpu { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    [TerraformProperty("in_transit_encryption_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InTransitEncryptionConfig { get; set; }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    [TerraformProperty("initial_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialNodeCount { get; set; }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    [TerraformProperty("logging_service")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoggingService { get; set; }

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    [TerraformProperty("min_master_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinMasterVersion { get; set; }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    [TerraformProperty("monitoring_service")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MonitoringService { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    [TerraformProperty("networking_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkingMode { get; set; }

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    [TerraformProperty("node_locations")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> NodeLocations { get; set; }

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    [TerraformProperty("node_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeVersion { get; set; }

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    [TerraformProperty("private_ipv6_google_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIpv6GoogleAccess { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    [TerraformProperty("remove_default_node_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RemoveDefaultNodePool { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("resource_labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceLabels { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Subnetwork { get; set; }

    /// <summary>
    /// Block for addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    [TerraformProperty("addons_config")]
    public TerraformList<GoogleContainerClusterAddonsConfigBlock> AddonsConfig { get; set; } = new();

    /// <summary>
    /// Block for anonymous_authentication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnonymousAuthenticationConfig block(s) allowed")]
    [TerraformProperty("anonymous_authentication_config")]
    public TerraformList<GoogleContainerClusterAnonymousAuthenticationConfigBlock> AnonymousAuthenticationConfig { get; set; } = new();

    /// <summary>
    /// Block for authenticator_groups_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticatorGroupsConfig block(s) allowed")]
    [TerraformProperty("authenticator_groups_config")]
    public TerraformList<GoogleContainerClusterAuthenticatorGroupsConfigBlock> AuthenticatorGroupsConfig { get; set; } = new();

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformProperty("binary_authorization")]
    public TerraformList<GoogleContainerClusterBinaryAuthorizationBlock> BinaryAuthorization { get; set; } = new();

    /// <summary>
    /// Block for cluster_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterAutoscaling block(s) allowed")]
    [TerraformProperty("cluster_autoscaling")]
    public TerraformList<GoogleContainerClusterClusterAutoscalingBlock> ClusterAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for confidential_nodes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    [TerraformProperty("confidential_nodes")]
    public TerraformList<GoogleContainerClusterConfidentialNodesBlock> ConfidentialNodes { get; set; } = new();

    /// <summary>
    /// Block for control_plane_endpoints_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEndpointsConfig block(s) allowed")]
    [TerraformProperty("control_plane_endpoints_config")]
    public TerraformList<GoogleContainerClusterControlPlaneEndpointsConfigBlock> ControlPlaneEndpointsConfig { get; set; } = new();

    /// <summary>
    /// Block for cost_management_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostManagementConfig block(s) allowed")]
    [TerraformProperty("cost_management_config")]
    public TerraformList<GoogleContainerClusterCostManagementConfigBlock> CostManagementConfig { get; set; } = new();

    /// <summary>
    /// Block for database_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    [TerraformProperty("database_encryption")]
    public TerraformList<GoogleContainerClusterDatabaseEncryptionBlock> DatabaseEncryption { get; set; } = new();

    /// <summary>
    /// Block for default_snat_status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSnatStatus block(s) allowed")]
    [TerraformProperty("default_snat_status")]
    public TerraformList<GoogleContainerClusterDefaultSnatStatusBlock> DefaultSnatStatus { get; set; } = new();

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformProperty("dns_config")]
    public TerraformList<GoogleContainerClusterDnsConfigBlock> DnsConfig { get; set; } = new();

    /// <summary>
    /// Block for enable_k8s_beta_apis.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnableK8sBetaApis block(s) allowed")]
    [TerraformProperty("enable_k8s_beta_apis")]
    public TerraformList<GoogleContainerClusterEnableK8sBetaApisBlock> EnableK8sBetaApis { get; set; } = new();

    /// <summary>
    /// Block for enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnterpriseConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("enterprise_config")]
    public TerraformList<GoogleContainerClusterEnterpriseConfigBlock> EnterpriseConfig { get; set; } = new();

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformProperty("fleet")]
    public TerraformList<GoogleContainerClusterFleetBlock> Fleet { get; set; } = new();

    /// <summary>
    /// Block for gateway_api_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GatewayApiConfig block(s) allowed")]
    [TerraformProperty("gateway_api_config")]
    public TerraformList<GoogleContainerClusterGatewayApiConfigBlock> GatewayApiConfig { get; set; } = new();

    /// <summary>
    /// Block for gke_auto_upgrade_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeAutoUpgradeConfig block(s) allowed")]
    [TerraformProperty("gke_auto_upgrade_config")]
    public TerraformList<GoogleContainerClusterGkeAutoUpgradeConfigBlock> GkeAutoUpgradeConfig { get; set; } = new();

    /// <summary>
    /// Block for identity_service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityServiceConfig block(s) allowed")]
    [TerraformProperty("identity_service_config")]
    public TerraformList<GoogleContainerClusterIdentityServiceConfigBlock> IdentityServiceConfig { get; set; } = new();

    /// <summary>
    /// Block for ip_allocation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAllocationPolicy block(s) allowed")]
    [TerraformProperty("ip_allocation_policy")]
    public TerraformList<GoogleContainerClusterIpAllocationPolicyBlock> IpAllocationPolicy { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public TerraformList<GoogleContainerClusterLoggingConfigBlock> LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformProperty("maintenance_policy")]
    public TerraformList<GoogleContainerClusterMaintenancePolicyBlock> MaintenancePolicy { get; set; } = new();

    /// <summary>
    /// Block for master_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuth block(s) allowed")]
    [TerraformProperty("master_auth")]
    public TerraformList<GoogleContainerClusterMasterAuthBlock> MasterAuth { get; set; } = new();

    /// <summary>
    /// Block for master_authorized_networks_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuthorizedNetworksConfig block(s) allowed")]
    [TerraformProperty("master_authorized_networks_config")]
    public TerraformList<GoogleContainerClusterMasterAuthorizedNetworksConfigBlock> MasterAuthorizedNetworksConfig { get; set; } = new();

    /// <summary>
    /// Block for mesh_certificates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MeshCertificates block(s) allowed")]
    [TerraformProperty("mesh_certificates")]
    public TerraformList<GoogleContainerClusterMeshCertificatesBlock> MeshCertificates { get; set; } = new();

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    [TerraformProperty("monitoring_config")]
    public TerraformList<GoogleContainerClusterMonitoringConfigBlock> MonitoringConfig { get; set; } = new();

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformProperty("network_performance_config")]
    public TerraformList<GoogleContainerClusterNetworkPerformanceConfigBlock> NetworkPerformanceConfig { get; set; } = new();

    /// <summary>
    /// Block for network_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPolicy block(s) allowed")]
    [TerraformProperty("network_policy")]
    public TerraformList<GoogleContainerClusterNetworkPolicyBlock> NetworkPolicy { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformProperty("node_config")]
    public TerraformList<GoogleContainerClusterNodeConfigBlock> NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for node_pool.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("node_pool")]
    public TerraformList<GoogleContainerClusterNodePoolBlock> NodePool { get; set; } = new();

    /// <summary>
    /// Block for node_pool_auto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoConfig block(s) allowed")]
    [TerraformProperty("node_pool_auto_config")]
    public TerraformList<GoogleContainerClusterNodePoolAutoConfigBlock> NodePoolAutoConfig { get; set; } = new();

    /// <summary>
    /// Block for node_pool_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolDefaults block(s) allowed")]
    [TerraformProperty("node_pool_defaults")]
    public TerraformList<GoogleContainerClusterNodePoolDefaultsBlock> NodePoolDefaults { get; set; } = new();

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformProperty("notification_config")]
    public TerraformList<GoogleContainerClusterNotificationConfigBlock> NotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodAutoscaling block(s) allowed")]
    [TerraformProperty("pod_autoscaling")]
    public TerraformList<GoogleContainerClusterPodAutoscalingBlock> PodAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for private_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateClusterConfig block(s) allowed")]
    [TerraformProperty("private_cluster_config")]
    public TerraformList<GoogleContainerClusterPrivateClusterConfigBlock> PrivateClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for rbac_binding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RbacBindingConfig block(s) allowed")]
    [TerraformProperty("rbac_binding_config")]
    public TerraformList<GoogleContainerClusterRbacBindingConfigBlock> RbacBindingConfig { get; set; } = new();

    /// <summary>
    /// Block for release_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseChannel block(s) allowed")]
    [TerraformProperty("release_channel")]
    public TerraformList<GoogleContainerClusterReleaseChannelBlock> ReleaseChannel { get; set; } = new();

    /// <summary>
    /// Block for resource_usage_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceUsageExportConfig block(s) allowed")]
    [TerraformProperty("resource_usage_export_config")]
    public TerraformList<GoogleContainerClusterResourceUsageExportConfigBlock> ResourceUsageExportConfig { get; set; } = new();

    /// <summary>
    /// Block for secret_manager_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerConfig block(s) allowed")]
    [TerraformProperty("secret_manager_config")]
    public TerraformList<GoogleContainerClusterSecretManagerConfigBlock> SecretManagerConfig { get; set; } = new();

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    [TerraformProperty("security_posture_config")]
    public TerraformList<GoogleContainerClusterSecurityPostureConfigBlock> SecurityPostureConfig { get; set; } = new();

    /// <summary>
    /// Block for service_external_ips_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceExternalIpsConfig block(s) allowed")]
    [TerraformProperty("service_external_ips_config")]
    public TerraformList<GoogleContainerClusterServiceExternalIpsConfigBlock> ServiceExternalIpsConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleContainerClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_managed_keys_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedKeysConfig block(s) allowed")]
    [TerraformProperty("user_managed_keys_config")]
    public TerraformList<GoogleContainerClusterUserManagedKeysConfigBlock> UserManagedKeysConfig { get; set; } = new();

    /// <summary>
    /// Block for vertical_pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerticalPodAutoscaling block(s) allowed")]
    [TerraformProperty("vertical_pod_autoscaling")]
    public TerraformList<GoogleContainerClusterVerticalPodAutoscalingBlock> VerticalPodAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for workload_identity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadIdentityConfig block(s) allowed")]
    [TerraformProperty("workload_identity_config")]
    public TerraformList<GoogleContainerClusterWorkloadIdentityConfigBlock> WorkloadIdentityConfig { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    [TerraformProperty("master_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterVersion { get; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformProperty("operation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Operation { get; }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    [TerraformProperty("services_ipv4_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServicesIpv4Cidr { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    [TerraformProperty("tpu_ipv4_cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TpuIpv4CidrBlock { get; }

}
