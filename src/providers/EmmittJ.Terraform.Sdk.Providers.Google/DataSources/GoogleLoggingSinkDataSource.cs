using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_logging_sink.
/// </summary>
public class GoogleLoggingSinkDataSource : TerraformDataSource
{
    public GoogleLoggingSinkDataSource(string name) : base("google_logging_sink", name)
    {
    }

    /// <summary>
    /// Required. An identifier for the resource in format: &amp;quot;projects/[PROJECT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;organizations/[ORGANIZATION_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;folders/[FOLDER_ID]/sinks/[SINK_NAME]&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Options that affect sinks exporting data to BigQuery.
    /// </summary>
    [TerraformPropertyName("bigquery_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BigqueryOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bigquery_options");

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    [TerraformPropertyName("destination")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Destination => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination");

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Disabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disabled");

    /// <summary>
    /// Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion&#39;s filters, it will not be exported.
    /// </summary>
    [TerraformPropertyName("exclusions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Exclusions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "exclusions");

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Filter => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "filter");

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    [TerraformPropertyName("writer_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WriterIdentity => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "writer_identity");

}
