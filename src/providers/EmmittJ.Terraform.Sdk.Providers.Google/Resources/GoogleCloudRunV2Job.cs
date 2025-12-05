using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in GoogleCloudRunV2Job.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobBinaryAuthorizationBlock : TerraformBlock
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
/// Block type for template in GoogleCloudRunV2Job.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter,
    /// or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or
    /// https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Specifies the maximum desired number of tasks the execution should run at given time. Must be &amp;lt;= taskCount. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.
    /// </summary>
    public TerraformValue<double> Parallelism
    {
        get => GetArgument<TerraformValue<double>>("parallelism") ?? CreateReference("parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
    /// </summary>
    public TerraformValue<double> TaskCount
    {
        get => GetArgument<TerraformValue<double>>("task_count") ?? CreateReference("task_count");
        set => SetArgument("task_count", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlock> Template
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

}

/// <summary>
/// Block type for template in GoogleCloudRunV2JobTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
    /// </summary>
    public TerraformValue<string>? EncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// The execution environment being used to host this Task. Possible values: [&amp;quot;EXECUTION_ENVIRONMENT_GEN1&amp;quot;, &amp;quot;EXECUTION_ENVIRONMENT_GEN2&amp;quot;]
    /// </summary>
    public TerraformValue<string> ExecutionEnvironment
    {
        get => GetArgument<TerraformValue<string>>("execution_environment") ?? CreateReference("execution_environment");
        set => SetArgument("execution_environment", value);
    }

    /// <summary>
    /// True if GPU zonal redundancy is disabled on this execution.
    /// </summary>
    public TerraformValue<bool>? GpuZonalRedundancyDisabled
    {
        get => GetArgument<TerraformValue<bool>>("gpu_zonal_redundancy_disabled");
        set => SetArgument("gpu_zonal_redundancy_disabled", value);
    }

    /// <summary>
    /// Number of retries allowed per Task, before marking this Task failed. Defaults to 3. Minimum value is 0.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => GetArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// Email address of the IAM service account associated with the Task of a Job. The service account represents the identity of the running task, and determines what permissions the task has. If not provided, the task will use the project&#39;s default service account.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? CreateReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Max allowed time duration the Task may be active before the system will actively try to mark it failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full timeout.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout") ?? CreateReference("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Containers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock>? Containers
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock>>("containers");
        set => SetArgument("containers", value);
    }

    /// <summary>
    /// NodeSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeSelector block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockNodeSelectorBlock>? NodeSelector
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockNodeSelectorBlock>>("node_selector");
        set => SetArgument("node_selector", value);
    }

    /// <summary>
    /// Volumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock>? Volumes
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock>>("volumes");
        set => SetArgument("volumes", value);
    }

    /// <summary>
    /// VpcAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccess block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlock>? VpcAccess
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlock>>("vpc_access");
        set => SetArgument("vpc_access", value);
    }

}

/// <summary>
/// Block type for containers in GoogleCloudRunV2JobTemplateBlockTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("image");
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
    public TerraformSet<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// Ports block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockPortsBlock>? Ports
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockPortsBlock>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartupProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock.
/// Nesting mode: set
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// Name of the environment variable. Must be a C_IDENTIFIER, and mnay not exceed 32768 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlock>? ValueSource
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlock>>("value_source");
        set => SetArgument("value_source", value);
    }

}

/// <summary>
/// Block type for value_source in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_source";

    /// <summary>
    /// SecretKeyRef block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretKeyRef block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock>? SecretKeyRef
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock>>("secret_key_ref");
        set => SetArgument("secret_key_ref", value);
    }

}

/// <summary>
/// Block type for secret_key_ref in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockEnvBlockValueSourceBlockSecretKeyRefBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest value or an integer for a specific version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for ports in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockPortsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// If specified, used to specify which protocol to use. Allowed values are &amp;quot;http1&amp;quot; and &amp;quot;h2c&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for resources in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Only memory, CPU, and nvidia.com/gpu are supported. Use key &#39;cpu&#39; for CPU limit, &#39;memory&#39; for memory limit, &#39;nvidia.com/gpu&#39; for gpu limit. Note: The only supported values for CPU are &#39;1&#39;, &#39;2&#39;, &#39;4&#39;, &#39;6&#39;, and &#39;8&#39;. Setting 4 CPU requires at least 2Gi of memory, setting 6 or more CPU requires at least 4Gi of memory. The values of the map is string form of the &#39;quantity&#39; k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    public TerraformMap<string> Limits
    {
        get => GetArgument<TerraformMap<string>>("limits") ?? CreateReference("limits");
        set => SetArgument("limits", value);
    }

}

/// <summary>
/// Block type for startup_probe in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "startup_probe";

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
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
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockGrpcBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Path to access on the HTTP server. If set, it should not be empty string.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockStartupProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for volume_mounts in GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockContainersBlockVolumeMountsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for node_selector in GoogleCloudRunV2JobTemplateBlockTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockNodeSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_selector";

    /// <summary>
    /// The GPU to attach to an instance. See https://cloud.google.com/run/docs/configuring/jobs/gpu for configuring GPU.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Accelerator is required")]
    public required TerraformValue<string> Accelerator
    {
        get => GetRequiredArgument<TerraformValue<string>>("accelerator");
        set => SetArgument("accelerator", value);
    }

}

