using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Mode of operation for binauthz policy evaluation. If unspecified,
    /// defaults to DISABLED. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EvaluationMode
    {
        get => GetProperty<TerraformProperty<string>>("evaluation_mode");
        set => WithProperty("evaluation_mode", value);
    }

}

/// <summary>
/// Block type for cluster_operations in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterClusterOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
    /// </summary>
    public TerraformProperty<bool>? EnableApplicationLogs
    {
        get => GetProperty<TerraformProperty<bool>>("enable_application_logs");
        set => WithProperty("enable_application_logs", value);
    }

}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterControlPlaneBlock : TerraformBlock
{
}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterLoadBalancerBlock : TerraformBlock
{
}

/// <summary>
/// Block type for maintenance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// All IPv4 address from these ranges will be placed into maintenance mode.
    /// Nodes in maintenance mode will be cordoned and drained. When both of these
    /// are true, the &amp;quot;baremetal.cluster.gke.io/maintenance&amp;quot; annotation will be set
    /// on the node resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceAddressCidrBlocks is required")]
    public List<TerraformProperty<string>>? MaintenanceAddressCidrBlocks
    {
        get => GetProperty<List<TerraformProperty<string>>>("maintenance_address_cidr_blocks");
        set => WithProperty("maintenance_address_cidr_blocks", value);
    }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Enables the use of advanced Anthos networking features, such as Bundled
    /// Load Balancing with BGP or the egress NAT gateway.
    /// Setting configuration for advanced networking features will automatically
    /// set this flag.
    /// </summary>
    public TerraformProperty<bool>? AdvancedNetworking
    {
        get => GetProperty<TerraformProperty<bool>>("advanced_networking");
        set => WithProperty("advanced_networking", value);
    }

}

/// <summary>
/// Block type for node_access_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// LoginUser is the user name used to access node machines.
    /// It defaults to &amp;quot;root&amp;quot; if not set.
    /// </summary>
    public TerraformProperty<string>? LoginUser
    {
        get => GetProperty<TerraformProperty<string>>("login_user");
        set => WithProperty("login_user", value);
    }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The available runtimes that can be used to run containers in a Bare Metal User Cluster. Possible values: [&amp;quot;CONTAINER_RUNTIME_UNSPECIFIED&amp;quot;, &amp;quot;DOCKER&amp;quot;, &amp;quot;CONTAINERD&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ContainerRuntime
    {
        get => GetProperty<TerraformProperty<string>>("container_runtime");
        set => WithProperty("container_runtime", value);
    }

    /// <summary>
    /// The maximum number of pods a node can run. The size of the CIDR range
    /// assigned to the node will be derived from this parameter.
    /// </summary>
    public TerraformProperty<double>? MaxPodsPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_pods_per_node");
        set => WithProperty("max_pods_per_node", value);
    }

}

/// <summary>
/// Block type for os_environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether the package repo should not be included when initializing
    /// bare metal machines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageRepoExcluded is required")]
    public required TerraformProperty<bool> PackageRepoExcluded
    {
        get => GetProperty<TerraformProperty<bool>>("package_repo_excluded");
        set => WithProperty("package_repo_excluded", value);
    }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterProxyBlock : TerraformBlock
{
    /// <summary>
    /// A list of IPs, hostnames, and domains that should skip the proxy.
    /// For example [&amp;quot;127.0.0.1&amp;quot;, &amp;quot;example.com&amp;quot;, &amp;quot;.corp&amp;quot;, &amp;quot;localhost&amp;quot;].
    /// </summary>
    public List<TerraformProperty<string>>? NoProxy
    {
        get => GetProperty<List<TerraformProperty<string>>>("no_proxy");
        set => WithProperty("no_proxy", value);
    }

    /// <summary>
    /// Specifies the address of your proxy server.
    /// For example: http://domain
    /// WARNING: Do not provide credentials in the format
    /// of http://(username:password@)domain these will be rejected by the server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for security_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterSecurityConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterStorageBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremBareMetalClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremBareMetalClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies which upgrade policy to use. Possible values: [&amp;quot;SERIAL&amp;quot;, &amp;quot;CONCURRENT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => WithProperty("policy", value);
    }

}

