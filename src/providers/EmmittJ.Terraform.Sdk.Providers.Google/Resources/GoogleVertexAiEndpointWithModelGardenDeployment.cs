using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for deploy_config in GoogleVertexAiEndpointWithModelGardenDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deploy_config";

    /// <summary>
    /// If true, enable the QMT fast tryout feature for this model if possible.
    /// </summary>
    public TerraformValue<bool>? FastTryoutEnabled
    {
        get => GetArgument<TerraformValue<bool>>("fast_tryout_enabled");
        set => SetArgument("fast_tryout_enabled", value);
    }

    /// <summary>
    /// System labels for Model Garden deployments.
    /// These labels are managed by Google and for tracking purposes only.
    /// </summary>
    public TerraformMap<string>? SystemLabels
    {
        get => GetArgument<TerraformMap<string>>("system_labels");
        set => SetArgument("system_labels", value);
    }

    /// <summary>
    /// DedicatedResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedResources block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlock>? DedicatedResources
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlock>>("dedicated_resources");
        set => SetArgument("dedicated_resources", value);
    }

}

/// <summary>
/// Block type for dedicated_resources in GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dedicated_resources";

    /// <summary>
    /// The maximum number of replicas that may be deployed on when the traffic
    /// against it increases. If the requested value is too large, the deployment
    /// will error, but if deployment succeeds then the ability to scale to that
    /// many replicas is guaranteed (barring service outages). If traffic increases
    /// beyond what its replicas at maximum may handle, a portion of the traffic
    /// will be dropped. If this value is not provided, will use
    /// min_replica_count as the default value.
    /// 
    /// The value of this field impacts the charge against Vertex CPU and GPU
    /// quotas. Specifically, you will be charged for (max_replica_count *
    /// number of cores in the selected machine type) and (max_replica_count *
    /// number of GPUs per replica in the selected machine type).
    /// </summary>
    public TerraformValue<double>? MaxReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("max_replica_count");
        set => SetArgument("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of machine replicas that will be always deployed on.
    /// This value must be greater than or equal to 1.
    /// 
    /// If traffic increases, it may dynamically be deployed onto more replicas,
    /// and as traffic decreases, some of these extra replicas may be freed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicaCount is required")]
    public required TerraformValue<double> MinReplicaCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_replica_count");
        set => SetArgument("min_replica_count", value);
    }

    /// <summary>
    /// Number of required available replicas for the deployment to succeed.
    /// This field is only needed when partial deployment/mutation is
    /// desired. If set, the deploy/mutate operation will succeed once
    /// available_replica_count reaches required_replica_count, and the rest of
    /// the replicas will be retried. If not set, the default
    /// required_replica_count will be min_replica_count.
    /// </summary>
    public TerraformValue<double>? RequiredReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("required_replica_count");
        set => SetArgument("required_replica_count", value);
    }

    /// <summary>
    /// If true, schedule the deployment workload on [spot
    /// VMs](https://cloud.google.com/kubernetes-engine/docs/concepts/spot-vms).
    /// </summary>
    public TerraformValue<bool>? Spot
    {
        get => GetArgument<TerraformValue<bool>>("spot");
        set => SetArgument("spot", value);
    }

    /// <summary>
    /// AutoscalingMetricSpecs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockAutoscalingMetricSpecsBlock>? AutoscalingMetricSpecs
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockAutoscalingMetricSpecsBlock>>("autoscaling_metric_specs");
        set => SetArgument("autoscaling_metric_specs", value);
    }

    /// <summary>
    /// MachineSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MachineSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    public required TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlock> MachineSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlock>>("machine_spec");
        set => SetArgument("machine_spec", value);
    }

}

