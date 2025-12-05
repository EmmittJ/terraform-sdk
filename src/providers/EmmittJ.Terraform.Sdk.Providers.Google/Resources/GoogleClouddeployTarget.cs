using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anthos_cluster in GoogleClouddeployTarget.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetAnthosClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "anthos_cluster";

    /// <summary>
    /// Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.
    /// </summary>
    public TerraformValue<string>? Membership
    {
        get => GetArgument<TerraformValue<string>>("membership");
        set => SetArgument("membership", value);
    }

}


/// <summary>
/// Block type for associated_entities in GoogleClouddeployTarget.
/// Nesting mode: set
/// </summary>
public class GoogleClouddeployTargetAssociatedEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "associated_entities";

    /// <summary>
    /// The name for the key in the map for which this object is mapped to in the API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityId is required")]
    public required TerraformValue<string> EntityId
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity_id");
        set => SetArgument("entity_id", value);
    }

    /// <summary>
    /// AnthosClusters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployTargetAssociatedEntitiesBlockAnthosClustersBlock>? AnthosClusters
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetAssociatedEntitiesBlockAnthosClustersBlock>>("anthos_clusters");
        set => SetArgument("anthos_clusters", value);
    }

    /// <summary>
    /// GkeClusters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployTargetAssociatedEntitiesBlockGkeClustersBlock>? GkeClusters
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetAssociatedEntitiesBlockGkeClustersBlock>>("gke_clusters");
        set => SetArgument("gke_clusters", value);
    }

}

/// <summary>
/// Block type for anthos_clusters in GoogleClouddeployTargetAssociatedEntitiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetAssociatedEntitiesBlockAnthosClustersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "anthos_clusters";

    /// <summary>
    /// Optional. Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format is `projects/{project}/locations/{location}/memberships/{membership_name}`.
    /// </summary>
    public TerraformValue<string>? Membership
    {
        get => GetArgument<TerraformValue<string>>("membership");
        set => SetArgument("membership", value);
    }

}

/// <summary>
/// Block type for gke_clusters in GoogleClouddeployTargetAssociatedEntitiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetAssociatedEntitiesBlockGkeClustersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_clusters";

    /// <summary>
    /// Optional. Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`.
    /// </summary>
    public TerraformValue<string>? Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of the control plane endpoint. Otherwise, the default IP address of the control plane endpoint is used. The default IP address is the private IP address for clusters with private control-plane endpoints and the public IP address otherwise. Only specify this option when `cluster` is a [private GKE cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    /// </summary>
    public TerraformValue<bool>? InternalIp
    {
        get => GetArgument<TerraformValue<bool>>("internal_ip");
        set => SetArgument("internal_ip", value);
    }

    /// <summary>
    /// Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.
    /// </summary>
    public TerraformValue<string>? ProxyUrl
    {
        get => GetArgument<TerraformValue<string>>("proxy_url");
        set => SetArgument("proxy_url", value);
    }

}


/// <summary>
/// Block type for custom_target in GoogleClouddeployTarget.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetCustomTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_target";

    /// <summary>
    /// Required. The name of the CustomTargetType. Format must be `projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomTargetType is required")]
    public required TerraformValue<string> CustomTargetType
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_target_type");
        set => SetArgument("custom_target_type", value);
    }

}


/// <summary>
/// Block type for execution_configs in GoogleClouddeployTarget.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetExecutionConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_configs";

    /// <summary>
    /// Optional. Cloud Storage location in which to store execution outputs. This can either be a bucket (&amp;quot;gs://my-bucket&amp;quot;) or a path within a bucket (&amp;quot;gs://my-bucket/my-dir&amp;quot;). If unspecified, a default bucket located in the same region will be used.
    /// </summary>
    public TerraformValue<string> ArtifactStorage
    {
        get => GetArgument<TerraformValue<string>>("artifact_storage") ?? CreateReference("artifact_storage");
        set => SetArgument("artifact_storage", value);
    }

    /// <summary>
    /// Optional. Execution timeout for a Cloud Build Execution. This must be between 10m and 24h in seconds format. If unspecified, a default timeout of 1h is used.
    /// </summary>
    public TerraformValue<string> ExecutionTimeout
    {
        get => GetArgument<TerraformValue<string>>("execution_timeout") ?? CreateReference("execution_timeout");
        set => SetArgument("execution_timeout", value);
    }

    /// <summary>
    /// Optional. Google service account to use for execution. If unspecified, the project execution service account (-compute@developer.gserviceaccount.com) is used.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? CreateReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Required. Usages when this configuration should be applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usages is required")]
    public TerraformList<string>? Usages
    {
        get => GetArgument<TerraformList<string>>("usages");
        set => SetArgument("usages", value);
    }

    /// <summary>
    /// Optional. If true, additional logging will be enabled when running builds in this execution environment.
    /// </summary>
    public TerraformValue<bool>? Verbose
    {
        get => GetArgument<TerraformValue<bool>>("verbose");
        set => SetArgument("verbose", value);
    }

    /// <summary>
    /// Optional. The resource name of the `WorkerPool`, with the format `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified, the default Cloud Build pool will be used.
    /// </summary>
    public TerraformValue<string>? WorkerPool
    {
        get => GetArgument<TerraformValue<string>>("worker_pool");
        set => SetArgument("worker_pool", value);
    }

}


