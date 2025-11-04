using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("chat_configuration_arn");
        this.DeclareOutput("slack_channel_name");
        this.DeclareOutput("slack_team_name");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    public string? ConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_name")?.Value;
        set => this.WithProperty("configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    public List<string>? GuardrailPolicyArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("guardrail_policy_arns")?.Value;
        set => this.WithProperty("guardrail_policy_arns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public string? LoggingLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_level")?.Value;
        set => this.WithProperty("logging_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The slack_channel_id attribute.
    /// </summary>
    public string? SlackChannelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slack_channel_id")?.Value;
        set => this.WithProperty("slack_channel_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    public string? SlackTeamId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slack_team_id")?.Value;
        set => this.WithProperty("slack_team_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    public HashSet<string>? SnsTopicArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("sns_topic_arns")?.Value;
        set => this.WithProperty("sns_topic_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_authorization_required attribute.
    /// </summary>
    public bool? UserAuthorizationRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_authorization_required")?.Value;
        set => this.WithProperty("user_authorization_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
