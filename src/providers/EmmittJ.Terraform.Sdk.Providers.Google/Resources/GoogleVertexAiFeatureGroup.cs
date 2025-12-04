using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for big_query in GoogleVertexAiFeatureGroup.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureGroupBigQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "big_query";

    /// <summary>
    /// Columns to construct entityId / row keys. If not provided defaults to entityId.
    /// </summary>
    public TerraformList<string>? EntityIdColumns
    {
        get => GetArgument<TerraformList<string>>("entity_id_columns");
        set => SetArgument("entity_id_columns", value);
    }

    /// <summary>
    /// BigQuerySource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BigQuerySource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BigQuerySource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQuerySource block(s) allowed")]
    public required TerraformList<GoogleVertexAiFeatureGroupBigQueryBlockBigQuerySourceBlock> BigQuerySource
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiFeatureGroupBigQueryBlockBigQuerySourceBlock>>("big_query_source");
        set => SetArgument("big_query_source", value);
    }

}

/// <summary>
/// Block type for big_query_source in GoogleVertexAiFeatureGroupBigQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureGroupBigQueryBlockBigQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "big_query_source";

    /// <summary>
    /// BigQuery URI to a table, up to 2000 characters long. For example: &#39;bq://projectId.bqDatasetId.bqTableId.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputUri is required")]
    public required TerraformValue<string> InputUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("input_uri");
        set => SetArgument("input_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiFeatureGroup.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeatureGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_feature_group Terraform resource.
/// Manages a google_vertex_ai_feature_group resource.
/// </summary>
public partial class GoogleVertexAiFeatureGroup(string name) : TerraformResource("google_vertex_ai_feature_group", name)
{
    /// <summary>
    /// The description of the FeatureGroup.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The labels with user-defined metadata to organize your FeatureGroup.
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
    /// The resource name of the Feature Group.
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
    /// The region of feature group. eg us-central1
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the FeatureGroup was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
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
    /// The timestamp of when the FeatureGroup was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// BigQuery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQuery block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureGroupBigQueryBlock>? BigQuery
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureGroupBigQueryBlock>>("big_query");
        set => SetArgument("big_query", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiFeatureGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiFeatureGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
