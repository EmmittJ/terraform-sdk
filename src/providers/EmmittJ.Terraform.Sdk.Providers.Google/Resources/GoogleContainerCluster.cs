using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for anonymous_authentication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAnonymousAuthenticationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Setting this to LIMITED will restrict authentication of anonymous users to health check endpoints only.
    ///  Accepted values are:
    /// * ENABLED: Authentication of anonymous users is enabled for all endpoints.
    /// * LIMITED: Anonymous access is only allowed for health check endpoints.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for authenticator_groups_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAuthenticatorGroupsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroup is required")]
    public required TerraformProperty<string> SecurityGroup
    {
        set => SetProperty("security_group", value);
    }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Enable Binary Authorization for this cluster.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation.
    /// </summary>
    public TerraformProperty<string>? EvaluationMode
    {
        set => SetProperty("evaluation_mode", value);
    }

}

/// <summary>
/// Block type for cluster_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// The list of Google Compute Engine zones in which the NodePool&#39;s nodes can be created by NAP.
    /// </summary>
    public List<TerraformProperty<string>>? AutoProvisioningLocations
    {
        set => SetProperty("auto_provisioning_locations", value);
    }

    /// <summary>
    /// Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.
    /// </summary>
    public TerraformProperty<string>? AutoscalingProfile
    {
        set => SetProperty("autoscaling_profile", value);
    }

    /// <summary>
    /// Specifies whether default compute class behaviour is enabled. If enabled, cluster autoscaler will use Compute Class with name default for all the workloads, if not overriden.
    /// </summary>
    public TerraformProperty<bool>? DefaultComputeClassEnabled
    {
        set => SetProperty("default_compute_class_enabled", value);
    }

    /// <summary>
    /// Whether node auto-provisioning is enabled. Resource limits for cpu and memory must be defined to enable node auto-provisioning.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for confidential_nodes in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterConfidentialNodesBlock : TerraformBlock
{
    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    public TerraformProperty<string>? ConfidentialInstanceType
    {
        set => SetProperty("confidential_instance_type", value);
    }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for control_plane_endpoints_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterControlPlaneEndpointsConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for cost_management_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterCostManagementConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to enable GKE cost allocation. When you enable GKE cost allocation, the cluster name and namespace of your GKE workloads appear in the labels field of the billing export to BigQuery. Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for database_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDatabaseEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The key to use to encrypt/decrypt secrets.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// ENCRYPTED or DECRYPTED.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for default_snat_status in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDefaultSnatStatusBlock : TerraformBlock
{
    /// <summary>
    /// When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformProperty<bool> Disabled
    {
        set => SetProperty("disabled", value);
    }

}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Enable additive VPC scope DNS in a GKE cluster.
    /// </summary>
    public TerraformProperty<string>? AdditiveVpcScopeDnsDomain
    {
        set => SetProperty("additive_vpc_scope_dns_domain", value);
    }

    /// <summary>
    /// Which in-cluster DNS provider should be used.
    /// </summary>
    public TerraformProperty<string>? ClusterDns
    {
        set => SetProperty("cluster_dns", value);
    }

    /// <summary>
    /// The suffix used for all cluster service records.
    /// </summary>
    public TerraformProperty<string>? ClusterDnsDomain
    {
        set => SetProperty("cluster_dns_domain", value);
    }

    /// <summary>
    /// The scope of access to cluster DNS records.
    /// </summary>
    public TerraformProperty<string>? ClusterDnsScope
    {
        set => SetProperty("cluster_dns_scope", value);
    }

}

/// <summary>
/// Block type for enable_k8s_beta_apis in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterEnableK8sBetaApisBlock : TerraformBlock
{
    /// <summary>
    /// Enabled Kubernetes Beta APIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledApis is required")]
    public HashSet<TerraformProperty<string>>? EnabledApis
    {
        set => SetProperty("enabled_apis", value);
    }

}

