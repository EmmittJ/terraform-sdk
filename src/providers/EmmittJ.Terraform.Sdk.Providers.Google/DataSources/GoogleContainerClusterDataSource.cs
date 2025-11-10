using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_cluster.
/// </summary>
public class GoogleContainerClusterDataSource : TerraformDataSource
{
    public GoogleContainerClusterDataSource(string name) : base("google_container_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The configuration for addons supported by GKE.
    /// </summary>
    [TerraformPropertyName("addons_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AddonsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "addons_config");

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    [TerraformPropertyName("allow_net_admin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowNetAdmin => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_net_admin");

    /// <summary>
    /// AnonymousAuthenticationConfig allows users to restrict or enable anonymous access to the cluster.
    /// </summary>
    [TerraformPropertyName("anonymous_authentication_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AnonymousAuthenticationConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "anonymous_authentication_config");

    /// <summary>
    /// Configuration for the Google Groups for GKE feature.
    /// </summary>
    [TerraformPropertyName("authenticator_groups_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthenticatorGroupsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authenticator_groups_config");

    /// <summary>
    /// Configuration options for the Binary Authorization feature.
    /// </summary>
    [TerraformPropertyName("binary_authorization")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BinaryAuthorization => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "binary_authorization");

    /// <summary>
    /// Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster&#39;s workload. See the guide to using Node Auto-Provisioning for more details.
    /// </summary>
    [TerraformPropertyName("cluster_autoscaling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterAutoscaling => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_autoscaling");

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    [TerraformPropertyName("cluster_ipv4_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterIpv4Cidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_ipv4_cidr");

    /// <summary>
    /// Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster.
    /// </summary>
    [TerraformPropertyName("confidential_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConfidentialNodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "confidential_nodes");

    /// <summary>
    /// Configuration for all of the cluster&#39;s control plane endpoints. Currently supports only DNS endpoint configuration and disable IP endpoint. Other IP endpoint configurations are available in private_cluster_config.
    /// </summary>
    [TerraformPropertyName("control_plane_endpoints_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ControlPlaneEndpointsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "control_plane_endpoints_config");

    /// <summary>
    /// Cost management configuration for the cluster.
    /// </summary>
    [TerraformPropertyName("cost_management_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CostManagementConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cost_management_config");

    /// <summary>
    /// Application-layer Secrets Encryption settings. The object format is {state = string, key_name = string}. Valid values of state are: &amp;quot;ENCRYPTED&amp;quot;; &amp;quot;DECRYPTED&amp;quot;. key_name is the name of a CloudKMS key.
    /// </summary>
    [TerraformPropertyName("database_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DatabaseEncryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "database_encryption");

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    [TerraformPropertyName("datapath_provider")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatapathProvider => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "datapath_provider");

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    [TerraformPropertyName("default_max_pods_per_node")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultMaxPodsPerNode => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_max_pods_per_node");

    /// <summary>
    /// Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.
    /// </summary>
    [TerraformPropertyName("default_snat_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DefaultSnatStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "default_snat_status");

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    [TerraformPropertyName("disable_l4_lb_firewall_reconciliation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableL4LbFirewallReconciliation => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_l4_lb_firewall_reconciliation");

    /// <summary>
    /// Configuration for Cloud DNS for Kubernetes Engine.
    /// </summary>
    [TerraformPropertyName("dns_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DnsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dns_config");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_autopilot")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableAutopilot => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_autopilot");

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    [TerraformPropertyName("enable_cilium_clusterwide_network_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableCiliumClusterwideNetworkPolicy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_cilium_clusterwide_network_policy");

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    [TerraformPropertyName("enable_fqdn_network_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableFqdnNetworkPolicy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_fqdn_network_policy");

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    [TerraformPropertyName("enable_intranode_visibility")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableIntranodeVisibility => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_intranode_visibility");

    /// <summary>
    /// Configuration for Kubernetes Beta APIs.
    /// </summary>
    [TerraformPropertyName("enable_k8s_beta_apis")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EnableK8sBetaApis => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "enable_k8s_beta_apis");

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    [TerraformPropertyName("enable_kubernetes_alpha")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableKubernetesAlpha => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_kubernetes_alpha");

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_l4_ilb_subsetting")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableL4IlbSubsetting => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_l4_ilb_subsetting");

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    [TerraformPropertyName("enable_legacy_abac")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableLegacyAbac => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_legacy_abac");

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    [TerraformPropertyName("enable_multi_networking")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableMultiNetworking => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_multi_networking");

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    [TerraformPropertyName("enable_shielded_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableShieldedNodes => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_shielded_nodes");

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    [TerraformPropertyName("enable_tpu")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableTpu => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_tpu");

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// Defines the config needed to enable/disable GKE Enterprise
    /// </summary>
    [TerraformPropertyName("enterprise_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EnterpriseConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "enterprise_config");

    /// <summary>
    /// Fleet configuration of the cluster.
    /// </summary>
    [TerraformPropertyName("fleet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Fleet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "fleet");

    /// <summary>
    /// Configuration for GKE Gateway API controller.
    /// </summary>
    [TerraformPropertyName("gateway_api_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GatewayApiConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "gateway_api_config");

    /// <summary>
    /// Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters.
    /// </summary>
    [TerraformPropertyName("gke_auto_upgrade_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GkeAutoUpgradeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "gke_auto_upgrade_config");

    /// <summary>
    /// Configuration for Identity Service which allows customers to use external identity providers with the K8S API.
    /// </summary>
    [TerraformPropertyName("identity_service_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IdentityServiceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity_service_config");

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    [TerraformPropertyName("in_transit_encryption_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InTransitEncryptionConfig => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "in_transit_encryption_config");

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    [TerraformPropertyName("initial_node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InitialNodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "initial_node_count");

    /// <summary>
    /// Configuration of cluster IP allocation for VPC-native clusters. Adding this block enables IP aliasing, making the cluster VPC-native instead of routes-based.
    /// </summary>
    [TerraformPropertyName("ip_allocation_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpAllocationPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip_allocation_policy");

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// Logging configuration for the cluster.
    /// </summary>
    [TerraformPropertyName("logging_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LoggingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logging_config");

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    [TerraformPropertyName("logging_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoggingService => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logging_service");

    /// <summary>
    /// The maintenance policy to use for the cluster.
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenancePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_policy");

    /// <summary>
    /// The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.
    /// </summary>
    [TerraformPropertyName("master_auth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MasterAuth => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "master_auth");

    /// <summary>
    /// The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists).
    /// </summary>
    [TerraformPropertyName("master_authorized_networks_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MasterAuthorizedNetworksConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "master_authorized_networks_config");

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    [TerraformPropertyName("master_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_version");

    /// <summary>
    /// If set, and enable_certificates=true, the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    [TerraformPropertyName("mesh_certificates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MeshCertificates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "mesh_certificates");

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    [TerraformPropertyName("min_master_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinMasterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "min_master_version");

    /// <summary>
    /// Monitoring configuration for the cluster.
    /// </summary>
    [TerraformPropertyName("monitoring_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MonitoringConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "monitoring_config");

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    [TerraformPropertyName("monitoring_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonitoringService => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_service");

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// Network bandwidth tier configuration.
    /// </summary>
    [TerraformPropertyName("network_performance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkPerformanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_performance_config");

    /// <summary>
    /// Configuration options for the NetworkPolicy feature.
    /// </summary>
    [TerraformPropertyName("network_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_policy");

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    [TerraformPropertyName("networking_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkingMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "networking_mode");

    /// <summary>
    /// The configuration of the nodepool
    /// </summary>
    [TerraformPropertyName("node_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_config");

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    [TerraformPropertyName("node_locations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NodeLocations => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "node_locations");

    /// <summary>
    /// List of node pools associated with this cluster. See google_container_node_pool for schema. Warning: node pools defined inside a cluster can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster. Unless you absolutely need the ability to say &amp;quot;these are the only node pools associated with this cluster&amp;quot;, use the google_container_node_pool resource instead of this property.
    /// </summary>
    [TerraformPropertyName("node_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodePool => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_pool");

    /// <summary>
    /// Node pool configs that apply to all auto-provisioned node pools in autopilot clusters and node auto-provisioning enabled clusters.
    /// </summary>
    [TerraformPropertyName("node_pool_auto_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodePoolAutoConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_pool_auto_config");

    /// <summary>
    /// The default nodel pool settings for the entire cluster.
    /// </summary>
    [TerraformPropertyName("node_pool_defaults")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodePoolDefaults => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_pool_defaults");

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    [TerraformPropertyName("node_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_version");

    /// <summary>
    /// The notification config for sending cluster upgrade notifications
    /// </summary>
    [TerraformPropertyName("notification_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NotificationConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "notification_config");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Operation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "operation");

    /// <summary>
    /// PodAutoscaling is used for configuration of parameters for workload autoscaling
    /// </summary>
    [TerraformPropertyName("pod_autoscaling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PodAutoscaling => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "pod_autoscaling");

    /// <summary>
    /// Configuration for private clusters, clusters with private nodes.
    /// </summary>
    [TerraformPropertyName("private_cluster_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateClusterConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_cluster_config");

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    [TerraformPropertyName("private_ipv6_google_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpv6GoogleAccess => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ipv6_google_access");

    /// <summary>
    /// RBACBindingConfig allows user to restrict ClusterRoleBindings an RoleBindings that can be created.
    /// </summary>
    [TerraformPropertyName("rbac_binding_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RbacBindingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "rbac_binding_config");

    /// <summary>
    /// Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. Note that removing this field from your config will not unenroll it. Instead, use the &amp;quot;UNSPECIFIED&amp;quot; channel.
    /// </summary>
    [TerraformPropertyName("release_channel")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReleaseChannel => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "release_channel");

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    [TerraformPropertyName("remove_default_node_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RemoveDefaultNodePool => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "remove_default_node_pool");

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("resource_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ResourceLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "resource_labels");

    /// <summary>
    /// Configuration for the ResourceUsageExportConfig feature.
    /// </summary>
    [TerraformPropertyName("resource_usage_export_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ResourceUsageExportConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resource_usage_export_config");

    /// <summary>
    /// Configuration for the Secret Manager feature.
    /// </summary>
    [TerraformPropertyName("secret_manager_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecretManagerConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secret_manager_config");

    /// <summary>
    /// Defines the config needed to enable/disable features for the Security Posture API
    /// </summary>
    [TerraformPropertyName("security_posture_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecurityPostureConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "security_posture_config");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// If set, and enabled=true, services with external ips field will not be blocked
    /// </summary>
    [TerraformPropertyName("service_external_ips_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceExternalIpsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_external_ips_config");

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    [TerraformPropertyName("services_ipv4_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServicesIpv4Cidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "services_ipv4_cidr");

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subnetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnetwork");

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

    /// <summary>
    /// The custom keys configuration of the cluster.
    /// </summary>
    [TerraformPropertyName("user_managed_keys_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserManagedKeysConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_managed_keys_config");

    /// <summary>
    /// Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it.
    /// </summary>
    [TerraformPropertyName("vertical_pod_autoscaling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VerticalPodAutoscaling => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vertical_pod_autoscaling");

    /// <summary>
    /// Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.
    /// </summary>
    [TerraformPropertyName("workload_identity_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkloadIdentityConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workload_identity_config");

}
