using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anthos_cluster in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployTargetAnthosClusterBlock : TerraformBlockBase
{
    /// <summary>
    /// Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.
    /// </summary>
    [TerraformProperty("membership")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Membership { get; set; }

}

/// <summary>
/// Block type for associated_entities in .
/// Nesting mode: set
/// </summary>
public partial class GoogleClouddeployTargetAssociatedEntitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The name for the key in the map for which this object is mapped to in the API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityId is required")]
    [TerraformProperty("entity_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EntityId { get; set; }

}

/// <summary>
/// Block type for custom_target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployTargetCustomTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The name of the CustomTargetType. Format must be `projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomTargetType is required")]
    [TerraformProperty("custom_target_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomTargetType { get; set; }

}

/// <summary>
/// Block type for execution_configs in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployTargetExecutionConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Cloud Storage location in which to store execution outputs. This can either be a bucket (&amp;quot;gs://my-bucket&amp;quot;) or a path within a bucket (&amp;quot;gs://my-bucket/my-dir&amp;quot;). If unspecified, a default bucket located in the same region will be used.
    /// </summary>
    [TerraformProperty("artifact_storage")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ArtifactStorage { get; set; }

    /// <summary>
    /// Optional. Execution timeout for a Cloud Build Execution. This must be between 10m and 24h in seconds format. If unspecified, a default timeout of 1h is used.
    /// </summary>
    [TerraformProperty("execution_timeout")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExecutionTimeout { get; set; }

    /// <summary>
    /// Optional. Google service account to use for execution. If unspecified, the project execution service account (-compute@developer.gserviceaccount.com) is used.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Required. Usages when this configuration should be applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usages is required")]
    [TerraformProperty("usages")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Usages { get; set; }

    /// <summary>
    /// Optional. If true, additional logging will be enabled when running builds in this execution environment.
    /// </summary>
    [TerraformProperty("verbose")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Verbose { get; set; }

    /// <summary>
    /// Optional. The resource name of the `WorkerPool`, with the format `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified, the default Cloud Build pool will be used.
    /// </summary>
    [TerraformProperty("worker_pool")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WorkerPool { get; set; }

}

/// <summary>
/// Block type for gke in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployTargetGkeBlock : TerraformBlockBase
{
    /// <summary>
    /// Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}.
    /// </summary>
    [TerraformProperty("cluster")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Cluster { get; set; }

    /// <summary>
    /// Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and `internal_ip` cannot be set to true.
    /// </summary>
    [TerraformProperty("dns_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DnsEndpoint { get; set; }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of the control plane endpoint. Otherwise, the default IP address of the control plane endpoint is used. The default IP address is the private IP address for clusters with private control-plane endpoints and the public IP address otherwise. Only specify this option when `cluster` is a [private GKE cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    /// </summary>
    [TerraformProperty("internal_ip")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InternalIp { get; set; }

    /// <summary>
    /// Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.
    /// </summary>
    [TerraformProperty("proxy_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProxyUrl { get; set; }

}

/// <summary>
/// Block type for multi_target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployTargetMultiTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The target_ids of this multiTarget.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIds is required")]
    [TerraformProperty("target_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? TargetIds { get; set; }

}

/// <summary>
/// Block type for run in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployTargetRunBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The location where the Cloud Run Service should be located. Format is `projects/{project}/locations/{location}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleClouddeployTargetTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_clouddeploy_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleClouddeployTarget : TerraformResource
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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Optional. The deploy parameters to use for this target.
    /// </summary>
    [TerraformProperty("deploy_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? DeployParameters { get; set; }

    /// <summary>
    /// Optional. Description of the `Target`. Max length is 255 characters.
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
    /// Optional. Labels are attributes that can be set and used by both the user and by Google Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of the `Target`. Format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. Whether or not the `Target` requires approval.
    /// </summary>
    [TerraformProperty("require_approval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireApproval { get; set; }

    /// <summary>
    /// Block for anthos_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnthosCluster block(s) allowed")]
    [TerraformProperty("anthos_cluster")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetAnthosClusterBlock>>? AnthosCluster { get; set; }

    /// <summary>
    /// Block for associated_entities.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("associated_entities")]
    public TerraformSet<TerraformBlock<GoogleClouddeployTargetAssociatedEntitiesBlock>>? AssociatedEntities { get; set; }

    /// <summary>
    /// Block for custom_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomTarget block(s) allowed")]
    [TerraformProperty("custom_target")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetCustomTargetBlock>>? CustomTarget { get; set; }

    /// <summary>
    /// Block for execution_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("execution_configs")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetExecutionConfigsBlock>>? ExecutionConfigs { get; set; }

    /// <summary>
    /// Block for gke.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gke block(s) allowed")]
    [TerraformProperty("gke")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetGkeBlock>>? Gke { get; set; }

    /// <summary>
    /// Block for multi_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTarget block(s) allowed")]
    [TerraformProperty("multi_target")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetMultiTargetBlock>>? MultiTarget { get; set; }

    /// <summary>
    /// Block for run.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Run block(s) allowed")]
    [TerraformProperty("run")]
    public TerraformList<TerraformBlock<GoogleClouddeployTargetRunBlock>>? Run { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleClouddeployTargetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Time at which the `Target` was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. Resource id of the `Target`.
    /// </summary>
    [TerraformProperty("target_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TargetId { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. Unique identifier of the `Target`.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. Most recent time at which the `Target` was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
