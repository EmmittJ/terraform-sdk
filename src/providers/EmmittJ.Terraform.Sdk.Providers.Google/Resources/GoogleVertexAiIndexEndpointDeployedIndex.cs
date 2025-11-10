using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexAutomaticResourcesBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If maxReplicaCount is not set, the default value is minReplicaCount. The max allowed replica count is 1000.
    /// 
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If the requested value is too large, the deployment will error, but if deployment succeeds then the ability to scale the model to that many replicas is guaranteed (barring service outages). If traffic against the DeployedModel increases beyond what its replicas at maximum may handle, a portion of the traffic will be dropped. If this value is not provided, a no upper bound for scaling under heavy traffic will be assume, though Vertex AI may be unable to scale beyond certain replica number.
    /// </summary>
    public TerraformProperty<double>? MaxReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("max_replica_count");
        set => WithProperty("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of replicas this DeployedModel will be always deployed on. If minReplicaCount is not set, the default value is 2 (we don&#39;t provide SLA when minReplicaCount=1).
    /// 
    /// If traffic against it increases, it may dynamically be deployed onto more replicas up to [maxReplicaCount](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/AutomaticResources#FIELDS.max_replica_count), and as traffic decreases, some of these extra replicas may be freed. If the requested value is too large, the deployment will error.
    /// </summary>
    public TerraformProperty<double>? MinReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("min_replica_count");
        set => WithProperty("min_replica_count", value);
    }

}

/// <summary>
/// Block type for dedicated_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If maxReplicaCount is not set, the default value is minReplicaCount
    /// </summary>
    public TerraformProperty<double>? MaxReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("max_replica_count");
        set => WithProperty("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of machine replicas this DeployedModel will be always deployed on. This value must be greater than or equal to 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicaCount is required")]
    public required TerraformProperty<double> MinReplicaCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_replica_count");
        set => WithProperty("min_replica_count", value);
    }

}

/// <summary>
/// Block type for deployed_index_auth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_vertex_ai_index_endpoint_deployed_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiIndexEndpointDeployedIndex : TerraformResource
{
    public GoogleVertexAiIndexEndpointDeployedIndex(string name) : base("google_vertex_ai_index_endpoint_deployed_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("index_sync_time");
        this.WithOutput("name");
        this.WithOutput("private_endpoints");
    }

    /// <summary>
    /// The user specified ID of the DeployedIndex. The ID can be up to 128 characters long and must start with a letter and only contain letters, numbers, and underscores. The ID must be unique within the project it is created in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeployedIndexId is required")]
    public required TerraformProperty<string> DeployedIndexId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("deployed_index_id");
        set => this.WithProperty("deployed_index_id", value);
    }

    /// <summary>
    /// The deployment group can be no longer than 64 characters (eg: &#39;test&#39;, &#39;prod&#39;). If not set, we will use the &#39;default&#39; deployment group.
    /// Creating deployment_groups with reserved_ip_ranges is a recommended practice when the peered network has multiple peering ranges. This creates your deployments from predictable IP spaces for easier traffic administration. Also, one deployment_group (except &#39;default&#39;) can only be used with the same reserved_ip_ranges which means if the deployment_group has been used with reserved_ip_ranges: [a, b, c], using it with [a, b] or [d, e] is disallowed. [See the official documentation here](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.indexEndpoints#DeployedIndex.FIELDS.deployment_group).
    /// Note: we only support up to 5 deployment groups (not including &#39;default&#39;).
    /// </summary>
    public TerraformProperty<string>? DeploymentGroup
    {
        get => GetProperty<TerraformProperty<string>>("deployment_group");
        set => this.WithProperty("deployment_group", value);
    }

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// If true, private endpoint&#39;s access logs are sent to Cloud Logging.
    /// </summary>
    public TerraformProperty<bool>? EnableAccessLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_access_logging");
        set => this.WithProperty("enable_access_logging", value);
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
    /// The name of the Index this is the deployment of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    public required TerraformProperty<string> Index
    {
        get => GetRequiredProperty<TerraformProperty<string>>("index");
        set => this.WithProperty("index", value);
    }

    /// <summary>
    /// Identifies the index endpoint. Must be in the format
    /// &#39;projects/{{project}}/locations/{{region}}/indexEndpoints/{{indexEndpoint}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexEndpoint is required")]
    public required TerraformProperty<string> IndexEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("index_endpoint");
        set => this.WithProperty("index_endpoint", value);
    }

    /// <summary>
    /// The region of the index endpoint deployment. eg us-central1
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// A list of reserved ip ranges under the VPC network that can be used for this DeployedIndex.
    /// If set, we will deploy the index within the provided ip ranges. Otherwise, the index might be deployed to any ip ranges under the provided VPC network.
    /// 
    /// The value should be the name of the address (https://cloud.google.com/compute/docs/reference/rest/v1/addresses) Example: [&#39;vertex-ai-ip-range&#39;].
    /// 
    /// For more information about subnets and network IP ranges, please see https://cloud.google.com/vpc/docs/subnets#manually_created_subnet_ip_ranges.
    /// </summary>
    public List<TerraformProperty<string>>? ReservedIpRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("reserved_ip_ranges");
        set => this.WithProperty("reserved_ip_ranges", value);
    }

    /// <summary>
    /// Block for automatic_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticResources block(s) allowed")]
    public List<GoogleVertexAiIndexEndpointDeployedIndexAutomaticResourcesBlock>? AutomaticResources
    {
        get => GetProperty<List<GoogleVertexAiIndexEndpointDeployedIndexAutomaticResourcesBlock>>("automatic_resources");
        set => this.WithProperty("automatic_resources", value);
    }

    /// <summary>
    /// Block for dedicated_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedResources block(s) allowed")]
    public List<GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock>? DedicatedResources
    {
        get => GetProperty<List<GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock>>("dedicated_resources");
        set => this.WithProperty("dedicated_resources", value);
    }

    /// <summary>
    /// Block for deployed_index_auth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeployedIndexAuthConfig block(s) allowed")]
    public List<GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock>? DeployedIndexAuthConfig
    {
        get => GetProperty<List<GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock>>("deployed_index_auth_config");
        set => this.WithProperty("deployed_index_auth_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiIndexEndpointDeployedIndexTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiIndexEndpointDeployedIndexTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The DeployedIndex may depend on various data on its original Index. Additionally when certain changes to the original Index are being done (e.g. when what the Index contains is being changed) the DeployedIndex may be asynchronously updated in the background to reflect these changes. If this timestamp&#39;s value is at least the [Index.update_time](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.indexes#Index.FIELDS.update_time) of the original Index, it means that this DeployedIndex and the original Index are in sync. If this timestamp is older, then to see which updates this DeployedIndex already contains (and which it does not), one must [list](https://cloud.google.com/vertex-ai/docs/reference/rest/v1beta1/projects.locations.operations/list#google.longrunning.Operations.ListOperations) the operations that are running on the original Index. Only the successfully completed Operations with updateTime equal or before this sync time are contained in this DeployedIndex.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples:&#160;&amp;quot;2014-10-02T15:01:23Z&amp;quot;&#160;and&#160;&amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression IndexSyncTime => this["index_sync_time"];

    /// <summary>
    /// The name of the DeployedIndex resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Provides paths for users to send requests directly to the deployed index services running on Cloud via private services access. This field is populated if [network](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.indexEndpoints#IndexEndpoint.FIELDS.network) is configured.
    /// </summary>
    public TerraformExpression PrivateEndpoints => this["private_endpoints"];

}
