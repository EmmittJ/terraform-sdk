using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in GoogleCloudRunV2WorkerPool.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_authorization";

    /// <summary>
    /// If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass
    /// </summary>
    public TerraformValue<string>? BreakglassJustification
    {
        get => GetArgument<TerraformValue<string>>("breakglass_justification");
        set => SetArgument("breakglass_justification", value);
    }

    /// <summary>
    /// The path to a binary authorization policy. Format: projects/{project}/platforms/cloudRun/{policy-name}
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// If True, indicates to use the default project&#39;s binary authorization policy. If False, binary authorization will be disabled.
    /// </summary>
    public TerraformValue<bool>? UseDefault
    {
        get => GetArgument<TerraformValue<bool>>("use_default");
        set => SetArgument("use_default", value);
    }

}


/// <summary>
/// Block type for instance_splits in GoogleCloudRunV2WorkerPool.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolInstanceSplitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_splits";

    /// <summary>
    /// Specifies percent of the instance split to this Revision. This defaults to zero if unspecified.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

    /// <summary>
    /// Revision to which to assign this portion of instances, if split allocation is by revision.
    /// </summary>
    public TerraformValue<string>? Revision
    {
        get => GetArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The allocation type for this instance split. Possible values: [&amp;quot;INSTANCE_SPLIT_ALLOCATION_TYPE_LATEST&amp;quot;, &amp;quot;INSTANCE_SPLIT_ALLOCATION_TYPE_REVISION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for scaling in GoogleCloudRunV2WorkerPool.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling";

    /// <summary>
    /// The total number of instances in manual scaling mode.
    /// </summary>
    public TerraformValue<double>? ManualInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("manual_instance_count");
        set => SetArgument("manual_instance_count", value);
    }

    /// <summary>
    /// The maximum count of instances distributed among revisions based on the specified instance split percentages.
    /// </summary>
    public TerraformValue<double>? MaxInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// The minimum count of instances distributed among revisions based on the specified instance split percentages.
    /// </summary>
    public TerraformValue<double>? MinInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

    /// <summary>
    /// The scaling mode for the worker pool. It defaults to MANUAL. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ScalingMode
    {
        get => GetArgument<TerraformValue<string>>("scaling_mode");
        set => SetArgument("scaling_mode", value);
    }

}


/// <summary>
/// Block type for template in GoogleCloudRunV2WorkerPool.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system annotations in v1 now have a corresponding field in v2 WorkerPoolRevisionTemplate.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
    /// </summary>
    public TerraformValue<string>? EncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// The action to take if the encryption key is revoked. Possible values: [&amp;quot;PREVENT_NEW&amp;quot;, &amp;quot;SHUTDOWN&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EncryptionKeyRevocationAction
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_revocation_action");
        set => SetArgument("encryption_key_revocation_action", value);
    }

    /// <summary>
    /// If encryptionKeyRevocationAction is SHUTDOWN, the duration before shutting down all instances. The minimum increment is 1 hour.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? EncryptionKeyShutdownDuration
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_shutdown_duration");
        set => SetArgument("encryption_key_shutdown_duration", value);
    }

    /// <summary>
    /// True if GPU zonal redundancy is disabled on this revision.
    /// </summary>
    public TerraformValue<bool>? GpuZonalRedundancyDisabled
    {
        get => GetArgument<TerraformValue<bool>>("gpu_zonal_redundancy_disabled");
        set => SetArgument("gpu_zonal_redundancy_disabled", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc.
    /// For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 WorkerPoolRevisionTemplate.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The unique name for the revision. If this field is omitted, it will be automatically generated based on the WorkerPool name.
    /// </summary>
    public TerraformValue<string>? Revision
    {
        get => GetArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the WorkerPool. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project&#39;s default service account.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Containers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock>? Containers
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock>>("containers");
        set => SetArgument("containers", value);
    }

    /// <summary>
    /// NodeSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeSelector block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockNodeSelectorBlock>? NodeSelector
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockNodeSelectorBlock>>("node_selector");
        set => SetArgument("node_selector", value);
    }

    /// <summary>
    /// Volumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock>? Volumes
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock>>("volumes");
        set => SetArgument("volumes", value);
    }

    /// <summary>
    /// VpcAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccess block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlock>? VpcAccess
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlock>>("vpc_access");
        set => SetArgument("vpc_access", value);
    }

}