/// <summary>
/// Block type for autoscaling_metric_specs in GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockAutoscalingMetricSpecsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_metric_specs";

    /// <summary>
    /// The resource metric name.
    /// Supported metrics:
    /// 
    /// * For Online Prediction:
    /// * &#39;aiplatform.googleapis.com/prediction/online/accelerator/duty_cycle&#39;
    /// * &#39;aiplatform.googleapis.com/prediction/online/cpu/utilization&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The target resource utilization in percentage (1% - 100%) for the given
    /// metric; once the real usage deviates from the target by a certain
    /// percentage, the machine replicas change. The default value is 60
    /// (representing 60%) if not provided.
    /// </summary>
    public TerraformValue<double>? Target
    {
        get => GetArgument<TerraformValue<double>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for machine_spec in GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_spec";

    /// <summary>
    /// The number of accelerators to attach to the machine.
    /// </summary>
    public TerraformValue<double>? AcceleratorCount
    {
        get => GetArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// Possible values:
    /// ACCELERATOR_TYPE_UNSPECIFIED
    /// NVIDIA_TESLA_K80
    /// NVIDIA_TESLA_P100
    /// NVIDIA_TESLA_V100
    /// NVIDIA_TESLA_P4
    /// NVIDIA_TESLA_T4
    /// NVIDIA_TESLA_A100
    /// NVIDIA_A100_80GB
    /// NVIDIA_L4
    /// NVIDIA_H100_80GB
    /// NVIDIA_H100_MEGA_80GB
    /// NVIDIA_H200_141GB
    /// NVIDIA_B200
    /// TPU_V2
    /// TPU_V3
    /// TPU_V4_POD
    /// TPU_V5_LITEPOD
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The type of the machine.
    /// 
    /// See the [list of machine types supported for
    /// prediction](https://cloud.google.com/vertex-ai/docs/predictions/configure-compute#machine-types)
    /// 
    /// See the [list of machine types supported for custom
    /// training](https://cloud.google.com/vertex-ai/docs/training/configure-compute#machine-types).
    /// 
    /// For DeployedModel this field is optional, and the default
    /// value is &#39;n1-standard-2&#39;. For BatchPredictionJob or as part of
    /// WorkerPoolSpec this field is required.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The number of nodes per replica for multihost GPU deployments.
    /// </summary>
    public TerraformValue<double>? MultihostGpuNodeCount
    {
        get => GetArgument<TerraformValue<double>>("multihost_gpu_node_count");
        set => SetArgument("multihost_gpu_node_count", value);
    }

    /// <summary>
    /// The topology of the TPUs. Corresponds to the TPU topologies available from
    /// GKE. (Example: tpu_topology: &amp;quot;2x2x1&amp;quot;).
    /// </summary>
    public TerraformValue<string>? TpuTopology
    {
        get => GetArgument<TerraformValue<string>>("tpu_topology");
        set => SetArgument("tpu_topology", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlockDedicatedResourcesBlockMachineSpecBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Corresponds to the label key of a reservation resource. To target a
    /// SPECIFIC_RESERVATION by name, use &#39;compute.googleapis.com/reservation-name&#39;
    /// as the key and specify the name of your reservation as its value.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Specifies the reservation affinity type.
    /// Possible values:
    /// TYPE_UNSPECIFIED
    /// NO_RESERVATION
    /// ANY_RESERVATION
    /// SPECIFIC_RESERVATION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationAffinityType is required")]
    public required TerraformValue<string> ReservationAffinityType
    {
        get => GetRequiredArgument<TerraformValue<string>>("reservation_affinity_type");
        set => SetArgument("reservation_affinity_type", value);
    }

    /// <summary>
    /// Corresponds to the label values of a reservation resource. This must be the
    /// full resource name of the reservation or reservation block.
    /// </summary>
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for endpoint_config in GoogleVertexAiEndpointWithModelGardenDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_config";

    /// <summary>
    /// If true, the endpoint will be exposed through a dedicated
    /// DNS [Endpoint.dedicated_endpoint_dns]. Your request to the dedicated DNS
    /// will be isolated from other users&#39; traffic and will have better
    /// performance and reliability. Note: Once you enabled dedicated endpoint,
    /// you won&#39;t be able to send request to the shared DNS
    /// {region}-aiplatform.googleapis.com. The limitations will be removed soon.
    /// </summary>
    public TerraformValue<bool>? DedicatedEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dedicated_endpoint_enabled");
        set => SetArgument("dedicated_endpoint_enabled", value);
    }

    /// <summary>
    /// The user-specified display name of the endpoint. If not set, a
    /// default name will be used.
    /// </summary>
    public TerraformValue<string>? EndpointDisplayName
    {
        get => GetArgument<TerraformValue<string>>("endpoint_display_name");
        set => SetArgument("endpoint_display_name", value);
    }

    /// <summary>
    /// PrivateServiceConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlock>? PrivateServiceConnectConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlock>>("private_service_connect_config");
        set => SetArgument("private_service_connect_config", value);
    }

}

/// <summary>
/// Block type for private_service_connect_config in GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_service_connect_config";

    /// <summary>
    /// Required. If true, expose the IndexEndpoint via private service connect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    public required TerraformValue<bool> EnablePrivateServiceConnect
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_private_service_connect");
        set => SetArgument("enable_private_service_connect", value);
    }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    public TerraformList<string>? ProjectAllowlist
    {
        get => GetArgument<TerraformList<string>>("project_allowlist");
        set => SetArgument("project_allowlist", value);
    }

    /// <summary>
    /// Output only. The name of the generated service attachment resource.
    /// This is only populated if the endpoint is deployed with PrivateServiceConnect.
    /// </summary>
    public TerraformValue<string> ServiceAttachment
        => AsReference("service_attachment");

    /// <summary>
    /// PscAutomationConfigs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscAutomationConfigs block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlockPscAutomationConfigsBlock>? PscAutomationConfigs
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlockPscAutomationConfigsBlock>>("psc_automation_configs");
        set => SetArgument("psc_automation_configs", value);
    }

}

