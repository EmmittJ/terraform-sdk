using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dedicated_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If the requested value is too large, the deployment will error, but if deployment succeeds then the ability to scale the model to that many replicas is guaranteed (barring service outages). If traffic against the DeployedModel increases beyond what its replicas at maximum may handle, a portion of the traffic will be dropped. If this value is not provided, will use min_replica_count as the default value. The value of this field impacts the charge against Vertex CPU and GPU quotas. Specifically, you will be charged for max_replica_count * number of cores in the selected machine type) and (max_replica_count * number of GPUs per replica in the selected machine type).
    /// </summary>
    public TerraformProperty<double>? MaxReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("max_replica_count");
        set => WithProperty("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of machine replicas this DeployedModel will be always deployed on. This value must be greater than or equal to 1. If traffic against the DeployedModel increases, it may dynamically be deployed onto more replicas, and as traffic decreases, some of these extra replicas may be freed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicaCount is required")]
    public required TerraformProperty<double> MinReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("min_replica_count");
        set => WithProperty("min_replica_count", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiDeploymentResourcePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_vertex_ai_deployment_resource_pool resource.
/// </summary>
public class GoogleVertexAiDeploymentResourcePool : TerraformResource
{
    public GoogleVertexAiDeploymentResourcePool(string name) : base("google_vertex_ai_deployment_resource_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource name of deployment resource pool. The maximum length is 63 characters, and valid characters are &#39;/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of deployment resource pool. eg us-central1
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for dedicated_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedResources block(s) allowed")]
    public List<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock>? DedicatedResources
    {
        get => GetProperty<List<GoogleVertexAiDeploymentResourcePoolDedicatedResourcesBlock>>("dedicated_resources");
        set => this.WithProperty("dedicated_resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiDeploymentResourcePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiDeploymentResourcePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
