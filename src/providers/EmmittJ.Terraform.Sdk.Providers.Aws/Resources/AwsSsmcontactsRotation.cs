using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recurrence in AwsSsmcontactsRotation.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurrence";

    /// <summary>
    /// The number_of_on_calls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfOnCalls is required")]
    public required TerraformValue<double> NumberOfOnCalls
    {
        get => GetRequiredArgument<TerraformValue<double>>("number_of_on_calls");
        set => SetArgument("number_of_on_calls", value);
    }

    /// <summary>
    /// The recurrence_multiplier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceMultiplier is required")]
    public required TerraformValue<double> RecurrenceMultiplier
    {
        get => GetRequiredArgument<TerraformValue<double>>("recurrence_multiplier");
        set => SetArgument("recurrence_multiplier", value);
    }

    /// <summary>
    /// DailySettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockDailySettingsBlock>? DailySettings
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockDailySettingsBlock>>("daily_settings");
        set => SetArgument("daily_settings", value);
    }

    /// <summary>
    /// MonthlySettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlock>? MonthlySettings
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlock>>("monthly_settings");
        set => SetArgument("monthly_settings", value);
    }

    /// <summary>
    /// ShiftCoverages block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlock>? ShiftCoverages
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlock>>("shift_coverages");
        set => SetArgument("shift_coverages", value);
    }

    /// <summary>
    /// WeeklySettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlock>? WeeklySettings
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlock>>("weekly_settings");
        set => SetArgument("weekly_settings", value);
    }

}

/// <summary>
/// Block type for daily_settings in AwsSsmcontactsRotationRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockDailySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_settings";

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinuteOfHour is required")]
    public required TerraformValue<double> MinuteOfHour
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute_of_hour");
        set => SetArgument("minute_of_hour", value);
    }

}

/// <summary>
/// Block type for monthly_settings in AwsSsmcontactsRotationRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly_settings";

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfMonth is required")]
    public required TerraformValue<double> DayOfMonth
    {
        get => GetRequiredArgument<TerraformValue<double>>("day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// HandOffTime block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlockHandOffTimeBlock>? HandOffTime
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlockHandOffTimeBlock>>("hand_off_time");
        set => SetArgument("hand_off_time", value);
    }

}

/// <summary>
/// Block type for hand_off_time in AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockMonthlySettingsBlockHandOffTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hand_off_time";

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinuteOfHour is required")]
    public required TerraformValue<double> MinuteOfHour
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute_of_hour");
        set => SetArgument("minute_of_hour", value);
    }

}

/// <summary>
/// Block type for shift_coverages in AwsSsmcontactsRotationRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shift_coverages";

    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformValue<string> MapBlockKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("map_block_key");
        set => SetArgument("map_block_key", value);
    }

    /// <summary>
    /// CoverageTimes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlock>? CoverageTimes
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlock>>("coverage_times");
        set => SetArgument("coverage_times", value);
    }

}

/// <summary>
/// Block type for coverage_times in AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "coverage_times";

    /// <summary>
    /// End block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlockEndBlock>? End
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlockEndBlock>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// Start block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlockStartBlock>? Start
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlockStartBlock>>("start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Block type for end in AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlockEndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end";

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinuteOfHour is required")]
    public required TerraformValue<double> MinuteOfHour
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute_of_hour");
        set => SetArgument("minute_of_hour", value);
    }

}

/// <summary>
/// Block type for start in AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockShiftCoveragesBlockCoverageTimesBlockStartBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start";

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinuteOfHour is required")]
    public required TerraformValue<double> MinuteOfHour
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute_of_hour");
        set => SetArgument("minute_of_hour", value);
    }

}

/// <summary>
/// Block type for weekly_settings in AwsSsmcontactsRotationRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_settings";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// HandOffTime block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlockHandOffTimeBlock>? HandOffTime
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlockHandOffTimeBlock>>("hand_off_time");
        set => SetArgument("hand_off_time", value);
    }

}

/// <summary>
/// Block type for hand_off_time in AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlockWeeklySettingsBlockHandOffTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hand_off_time";

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinuteOfHour is required")]
    public required TerraformValue<double> MinuteOfHour
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute_of_hour");
        set => SetArgument("minute_of_hour", value);
    }

}


/// <summary>
/// Represents a aws_ssmcontacts_rotation Terraform resource.
/// Manages a aws_ssmcontacts_rotation resource.
/// </summary>
public partial class AwsSsmcontactsRotation(string name) : TerraformResource("aws_ssmcontacts_rotation", name)
{
    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactIds is required")]
    public TerraformList<string>? ContactIds
    {
        get => GetArgument<TerraformList<string>>("contact_ids");
        set => SetArgument("contact_ids", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    public required TerraformValue<string> TimeZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone_id");
        set => SetArgument("time_zone_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Recurrence block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsRotationRecurrenceBlock>? Recurrence
    {
        get => GetArgument<TerraformList<AwsSsmcontactsRotationRecurrenceBlock>>("recurrence");
        set => SetArgument("recurrence", value);
    }

}