/// <summary>
/// Block type for psc_automation_configs in GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlockPrivateServiceConnectConfigBlockPscAutomationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_automation_configs";

    /// <summary>
    /// Output only. Error message if the PSC service automation failed.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => AsReference("error_message");

    /// <summary>
    /// Output only. Forwarding rule created by the PSC service automation.
    /// </summary>
    public TerraformValue<string> ForwardingRule
        => AsReference("forwarding_rule");

    /// <summary>
    /// Output only. IP address rule created by the PSC service automation.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// Required. The full name of the Google Compute Engine network.
    /// Format: projects/{project}/global/networks/{network}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Required. Project id used to create forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Output only. The state of the PSC service automation.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

}


/// <summary>
/// Block type for model_config in GoogleVertexAiEndpointWithModelGardenDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_config";

    /// <summary>
    /// Whether the user accepts the End User License Agreement (EULA)
    /// for the model.
    /// </summary>
    public TerraformValue<bool>? AcceptEula
    {
        get => GetArgument<TerraformValue<bool>>("accept_eula");
        set => SetArgument("accept_eula", value);
    }

    /// <summary>
    /// The Hugging Face read access token used to access the model
    /// artifacts of gated models.
    /// </summary>
    public TerraformValue<string>? HuggingFaceAccessToken
    {
        get => GetArgument<TerraformValue<string>>("hugging_face_access_token");
        set => SetArgument("hugging_face_access_token", value);
    }

    /// <summary>
    /// If true, the model will deploy with a cached version instead of directly
    /// downloading the model artifacts from Hugging Face. This is suitable for
    /// VPC-SC users with limited internet access.
    /// </summary>
    public TerraformValue<bool>? HuggingFaceCacheEnabled
    {
        get => GetArgument<TerraformValue<bool>>("hugging_face_cache_enabled");
        set => SetArgument("hugging_face_cache_enabled", value);
    }

    /// <summary>
    /// The user-specified display name of the uploaded model. If not
    /// set, a default name will be used.
    /// </summary>
    public TerraformValue<string>? ModelDisplayName
    {
        get => GetArgument<TerraformValue<string>>("model_display_name");
        set => SetArgument("model_display_name", value);
    }

    /// <summary>
    /// ContainerSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock>? ContainerSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock>>("container_spec");
        set => SetArgument("container_spec", value);
    }

}

