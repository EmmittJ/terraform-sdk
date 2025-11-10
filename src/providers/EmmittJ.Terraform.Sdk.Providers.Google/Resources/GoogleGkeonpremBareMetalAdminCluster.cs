using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_operations in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock : ITerraformBlock
{
    /// <summary>
    /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
    /// </summary>
    [TerraformPropertyName("enable_application_logs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableApplicationLogs { get; set; }

}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for maintenance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// All IPv4 address from these ranges will be placed into maintenance mode.
    /// Nodes in maintenance mode will be cordoned and drained. When both of these
    /// are true, the &amp;quot;baremetal.cluster.gke.io/maintenance&amp;quot; annotation will be set
    /// on the node resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceAddressCidrBlocks is required")]
    [TerraformPropertyName("maintenance_address_cidr_blocks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? MaintenanceAddressCidrBlocks { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for node_access_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock : ITerraformBlock
{
    /// <summary>
    /// LoginUser is the user name used to access node machines.
    /// It defaults to &amp;quot;root&amp;quot; if not set.
    /// </summary>
    [TerraformPropertyName("login_user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoginUser { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum number of pods a node can run. The size of the CIDR range
    /// assigned to the node will be derived from this parameter.
    /// </summary>
    [TerraformPropertyName("max_pods_per_node")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxPodsPerNode { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterProxyBlock : ITerraformBlock
{
    /// <summary>
    /// A list of IPs, hostnames, and domains that should skip the proxy.
    /// For example: [&amp;quot;127.0.0.1&amp;quot;, &amp;quot;example.com&amp;quot;, &amp;quot;.corp&amp;quot;, &amp;quot;localhost&amp;quot;].
    /// </summary>
    [TerraformPropertyName("no_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NoProxy { get; set; }

    /// <summary>
    /// Specifies the address of your proxy server.
    /// For Example: http://domain
    /// WARNING: Do not provide credentials in the format
    /// of http://(username:password@)domain these will be rejected by the server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Uri { get; set; }

}

/// <summary>
/// Block type for security_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterStorageBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_gkeonprem_bare_metal_admin_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremBareMetalAdminCluster : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// A human readable description of this Bare Metal Admin Cluster.
    /// </summary>
    [TerraformPropertyName("bare_metal_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BareMetalVersion { get; set; }

    /// <summary>
    /// A human readable description of this Bare Metal Admin Cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The bare metal admin cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for cluster_operations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterOperations block(s) allowed")]
    [TerraformPropertyName("cluster_operations")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterClusterOperationsBlock>>? ClusterOperations { get; set; } = new();

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    [TerraformPropertyName("control_plane")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterControlPlaneBlock>>? ControlPlane { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformPropertyName("load_balancer")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterLoadBalancerBlock>>? LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for maintenance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceConfig block(s) allowed")]
    [TerraformPropertyName("maintenance_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterMaintenanceConfigBlock>>? MaintenanceConfig { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for node_access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeAccessConfig block(s) allowed")]
    [TerraformPropertyName("node_access_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterNodeAccessConfigBlock>>? NodeAccessConfig { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterNodeConfigBlock>>? NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformPropertyName("proxy")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterProxyBlock>>? Proxy { get; set; } = new();

    /// <summary>
    /// Block for security_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    [TerraformPropertyName("security_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterSecurityConfigBlock>>? SecurityConfig { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformPropertyName("storage")]
    public TerraformList<TerraformBlock<GoogleGkeonpremBareMetalAdminClusterStorageBlock>>? Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeonpremBareMetalAdminClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// The IP address name of Bare Metal Admin Cluster&#39;s API server.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Fleet related configuration.
    /// Fleets are a Google Cloud concept for logically organizing clusters,
    /// letting you use and manage multi-cluster capabilities and apply
    /// consistent policies across your systems.
    /// See [Anthos Fleets](https://cloud.google.com/anthos/multicluster-management/fleets) for
    /// more details on Anthos multi-cluster capabilities using Fleets.
    /// </summary>
    [TerraformPropertyName("fleet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Fleet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "fleet");

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
    [TerraformPropertyName("local_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_name");

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal Admin Cluster.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Specifies detailed cluster status.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "status");

    /// <summary>
    /// The unique identifier of the Bare Metal Admin Cluster.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// Specifies the security related settings for the Bare Metal Admin Cluster.
    /// </summary>
    [TerraformPropertyName("validation_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ValidationCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validation_check");

}
