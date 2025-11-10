using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingLinkedDatasetBigqueryDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Output only. The full resource name of the BigQuery dataset. The DATASET_ID will match the ID
    /// of the link, so the link must match the naming restrictions of BigQuery datasets
    /// (alphanumeric characters and underscores only). The dataset will have a resource path of
    /// &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET_ID]&amp;quot;
    /// </summary>
    public TerraformProperty<string>? DatasetId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_id");
        set => WithProperty("dataset_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLoggingLinkedDatasetTimeoutsBlock : TerraformBlock
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
/// Manages a google_logging_linked_dataset resource.
/// </summary>
public class GoogleLoggingLinkedDataset : TerraformResource
{
    public GoogleLoggingLinkedDataset(string name) : base("google_logging_linked_dataset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("lifecycle_state");
        this.WithOutput("name");
    }

    /// <summary>
    /// The bucket to which the linked dataset is attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Describes this link. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The id of the linked dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    public required TerraformProperty<string> LinkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("link_id");
        set => this.WithProperty("link_id", value);
    }

    /// <summary>
    /// The location of the linked dataset.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The parent of the linked dataset.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleLoggingLinkedDatasetBigqueryDatasetBlock>? BigqueryDataset
    {
        get => GetProperty<List<GoogleLoggingLinkedDatasetBigqueryDatasetBlock>>("bigquery_dataset");
        set => this.WithProperty("bigquery_dataset", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleLoggingLinkedDatasetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleLoggingLinkedDatasetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of the link. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;
    /// and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. The linked dataset lifecycle state.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The resource name of the linked dataset. The name can have up to 100 characters. A valid link id
    /// (at the end of the link name) must only have alphanumeric characters and underscores within it.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
