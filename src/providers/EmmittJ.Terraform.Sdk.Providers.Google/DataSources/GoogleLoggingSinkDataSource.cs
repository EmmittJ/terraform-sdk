using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_logging_sink.
/// </summary>
public partial class GoogleLoggingSinkDataSource : TerraformDataSource
{
    public GoogleLoggingSinkDataSource(string name) : base("google_logging_sink", name)
    {
    }

    /// <summary>
    /// Required. An identifier for the resource in format: &amp;quot;projects/[PROJECT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;organizations/[ORGANIZATION_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;folders/[FOLDER_ID]/sinks/[SINK_NAME]&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Options that affect sinks exporting data to BigQuery.
    /// </summary>
    [TerraformProperty("bigquery_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BigqueryOptions { get; }

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    [TerraformProperty("destination")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Destination { get; }

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    [TerraformProperty("disabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Disabled { get; }

    /// <summary>
    /// Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion&#39;s filters, it will not be exported.
    /// </summary>
    [TerraformProperty("exclusions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Exclusions { get; }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    [TerraformProperty("filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Filter { get; }

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    [TerraformProperty("writer_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WriterIdentity { get; }

}
