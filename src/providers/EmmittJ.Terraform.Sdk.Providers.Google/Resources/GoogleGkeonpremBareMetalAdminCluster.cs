using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_operations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
    /// </summary>
    [TerraformProperty("enable_application_logs")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableApplicationLogs { get; set; }

}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for maintenance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock : TerraformBlockBase
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
    public TerraformList<string>? MaintenanceAddressCidrBlocks { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for node_access_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// LoginUser is the user name used to access node machines.
    /// It defaults to &amp;quot;root&amp;quot; if not set.
    /// </summary>
    [TerraformProperty("login_user")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoginUser { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum number of pods a node can run. The size of the CIDR range
    /// assigned to the node will be derived from this parameter.
    /// </summary>
    [TerraformProperty("max_pods_per_node")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxPodsPerNode { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterProxyBlock : TerraformBlockBase
{
    /// <summary>
    /// A list of IPs, hostnames, and domains that should skip the proxy.
    /// For example: [&amp;quot;127.0.0.1&amp;quot;, &amp;quot;example.com&amp;quot;, &amp;quot;.corp&amp;quot;, &amp;quot;localhost&amp;quot;].
    /// </summary>
    [TerraformProperty("no_proxy")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? NoProxy { get; set; }

    /// <summary>
    /// Specifies the address of your proxy server.
    /// For Example: http://domain
    /// WARNING: Do not provide credentials in the format
    /// of http://(username:password@)domain these will be rejected by the server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for security_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterStorageBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_gkeonprem_bare_metal_admin_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeonpremBareMetalAdminCluster : TerraformResource
{
    public GoogleGkeonpremBareMetalAdminCluster(string name) : base("google_gkeonprem_bare_metal_admin_cluster", name)
    {
    }

    /// <summary>
    /// Annotations on the Bare Metal Admin Cluster.
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
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// A human readable description of this Bare Metal Admin Cluster.
    /// </summary>
    [TerraformProperty("bare_metal_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BareMetalVersion { get; set; }

    /// <summary>
    /// A human readable description of this Bare Metal Admin Cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The bare metal admin cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for cluster_operations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterOperations block(s) allowed")]
    [TerraformProperty("cluster_operations")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock>>? ClusterOperations { get; set; }

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    [TerraformProperty("control_plane")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock>>? ControlPlane { get; set; }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformProperty("load_balancer")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock>>? LoadBalancer { get; set; }

    /// <summary>
    /// Block for maintenance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceConfig block(s) allowed")]
    [TerraformProperty("maintenance_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock>>? MaintenanceConfig { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for node_access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeAccessConfig block(s) allowed")]
    [TerraformProperty("node_access_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock>>? NodeAccessConfig { get; set; }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformProperty("node_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock>>? NodeConfig { get; set; }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformProperty("proxy")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterProxyBlock>>? Proxy { get; set; }

    /// <summary>
    /// Block for security_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    [TerraformProperty("security_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock>>? SecurityConfig { get; set; }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformProperty("storage")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterStorageBlock>>? Storage { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// The IP address name of Bare Metal Admin Cluster&#39;s API server.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

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
    public TerraformList<object> Fleet { get; }

    /// <summary>
    /// The object name of the Bare Metal Admin Cluster custom resource on the
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
    public TerraformValue<string> LocalName { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal Admin Cluster.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// Specifies detailed cluster status.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Status { get; }

    /// <summary>
    /// The unique identifier of the Bare Metal Admin Cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Specifies the security related settings for the Bare Metal Admin Cluster.
    /// </summary>
    [TerraformProperty("validation_check")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ValidationCheck { get; }

}
