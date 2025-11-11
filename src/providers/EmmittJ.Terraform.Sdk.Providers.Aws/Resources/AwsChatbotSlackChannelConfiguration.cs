using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsChatbotSlackChannelConfigurationTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_chatbot_slack_channel_configuration resource.
/// </summary>
public class AwsChatbotSlackChannelConfiguration : TerraformResource
{
    public AwsChatbotSlackChannelConfiguration(string name) : base("aws_chatbot_slack_channel_configuration", name)
    {
    }

    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationName is required")]
    [TerraformPropertyName("configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConfigurationName { get; set; }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    [TerraformPropertyName("guardrail_policy_arns")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> GuardrailPolicyArns { get; set; } = default!;

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformPropertyName("iam_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformPropertyName("logging_level")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoggingLevel { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The slack_channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackChannelId is required")]
    [TerraformPropertyName("slack_channel_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SlackChannelId { get; set; }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamId is required")]
    [TerraformPropertyName("slack_team_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SlackTeamId { get; set; }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arns")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SnsTopicArns { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_authorization_required attribute.
    /// </summary>
    [TerraformPropertyName("user_authorization_required")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> UserAuthorizationRequired { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsChatbotSlackChannelConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The chat_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("chat_configuration_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChatConfigurationArn => new TerraformReference(this, "chat_configuration_arn");

    /// <summary>
    /// The slack_channel_name attribute.
    /// </summary>
    [TerraformPropertyName("slack_channel_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SlackChannelName => new TerraformReference(this, "slack_channel_name");

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [TerraformPropertyName("slack_team_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SlackTeamName => new TerraformReference(this, "slack_team_name");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
