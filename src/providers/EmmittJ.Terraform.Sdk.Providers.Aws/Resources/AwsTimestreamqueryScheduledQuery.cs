using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_report_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock
{
}

/// <summary>
/// Block type for last_run_summary in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlock
{




}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock
{
}

/// <summary>
/// Block type for recently_failed_runs in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock
{




}

/// <summary>
/// Block type for schedule_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformPropertyName("schedule_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScheduleExpression { get; set; }

}

/// <summary>
/// Block type for target_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTimestreamqueryScheduledQueryTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public required TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformPropertyName("query_string")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for error_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("error_report_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>>? ErrorReportConfiguration { get; set; }

    /// <summary>
    /// Block for last_run_summary.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("last_run_summary")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>>? LastRunSummary { get; set; }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("notification_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>>? NotificationConfiguration { get; set; }

    /// <summary>
    /// Block for recently_failed_runs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("recently_failed_runs")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>>? RecentlyFailedRuns { get; set; }

    /// <summary>
    /// Block for schedule_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("schedule_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>>? ScheduleConfiguration { get; set; }

    /// <summary>
    /// Block for target_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>>? TargetConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsTimestreamqueryScheduledQueryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The next_invocation_time attribute.
    /// </summary>
    [TerraformPropertyName("next_invocation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NextInvocationTime => new TerraformReference(this, "next_invocation_time");

    /// <summary>
    /// The previous_invocation_time attribute.
    /// </summary>
    [TerraformPropertyName("previous_invocation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreviousInvocationTime => new TerraformReference(this, "previous_invocation_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