/// <summary>
/// Block type for enterprise_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleContainerClusterEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Indicates the effective cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ClusterTier
    {
        set => SetProperty("cluster_tier", value);
    }

    /// <summary>
    /// Indicates the desired cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? DesiredTier
    {
        set => SetProperty("desired_tier", value);
    }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// Full resource name of the registered fleet membership of the cluster.
    /// </summary>
    public TerraformProperty<string>? Membership
    {
        set => SetProperty("membership", value);
    }

    /// <summary>
    /// Short name of the fleet membership, for example &amp;quot;member-1&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MembershipId
    {
        set => SetProperty("membership_id", value);
    }

    /// <summary>
    /// Location of the fleet membership, for example &amp;quot;us-central1&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MembershipLocation
    {
        set => SetProperty("membership_location", value);
    }

    /// <summary>
    /// The type of the cluster&#39;s fleet membership.
    /// </summary>
    public TerraformProperty<string>? MembershipType
    {
        set => SetProperty("membership_type", value);
    }

    /// <summary>
    /// Whether the cluster has been registered via the fleet API.
    /// </summary>
    public TerraformProperty<bool>? PreRegistered
    {
        set => SetProperty("pre_registered", value);
    }

    /// <summary>
    /// The Fleet host project of the cluster.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        set => SetProperty("project", value);
    }

}

/// <summary>
/// Block type for gateway_api_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGatewayApiConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Gateway API release channel to use for Gateway API.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformProperty<string> Channel
    {
        set => SetProperty("channel", value);
    }

}

/// <summary>
/// Block type for gke_auto_upgrade_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGkeAutoUpgradeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The selected auto-upgrade patch type. Accepted values are:
    /// * ACCELERATED: Upgrades to the latest available patch version in a given minor and release channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchMode is required")]
    public required TerraformProperty<string> PatchMode
    {
        set => SetProperty("patch_mode", value);
    }

}

