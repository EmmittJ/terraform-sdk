using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    public List<TerraformProperty<string>>? AdminGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("admin_groups");
        set => WithProperty("admin_groups", value);
    }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    public List<TerraformProperty<string>>? AdminUsers
    {
        get => GetProperty<List<TerraformProperty<string>>>("admin_users");
        set => WithProperty("admin_users", value);
    }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Configure Binary Authorization evaluation mode. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EvaluationMode
    {
        get => GetProperty<TerraformProperty<string>>("evaluation_mode");
        set => WithProperty("evaluation_mode", value);
    }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// The name of the managed Hub Membership resource associated to this
    /// cluster. Membership names are formatted as
    /// projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Membership
    {
        get => GetProperty<TerraformProperty<string>>("membership");
        set => WithProperty("membership", value);
    }

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformProperty<string> Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => WithProperty("project", value);
    }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterLoggingConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterMonitoringConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for oidc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterOidcConfigBlock : TerraformBlock
{
    /// <summary>
    /// A JSON Web Token (JWT) issuer URI. &#39;issuer&#39; must start with &#39;https://&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    public required TerraformProperty<string> IssuerUrl
    {
        get => GetProperty<TerraformProperty<string>>("issuer_url");
        set => WithProperty("issuer_url", value);
    }

    /// <summary>
    /// OIDC verification keys in JWKS format (RFC 7517).
    /// </summary>
    public TerraformProperty<string>? Jwks
    {
        get => GetProperty<TerraformProperty<string>>("jwks");
        set => WithProperty("jwks", value);
    }

}

/// <summary>
/// Block type for proxy_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterProxyConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterSecurityPostureConfigBlock : TerraformBlock
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Possible values: [&amp;quot;VULNERABILITY_DISABLED&amp;quot;, &amp;quot;VULNERABILITY_ENTERPRISE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VulnerabilityMode is required")]
    public required TerraformProperty<string> VulnerabilityMode
    {
        get => GetProperty<TerraformProperty<string>>("vulnerability_mode");
        set => WithProperty("vulnerability_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAttachedClusterTimeoutsBlock : TerraformBlock
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
/// Manages a google_container_attached_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerAttachedCluster : TerraformResource
{
    public GoogleContainerAttachedCluster(string name) : base("google_container_attached_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_region");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("errors");
        this.DeclareOutput("kubernetes_version");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("workload_identity_config");
    }

    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same
    /// restrictions as Kubernetes annotations. The total size of all keys and
    /// values combined is limited to 256k. Key can have 2 segments: prefix (optional)
    /// and name (required), separated by a slash (/). Prefix must be a DNS subdomain.
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
    /// Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &amp;quot;eks&amp;quot;, &amp;quot;aks&amp;quot;, &amp;quot;generic&amp;quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    public required TerraformProperty<string> Distribution
    {
        get => GetProperty<TerraformProperty<string>>("distribution");
        set => this.WithProperty("distribution", value);
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform version for the cluster (e.g. &#39;1.23.0-gke.1&#39;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformVersion is required")]
    public required TerraformProperty<string> PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
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
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public List<GoogleContainerAttachedClusterAuthorizationBlock>? Authorization
    {
        get => GetProperty<List<GoogleContainerAttachedClusterAuthorizationBlock>>("authorization");
        set => this.WithProperty("authorization", value);
    }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public List<GoogleContainerAttachedClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetProperty<List<GoogleContainerAttachedClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => this.WithProperty("binary_authorization", value);
    }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public List<GoogleContainerAttachedClusterFleetBlock>? Fleet
    {
        get => GetProperty<List<GoogleContainerAttachedClusterFleetBlock>>("fleet");
        set => this.WithProperty("fleet", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleContainerAttachedClusterLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<GoogleContainerAttachedClusterLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    public List<GoogleContainerAttachedClusterMonitoringConfigBlock>? MonitoringConfig
    {
        get => GetProperty<List<GoogleContainerAttachedClusterMonitoringConfigBlock>>("monitoring_config");
        set => this.WithProperty("monitoring_config", value);
    }

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OidcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    public List<GoogleContainerAttachedClusterOidcConfigBlock>? OidcConfig
    {
        get => GetProperty<List<GoogleContainerAttachedClusterOidcConfigBlock>>("oidc_config");
        set => this.WithProperty("oidc_config", value);
    }

    /// <summary>
    /// Block for proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    public List<GoogleContainerAttachedClusterProxyConfigBlock>? ProxyConfig
    {
        get => GetProperty<List<GoogleContainerAttachedClusterProxyConfigBlock>>("proxy_config");
        set => this.WithProperty("proxy_config", value);
    }

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    public List<GoogleContainerAttachedClusterSecurityPostureConfigBlock>? SecurityPostureConfig
    {
        get => GetProperty<List<GoogleContainerAttachedClusterSecurityPostureConfigBlock>>("security_posture_config");
        set => this.WithProperty("security_posture_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAttachedClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerAttachedClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The region where this cluster runs.
    /// 
    /// For EKS clusters, this is an AWS region. For AKS clusters,
    /// this is an Azure region.
    /// </summary>
    public TerraformExpression ClusterRegion => this["cluster_region"];

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// A set of errors found in the cluster.
    /// </summary>
    public TerraformExpression Errors => this["errors"];

    /// <summary>
    /// The Kubernetes version of the cluster.
    /// </summary>
    public TerraformExpression KubernetesVersion => this["kubernetes_version"];

    /// <summary>
    /// If set, there are currently changes in flight to the cluster.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of the cluster. Possible values:
    /// STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR,
    /// DEGRADED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// A globally unique identifier for the cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time at which this cluster was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Workload Identity settings.
    /// </summary>
    public TerraformExpression WorkloadIdentityConfig => this["workload_identity_config"];

}
