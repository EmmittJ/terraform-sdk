using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_report_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for last_run_summary in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlock : TerraformBlock
{
    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformProperty<string>? FailureReason
    {
        get => GetProperty<TerraformProperty<string>>("failure_reason");
        set => WithProperty("failure_reason", value);
    }

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationTime
    {
        get => GetProperty<TerraformProperty<string>>("invocation_time");
        set => WithProperty("invocation_time", value);
    }

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    public TerraformProperty<string>? RunStatus
    {
        get => GetProperty<TerraformProperty<string>>("run_status");
        set => WithProperty("run_status", value);
    }

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerTime
    {
        get => GetProperty<TerraformProperty<string>>("trigger_time");
        set => WithProperty("trigger_time", value);
    }

}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for recently_failed_runs in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock : TerraformBlock
{
    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformProperty<string>? FailureReason
    {
        get => GetProperty<TerraformProperty<string>>("failure_reason");
        set => WithProperty("failure_reason", value);
    }

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationTime
    {
        get => GetProperty<TerraformProperty<string>>("invocation_time");
        set => WithProperty("invocation_time", value);
    }

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    public TerraformProperty<string>? RunStatus
    {
        get => GetProperty<TerraformProperty<string>>("run_status");
        set => WithProperty("run_status", value);
    }

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerTime
    {
        get => GetProperty<TerraformProperty<string>>("trigger_time");
        set => WithProperty("trigger_time", value);
    }

}

/// <summary>
/// Block type for schedule_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("schedule_expression");
        set => WithProperty("schedule_expression", value);
    }

}

/// <summary>
/// Block type for target_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTimestreamqueryScheduledQueryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_timestreamquery_scheduled_query resource.
/// </summary>
public class AwsTimestreamqueryScheduledQuery : TerraformResource
{
    public AwsTimestreamqueryScheduledQuery(string name) : base("aws_timestreamquery_scheduled_query", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("next_invocation_time");
        this.DeclareOutput("previous_invocation_time");
        this.DeclareOutput("state");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformProperty<string> QueryString
    {
        get => GetRequiredProperty<TerraformProperty<string>>("query_string");
        set => this.WithProperty("query_string", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for error_report_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>? ErrorReportConfiguration
    {
        get => GetProperty<List<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>>("error_report_configuration");
        set => this.WithProperty("error_report_configuration", value);
    }

    /// <summary>
    /// Block for last_run_summary.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>? LastRunSummary
    {
        get => GetProperty<List<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>>("last_run_summary");
        set => this.WithProperty("last_run_summary", value);
    }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>? NotificationConfiguration
    {
        get => GetProperty<List<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>>("notification_configuration");
        set => this.WithProperty("notification_configuration", value);
    }

    /// <summary>
    /// Block for recently_failed_runs.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>? RecentlyFailedRuns
    {
        get => GetProperty<List<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>>("recently_failed_runs");
        set => this.WithProperty("recently_failed_runs", value);
    }

    /// <summary>
    /// Block for schedule_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>? ScheduleConfiguration
    {
        get => GetProperty<List<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>>("schedule_configuration");
        set => this.WithProperty("schedule_configuration", value);
    }

    /// <summary>
    /// Block for target_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>? TargetConfiguration
    {
        get => GetProperty<List<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>>("target_configuration");
        set => this.WithProperty("target_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsTimestreamqueryScheduledQueryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsTimestreamqueryScheduledQueryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The next_invocation_time attribute.
    /// </summary>
    public TerraformExpression NextInvocationTime => this["next_invocation_time"];

    /// <summary>
    /// The previous_invocation_time attribute.
    /// </summary>
    public TerraformExpression PreviousInvocationTime => this["previous_invocation_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