/// <summary>
/// Block type for identity_service_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIdentityServiceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to enable the Identity Service component.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for ip_allocation_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    public TerraformProperty<string>? ClusterIpv4CidrBlock
    {
        set => SetProperty("cluster_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    public TerraformProperty<string>? ClusterSecondaryRangeName
    {
        set => SetProperty("cluster_secondary_range_name", value);
    }

    /// <summary>
    /// The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    public TerraformProperty<string>? ServicesIpv4CidrBlock
    {
        set => SetProperty("services_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    public TerraformProperty<string>? ServicesSecondaryRangeName
    {
        set => SetProperty("services_secondary_range_name", value);
    }

    /// <summary>
    /// The IP Stack type of the cluster. Choose between IPV4 and IPV4_IPV6. Default type is IPV4 Only if not set
    /// </summary>
    public TerraformProperty<string>? StackType
    {
        set => SetProperty("stack_type", value);
    }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// GKE components exposing logs. Valid values include SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, KCP_CONNECTION, KCP_SSHD, KCP_HPA, SCHEDULER, and WORKLOADS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableComponents is required")]
    public List<TerraformProperty<string>>? EnableComponents
    {
        set => SetProperty("enable_components", value);
    }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for master_auth in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthBlock : TerraformBlock
{
    /// <summary>
    /// Base64 encoded public certificate used by clients to authenticate to the cluster endpoint.
    /// </summary>
    public TerraformProperty<string>? ClientCertificate
    {
        set => SetProperty("client_certificate", value);
    }

    /// <summary>
    /// Base64 encoded private key used by clients to authenticate to the cluster endpoint.
    /// </summary>
    public TerraformProperty<string>? ClientKey
    {
        set => SetProperty("client_key", value);
    }

    /// <summary>
    /// Base64 encoded public certificate that is the root of trust for the cluster.
    /// </summary>
    public TerraformProperty<string>? ClusterCaCertificate
    {
        set => SetProperty("cluster_ca_certificate", value);
    }

}

/// <summary>
/// Block type for master_authorized_networks_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthorizedNetworksConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether Kubernetes master is accessible via Google Compute Engine Public IPs.
    /// </summary>
    public TerraformProperty<bool>? GcpPublicCidrsAccessEnabled
    {
        set => SetProperty("gcp_public_cidrs_access_enabled", value);
    }

    /// <summary>
    /// Whether authorized networks is enforced on the private endpoint or not. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? PrivateEndpointEnforcementEnabled
    {
        set => SetProperty("private_endpoint_enforcement_enabled", value);
    }

}

/// <summary>
/// Block type for mesh_certificates in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMeshCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// When enabled the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableCertificates is required")]
    public required TerraformProperty<bool> EnableCertificates
    {
        set => SetProperty("enable_certificates", value);
    }

}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlock : TerraformBlock
{
    /// <summary>
    /// GKE components exposing metrics. Valid values include SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET.
    /// </summary>
    public List<TerraformProperty<string>>? EnableComponents
    {
        set => SetProperty("enable_components", value);
    }

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the total network bandwidth tier for NodePools in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    public required TerraformProperty<string> TotalEgressBandwidthTier
    {
        set => SetProperty("total_egress_bandwidth_tier", value);
    }

}

/// <summary>
/// Block type for network_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Whether network policy is enabled on the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The selected network policy provider.
    /// </summary>
    public TerraformProperty<string>? Provider
    {
        set => SetProperty("provider", value);
    }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    public TerraformProperty<string>? BootDiskKmsKey
    {
        set => SetProperty("boot_disk_kms_key", value);
    }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        set => SetProperty("disk_type", value);
    }

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    public List<TerraformProperty<object>>? EffectiveTaints
    {
        set => SetProperty("effective_taints", value);
    }

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    public TerraformProperty<bool>? EnableConfidentialStorage
    {
        set => SetProperty("enable_confidential_storage", value);
    }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    public TerraformProperty<bool>? FlexStart
    {
        set => SetProperty("flex_start", value);
    }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    public TerraformProperty<string>? ImageType
    {
        set => SetProperty("image_type", value);
    }

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    public TerraformProperty<double>? LocalSsdCount
    {
        set => SetProperty("local_ssd_count", value);
    }

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    public TerraformProperty<string>? LocalSsdEncryptionMode
    {
        set => SetProperty("local_ssd_encryption_mode", value);
    }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    public TerraformProperty<string>? LoggingVariant
    {
        set => SetProperty("logging_variant", value);
    }

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        set => SetProperty("machine_type", value);
    }

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MaxRunDuration
    {
        set => SetProperty("max_run_duration", value);
    }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    public TerraformProperty<string>? MinCpuPlatform
    {
        set => SetProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    public TerraformProperty<string>? NodeGroup
    {
        set => SetProperty("node_group", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OauthScopes
    {
        set => SetProperty("oauth_scopes", value);
    }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    public TerraformProperty<bool>? Preemptible
    {
        set => SetProperty("preemptible", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceLabels
    {
        set => SetProperty("resource_labels", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        set => SetProperty("resource_manager_tags", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    public TerraformProperty<bool>? Spot
    {
        set => SetProperty("spot", value);
    }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    public List<TerraformProperty<string>>? StoragePools
    {
        set => SetProperty("storage_pools", value);
    }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Block type for node_pool in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlock : TerraformBlock
{
    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    public TerraformProperty<double>? InitialNodeCount
    {
        set => SetProperty("initial_node_count", value);
    }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    public List<TerraformProperty<string>>? InstanceGroupUrls
    {
        set => SetProperty("instance_group_urls", value);
    }

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    public List<TerraformProperty<string>>? ManagedInstanceGroupUrls
    {
        set => SetProperty("managed_instance_group_urls", value);
    }

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    public TerraformProperty<double>? MaxPodsPerNode
    {
        set => SetProperty("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NodeLocations
    {
        set => SetProperty("node_locations", value);
    }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for node_pool_auto_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlock : TerraformBlock
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        set => SetProperty("resource_manager_tags", value);
    }

}

/// <summary>
/// Block type for node_pool_defaults in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNotificationConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPodAutoscalingBlock : TerraformBlock
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
    public required TerraformProperty<string> HpaProfile
    {
        set => SetProperty("hpa_profile", value);
    }

}

/// <summary>
/// Block type for private_cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPrivateClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// When true, the cluster&#39;s private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateEndpoint
    {
        set => SetProperty("enable_private_endpoint", value);
    }

    /// <summary>
    /// Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master&#39;s private endpoint via private networking.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateNodes
    {
        set => SetProperty("enable_private_nodes", value);
    }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster&#39;s network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.
    /// </summary>
    public TerraformProperty<string>? MasterIpv4CidrBlock
    {
        set => SetProperty("master_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the peering between this cluster and the Google owned VPC.
    /// </summary>
    public TerraformProperty<string>? PeeringName
    {
        set => SetProperty("peering_name", value);
    }

    /// <summary>
    /// The internal IP address of this cluster&#39;s master endpoint.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpoint
    {
        set => SetProperty("private_endpoint", value);
    }

    /// <summary>
    /// Subnetwork in cluster&#39;s network where master&#39;s endpoint will be provisioned.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointSubnetwork
    {
        set => SetProperty("private_endpoint_subnetwork", value);
    }

    /// <summary>
    /// The external IP address of this cluster&#39;s master endpoint.
    /// </summary>
    public TerraformProperty<string>? PublicEndpoint
    {
        set => SetProperty("public_endpoint", value);
    }

}

/// <summary>
/// Block type for rbac_binding_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterRbacBindingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:authenticated.
    /// </summary>
    public TerraformProperty<bool>? EnableInsecureBindingSystemAuthenticated
    {
        set => SetProperty("enable_insecure_binding_system_authenticated", value);
    }

    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:anonymous or system:unauthenticated.
    /// </summary>
    public TerraformProperty<bool>? EnableInsecureBindingSystemUnauthenticated
    {
        set => SetProperty("enable_insecure_binding_system_unauthenticated", value);
    }

}

/// <summary>
/// Block type for release_channel in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterReleaseChannelBlock : TerraformBlock
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
    public required TerraformProperty<string> Channel
    {
        set => SetProperty("channel", value);
    }

}

/// <summary>
/// Block type for resource_usage_export_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterResourceUsageExportConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.
    /// </summary>
    public TerraformProperty<bool>? EnableNetworkEgressMetering
    {
        set => SetProperty("enable_network_egress_metering", value);
    }

    /// <summary>
    /// Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceConsumptionMetering
    {
        set => SetProperty("enable_resource_consumption_metering", value);
    }

}

/// <summary>
/// Block type for secret_manager_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecretManagerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Enable the Secret manager csi component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecurityPostureConfigBlock : TerraformBlock
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.
    /// </summary>
    public TerraformProperty<string>? VulnerabilityMode
    {
        set => SetProperty("vulnerability_mode", value);
    }

}

/// <summary>
/// Block type for service_external_ips_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterServiceExternalIpsConfigBlock : TerraformBlock
{
    /// <summary>
    /// When enabled, services with external ips specified will be allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerClusterTimeoutsBlock : TerraformBlock
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
/// Block type for user_managed_keys_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterUserManagedKeysConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Certificate Authority Service caPool to use for the aggreation CA in this cluster.
    /// </summary>
    public TerraformProperty<string>? AggregationCa
    {
        set => SetProperty("aggregation_ca", value);
    }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the cluster CA in this cluster.
    /// </summary>
    public TerraformProperty<string>? ClusterCa
    {
        set => SetProperty("cluster_ca", value);
    }

    /// <summary>
    /// The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.
    /// </summary>
    public TerraformProperty<string>? ControlPlaneDiskEncryptionKey
    {
        set => SetProperty("control_plane_disk_encryption_key", value);
    }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd API CA in this cluster.
    /// </summary>
    public TerraformProperty<string>? EtcdApiCa
    {
        set => SetProperty("etcd_api_ca", value);
    }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.
    /// </summary>
    public TerraformProperty<string>? EtcdPeerCa
    {
        set => SetProperty("etcd_peer_ca", value);
    }

    /// <summary>
    /// Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.
    /// </summary>
    public TerraformProperty<string>? GkeopsEtcdBackupEncryptionKey
    {
        set => SetProperty("gkeops_etcd_backup_encryption_key", value);
    }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServiceAccountSigningKeys
    {
        set => SetProperty("service_account_signing_keys", value);
    }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServiceAccountVerificationKeys
    {
        set => SetProperty("service_account_verification_keys", value);
    }

}

/// <summary>
/// Block type for vertical_pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterVerticalPodAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Enables vertical pod autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for workload_identity_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterWorkloadIdentityConfigBlock : TerraformBlock
{
    /// <summary>
    /// The workload pool to attach all Kubernetes service accounts to.
    /// </summary>
    public TerraformProperty<string>? WorkloadPool
    {
        set => SetProperty("workload_pool", value);
    }

}

/// <summary>
/// Manages a google_container_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerCluster : TerraformResource
{
    public GoogleContainerCluster(string name) : base("google_container_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("endpoint");
        SetOutput("label_fingerprint");
        SetOutput("master_version");
        SetOutput("operation");
        SetOutput("self_link");
        SetOutput("services_ipv4_cidr");
        SetOutput("terraform_labels");
        SetOutput("tpu_ipv4_cidr_block");
        SetOutput("allow_net_admin");
        SetOutput("cluster_ipv4_cidr");
        SetOutput("datapath_provider");
        SetOutput("default_max_pods_per_node");
        SetOutput("deletion_protection");
        SetOutput("description");
        SetOutput("disable_l4_lb_firewall_reconciliation");
        SetOutput("enable_autopilot");
        SetOutput("enable_cilium_clusterwide_network_policy");
        SetOutput("enable_fqdn_network_policy");
        SetOutput("enable_intranode_visibility");
        SetOutput("enable_kubernetes_alpha");
        SetOutput("enable_l4_ilb_subsetting");
        SetOutput("enable_legacy_abac");
        SetOutput("enable_multi_networking");
        SetOutput("enable_shielded_nodes");
        SetOutput("enable_tpu");
        SetOutput("id");
        SetOutput("in_transit_encryption_config");
        SetOutput("initial_node_count");
        SetOutput("location");
        SetOutput("logging_service");
        SetOutput("min_master_version");
        SetOutput("monitoring_service");
        SetOutput("name");
        SetOutput("network");
        SetOutput("networking_mode");
        SetOutput("node_locations");
        SetOutput("node_version");
        SetOutput("private_ipv6_google_access");
        SetOutput("project");
        SetOutput("remove_default_node_pool");
        SetOutput("resource_labels");
        SetOutput("subnetwork");
    }

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    public TerraformProperty<bool> AllowNetAdmin
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_net_admin");
        set => SetProperty("allow_net_admin", value);
    }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    public TerraformProperty<string> ClusterIpv4Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_ipv4_cidr");
        set => SetProperty("cluster_ipv4_cidr", value);
    }

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    public TerraformProperty<string> DatapathProvider
    {
        get => GetRequiredOutput<TerraformProperty<string>>("datapath_provider");
        set => SetProperty("datapath_provider", value);
    }

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    public TerraformProperty<double> DefaultMaxPodsPerNode
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_max_pods_per_node");
        set => SetProperty("default_max_pods_per_node", value);
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    public TerraformProperty<bool> DisableL4LbFirewallReconciliation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_l4_lb_firewall_reconciliation");
        set => SetProperty("disable_l4_lb_firewall_reconciliation", value);
    }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    public TerraformProperty<bool> EnableAutopilot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_autopilot");
        set => SetProperty("enable_autopilot", value);
    }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    public TerraformProperty<bool> EnableCiliumClusterwideNetworkPolicy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_cilium_clusterwide_network_policy");
        set => SetProperty("enable_cilium_clusterwide_network_policy", value);
    }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    public TerraformProperty<bool> EnableFqdnNetworkPolicy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_fqdn_network_policy");
        set => SetProperty("enable_fqdn_network_policy", value);
    }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    public TerraformProperty<bool> EnableIntranodeVisibility
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_intranode_visibility");
        set => SetProperty("enable_intranode_visibility", value);
    }

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    public TerraformProperty<bool> EnableKubernetesAlpha
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_kubernetes_alpha");
        set => SetProperty("enable_kubernetes_alpha", value);
    }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    public TerraformProperty<bool> EnableL4IlbSubsetting
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_l4_ilb_subsetting");
        set => SetProperty("enable_l4_ilb_subsetting", value);
    }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    public TerraformProperty<bool> EnableLegacyAbac
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_legacy_abac");
        set => SetProperty("enable_legacy_abac", value);
    }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    public TerraformProperty<bool> EnableMultiNetworking
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_multi_networking");
        set => SetProperty("enable_multi_networking", value);
    }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    public TerraformProperty<bool> EnableShieldedNodes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_shielded_nodes");
        set => SetProperty("enable_shielded_nodes", value);
    }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    public TerraformProperty<bool> EnableTpu
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_tpu");
        set => SetProperty("enable_tpu", value);
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
    /// Defines the config of in-transit encryption
    /// </summary>
    public TerraformProperty<string> InTransitEncryptionConfig
    {
        get => GetRequiredOutput<TerraformProperty<string>>("in_transit_encryption_config");
        set => SetProperty("in_transit_encryption_config", value);
    }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    public TerraformProperty<double> InitialNodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("initial_node_count");
        set => SetProperty("initial_node_count", value);
    }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    public TerraformProperty<string> LoggingService
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logging_service");
        set => SetProperty("logging_service", value);
    }

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    public TerraformProperty<string> MinMasterVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("min_master_version");
        set => SetProperty("min_master_version", value);
    }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    public TerraformProperty<string> MonitoringService
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitoring_service");
        set => SetProperty("monitoring_service", value);
    }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    public TerraformProperty<string> NetworkingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("networking_mode");
        set => SetProperty("networking_mode", value);
    }

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    public HashSet<TerraformProperty<string>> NodeLocations
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("node_locations");
        set => SetProperty("node_locations", value);
    }

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    public TerraformProperty<string> NodeVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_version");
        set => SetProperty("node_version", value);
    }

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    public TerraformProperty<string> PrivateIpv6GoogleAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_ipv6_google_access");
        set => SetProperty("private_ipv6_google_access", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    public TerraformProperty<bool> RemoveDefaultNodePool
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("remove_default_node_pool");
        set => SetProperty("remove_default_node_pool", value);
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResourceLabels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("resource_labels");
        set => SetProperty("resource_labels", value);
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    public TerraformProperty<string> Subnetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnetwork");
        set => SetProperty("subnetwork", value);
    }

    /// <summary>
    /// Block for addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    public List<GoogleContainerClusterAddonsConfigBlock>? AddonsConfig
    {
        set => SetProperty("addons_config", value);
    }

    /// <summary>
    /// Block for anonymous_authentication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnonymousAuthenticationConfig block(s) allowed")]
    public List<GoogleContainerClusterAnonymousAuthenticationConfigBlock>? AnonymousAuthenticationConfig
    {
        set => SetProperty("anonymous_authentication_config", value);
    }

    /// <summary>
    /// Block for authenticator_groups_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticatorGroupsConfig block(s) allowed")]
    public List<GoogleContainerClusterAuthenticatorGroupsConfigBlock>? AuthenticatorGroupsConfig
    {
        set => SetProperty("authenticator_groups_config", value);
    }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public List<GoogleContainerClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        set => SetProperty("binary_authorization", value);
    }

    /// <summary>
    /// Block for cluster_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterAutoscaling block(s) allowed")]
    public List<GoogleContainerClusterClusterAutoscalingBlock>? ClusterAutoscaling
    {
        set => SetProperty("cluster_autoscaling", value);
    }

    /// <summary>
    /// Block for confidential_nodes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    public List<GoogleContainerClusterConfidentialNodesBlock>? ConfidentialNodes
    {
        set => SetProperty("confidential_nodes", value);
    }

    /// <summary>
    /// Block for control_plane_endpoints_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEndpointsConfig block(s) allowed")]
    public List<GoogleContainerClusterControlPlaneEndpointsConfigBlock>? ControlPlaneEndpointsConfig
    {
        set => SetProperty("control_plane_endpoints_config", value);
    }

    /// <summary>
    /// Block for cost_management_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostManagementConfig block(s) allowed")]
    public List<GoogleContainerClusterCostManagementConfigBlock>? CostManagementConfig
    {
        set => SetProperty("cost_management_config", value);
    }

    /// <summary>
    /// Block for database_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    public List<GoogleContainerClusterDatabaseEncryptionBlock>? DatabaseEncryption
    {
        set => SetProperty("database_encryption", value);
    }

    /// <summary>
    /// Block for default_snat_status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSnatStatus block(s) allowed")]
    public List<GoogleContainerClusterDefaultSnatStatusBlock>? DefaultSnatStatus
    {
        set => SetProperty("default_snat_status", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public List<GoogleContainerClusterDnsConfigBlock>? DnsConfig
    {
        set => SetProperty("dns_config", value);
    }

    /// <summary>
    /// Block for enable_k8s_beta_apis.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnableK8sBetaApis block(s) allowed")]
    public List<GoogleContainerClusterEnableK8sBetaApisBlock>? EnableK8sBetaApis
    {
        set => SetProperty("enable_k8s_beta_apis", value);
    }

    /// <summary>
    /// Block for enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnterpriseConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<GoogleContainerClusterEnterpriseConfigBlock>? EnterpriseConfig
    {
        set => SetProperty("enterprise_config", value);
    }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public List<GoogleContainerClusterFleetBlock>? Fleet
    {
        set => SetProperty("fleet", value);
    }

    /// <summary>
    /// Block for gateway_api_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GatewayApiConfig block(s) allowed")]
    public List<GoogleContainerClusterGatewayApiConfigBlock>? GatewayApiConfig
    {
        set => SetProperty("gateway_api_config", value);
    }

    /// <summary>
    /// Block for gke_auto_upgrade_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeAutoUpgradeConfig block(s) allowed")]
    public List<GoogleContainerClusterGkeAutoUpgradeConfigBlock>? GkeAutoUpgradeConfig
    {
        set => SetProperty("gke_auto_upgrade_config", value);
    }

    /// <summary>
    /// Block for identity_service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityServiceConfig block(s) allowed")]
    public List<GoogleContainerClusterIdentityServiceConfigBlock>? IdentityServiceConfig
    {
        set => SetProperty("identity_service_config", value);
    }

    /// <summary>
    /// Block for ip_allocation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAllocationPolicy block(s) allowed")]
    public List<GoogleContainerClusterIpAllocationPolicyBlock>? IpAllocationPolicy
    {
        set => SetProperty("ip_allocation_policy", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleContainerClusterLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
    }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public List<GoogleContainerClusterMaintenancePolicyBlock>? MaintenancePolicy
    {
        set => SetProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Block for master_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuth block(s) allowed")]
    public List<GoogleContainerClusterMasterAuthBlock>? MasterAuth
    {
        set => SetProperty("master_auth", value);
    }

    /// <summary>
    /// Block for master_authorized_networks_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuthorizedNetworksConfig block(s) allowed")]
    public List<GoogleContainerClusterMasterAuthorizedNetworksConfigBlock>? MasterAuthorizedNetworksConfig
    {
        set => SetProperty("master_authorized_networks_config", value);
    }

    /// <summary>
    /// Block for mesh_certificates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MeshCertificates block(s) allowed")]
    public List<GoogleContainerClusterMeshCertificatesBlock>? MeshCertificates
    {
        set => SetProperty("mesh_certificates", value);
    }

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    public List<GoogleContainerClusterMonitoringConfigBlock>? MonitoringConfig
    {
        set => SetProperty("monitoring_config", value);
    }

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    public List<GoogleContainerClusterNetworkPerformanceConfigBlock>? NetworkPerformanceConfig
    {
        set => SetProperty("network_performance_config", value);
    }

    /// <summary>
    /// Block for network_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPolicy block(s) allowed")]
    public List<GoogleContainerClusterNetworkPolicyBlock>? NetworkPolicy
    {
        set => SetProperty("network_policy", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleContainerClusterNodeConfigBlock>? NodeConfig
    {
        set => SetProperty("node_config", value);
    }

    /// <summary>
    /// Block for node_pool.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleContainerClusterNodePoolBlock>? NodePool
    {
        set => SetProperty("node_pool", value);
    }

    /// <summary>
    /// Block for node_pool_auto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoConfig block(s) allowed")]
    public List<GoogleContainerClusterNodePoolAutoConfigBlock>? NodePoolAutoConfig
    {
        set => SetProperty("node_pool_auto_config", value);
    }

    /// <summary>
    /// Block for node_pool_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolDefaults block(s) allowed")]
    public List<GoogleContainerClusterNodePoolDefaultsBlock>? NodePoolDefaults
    {
        set => SetProperty("node_pool_defaults", value);
    }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public List<GoogleContainerClusterNotificationConfigBlock>? NotificationConfig
    {
        set => SetProperty("notification_config", value);
    }

    /// <summary>
    /// Block for pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodAutoscaling block(s) allowed")]
    public List<GoogleContainerClusterPodAutoscalingBlock>? PodAutoscaling
    {
        set => SetProperty("pod_autoscaling", value);
    }

    /// <summary>
    /// Block for private_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateClusterConfig block(s) allowed")]
    public List<GoogleContainerClusterPrivateClusterConfigBlock>? PrivateClusterConfig
    {
        set => SetProperty("private_cluster_config", value);
    }

    /// <summary>
    /// Block for rbac_binding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RbacBindingConfig block(s) allowed")]
    public List<GoogleContainerClusterRbacBindingConfigBlock>? RbacBindingConfig
    {
        set => SetProperty("rbac_binding_config", value);
    }

    /// <summary>
    /// Block for release_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseChannel block(s) allowed")]
    public List<GoogleContainerClusterReleaseChannelBlock>? ReleaseChannel
    {
        set => SetProperty("release_channel", value);
    }

    /// <summary>
    /// Block for resource_usage_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceUsageExportConfig block(s) allowed")]
    public List<GoogleContainerClusterResourceUsageExportConfigBlock>? ResourceUsageExportConfig
    {
        set => SetProperty("resource_usage_export_config", value);
    }

    /// <summary>
    /// Block for secret_manager_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerConfig block(s) allowed")]
    public List<GoogleContainerClusterSecretManagerConfigBlock>? SecretManagerConfig
    {
        set => SetProperty("secret_manager_config", value);
    }

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    public List<GoogleContainerClusterSecurityPostureConfigBlock>? SecurityPostureConfig
    {
        set => SetProperty("security_posture_config", value);
    }

    /// <summary>
    /// Block for service_external_ips_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceExternalIpsConfig block(s) allowed")]
    public List<GoogleContainerClusterServiceExternalIpsConfigBlock>? ServiceExternalIpsConfig
    {
        set => SetProperty("service_external_ips_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_managed_keys_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedKeysConfig block(s) allowed")]
    public List<GoogleContainerClusterUserManagedKeysConfigBlock>? UserManagedKeysConfig
    {
        set => SetProperty("user_managed_keys_config", value);
    }

    /// <summary>
    /// Block for vertical_pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerticalPodAutoscaling block(s) allowed")]
    public List<GoogleContainerClusterVerticalPodAutoscalingBlock>? VerticalPodAutoscaling
    {
        set => SetProperty("vertical_pod_autoscaling", value);
    }

    /// <summary>
    /// Block for workload_identity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadIdentityConfig block(s) allowed")]
    public List<GoogleContainerClusterWorkloadIdentityConfigBlock>? WorkloadIdentityConfig
    {
        set => SetProperty("workload_identity_config", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    public TerraformExpression MasterVersion => this["master_version"];

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    public TerraformExpression ServicesIpv4Cidr => this["services_ipv4_cidr"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    public TerraformExpression TpuIpv4CidrBlock => this["tpu_ipv4_cidr_block"];

}
