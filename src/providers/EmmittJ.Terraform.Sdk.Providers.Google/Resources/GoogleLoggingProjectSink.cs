using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_options in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingProjectSinkBigqueryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Whether to use BigQuery&#39;s partition tables. By default, Logging creates dated tables based on the log entries&#39; timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsePartitionedTables is required")]
    public required TerraformProperty<bool> UsePartitionedTables
    {
        set => SetProperty("use_partitioned_tables", value);
    }

}

/// <summary>
/// Block type for exclusions in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingProjectSinkExclusionsBlock : TerraformBlock
{
    /// <summary>
    /// A description of this exclusion.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// If set to True, then this exclusion is disabled and it does not exclude any log entries
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// A client-assigned identifier, such as &amp;quot;load-balancer-exclusion&amp;quot;. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Manages a google_logging_project_sink resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLoggingProjectSink : TerraformResource
{
    public GoogleLoggingProjectSink(string name) : base("google_logging_project_sink", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("writer_identity");
        SetOutput("custom_writer_identity");
        SetOutput("description");
        SetOutput("destination");
        SetOutput("disabled");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("unique_writer_identity");
    }

    /// <summary>
    /// A service account provided by the caller that will be used to write the log entries. The format must be serviceAccount:some@email. This field can only be specified if you are routing logs to a destination outside this sink&#39;s project. If not specified, a Logging service account will automatically be generated.
    /// </summary>
    public TerraformProperty<string> CustomWriterIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_writer_identity");
        set => SetProperty("custom_writer_identity", value);
    }

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination");
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project to create the sink in. If omitted, the project associated with the provider is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Whether or not to create a unique identity associated with this sink. If false (the legacy behavior), then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true (default), then a unique service account is created and used for this sink. If you wish to publish logs across projects, you must set unique_writer_identity to true.
    /// </summary>
    public TerraformProperty<bool> UniqueWriterIdentity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("unique_writer_identity");
        set => SetProperty("unique_writer_identity", value);
    }

    /// <summary>
    /// Block for bigquery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryOptions block(s) allowed")]
    public List<GoogleLoggingProjectSinkBigqueryOptionsBlock>? BigqueryOptions
    {
        set => SetProperty("bigquery_options", value);
    }

    /// <summary>
    /// Block for exclusions.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleLoggingProjectSinkExclusionsBlock>? Exclusions
    {
        set => SetProperty("exclusions", value);
    }

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    public TerraformExpression WriterIdentity => this["writer_identity"];

}