/// <summary>
/// Block type for container_spec in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_spec";

    /// <summary>
    /// Specifies arguments for the command that runs when the container starts.
    /// This overrides the container&#39;s
    /// [&#39;CMD&#39;](https://docs.docker.com/engine/reference/builder/#cmd). Specify
    /// this field as an array of executable and arguments, similar to a Docker
    /// &#39;CMD&#39;&#39;s &amp;quot;default parameters&amp;quot; form.
    /// 
    /// If you don&#39;t specify this field but do specify the
    /// command field, then the command from the
    /// &#39;command&#39; field runs without any additional arguments. See the
    /// [Kubernetes documentation about how the
    /// &#39;command&#39; and &#39;args&#39; fields interact with a container&#39;s &#39;ENTRYPOINT&#39; and
    /// &#39;CMD&#39;](https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#notes).
    /// 
    /// If you don&#39;t specify this field and don&#39;t specify the &#39;command&#39; field,
    /// then the container&#39;s
    /// [&#39;ENTRYPOINT&#39;](https://docs.docker.com/engine/reference/builder/#cmd) and
    /// &#39;CMD&#39; determine what runs based on their default behavior. See the Docker
    /// documentation about [how &#39;CMD&#39; and &#39;ENTRYPOINT&#39;
    /// interact](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact).
    /// 
    /// In this field, you can reference [environment variables
    /// set by Vertex
    /// AI](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables)
    /// and environment variables set in the env field.
    /// You cannot reference environment variables set in the Docker image. In
    /// order for environment variables to be expanded, reference them by using the
    /// following syntax:$(VARIABLE_NAME)
    /// Note that this differs from Bash variable expansion, which does not use
    /// parentheses. If a variable cannot be resolved, the reference in the input
    /// string is used unchanged. To avoid variable expansion, you can escape this
    /// syntax with &#39;$$&#39;; for example:$$(VARIABLE_NAME)
    /// This field corresponds to the &#39;args&#39; field of the Kubernetes Containers
    /// [v1 core
    /// API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.23/#container-v1-core).
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Specifies the command that runs when the container starts. This overrides
    /// the container&#39;s
    /// [ENTRYPOINT](https://docs.docker.com/engine/reference/builder/#entrypoint).
    /// Specify this field as an array of executable and arguments, similar to a
    /// Docker &#39;ENTRYPOINT&#39;&#39;s &amp;quot;exec&amp;quot; form, not its &amp;quot;shell&amp;quot; form.
    /// 
    /// If you do not specify this field, then the container&#39;s &#39;ENTRYPOINT&#39; runs,
    /// in conjunction with the args field or the
    /// container&#39;s [&#39;CMD&#39;](https://docs.docker.com/engine/reference/builder/#cmd),
    /// if either exists. If this field is not specified and the container does not
    /// have an &#39;ENTRYPOINT&#39;, then refer to the Docker documentation about [how
    /// &#39;CMD&#39; and &#39;ENTRYPOINT&#39;
    /// interact](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact).
    /// 
    /// If you specify this field, then you can also specify the &#39;args&#39; field to
    /// provide additional arguments for this command. However, if you specify this
    /// field, then the container&#39;s &#39;CMD&#39; is ignored. See the
    /// [Kubernetes documentation about how the
    /// &#39;command&#39; and &#39;args&#39; fields interact with a container&#39;s &#39;ENTRYPOINT&#39; and
    /// &#39;CMD&#39;](https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#notes).
    /// 
    /// In this field, you can reference [environment variables set by Vertex
    /// AI](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables)
    /// and environment variables set in the env field.
    /// You cannot reference environment variables set in the Docker image. In
    /// order for environment variables to be expanded, reference them by using the
    /// following syntax:$(VARIABLE_NAME)
    /// Note that this differs from Bash variable expansion, which does not use
    /// parentheses. If a variable cannot be resolved, the reference in the input
    /// string is used unchanged. To avoid variable expansion, you can escape this
    /// syntax with &#39;$$&#39;; for example:$$(VARIABLE_NAME)
    /// This field corresponds to the &#39;command&#39; field of the Kubernetes Containers
    /// [v1 core
    /// API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.23/#container-v1-core).
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// Deployment timeout.
    /// Limit for deployment timeout is 2 hours.
    /// </summary>
    public TerraformValue<string>? DeploymentTimeout
    {
        get => GetArgument<TerraformValue<string>>("deployment_timeout");
        set => SetArgument("deployment_timeout", value);
    }

    /// <summary>
    /// HTTP path on the container to send health checks to. Vertex AI
    /// intermittently sends GET requests to this path on the container&#39;s IP
    /// address and port to check that the container is healthy. Read more about
    /// [health
    /// checks](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#health).
    /// 
    /// For example, if you set this field to &#39;/bar&#39;, then Vertex AI
    /// intermittently sends a GET request to the &#39;/bar&#39; path on the port of your
    /// container specified by the first value of this &#39;ModelContainerSpec&#39;&#39;s
    /// ports field.
    /// 
    /// If you don&#39;t specify this field, it defaults to the following value when
    /// you deploy this Model to an Endpoint:/v1/endpoints/ENDPOINT/deployedModels/DEPLOYED_MODEL:predict
    /// The placeholders in this value are replaced as follows:
    /// 
    /// * ENDPOINT: The last segment (following &#39;endpoints/&#39;)of the
    /// Endpoint.name][] field of the Endpoint where this Model has been
    /// deployed. (Vertex AI makes this value available to your container code
    /// as the [&#39;AIP_ENDPOINT_ID&#39; environment
    /// variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)
    /// 
    /// * DEPLOYED_MODEL: DeployedModel.id of the &#39;DeployedModel&#39;.
    /// (Vertex AI makes this value available to your container code as the
    /// [&#39;AIP_DEPLOYED_MODEL_ID&#39; environment
    /// variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)
    /// </summary>
    public TerraformValue<string>? HealthRoute
    {
        get => GetArgument<TerraformValue<string>>("health_route");
        set => SetArgument("health_route", value);
    }

    /// <summary>
    /// URI of the Docker image to be used as the custom container for serving
    /// predictions. This URI must identify an image in Artifact Registry or
    /// Container Registry. Learn more about the [container publishing
    /// requirements](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#publishing),
    /// including permissions requirements for the Vertex AI Service Agent.
    /// 
    /// The container image is ingested upon ModelService.UploadModel, stored
    /// internally, and this original path is afterwards not used.
    /// 
    /// To learn about the requirements for the Docker image itself, see
    /// [Custom container
    /// requirements](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#).
    /// 
    /// You can use the URI to one of Vertex AI&#39;s [pre-built container images for
    /// prediction](https://cloud.google.com/vertex-ai/docs/predictions/pre-built-containers)
    /// in this field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    public required TerraformValue<string> ImageUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// HTTP path on the container to send prediction requests to. Vertex AI
    /// forwards requests sent using
    /// projects.locations.endpoints.predict to this
    /// path on the container&#39;s IP address and port. Vertex AI then returns the
    /// container&#39;s response in the API response.
    /// 
    /// For example, if you set this field to &#39;/foo&#39;, then when Vertex AI
    /// receives a prediction request, it forwards the request body in a POST
    /// request to the &#39;/foo&#39; path on the port of your container specified by the
    /// first value of this &#39;ModelContainerSpec&#39;&#39;s
    /// ports field.
    /// 
    /// If you don&#39;t specify this field, it defaults to the following value when
    /// you deploy this Model to an Endpoint:/v1/endpoints/ENDPOINT/deployedModels/DEPLOYED_MODEL:predict
    /// The placeholders in this value are replaced as follows:
    /// 
    /// * ENDPOINT: The last segment (following &#39;endpoints/&#39;)of the
    /// Endpoint.name][] field of the Endpoint where this Model has been
    /// deployed. (Vertex AI makes this value available to your container code
    /// as the [&#39;AIP_ENDPOINT_ID&#39; environment
    /// variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)
    /// 
    /// * DEPLOYED_MODEL: DeployedModel.id of the &#39;DeployedModel&#39;.
    /// (Vertex AI makes this value available to your container code
    /// as the [&#39;AIP_DEPLOYED_MODEL_ID&#39; environment
    /// variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)
    /// </summary>
    public TerraformValue<string>? PredictRoute
    {
        get => GetArgument<TerraformValue<string>>("predict_route");
        set => SetArgument("predict_route", value);
    }

    /// <summary>
    /// The amount of the VM memory to reserve as the shared memory for the model
    /// in megabytes.
    /// </summary>
    public TerraformValue<string>? SharedMemorySizeMb
    {
        get => GetArgument<TerraformValue<string>>("shared_memory_size_mb");
        set => SetArgument("shared_memory_size_mb", value);
    }

    /// <summary>
    /// Env block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// GrpcPorts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockGrpcPortsBlock>? GrpcPorts
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockGrpcPortsBlock>>("grpc_ports");
        set => SetArgument("grpc_ports", value);
    }

    /// <summary>
    /// HealthProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock>? HealthProbe
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock>>("health_probe");
        set => SetArgument("health_probe", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessProbe block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// Ports block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockPortsBlock>? Ports
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockPortsBlock>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartupProbe block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

}

