using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_cluster.
/// </summary>
public partial class GoogleContainerClusterDataSource : TerraformDataSource
{
    public GoogleContainerClusterDataSource(string name) : base("google_container_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The configuration for addons supported by GKE.
    /// </summary>
    [TerraformProperty("addons_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AddonsConfig { get; }

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    [TerraformProperty("allow_net_admin")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowNetAdmin { get; }

    /// <summary>
    /// AnonymousAuthenticationConfig allows users to restrict or enable anonymous access to the cluster.
    /// </summary>
    [TerraformProperty("anonymous_authentication_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AnonymousAuthenticationConfig { get; }

    /// <summary>
    /// Configuration for the Google Groups for GKE feature.
    /// </summary>
    [TerraformProperty("authenticator_groups_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AuthenticatorGroupsConfig { get; }

    /// <summary>
    /// Configuration options for the Binary Authorization feature.
    /// </summary>
    [TerraformProperty("binary_authorization")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BinaryAuthorization { get; }

    /// <summary>
    /// Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster&#39;s workload. See the guide to using Node Auto-Provisioning for more details.
    /// </summary>
    [TerraformProperty("cluster_autoscaling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ClusterAutoscaling { get; }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    [TerraformProperty("cluster_ipv4_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterIpv4Cidr { get; }

    /// <summary>
    /// Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster.
    /// </summary>
    [TerraformProperty("confidential_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConfidentialNodes { get; }

    /// <summary>
    /// Configuration for all of the cluster&#39;s control plane endpoints. Currently supports only DNS endpoint configuration and disable IP endpoint. Other IP endpoint configurations are available in private_cluster_config.
    /// </summary>
    [TerraformProperty("control_plane_endpoints_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ControlPlaneEndpointsConfig { get; }

    /// <summary>
    /// Cost management configuration for the cluster.
    /// </summary>
    [TerraformProperty("cost_management_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CostManagementConfig { get; }

    /// <summary>
    /// Application-layer Secrets Encryption settings. The object format is {state = string, key_name = string}. Valid values of state are: &amp;quot;ENCRYPTED&amp;quot;; &amp;quot;DECRYPTED&amp;quot;. key_name is the name of a CloudKMS key.
    /// </summary>
    [TerraformProperty("database_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DatabaseEncryption { get; }

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    [TerraformProperty("datapath_provider")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatapathProvider { get; }

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    [TerraformProperty("default_max_pods_per_node")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DefaultMaxPodsPerNode { get; }

    /// <summary>
    /// Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.
    /// </summary>
    [TerraformProperty("default_snat_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DefaultSnatStatus { get; }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    [TerraformProperty("disable_l4_lb_firewall_reconciliation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DisableL4LbFirewallReconciliation { get; }

    /// <summary>
    /// Configuration for Cloud DNS for Kubernetes Engine.
    /// </summary>
    [TerraformProperty("dns_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DnsConfig { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    [TerraformProperty("enable_autopilot")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableAutopilot { get; }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    [TerraformProperty("enable_cilium_clusterwide_network_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableCiliumClusterwideNetworkPolicy { get; }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    [TerraformProperty("enable_fqdn_network_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableFqdnNetworkPolicy { get; }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    [TerraformProperty("enable_intranode_visibility")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableIntranodeVisibility { get; }

    /// <summary>
    /// Configuration for Kubernetes Beta APIs.
    /// </summary>
    [TerraformProperty("enable_k8s_beta_apis")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EnableK8sBetaApis { get; }

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    [TerraformProperty("enable_kubernetes_alpha")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableKubernetesAlpha { get; }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    [TerraformProperty("enable_l4_ilb_subsetting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableL4IlbSubsetting { get; }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    [TerraformProperty("enable_legacy_abac")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableLegacyAbac { get; }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    [TerraformProperty("enable_multi_networking")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableMultiNetworking { get; }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    [TerraformProperty("enable_shielded_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableShieldedNodes { get; }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    [TerraformProperty("enable_tpu")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableTpu { get; }

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// Defines the config needed to enable/disable GKE Enterprise
    /// </summary>
    [TerraformProperty("enterprise_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EnterpriseConfig { get; }

    /// <summary>
    /// Fleet configuration of the cluster.
    /// </summary>
    [TerraformProperty("fleet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Fleet { get; }

    /// <summary>
    /// Configuration for GKE Gateway API controller.
    /// </summary>
    [TerraformProperty("gateway_api_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GatewayApiConfig { get; }

    /// <summary>
    /// Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters.
    /// </summary>
    [TerraformProperty("gke_auto_upgrade_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GkeAutoUpgradeConfig { get; }

    /// <summary>
    /// Configuration for Identity Service which allows customers to use external identity providers with the K8S API.
    /// </summary>
    [TerraformProperty("identity_service_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IdentityServiceConfig { get; }

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    [TerraformProperty("in_transit_encryption_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InTransitEncryptionConfig { get; }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    [TerraformProperty("initial_node_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> InitialNodeCount { get; }

    /// <summary>
    /// Configuration of cluster IP allocation for VPC-native clusters. Adding this block enables IP aliasing, making the cluster VPC-native instead of routes-based.
    /// </summary>
    [TerraformProperty("ip_allocation_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpAllocationPolicy { get; }

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// Logging configuration for the cluster.
    /// </summary>
    [TerraformProperty("logging_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LoggingConfig { get; }

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    [TerraformProperty("logging_service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LoggingService { get; }

    /// <summary>
    /// The maintenance policy to use for the cluster.
    /// </summary>
    [TerraformProperty("maintenance_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenancePolicy { get; }

    /// <summary>
    /// The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.
    /// </summary>
    [TerraformProperty("master_auth")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MasterAuth { get; }

    /// <summary>
    /// The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists).
    /// </summary>
    [TerraformProperty("master_authorized_networks_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MasterAuthorizedNetworksConfig { get; }

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    [TerraformProperty("master_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterVersion { get; }

    /// <summary>
    /// If set, and enable_certificates=true, the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [TerraformProperty("mesh_certificates")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MeshCertificates { get; }

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    [TerraformProperty("min_master_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MinMasterVersion { get; }

    /// <summary>
    /// Monitoring configuration for the cluster.
    /// </summary>
    [TerraformProperty("monitoring_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MonitoringConfig { get; }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    [TerraformProperty("monitoring_service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MonitoringService { get; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// Network bandwidth tier configuration.
    /// </summary>
    [TerraformProperty("network_performance_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkPerformanceConfig { get; }

    /// <summary>
    /// Configuration options for the NetworkPolicy feature.
    /// </summary>
    [TerraformProperty("network_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkPolicy { get; }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    [TerraformProperty("networking_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkingMode { get; }

    /// <summary>
    /// The configuration of the nodepool
    /// </summary>
    [TerraformProperty("node_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NodeConfig { get; }

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    [TerraformProperty("node_locations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> NodeLocations { get; }

    /// <summary>
    /// List of node pools associated with this cluster. See google_container_node_pool for schema. Warning: node pools defined inside a cluster can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster. Unless you absolutely need the ability to say &amp;quot;these are the only node pools associated with this cluster&amp;quot;, use the google_container_node_pool resource instead of this property.
    /// </summary>
    [TerraformProperty("node_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NodePool { get; }

    /// <summary>
    /// Node pool configs that apply to all auto-provisioned node pools in autopilot clusters and node auto-provisioning enabled clusters.
    /// </summary>
    [TerraformProperty("node_pool_auto_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NodePoolAutoConfig { get; }

    /// <summary>
    /// The default nodel pool settings for the entire cluster.
    /// </summary>
    [TerraformProperty("node_pool_defaults")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NodePoolDefaults { get; }

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    [TerraformProperty("node_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeVersion { get; }

    /// <summary>
    /// The notification config for sending cluster upgrade notifications
    /// </summary>
    [TerraformProperty("notification_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NotificationConfig { get; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformProperty("operation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Operation { get; }

    /// <summary>
    /// PodAutoscaling is used for configuration of parameters for workload autoscaling
    /// </summary>
    [TerraformProperty("pod_autoscaling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PodAutoscaling { get; }

    /// <summary>
    /// Configuration for private clusters, clusters with private nodes.
    /// </summary>
    [TerraformProperty("private_cluster_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrivateClusterConfig { get; }

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    [TerraformProperty("private_ipv6_google_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIpv6GoogleAccess { get; }

    /// <summary>
    /// RBACBindingConfig allows user to restrict ClusterRoleBindings an RoleBindings that can be created.
    /// </summary>
    [TerraformProperty("rbac_binding_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RbacBindingConfig { get; }

    /// <summary>
    /// Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. Note that removing this field from your config will not unenroll it. Instead, use the &amp;quot;UNSPECIFIED&amp;quot; channel.
    /// </summary>
    [TerraformProperty("release_channel")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReleaseChannel { get; }

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    [TerraformProperty("remove_default_node_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RemoveDefaultNodePool { get; }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("resource_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> ResourceLabels { get; }

    /// <summary>
    /// Configuration for the ResourceUsageExportConfig feature.
    /// </summary>
    [TerraformProperty("resource_usage_export_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ResourceUsageExportConfig { get; }

    /// <summary>
    /// Configuration for the Secret Manager feature.
    /// </summary>
    [TerraformProperty("secret_manager_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecretManagerConfig { get; }

    /// <summary>
    /// Defines the config needed to enable/disable features for the Security Posture API
    /// </summary>
    [TerraformProperty("security_posture_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecurityPostureConfig { get; }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// If set, and enabled=true, services with external ips field will not be blocked
    /// </summary>
    [TerraformProperty("service_external_ips_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServiceExternalIpsConfig { get; }

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    [TerraformProperty("services_ipv4_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServicesIpv4Cidr { get; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Subnetwork { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    [TerraformProperty("tpu_ipv4_cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TpuIpv4CidrBlock { get; }

    /// <summary>
    /// The custom keys configuration of the cluster.
    /// </summary>
    [TerraformProperty("user_managed_keys_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UserManagedKeysConfig { get; }

    /// <summary>
    /// Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it.
    /// </summary>
    [TerraformProperty("vertical_pod_autoscaling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VerticalPodAutoscaling { get; }

    /// <summary>
    /// Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.
    /// </summary>
    [TerraformProperty("workload_identity_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WorkloadIdentityConfig { get; }

}
