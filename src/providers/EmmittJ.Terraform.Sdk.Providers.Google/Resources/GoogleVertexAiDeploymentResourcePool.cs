using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dedicated_resources in GoogleVertexAiDeploymentResourcePool.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dedicated_resources";

    /// <summary>
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If the requested value is too large, the deployment will error, but if deployment succeeds then the ability to scale the model to that many replicas is guaranteed (barring service outages). If traffic against the DeployedModel increases beyond what its replicas at maximum may handle, a portion of the traffic will be dropped. If this value is not provided, will use min_replica_count as the default value. The value of this field impacts the charge against Vertex CPU and GPU quotas. Specifically, you will be charged for max_replica_count * number of cores in the selected machine type) and (max_replica_count * number of GPUs per replica in the selected machine type).
    /// </summary>
    public TerraformValue<double>? MaxReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("max_replica_count");
        set => SetArgument("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of machine replicas this DeployedModel will be always deployed on. This value must be greater than or equal to 1. If traffic against the DeployedModel increases, it may dynamically be deployed onto more replicas, and as traffic decreases, some of these extra replicas may be freed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicaCount is required")]
    public required TerraformValue<double> MinReplicaCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_replica_count");
        set => SetArgument("min_replica_count", value);
    }

    /// <summary>
    /// AutoscalingMetricSpecs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlockAutoscalingMetricSpecsBlock>? AutoscalingMetricSpecs
    {
        get => GetArgument<TerraformList<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlockAutoscalingMetricSpecsBlock>>("autoscaling_metric_specs");
        set => SetArgument("autoscaling_metric_specs", value);
    }

    /// <summary>
    /// MachineSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MachineSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    public required TerraformList<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlockMachineSpecBlock> MachineSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlockMachineSpecBlock>>("machine_spec");
        set => SetArgument("machine_spec", value);
    }

}

/// <summary>
/// Block type for autoscaling_metric_specs in GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlockAutoscalingMetricSpecsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_metric_specs";

    /// <summary>
    /// The resource metric name. Supported metrics: For Online Prediction: * &#39;aiplatform.googleapis.com/prediction/online/accelerator/duty_cycle&#39; * &#39;aiplatform.googleapis.com/prediction/online/cpu/utilization&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The target resource utilization in percentage (1% - 100%) for the given metric; once the real usage deviates from the target by a certain percentage, the machine replicas change. The default value is 60 (representing 60%) if not provided.
    /// </summary>
    public TerraformValue<double>? Target
    {
        get => GetArgument<TerraformValue<double>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for machine_spec in GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlockMachineSpecBlock : TerraformBlock
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
    /// The type of accelerator(s) that may be attached to the machine as per accelerator_count. See possible values [here](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/MachineSpec#AcceleratorType).
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The type of the machine. See the [list of machine types supported for prediction](https://cloud.google.com/vertex-ai/docs/predictions/configure-compute#machine-types).
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiDeploymentResourcePool.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiDeploymentResourcePoolTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_deployment_resource_pool Terraform resource.
/// Manages a google_vertex_ai_deployment_resource_pool resource.
/// </summary>
public partial class GoogleVertexAiDeploymentResourcePool(string name) : TerraformResource("google_vertex_ai_deployment_resource_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of deployment resource pool. The maximum length is 63 characters, and valid characters are &#39;/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/&#39;.
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
    /// The region of deployment resource pool. eg us-central1
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// DedicatedResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedResources block(s) allowed")]
    public TerraformList<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock>? DedicatedResources
    {
        get => GetArgument<TerraformList<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock>>("dedicated_resources");
        set => SetArgument("dedicated_resources", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiDeploymentResourcePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiDeploymentResourcePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
