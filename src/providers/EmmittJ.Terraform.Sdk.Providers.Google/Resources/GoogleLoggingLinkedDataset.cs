using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLoggingLinkedDatasetBigqueryDatasetBlock() : TerraformBlock("bigquery_dataset")
{

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleLoggingLinkedDatasetTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_logging_linked_dataset resource.
/// </summary>
public partial class GoogleLoggingLinkedDataset : TerraformResource
{
    public GoogleLoggingLinkedDataset(string name) : base("google_logging_linked_dataset", name)
    {
    }

    /// <summary>
    /// The bucket to which the linked dataset is attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// Describes this link. The maximum length of the description is 8000 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The id of the linked dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    [TerraformProperty("link_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkId { get; set; }

    /// <summary>
    /// The location of the linked dataset.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The parent of the linked dataset.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("bigquery_dataset")]
    public TerraformList<GoogleLoggingLinkedDatasetBigqueryDatasetBlock> BigqueryDataset { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleLoggingLinkedDatasetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The creation timestamp of the link. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;
    /// and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The linked dataset lifecycle state.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The resource name of the linked dataset. The name can have up to 100 characters. A valid link id
    /// (at the end of the link name) must only have alphanumeric characters and underscores within it.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
