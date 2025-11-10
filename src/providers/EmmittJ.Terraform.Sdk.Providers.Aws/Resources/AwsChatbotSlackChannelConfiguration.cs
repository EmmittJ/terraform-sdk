using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsChatbotSlackChannelConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_chatbot_slack_channel_configuration resource.
/// </summary>
public class AwsChatbotSlackChannelConfiguration : TerraformResource
{
    public AwsChatbotSlackChannelConfiguration(string name) : base("aws_chatbot_slack_channel_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("chat_configuration_arn");
        this.WithOutput("slack_channel_name");
        this.WithOutput("slack_team_name");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationName is required")]
    public required TerraformProperty<string> ConfigurationName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("configuration_name");
        set => this.WithProperty("configuration_name", value);
    }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GuardrailPolicyArns
    {
        get => GetProperty<List<TerraformProperty<string>>>("guardrail_policy_arns");
        set => this.WithProperty("guardrail_policy_arns", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        get => GetProperty<TerraformProperty<string>>("logging_level");
        set => this.WithProperty("logging_level", value);
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
    /// The slack_channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackChannelId is required")]
    public required TerraformProperty<string> SlackChannelId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("slack_channel_id");
        set => this.WithProperty("slack_channel_id", value);
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamId is required")]
    public required TerraformProperty<string> SlackTeamId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("slack_team_id");
        set => this.WithProperty("slack_team_id", value);
    }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SnsTopicArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("sns_topic_arns");
        set => this.WithProperty("sns_topic_arns", value);
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
    /// The user_authorization_required attribute.
    /// </summary>
    public TerraformProperty<bool>? UserAuthorizationRequired
    {
        get => GetProperty<TerraformProperty<bool>>("user_authorization_required");
        set => this.WithProperty("user_authorization_required", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsChatbotSlackChannelConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsChatbotSlackChannelConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The chat_configuration_arn attribute.
    /// </summary>
    public TerraformExpression ChatConfigurationArn => this["chat_configuration_arn"];

    /// <summary>
    /// The slack_channel_name attribute.
    /// </summary>
    public TerraformExpression SlackChannelName => this["slack_channel_name"];

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    public TerraformExpression SlackTeamName => this["slack_team_name"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
