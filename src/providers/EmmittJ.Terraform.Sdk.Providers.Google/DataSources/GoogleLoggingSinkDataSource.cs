using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_logging_sink Terraform data source.
/// Retrieves information about a google_logging_sink.
/// </summary>
public partial class GoogleLoggingSinkDataSource(string name) : TerraformDataSource("google_logging_sink", name)
{
    /// <summary>
    /// Required. An identifier for the resource in format: &amp;quot;projects/[PROJECT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;organizations/[ORGANIZATION_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;folders/[FOLDER_ID]/sinks/[SINK_NAME]&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Options that affect sinks exporting data to BigQuery.
    /// </summary>
    public TerraformList<TerraformMap<object>> BigqueryOptions
        => CreateReference("bigquery_options");

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    public TerraformValue<string> Destination
        => CreateReference("destination");

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    public TerraformValue<bool> Disabled
        => CreateReference("disabled");

    /// <summary>
    /// Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion&#39;s filters, it will not be exported.
    /// </summary>
    public TerraformList<TerraformMap<object>> Exclusions
        => CreateReference("exclusions");

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    public TerraformValue<string> Filter
        => CreateReference("filter");

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    public TerraformValue<string> WriterIdentity
        => CreateReference("writer_identity");

}
