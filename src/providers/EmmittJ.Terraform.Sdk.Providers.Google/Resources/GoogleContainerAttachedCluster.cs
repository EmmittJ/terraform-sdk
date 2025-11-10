using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterAuthorizationBlock : ITerraformBlock
{
    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [TerraformPropertyName("admin_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdminGroups { get; set; }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [TerraformPropertyName("admin_users")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdminUsers { get; set; }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterBinaryAuthorizationBlock : ITerraformBlock
{
    /// <summary>
    /// Configure Binary Authorization evaluation mode. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("evaluation_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvaluationMode { get; set; }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterFleetBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the managed Hub Membership resource associated to this
    /// cluster. Membership names are formatted as
    /// projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;.
    /// </summary>
    [TerraformPropertyName("membership")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Membership => new TerraformReferenceProperty<TerraformProperty<string>>("", "membership");

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterLoggingConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterMonitoringConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for oidc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterOidcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A JSON Web Token (JWT) issuer URI. &#39;issuer&#39; must start with &#39;https://&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    [TerraformPropertyName("issuer_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IssuerUrl { get; set; }

    /// <summary>
    /// OIDC verification keys in JWKS format (RFC 7517).
    /// </summary>
    [TerraformPropertyName("jwks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Jwks { get; set; }

}

/// <summary>
/// Block type for proxy_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterProxyConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleContainerAttachedClusterSecurityPostureConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Possible values: [&amp;quot;VULNERABILITY_DISABLED&amp;quot;, &amp;quot;VULNERABILITY_ENTERPRISE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VulnerabilityMode is required")]
    [TerraformPropertyName("vulnerability_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VulnerabilityMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAttachedClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a google_container_attached_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerAttachedCluster : TerraformResource
{
    public GoogleContainerAttachedCluster(string name) : base("google_container_attached_cluster", name)
    {
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &amp;quot;eks&amp;quot;, &amp;quot;aks&amp;quot;, &amp;quot;generic&amp;quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    [TerraformPropertyName("distribution")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Distribution { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The platform version for the cluster (e.g. &#39;1.23.0-gke.1&#39;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformVersion is required")]
    [TerraformPropertyName("platform_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PlatformVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformPropertyName("authorization")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterAuthorizationBlock>>? Authorization { get; set; } = new();

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformPropertyName("binary_authorization")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterBinaryAuthorizationBlock>>? BinaryAuthorization { get; set; } = new();

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformPropertyName("fleet")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterFleetBlock>>? Fleet { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    [TerraformPropertyName("monitoring_config")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterMonitoringConfigBlock>>? MonitoringConfig { get; set; } = new();

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OidcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OidcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    [TerraformPropertyName("oidc_config")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterOidcConfigBlock>>? OidcConfig { get; set; } = new();

    /// <summary>
    /// Block for proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    [TerraformPropertyName("proxy_config")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterProxyConfigBlock>>? ProxyConfig { get; set; } = new();

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("security_posture_config")]
    public TerraformList<TerraformBlock<GoogleContainerAttachedClusterSecurityPostureConfigBlock>>? SecurityPostureConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerAttachedClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The region where this cluster runs.
    /// 
    /// For EKS clusters, this is an AWS region. For AKS clusters,
    /// this is an Azure region.
    /// </summary>
    [TerraformPropertyName("cluster_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_region");

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// A set of errors found in the cluster.
    /// </summary>
    [TerraformPropertyName("errors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Errors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "errors");

    /// <summary>
    /// The Kubernetes version of the cluster.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubernetesVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kubernetes_version");

    /// <summary>
    /// If set, there are currently changes in flight to the cluster.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The current state of the cluster. Possible values:
    /// STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR,
    /// DEGRADED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// A globally unique identifier for the cluster.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The time at which this cluster was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// Workload Identity settings.
    /// </summary>
    [TerraformPropertyName("workload_identity_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkloadIdentityConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workload_identity_config");

}