/// <summary>
/// Block type for containers in GoogleCloudRunV2WorkerPoolTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containers";

    /// <summary>
    /// Arguments to the entrypoint. The docker image&#39;s CMD is used if this is not provided. Variable references are not supported in Cloud Run.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Entrypoint array. Not executed within a shell. The docker image&#39;s ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// Names of the containers that must start before this container.
    /// </summary>
    public TerraformList<string>? DependsOnAttribute
    {
        get => GetArgument<TerraformList<string>>("depends_on");
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Name of the container specified as a DNS_LABEL.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Container&#39;s working directory. If not specified, the container runtime&#39;s default will be used, which might be configured in the container image.
    /// </summary>
    public TerraformValue<string>? WorkingDir
    {
        get => GetArgument<TerraformValue<string>>("working_dir");
        set => SetArgument("working_dir", value);
    }

    /// <summary>
    /// Env block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartupProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock.
/// Nesting mode: set
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// Name of the environment variable. Must be a C_IDENTIFIER, and may not exceed 32768 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Literal value of the environment variable. Defaults to &amp;quot;&amp;quot; and the maximum allowed length is 32768 characters. Variable references are not supported in Cloud Run.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// ValueSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValueSource block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlock>? ValueSource
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlock>>("value_source");
        set => SetArgument("value_source", value);
    }

}

/// <summary>
/// Block type for value_source in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_source";

    /// <summary>
    /// SecretKeyRef block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretKeyRef block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock>? SecretKeyRef
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock>>("secret_key_ref");
        set => SetArgument("secret_key_ref", value);
    }

}

/// <summary>
/// Block type for secret_key_ref in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_key_ref";

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. Format: {secretName} if the secret is in the same project. projects/{project}/secrets/{secretName} if the secret is in a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest value or an integer for a specific version.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for liveness_probe in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_probe";

    /// <summary>
    /// Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeout_seconds.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than period_seconds.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Optional. Port number of the gRPC service. Number must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Optional. Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md ). If this is not specified, the default behavior is defined by gRPC
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Optional. Path to access on the HTTP server. Defaults to &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHeaders block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// Required. The header field name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Optional. The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockLivenessProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for resources in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Only memory, CPU, and nvidia.com/gpu are supported. Use key &#39;cpu&#39; for CPU limit, &#39;memory&#39; for memory limit, &#39;nvidia.com/gpu&#39; for gpu limit. Note: The only supported values for CPU are &#39;1&#39;, &#39;2&#39;, &#39;4&#39;, &#39;6&#39;, and &#39;8&#39;. Setting 4 CPU requires at least 2Gi of memory, setting 6 or more CPU requires at least 4Gi of memory. The values of the map is string form of the &#39;quantity&#39; k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    public TerraformMap<string>? Limits
    {
        get => GetArgument<TerraformMap<string>>("limits");
        set => SetArgument("limits", value);
    }

}

/// <summary>
/// Block type for startup_probe in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "startup_probe";

    /// <summary>
    /// Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeout_seconds.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than period_seconds.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Optional. Port number of the gRPC service. Number must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Optional. Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md ). If this is not specified, the default behavior is defined by gRPC
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Optional. Path to access on the HTTP server. Defaults to &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHeaders block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// Required. The header field name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Optional. The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for volume_mounts in GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockContainersBlockVolumeMountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_mounts";

    /// <summary>
    /// Path within the container at which the volume should be mounted. Must not contain &#39;:&#39;. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Path within the volume from which the container&#39;s volume should be mounted.
    /// </summary>
    public TerraformValue<string>? SubPath
    {
        get => GetArgument<TerraformValue<string>>("sub_path");
        set => SetArgument("sub_path", value);
    }

}

