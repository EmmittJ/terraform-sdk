using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anthos_cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetAnthosClusterBlock : ITerraformBlock
{
    /// <summary>
    /// Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.
    /// </summary>
    [TerraformPropertyName("membership")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Membership { get; set; }

}

/// <summary>
/// Block type for associated_entities in .
/// Nesting mode: set
/// </summary>
public class GoogleClouddeployTargetAssociatedEntitiesBlock : ITerraformBlock
{
    /// <summary>
    /// The name for the key in the map for which this object is mapped to in the API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityId is required")]
    [TerraformPropertyName("entity_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EntityId { get; set; }

}

/// <summary>
/// Block type for custom_target in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetCustomTargetBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The name of the CustomTargetType. Format must be `projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomTargetType is required")]
    [TerraformPropertyName("custom_target_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomTargetType { get; set; }

}

/// <summary>
/// Block type for execution_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetExecutionConfigsBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Cloud Storage location in which to store execution outputs. This can either be a bucket (&amp;quot;gs://my-bucket&amp;quot;) or a path within a bucket (&amp;quot;gs://my-bucket/my-dir&amp;quot;). If unspecified, a default bucket located in the same region will be used.
    /// </summary>
    [TerraformPropertyName("artifact_storage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ArtifactStorage { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "artifact_storage");

    /// <summary>
    /// Optional. Execution timeout for a Cloud Build Execution. This must be between 10m and 24h in seconds format. If unspecified, a default timeout of 1h is used.
    /// </summary>
    [TerraformPropertyName("execution_timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExecutionTimeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "execution_timeout");

    /// <summary>
    /// Optional. Google service account to use for execution. If unspecified, the project execution service account (-compute@developer.gserviceaccount.com) is used.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceAccount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_account");

    /// <summary>
    /// Required. Usages when this configuration should be applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usages is required")]
    [TerraformPropertyName("usages")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Usages { get; set; }

    /// <summary>
    /// Optional. If true, additional logging will be enabled when running builds in this execution environment.
    /// </summary>
    [TerraformPropertyName("verbose")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Verbose { get; set; }

    /// <summary>
    /// Optional. The resource name of the `WorkerPool`, with the format `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified, the default Cloud Build pool will be used.
    /// </summary>
    [TerraformPropertyName("worker_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkerPool { get; set; }

}

/// <summary>
/// Block type for gke in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetGkeBlock : ITerraformBlock
{
    /// <summary>
    /// Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}.
    /// </summary>
    [TerraformPropertyName("cluster")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cluster { get; set; }

    /// <summary>
    /// Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and `internal_ip` cannot be set to true.
    /// </summary>
    [TerraformPropertyName("dns_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DnsEndpoint { get; set; }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of the control plane endpoint. Otherwise, the default IP address of the control plane endpoint is used. The default IP address is the private IP address for clusters with private control-plane endpoints and the public IP address otherwise. Only specify this option when `cluster` is a [private GKE cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    /// </summary>
    [TerraformPropertyName("internal_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternalIp { get; set; }

    /// <summary>
    /// Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.
    /// </summary>
    [TerraformPropertyName("proxy_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyUrl { get; set; }

}

/// <summary>
/// Block type for multi_target in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetMultiTargetBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The target_ids of this multiTarget.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIds is required")]
    [TerraformPropertyName("target_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? TargetIds { get; set; }

}

/// <summary>
/// Block type for run in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetRunBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The location where the Cloud Run Service should be located. Format is `projects/{project}/locations/{location}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployTargetTimeoutsBlock : ITerraformBlock
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
/// Manages a google_clouddeploy_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleClouddeployTarget : TerraformResource
{
    public GoogleClouddeployTarget(string name) : base("google_clouddeploy_target", name)
    {
    }

    /// <summary>
    /// Optional. User annotations. These attributes can only be set and used by the user, and not by Google Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// Optional. The deploy parameters to use for this target.
    /// </summary>
    [TerraformPropertyName("deploy_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? DeployParameters { get; set; }

    /// <summary>
    /// Optional. Description of the `Target`. Max length is 255 characters.
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
    /// Optional. Labels are attributes that can be set and used by both the user and by Google Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Name of the `Target`. Format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Optional. Whether or not the `Target` requires approval.
    /// </summary>
    [TerraformPropertyName("require_approval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireApproval { get; set; }

    /// <summary>
    /// Block for anthos_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnthosCluster block(s) allowed")]
    [TerraformPropertyName("anthos_cluster")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetAnthosClusterBlock>>? AnthosCluster { get; set; } = new();

    /// <summary>
    /// Block for associated_entities.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("associated_entities")]
    public TerraformSet<TerraformBlock<GoogleClouddeployTargetAssociatedEntitiesBlock>>? AssociatedEntities { get; set; } = new();

    /// <summary>
    /// Block for custom_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomTarget block(s) allowed")]
    [TerraformPropertyName("custom_target")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetCustomTargetBlock>>? CustomTarget { get; set; } = new();

    /// <summary>
    /// Block for execution_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("execution_configs")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetExecutionConfigsBlock>>? ExecutionConfigs { get; set; } = new();

    /// <summary>
    /// Block for gke.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gke block(s) allowed")]
    [TerraformPropertyName("gke")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetGkeBlock>>? Gke { get; set; } = new();

    /// <summary>
    /// Block for multi_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTarget block(s) allowed")]
    [TerraformPropertyName("multi_target")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetMultiTargetBlock>>? MultiTarget { get; set; } = new();

    /// <summary>
    /// Block for run.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Run block(s) allowed")]
    [TerraformPropertyName("run")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetRunBlock>>? Run { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleClouddeployTargetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Time at which the `Target` was created.
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Output only. Resource id of the `Target`.
    /// </summary>
    [TerraformPropertyName("target_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_id");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. Unique identifier of the `Target`.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Output only. Most recent time at which the `Target` was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
