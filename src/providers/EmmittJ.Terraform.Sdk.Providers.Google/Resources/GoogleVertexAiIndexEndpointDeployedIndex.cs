using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_resources in GoogleVertexAiIndexEndpointDeployedIndex.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexAutomaticResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_resources";

    /// <summary>
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If maxReplicaCount is not set, the default value is minReplicaCount. The max allowed replica count is 1000.
    /// 
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If the requested value is too large, the deployment will error, but if deployment succeeds then the ability to scale the model to that many replicas is guaranteed (barring service outages). If traffic against the DeployedModel increases beyond what its replicas at maximum may handle, a portion of the traffic will be dropped. If this value is not provided, a no upper bound for scaling under heavy traffic will be assume, though Vertex AI may be unable to scale beyond certain replica number.
    /// </summary>
    public TerraformValue<double> MaxReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("max_replica_count") ?? CreateReference("max_replica_count");
        set => SetArgument("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of replicas this DeployedModel will be always deployed on. If minReplicaCount is not set, the default value is 2 (we don&#39;t provide SLA when minReplicaCount=1).
    /// 
    /// If traffic against it increases, it may dynamically be deployed onto more replicas up to [maxReplicaCount](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/AutomaticResources#FIELDS.max_replica_count), and as traffic decreases, some of these extra replicas may be freed. If the requested value is too large, the deployment will error.
    /// </summary>
    public TerraformValue<double> MinReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("min_replica_count") ?? CreateReference("min_replica_count");
        set => SetArgument("min_replica_count", value);
    }

}


/// <summary>
/// Block type for dedicated_resources in GoogleVertexAiIndexEndpointDeployedIndex.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dedicated_resources";

    /// <summary>
    /// The maximum number of replicas this DeployedModel may be deployed on when the traffic against it increases. If maxReplicaCount is not set, the default value is minReplicaCount
    /// </summary>
    public TerraformValue<double> MaxReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("max_replica_count") ?? CreateReference("max_replica_count");
        set => SetArgument("max_replica_count", value);
    }

    /// <summary>
    /// The minimum number of machine replicas this DeployedModel will be always deployed on. This value must be greater than or equal to 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicaCount is required")]
    public required TerraformValue<double> MinReplicaCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_replica_count");
        set => SetArgument("min_replica_count", value);
    }

    /// <summary>
    /// MachineSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MachineSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    public required TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlockMachineSpecBlock> MachineSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlockMachineSpecBlock>>("machine_spec");
        set => SetArgument("machine_spec", value);
    }

}

/// <summary>
/// Block type for machine_spec in GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlockMachineSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_spec";

    /// <summary>
    /// The type of the machine.
    /// 
    /// See the [list of machine types supported for prediction](https://cloud.google.com/vertex-ai/docs/predictions/configure-compute#machine-types)
    /// 
    /// See the [list of machine types supported for custom training](https://cloud.google.com/vertex-ai/docs/training/configure-compute#machine-types).
    /// 
    /// For [DeployedModel](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.endpoints#DeployedModel) this field is optional, and the default value is n1-standard-2. For [BatchPredictionJob](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.batchPredictionJobs#BatchPredictionJob) or as part of [WorkerPoolSpec](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/CustomJobSpec#WorkerPoolSpec) this field is required.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

}


/// <summary>
/// Block type for deployed_index_auth_config in GoogleVertexAiIndexEndpointDeployedIndex.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployed_index_auth_config";

    /// <summary>
    /// AuthProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthProvider block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlockAuthProviderBlock>? AuthProvider
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlockAuthProviderBlock>>("auth_provider");
        set => SetArgument("auth_provider", value);
    }

}