/// <summary>
/// Block type for volumes in GoogleCloudRunV2JobTemplateBlockTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// CloudSqlInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSqlInstance block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockCloudSqlInstanceBlock>? CloudSqlInstance
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockCloudSqlInstanceBlock>>("cloud_sql_instance");
        set => SetArgument("cloud_sql_instance", value);
    }

    /// <summary>
    /// EmptyDir block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmptyDir block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockEmptyDirBlock>? EmptyDir
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockEmptyDirBlock>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Nfs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Nfs block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockNfsBlock>? Nfs
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secret block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for cloud_sql_instance in GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockCloudSqlInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_sql_instance";

    /// <summary>
    /// The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}
    /// </summary>
    public TerraformList<string>? Instances
    {
        get => GetArgument<TerraformList<string>>("instances");
        set => SetArgument("instances", value);
    }

}

/// <summary>
/// Block type for empty_dir in GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockEmptyDirBlock : TerraformBlock
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
/// Block type for gcs in GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Name of the cloud storage bucket to back the volume. The resource service account must have permission to access the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
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
    /// If true, mount this volume as read-only in all mounts. If false, mount this volume as read-write.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

}

/// <summary>
/// Block type for nfs in GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockNfsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs";

    /// <summary>
    /// Path that is exported by the NFS server.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// If true, mount this volume as read-only in all mounts.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// Hostname or IP address of the NFS server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

}

/// <summary>
/// Block type for secret in GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVolumesBlockSecretBlockItemsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest value or an integer for a specific version
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for vpc_access in GoogleCloudRunV2JobTemplateBlockTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlock : TerraformBlock
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
    public TerraformValue<string> Egress
    {
        get => GetArgument<TerraformValue<string>>("egress") ?? CreateReference("egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// NetworkInterfaces block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlockNetworkInterfacesBlock>? NetworkInterfaces
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlockNetworkInterfacesBlock>>("network_interfaces");
        set => SetArgument("network_interfaces", value);
    }

}

/// <summary>
/// Block type for network_interfaces in GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2JobTemplateBlockTemplateBlockVpcAccessBlockNetworkInterfacesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("network") ?? CreateReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both
    /// network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the
    /// subnetwork with the same name with the network will be used.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork") ?? CreateReference("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// Network tags applied to this Cloud Run job.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudRunV2Job.
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunV2JobTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloud_run_v2_job Terraform resource.
/// Manages a google_cloud_run_v2_job resource.
/// </summary>
public partial class GoogleCloudRunV2Job(string name) : TerraformResource("google_cloud_run_v2_job", name)
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected on new resources.
    /// All system annotations in v1 now have a corresponding field in v2 Job.
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
    /// Whether Terraform will be prevented from destroying the job. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the job,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the job will fail.
    /// When the field is set to false, deleting the job is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
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
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 Job.
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
    public TerraformValue<string> LaunchStage
    {
        get => GetArgument<TerraformValue<string>>("launch_stage") ?? CreateReference("launch_stage");
        set => SetArgument("launch_stage", value);
    }

    /// <summary>
    /// The location of the cloud run job
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the Job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Job does not reach its desired state. See comments in reconciling for additional information on &#39;reconciliation&#39; process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> Conditions
        => CreateReference("conditions");

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    public TerraformValue<string> Creator
        => CreateReference("creator");

    /// <summary>
    /// The deletion time.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => CreateReference("delete_time");

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
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// Number of executions created for this job.
    /// </summary>
    public TerraformValue<double> ExecutionCount
        => CreateReference("execution_count");

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => CreateReference("expire_time");

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state.
    /// </summary>
    public TerraformValue<string> Generation
        => CreateReference("generation");

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    public TerraformValue<string> LastModifier
        => CreateReference("last_modifier");

    /// <summary>
    /// Name of the last created execution.
    /// </summary>
    public TerraformList<TerraformMap<object>> LatestCreatedExecution
        => CreateReference("latest_created_execution");

    /// <summary>
    /// The generation of this Job. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> ObservedGeneration
        => CreateReference("observed_generation");

    /// <summary>
    /// Returns true if the Job is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new Job is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Job to the desired state. This process is called reconciliation. While reconciliation is in process, observedGeneration and latest_succeeded_execution, will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the state matches the Job, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: observedGeneration and generation, latest_succeeded_execution and latestCreatedExecution.
    /// 
    /// If reconciliation failed, observedGeneration and latest_succeeded_execution will have the state of the last succeeded execution or empty for newly created Job. Additional information on the failure can be found in terminalCondition and conditions
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// The Condition of this Job, containing its readiness status, and detailed error information in case it did not reach the desired state
    /// </summary>
    public TerraformList<TerraformMap<object>> TerminalCondition
        => CreateReference("terminal_condition");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleCloudRunV2JobBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleCloudRunV2JobBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required TerraformList<GoogleCloudRunV2JobTemplateBlock> Template
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudRunV2JobTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudRunV2JobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudRunV2JobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
