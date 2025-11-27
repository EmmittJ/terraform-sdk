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
        get => new TerraformReference<string>(this, "alarm");
        set => SetArgument("alarm", value);
    }

    /// <summary>
    /// The extension_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionPeriod is required")]
    public required TerraformValue<double> ExtensionPeriod
    {
        get => new TerraformReference<double>(this, "extension_period");
        set => SetArgument("extension_period", value);
    }

    /// <summary>
    /// The wait_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriod is required")]
    public required TerraformValue<double> WaitPeriod
    {
        get => new TerraformReference<double>(this, "wait_period");
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
        get => new TerraformReference<bool>(this, "actions_enabled");
        set => SetArgument("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public TerraformSet<string>? AlarmActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "alarm_actions").ResolveNodes(ctx));
        set => SetArgument("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformValue<string>? AlarmDescription
    {
        get => new TerraformReference<string>(this, "alarm_description");
        set => SetArgument("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => new TerraformReference<string>(this, "alarm_name");
        set => SetArgument("alarm_name", value);
    }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmRule is required")]
    public required TerraformValue<string> AlarmRule
    {
        get => new TerraformReference<string>(this, "alarm_rule");
        set => SetArgument("alarm_rule", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public TerraformSet<string>? InsufficientDataActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "insufficient_data_actions").ResolveNodes(ctx));
        set => SetArgument("insufficient_data_actions", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformSet<string>? OkActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ok_actions").ResolveNodes(ctx));
        set => SetArgument("ok_actions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
