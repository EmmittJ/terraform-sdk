using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anthos_cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetAnthosClusterBlock : TerraformBlock
{
    /// <summary>
    /// Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.
    /// </summary>
    public TerraformProperty<string>? Membership
    {
        set => SetProperty("membership", value);
    }

}

/// <summary>
/// Block type for associated_entities in .
/// Nesting mode: set
/// </summary>
public class GoogleClouddeployTargetAssociatedEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// The name for the key in the map for which this object is mapped to in the API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityId is required")]
    public required TerraformProperty<string> EntityId
    {
        set => SetProperty("entity_id", value);
    }

}

/// <summary>
/// Block type for custom_target in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetCustomTargetBlock : TerraformBlock
{
    /// <summary>
    /// Required. The name of the CustomTargetType. Format must be `projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomTargetType is required")]
    public required TerraformProperty<string> CustomTargetType
    {
        set => SetProperty("custom_target_type", value);
    }

}

/// <summary>
/// Block type for execution_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetExecutionConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Cloud Storage location in which to store execution outputs. This can either be a bucket (&amp;quot;gs://my-bucket&amp;quot;) or a path within a bucket (&amp;quot;gs://my-bucket/my-dir&amp;quot;). If unspecified, a default bucket located in the same region will be used.
    /// </summary>
    public TerraformProperty<string>? ArtifactStorage
    {
        set => SetProperty("artifact_storage", value);
    }

    /// <summary>
    /// Optional. Execution timeout for a Cloud Build Execution. This must be between 10m and 24h in seconds format. If unspecified, a default timeout of 1h is used.
    /// </summary>
    public TerraformProperty<string>? ExecutionTimeout
    {
        set => SetProperty("execution_timeout", value);
    }

    /// <summary>
    /// Optional. Google service account to use for execution. If unspecified, the project execution service account (-compute@developer.gserviceaccount.com) is used.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Required. Usages when this configuration should be applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usages is required")]
    public List<TerraformProperty<string>>? Usages
    {
        set => SetProperty("usages", value);
    }

    /// <summary>
    /// Optional. If true, additional logging will be enabled when running builds in this execution environment.
    /// </summary>
    public TerraformProperty<bool>? Verbose
    {
        set => SetProperty("verbose", value);
    }

    /// <summary>
    /// Optional. The resource name of the `WorkerPool`, with the format `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified, the default Cloud Build pool will be used.
    /// </summary>
    public TerraformProperty<string>? WorkerPool
    {
        set => SetProperty("worker_pool", value);
    }

}

/// <summary>
/// Block type for gke in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetGkeBlock : TerraformBlock
{
    /// <summary>
    /// Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and `internal_ip` cannot be set to true.
    /// </summary>
    public TerraformProperty<bool>? DnsEndpoint
    {
        set => SetProperty("dns_endpoint", value);
    }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of the control plane endpoint. Otherwise, the default IP address of the control plane endpoint is used. The default IP address is the private IP address for clusters with private control-plane endpoints and the public IP address otherwise. Only specify this option when `cluster` is a [private GKE cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    /// </summary>
    public TerraformProperty<bool>? InternalIp
    {
        set => SetProperty("internal_ip", value);
    }

    /// <summary>
    /// Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.
    /// </summary>
    public TerraformProperty<string>? ProxyUrl
    {
        set => SetProperty("proxy_url", value);
    }

}

/// <summary>
/// Block type for multi_target in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetMultiTargetBlock : TerraformBlock
{
    /// <summary>
    /// Required. The target_ids of this multiTarget.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIds is required")]
    public List<TerraformProperty<string>>? TargetIds
    {
        set => SetProperty("target_ids", value);
    }

}

/// <summary>
/// Block type for run in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetRunBlock : TerraformBlock
{
    /// <summary>
    /// Required. The location where the Cloud Run Service should be located. Format is `projects/{project}/locations/{location}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        set => SetProperty("location", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployTargetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_clouddeploy_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleClouddeployTarget : TerraformResource
{
    public GoogleClouddeployTarget(string name) : base("google_clouddeploy_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("target_id");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("deploy_parameters");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("require_approval");
    }

    /// <summary>
    /// Optional. User annotations. These attributes can only be set and used by the user, and not by Google Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// Optional. The deploy parameters to use for this target.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> DeployParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("deploy_parameters");
        set => SetProperty("deploy_parameters", value);
    }

    /// <summary>
    /// Optional. Description of the `Target`. Max length is 255 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Optional. Labels are attributes that can be set and used by both the user and by Google Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Name of the `Target`. Format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Optional. Whether or not the `Target` requires approval.
    /// </summary>
    public TerraformProperty<bool> RequireApproval
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_approval");
        set => SetProperty("require_approval", value);
    }

    /// <summary>
    /// Block for anthos_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnthosCluster block(s) allowed")]
    public List<GoogleClouddeployTargetAnthosClusterBlock>? AnthosCluster
    {
        set => SetProperty("anthos_cluster", value);
    }

    /// <summary>
    /// Block for associated_entities.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleClouddeployTargetAssociatedEntitiesBlock>? AssociatedEntities
    {
        set => SetProperty("associated_entities", value);
    }

    /// <summary>
    /// Block for custom_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomTarget block(s) allowed")]
    public List<GoogleClouddeployTargetCustomTargetBlock>? CustomTarget
    {
        set => SetProperty("custom_target", value);
    }

    /// <summary>
    /// Block for execution_configs.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleClouddeployTargetExecutionConfigsBlock>? ExecutionConfigs
    {
        set => SetProperty("execution_configs", value);
    }

    /// <summary>
    /// Block for gke.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gke block(s) allowed")]
    public List<GoogleClouddeployTargetGkeBlock>? Gke
    {
        set => SetProperty("gke", value);
    }

    /// <summary>
    /// Block for multi_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTarget block(s) allowed")]
    public List<GoogleClouddeployTargetMultiTargetBlock>? MultiTarget
    {
        set => SetProperty("multi_target", value);
    }

    /// <summary>
    /// Block for run.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Run block(s) allowed")]
    public List<GoogleClouddeployTargetRunBlock>? Run
    {
        set => SetProperty("run", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleClouddeployTargetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Time at which the `Target` was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. Resource id of the `Target`.
    /// </summary>
    public TerraformExpression TargetId => this["target_id"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. Unique identifier of the `Target`.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Most recent time at which the `Target` was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
