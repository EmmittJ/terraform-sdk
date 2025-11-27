using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in GoogleCloudRunV2Service.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceBinaryAuthorizationBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "breakglass_justification");
        set => SetArgument("breakglass_justification", value);
    }

    /// <summary>
    /// The path to a binary authorization policy. Format: projects/{project}/platforms/cloudRun/{policy-name}
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// If True, indicates to use the default project&#39;s binary authorization policy. If False, binary authorization will be disabled.
    /// </summary>
    public TerraformValue<bool>? UseDefault
    {
        get => new TerraformReference<bool>(this, "use_default");
        set => SetArgument("use_default", value);
    }

}


/// <summary>
/// Block type for build_config in GoogleCloudRunV2Service.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceBuildConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "build_config";

    /// <summary>
    /// The base image used to build the function.
    /// </summary>
    public TerraformValue<string>? BaseImage
    {
        get => new TerraformReference<string>(this, "base_image");
        set => SetArgument("base_image", value);
    }

    /// <summary>
    /// Sets whether the function will receive automatic base image updates.
    /// </summary>
    public TerraformValue<bool>? EnableAutomaticUpdates
    {
        get => new TerraformReference<bool>(this, "enable_automatic_updates");
        set => SetArgument("enable_automatic_updates", value);
    }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed. Defaults to the resource name suffix, if not specified. For backward compatibility, if function with given name is not found, then the system will try to use function named &amp;quot;function&amp;quot;.
    /// </summary>
    public TerraformValue<string>? FunctionTarget
    {
        get => new TerraformReference<string>(this, "function_target");
        set => SetArgument("function_target", value);
    }

    /// <summary>
    /// Artifact Registry URI to store the built image.
    /// </summary>
    public TerraformValue<string>? ImageUri
    {
        get => new TerraformReference<string>(this, "image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The Cloud Build name of the latest successful deployment of the function.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Service account to be used for building the container. The format of this field is &#39;projects/{projectId}/serviceAccounts/{serviceAccountEmail}&#39;.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// The Cloud Storage bucket URI where the function source code is located.
    /// </summary>
    public TerraformValue<string>? SourceLocation
    {
        get => new TerraformReference<string>(this, "source_location");
        set => SetArgument("source_location", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the Cloud Run function. The format of this field is &#39;projects/{project}/locations/{region}/workerPools/{workerPool}&#39; where {project} and {region} are the project id and region respectively where the worker pool is defined and {workerPool} is the short name of the worker pool.
    /// </summary>
    public TerraformValue<string>? WorkerPool
    {
        get => new TerraformReference<string>(this, "worker_pool");
        set => SetArgument("worker_pool", value);
    }

}


/// <summary>
/// Block type for multi_region_settings in GoogleCloudRunV2Service.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceMultiRegionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_region_settings";

    /// <summary>
    /// System-generated unique id for the multi-region Service.
    /// </summary>
    public TerraformValue<string> MultiRegionId
    {
        get => new TerraformReference<string>(this, "multi_region_id");
    }

    /// <summary>
    /// The list of regions to deploy the multi-region Service.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

}


/// <summary>
/// Block type for scaling in GoogleCloudRunV2Service.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling";

    /// <summary>
    /// Total instance count for the service in manual scaling mode. This number of instances is divided among all revisions with specified traffic based on the percent of traffic they are receiving.
    /// </summary>
    public TerraformValue<double>? ManualInstanceCount
    {
        get => new TerraformReference<double>(this, "manual_instance_count");
        set => SetArgument("manual_instance_count", value);
    }

    /// <summary>
    /// Combined maximum number of instances for all revisions receiving traffic.
    /// </summary>
    public TerraformValue<double>? MaxInstanceCount
    {
        get => new TerraformReference<double>(this, "max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// Minimum number of instances for the service, to be divided among all revisions receiving traffic.
    /// </summary>
    public TerraformValue<double>? MinInstanceCount
    {
        get => new TerraformReference<double>(this, "min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

    /// <summary>
    /// The [scaling mode](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services#scalingmode) for the service. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ScalingMode
    {
        get => new TerraformReference<string>(this, "scaling_mode");
        set => SetArgument("scaling_mode", value);
    }

}


/// <summary>
/// Block type for template in GoogleCloudRunV2Service.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system annotations in v1 now have a corresponding field in v2 RevisionTemplate.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
    /// </summary>
    public TerraformValue<string>? EncryptionKey
    {
        get => new TerraformReference<string>(this, "encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// The sandbox environment to host this Revision. Possible values: [&amp;quot;EXECUTION_ENVIRONMENT_GEN1&amp;quot;, &amp;quot;EXECUTION_ENVIRONMENT_GEN2&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ExecutionEnvironment
    {
        get => new TerraformReference<string>(this, "execution_environment");
        set => SetArgument("execution_environment", value);
    }

    /// <summary>
    /// True if GPU zonal redundancy is disabled on this revision.
    /// </summary>
    public TerraformValue<bool>? GpuZonalRedundancyDisabled
    {
        get => new TerraformReference<bool>(this, "gpu_zonal_redundancy_disabled");
        set => SetArgument("gpu_zonal_redundancy_disabled", value);
    }

    /// <summary>
    /// Disables health checking containers during deployment.
    /// </summary>
    public TerraformValue<bool>? HealthCheckDisabled
    {
        get => new TerraformReference<bool>(this, "health_check_disabled");
        set => SetArgument("health_check_disabled", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc.
    /// For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 RevisionTemplate.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Sets the maximum number of requests that each serving instance can receive.
    /// If not specified or 0, defaults to 80 when requested CPU &amp;gt;= 1 and defaults to 1 when requested CPU &amp;lt; 1.
    /// </summary>
    public TerraformValue<double> MaxInstanceRequestConcurrency
    {
        get => new TerraformReference<double>(this, "max_instance_request_concurrency");
        set => SetArgument("max_instance_request_concurrency", value);
    }

    /// <summary>
    /// The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.
    /// </summary>
    public TerraformValue<string>? Revision
    {
        get => new TerraformReference<string>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project&#39;s default service account.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity
    /// </summary>
    public TerraformValue<bool>? SessionAffinity
    {
        get => new TerraformReference<bool>(this, "session_affinity");
        set => SetArgument("session_affinity", value);
    }

    /// <summary>
    /// Max allowed time for an instance to respond to a request.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Containers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlock>? Containers
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlock>>("containers");
        set => SetArgument("containers", value);
    }

    /// <summary>
    /// NodeSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeSelector block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockNodeSelectorBlock>? NodeSelector
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockNodeSelectorBlock>>("node_selector");
        set => SetArgument("node_selector", value);
    }

    /// <summary>
    /// Scaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaling block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockScalingBlock>? Scaling
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockScalingBlock>>("scaling");
        set => SetArgument("scaling", value);
    }

    /// <summary>
    /// Volumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlock>? Volumes
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlock>>("volumes");
        set => SetArgument("volumes", value);
    }

    /// <summary>
    /// VpcAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccess block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlock>? VpcAccess
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlock>>("vpc_access");
        set => SetArgument("vpc_access", value);
    }

}

/// <summary>
/// Block type for containers in GoogleCloudRunV2ServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "args").ResolveNodes(ctx));
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Base image for this container. If set, it indicates that the service is enrolled into automatic base image update.
    /// </summary>
    public TerraformValue<string>? BaseImageUri
    {
        get => new TerraformReference<string>(this, "base_image_uri");
        set => SetArgument("base_image_uri", value);
    }

    /// <summary>
    /// The build info of the container image.
    /// </summary>
    public TerraformList<TerraformMap<object>> BuildInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "build_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// Entrypoint array. Not executed within a shell. The docker image&#39;s ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
    /// </summary>
    public TerraformList<string>? Command
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "command").ResolveNodes(ctx));
        set => SetArgument("command", value);
    }

    /// <summary>
    /// Containers which should be started before this container. If specified the container will wait to start until all containers with the listed names are healthy.
    /// </summary>
    public TerraformList<string>? DependsOnAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "depends_on").ResolveNodes(ctx));
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Name of the container specified as a DNS_LABEL.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Container&#39;s working directory. If not specified, the container runtime&#39;s default will be used, which might be configured in the container image.
    /// </summary>
    public TerraformValue<string>? WorkingDir
    {
        get => new TerraformReference<string>(this, "working_dir");
        set => SetArgument("working_dir", value);
    }

    /// <summary>
    /// Env block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// Ports block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ports block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockPortsBlock>? Ports
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockPortsBlock>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartupProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in GoogleCloudRunV2ServiceTemplateBlockContainersBlock.
/// Nesting mode: set
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Literal value of the environment variable. Defaults to &amp;quot;&amp;quot; and the maximum allowed length is 32768 characters. Variable references are not supported in Cloud Run.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// ValueSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValueSource block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlock>? ValueSource
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlock>>("value_source");
        set => SetArgument("value_source", value);
    }

}

