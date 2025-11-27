using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_cluster Terraform data source.
/// Retrieves information about a google_container_cluster.
/// </summary>
public partial class GoogleContainerClusterDataSource(string name) : TerraformDataSource("google_container_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The configuration for addons supported by GKE.
    /// </summary>
    public TerraformList<TerraformMap<object>> AddonsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "addons_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    public TerraformValue<bool> AllowNetAdmin
    {
        get => new TerraformReference<bool>(this, "allow_net_admin");
    }

    /// <summary>
    /// AnonymousAuthenticationConfig allows users to restrict or enable anonymous access to the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> AnonymousAuthenticationConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "anonymous_authentication_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for the Google Groups for GKE feature.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticatorGroupsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "authenticator_groups_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration options for the Binary Authorization feature.
    /// </summary>
    public TerraformList<TerraformMap<object>> BinaryAuthorization
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "binary_authorization").ResolveNodes(ctx));
    }

    /// <summary>
    /// Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster&#39;s workload. See the guide to using Node Auto-Provisioning for more details.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterAutoscaling
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_autoscaling").ResolveNodes(ctx));
    }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    public TerraformValue<string> ClusterIpv4Cidr
    {
        get => new TerraformReference<string>(this, "cluster_ipv4_cidr");
    }

    /// <summary>
    /// Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConfidentialNodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "confidential_nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for all of the cluster&#39;s control plane endpoints. Currently supports only DNS endpoint configuration and disable IP endpoint. Other IP endpoint configurations are available in private_cluster_config.
    /// </summary>
    public TerraformList<TerraformMap<object>> ControlPlaneEndpointsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "control_plane_endpoints_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cost management configuration for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> CostManagementConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cost_management_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Application-layer Secrets Encryption settings. The object format is {state = string, key_name = string}. Valid values of state are: &amp;quot;ENCRYPTED&amp;quot;; &amp;quot;DECRYPTED&amp;quot;. key_name is the name of a CloudKMS key.
    /// </summary>
    public TerraformList<TerraformMap<object>> DatabaseEncryption
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "database_encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    public TerraformValue<string> DatapathProvider
    {
        get => new TerraformReference<string>(this, "datapath_provider");
    }

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    public TerraformValue<double> DefaultMaxPodsPerNode
    {
        get => new TerraformReference<double>(this, "default_max_pods_per_node");
    }

    /// <summary>
    /// Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefaultSnatStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "default_snat_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    public TerraformValue<bool> DisableL4LbFirewallReconciliation
    {
        get => new TerraformReference<bool>(this, "disable_l4_lb_firewall_reconciliation");
    }

    /// <summary>
    /// Configuration for Cloud DNS for Kubernetes Engine.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    public TerraformValue<bool> EnableAutopilot
    {
        get => new TerraformReference<bool>(this, "enable_autopilot");
    }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    public TerraformValue<bool> EnableCiliumClusterwideNetworkPolicy
    {
        get => new TerraformReference<bool>(this, "enable_cilium_clusterwide_network_policy");
    }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    public TerraformValue<bool> EnableFqdnNetworkPolicy
    {
        get => new TerraformReference<bool>(this, "enable_fqdn_network_policy");
    }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    public TerraformValue<bool> EnableIntranodeVisibility
    {
        get => new TerraformReference<bool>(this, "enable_intranode_visibility");
    }

    /// <summary>
    /// Configuration for Kubernetes Beta APIs.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnableK8sBetaApis
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "enable_k8s_beta_apis").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    public TerraformValue<bool> EnableKubernetesAlpha
    {
        get => new TerraformReference<bool>(this, "enable_kubernetes_alpha");
    }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    public TerraformValue<bool> EnableL4IlbSubsetting
    {
        get => new TerraformReference<bool>(this, "enable_l4_ilb_subsetting");
    }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    public TerraformValue<bool> EnableLegacyAbac
    {
        get => new TerraformReference<bool>(this, "enable_legacy_abac");
    }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    public TerraformValue<bool> EnableMultiNetworking
    {
        get => new TerraformReference<bool>(this, "enable_multi_networking");
    }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    public TerraformValue<bool> EnableShieldedNodes
    {
        get => new TerraformReference<bool>(this, "enable_shielded_nodes");
    }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    public TerraformValue<bool> EnableTpu
    {
        get => new TerraformReference<bool>(this, "enable_tpu");
    }

    /// <summary>
    /// The IP address of this cluster&#39;s Kubernetes master.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// Defines the config needed to enable/disable GKE Enterprise
    /// </summary>
    public TerraformList<TerraformMap<object>> EnterpriseConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "enterprise_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Fleet configuration of the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> Fleet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "fleet").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for GKE Gateway API controller.
    /// </summary>
    public TerraformList<TerraformMap<object>> GatewayApiConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gateway_api_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> GkeAutoUpgradeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gke_auto_upgrade_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for Identity Service which allows customers to use external identity providers with the K8S API.
    /// </summary>
    public TerraformList<TerraformMap<object>> IdentityServiceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity_service_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    public TerraformValue<string> InTransitEncryptionConfig
    {
        get => new TerraformReference<string>(this, "in_transit_encryption_config");
    }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    public TerraformValue<double> InitialNodeCount
    {
        get => new TerraformReference<double>(this, "initial_node_count");
    }

    /// <summary>
    /// Configuration of cluster IP allocation for VPC-native clusters. Adding this block enables IP aliasing, making the cluster VPC-native instead of routes-based.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpAllocationPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_allocation_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fingerprint of the set of labels for this cluster.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
    {
        get => new TerraformReference<string>(this, "label_fingerprint");
    }

    /// <summary>
    /// Logging configuration for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> LoggingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logging_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    public TerraformValue<string> LoggingService
    {
        get => new TerraformReference<string>(this, "logging_service");
    }

    /// <summary>
    /// The maintenance policy to use for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenancePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterAuth
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "master_auth").ResolveNodes(ctx));
    }

    /// <summary>
    /// The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists).
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterAuthorizedNetworksConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "master_authorized_networks_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.
    /// </summary>
    public TerraformValue<string> MasterVersion
    {
        get => new TerraformReference<string>(this, "master_version");
    }

    /// <summary>
    /// If set, and enable_certificates=true, the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> MeshCertificates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mesh_certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    public TerraformValue<string> MinMasterVersion
    {
        get => new TerraformReference<string>(this, "min_master_version");
    }

    /// <summary>
    /// Monitoring configuration for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> MonitoringConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "monitoring_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    public TerraformValue<string> MonitoringService
    {
        get => new TerraformReference<string>(this, "monitoring_service");
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// Network bandwidth tier configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkPerformanceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_performance_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration options for the NetworkPolicy feature.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    public TerraformValue<string> NetworkingMode
    {
        get => new TerraformReference<string>(this, "networking_mode");
    }

    /// <summary>
    /// The configuration of the nodepool
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    public TerraformSet<string> NodeLocations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "node_locations").ResolveNodes(ctx));
    }

    /// <summary>
    /// List of node pools associated with this cluster. See google_container_node_pool for schema. Warning: node pools defined inside a cluster can&#39;t be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster. Unless you absolutely need the ability to say &amp;quot;these are the only node pools associated with this cluster&amp;quot;, use the google_container_node_pool resource instead of this property.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodePool
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_pool").ResolveNodes(ctx));
    }

    /// <summary>
    /// Node pool configs that apply to all auto-provisioned node pools in autopilot clusters and node auto-provisioning enabled clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodePoolAutoConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_pool_auto_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default nodel pool settings for the entire cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodePoolDefaults
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_pool_defaults").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    public TerraformValue<string> NodeVersion
    {
        get => new TerraformReference<string>(this, "node_version");
    }

    /// <summary>
    /// The notification config for sending cluster upgrade notifications
    /// </summary>
    public TerraformList<TerraformMap<object>> NotificationConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "notification_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string> Operation
    {
        get => new TerraformReference<string>(this, "operation");
    }

    /// <summary>
    /// PodAutoscaling is used for configuration of parameters for workload autoscaling
    /// </summary>
    public TerraformList<TerraformMap<object>> PodAutoscaling
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "pod_autoscaling").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for private clusters, clusters with private nodes.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateClusterConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_cluster_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    public TerraformValue<string> PrivateIpv6GoogleAccess
    {
        get => new TerraformReference<string>(this, "private_ipv6_google_access");
    }

    /// <summary>
    /// RBACBindingConfig allows user to restrict ClusterRoleBindings an RoleBindings that can be created.
    /// </summary>
    public TerraformList<TerraformMap<object>> RbacBindingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "rbac_binding_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. Note that removing this field from your config will not unenroll it. Instead, use the &amp;quot;UNSPECIFIED&amp;quot; channel.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReleaseChannel
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "release_channel").ResolveNodes(ctx));
    }

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    public TerraformValue<bool> RemoveDefaultNodePool
    {
        get => new TerraformReference<bool>(this, "remove_default_node_pool");
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> ResourceLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for the ResourceUsageExportConfig feature.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceUsageExportConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resource_usage_export_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for the Secret Manager feature.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecretManagerConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secret_manager_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Defines the config needed to enable/disable features for the Security Posture API
    /// </summary>
    public TerraformList<TerraformMap<object>> SecurityPostureConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "security_posture_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// If set, and enabled=true, services with external ips field will not be blocked
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceExternalIpsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_external_ips_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.
    /// </summary>
    public TerraformValue<string> ServicesIpv4Cidr
    {
        get => new TerraformReference<string>(this, "services_ipv4_cidr");
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).
    /// </summary>
    public TerraformValue<string> TpuIpv4CidrBlock
    {
        get => new TerraformReference<string>(this, "tpu_ipv4_cidr_block");
    }

    /// <summary>
    /// The custom keys configuration of the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserManagedKeysConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "user_managed_keys_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it.
    /// </summary>
    public TerraformList<TerraformMap<object>> VerticalPodAutoscaling
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vertical_pod_autoscaling").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadIdentityConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workload_identity_config").ResolveNodes(ctx));
    }

}