/// <summary>
/// Block type for env in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// Name of the environment variable. Must be a valid C identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Variables that reference a $(VAR_NAME) are expanded
    /// using the previous defined environment variables in the container and
    /// any service environment variables. If a variable cannot be resolved,
    /// the reference in the input string will be unchanged. The $(VAR_NAME)
    /// syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped
    /// references will never be expanded, regardless of whether the variable
    /// exists or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for grpc_ports in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockGrpcPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_ports";

    /// <summary>
    /// The number of the port to expose on the pod&#39;s IP address.
    /// Must be a valid port number, between 1 and 65535 inclusive.
    /// </summary>
    public TerraformValue<double>? ContainerPort
    {
        get => GetArgument<TerraformValue<double>>("container_port");
        set => SetArgument("container_port", value);
    }

}

/// <summary>
/// Block type for health_probe in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_probe";

    /// <summary>
    /// Number of consecutive failures before the probe is considered failed.
    /// Defaults to 3. Minimum value is 1.
    /// 
    /// Maps to Kubernetes probe argument &#39;failureThreshold&#39;.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds to wait before starting the probe. Defaults to 0.
    /// Minimum value is 0.
    /// 
    /// Maps to Kubernetes probe argument &#39;initialDelaySeconds&#39;.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds.
    /// Minimum value is 1. Must be less than timeout_seconds.
    /// 
    /// Maps to Kubernetes probe argument &#39;periodSeconds&#39;.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of consecutive successes before the probe is considered successful.
    /// Defaults to 1. Minimum value is 1.
    /// 
    /// Maps to Kubernetes probe argument &#39;successThreshold&#39;.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second.
    /// Minimum value is 1. Must be greater or equal to period_seconds.
    /// 
    /// Maps to Kubernetes probe argument &#39;timeoutSeconds&#39;.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Exec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exec block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockExecBlock>? Exec
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockExecBlock>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for exec in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockExecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exec";

    /// <summary>
    /// Command is the command line to execute inside the container, the working
    /// directory for the command is root (&#39;/&#39;) in the container&#39;s filesystem.
    /// The command is simply exec&#39;d, it is not run inside a shell, so
    /// traditional shell instructions (&#39;|&#39;, etc) won&#39;t work. To use a shell, you
    /// need to explicitly call out to that shell. Exit status of 0 is treated as
    /// live/healthy and non-zero is unhealthy.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number of the gRPC service. Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Service is the name of the service to place in the gRPC
    /// HealthCheckRequest. See
    /// https://github.com/grpc/grpc/blob/master/doc/health-checking.md.
    /// 
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Host name to connect to, defaults to the model serving container&#39;s IP.
    /// You probably want to set &amp;quot;Host&amp;quot; in httpHeaders instead.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Path to access on the HTTP server.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Number of the port to access on the container.
    /// Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Scheme to use for connecting to the host.
    /// Defaults to HTTP. Acceptable values are &amp;quot;HTTP&amp;quot; or &amp;quot;HTTPS&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name.
    /// This will be canonicalized upon output, so case-variant names will be
    /// understood as the same header.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockHealthProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Optional: Host name to connect to, defaults to the model serving
    /// container&#39;s IP.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Number of the port to access on the container.
    /// Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for liveness_probe in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_probe";

    /// <summary>
    /// Number of consecutive failures before the probe is considered failed.
    /// Defaults to 3. Minimum value is 1.
    /// 
    /// Maps to Kubernetes probe argument &#39;failureThreshold&#39;.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds to wait before starting the probe. Defaults to 0.
    /// Minimum value is 0.
    /// 
    /// Maps to Kubernetes probe argument &#39;initialDelaySeconds&#39;.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds.
    /// Minimum value is 1. Must be less than timeout_seconds.
    /// 
    /// Maps to Kubernetes probe argument &#39;periodSeconds&#39;.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of consecutive successes before the probe is considered successful.
    /// Defaults to 1. Minimum value is 1.
    /// 
    /// Maps to Kubernetes probe argument &#39;successThreshold&#39;.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second.
    /// Minimum value is 1. Must be greater or equal to period_seconds.
    /// 
    /// Maps to Kubernetes probe argument &#39;timeoutSeconds&#39;.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Exec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exec block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockExecBlock>? Exec
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockExecBlock>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for exec in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockExecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exec";

    /// <summary>
    /// Command is the command line to execute inside the container, the working
    /// directory for the command is root (&#39;/&#39;) in the container&#39;s filesystem.
    /// The command is simply exec&#39;d, it is not run inside a shell, so
    /// traditional shell instructions (&#39;|&#39;, etc) won&#39;t work. To use a shell, you
    /// need to explicitly call out to that shell. Exit status of 0 is treated as
    /// live/healthy and non-zero is unhealthy.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number of the gRPC service. Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Service is the name of the service to place in the gRPC
    /// HealthCheckRequest. See
    /// https://github.com/grpc/grpc/blob/master/doc/health-checking.md.
    /// 
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Host name to connect to, defaults to the model serving container&#39;s IP.
    /// You probably want to set &amp;quot;Host&amp;quot; in httpHeaders instead.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Path to access on the HTTP server.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Number of the port to access on the container.
    /// Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Scheme to use for connecting to the host.
    /// Defaults to HTTP. Acceptable values are &amp;quot;HTTP&amp;quot; or &amp;quot;HTTPS&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name.
    /// This will be canonicalized upon output, so case-variant names will be
    /// understood as the same header.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockLivenessProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Optional: Host name to connect to, defaults to the model serving
    /// container&#39;s IP.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Number of the port to access on the container.
    /// Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for ports in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ports";

    /// <summary>
    /// The number of the port to expose on the pod&#39;s IP address.
    /// Must be a valid port number, between 1 and 65535 inclusive.
    /// </summary>
    public TerraformValue<double>? ContainerPort
    {
        get => GetArgument<TerraformValue<double>>("container_port");
        set => SetArgument("container_port", value);
    }

}