/// <summary>
/// Block type for value_source in GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_source";

    /// <summary>
    /// SecretKeyRef block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretKeyRef block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock>? SecretKeyRef
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock>>("secret_key_ref");
        set => SetArgument("secret_key_ref", value);
    }

}

/// <summary>
/// Block type for secret_key_ref in GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest value or an integer for a specific version.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for liveness_probe in GoogleCloudRunV2ServiceTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_probe";

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => new TerraformReference<double>(this, "failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => new TerraformReference<double>(this, "initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => new TerraformReference<double>(this, "period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => new TerraformReference<double>(this, "timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Path to access on the HTTP server. Defaults to &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockLivenessProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Port number to access on the container. Must be in the range 1 to 65535.
    /// If not specified, defaults to the exposed port of the container, which
    /// is the value of container.ports[0].containerPort.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for ports in GoogleCloudRunV2ServiceTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ports";

    /// <summary>
    /// Port number the container listens on. This must be a valid TCP port number, 0 &amp;lt; containerPort &amp;lt; 65536.
    /// </summary>
    public TerraformValue<double>? ContainerPort
    {
        get => new TerraformReference<double>(this, "container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// If specified, used to specify which protocol to use. Allowed values are &amp;quot;http1&amp;quot; and &amp;quot;h2c&amp;quot;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for resources in GoogleCloudRunV2ServiceTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Determines whether CPU is only allocated during requests. True by default if the parent &#39;resources&#39; field is not set. However, if
    /// &#39;resources&#39; is set, this field must be explicitly set to true to preserve the default behavior.
    /// </summary>
    public TerraformValue<bool>? CpuIdle
    {
        get => new TerraformReference<bool>(this, "cpu_idle");
        set => SetArgument("cpu_idle", value);
    }

    /// <summary>
    /// Only memory, CPU, and nvidia.com/gpu are supported. Use key &#39;cpu&#39; for CPU limit, &#39;memory&#39; for memory limit, &#39;nvidia.com/gpu&#39; for gpu limit. Note: The only supported values for CPU are &#39;1&#39;, &#39;2&#39;, &#39;4&#39;, &#39;6&#39; and &#39;8&#39;. Setting 4 CPU requires at least 2Gi of memory, setting 6 or more CPU requires at least 4Gi of memory. The values of the map is string form of the &#39;quantity&#39; k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    public TerraformMap<string> Limits
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "limits").ResolveNodes(ctx));
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// Determines whether CPU should be boosted on startup of a new container instance above the requested CPU threshold, this can help reduce cold-start latency.
    /// </summary>
    public TerraformValue<bool>? StartupCpuBoost
    {
        get => new TerraformReference<bool>(this, "startup_cpu_boost");
        set => SetArgument("startup_cpu_boost", value);
    }

}

/// <summary>
/// Block type for startup_probe in GoogleCloudRunV2ServiceTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "startup_probe";

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => new TerraformReference<double>(this, "failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => new TerraformReference<double>(this, "initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => new TerraformReference<double>(this, "period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => new TerraformReference<double>(this, "timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Path to access on the HTTP server. Defaults to &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Port number to access on the container. Must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Port number to access on the container. Must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for volume_mounts in GoogleCloudRunV2ServiceTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockContainersBlockVolumeMountsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Path within the volume from which the container&#39;s volume should be mounted.
    /// </summary>
    public TerraformValue<string>? SubPath
    {
        get => new TerraformReference<string>(this, "sub_path");
        set => SetArgument("sub_path", value);
    }

}

/// <summary>
/// Block type for node_selector in GoogleCloudRunV2ServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockNodeSelectorBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "accelerator");
        set => SetArgument("accelerator", value);
    }

}

