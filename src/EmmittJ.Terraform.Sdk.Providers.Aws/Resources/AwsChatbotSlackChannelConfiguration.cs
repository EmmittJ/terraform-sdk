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
    public TerraformLiteralProperty<string>? ConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_name");
        set => this.WithProperty("configuration_name", value);
    }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? GuardrailPolicyArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("guardrail_policy_arns");
        set => this.WithProperty("guardrail_policy_arns", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoggingLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_level");
        set => this.WithProperty("logging_level", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The slack_channel_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SlackChannelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slack_channel_id");
        set => this.WithProperty("slack_channel_id", value);
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SlackTeamId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slack_team_id");
        set => this.WithProperty("slack_team_id", value);
    }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SnsTopicArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("sns_topic_arns");
        set => this.WithProperty("sns_topic_arns", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_authorization_required attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UserAuthorizationRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_authorization_required");
        set => this.WithProperty("user_authorization_required", value);
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
