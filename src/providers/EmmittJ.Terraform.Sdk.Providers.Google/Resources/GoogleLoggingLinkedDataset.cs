using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in GoogleLoggingLinkedDataset.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingLinkedDatasetBigqueryDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_dataset";

    /// <summary>
    /// Output only. The full resource name of the BigQuery dataset. The DATASET_ID will match the ID
    /// of the link, so the link must match the naming restrictions of BigQuery datasets
    /// (alphanumeric characters and underscores only). The dataset will have a resource path of
    /// &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET_ID]&amp;quot;
    /// </summary>
    public TerraformValue<string> DatasetId
        => CreateReference("dataset_id");

}


/// <summary>
/// Block type for timeouts in GoogleLoggingLinkedDataset.
/// Nesting mode: single
/// </summary>
public class GoogleLoggingLinkedDatasetTimeoutsBlock : TerraformBlock
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
/// Represents a google_logging_linked_dataset Terraform resource.
/// Manages a google_logging_linked_dataset resource.
/// </summary>
public partial class GoogleLoggingLinkedDataset(string name) : TerraformResource("google_logging_linked_dataset", name)
{
    /// <summary>
    /// The bucket to which the linked dataset is attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Describes this link. The maximum length of the description is 8000 characters.
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The id of the linked dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    public required TerraformValue<string> LinkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("link_id");
        set => SetArgument("link_id", value);
    }

    /// <summary>
    /// The location of the linked dataset.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? CreateReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The parent of the linked dataset.
    /// </summary>
    public TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent") ?? CreateReference("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of the link. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;
    /// and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Output only. The linked dataset lifecycle state.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => CreateReference("lifecycle_state");

    /// <summary>
    /// The resource name of the linked dataset. The name can have up to 100 characters. A valid link id
    /// (at the end of the link name) must only have alphanumeric characters and underscores within it.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// BigqueryDataset block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleLoggingLinkedDatasetBigqueryDatasetBlock>? BigqueryDataset
    {
        get => GetArgument<TerraformList<GoogleLoggingLinkedDatasetBigqueryDatasetBlock>>("bigquery_dataset");
        set => SetArgument("bigquery_dataset", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleLoggingLinkedDatasetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleLoggingLinkedDatasetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
