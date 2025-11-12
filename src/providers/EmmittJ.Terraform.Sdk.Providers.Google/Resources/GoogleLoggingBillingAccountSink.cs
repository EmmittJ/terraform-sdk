using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLoggingBillingAccountSinkBigqueryOptionsBlock() : TerraformBlock("bigquery_options")
{
    /// <summary>
    /// Whether to use BigQuery&#39;s partition tables. By default, Logging creates dated tables based on the log entries&#39; timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsePartitionedTables is required")]
    [TerraformProperty("use_partitioned_tables")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> UsePartitionedTables { get; set; }

}

/// <summary>
/// Block type for exclusions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLoggingBillingAccountSinkExclusionsBlock() : TerraformBlock("exclusions")
{
    /// <summary>
    /// A description of this exclusion.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If set to True, then this exclusion is disabled and it does not exclude any log entries
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// A client-assigned identifier, such as &amp;quot;load-balancer-exclusion&amp;quot;. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a google_logging_billing_account_sink resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleLoggingBillingAccountSink : TerraformResource
{
    public GoogleLoggingBillingAccountSink(string name) : base("google_logging_billing_account_sink", name)
    {
    }

    /// <summary>
    /// The billing account exported to the sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    [TerraformProperty("billing_account")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BillingAccount { get; set; }

    /// <summary>
    /// A description of this sink. The maximum length of the description is 8000 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, or a BigQuery dataset. Examples: &amp;quot;storage.googleapis.com/[GCS_BUCKET]&amp;quot; &amp;quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]&amp;quot; &amp;quot;pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]&amp;quot; The writer associated with the sink must have access to write to the above resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// If set to True, then this sink is disabled and it does not export any log entries.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the logging sink.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for bigquery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryOptions block(s) allowed")]
    [TerraformProperty("bigquery_options")]
    public TerraformList<GoogleLoggingBillingAccountSinkBigqueryOptionsBlock> BigqueryOptions { get; set; } = new();

    /// <summary>
    /// Block for exclusions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("exclusions")]
    public TerraformList<GoogleLoggingBillingAccountSinkExclusionsBlock> Exclusions { get; set; } = new();

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the configured destination.
    /// </summary>
    [TerraformProperty("writer_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WriterIdentity { get; }

}
