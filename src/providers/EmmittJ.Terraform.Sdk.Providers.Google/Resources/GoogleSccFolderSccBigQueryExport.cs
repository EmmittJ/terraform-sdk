using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSccFolderSccBigQueryExportTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_scc_folder_scc_big_query_export resource.
/// </summary>
public partial class GoogleSccFolderSccBigQueryExport : TerraformResource
{
    public GoogleSccFolderSccBigQueryExport(string name) : base("google_scc_folder_scc_big_query_export", name)
    {
    }

    /// <summary>
    /// This must be unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BigQueryExportId is required")]
    [TerraformProperty("big_query_export_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BigQueryExportId { get; set; }

    /// <summary>
    /// The dataset to write findings&#39; updates to.
    /// Its format is &amp;quot;projects/[projectId]/datasets/[bigquery_dataset_id]&amp;quot;.
    /// BigQuery Dataset unique ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformProperty("dataset")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Dataset { get; set; }

    /// <summary>
    /// The description of the export (max of 1024 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// Expression that defines the filter to apply across create/update
    /// events of findings. The
    /// expression is a list of zero or more restrictions combined via
    /// logical operators AND and OR. Parentheses are supported, and OR
    /// has higher precedence than AND.
    /// 
    /// Restrictions have the form &amp;lt;field&amp;gt; &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt; and may have
    /// a - character in front of them to indicate negation. The fields
    /// map to those defined in the corresponding resource.
    /// 
    /// The supported operators are:
    /// 
    /// * = for all value types.
    /// * &amp;gt;, &amp;lt;, &amp;gt;=, &amp;lt;= for integer values.
    /// * :, meaning substring matching, for strings.
    /// 
    /// The supported value types are:
    /// 
    /// * string literals in quotes.
    /// * integer literals without quotes.
    /// * boolean literals true and false without quotes.
    /// 
    /// See
    /// [Filtering notifications](https://cloud.google.com/security-command-center/docs/how-to-api-filter-notifications)
    /// for information on how to write a filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The folder where Cloud Security Command Center Big Query Export
    /// Config lives in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformProperty("folder")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleSccFolderSccBigQueryExportTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time at which the BigQuery export was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Email address of the user who last edited the BigQuery export.
    /// </summary>
    [TerraformProperty("most_recent_editor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MostRecentEditor { get; }

    /// <summary>
    /// The resource name of this export, in the format
    /// &#39;projects/{{project}}/bigQueryExports/{{big_query_export_id}}&#39;.
    /// This field is provided in responses, and is ignored when provided in create requests.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The service account that needs permission to create table and upload data to the BigQuery dataset.
    /// </summary>
    [TerraformProperty("principal")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Principal { get; }

    /// <summary>
    /// The most recent time at which the BigQuery export was updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
