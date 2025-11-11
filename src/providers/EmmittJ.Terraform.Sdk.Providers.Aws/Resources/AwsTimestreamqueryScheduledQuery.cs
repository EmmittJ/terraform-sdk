using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_report_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for last_run_summary in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryLastRunSummaryBlock : TerraformBlockBase
{




}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for recently_failed_runs in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock : TerraformBlockBase
{




}

/// <summary>
/// Block type for schedule_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformProperty("schedule_expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScheduleExpression { get; set; }

}

/// <summary>
/// Block type for target_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryTargetConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsTimestreamqueryScheduledQueryTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_timestreamquery_scheduled_query resource.
/// </summary>
public partial class AwsTimestreamqueryScheduledQuery : TerraformResource
{
    public AwsTimestreamqueryScheduledQuery(string name) : base("aws_timestreamquery_scheduled_query", name)
    {
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformProperty("query_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for error_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("error_report_configuration")]
    public partial TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>>? ErrorReportConfiguration { get; set; }

    /// <summary>
    /// Block for last_run_summary.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("last_run_summary")]
    public partial TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>>? LastRunSummary { get; set; }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("notification_configuration")]
    public partial TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>>? NotificationConfiguration { get; set; }

    /// <summary>
    /// Block for recently_failed_runs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("recently_failed_runs")]
    public partial TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>>? RecentlyFailedRuns { get; set; }

    /// <summary>
    /// Block for schedule_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("schedule_configuration")]
    public partial TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>>? ScheduleConfiguration { get; set; }

    /// <summary>
    /// Block for target_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("target_configuration")]
    public partial TerraformList<TerraformBlock<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>>? TargetConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsTimestreamqueryScheduledQueryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The next_invocation_time attribute.
    /// </summary>
    [TerraformProperty("next_invocation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NextInvocationTime { get; }

    /// <summary>
    /// The previous_invocation_time attribute.
    /// </summary>
    [TerraformProperty("previous_invocation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreviousInvocationTime { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
