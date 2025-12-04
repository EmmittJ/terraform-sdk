using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleVertexAiFeaturestore.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeaturestoreEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for online_serving_config in GoogleVertexAiFeaturestore.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeaturestoreOnlineServingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "online_serving_config";

    /// <summary>
    /// The number of nodes for each cluster. The number of nodes will not scale automatically but can be scaled manually by providing different values when updating.
    /// </summary>
    public TerraformValue<double>? FixedNodeCount
    {
        get => GetArgument<TerraformValue<double>>("fixed_node_count");
        set => SetArgument("fixed_node_count", value);
    }

    /// <summary>
    /// Scaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaling block(s) allowed")]
    public TerraformList<GoogleVertexAiFeaturestoreOnlineServingConfigBlockScalingBlock>? Scaling
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeaturestoreOnlineServingConfigBlockScalingBlock>>("scaling");
        set => SetArgument("scaling", value);
    }

}

/// <summary>
/// Block type for scaling in GoogleVertexAiFeaturestoreOnlineServingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeaturestoreOnlineServingConfigBlockScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling";

    /// <summary>
    /// The maximum number of nodes to scale up to. Must be greater than minNodeCount, and less than or equal to 10 times of &#39;minNodeCount&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The minimum number of nodes to scale down to. Must be greater than or equal to 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformValue<double> MinNodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiFeaturestore.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeaturestoreTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_featurestore Terraform resource.
/// Manages a google_vertex_ai_featurestore resource.
/// </summary>
public partial class GoogleVertexAiFeaturestore(string name) : TerraformResource("google_vertex_ai_featurestore", name)
{
    /// <summary>
    /// If set to true, any EntityTypes and Features for this Featurestore will also be deleted
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// A set of key/value label pairs to assign to this Featurestore.
    /// 
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
    /// The name of the Featurestore. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The region of the dataset. eg us-central1
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the featurestore was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp of when the featurestore was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiFeaturestoreEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeaturestoreEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// OnlineServingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineServingConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiFeaturestoreOnlineServingConfigBlock>? OnlineServingConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeaturestoreOnlineServingConfigBlock>>("online_serving_config");
        set => SetArgument("online_serving_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiFeaturestoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiFeaturestoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