/// <summary>
/// Block type for startup_probe in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "startup_probe";

    /// <summary>
    /// Number of consecutive failures before the probe is considered failed.
    /// Defaults to 3. Minimum value is 1.
    /// 
    /// Maps to Kubernetes probe argument &#39;failureThreshold&#39;.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds to wait before starting the probe. Defaults to 0.
    /// Minimum value is 0.
    /// 
    /// Maps to Kubernetes probe argument &#39;initialDelaySeconds&#39;.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds.
    /// Minimum value is 1. Must be less than timeout_seconds.
    /// 
    /// Maps to Kubernetes probe argument &#39;periodSeconds&#39;.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of consecutive successes before the probe is considered successful.
    /// Defaults to 1. Minimum value is 1.
    /// 
    /// Maps to Kubernetes probe argument &#39;successThreshold&#39;.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second.
    /// Minimum value is 1. Must be greater or equal to period_seconds.
    /// 
    /// Maps to Kubernetes probe argument &#39;timeoutSeconds&#39;.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Exec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exec block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockExecBlock>? Exec
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockExecBlock>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for exec in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockExecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exec";

    /// <summary>
    /// Command is the command line to execute inside the container, the working
    /// directory for the command is root (&#39;/&#39;) in the container&#39;s filesystem.
    /// The command is simply exec&#39;d, it is not run inside a shell, so
    /// traditional shell instructions (&#39;|&#39;, etc) won&#39;t work. To use a shell, you
    /// need to explicitly call out to that shell. Exit status of 0 is treated as
    /// live/healthy and non-zero is unhealthy.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number of the gRPC service. Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Service is the name of the service to place in the gRPC
    /// HealthCheckRequest. See
    /// https://github.com/grpc/grpc/blob/master/doc/health-checking.md.
    /// 
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Host name to connect to, defaults to the model serving container&#39;s IP.
    /// You probably want to set &amp;quot;Host&amp;quot; in httpHeaders instead.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Path to access on the HTTP server.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Number of the port to access on the container.
    /// Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Scheme to use for connecting to the host.
    /// Defaults to HTTP. Acceptable values are &amp;quot;HTTP&amp;quot; or &amp;quot;HTTPS&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name.
    /// This will be canonicalized upon output, so case-variant names will be
    /// understood as the same header.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlockContainerSpecBlockStartupProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Optional: Host name to connect to, defaults to the model serving
    /// container&#39;s IP.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Number of the port to access on the container.
    /// Number must be in the range 1 to 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiEndpointWithModelGardenDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_vertex_ai_endpoint_with_model_garden_deployment Terraform resource.
