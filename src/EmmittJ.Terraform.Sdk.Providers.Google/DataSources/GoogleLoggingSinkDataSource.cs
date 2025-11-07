using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_logging_sink.
/// </summary>
public class GoogleLoggingSinkDataSource : TerraformDataSource
{
    public GoogleLoggingSinkDataSource(string name) : base("google_logging_sink", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bigquery_options");
        this.DeclareOutput("description");
        this.DeclareOutput("destination");
        this.DeclareOutput("disabled");
        this.DeclareOutput("exclusions");
        this.DeclareOutput("filter");
        this.DeclareOutput("name");
        this.DeclareOutput("writer_identity");
    }

    /// <summary>
    /// Required. An identifier for the resource in format: &amp;quot;projects/[PROJECT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;organizations/[ORGANIZATION_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_NAME]&amp;quot;, &amp;quot;folders/[FOLDER_ID]/sinks/[SINK_NAME]&amp;quot;
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Options that affect sinks exporting data to BigQuery.
    /// </summary>
    public TerraformExpression BigqueryOptions => this["bigquery_options"];

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    public TerraformExpression Destination => this["destination"];

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    public TerraformExpression Disabled => this["disabled"];

    /// <summary>
    /// Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion&#39;s filters, it will not be exported.
    /// </summary>
    public TerraformExpression Exclusions => this["exclusions"];

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    public TerraformExpression Filter => this["filter"];

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    public TerraformExpression WriterIdentity => this["writer_identity"];

}