/// <summary>
/// Block type for scaling in GoogleCloudRunV2ServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling";

    /// <summary>
    /// Maximum number of serving instances that this resource should have. Must not be less than minimum instance count. If absent, Cloud Run will calculate
    /// a default value based on the project&#39;s available container instances quota in the region and specified instance size.
    /// </summary>
    public TerraformValue<double>? MaxInstanceCount
    {
        get => new TerraformReference<double>(this, "max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// Minimum number of serving instances that this resource should have. Defaults to 0. Must not be greater than maximum instance count.
    /// </summary>
    public TerraformValue<double>? MinInstanceCount
    {
        get => new TerraformReference<double>(this, "min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

}

/// <summary>
/// Block type for volumes in GoogleCloudRunV2ServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// CloudSqlInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSqlInstance block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockCloudSqlInstanceBlock>? CloudSqlInstance
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockCloudSqlInstanceBlock>>("cloud_sql_instance");
        set => SetArgument("cloud_sql_instance", value);
    }

    /// <summary>
    /// EmptyDir block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmptyDir block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockEmptyDirBlock>? EmptyDir
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockEmptyDirBlock>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Nfs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Nfs block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockNfsBlock>? Nfs
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secret block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for cloud_sql_instance in GoogleCloudRunV2ServiceTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlockCloudSqlInstanceBlock : TerraformBlock
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "instances").ResolveNodes(ctx));
        set => SetArgument("instances", value);
    }

}