/// <summary>
/// Block type for node_selector in GoogleCloudRunV2WorkerPoolTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockNodeSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_selector";

    /// <summary>
    /// The GPU to attach to an instance. See https://cloud.google.com/run/docs/configuring/services/gpu for configuring GPU.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Accelerator is required")]
    public required TerraformValue<string> Accelerator
    {
        get => GetArgument<TerraformValue<string>>("accelerator");
        set => SetArgument("accelerator", value);
    }

}

/// <summary>
/// Block type for volumes in GoogleCloudRunV2WorkerPoolTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volumes";

    /// <summary>
    /// Volume&#39;s name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// CloudSqlInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSqlInstance block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockCloudSqlInstanceBlock>? CloudSqlInstance
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockCloudSqlInstanceBlock>>("cloud_sql_instance");
        set => SetArgument("cloud_sql_instance", value);
    }

    /// <summary>
    /// EmptyDir block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmptyDir block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockEmptyDirBlock>? EmptyDir
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockEmptyDirBlock>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Nfs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Nfs block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockNfsBlock>? Nfs
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secret block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for cloud_sql_instance in GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockCloudSqlInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_sql_instance";

    /// <summary>
    /// The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}
    /// </summary>
    public TerraformSet<string>? Instances
    {
        get => GetArgument<TerraformSet<string>>("instances");
        set => SetArgument("instances", value);
    }

}