/// <summary>
/// Manages a google_gkeonprem_bare_metal_cluster resource.
/// </summary>
public class GoogleGkeonpremBareMetalCluster : TerraformResource
{
    public GoogleGkeonpremBareMetalCluster(string name) : base("google_gkeonprem_bare_metal_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("etag");
        this.DeclareOutput("fleet");
        this.DeclareOutput("local_name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("validation_check");
    }

    /// <summary>
    /// The Admin Cluster this Bare Metal User Cluster belongs to.
    /// This is the full resource name of the Admin Cluster&#39;s hub membership.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminClusterMembership is required")]
    public required TerraformProperty<string> AdminClusterMembership
    {
        get => GetProperty<TerraformProperty<string>>("admin_cluster_membership");
        set => this.WithProperty("admin_cluster_membership", value);
    }

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
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// A human readable description of this Bare Metal User Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BareMetalVersion is required")]
    public required TerraformProperty<string> BareMetalVersion
    {
        get => GetProperty<TerraformProperty<string>>("bare_metal_version");
        set => this.WithProperty("bare_metal_version", value);
    }

    /// <summary>
    /// A human readable description of this Bare Metal User Cluster.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The bare metal cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => this.WithProperty("binary_authorization", value);
    }

    /// <summary>
    /// Block for cluster_operations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterOperations block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterClusterOperationsBlock>? ClusterOperations
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterClusterOperationsBlock>>("cluster_operations");
        set => this.WithProperty("cluster_operations", value);
    }

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlane block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterControlPlaneBlock>? ControlPlane
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterControlPlaneBlock>>("control_plane");
        set => this.WithProperty("control_plane", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterLoadBalancerBlock>? LoadBalancer
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterLoadBalancerBlock>>("load_balancer");
        set => this.WithProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for maintenance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceConfig block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock>? MaintenanceConfig
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterMaintenanceConfigBlock>>("maintenance_config");
        set => this.WithProperty("maintenance_config", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for node_access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeAccessConfig block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock>? NodeAccessConfig
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterNodeAccessConfigBlock>>("node_access_config");
        set => this.WithProperty("node_access_config", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterNodeConfigBlock>? NodeConfig
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterNodeConfigBlock>>("node_config");
        set => this.WithProperty("node_config", value);
    }

    /// <summary>
    /// Block for os_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsEnvironmentConfig block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock>? OsEnvironmentConfig
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterOsEnvironmentConfigBlock>>("os_environment_config");
        set => this.WithProperty("os_environment_config", value);
    }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterProxyBlock>? Proxy
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterProxyBlock>>("proxy");
        set => this.WithProperty("proxy", value);
    }

    /// <summary>
    /// Block for security_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterSecurityConfigBlock>? SecurityConfig
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterSecurityConfigBlock>>("security_config");
        set => this.WithProperty("security_config", value);
    }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Storage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterStorageBlock>? Storage
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterStorageBlock>>("storage");
        set => this.WithProperty("storage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeonpremBareMetalClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGkeonpremBareMetalClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public List<GoogleGkeonpremBareMetalClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetProperty<List<GoogleGkeonpremBareMetalClusterUpgradePolicyBlock>>("upgrade_policy");
        set => this.WithProperty("upgrade_policy", value);
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// The IP address name of Bare Metal User Cluster&#39;s API server.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Fleet related configuration.
    /// Fleets are a Google Cloud concept for logically organizing clusters,
    /// letting you use and manage multi-cluster capabilities and apply
    /// consistent policies across your systems.
    /// See [Anthos Fleets](https://cloud.google.com/anthos/multicluster-management/fleets) for
    /// more details on Anthos multi-cluster capabilities using Fleets.
    /// </summary>
    public TerraformExpression Fleet => this["fleet"];

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
    public TerraformExpression LocalName => this["local_name"];

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal User Cluster.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Specifies detailed cluster status.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The unique identifier of the Bare Metal User Cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Specifies the security related settings for the Bare Metal User Cluster.
    /// </summary>
    public TerraformExpression ValidationCheck => this["validation_check"];

}
