using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// Groups that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the groups. Up to ten admin groups can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    public TerraformList<string>? AdminGroups
    {
        get => GetArgument<TerraformList<string>>("admin_groups");
        set => SetArgument("admin_groups", value);
    }

    /// <summary>
    /// Users that can perform operations as a cluster admin. A managed
    /// ClusterRoleBinding will be created to grant the &#39;cluster-admin&#39; ClusterRole
    /// to the users. Up to ten admin users can be provided.
    /// 
    /// For more info on RBAC, see
    /// https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles
    /// </summary>
    public TerraformList<string>? AdminUsers
    {
        get => GetArgument<TerraformList<string>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}


/// <summary>
/// Block type for binary_authorization in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_authorization";

    /// <summary>
    /// Configure Binary Authorization evaluation mode. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;PROJECT_SINGLETON_POLICY_ENFORCE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EvaluationMode
    {
        get => GetArgument<TerraformValue<string>>("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
    }

}


/// <summary>
/// Block type for fleet in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet";

    /// <summary>
    /// The name of the managed Hub Membership resource associated to this
    /// cluster. Membership names are formatted as
    /// projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;.
    /// </summary>
    public TerraformValue<string> Membership
        => CreateReference("membership");

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for logging_config in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// ComponentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComponentConfig block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterLoggingConfigBlockComponentConfigBlock>? ComponentConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterLoggingConfigBlockComponentConfigBlock>>("component_config");
        set => SetArgument("component_config", value);
    }

}

/// <summary>
/// Block type for component_config in GoogleContainerAttachedClusterLoggingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterLoggingConfigBlockComponentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component_config";

    /// <summary>
    /// The components to be enabled. Possible values: [&amp;quot;SYSTEM_COMPONENTS&amp;quot;, &amp;quot;WORKLOADS&amp;quot;]
    /// </summary>
    public TerraformList<string>? EnableComponents
    {
        get => GetArgument<TerraformList<string>>("enable_components");
        set => SetArgument("enable_components", value);
    }

}


/// <summary>
/// Block type for monitoring_config in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterMonitoringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_config";

    /// <summary>
    /// ManagedPrometheusConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedPrometheusConfig block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterMonitoringConfigBlockManagedPrometheusConfigBlock>? ManagedPrometheusConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterMonitoringConfigBlockManagedPrometheusConfigBlock>>("managed_prometheus_config");
        set => SetArgument("managed_prometheus_config", value);
    }

}

/// <summary>
/// Block type for managed_prometheus_config in GoogleContainerAttachedClusterMonitoringConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterMonitoringConfigBlockManagedPrometheusConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_prometheus_config";

    /// <summary>
    /// Enable Managed Collection.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for oidc_config in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterOidcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_config";

    /// <summary>
    /// A JSON Web Token (JWT) issuer URI. &#39;issuer&#39; must start with &#39;https://&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    public required TerraformValue<string> IssuerUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer_url");
        set => SetArgument("issuer_url", value);
    }

    /// <summary>
    /// OIDC verification keys in JWKS format (RFC 7517).
    /// </summary>
    public TerraformValue<string>? Jwks
    {
        get => GetArgument<TerraformValue<string>>("jwks");
        set => SetArgument("jwks", value);
    }

}


/// <summary>
/// Block type for proxy_config in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_config";

    /// <summary>
    /// KubernetesSecret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesSecret block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterProxyConfigBlockKubernetesSecretBlock>? KubernetesSecret
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterProxyConfigBlockKubernetesSecretBlock>>("kubernetes_secret");
        set => SetArgument("kubernetes_secret", value);
    }

}

/// <summary>
/// Block type for kubernetes_secret in GoogleContainerAttachedClusterProxyConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAttachedClusterProxyConfigBlockKubernetesSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubernetes_secret";

    /// <summary>
    /// Name of the kubernetes secret containing the proxy config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Namespace of the kubernetes secret containing the proxy config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for security_posture_config in GoogleContainerAttachedCluster.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleContainerAttachedClusterSecurityPostureConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_posture_config";

    /// <summary>
    /// Sets the mode of the Kubernetes security posture API&#39;s workload vulnerability scanning. Possible values: [&amp;quot;VULNERABILITY_DISABLED&amp;quot;, &amp;quot;VULNERABILITY_ENTERPRISE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VulnerabilityMode is required")]
    public required TerraformValue<string> VulnerabilityMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("vulnerability_mode");
        set => SetArgument("vulnerability_mode", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAttachedCluster.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAttachedClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_container_attached_cluster Terraform resource.
/// Manages a google_container_attached_cluster resource.
/// </summary>
public partial class GoogleContainerAttachedCluster(string name) : TerraformResource("google_container_attached_cluster", name)
{
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
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// A human readable description of this attached cluster. Cannot be longer
    /// than 255 UTF-8 encoded bytes.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The Kubernetes distribution of the underlying attached cluster. Supported values:
    /// &amp;quot;eks&amp;quot;, &amp;quot;aks&amp;quot;, &amp;quot;generic&amp;quot;. The generic distribution provides the ability to register
    /// or migrate any CNCF conformant cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    public required TerraformValue<string> Distribution
    {
        get => GetRequiredArgument<TerraformValue<string>>("distribution");
        set => SetArgument("distribution", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform version for the cluster (e.g. &#39;1.23.0-gke.1&#39;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformVersion is required")]
    public required TerraformValue<string> PlatformVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The region where this cluster runs.
    /// 
    /// For EKS clusters, this is an AWS region. For AKS clusters,
    /// this is an Azure region.
    /// </summary>
    public TerraformValue<string> ClusterRegion
        => CreateReference("cluster_region");

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// A set of errors found in the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> Errors
        => CreateReference("errors");

    /// <summary>
    /// The Kubernetes version of the cluster.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
        => CreateReference("kubernetes_version");

    /// <summary>
    /// If set, there are currently changes in flight to the cluster.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// The current state of the cluster. Possible values:
    /// STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR,
    /// DEGRADED
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// A globally unique identifier for the cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The time at which this cluster was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Workload Identity settings.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadIdentityConfig
        => CreateReference("workload_identity_config");

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// Fleet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public required TerraformList<GoogleContainerAttachedClusterFleetBlock> Fleet
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAttachedClusterFleetBlock>>("fleet");
        set => SetArgument("fleet", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// MonitoringConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfig block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterMonitoringConfigBlock>? MonitoringConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterMonitoringConfigBlock>>("monitoring_config");
        set => SetArgument("monitoring_config", value);
    }

    /// <summary>
    /// OidcConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OidcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OidcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    public required TerraformList<GoogleContainerAttachedClusterOidcConfigBlock> OidcConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAttachedClusterOidcConfigBlock>>("oidc_config");
        set => SetArgument("oidc_config", value);
    }

    /// <summary>
    /// ProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    public TerraformList<GoogleContainerAttachedClusterProxyConfigBlock>? ProxyConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterProxyConfigBlock>>("proxy_config");
        set => SetArgument("proxy_config", value);
    }

    /// <summary>
    /// SecurityPostureConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPostureConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<GoogleContainerAttachedClusterSecurityPostureConfigBlock>? SecurityPostureConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAttachedClusterSecurityPostureConfigBlock>>("security_posture_config");
        set => SetArgument("security_posture_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAttachedClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAttachedClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
