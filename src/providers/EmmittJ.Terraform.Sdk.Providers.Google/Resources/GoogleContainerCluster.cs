using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAddonsConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for anonymous_authentication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAnonymousAuthenticationConfigBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for authenticator_groups_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterAuthenticatorGroupsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroup is required")]
    [TerraformPropertyName("security_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityGroup { get; set; }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterBinaryAuthorizationBlock : ITerraformBlock
{
    /// <summary>
    /// Enable Binary Authorization for this cluster.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation.
    /// </summary>
    [TerraformPropertyName("evaluation_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EvaluationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "evaluation_mode");

}

/// <summary>
/// Block type for cluster_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterClusterAutoscalingBlock : ITerraformBlock
{
    /// <summary>
    /// The list of Google Compute Engine zones in which the NodePool&#39;s nodes can be created by NAP.
    /// </summary>
    [TerraformPropertyName("auto_provisioning_locations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> AutoProvisioningLocations { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "auto_provisioning_locations");

    /// <summary>
    /// Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.
    /// </summary>
    [TerraformPropertyName("autoscaling_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoscalingProfile { get; set; }

    /// <summary>
    /// Specifies whether default compute class behaviour is enabled. If enabled, cluster autoscaler will use Compute Class with name default for all the workloads, if not overriden.
    /// </summary>
    [TerraformPropertyName("default_compute_class_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultComputeClassEnabled { get; set; }

    /// <summary>
    /// Whether node auto-provisioning is enabled. Resource limits for cpu and memory must be defined to enable node auto-provisioning.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

}

/// <summary>
/// Block type for confidential_nodes in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterConfidentialNodesBlock : ITerraformBlock
{
    /// <summary>
    /// Defines the type of technology used by the confidential node.
    /// </summary>
    [TerraformPropertyName("confidential_instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfidentialInstanceType { get; set; }

    /// <summary>
    /// Whether Confidential Nodes feature is enabled for all nodes in this cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for control_plane_endpoints_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterControlPlaneEndpointsConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for cost_management_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterCostManagementConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to enable GKE cost allocation. When you enable GKE cost allocation, the cluster name and namespace of your GKE workloads appear in the labels field of the billing export to BigQuery. Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for database_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDatabaseEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The key to use to encrypt/decrypt secrets.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyName { get; set; }

    /// <summary>
    /// ENCRYPTED or DECRYPTED.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> State { get; set; }

}

/// <summary>
/// Block type for default_snat_status in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDefaultSnatStatusBlock : ITerraformBlock
{
    /// <summary>
    /// When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    [TerraformPropertyName("disabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Disabled { get; set; }

}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterDnsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Enable additive VPC scope DNS in a GKE cluster.
    /// </summary>
    [TerraformPropertyName("additive_vpc_scope_dns_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdditiveVpcScopeDnsDomain { get; set; }

    /// <summary>
    /// Which in-cluster DNS provider should be used.
    /// </summary>
    [TerraformPropertyName("cluster_dns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterDns { get; set; }

    /// <summary>
    /// The suffix used for all cluster service records.
    /// </summary>
    [TerraformPropertyName("cluster_dns_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterDnsDomain { get; set; }

    /// <summary>
    /// The scope of access to cluster DNS records.
    /// </summary>
    [TerraformPropertyName("cluster_dns_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterDnsScope { get; set; }

}

/// <summary>
/// Block type for enable_k8s_beta_apis in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterEnableK8sBetaApisBlock : ITerraformBlock
{
    /// <summary>
    /// Enabled Kubernetes Beta APIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledApis is required")]
    [TerraformPropertyName("enabled_apis")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledApis { get; set; }

}

/// <summary>
/// Block type for enterprise_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleContainerClusterEnterpriseConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Indicates the effective cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("cluster_tier")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterTier => new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_tier");

    /// <summary>
    /// Indicates the desired cluster tier. Available options include STANDARD and ENTERPRISE.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("desired_tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DesiredTier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "desired_tier");

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterFleetBlock : ITerraformBlock
{
    /// <summary>
    /// Full resource name of the registered fleet membership of the cluster.
    /// </summary>
    [TerraformPropertyName("membership")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Membership => new TerraformReferenceProperty<TerraformProperty<string>>("", "membership");

    /// <summary>
    /// Short name of the fleet membership, for example &amp;quot;member-1&amp;quot;.
    /// </summary>
    [TerraformPropertyName("membership_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MembershipId => new TerraformReferenceProperty<TerraformProperty<string>>("", "membership_id");

    /// <summary>
    /// Location of the fleet membership, for example &amp;quot;us-central1&amp;quot;.
    /// </summary>
    [TerraformPropertyName("membership_location")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MembershipLocation => new TerraformReferenceProperty<TerraformProperty<string>>("", "membership_location");

    /// <summary>
    /// The type of the cluster&#39;s fleet membership.
    /// </summary>
    [TerraformPropertyName("membership_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MembershipType { get; set; }

    /// <summary>
    /// Whether the cluster has been registered via the fleet API.
    /// </summary>
    [TerraformPropertyName("pre_registered")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PreRegistered => new TerraformReferenceProperty<TerraformProperty<bool>>("", "pre_registered");

    /// <summary>
    /// The Fleet host project of the cluster.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

}

/// <summary>
/// Block type for gateway_api_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGatewayApiConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The Gateway API release channel to use for Gateway API.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformPropertyName("channel")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Channel { get; set; }

}

/// <summary>
/// Block type for gke_auto_upgrade_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterGkeAutoUpgradeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The selected auto-upgrade patch type. Accepted values are:
    /// * ACCELERATED: Upgrades to the latest available patch version in a given minor and release channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchMode is required")]
    [TerraformPropertyName("patch_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PatchMode { get; set; }

}

/// <summary>
/// Block type for identity_service_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIdentityServiceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to enable the Identity Service component.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

}

/// <summary>
/// Block type for ip_allocation_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterIpAllocationPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    [TerraformPropertyName("cluster_ipv4_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterIpv4CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_ipv4_cidr_block");

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    [TerraformPropertyName("cluster_secondary_range_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterSecondaryRangeName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_secondary_range_name");

    /// <summary>
    /// The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// </summary>
    [TerraformPropertyName("services_ipv4_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServicesIpv4CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "services_ipv4_cidr_block");

    /// <summary>
    /// The name of the existing secondary range in the cluster&#39;s subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.
    /// </summary>
    [TerraformPropertyName("services_secondary_range_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServicesSecondaryRangeName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "services_secondary_range_name");

    /// <summary>
    /// The IP Stack type of the cluster. Choose between IPV4 and IPV4_IPV6. Default type is IPV4 Only if not set
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StackType { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// GKE components exposing logs. Valid values include SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, KCP_CONNECTION, KCP_SSHD, KCP_HPA, SCHEDULER, and WORKLOADS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableComponents is required")]
    [TerraformPropertyName("enable_components")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? EnableComponents { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMaintenancePolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for master_auth in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthBlock : ITerraformBlock
{
    /// <summary>
    /// Base64 encoded public certificate used by clients to authenticate to the cluster endpoint.
    /// </summary>
    [TerraformPropertyName("client_certificate")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientCertificate => new TerraformReferenceProperty<TerraformProperty<string>>("", "client_certificate");

    /// <summary>
    /// Base64 encoded private key used by clients to authenticate to the cluster endpoint.
    /// </summary>
    [TerraformPropertyName("client_key")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientKey => new TerraformReferenceProperty<TerraformProperty<string>>("", "client_key");

    /// <summary>
    /// Base64 encoded public certificate that is the root of trust for the cluster.
    /// </summary>
    [TerraformPropertyName("cluster_ca_certificate")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterCaCertificate => new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_ca_certificate");

}

/// <summary>
/// Block type for master_authorized_networks_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMasterAuthorizedNetworksConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether Kubernetes master is accessible via Google Compute Engine Public IPs.
    /// </summary>
    [TerraformPropertyName("gcp_public_cidrs_access_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> GcpPublicCidrsAccessEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "gcp_public_cidrs_access_enabled");

    /// <summary>
    /// Whether authorized networks is enforced on the private endpoint or not. Defaults to false.
    /// </summary>
    [TerraformPropertyName("private_endpoint_enforcement_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PrivateEndpointEnforcementEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "private_endpoint_enforcement_enabled");

}

/// <summary>
/// Block type for mesh_certificates in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMeshCertificatesBlock : ITerraformBlock
{
    /// <summary>
    /// When enabled the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableCertificates is required")]
    [TerraformPropertyName("enable_certificates")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnableCertificates { get; set; }

}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterMonitoringConfigBlock : ITerraformBlock
{
    /// <summary>
    /// GKE components exposing metrics. Valid values include SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET.
    /// </summary>
    [TerraformPropertyName("enable_components")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> EnableComponents { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "enable_components");

}

/// <summary>
/// Block type for network_performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPerformanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the total network bandwidth tier for NodePools in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalEgressBandwidthTier is required")]
    [TerraformPropertyName("total_egress_bandwidth_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TotalEgressBandwidthTier { get; set; }

}

/// <summary>
/// Block type for network_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNetworkPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Whether network policy is enabled on the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The selected network policy provider.
    /// </summary>
    [TerraformPropertyName("provider")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Provider { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
    /// </summary>
    [TerraformPropertyName("boot_disk_kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BootDiskKmsKey { get; set; }

    /// <summary>
    /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_type");

    /// <summary>
    /// List of kubernetes taints applied to each node.
    /// </summary>
    [TerraformPropertyName("effective_taints")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EffectiveTaints => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "effective_taints");

    /// <summary>
    /// If enabled boot disks are configured with confidential mode.
    /// </summary>
    [TerraformPropertyName("enable_confidential_storage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableConfidentialStorage { get; set; }

    /// <summary>
    /// Enables Flex Start provisioning model for the node pool
    /// </summary>
    [TerraformPropertyName("flex_start")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FlexStart { get; set; }

    /// <summary>
    /// The image type to use for this node. Note that for a given image type, the latest version of it will be used.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ImageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "image_type");

    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "labels");

    /// <summary>
    /// The number of local SSD disks to be attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> LocalSsdCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "local_ssd_count");

    /// <summary>
    /// LocalSsdEncryptionMode specified the method used for encrypting the local SSDs attached to the node.
    /// </summary>
    [TerraformPropertyName("local_ssd_encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocalSsdEncryptionMode { get; set; }

    /// <summary>
    /// Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.
    /// </summary>
    [TerraformPropertyName("logging_variant")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoggingVariant { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "logging_variant");

    /// <summary>
    /// The name of a Google Compute Engine machine type.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MachineType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "machine_type");

    /// <summary>
    /// The runtime of each node in the node pool in seconds, terminated by &#39;s&#39;. Example: &amp;quot;3600s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("max_run_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxRunDuration { get; set; }

    /// <summary>
    /// The metadata key/value pairs assigned to instances in the cluster.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "metadata");

    /// <summary>
    /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinCpuPlatform { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_cpu_platform");

    /// <summary>
    /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.
    /// </summary>
    [TerraformPropertyName("node_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeGroup { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all of the node VMs.
    /// </summary>
    [TerraformPropertyName("oauth_scopes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> OauthScopes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "oauth_scopes");

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// </summary>
    [TerraformPropertyName("preemptible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Preemptible { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the node pool.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceLabels { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceManagerTags { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceAccount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_account");

    /// <summary>
    /// Whether the nodes are created as spot VM instances.
    /// </summary>
    [TerraformPropertyName("spot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Spot { get; set; }

    /// <summary>
    /// The list of Storage Pools where boot disks are provisioned.
    /// </summary>
    [TerraformPropertyName("storage_pools")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? StoragePools { get; set; }

    /// <summary>
    /// The list of instance tags applied to all nodes.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Tags { get; set; }

}

/// <summary>
/// Block type for node_pool in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolBlock : ITerraformBlock
{
    /// <summary>
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> InitialNodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "initial_node_count");

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    [TerraformPropertyName("instance_group_urls")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InstanceGroupUrls => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "instance_group_urls");

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    [TerraformPropertyName("managed_instance_group_urls")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ManagedInstanceGroupUrls => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "managed_instance_group_urls");

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("max_pods_per_node")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxPodsPerNode { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_pods_per_node");

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name_prefix");

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "node_count");

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> NodeLocations { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "node_locations");

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for node_pool_auto_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolAutoConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for node_pool_defaults in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNodePoolDefaultsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterNotificationConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPodAutoscalingBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> HpaProfile { get; set; }

}

/// <summary>
/// Block type for private_cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterPrivateClusterConfigBlock : ITerraformBlock
{
    /// <summary>
    /// When true, the cluster&#39;s private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used.
    /// </summary>
    [TerraformPropertyName("enable_private_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePrivateEndpoint { get; set; }

    /// <summary>
    /// Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master&#39;s private endpoint via private networking.
    /// </summary>
    [TerraformPropertyName("enable_private_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePrivateNodes { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster&#39;s network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.
    /// </summary>
    [TerraformPropertyName("master_ipv4_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MasterIpv4CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "master_ipv4_cidr_block");

    /// <summary>
    /// The name of the peering between this cluster and the Google owned VPC.
    /// </summary>
    [TerraformPropertyName("peering_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeeringName => new TerraformReferenceProperty<TerraformProperty<string>>("", "peering_name");

    /// <summary>
    /// The internal IP address of this cluster&#39;s master endpoint.
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_endpoint");

    /// <summary>
    /// Subnetwork in cluster&#39;s network where master&#39;s endpoint will be provisioned.
    /// </summary>
    [TerraformPropertyName("private_endpoint_subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateEndpointSubnetwork { get; set; }

    /// <summary>
    /// The external IP address of this cluster&#39;s master endpoint.
    /// </summary>
    [TerraformPropertyName("public_endpoint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>("", "public_endpoint");

}

/// <summary>
/// Block type for rbac_binding_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterRbacBindingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:authenticated.
    /// </summary>
    [TerraformPropertyName("enable_insecure_binding_system_authenticated")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableInsecureBindingSystemAuthenticated { get; set; }

    /// <summary>
    /// Setting this to true will allow any ClusterRoleBinding and RoleBinding with subjects system:anonymous or system:unauthenticated.
    /// </summary>
    [TerraformPropertyName("enable_insecure_binding_system_unauthenticated")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableInsecureBindingSystemUnauthenticated { get; set; }

}

/// <summary>
/// Block type for release_channel in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterReleaseChannelBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> Channel { get; set; }

}

/// <summary>
/// Block type for resource_usage_export_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterResourceUsageExportConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.
    /// </summary>
    [TerraformPropertyName("enable_network_egress_metering")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableNetworkEgressMetering { get; set; }

    /// <summary>
    /// Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_resource_consumption_metering")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableResourceConsumptionMetering { get; set; }

}

/// <summary>
/// Block type for secret_manager_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecretManagerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Enable the Secret manager csi component.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterSecurityPostureConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.
    /// </summary>
    [TerraformPropertyName("vulnerability_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VulnerabilityMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "vulnerability_mode");

}

/// <summary>
/// Block type for service_external_ips_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterServiceExternalIpsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// When enabled, services with external ips specified will be allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerClusterTimeoutsBlock : ITerraformBlock
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
/// Block type for user_managed_keys_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterUserManagedKeysConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The Certificate Authority Service caPool to use for the aggreation CA in this cluster.
    /// </summary>
    [TerraformPropertyName("aggregation_ca")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AggregationCa { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the cluster CA in this cluster.
    /// </summary>
    [TerraformPropertyName("cluster_ca")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterCa { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.
    /// </summary>
    [TerraformPropertyName("control_plane_disk_encryption_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ControlPlaneDiskEncryptionKey { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd API CA in this cluster.
    /// </summary>
    [TerraformPropertyName("etcd_api_ca")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EtcdApiCa { get; set; }

    /// <summary>
    /// The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.
    /// </summary>
    [TerraformPropertyName("etcd_peer_ca")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EtcdPeerCa { get; set; }

    /// <summary>
    /// Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.
    /// </summary>
    [TerraformPropertyName("gkeops_etcd_backup_encryption_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GkeopsEtcdBackupEncryptionKey { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.
    /// </summary>
    [TerraformPropertyName("service_account_signing_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServiceAccountSigningKeys { get; set; }

    /// <summary>
    /// The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.
    /// </summary>
    [TerraformPropertyName("service_account_verification_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServiceAccountVerificationKeys { get; set; }

}

/// <summary>
/// Block type for vertical_pod_autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterVerticalPodAutoscalingBlock : ITerraformBlock
{
    /// <summary>
    /// Enables vertical pod autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for workload_identity_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerClusterWorkloadIdentityConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The workload pool to attach all Kubernetes service accounts to.
    /// </summary>
    [TerraformPropertyName("workload_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkloadPool { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AllowNetAdmin { get; set; }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    [TerraformPropertyName("cluster_ipv4_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterIpv4Cidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_ipv4_cidr");

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    [TerraformPropertyName("datapath_provider")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatapathProvider { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "datapath_provider");

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("default_max_pods_per_node")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DefaultMaxPodsPerNode { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_max_pods_per_node");

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    [TerraformPropertyName("disable_l4_lb_firewall_reconciliation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableL4LbFirewallReconciliation { get; set; }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_autopilot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAutopilot { get; set; }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    [TerraformPropertyName("enable_cilium_clusterwide_network_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableCiliumClusterwideNetworkPolicy { get; set; }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    [TerraformPropertyName("enable_fqdn_network_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    [TerraformPropertyName("enable_intranode_visibility")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableIntranodeVisibility { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_intranode_visibility");

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    [TerraformPropertyName("enable_kubernetes_alpha")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableKubernetesAlpha { get; set; }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_l4_ilb_subsetting")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableL4IlbSubsetting { get; set; }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    [TerraformPropertyName("enable_legacy_abac")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLegacyAbac { get; set; }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_multi_networking")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableMultiNetworking { get; set; }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_shielded_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableShieldedNodes { get; set; }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    [TerraformPropertyName("enable_tpu")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableTpu { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    [TerraformPropertyName("in_transit_encryption_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InTransitEncryptionConfig { get; set; }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialNodeCount { get; set; }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Location { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    [TerraformPropertyName("logging_service")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoggingService { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logging_service");

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    [TerraformPropertyName("min_master_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinMasterVersion { get; set; }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    [TerraformPropertyName("monitoring_service")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MonitoringService { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_service");

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    [TerraformPropertyName("networking_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkingMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "networking_mode");

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> NodeLocations { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "node_locations");

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    [TerraformPropertyName("node_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NodeVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_version");

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    [TerraformPropertyName("private_ipv6_google_access")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpv6GoogleAccess { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ipv6_google_access");

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    [TerraformPropertyName("remove_default_node_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoveDefaultNodePool { get; set; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceLabels { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Subnetwork { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnetwork");

    /// <summary>
    /// Block for addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    [TerraformPropertyName("addons_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterAddonsConfigBlock>>? AddonsConfig { get; set; } = new();

    /// <summary>
    /// Block for anonymous_authentication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnonymousAuthenticationConfig block(s) allowed")]
    [TerraformPropertyName("anonymous_authentication_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterAnonymousAuthenticationConfigBlock>>? AnonymousAuthenticationConfig { get; set; } = new();

    /// <summary>
    /// Block for authenticator_groups_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticatorGroupsConfig block(s) allowed")]
    [TerraformPropertyName("authenticator_groups_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterAuthenticatorGroupsConfigBlock>>? AuthenticatorGroupsConfig { get; set; } = new();

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformPropertyName("binary_authorization")]
    public TerraformList<TerraformBlock<GoogleContainerClusterBinaryAuthorizationBlock>>? BinaryAuthorization { get; set; } = new();

    /// <summary>
    /// Block for cluster_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterAutoscaling block(s) allowed")]
    [TerraformPropertyName("cluster_autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerClusterClusterAutoscalingBlock>>? ClusterAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for confidential_nodes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialNodes block(s) allowed")]
    [TerraformPropertyName("confidential_nodes")]
    public TerraformList<TerraformBlock<GoogleContainerClusterConfidentialNodesBlock>>? ConfidentialNodes { get; set; } = new();

    /// <summary>
    /// Block for control_plane_endpoints_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEndpointsConfig block(s) allowed")]
    [TerraformPropertyName("control_plane_endpoints_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterControlPlaneEndpointsConfigBlock>>? ControlPlaneEndpointsConfig { get; set; } = new();

    /// <summary>
    /// Block for cost_management_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostManagementConfig block(s) allowed")]
    [TerraformPropertyName("cost_management_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterCostManagementConfigBlock>>? CostManagementConfig { get; set; } = new();

    /// <summary>
    /// Block for database_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    [TerraformPropertyName("database_encryption")]
    public TerraformList<TerraformBlock<GoogleContainerClusterDatabaseEncryptionBlock>>? DatabaseEncryption { get; set; } = new();

    /// <summary>
    /// Block for default_snat_status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSnatStatus block(s) allowed")]
    [TerraformPropertyName("default_snat_status")]
    public TerraformList<TerraformBlock<GoogleContainerClusterDefaultSnatStatusBlock>>? DefaultSnatStatus { get; set; } = new();

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformPropertyName("dns_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterDnsConfigBlock>>? DnsConfig { get; set; } = new();

    /// <summary>
    /// Block for enable_k8s_beta_apis.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnableK8sBetaApis block(s) allowed")]
    [TerraformPropertyName("enable_k8s_beta_apis")]
    public TerraformList<TerraformBlock<GoogleContainerClusterEnableK8sBetaApisBlock>>? EnableK8sBetaApis { get; set; } = new();

    /// <summary>
    /// Block for enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnterpriseConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("enterprise_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterEnterpriseConfigBlock>>? EnterpriseConfig { get; set; } = new();

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformPropertyName("fleet")]
    public TerraformList<TerraformBlock<GoogleContainerClusterFleetBlock>>? Fleet { get; set; } = new();

    /// <summary>
    /// Block for gateway_api_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GatewayApiConfig block(s) allowed")]
    [TerraformPropertyName("gateway_api_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterGatewayApiConfigBlock>>? GatewayApiConfig { get; set; } = new();

    /// <summary>
    /// Block for gke_auto_upgrade_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeAutoUpgradeConfig block(s) allowed")]
    [TerraformPropertyName("gke_auto_upgrade_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterGkeAutoUpgradeConfigBlock>>? GkeAutoUpgradeConfig { get; set; } = new();

    /// <summary>
    /// Block for identity_service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityServiceConfig block(s) allowed")]
    [TerraformPropertyName("identity_service_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterIdentityServiceConfigBlock>>? IdentityServiceConfig { get; set; } = new();

    /// <summary>
    /// Block for ip_allocation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAllocationPolicy block(s) allowed")]
    [TerraformPropertyName("ip_allocation_policy")]
    public TerraformList<TerraformBlock<GoogleContainerClusterIpAllocationPolicyBlock>>? IpAllocationPolicy { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMaintenancePolicyBlock>>? MaintenancePolicy { get; set; } = new();

    /// <summary>
    /// Block for master_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuth block(s) allowed")]
    [TerraformPropertyName("master_auth")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMasterAuthBlock>>? MasterAuth { get; set; } = new();

    /// <summary>
    /// Block for master_authorized_networks_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuthorizedNetworksConfig block(s) allowed")]
    [TerraformPropertyName("master_authorized_networks_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMasterAuthorizedNetworksConfigBlock>>? MasterAuthorizedNetworksConfig { get; set; } = new();

    /// <summary>
    /// Block for mesh_certificates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MeshCertificates block(s) allowed")]
    [TerraformPropertyName("mesh_certificates")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMeshCertificatesBlock>>? MeshCertificates { get; set; } = new();

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    [TerraformPropertyName("monitoring_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterMonitoringConfigBlock>>? MonitoringConfig { get; set; } = new();

    /// <summary>
    /// Block for network_performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPerformanceConfig block(s) allowed")]
    [TerraformPropertyName("network_performance_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNetworkPerformanceConfigBlock>>? NetworkPerformanceConfig { get; set; } = new();

    /// <summary>
    /// Block for network_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkPolicy block(s) allowed")]
    [TerraformPropertyName("network_policy")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNetworkPolicyBlock>>? NetworkPolicy { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodeConfigBlock>>? NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for node_pool.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("node_pool")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodePoolBlock>>? NodePool { get; set; } = new();

    /// <summary>
    /// Block for node_pool_auto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolAutoConfig block(s) allowed")]
    [TerraformPropertyName("node_pool_auto_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodePoolAutoConfigBlock>>? NodePoolAutoConfig { get; set; } = new();

    /// <summary>
    /// Block for node_pool_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolDefaults block(s) allowed")]
    [TerraformPropertyName("node_pool_defaults")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNodePoolDefaultsBlock>>? NodePoolDefaults { get; set; } = new();

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformPropertyName("notification_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterNotificationConfigBlock>>? NotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodAutoscaling block(s) allowed")]
    [TerraformPropertyName("pod_autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerClusterPodAutoscalingBlock>>? PodAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for private_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateClusterConfig block(s) allowed")]
    [TerraformPropertyName("private_cluster_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterPrivateClusterConfigBlock>>? PrivateClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for rbac_binding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RbacBindingConfig block(s) allowed")]
    [TerraformPropertyName("rbac_binding_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterRbacBindingConfigBlock>>? RbacBindingConfig { get; set; } = new();

    /// <summary>
    /// Block for release_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseChannel block(s) allowed")]
    [TerraformPropertyName("release_channel")]
    public TerraformList<TerraformBlock<GoogleContainerClusterReleaseChannelBlock>>? ReleaseChannel { get; set; } = new();

    /// <summary>
    /// Block for resource_usage_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceUsageExportConfig block(s) allowed")]
    [TerraformPropertyName("resource_usage_export_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterResourceUsageExportConfigBlock>>? ResourceUsageExportConfig { get; set; } = new();

    /// <summary>
    /// Block for secret_manager_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerConfig block(s) allowed")]
    [TerraformPropertyName("secret_manager_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterSecretManagerConfigBlock>>? SecretManagerConfig { get; set; } = new();

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    [TerraformPropertyName("security_posture_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterSecurityPostureConfigBlock>>? SecurityPostureConfig { get; set; } = new();

    /// <summary>
    /// Block for service_external_ips_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceExternalIpsConfig block(s) allowed")]
    [TerraformPropertyName("service_external_ips_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterServiceExternalIpsConfigBlock>>? ServiceExternalIpsConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_managed_keys_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedKeysConfig block(s) allowed")]
    [TerraformPropertyName("user_managed_keys_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterUserManagedKeysConfigBlock>>? UserManagedKeysConfig { get; set; } = new();

    /// <summary>
    /// Block for vertical_pod_autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerticalPodAutoscaling block(s) allowed")]
    [TerraformPropertyName("vertical_pod_autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerClusterVerticalPodAutoscalingBlock>>? VerticalPodAutoscaling { get; set; } = new();

    /// <summary>
    /// Block for workload_identity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadIdentityConfig block(s) allowed")]
    [TerraformPropertyName("workload_identity_config")]
    public TerraformList<TerraformBlock<GoogleContainerClusterWorkloadIdentityConfigBlock>>? WorkloadIdentityConfig { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    [TerraformPropertyName("master_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_version");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Operation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "operation");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    [TerraformPropertyName("services_ipv4_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServicesIpv4Cidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "services_ipv4_cidr");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    [TerraformPropertyName("tpu_ipv4_cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TpuIpv4CidrBlock => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tpu_ipv4_cidr_block");

}