/// <summary>
/// Block type for gke in GoogleClouddeployTarget.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetGkeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke";

    /// <summary>
    /// Information specifying a GKE Cluster. Format is `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}.
    /// </summary>
    public TerraformValue<string>? Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and `internal_ip` cannot be set to true.
    /// </summary>
    public TerraformValue<bool>? DnsEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("dns_endpoint");
        set => SetArgument("dns_endpoint", value);
    }

    /// <summary>
    /// Optional. If true, `cluster` is accessed using the private IP address of the control plane endpoint. Otherwise, the default IP address of the control plane endpoint is used. The default IP address is the private IP address for clusters with private control-plane endpoints and the public IP address otherwise. Only specify this option when `cluster` is a [private GKE cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept).
    /// </summary>
    public TerraformValue<bool>? InternalIp
    {
        get => GetArgument<TerraformValue<bool>>("internal_ip");
        set => SetArgument("internal_ip", value);
    }

    /// <summary>
    /// Optional. If set, used to configure a [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the Kubernetes server.
    /// </summary>
    public TerraformValue<string>? ProxyUrl
    {
        get => GetArgument<TerraformValue<string>>("proxy_url");
        set => SetArgument("proxy_url", value);
    }

}


/// <summary>
/// Block type for multi_target in GoogleClouddeployTarget.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetMultiTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_target";

    /// <summary>
    /// Required. The target_ids of this multiTarget.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIds is required")]
    public TerraformList<string>? TargetIds
    {
        get => GetArgument<TerraformList<string>>("target_ids");
        set => SetArgument("target_ids", value);
    }

}


/// <summary>
/// Block type for run in GoogleClouddeployTarget.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployTargetRunBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "run";

    /// <summary>
    /// Required. The location where the Cloud Run Service should be located. Format is `projects/{project}/locations/{location}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleClouddeployTarget.
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployTargetTimeoutsBlock : TerraformBlock
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
/// Represents a google_clouddeploy_target Terraform resource.
/// Manages a google_clouddeploy_target resource.
/// </summary>
public partial class GoogleClouddeployTarget(string name) : TerraformResource("google_clouddeploy_target", name)
{
    /// <summary>
    /// Optional. User annotations. These attributes can only be set and used by the user, and not by Google Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Optional. The deploy parameters to use for this target.
    /// </summary>
    public TerraformMap<string>? DeployParameters
    {
        get => GetArgument<TerraformMap<string>>("deploy_parameters");
        set => SetArgument("deploy_parameters", value);
    }

    /// <summary>
    /// Optional. Description of the `Target`. Max length is 255 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Optional. Labels are attributes that can be set and used by both the user and by Google Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
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
    /// Name of the `Target`. Format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. Whether or not the `Target` requires approval.
    /// </summary>
    public TerraformValue<bool>? RequireApproval
    {
        get => GetArgument<TerraformValue<bool>>("require_approval");
        set => SetArgument("require_approval", value);
    }

    /// <summary>
    /// Output only. Time at which the `Target` was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// Output only. Resource id of the `Target`.
    /// </summary>
    public TerraformValue<string> TargetId
        => CreateReference("target_id");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Output only. Unique identifier of the `Target`.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// Output only. Most recent time at which the `Target` was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// AnthosCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnthosCluster block(s) allowed")]
    public TerraformList<GoogleClouddeployTargetAnthosClusterBlock>? AnthosCluster
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetAnthosClusterBlock>>("anthos_cluster");
        set => SetArgument("anthos_cluster", value);
    }

    /// <summary>
    /// AssociatedEntities block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleClouddeployTargetAssociatedEntitiesBlock>? AssociatedEntities
    {
        get => GetArgument<TerraformSet<GoogleClouddeployTargetAssociatedEntitiesBlock>>("associated_entities");
        set => SetArgument("associated_entities", value);
    }

    /// <summary>
    /// CustomTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomTarget block(s) allowed")]
    public TerraformList<GoogleClouddeployTargetCustomTargetBlock>? CustomTarget
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetCustomTargetBlock>>("custom_target");
        set => SetArgument("custom_target", value);
    }

    /// <summary>
    /// ExecutionConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployTargetExecutionConfigsBlock>? ExecutionConfigs
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetExecutionConfigsBlock>>("execution_configs");
        set => SetArgument("execution_configs", value);
    }

    /// <summary>
    /// Gke block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gke block(s) allowed")]
    public TerraformList<GoogleClouddeployTargetGkeBlock>? Gke
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetGkeBlock>>("gke");
        set => SetArgument("gke", value);
    }

    /// <summary>
    /// MultiTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTarget block(s) allowed")]
    public TerraformList<GoogleClouddeployTargetMultiTargetBlock>? MultiTarget
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetMultiTargetBlock>>("multi_target");
        set => SetArgument("multi_target", value);
    }

    /// <summary>
    /// Run block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Run block(s) allowed")]
    public TerraformList<GoogleClouddeployTargetRunBlock>? Run
    {
        get => GetArgument<TerraformList<GoogleClouddeployTargetRunBlock>>("run");
        set => SetArgument("run", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleClouddeployTargetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleClouddeployTargetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
