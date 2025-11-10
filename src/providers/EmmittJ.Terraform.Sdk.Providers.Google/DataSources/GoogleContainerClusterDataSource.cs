using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_cluster.
/// </summary>
public class GoogleContainerClusterDataSource : TerraformDataSource
{
    public GoogleContainerClusterDataSource(string name) : base("google_container_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("addons_config");
        this.WithOutput("allow_net_admin");
        this.WithOutput("anonymous_authentication_config");
        this.WithOutput("authenticator_groups_config");
        this.WithOutput("binary_authorization");
        this.WithOutput("cluster_autoscaling");
        this.WithOutput("cluster_ipv4_cidr");
        this.WithOutput("confidential_nodes");
        this.WithOutput("control_plane_endpoints_config");
        this.WithOutput("cost_management_config");
        this.WithOutput("database_encryption");
        this.WithOutput("datapath_provider");
        this.WithOutput("default_max_pods_per_node");
        this.WithOutput("default_snat_status");
        this.WithOutput("deletion_protection");
        this.WithOutput("description");
        this.WithOutput("disable_l4_lb_firewall_reconciliation");
        this.WithOutput("dns_config");
        this.WithOutput("effective_labels");
        this.WithOutput("enable_autopilot");
        this.WithOutput("enable_cilium_clusterwide_network_policy");
        this.WithOutput("enable_fqdn_network_policy");
        this.WithOutput("enable_intranode_visibility");
        this.WithOutput("enable_k8s_beta_apis");
        this.WithOutput("enable_kubernetes_alpha");
        this.WithOutput("enable_l4_ilb_subsetting");
        this.WithOutput("enable_legacy_abac");
        this.WithOutput("enable_multi_networking");
        this.WithOutput("enable_shielded_nodes");
        this.WithOutput("enable_tpu");
        this.WithOutput("endpoint");
        this.WithOutput("enterprise_config");
        this.WithOutput("fleet");
        this.WithOutput("gateway_api_config");
        this.WithOutput("gke_auto_upgrade_config");
        this.WithOutput("identity_service_config");
        this.WithOutput("in_transit_encryption_config");
        this.WithOutput("initial_node_count");
        this.WithOutput("ip_allocation_policy");
        this.WithOutput("label_fingerprint");
        this.WithOutput("logging_config");
        this.WithOutput("logging_service");
        this.WithOutput("maintenance_policy");
        this.WithOutput("master_auth");
        this.WithOutput("master_authorized_networks_config");
        this.WithOutput("master_version");
        this.WithOutput("mesh_certificates");
        this.WithOutput("min_master_version");
        this.WithOutput("monitoring_config");
        this.WithOutput("monitoring_service");
        this.WithOutput("network");
        this.WithOutput("network_performance_config");
        this.WithOutput("network_policy");
        this.WithOutput("networking_mode");
        this.WithOutput("node_config");
        this.WithOutput("node_locations");
        this.WithOutput("node_pool");
        this.WithOutput("node_pool_auto_config");
        this.WithOutput("node_pool_defaults");
        this.WithOutput("node_version");
        this.WithOutput("notification_config");
        this.WithOutput("operation");
        this.WithOutput("pod_autoscaling");
        this.WithOutput("private_cluster_config");
        this.WithOutput("private_ipv6_google_access");
        this.WithOutput("rbac_binding_config");
        this.WithOutput("release_channel");
        this.WithOutput("remove_default_node_pool");
        this.WithOutput("resource_labels");
        this.WithOutput("resource_usage_export_config");
        this.WithOutput("secret_manager_config");
        this.WithOutput("security_posture_config");
        this.WithOutput("self_link");
        this.WithOutput("service_external_ips_config");
        this.WithOutput("services_ipv4_cidr");
        this.WithOutput("subnetwork");
        this.WithOutput("terraform_labels");
        this.WithOutput("tpu_ipv4_cidr_block");
        this.WithOutput("user_managed_keys_config");
        this.WithOutput("vertical_pod_autoscaling");
        this.WithOutput("workload_identity_config");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The configuration for addons supported by GKE.
    /// </summary>
    public TerraformExpression AddonsConfig => this["addons_config"];

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    public TerraformExpression AllowNetAdmin => this["allow_net_admin"];

    /// <summary>
    /// AnonymousAuthenticationConfig allows users to restrict or enable anonymous access to the cluster.
    /// </summary>
    public TerraformExpression AnonymousAuthenticationConfig => this["anonymous_authentication_config"];

    /// <summary>
    /// Configuration for the Google Groups for GKE feature.
    /// </summary>
    public TerraformExpression AuthenticatorGroupsConfig => this["authenticator_groups_config"];

    /// <summary>
    /// Configuration options for the Binary Authorization feature.
    /// </summary>
    public TerraformExpression BinaryAuthorization => this["binary_authorization"];

    /// <summary>
    /// Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster&#39;s workload. See the guide to using Node Auto-Provisioning for more details.
    /// </summary>
    public TerraformExpression ClusterAutoscaling => this["cluster_autoscaling"];

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    public TerraformExpression ClusterIpv4Cidr => this["cluster_ipv4_cidr"];

    /// <summary>
    /// Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster.
    /// </summary>
    public TerraformExpression ConfidentialNodes => this["confidential_nodes"];

    /// <summary>
    /// Configuration for all of the cluster&#39;s control plane endpoints. Currently supports only DNS endpoint configuration and disable IP endpoint. Other IP endpoint configurations are available in private_cluster_config.
    /// </summary>
    public TerraformExpression ControlPlaneEndpointsConfig => this["control_plane_endpoints_config"];

    /// <summary>
    /// Cost management configuration for the cluster.
    /// </summary>
    public TerraformExpression CostManagementConfig => this["cost_management_config"];

    /// <summary>
    /// Application-layer Secrets Encryption settings. The object format is {state = string, key_name = string}. Valid values of state are: &amp;quot;ENCRYPTED&amp;quot;; &amp;quot;DECRYPTED&amp;quot;. key_name is the name of a CloudKMS key.
    /// </summary>
    public TerraformExpression DatabaseEncryption => this["database_encryption"];

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    public TerraformExpression DatapathProvider => this["datapath_provider"];

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    public TerraformExpression DefaultMaxPodsPerNode => this["default_max_pods_per_node"];

    /// <summary>
    /// Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.
    /// </summary>
    public TerraformExpression DefaultSnatStatus => this["default_snat_status"];

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    public TerraformExpression DisableL4LbFirewallReconciliation => this["disable_l4_lb_firewall_reconciliation"];

    /// <summary>
    /// Configuration for Cloud DNS for Kubernetes Engine.
    /// </summary>
    public TerraformExpression DnsConfig => this["dns_config"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    public TerraformExpression EnableAutopilot => this["enable_autopilot"];

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    public TerraformExpression EnableCiliumClusterwideNetworkPolicy => this["enable_cilium_clusterwide_network_policy"];

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    public TerraformExpression EnableFqdnNetworkPolicy => this["enable_fqdn_network_policy"];

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    public TerraformExpression EnableIntranodeVisibility => this["enable_intranode_visibility"];

    /// <summary>
    /// Configuration for Kubernetes Beta APIs.
    /// </summary>
    public TerraformExpression EnableK8sBetaApis => this["enable_k8s_beta_apis"];

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    public TerraformExpression EnableKubernetesAlpha => this["enable_kubernetes_alpha"];

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    public TerraformExpression EnableL4IlbSubsetting => this["enable_l4_ilb_subsetting"];

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    public TerraformExpression EnableLegacyAbac => this["enable_legacy_abac"];

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    public TerraformExpression EnableMultiNetworking => this["enable_multi_networking"];

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    public TerraformExpression EnableShieldedNodes => this["enable_shielded_nodes"];

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    public TerraformExpression EnableTpu => this["enable_tpu"];

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// Defines the config needed to enable/disable GKE Enterprise
    /// </summary>
    public TerraformExpression EnterpriseConfig => this["enterprise_config"];

    /// <summary>
    /// Fleet configuration of the cluster.
    /// </summary>
    public TerraformExpression Fleet => this["fleet"];

    /// <summary>
    /// Configuration for GKE Gateway API controller.
    /// </summary>
    public TerraformExpression GatewayApiConfig => this["gateway_api_config"];

    /// <summary>
    /// Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters.
    /// </summary>
    public TerraformExpression GkeAutoUpgradeConfig => this["gke_auto_upgrade_config"];

    /// <summary>
    /// Configuration for Identity Service which allows customers to use external identity providers with the K8S API.
    /// </summary>
    public TerraformExpression IdentityServiceConfig => this["identity_service_config"];

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    public TerraformExpression InTransitEncryptionConfig => this["in_transit_encryption_config"];

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    public TerraformExpression InitialNodeCount => this["initial_node_count"];

    /// <summary>
    /// Configuration of cluster IP allocation for VPC-native clusters. Adding this block enables IP aliasing, making the cluster VPC-native instead of routes-based.
    /// </summary>
    public TerraformExpression IpAllocationPolicy => this["ip_allocation_policy"];

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// Logging configuration for the cluster.
    /// </summary>
    public TerraformExpression LoggingConfig => this["logging_config"];

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    public TerraformExpression LoggingService => this["logging_service"];

    /// <summary>
    /// The maintenance policy to use for the cluster.
    /// </summary>
    public TerraformExpression MaintenancePolicy => this["maintenance_policy"];

    /// <summary>
    /// The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.
    /// </summary>
    public TerraformExpression MasterAuth => this["master_auth"];

    /// <summary>
    /// The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists).
    /// </summary>
    public TerraformExpression MasterAuthorizedNetworksConfig => this["master_authorized_networks_config"];

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    public TerraformExpression MasterVersion => this["master_version"];

    /// <summary>
    /// If set, and enable_certificates=true, the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    public TerraformExpression MeshCertificates => this["mesh_certificates"];

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    public TerraformExpression MinMasterVersion => this["min_master_version"];

    /// <summary>
    /// Monitoring configuration for the cluster.
    /// </summary>
    public TerraformExpression MonitoringConfig => this["monitoring_config"];

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    public TerraformExpression MonitoringService => this["monitoring_service"];

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// Network bandwidth tier configuration.
    /// </summary>
    public TerraformExpression NetworkPerformanceConfig => this["network_performance_config"];

    /// <summary>
    /// Configuration options for the NetworkPolicy feature.
    /// </summary>
    public TerraformExpression NetworkPolicy => this["network_policy"];

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    public TerraformExpression NetworkingMode => this["networking_mode"];

    /// <summary>
    /// The configuration of the nodepool
    /// </summary>
    public TerraformExpression NodeConfig => this["node_config"];

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    public TerraformExpression NodeLocations => this["node_locations"];

    /// <summary>
    /// List of node pools associated with this cluster. See google_container_node_pool for schema. Warning: node pools defined inside a cluster can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster. Unless you absolutely need the ability to say &amp;quot;these are the only node pools associated with this cluster&amp;quot;, use the google_container_node_pool resource instead of this property.
    /// </summary>
    public TerraformExpression NodePool => this["node_pool"];

    /// <summary>
    /// Node pool configs that apply to all auto-provisioned node pools in autopilot clusters and node auto-provisioning enabled clusters.
    /// </summary>
    public TerraformExpression NodePoolAutoConfig => this["node_pool_auto_config"];

    /// <summary>
    /// The default nodel pool settings for the entire cluster.
    /// </summary>
    public TerraformExpression NodePoolDefaults => this["node_pool_defaults"];

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    public TerraformExpression NodeVersion => this["node_version"];

    /// <summary>
    /// The notification config for sending cluster upgrade notifications
    /// </summary>
    public TerraformExpression NotificationConfig => this["notification_config"];

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

    /// <summary>
    /// PodAutoscaling is used for configuration of parameters for workload autoscaling
    /// </summary>
    public TerraformExpression PodAutoscaling => this["pod_autoscaling"];

    /// <summary>
    /// Configuration for private clusters, clusters with private nodes.
    /// </summary>
    public TerraformExpression PrivateClusterConfig => this["private_cluster_config"];

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    public TerraformExpression PrivateIpv6GoogleAccess => this["private_ipv6_google_access"];

    /// <summary>
    /// RBACBindingConfig allows user to restrict ClusterRoleBindings an RoleBindings that can be created.
    /// </summary>
    public TerraformExpression RbacBindingConfig => this["rbac_binding_config"];

    /// <summary>
    /// Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. Note that removing this field from your config will not unenroll it. Instead, use the &amp;quot;UNSPECIFIED&amp;quot; channel.
    /// </summary>
    public TerraformExpression ReleaseChannel => this["release_channel"];

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    public TerraformExpression RemoveDefaultNodePool => this["remove_default_node_pool"];

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression ResourceLabels => this["resource_labels"];

    /// <summary>
    /// Configuration for the ResourceUsageExportConfig feature.
    /// </summary>
    public TerraformExpression ResourceUsageExportConfig => this["resource_usage_export_config"];

    /// <summary>
    /// Configuration for the Secret Manager feature.
    /// </summary>
    public TerraformExpression SecretManagerConfig => this["secret_manager_config"];

    /// <summary>
    /// Defines the config needed to enable/disable features for the Security Posture API
    /// </summary>
    public TerraformExpression SecurityPostureConfig => this["security_posture_config"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// If set, and enabled=true, services with external ips field will not be blocked
    /// </summary>
    public TerraformExpression ServiceExternalIpsConfig => this["service_external_ips_config"];

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    public TerraformExpression ServicesIpv4Cidr => this["services_ipv4_cidr"];

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    public TerraformExpression Subnetwork => this["subnetwork"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    public TerraformExpression TpuIpv4CidrBlock => this["tpu_ipv4_cidr_block"];

    /// <summary>
    /// The custom keys configuration of the cluster.
    /// </summary>
    public TerraformExpression UserManagedKeysConfig => this["user_managed_keys_config"];

    /// <summary>
    /// Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it.
    /// </summary>
    public TerraformExpression VerticalPodAutoscaling => this["vertical_pod_autoscaling"];

    /// <summary>
    /// Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.
    /// </summary>
    public TerraformExpression WorkloadIdentityConfig => this["workload_identity_config"];

}
