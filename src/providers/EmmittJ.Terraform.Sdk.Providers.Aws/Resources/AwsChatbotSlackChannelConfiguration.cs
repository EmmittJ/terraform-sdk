using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsChatbotSlackChannelConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsChatbotSlackChannelConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_chatbot_slack_channel_configuration Terraform resource.
/// Manages a aws_chatbot_slack_channel_configuration resource.
/// </summary>
public partial class AwsChatbotSlackChannelConfiguration(string name) : TerraformResource("aws_chatbot_slack_channel_configuration", name)
{
    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationName is required")]
    public required TerraformValue<string> ConfigurationName
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_name");
        set => SetArgument("configuration_name", value);
    }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    public TerraformList<string> GuardrailPolicyArns
    {
        get => GetArgument<TerraformList<string>>("guardrail_policy_arns") ?? AsReference("guardrail_policy_arns");
        set => SetArgument("guardrail_policy_arns", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformValue<string> LoggingLevel
    {
        get => GetArgument<TerraformValue<string>>("logging_level") ?? AsReference("logging_level");
        set => SetArgument("logging_level", value);
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
    /// The slack_channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackChannelId is required")]
    public required TerraformValue<string> SlackChannelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("slack_channel_id");
        set => SetArgument("slack_channel_id", value);
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamId is required")]
    public required TerraformValue<string> SlackTeamId
    {
        get => GetRequiredArgument<TerraformValue<string>>("slack_team_id");
        set => SetArgument("slack_team_id", value);
    }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    public TerraformSet<string> SnsTopicArns
    {
        get => GetArgument<TerraformSet<string>>("sns_topic_arns") ?? AsReference("sns_topic_arns");
        set => SetArgument("sns_topic_arns", value);
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
    /// The user_authorization_required attribute.
    /// </summary>
    public TerraformValue<bool> UserAuthorizationRequired
    {
        get => GetArgument<TerraformValue<bool>>("user_authorization_required") ?? AsReference("user_authorization_required");
        set => SetArgument("user_authorization_required", value);
    }

    /// <summary>
    /// The chat_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> ChatConfigurationArn
        => AsReference("chat_configuration_arn");

    /// <summary>
    /// The slack_channel_name attribute.
    /// </summary>
    public TerraformValue<string> SlackChannelName
        => AsReference("slack_channel_name");

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    public TerraformValue<string> SlackTeamName
        => AsReference("slack_team_name");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsChatbotSlackChannelConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsChatbotSlackChannelConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
