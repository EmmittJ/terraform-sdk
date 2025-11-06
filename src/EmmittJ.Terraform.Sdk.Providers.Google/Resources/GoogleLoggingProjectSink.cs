using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_project_sink resource.
/// </summary>
public class GoogleLoggingProjectSink : TerraformResource
{
    public GoogleLoggingProjectSink(string name) : base("google_logging_project_sink", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("writer_identity");
    }

    /// <summary>
    /// A service account provided by the caller that will be used to write the log entries. The format must be serviceAccount:some@email. This field can only be specified if you are routing logs to a destination outside this sink&#39;s project. If not specified, a Logging service account will automatically be generated.
    /// </summary>
    public string? CustomWriterIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_writer_identity")?.Value;
        set => this.WithProperty("custom_writer_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    public string? Destination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination")?.Value;
        set => this.WithProperty("destination", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    public string? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter")?.Value;
        set => this.WithProperty("filter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project to create the sink in. If omitted, the project associated with the provider is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether or not to create a unique identity associated with this sink. If false (the legacy behavior), then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true (default), then a unique service account is created and used for this sink. If you wish to publish logs across projects, you must set unique_writer_identity to true.
    /// </summary>
    public bool? UniqueWriterIdentity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("unique_writer_identity")?.Value;
        set => this.WithProperty("unique_writer_identity", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    public TerraformExpression WriterIdentity => this["writer_identity"];

}