/// <summary>
/// Block type for empty_dir in GoogleCloudRunV2ServiceTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlockEmptyDirBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "medium");
        set => SetArgument("medium", value);
    }

    /// <summary>
    /// Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field&#39;s values are of the &#39;Quantity&#39; k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.
    /// </summary>
    public TerraformValue<string>? SizeLimit
    {
        get => new TerraformReference<string>(this, "size_limit");
        set => SetArgument("size_limit", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleCloudRunV2ServiceTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlockGcsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// A list of flags to pass to the gcsfuse command for configuring this volume.
    /// Flags should be passed without leading dashes.
    /// </summary>
    public TerraformList<string>? MountOptions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mount_options").ResolveNodes(ctx));
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// If true, mount the GCS bucket as read-only
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => new TerraformReference<bool>(this, "read_only");
        set => SetArgument("read_only", value);
    }

}

/// <summary>
/// Block type for nfs in GoogleCloudRunV2ServiceTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlockNfsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// If true, mount the NFS volume as read only
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => new TerraformReference<bool>(this, "read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// Hostname or IP address of the NFS server
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

}

/// <summary>
/// Block type for secret in GoogleCloudRunV2ServiceTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "default_mode");
        set => SetArgument("default_mode", value);
    }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVolumesBlockSecretBlockItemsBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The relative path of the secret in the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest value or an integer for a specific version
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for vpc_access in GoogleCloudRunV2ServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "connector");
        set => SetArgument("connector", value);
    }

    /// <summary>
    /// Traffic VPC egress settings. Possible values: [&amp;quot;ALL_TRAFFIC&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string> Egress
    {
        get => new TerraformReference<string>(this, "egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// NetworkInterfaces block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlockNetworkInterfacesBlock>? NetworkInterfaces
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlockNetworkInterfacesBlock>>("network_interfaces");
        set => SetArgument("network_interfaces", value);
    }

}

