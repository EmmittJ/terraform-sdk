using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleVertexAiIndex.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for metadata in GoogleVertexAiIndex.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// Allows inserting, updating  or deleting the contents of the Matching Engine Index.
    /// The string must be a valid Cloud Storage directory path. If this
    /// field is set when calling IndexService.UpdateIndex, then no other
    /// Index field can be also updated as part of the same call.
    /// The expected structure and format of the files this URI points to is
    /// described at https://cloud.google.com/vertex-ai/docs/matching-engine/using-matching-engine#input-data-format
    /// </summary>
    public TerraformValue<string>? ContentsDeltaUri
    {
        get => GetArgument<TerraformValue<string>>("contents_delta_uri");
        set => SetArgument("contents_delta_uri", value);
    }

    /// <summary>
    /// If this field is set together with contentsDeltaUri when calling IndexService.UpdateIndex,
    /// then existing content of the Index will be replaced by the data from the contentsDeltaUri.
    /// </summary>
    public TerraformValue<bool>? IsCompleteOverwrite
    {
        get => GetArgument<TerraformValue<bool>>("is_complete_overwrite");
        set => SetArgument("is_complete_overwrite", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

}

/// <summary>
/// Block type for config in GoogleVertexAiIndexMetadataBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexMetadataBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The default number of neighbors to find via approximate search before exact reordering is
    /// performed. Exact reordering is a procedure where results returned by an
    /// approximate search algorithm are reordered via a more expensive distance computation.
    /// Required if tree-AH algorithm is used.
    /// </summary>
    public TerraformValue<double>? ApproximateNeighborsCount
    {
        get => GetArgument<TerraformValue<double>>("approximate_neighbors_count");
        set => SetArgument("approximate_neighbors_count", value);
    }

    /// <summary>
    /// The number of dimensions of the input vectors.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dimensions is required")]
    public required TerraformValue<double> Dimensions
    {
        get => GetArgument<TerraformValue<double>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The distance measure used in nearest neighbor search. The value must be one of the followings:
    /// * SQUARED_L2_DISTANCE: Euclidean (L_2) Distance
    /// * L1_DISTANCE: Manhattan (L_1) Distance
    /// * COSINE_DISTANCE: Cosine Distance. Defined as 1 - cosine similarity.
    /// * DOT_PRODUCT_DISTANCE: Dot Product Distance. Defined as a negative of the dot product
    /// </summary>
    public TerraformValue<string>? DistanceMeasureType
    {
        get => GetArgument<TerraformValue<string>>("distance_measure_type");
        set => SetArgument("distance_measure_type", value);
    }

    /// <summary>
    /// Type of normalization to be carried out on each vector. The value must be one of the followings:
    /// * UNIT_L2_NORM: Unit L2 normalization type
    /// * NONE: No normalization type is specified.
    /// </summary>
    public TerraformValue<string>? FeatureNormType
    {
        get => GetArgument<TerraformValue<string>>("feature_norm_type");
        set => SetArgument("feature_norm_type", value);
    }

    /// <summary>
    /// Index data is split into equal parts to be processed. These are called &amp;quot;shards&amp;quot;.
    /// The shard size must be specified when creating an index. The value must be one of the followings:
    /// * SHARD_SIZE_SMALL: Small (2GB)
    /// * SHARD_SIZE_MEDIUM: Medium (20GB)
    /// * SHARD_SIZE_LARGE: Large (50GB)
    /// </summary>
    public TerraformValue<string>? ShardSize
    {
        get => GetArgument<TerraformValue<string>>("shard_size");
        set => SetArgument("shard_size", value);
    }

    /// <summary>
    /// AlgorithmConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlgorithmConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlock>? AlgorithmConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlock>>("algorithm_config");
        set => SetArgument("algorithm_config", value);
    }

}

/// <summary>
/// Block type for algorithm_config in GoogleVertexAiIndexMetadataBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "algorithm_config";

    /// <summary>
    /// BruteForceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BruteForceConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlockBruteForceConfigBlock>? BruteForceConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlockBruteForceConfigBlock>>("brute_force_config");
        set => SetArgument("brute_force_config", value);
    }

    /// <summary>
    /// TreeAhConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TreeAhConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlockTreeAhConfigBlock>? TreeAhConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlockTreeAhConfigBlock>>("tree_ah_config");
        set => SetArgument("tree_ah_config", value);
    }

}

/// <summary>
/// Block type for brute_force_config in GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlockBruteForceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "brute_force_config";

}

/// <summary>
/// Block type for tree_ah_config in GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexMetadataBlockConfigBlockAlgorithmConfigBlockTreeAhConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tree_ah_config";

    /// <summary>
    /// Number of embeddings on each leaf node. The default value is 1000 if not set.
    /// </summary>
    public TerraformValue<double>? LeafNodeEmbeddingCount
    {
        get => GetArgument<TerraformValue<double>>("leaf_node_embedding_count");
        set => SetArgument("leaf_node_embedding_count", value);
    }

    /// <summary>
    /// The default percentage of leaf nodes that any query may be searched. Must be in
    /// range 1-100, inclusive. The default value is 10 (means 10%) if not set.
    /// </summary>
    public TerraformValue<double>? LeafNodesToSearchPercent
    {
        get => GetArgument<TerraformValue<double>>("leaf_nodes_to_search_percent");
        set => SetArgument("leaf_nodes_to_search_percent", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiIndex.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiIndexTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_index Terraform resource.
/// Manages a google_vertex_ai_index resource.
/// </summary>
public partial class GoogleVertexAiIndex(string name) : TerraformResource("google_vertex_ai_index", name)
{
    /// <summary>
    /// The description of the Index.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The update method to use with this Index. The value must be the followings. If not set, BATCH_UPDATE will be used by default.
    /// * BATCH_UPDATE: user can call indexes.patch with files on Cloud Storage of datapoints to update.
    /// * STREAM_UPDATE: user can call indexes.upsertDatapoints/DeleteDatapoints to update the Index and the updates will be applied in corresponding DeployedIndexes in nearly real-time.
    /// </summary>
    public TerraformValue<string>? IndexUpdateMethod
    {
        get => GetArgument<TerraformValue<string>>("index_update_method");
        set => SetArgument("index_update_method", value);
    }

    /// <summary>
    /// The labels with user-defined metadata to organize your Indexes.
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the index. eg us-central1
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The pointers to DeployedIndexes created from this Index. An Index can be only deleted if all its DeployedIndexes had been undeployed first.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeployedIndexes
        => AsReference("deployed_indexes");

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
    /// Stats of the index resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> IndexStats
        => AsReference("index_stats");

    /// <summary>
    /// Points to a YAML file stored on Google Cloud Storage describing additional information about the Index, that is specific to it. Unset if the Index does not have any additional information.
    /// </summary>
    public TerraformValue<string> MetadataSchemaUri
        => AsReference("metadata_schema_uri");

    /// <summary>
    /// The resource name of the Index.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metadata block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public required TerraformList<GoogleVertexAiIndexMetadataBlock> Metadata
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiIndexMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiIndexTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiIndexTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
