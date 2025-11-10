using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsChatbotTeamsChannelConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("chat_configuration_arn");
        SetOutput("tags_all");
        SetOutput("channel_id");
        SetOutput("channel_name");
        SetOutput("configuration_name");
        SetOutput("guardrail_policy_arns");
        SetOutput("iam_role_arn");
        SetOutput("logging_level");
        SetOutput("region");
        SetOutput("sns_topic_arns");
        SetOutput("tags");
        SetOutput("team_id");
        SetOutput("team_name");
        SetOutput("tenant_id");
        SetOutput("user_authorization_required");
    }

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelId is required")]
    public required TerraformProperty<string> ChannelId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("channel_id");
        set => SetProperty("channel_id", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    public TerraformProperty<string> ChannelName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("channel_name");
        set => SetProperty("channel_name", value);
    }

    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationName is required")]
    public required TerraformProperty<string> ConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_name");
        set => SetProperty("configuration_name", value);
    }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>> GuardrailPolicyArns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("guardrail_policy_arns");
        set => SetProperty("guardrail_policy_arns", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string> LoggingLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logging_level");
        set => SetProperty("logging_level", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SnsTopicArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("sns_topic_arns");
        set => SetProperty("sns_topic_arns", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TeamId is required")]
    public required TerraformProperty<string> TeamId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("team_id");
        set => SetProperty("team_id", value);
    }

    /// <summary>
    /// The team_name attribute.
    /// </summary>
    public TerraformProperty<string> TeamName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("team_name");
        set => SetProperty("team_name", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The user_authorization_required attribute.
    /// </summary>
    public TerraformProperty<bool> UserAuthorizationRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("user_authorization_required");
        set => SetProperty("user_authorization_required", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsChatbotTeamsChannelConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