/// <summary>
/// Block type for network_interfaces in GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlockVpcAccessBlockNetworkInterfacesBlock : TerraformBlock
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
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both
    /// network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the
    /// subnetwork with the same name with the network will be used.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// Network tags applied to this Cloud Run service.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudRunV2Service.
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunV2ServiceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for traffic in GoogleCloudRunV2Service.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTrafficBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic";

    /// <summary>
    /// Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.
    /// </summary>
    public TerraformValue<double> Percent
    {
        get => new TerraformReference<double>(this, "percent");
        set => SetArgument("percent", value);
    }

    /// <summary>
    /// Revision to which to send this portion of traffic, if traffic allocation is by revision.
    /// </summary>
    public TerraformValue<string>? Revision
    {
        get => new TerraformReference<string>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// Indicates a string to be part of the URI to exclusively reference this target.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The allocation type for this traffic target. Possible values: [&amp;quot;TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST&amp;quot;, &amp;quot;TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a google_cloud_run_v2_service Terraform resource.
/// Manages a google_cloud_run_v2_service resource.
/// </summary>
public partial class GoogleCloudRunV2Service(string name) : TerraformResource("google_cloud_run_v2_service", name)
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected in new resources.
    /// All system annotations in v1 now have a corresponding field in v2 Service.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Arbitrary identifier for the API client.
    /// </summary>
    public TerraformValue<string>? Client
    {
        get => new TerraformReference<string>(this, "client");
        set => SetArgument("client", value);
    }

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    public TerraformValue<string>? ClientVersion
    {
        get => new TerraformReference<string>(this, "client_version");
        set => SetArgument("client_version", value);
    }

    /// <summary>
    /// One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests.
    /// For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
    /// </summary>
    public TerraformList<string>? CustomAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_audiences").ResolveNodes(ctx));
        set => SetArgument("custom_audiences", value);
    }

    /// <summary>
    /// Disables public resolution of the default URI of this service.
    /// </summary>
    public TerraformValue<bool>? DefaultUriDisabled
    {
        get => new TerraformReference<bool>(this, "default_uri_disabled");
        set => SetArgument("default_uri_disabled", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the service. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the service,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the service will fail.
    /// When the field is set to false, deleting the service is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// User-provided description of the Service. This field currently has a 512-character limit.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values: [&amp;quot;INGRESS_TRAFFIC_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER&amp;quot;]
    /// </summary>
    public TerraformValue<string> Ingress
    {
        get => new TerraformReference<string>(this, "ingress");
        set => SetArgument("ingress", value);
    }

    /// <summary>
    /// Disables IAM permission check for run.routes.invoke for callers of this service. For more information, visit https://cloud.google.com/run/docs/securing/managing-access#invoker_check.
    /// </summary>
    public TerraformValue<bool>? InvokerIamDisabled
    {
        get => new TerraformReference<bool>(this, "invoker_iam_disabled");
        set => SetArgument("invoker_iam_disabled", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with  &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 Service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public TerraformValue<string> LaunchStage
    {
        get => new TerraformReference<string>(this, "launch_stage");
        set => SetArgument("launch_stage", value);
    }

    /// <summary>
    /// The location of the cloud run service
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> Conditions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "conditions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    public TerraformValue<string> Creator
    {
        get => new TerraformReference<string>(this, "creator");
    }

    /// <summary>
    /// The deletion time.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    public TerraformValue<string> ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
    }

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformValue<string> Generation
    {
        get => new TerraformReference<string>(this, "generation");
    }

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    public TerraformValue<string> LastModifier
    {
        get => new TerraformReference<string>(this, "last_modifier");
    }

    /// <summary>
    /// Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> LatestCreatedRevision
    {
        get => new TerraformReference<string>(this, "latest_created_revision");
    }

    /// <summary>
    /// Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> LatestReadyRevision
    {
        get => new TerraformReference<string>(this, "latest_ready_revision");
    }

    /// <summary>
    /// The generation of this Service currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformValue<string> ObservedGeneration
    {
        get => new TerraformReference<string>(this, "observed_generation");
    }

    /// <summary>
    /// Returns true if the Service is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.
    /// 
    /// If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in terminalCondition and conditions.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> TerminalCondition
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "terminal_condition").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Detailed status information for corresponding traffic targets. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrafficStatuses
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "traffic_statuses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// The main URI in which this Service is serving traffic.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

    /// <summary>
    /// All URLs serving traffic for this Service.
    /// </summary>
    public TerraformList<string> Urls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "urls").ResolveNodes(ctx));
    }

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// BuildConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceBuildConfigBlock>? BuildConfig
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceBuildConfigBlock>>("build_config");
        set => SetArgument("build_config", value);
    }

    /// <summary>
    /// MultiRegionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiRegionSettings block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceMultiRegionSettingsBlock>? MultiRegionSettings
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceMultiRegionSettingsBlock>>("multi_region_settings");
        set => SetArgument("multi_region_settings", value);
    }

    /// <summary>
    /// Scaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaling block(s) allowed")]
    public TerraformList<GoogleCloudRunV2ServiceScalingBlock>? Scaling
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceScalingBlock>>("scaling");
        set => SetArgument("scaling", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required TerraformList<GoogleCloudRunV2ServiceTemplateBlock> Template
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudRunV2ServiceTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudRunV2ServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudRunV2ServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Traffic block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2ServiceTrafficBlock>? Traffic
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2ServiceTrafficBlock>>("traffic");
        set => SetArgument("traffic", value);
    }

}
