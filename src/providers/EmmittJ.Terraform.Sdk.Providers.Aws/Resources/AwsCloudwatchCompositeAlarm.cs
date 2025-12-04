using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions_suppressor in AwsCloudwatchCompositeAlarm.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchCompositeAlarmActionsSuppressorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions_suppressor";

    /// <summary>
    /// The alarm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alarm is required")]
    public required TerraformValue<string> Alarm
    {
        get => GetRequiredArgument<TerraformValue<string>>("alarm");
        set => SetArgument("alarm", value);
    }

    /// <summary>
    /// The extension_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionPeriod is required")]
    public required TerraformValue<double> ExtensionPeriod
    {
        get => GetRequiredArgument<TerraformValue<double>>("extension_period");
        set => SetArgument("extension_period", value);
    }

    /// <summary>
    /// The wait_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriod is required")]
    public required TerraformValue<double> WaitPeriod
    {
        get => GetRequiredArgument<TerraformValue<double>>("wait_period");
        set => SetArgument("wait_period", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_composite_alarm Terraform resource.
/// Manages a aws_cloudwatch_composite_alarm resource.
/// </summary>
public partial class AwsCloudwatchCompositeAlarm(string name) : TerraformResource("aws_cloudwatch_composite_alarm", name)
{
    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ActionsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("actions_enabled");
        set => SetArgument("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public TerraformSet<string>? AlarmActions
    {
        get => GetArgument<TerraformSet<string>>("alarm_actions");
        set => SetArgument("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformValue<string>? AlarmDescription
    {
        get => GetArgument<TerraformValue<string>>("alarm_description");
        set => SetArgument("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => GetRequiredArgument<TerraformValue<string>>("alarm_name");
        set => SetArgument("alarm_name", value);
    }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmRule is required")]
    public required TerraformValue<string> AlarmRule
    {
        get => GetRequiredArgument<TerraformValue<string>>("alarm_rule");
        set => SetArgument("alarm_rule", value);
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
    /// The insufficient_data_actions attribute.
    /// </summary>
    public TerraformSet<string>? InsufficientDataActions
    {
        get => GetArgument<TerraformSet<string>>("insufficient_data_actions");
        set => SetArgument("insufficient_data_actions", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformSet<string>? OkActions
    {
        get => GetArgument<TerraformSet<string>>("ok_actions");
        set => SetArgument("ok_actions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// ActionsSuppressor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionsSuppressor block(s) allowed")]
    public TerraformList<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>? ActionsSuppressor
    {
        get => GetArgument<TerraformList<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>>("actions_suppressor");
        set => SetArgument("actions_suppressor", value);
    }

}
