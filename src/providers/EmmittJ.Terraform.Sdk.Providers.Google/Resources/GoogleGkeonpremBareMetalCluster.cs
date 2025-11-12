using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock() : TerraformBlock("binary_authorization")
{
    /// <summary>
    /// Mode of operation for binauthz policy evaluation. If unspecified,
    /// defaults to DISABLED. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    [TerraformProperty("evaluation_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EvaluationMode { get; set; }

}

/// <summary>
/// Block type for cluster_operations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterClusterOperationsBlock() : TerraformBlock("cluster_operations")
{
    /// <summary>
    /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
    /// </summary>
    [TerraformProperty("enable_application_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableApplicationLogs { get; set; }

}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterControlPlaneBlock() : TerraformBlock("control_plane")
{
}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterLoadBalancerBlock() : TerraformBlock("load_balancer")
{
}

/// <summary>
/// Block type for maintenance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock() : TerraformBlock("maintenance_config")
{
    /// <summary>
    /// All IPv4 address from these ranges will be placed into maintenance mode.
    /// Nodes in maintenance mode will be cordoned and drained. When both of these
    /// are true, the &amp;quot;baremetal.cluster.gke.io/maintenance&amp;quot; annotation will be set
    /// on the node resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceAddressCidrBlocks is required")]
    [TerraformProperty("maintenance_address_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? MaintenanceAddressCidrBlocks { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterNetworkConfigBlock() : TerraformBlock("network_config")
{
    /// <summary>
    /// Enables the use of advanced Anthos networking features, such as Bundled
    /// Load Balancing with BGP or the egress NAT gateway.
    /// Setting configuration for advanced networking features will automatically
    /// set this flag.
    /// </summary>
    [TerraformProperty("advanced_networking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdvancedNetworking { get; set; }

}

/// <summary>
/// Block type for node_access_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock() : TerraformBlock("node_access_config")
{
    /// <summary>
    /// LoginUser is the user name used to access node machines.
    /// It defaults to &amp;quot;root&amp;quot; if not set.
    /// </summary>
    [TerraformProperty("login_user")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoginUser { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterNodeConfigBlock() : TerraformBlock("node_config")
{
    /// <summary>
    /// The available runtimes that can be used to run containers in a Bare Metal User Cluster. Possible values: [&amp;quot;CONTAINER_RUNTIME_UNSPECIFIED&amp;quot;, &amp;quot;DOCKER&amp;quot;, &amp;quot;CONTAINERD&amp;quot;]
    /// </summary>
    [TerraformProperty("container_runtime")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContainerRuntime { get; set; }

    /// <summary>
    /// The maximum number of pods a node can run. The size of the CIDR range
    /// assigned to the node will be derived from this parameter.
    /// </summary>
    [TerraformProperty("max_pods_per_node")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxPodsPerNode { get; set; }

}

/// <summary>
/// Block type for os_environment_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock() : TerraformBlock("os_environment_config")
{
    /// <summary>
    /// Whether the package repo should not be included when initializing
    /// bare metal machines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageRepoExcluded is required")]
    [TerraformProperty("package_repo_excluded")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> PackageRepoExcluded { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterProxyBlock() : TerraformBlock("proxy")
{
    /// <summary>
    /// A list of IPs, hostnames, and domains that should skip the proxy.
    /// For example [&amp;quot;127.0.0.1&amp;quot;, &amp;quot;example.com&amp;quot;, &amp;quot;.corp&amp;quot;, &amp;quot;localhost&amp;quot;].
    /// </summary>
    [TerraformProperty("no_proxy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NoProxy { get; set; }

    /// <summary>
    /// Specifies the address of your proxy server.
    /// For example: http://domain
    /// WARNING: Do not provide credentials in the format
    /// of http://(username:password@)domain these will be rejected by the server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for security_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterSecurityConfigBlock() : TerraformBlock("security_config")
{
}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterStorageBlock() : TerraformBlock("storage")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalClusterUpgradePolicyBlock() : TerraformBlock("upgrade_policy")
{
    /// <summary>
    /// Specifies which upgrade policy to use. Possible values: [&amp;quot;SERIAL&amp;quot;, &amp;quot;CONCURRENT&amp;quot;]
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Policy { get; set; }

}

/// <summary>
/// Manages a google_gkeonprem_bare_metal_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeonpremBareMetalCluster : TerraformResource
{
    public GoogleGkeonpremBareMetalCluster(string name) : base("google_gkeonprem_bare_metal_cluster", name)
    {
    }

    /// <summary>
    /// The Admin Cluster this Bare Metal User Cluster belongs to.
    /// This is the full resource name of the Admin Cluster&#39;s hub membership.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminClusterMembership is required")]
    [TerraformProperty("admin_cluster_membership")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminClusterMembership { get; set; }

    /// <summary>
    /// Annotations on the Bare Metal User Cluster.
    /// This field has the same restrictions as Kubernetes annotations.
    /// The total size of all keys and values combined is limited to 256k.
    /// Key can have 2 segments: prefix (optional) and name (required),
    /// separated by a slash (/).
    /// Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// A human readable description of this Bare Metal User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BareMetalVersion is required")]
    [TerraformProperty("bare_metal_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BareMetalVersion { get; set; }

    /// <summary>
    /// A human readable description of this Bare Metal User Cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The bare metal cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformProperty("binary_authorization")]
    public TerraformList<GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock> BinaryAuthorization { get; set; } = new();

    /// <summary>
    /// Block for cluster_operations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterOperations block(s) allowed")]
    [TerraformProperty("cluster_operations")]
    public TerraformList<GoogleGkeonpremBareMetalClusterClusterOperationsBlock> ClusterOperations { get; set; } = new();

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlane is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlane block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    [TerraformProperty("control_plane")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterControlPlaneBlock> ControlPlane { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformProperty("load_balancer")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterLoadBalancerBlock> LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for maintenance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceConfig block(s) allowed")]
    [TerraformProperty("maintenance_config")]
    public TerraformList<GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock> MaintenanceConfig { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterNetworkConfigBlock> NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for node_access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeAccessConfig block(s) allowed")]
    [TerraformProperty("node_access_config")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock> NodeAccessConfig { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformProperty("node_config")]
    public TerraformList<GoogleGkeonpremBareMetalClusterNodeConfigBlock> NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for os_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsEnvironmentConfig block(s) allowed")]
    [TerraformProperty("os_environment_config")]
    public TerraformList<GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock> OsEnvironmentConfig { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformProperty("proxy")]
    public TerraformList<GoogleGkeonpremBareMetalClusterProxyBlock> Proxy { get; set; } = new();

    /// <summary>
    /// Block for security_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    [TerraformProperty("security_config")]
    public TerraformList<GoogleGkeonpremBareMetalClusterSecurityConfigBlock> SecurityConfig { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Storage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Storage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformProperty("storage")]
    public required TerraformList<GoogleGkeonpremBareMetalClusterStorageBlock> Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleGkeonpremBareMetalClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformProperty("upgrade_policy")]
    public TerraformList<GoogleGkeonpremBareMetalClusterUpgradePolicyBlock> UpgradePolicy { get; set; } = new();

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// The IP address name of Bare Metal User Cluster&#39;s API server.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Fleet related configuration.
    /// Fleets are a Google Cloud concept for logically organizing clusters,
    /// letting you use and manage multi-cluster capabilities and apply
    /// consistent policies across your systems.
    /// See [Anthos Fleets](https://cloud.google.com/anthos/multicluster-management/fleets) for
    /// more details on Anthos multi-cluster capabilities using Fleets.
    /// </summary>
    [TerraformProperty("fleet")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Fleet { get; }

    /// <summary>
    /// The object name of the Bare Metal Cluster custom resource on the
    /// associated admin cluster. This field is used to support conflicting
    /// names when enrolling existing clusters to the API. When used as a part of
    /// cluster enrollment, this field will differ from the ID in the resource
    /// name. For new clusters, this field will match the user provided cluster ID
    /// and be visible in the last component of the resource name. It is not
    /// modifiable.
    /// All users should use this name to access their cluster using gkectl or
    /// kubectl and should expect to see the local name when viewing admin
    /// cluster controller logs.
    /// </summary>
    [TerraformProperty("local_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LocalName { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal User Cluster.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Specifies detailed cluster status.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

    /// <summary>
    /// The unique identifier of the Bare Metal User Cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Specifies the security related settings for the Bare Metal User Cluster.
    /// </summary>
    [TerraformProperty("validation_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ValidationCheck { get; }

}
