using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for schedule in AwsQuicksightRefreshSchedule.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightRefreshScheduleScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The refresh_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshType is required")]
    public required TerraformValue<string> RefreshType
    {
        get => GetRequiredArgument<TerraformValue<string>>("refresh_type");
        set => SetArgument("refresh_type", value);
    }

    /// <summary>
    /// The start_after_date_time attribute.
    /// </summary>
    public TerraformValue<string> StartAfterDateTime
    {
        get => GetArgument<TerraformValue<string>>("start_after_date_time") ?? CreateReference("start_after_date_time");
        set => SetArgument("start_after_date_time", value);
    }

    /// <summary>
    /// ScheduleFrequency block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlock>? ScheduleFrequency
    {
        get => GetArgument<TerraformList<AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlock>>("schedule_frequency");
        set => SetArgument("schedule_frequency", value);
    }

}

/// <summary>
/// Block type for schedule_frequency in AwsQuicksightRefreshScheduleScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_frequency";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => GetRequiredArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The time_of_the_day attribute.
    /// </summary>
    public TerraformValue<string> TimeOfTheDay
    {
        get => GetArgument<TerraformValue<string>>("time_of_the_day") ?? CreateReference("time_of_the_day");
        set => SetArgument("time_of_the_day", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone") ?? CreateReference("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// RefreshOnDay block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlockRefreshOnDayBlock>? RefreshOnDay
    {
        get => GetArgument<TerraformList<AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlockRefreshOnDayBlock>>("refresh_on_day");
        set => SetArgument("refresh_on_day", value);
    }

}

/// <summary>
/// Block type for refresh_on_day in AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightRefreshScheduleScheduleBlockScheduleFrequencyBlockRefreshOnDayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "refresh_on_day";

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformValue<string>? DayOfMonth
    {
        get => GetArgument<TerraformValue<string>>("day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformValue<string>? DayOfWeek
    {
        get => GetArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_refresh_schedule Terraform resource.
/// Manages a aws_quicksight_refresh_schedule resource.
/// </summary>
public partial class AwsQuicksightRefreshSchedule(string name) : TerraformResource("aws_quicksight_refresh_schedule", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? CreateReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_set_id");
        set => SetArgument("data_set_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schedule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleId is required")]
    public required TerraformValue<string> ScheduleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule_id");
        set => SetArgument("schedule_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQuicksightRefreshScheduleScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AwsQuicksightRefreshScheduleScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}