/// Manages a google_vertex_ai_endpoint_with_model_garden_deployment resource.
/// </summary>
public partial class GoogleVertexAiEndpointWithModelGardenDeployment(string name) : TerraformResource("google_vertex_ai_endpoint_with_model_garden_deployment", name)
{
    /// <summary>
    /// The Hugging Face model to deploy.
    /// Format: Hugging Face model ID like &#39;google/gemma-2-2b-it&#39;.
    /// </summary>
    public TerraformValue<string>? HuggingFaceModelId
    {
        get => GetArgument<TerraformValue<string>>("hugging_face_model_id");
        set => SetArgument("hugging_face_model_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;location&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Model Garden model to deploy.
    /// Format:
    /// &#39;publishers/{publisher}/models/{publisher_model}@{version_id}&#39;, or
    /// &#39;publishers/hf-{hugging-face-author}/models/{hugging-face-model-name}@001&#39;.
    /// </summary>
    public TerraformValue<string>? PublisherModelName
    {
        get => GetArgument<TerraformValue<string>>("publisher_model_name");
        set => SetArgument("publisher_model_name", value);
    }

    /// <summary>
    /// Output only. The display name assigned to the model deployed to the endpoint.
    /// This is not required to delete the resource but is used for debug logging.
    /// </summary>
    public TerraformValue<string> DeployedModelDisplayName
        => AsReference("deployed_model_display_name");

    /// <summary>
    /// Output only. The unique numeric ID that Vertex AI assigns to the model at the time it is deployed to the endpoint.
    /// It is required to undeploy the model from the endpoint during resource deletion as described in
    /// https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.endpoints/undeployModel.
    /// </summary>
    public TerraformValue<string> DeployedModelId
        => AsReference("deployed_model_id");

    /// <summary>
    /// Resource ID segment making up resource &#39;endpoint&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// DeployConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeployConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock>? DeployConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock>>("deploy_config");
        set => SetArgument("deploy_config", value);
    }

    /// <summary>
    /// EndpointConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock>? EndpointConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock>>("endpoint_config");
        set => SetArgument("endpoint_config", value);
    }

    /// <summary>
    /// ModelConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock>? ModelConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock>>("model_config");
        set => SetArgument("model_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
