using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigtable in GoogleVertexAiFeatureOnlineStore.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreBigtableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigtable";

    /// <summary>
    /// AutoScaling block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScaling is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoScaling block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScaling block(s) allowed")]
    public required TerraformList<GoogleVertexAiFeatureOnlineStoreBigtableBlockAutoScalingBlock> AutoScaling
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreBigtableBlockAutoScalingBlock>>("auto_scaling");
        set => SetArgument("auto_scaling", value);
    }

}

/// <summary>
/// Block type for auto_scaling in GoogleVertexAiFeatureOnlineStoreBigtableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreBigtableBlockAutoScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scaling";

    /// <summary>
    /// A percentage of the cluster&#39;s CPU capacity. Can be from 10% to 80%. When a cluster&#39;s CPU utilization exceeds the target that you have set, Bigtable immediately adds nodes to the cluster. When CPU utilization is substantially lower than the target, Bigtable removes nodes. If not set will default to 50%.
    /// </summary>
    public TerraformValue<double> CpuUtilizationTarget
    {
        get => new TerraformReference<double>(this, "cpu_utilization_target");
        set => SetArgument("cpu_utilization_target", value);
    }

    /// <summary>
    /// The maximum number of nodes to scale up to. Must be greater than or equal to minNodeCount, and less than or equal to 10 times of &#39;minNodeCount&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The minimum number of nodes to scale down to. Must be greater than or equal to 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformValue<double> MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for dedicated_serving_endpoint in GoogleVertexAiFeatureOnlineStore.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dedicated_serving_endpoint";

    /// <summary>
    /// Domain name to use for this FeatureOnlineStore
    /// </summary>
    public TerraformValue<string> PublicEndpointDomainName
    {
        get => new TerraformReference<string>(this, "public_endpoint_domain_name");
    }

    /// <summary>
    /// Name of the service attachment resource. Applicable only if private service connect is enabled and after FeatureViewSync is created.
    /// </summary>
    public TerraformValue<string> ServiceAttachment
    {
        get => new TerraformReference<string>(this, "service_attachment");
    }

    /// <summary>
    /// PrivateServiceConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlockPrivateServiceConnectConfigBlock>? PrivateServiceConnectConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlockPrivateServiceConnectConfigBlock>>("private_service_connect_config");
        set => SetArgument("private_service_connect_config", value);
    }

}

/// <summary>
/// Block type for private_service_connect_config in GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlockPrivateServiceConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_service_connect_config";

    /// <summary>
    /// If set to true, customers will use private service connection to send request. Otherwise, the connection will set to public endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    public required TerraformValue<bool> EnablePrivateServiceConnect
    {
        get => new TerraformReference<bool>(this, "enable_private_service_connect");
        set => SetArgument("enable_private_service_connect", value);
    }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    public TerraformList<string>? ProjectAllowlist
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "project_allowlist").ResolveNodes(ctx));
        set => SetArgument("project_allowlist", value);
    }

}


/// <summary>
/// Block type for optimized in GoogleVertexAiFeatureOnlineStore.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreOptimizedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "optimized";

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiFeatureOnlineStore.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_feature_online_store Terraform resource.
/// Manages a google_vertex_ai_feature_online_store resource.
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStore(string name) : TerraformResource("google_vertex_ai_feature_online_store", name)
{
    /// <summary>
    /// If set to true, any FeatureViews and Features for this FeatureOnlineStore will also be deleted.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The labels with user-defined metadata to organize your feature online stores.
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
    /// The resource name of the Feature Online Store. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
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
    /// The region of feature online store. eg us-central1
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the feature online store was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The state of the Feature Online Store. See the possible states in [this link](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.featureOnlineStores#state).
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
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
    /// The timestamp of when the feature online store was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Bigtable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bigtable block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreBigtableBlock>? Bigtable
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreBigtableBlock>>("bigtable");
        set => SetArgument("bigtable", value);
    }

    /// <summary>
    /// DedicatedServingEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedServingEndpoint block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock>? DedicatedServingEndpoint
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock>>("dedicated_serving_endpoint");
        set => SetArgument("dedicated_serving_endpoint", value);
    }

    /// <summary>
    /// Optimized block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Optimized block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreOptimizedBlock>? Optimized
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreOptimizedBlock>>("optimized");
        set => SetArgument("optimized", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiFeatureOnlineStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiFeatureOnlineStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