/// <summary>
/// Block type for empty_dir in GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockEmptyDirBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "empty_dir";

    /// <summary>
    /// The different types of medium supported for EmptyDir. Default value: &amp;quot;MEMORY&amp;quot; Possible values: [&amp;quot;MEMORY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Medium
    {
        get => GetArgument<TerraformValue<string>>("medium");
        set => SetArgument("medium", value);
    }

    /// <summary>
    /// Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field&#39;s values are of the &#39;Quantity&#39; k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.
    /// </summary>
    public TerraformValue<string>? SizeLimit
    {
        get => GetArgument<TerraformValue<string>>("size_limit");
        set => SetArgument("size_limit", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// GCS Bucket name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// A list of flags to pass to the gcsfuse command for configuring this volume.
    /// Flags should be passed without leading dashes.
    /// </summary>
    public TerraformList<string>? MountOptions
    {
        get => GetArgument<TerraformList<string>>("mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// If true, mount the GCS bucket as read-only
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

}

/// <summary>
/// Block type for nfs in GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockNfsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs";

    /// <summary>
    /// Path that is exported by the NFS server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// If true, mount the NFS volume as read only
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// Hostname or IP address of the NFS server
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

}

/// <summary>
/// Block type for secret in GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.
    /// </summary>
    public TerraformValue<double>? DefaultMode
    {
        get => GetArgument<TerraformValue<double>>("default_mode");
        set => SetArgument("default_mode", value);
    }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVolumesBlockSecretBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume&#39;s default mode will be used.
    /// </summary>
    public TerraformValue<double>? Mode
    {
        get => GetArgument<TerraformValue<double>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The relative path of the secret in the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest value or an integer for a specific version
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for vpc_access in GoogleCloudRunV2WorkerPoolTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_access";

    /// <summary>
    /// VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.
    /// </summary>
    public TerraformValue<string>? Connector
    {
        get => GetArgument<TerraformValue<string>>("connector");
        set => SetArgument("connector", value);
    }

    /// <summary>
    /// Traffic VPC egress settings. Possible values: [&amp;quot;ALL_TRAFFIC&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Egress
    {
        get => GetArgument<TerraformValue<string>>("egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// NetworkInterfaces block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlockNetworkInterfacesBlock>? NetworkInterfaces
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlockNetworkInterfacesBlock>>("network_interfaces");
        set => SetArgument("network_interfaces", value);
    }

}

/// <summary>
/// Block type for network_interfaces in GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2WorkerPoolTemplateBlockVpcAccessBlockNetworkInterfacesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interfaces";

    /// <summary>
    /// The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both
    /// network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be
    /// looked up from the subnetwork.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both
    /// network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the
    /// subnetwork with the same name with the network will be used.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// Network tags applied to this Cloud Run WorkerPool.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudRunV2WorkerPool.
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunV2WorkerPoolTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloud_run_v2_worker_pool Terraform resource.
/// Manages a google_cloud_run_v2_worker_pool resource.
/// </summary>
public partial class GoogleCloudRunV2WorkerPool(string name) : TerraformResource("google_cloud_run_v2_worker_pool", name)
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected in new resources.
    /// All system annotations in v1 now have a corresponding field in v2 WorkerPool.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
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
    /// Arbitrary identifier for the API client.
    /// </summary>
    public TerraformValue<string>? Client
    {
        get => GetArgument<TerraformValue<string>>("client");
        set => SetArgument("client", value);
    }

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    public TerraformValue<string>? ClientVersion
    {
        get => GetArgument<TerraformValue<string>>("client_version");
        set => SetArgument("client_version", value);
    }

    /// <summary>
    /// One or more custom audiences that you want this worker pool to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests.
    /// For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
    /// </summary>
    public TerraformList<string>? CustomAudiences
    {
        get => GetArgument<TerraformList<string>>("custom_audiences");
        set => SetArgument("custom_audiences", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the service. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the service,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the WorkerPool will fail.
    /// When the field is set to false, deleting the WorkerPool is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// User-provided description of the WorkerPool. This field currently has a 512-character limit.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with  &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 WorkerPool.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LaunchStage
    {
        get => GetArgument<TerraformValue<string>>("launch_stage");
        set => SetArgument("launch_stage", value);
    }

    /// <summary>
    /// The location of the cloud run worker pool
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the WorkerPool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the WorkerPool does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> Conditions
        => AsReference("conditions");

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    public TerraformValue<string> Creator
        => AsReference("creator");

    /// <summary>
    /// The deletion time.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => AsReference("expire_time");

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformValue<string> Generation
        => AsReference("generation");

    /// <summary>
    /// Detailed status information for corresponding instance splits. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceSplitStatuses
        => AsReference("instance_split_statuses");

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    public TerraformValue<string> LastModifier
        => AsReference("last_modifier");

    /// <summary>
    /// Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> LatestCreatedRevision
        => AsReference("latest_created_revision");

    /// <summary>
    /// Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> LatestReadyRevision
        => AsReference("latest_ready_revision");

    /// <summary>
    /// The generation of this WorkerPool currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformValue<string> ObservedGeneration
        => AsReference("observed_generation");

    /// <summary>
    /// Returns true if the WorkerPool is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new WorkerPool is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the WorkerPool to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the WorkerPool, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.
    /// 
    /// If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created WorkerPools. Additional information on the failure can be found in terminalCondition and conditions.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The Condition of this WorkerPool, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> TerminalCondition
        => AsReference("terminal_condition");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// InstanceSplits block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2WorkerPoolInstanceSplitsBlock>? InstanceSplits
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolInstanceSplitsBlock>>("instance_splits");
        set => SetArgument("instance_splits", value);
    }

    /// <summary>
    /// Scaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaling block(s) allowed")]
    public TerraformList<GoogleCloudRunV2WorkerPoolScalingBlock>? Scaling
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2WorkerPoolScalingBlock>>("scaling");
        set => SetArgument("scaling", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlock> Template
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudRunV2WorkerPoolTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudRunV2WorkerPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudRunV2WorkerPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
