using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_cluster resource.
/// </summary>
public class GoogleContainerCluster : TerraformResource
{
    public GoogleContainerCluster(string name) : base("google_container_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("master_version");
        this.DeclareOutput("operation");
        this.DeclareOutput("self_link");
        this.DeclareOutput("services_ipv4_cidr");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("tpu_ipv4_cidr_block");
    }

    /// <summary>
    /// Enable NET_ADMIN for this cluster.
    /// </summary>
    public bool? AllowNetAdmin
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_net_admin")?.Value;
        set => this.WithProperty("allow_net_admin", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.
    /// </summary>
    public string? ClusterIpv4Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_ipv4_cidr")?.Value;
        set => this.WithProperty("cluster_ipv4_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.
    /// </summary>
    public string? DatapathProvider
    {
        get => GetProperty<TerraformLiteralProperty<string>>("datapath_provider")?.Value;
        set => this.WithProperty("datapath_provider", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default maximum number of pods per node in this cluster. This doesn&#39;t work on &amp;quot;routes-based&amp;quot; clusters, clusters that don&#39;t have IP Aliasing enabled.
    /// </summary>
    public double? DefaultMaxPodsPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_max_pods_per_node")?.Value;
        set => this.WithProperty("default_max_pods_per_node", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the cluster will fail. When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    ///  Description of the cluster.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Disable L4 load balancer VPC firewalls to enable firewall policies.
    /// </summary>
    public bool? DisableL4LbFirewallReconciliation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_l4_lb_firewall_reconciliation")?.Value;
        set => this.WithProperty("disable_l4_lb_firewall_reconciliation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Enable Autopilot for this cluster.
    /// </summary>
    public bool? EnableAutopilot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_autopilot")?.Value;
        set => this.WithProperty("enable_autopilot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether Cilium cluster-wide network policy is enabled on this cluster.
    /// </summary>
    public bool? EnableCiliumClusterwideNetworkPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_cilium_clusterwide_network_policy")?.Value;
        set => this.WithProperty("enable_cilium_clusterwide_network_policy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether FQDN Network Policy is enabled on this cluster.
    /// </summary>
    public bool? EnableFqdnNetworkPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_fqdn_network_policy")?.Value;
        set => this.WithProperty("enable_fqdn_network_policy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
    /// </summary>
    public bool? EnableIntranodeVisibility
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_intranode_visibility")?.Value;
        set => this.WithProperty("enable_intranode_visibility", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.
    /// </summary>
    public bool? EnableKubernetesAlpha
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_kubernetes_alpha")?.Value;
        set => this.WithProperty("enable_kubernetes_alpha", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether L4ILB Subsetting is enabled for this cluster.
    /// </summary>
    public bool? EnableL4IlbSubsetting
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_l4_ilb_subsetting")?.Value;
        set => this.WithProperty("enable_l4_ilb_subsetting", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.
    /// </summary>
    public bool? EnableLegacyAbac
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_legacy_abac")?.Value;
        set => this.WithProperty("enable_legacy_abac", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether multi-networking is enabled for this cluster.
    /// </summary>
    public bool? EnableMultiNetworking
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_multi_networking")?.Value;
        set => this.WithProperty("enable_multi_networking", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.
    /// </summary>
    public bool? EnableShieldedNodes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_shielded_nodes")?.Value;
        set => this.WithProperty("enable_shielded_nodes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether to enable Cloud TPU resources in this cluster.
    /// </summary>
    public bool? EnableTpu
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_tpu")?.Value;
        set => this.WithProperty("enable_tpu", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Defines the config of in-transit encryption
    /// </summary>
    public string? InTransitEncryptionConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("in_transit_encryption_config")?.Value;
        set => this.WithProperty("in_transit_encryption_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number of nodes to create in this cluster&#39;s default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you&#39;re using google_container_node_pool objects with no default node pool, you&#39;ll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.
    /// </summary>
    public double? InitialNodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("initial_node_count")?.Value;
        set => this.WithProperty("initial_node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.
    /// </summary>
    public string? LoggingService
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_service")?.Value;
        set => this.WithProperty("logging_service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster&#39;s version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).
    /// </summary>
    public string? MinMasterVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("min_master_version")?.Value;
        set => this.WithProperty("min_master_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.
    /// </summary>
    public string? MonitoringService
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitoring_service")?.Value;
        set => this.WithProperty("monitoring_service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the cluster, unique within the project and location.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Determines whether alias IPs or routes will be used for pod IPs in the cluster. Defaults to VPC_NATIVE for new clusters.
    /// </summary>
    public string? NetworkingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("networking_mode")?.Value;
        set => this.WithProperty("networking_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of zones in which the cluster&#39;s nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster&#39;s zone.
    /// </summary>
    public HashSet<string>? NodeLocations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("node_locations")?.Value;
        set => this.WithProperty("node_locations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way. To update nodes in other node pools, use the version attribute on the node pool.
    /// </summary>
    public string? NodeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_version")?.Value;
        set => this.WithProperty("node_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).
    /// </summary>
    public string? PrivateIpv6GoogleAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ipv6_google_access")?.Value;
        set => this.WithProperty("private_ipv6_google_access", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, deletes the default node pool upon cluster creation. If you&#39;re using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.
    /// </summary>
    public bool? RemoveDefaultNodePool
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remove_default_node_pool")?.Value;
        set => this.WithProperty("remove_default_node_pool", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The GCE resource labels (a map of key/value pairs) to be applied to the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? ResourceLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("resource_labels")?.Value;
        set => this.WithProperty("resource_labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name or self_link of the Google Compute Engine subnetwork in which the cluster&#39;s instances are launched.
    /// </summary>
    public string? Subnetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnetwork")?.Value;
        set => this.WithProperty("subnetwork", value == null ? null : new TerraformLiteralProperty<string>(value));
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
