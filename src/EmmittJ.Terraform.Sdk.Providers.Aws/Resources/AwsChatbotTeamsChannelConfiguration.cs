using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chatbot_teams_channel_configuration resource.
/// </summary>
public class AwsChatbotTeamsChannelConfiguration : TerraformResource
{
    public AwsChatbotTeamsChannelConfiguration(string name) : base("aws_chatbot_teams_channel_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("chat_configuration_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    public TerraformProperty<string>? ChannelId
    {
        get => GetProperty<TerraformProperty<string>>("channel_id");
        set => this.WithProperty("channel_id", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    public TerraformProperty<string>? ChannelName
    {
        get => GetProperty<TerraformProperty<string>>("channel_name");
        set => this.WithProperty("channel_name", value);
    }

    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_name");
        set => this.WithProperty("configuration_name", value);
    }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? GuardrailPolicyArns
    {
        get => GetProperty<TerraformProperty<List<string>>>("guardrail_policy_arns");
        set => this.WithProperty("guardrail_policy_arns", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
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
    /// The sns_topic_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SnsTopicArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("sns_topic_arns");
        set => this.WithProperty("sns_topic_arns", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    public TerraformProperty<string>? TeamId
    {
        get => GetProperty<TerraformProperty<string>>("team_id");
        set => this.WithProperty("team_id", value);
    }

    /// <summary>
    /// The team_name attribute.
    /// </summary>
    public TerraformProperty<string>? TeamName
    {
        get => GetProperty<TerraformProperty<string>>("team_name");
        set => this.WithProperty("team_name", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
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
    /// The chat_configuration_arn attribute.
    /// </summary>
    public TerraformExpression ChatConfigurationArn => this["chat_configuration_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
