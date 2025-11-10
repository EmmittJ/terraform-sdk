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
        set => SetProperty("failure_reason", value);
    }

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationTime
    {
        set => SetProperty("invocation_time", value);
    }

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    public TerraformProperty<string>? RunStatus
    {
        set => SetProperty("run_status", value);
    }

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerTime
    {
        set => SetProperty("trigger_time", value);
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
        set => SetProperty("failure_reason", value);
    }

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationTime
    {
        set => SetProperty("invocation_time", value);
    }

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    public TerraformProperty<string>? RunStatus
    {
        set => SetProperty("run_status", value);
    }

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerTime
    {
        set => SetProperty("trigger_time", value);
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
        set => SetProperty("schedule_expression", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("creation_time");
        SetOutput("next_invocation_time");
        SetOutput("previous_invocation_time");
        SetOutput("state");
        SetOutput("tags_all");
        SetOutput("execution_role_arn");
        SetOutput("kms_key_id");
        SetOutput("name");
        SetOutput("query_string");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformProperty<string> QueryString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_string");
        set => SetProperty("query_string", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for error_report_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>? ErrorReportConfiguration
    {
        set => SetProperty("error_report_configuration", value);
    }

    /// <summary>
    /// Block for last_run_summary.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>? LastRunSummary
    {
        set => SetProperty("last_run_summary", value);
    }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>? NotificationConfiguration
    {
        set => SetProperty("notification_configuration", value);
    }

    /// <summary>
    /// Block for recently_failed_runs.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>? RecentlyFailedRuns
    {
        set => SetProperty("recently_failed_runs", value);
    }

    /// <summary>
    /// Block for schedule_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>? ScheduleConfiguration
    {
        set => SetProperty("schedule_configuration", value);
    }

    /// <summary>
    /// Block for target_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>? TargetConfiguration
    {
        set => SetProperty("target_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsTimestreamqueryScheduledQueryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
