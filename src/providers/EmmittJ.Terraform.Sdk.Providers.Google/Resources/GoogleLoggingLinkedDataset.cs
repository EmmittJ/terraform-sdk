using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingLinkedDatasetBigqueryDatasetBlock : ITerraformBlock
{
    /// <summary>
    /// Output only. The full resource name of the BigQuery dataset. The DATASET_ID will match the ID
    /// of the link, so the link must match the naming restrictions of BigQuery datasets
    /// (alphanumeric characters and underscores only). The dataset will have a resource path of
    /// &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET_ID]&amp;quot;
    /// </summary>
    [TerraformPropertyName("dataset_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatasetId => new TerraformReferenceProperty<TerraformProperty<string>>("", "dataset_id");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLoggingLinkedDatasetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_logging_linked_dataset resource.
/// </summary>
public class GoogleLoggingLinkedDataset : TerraformResource
{
    public GoogleLoggingLinkedDataset(string name) : base("google_logging_linked_dataset", name)
    {
    }

    /// <summary>
    /// The bucket to which the linked dataset is attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// Describes this link. The maximum length of the description is 8000 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The id of the linked dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    [TerraformPropertyName("link_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkId { get; set; }

    /// <summary>
    /// The location of the linked dataset.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Location { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The parent of the linked dataset.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Parent { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent");

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("bigquery_dataset")]
    public TerraformList<TerraformBlock<GoogleLoggingLinkedDatasetBigqueryDatasetBlock>>? BigqueryDataset { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleLoggingLinkedDatasetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The creation timestamp of the link. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;
    /// and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. The linked dataset lifecycle state.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The resource name of the linked dataset. The name can have up to 100 characters. A valid link id
    /// (at the end of the link name) must only have alphanumeric characters and underscores within it.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
