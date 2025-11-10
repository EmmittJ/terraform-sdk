using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_report_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for last_run_summary in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlock : ITerraformBlock
{
    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureReason => new TerraformReferenceProperty<TerraformProperty<string>>("", "failure_reason");

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    [TerraformPropertyName("invocation_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvocationTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "invocation_time");

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    [TerraformPropertyName("run_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RunStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "run_status");

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    [TerraformPropertyName("trigger_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TriggerTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "trigger_time");

}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for recently_failed_runs in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock : ITerraformBlock
{
    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureReason => new TerraformReferenceProperty<TerraformProperty<string>>("", "failure_reason");

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    [TerraformPropertyName("invocation_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvocationTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "invocation_time");

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    [TerraformPropertyName("run_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RunStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "run_status");

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    [TerraformPropertyName("trigger_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TriggerTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "trigger_time");

}

/// <summary>
/// Block type for schedule_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformPropertyName("schedule_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScheduleExpression { get; set; }

}

/// <summary>
/// Block type for target_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTimestreamqueryScheduledQueryTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_timestreamquery_scheduled_query resource.
/// </summary>
public class AwsTimestreamqueryScheduledQuery : TerraformResource
{
    public AwsTimestreamqueryScheduledQuery(string name) : base("aws_timestreamquery_scheduled_query", name)
    {
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformPropertyName("query_string")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for error_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("error_report_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>>? ErrorReportConfiguration { get; set; } = new();

    /// <summary>
    /// Block for last_run_summary.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("last_run_summary")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>>? LastRunSummary { get; set; } = new();

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("notification_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>>? NotificationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for recently_failed_runs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("recently_failed_runs")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>>? RecentlyFailedRuns { get; set; } = new();

    /// <summary>
    /// Block for schedule_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("schedule_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>>? ScheduleConfiguration { get; set; } = new();

    /// <summary>
    /// Block for target_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>>? TargetConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsTimestreamqueryScheduledQueryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The next_invocation_time attribute.
    /// </summary>
    [TerraformPropertyName("next_invocation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextInvocationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_invocation_time");

    /// <summary>
    /// The previous_invocation_time attribute.
    /// </summary>
    [TerraformPropertyName("previous_invocation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreviousInvocationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "previous_invocation_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
