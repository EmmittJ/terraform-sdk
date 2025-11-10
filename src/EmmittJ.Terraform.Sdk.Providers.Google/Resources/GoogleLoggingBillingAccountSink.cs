using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_options in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingBillingAccountSinkBigqueryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Whether to use BigQuery&#39;s partition tables. By default, Logging creates dated tables based on the log entries&#39; timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsePartitionedTables is required")]
    public required TerraformProperty<bool> UsePartitionedTables
    {
        get => GetProperty<TerraformProperty<bool>>("use_partitioned_tables");
        set => WithProperty("use_partitioned_tables", value);
    }

}

/// <summary>
/// Block type for exclusions in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingBillingAccountSinkExclusionsBlock : TerraformBlock
{
    /// <summary>
    /// A description of this exclusion.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// If set to True, then this exclusion is disabled and it does not exclude any log entries
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => WithProperty("disabled", value);
    }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

    /// <summary>
    /// A client-assigned identifier, such as &amp;quot;load-balancer-exclusion&amp;quot;. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a google_logging_billing_account_sink resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLoggingBillingAccountSink : TerraformResource
{
    public GoogleLoggingBillingAccountSink(string name) : base("google_logging_billing_account_sink", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("writer_identity");
    }

    /// <summary>
    /// The billing account exported to the sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformProperty<string> BillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetProperty<TerraformProperty<string>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for bigquery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryOptions block(s) allowed")]
    public List<GoogleLoggingBillingAccountSinkBigqueryOptionsBlock>? BigqueryOptions
    {
        get => GetProperty<List<GoogleLoggingBillingAccountSinkBigqueryOptionsBlock>>("bigquery_options");
        set => this.WithProperty("bigquery_options", value);
    }

    /// <summary>
    /// Block for exclusions.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleLoggingBillingAccountSinkExclusionsBlock>? Exclusions
    {
        get => GetProperty<List<GoogleLoggingBillingAccountSinkExclusionsBlock>>("exclusions");
        set => this.WithProperty("exclusions", value);
    }

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    public TerraformExpression WriterIdentity => this["writer_identity"];

}
