using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSccV2OrganizationSccBigQueryExportsTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_scc_v2_organization_scc_big_query_exports resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleSccV2OrganizationSccBigQueryExports : TerraformResource
{
    public GoogleSccV2OrganizationSccBigQueryExports(string name) : base("google_scc_v2_organization_scc_big_query_exports", name)
    {
    }

    /// <summary>
    /// This must be unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BigQueryExportId is required")]
    [TerraformPropertyName("big_query_export_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BigQueryExportId { get; set; }

    /// <summary>
    /// The dataset to write findings&#39; updates to.
    /// Its format is &amp;quot;projects/[projectId]/datasets/[bigquery_dataset_id]&amp;quot;.
    /// BigQuery Dataset unique ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_).
    /// </summary>
    [TerraformPropertyName("dataset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Dataset { get; set; }

    /// <summary>
    /// The description of the notification config (max of 1024 characters).
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

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
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// location Id is provided by organization. If not provided, Use global as default.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The resource name of this export, in the format
    /// &#39;organizations/{{organization}}/locations/{{location}}/bigQueryExports/{{big_query_export_id}}&#39;.
    /// This field is provided in responses, and is ignored when provided in create requests.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The organization whose Cloud Security Command Center the Big Query Export
    /// Config lives in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformPropertyName("organization")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSccV2OrganizationSccBigQueryExportsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time at which the BigQuery export was created. This field is set by the server and will be ignored if provided on export on creation.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Email address of the user who last edited the BigQuery export.
    /// This field is set by the server and will be ignored if provided on export creation or update.
    /// </summary>
    [TerraformPropertyName("most_recent_editor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MostRecentEditor => new TerraformReference(this, "most_recent_editor");

    /// <summary>
    /// The service account that needs permission to create table and upload data to the BigQuery dataset.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Principal => new TerraformReference(this, "principal");

    /// <summary>
    /// The most recent time at which the BigQuery export was updated. This field is set by the server and will be ignored if provided on export creation or update.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