/// <summary>
/// Block type for auth_provider in GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlockAuthProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_provider";

    /// <summary>
    /// A list of allowed JWT issuers. Each entry must be a valid Google service account, in the following format: service-account-name@project-id.iam.gserviceaccount.com
    /// </summary>
    public TerraformList<string>? AllowedIssuers
    {
        get => GetArgument<TerraformList<string>>("allowed_issuers");
        set => SetArgument("allowed_issuers", value);
    }

    /// <summary>
    /// The list of JWT audiences. that are allowed to access. A JWT containing any of these audiences will be accepted.
    /// </summary>
    public TerraformList<string>? Audiences
    {
        get => GetArgument<TerraformList<string>>("audiences");
        set => SetArgument("audiences", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiIndexEndpointDeployedIndex.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiIndexEndpointDeployedIndexTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_index_endpoint_deployed_index Terraform resource.
/// Manages a google_vertex_ai_index_endpoint_deployed_index resource.
/// </summary>
public partial class GoogleVertexAiIndexEndpointDeployedIndex(string name) : TerraformResource("google_vertex_ai_index_endpoint_deployed_index", name)
{
    /// <summary>
    /// The user specified ID of the DeployedIndex. The ID can be up to 128 characters long and must start with a letter and only contain letters, numbers, and underscores. The ID must be unique within the project it is created in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeployedIndexId is required")]
    public required TerraformValue<string> DeployedIndexId
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployed_index_id");
        set => SetArgument("deployed_index_id", value);
    }

    /// <summary>
    /// The deployment group can be no longer than 64 characters (eg: &#39;test&#39;, &#39;prod&#39;). If not set, we will use the &#39;default&#39; deployment group.
    /// Creating deployment_groups with reserved_ip_ranges is a recommended practice when the peered network has multiple peering ranges. This creates your deployments from predictable IP spaces for easier traffic administration. Also, one deployment_group (except &#39;default&#39;) can only be used with the same reserved_ip_ranges which means if the deployment_group has been used with reserved_ip_ranges: [a, b, c], using it with [a, b] or [d, e] is disallowed. [See the official documentation here](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.indexEndpoints#DeployedIndex.FIELDS.deployment_group).
    /// Note: we only support up to 5 deployment groups (not including &#39;default&#39;).
    /// </summary>
    public TerraformValue<string>? DeploymentGroup
    {
        get => GetArgument<TerraformValue<string>>("deployment_group");
        set => SetArgument("deployment_group", value);
    }

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// If true, private endpoint&#39;s access logs are sent to Cloud Logging.
    /// </summary>
    public TerraformValue<bool>? EnableAccessLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_access_logging");
        set => SetArgument("enable_access_logging", value);
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
    /// The name of the Index this is the deployment of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    public required TerraformValue<string> Index
    {
        get => GetRequiredArgument<TerraformValue<string>>("index");
        set => SetArgument("index", value);
    }

    /// <summary>
    /// Identifies the index endpoint. Must be in the format
    /// &#39;projects/{{project}}/locations/{{region}}/indexEndpoints/{{indexEndpoint}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexEndpoint is required")]
    public required TerraformValue<string> IndexEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("index_endpoint");
        set => SetArgument("index_endpoint", value);
    }

    /// <summary>
    /// The region of the index endpoint deployment. eg us-central1
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A list of reserved ip ranges under the VPC network that can be used for this DeployedIndex.
    /// If set, we will deploy the index within the provided ip ranges. Otherwise, the index might be deployed to any ip ranges under the provided VPC network.
    /// 
    /// The value should be the name of the address (https://cloud.google.com/compute/docs/reference/rest/v1/addresses) Example: [&#39;vertex-ai-ip-range&#39;].
    /// 
    /// For more information about subnets and network IP ranges, please see https://cloud.google.com/vpc/docs/subnets#manually_created_subnet_ip_ranges.
    /// </summary>
    public TerraformList<string>? ReservedIpRanges
    {
        get => GetArgument<TerraformList<string>>("reserved_ip_ranges");
        set => SetArgument("reserved_ip_ranges", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The DeployedIndex may depend on various data on its original Index. Additionally when certain changes to the original Index are being done (e.g. when what the Index contains is being changed) the DeployedIndex may be asynchronously updated in the background to reflect these changes. If this timestamp&#39;s value is at least the [Index.update_time](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.indexes#Index.FIELDS.update_time) of the original Index, it means that this DeployedIndex and the original Index are in sync. If this timestamp is older, then to see which updates this DeployedIndex already contains (and which it does not), one must [list](https://cloud.google.com/vertex-ai/docs/reference/rest/v1beta1/projects.locations.operations/list#google.longrunning.Operations.ListOperations) the operations that are running on the original Index. Only the successfully completed Operations with updateTime equal or before this sync time are contained in this DeployedIndex.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples:&#160;&amp;quot;2014-10-02T15:01:23Z&amp;quot;&#160;and&#160;&amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> IndexSyncTime
        => CreateReference("index_sync_time");

    /// <summary>
    /// The name of the DeployedIndex resource.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Provides paths for users to send requests directly to the deployed index services running on Cloud via private services access. This field is populated if [network](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.indexEndpoints#IndexEndpoint.FIELDS.network) is configured.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateEndpoints
        => CreateReference("private_endpoints");

    /// <summary>
    /// AutomaticResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticResources block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEndpointDeployedIndexAutomaticResourcesBlock>? AutomaticResources
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEndpointDeployedIndexAutomaticResourcesBlock>>("automatic_resources");
        set => SetArgument("automatic_resources", value);
    }

    /// <summary>
    /// DedicatedResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedResources block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock>? DedicatedResources
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDedicatedResourcesBlock>>("dedicated_resources");
        set => SetArgument("dedicated_resources", value);
    }

    /// <summary>
    /// DeployedIndexAuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeployedIndexAuthConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock>? DeployedIndexAuthConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEndpointDeployedIndexDeployedIndexAuthConfigBlock>>("deployed_index_auth_config");
        set => SetArgument("deployed_index_auth_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiIndexEndpointDeployedIndexTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiIndexEndpointDeployedIndexTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
