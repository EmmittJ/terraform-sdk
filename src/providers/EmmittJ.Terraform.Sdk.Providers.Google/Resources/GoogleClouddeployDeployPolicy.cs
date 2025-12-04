using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleClouddeployDeployPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// RolloutRestriction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutRestriction block(s) allowed")]
    public TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlock>? RolloutRestriction
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlock>>("rollout_restriction");
        set => SetArgument("rollout_restriction", value);
    }

}

/// <summary>
/// Block type for rollout_restriction in GoogleClouddeployDeployPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout_restriction";

    /// <summary>
    /// Rollout actions to be restricted as part of the policy. If left empty, all actions will be restricted. Possible values: [&amp;quot;ADVANCE&amp;quot;, &amp;quot;APPROVE&amp;quot;, &amp;quot;CANCEL&amp;quot;, &amp;quot;CREATE&amp;quot;, &amp;quot;IGNORE_JOB&amp;quot;, &amp;quot;RETRY_JOB&amp;quot;, &amp;quot;ROLLBACK&amp;quot;, &amp;quot;TERMINATE_JOBRUN&amp;quot;]
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// ID of the rule. This id must be unique in the &#39;DeployPolicy&#39; resource to which this rule belongs. The format is &#39;a-z{0,62}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// What invoked the action. If left empty, all invoker types will be restricted. Possible values: [&amp;quot;USER&amp;quot;, &amp;quot;DEPLOY_AUTOMATION&amp;quot;]
    /// </summary>
    public TerraformList<string>? Invokers
    {
        get => GetArgument<TerraformList<string>>("invokers");
        set => SetArgument("invokers", value);
    }

    /// <summary>
    /// TimeWindows block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeWindows block(s) allowed")]
    public TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlock>? TimeWindows
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlock>>("time_windows");
        set => SetArgument("time_windows", value);
    }

}

/// <summary>
/// Block type for time_windows in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_windows";

    /// <summary>
    /// The time zone in IANA format IANA Time Zone Database (e.g. America/New_York).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// OneTimeWindows block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock>? OneTimeWindows
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock>>("one_time_windows");
        set => SetArgument("one_time_windows", value);
    }

    /// <summary>
    /// WeeklyWindows block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlock>? WeeklyWindows
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlock>>("weekly_windows");
        set => SetArgument("weekly_windows", value);
    }

}

/// <summary>
/// Block type for one_time_windows in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "one_time_windows";

    /// <summary>
    /// EndDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public required TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockEndDateBlock> EndDate
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockEndDateBlock>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// EndTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndTime block(s) allowed")]
    public required TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockEndTimeBlock> EndTime
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockEndTimeBlock>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// StartDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public required TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockStartDateBlock> StartDate
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockStartDateBlock>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for end_date in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for end_time in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockEndTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_time";

    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or equal to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for start_date in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockOneTimeWindowsBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or equal to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for weekly_windows in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_windows";

    /// <summary>
    /// Days of week. If left empty, all days of the week will be included. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformList<string>? DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// EndTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndTime block(s) allowed")]
    public TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlockEndTimeBlock>? EndTime
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlockEndTimeBlock>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlockStartTimeBlock>? StartTime
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for end_time in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlockEndTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_time";

    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or equal to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicyRulesBlockRolloutRestrictionBlockTimeWindowsBlockWeeklyWindowsBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or equal to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for selectors in GoogleClouddeployDeployPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicySelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selectors";

    /// <summary>
    /// DeliveryPipeline block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryPipeline block(s) allowed")]
    public TerraformList<GoogleClouddeployDeployPolicySelectorsBlockDeliveryPipelineBlock>? DeliveryPipeline
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicySelectorsBlockDeliveryPipelineBlock>>("delivery_pipeline");
        set => SetArgument("delivery_pipeline", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public TerraformList<GoogleClouddeployDeployPolicySelectorsBlockTargetBlock>? Target
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeployPolicySelectorsBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for delivery_pipeline in GoogleClouddeployDeployPolicySelectorsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicySelectorsBlockDeliveryPipelineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_pipeline";

    /// <summary>
    /// ID of the DeliveryPipeline. The value of this field could be one of the following:
    /// - The last segment of a pipeline name
    /// - &amp;quot;*&amp;quot;, all delivery pipelines in a location
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// DeliveryPipeline labels.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for target in GoogleClouddeployDeployPolicySelectorsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeployPolicySelectorsBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// ID of the &#39;Target&#39;. The value of this field could be one of the following: * The last segment of a target name. It only needs the ID to determine which target is being referred to * &amp;quot;*&amp;quot;, all targets in a location.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Target labels.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleClouddeployDeployPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployDeployPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_clouddeploy_deploy_policy Terraform resource.
/// Manages a google_clouddeploy_deploy_policy resource.
/// </summary>
public partial class GoogleClouddeployDeployPolicy(string name) : TerraformResource("google_clouddeploy_deploy_policy", name)
{
    /// <summary>
    /// User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. Annotations must meet the following constraints: * Annotations are key/value pairs. * Valid annotation keys have two segments: an optional prefix and name, separated by a slash (&#39;/&#39;). * The name segment is required and must be 63 characters or less, beginning and ending with an alphanumeric character (&#39;[a-z0-9A-Z]&#39;) with dashes (&#39;-&#39;), underscores (&#39;_&#39;), dots (&#39;.&#39;), and alphanumerics between. * The prefix is optional. If specified, the prefix must be a DNS subdomain: a series of DNS labels separated by dots(&#39;.&#39;), not longer than 253 characters in total, followed by a slash (&#39;/&#39;). See https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/#syntax-and-character-set for more details.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Description of the &#39;DeployPolicy&#39;. Max length is 255 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 63 characters.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the &#39;DeployPolicy&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// When suspended, the policy will not prevent actions from occurring, even if the action violates the policy.
    /// </summary>
    public TerraformValue<bool>? Suspended
    {
        get => GetArgument<TerraformValue<bool>>("suspended");
        set => SetArgument("suspended", value);
    }

    /// <summary>
    /// Output only. Time at which the DeployPolicy was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The weak etag of the &#39;DeployPolicy&#39; resource. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. Unique identifier of the &#39;DeployPolicy&#39;.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. Time at which the DeployPolicy was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleClouddeployDeployPolicyRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeployPolicyRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selectors is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Selectors block(s) required")]
    public required TerraformList<GoogleClouddeployDeployPolicySelectorsBlock> Selectors
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeployPolicySelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleClouddeployDeployPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleClouddeployDeployPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
