using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [TerraformProperty("admin_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdminGroups { get; set; }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    [TerraformProperty("admin_users")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdminUsers { get; set; }

}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterBinaryAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// Configure Binary Authorization evaluation mode. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    [TerraformProperty("evaluation_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EvaluationMode { get; set; }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterFleetBlock : TerraformBlockBase
{

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Project { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterLoggingConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for monitoring_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterMonitoringConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for oidc_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterOidcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// A JSON Web Token (JWT) issuer URI. &#39;issuer&#39; must start with &#39;https://&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    [TerraformProperty("issuer_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IssuerUrl { get; set; }

    /// <summary>
    /// OIDC verification keys in JWKS format (RFC 7517).
    /// </summary>
    [TerraformProperty("jwks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Jwks { get; set; }

}

/// <summary>
/// Block type for proxy_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAttachedClusterProxyConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for security_posture_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class GoogleContainerAttachedClusterSecurityPostureConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Possible values: [&amp;quot;VULNERABILITY_DISABLED&amp;quot;, &amp;quot;VULNERABILITY_ENTERPRISE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VulnerabilityMode is required")]
    [TerraformProperty("vulnerability_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VulnerabilityMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContainerAttachedClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_container_attached_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContainerAttachedCluster : TerraformResource
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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &amp;quot;eks&amp;quot;, &amp;quot;aks&amp;quot;, &amp;quot;generic&amp;quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    [TerraformProperty("distribution")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Distribution { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform version for the cluster (e.g. &#39;1.23.0-gke.1&#39;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformVersion is required")]
    [TerraformProperty("platform_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PlatformVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformProperty("authorization")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterAuthorizationBlock>>? Authorization { get; set; }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformProperty("binary_authorization")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterBinaryAuthorizationBlock>>? BinaryAuthorization { get; set; }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformProperty("fleet")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterFleetBlock>>? Fleet { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// Block for monitoring_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    [TerraformProperty("monitoring_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterMonitoringConfigBlock>>? MonitoringConfig { get; set; }

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OidcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OidcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    [TerraformProperty("oidc_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterOidcConfigBlock>>? OidcConfig { get; set; }

    /// <summary>
    /// Block for proxy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    [TerraformProperty("proxy_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterProxyConfigBlock>>? ProxyConfig { get; set; }

    /// <summary>
    /// Block for security_posture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("security_posture_config")]
    public partial TerraformList<TerraformBlock<GoogleContainerAttachedClusterSecurityPostureConfigBlock>>? SecurityPostureConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleContainerAttachedClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The region where this cluster runs.
    /// 
    /// For EKS clusters, this is an AWS region. For AKS clusters,
    /// this is an Azure region.
    /// </summary>
    [TerraformProperty("cluster_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterRegion { get; }

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// A set of errors found in the cluster.
    /// </summary>
    [TerraformProperty("errors")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Errors { get; }

    /// <summary>
    /// The Kubernetes version of the cluster.
    /// </summary>
    [TerraformProperty("kubernetes_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KubernetesVersion { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the cluster.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of the cluster. Possible values:
    /// STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR,
    /// DEGRADED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// A globally unique identifier for the cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time at which this cluster was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Workload Identity settings.
    /// </summary>
    [TerraformProperty("workload_identity_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WorkloadIdentityConfig { get; }

}
