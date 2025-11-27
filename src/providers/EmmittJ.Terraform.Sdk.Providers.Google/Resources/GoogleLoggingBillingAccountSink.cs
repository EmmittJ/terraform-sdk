using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_options in GoogleLoggingBillingAccountSink.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingBillingAccountSinkBigqueryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_options";

    /// <summary>
    /// Whether to use BigQuery&#39;s partition tables. By default, Logging creates dated tables based on the log entries&#39; timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsePartitionedTables is required")]
    public required TerraformValue<bool> UsePartitionedTables
    {
        get => new TerraformReference<bool>(this, "use_partitioned_tables");
        set => SetArgument("use_partitioned_tables", value);
    }

}


/// <summary>
/// Block type for exclusions in GoogleLoggingBillingAccountSink.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingBillingAccountSinkExclusionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusions";

    /// <summary>
    /// A description of this exclusion.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If set to True, then this exclusion is disabled and it does not exclude any log entries
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// A client-assigned identifier, such as &amp;quot;load-balancer-exclusion&amp;quot;. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a google_logging_billing_account_sink Terraform resource.
/// Manages a google_logging_billing_account_sink resource.
/// </summary>
public partial class GoogleLoggingBillingAccountSink(string name) : TerraformResource("google_logging_billing_account_sink", name)
{
    /// <summary>
    /// The billing account exported to the sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformValue<string> BillingAccount
    {
        get => new TerraformReference<string>(this, "billing_account");
        set => SetArgument("billing_account", value);
    }

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    public TerraformValue<string> WriterIdentity
    {
        get => new TerraformReference<string>(this, "writer_identity");
    }

    /// <summary>
    /// BigqueryOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryOptions block(s) allowed")]
    public TerraformList<GoogleLoggingBillingAccountSinkBigqueryOptionsBlock>? BigqueryOptions
    {
        get => GetArgument<TerraformList<GoogleLoggingBillingAccountSinkBigqueryOptionsBlock>>("bigquery_options");
        set => SetArgument("bigquery_options", value);
    }

    /// <summary>
    /// Exclusions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleLoggingBillingAccountSinkExclusionsBlock>? Exclusions
    {
        get => GetArgument<TerraformList<GoogleLoggingBillingAccountSinkExclusionsBlock>>("exclusions");
        set => SetArgument("exclusions", value);
    }

}
