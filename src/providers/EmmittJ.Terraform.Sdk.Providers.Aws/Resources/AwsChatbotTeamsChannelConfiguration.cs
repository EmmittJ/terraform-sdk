using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsChatbotTeamsChannelConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsChatbotTeamsChannelConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_chatbot_teams_channel_configuration Terraform resource.
/// Manages a aws_chatbot_teams_channel_configuration resource.
/// </summary>
public partial class AwsChatbotTeamsChannelConfiguration(string name) : TerraformResource("aws_chatbot_teams_channel_configuration", name)
{
    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelId is required")]
    public required TerraformValue<string> ChannelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("channel_id");
        set => SetArgument("channel_id", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    public TerraformValue<string> ChannelName
    {
        get => GetArgument<TerraformValue<string>>("channel_name") ?? CreateReference("channel_name");
        set => SetArgument("channel_name", value);
    }

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
        get => GetArgument<TerraformList<string>>("guardrail_policy_arns") ?? CreateReference("guardrail_policy_arns");
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
        get => GetArgument<TerraformValue<string>>("logging_level") ?? CreateReference("logging_level");
        set => SetArgument("logging_level", value);
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
    /// The sns_topic_arns attribute.
    /// </summary>
    public TerraformSet<string> SnsTopicArns
    {
        get => GetArgument<TerraformSet<string>>("sns_topic_arns") ?? CreateReference("sns_topic_arns");
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
    /// The team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TeamId is required")]
    public required TerraformValue<string> TeamId
    {
        get => GetRequiredArgument<TerraformValue<string>>("team_id");
        set => SetArgument("team_id", value);
    }

    /// <summary>
    /// The team_name attribute.
    /// </summary>
    public TerraformValue<string> TeamName
    {
        get => GetArgument<TerraformValue<string>>("team_name") ?? CreateReference("team_name");
        set => SetArgument("team_name", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// The user_authorization_required attribute.
    /// </summary>
    public TerraformValue<bool> UserAuthorizationRequired
    {
        get => GetArgument<TerraformValue<bool>>("user_authorization_required") ?? CreateReference("user_authorization_required");
        set => SetArgument("user_authorization_required", value);
    }

    /// <summary>
    /// The chat_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> ChatConfigurationArn
        => CreateReference("chat_configuration_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsChatbotTeamsChannelConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsChatbotTeamsChannelConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
