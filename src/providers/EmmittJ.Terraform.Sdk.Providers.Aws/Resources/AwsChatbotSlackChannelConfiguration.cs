using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsChatbotSlackChannelConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_chatbot_slack_channel_configuration resource.
/// </summary>
public partial class AwsChatbotSlackChannelConfiguration : TerraformResource
{
    public AwsChatbotSlackChannelConfiguration(string name) : base("aws_chatbot_slack_channel_configuration", name)
    {
    }

    /// <summary>
    /// The configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationName is required")]
    [TerraformProperty("configuration_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigurationName { get; set; }

    /// <summary>
    /// The guardrail_policy_arns attribute.
    /// </summary>
    [TerraformProperty("guardrail_policy_arns")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> GuardrailPolicyArns { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformProperty("iam_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformProperty("logging_level")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoggingLevel { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The slack_channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackChannelId is required")]
    [TerraformProperty("slack_channel_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SlackChannelId { get; set; }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamId is required")]
    [TerraformProperty("slack_team_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SlackTeamId { get; set; }

    /// <summary>
    /// The sns_topic_arns attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arns")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SnsTopicArns { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_authorization_required attribute.
    /// </summary>
    [TerraformProperty("user_authorization_required")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> UserAuthorizationRequired { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsChatbotSlackChannelConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The chat_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("chat_configuration_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ChatConfigurationArn { get; }

    /// <summary>
    /// The slack_channel_name attribute.
    /// </summary>
    [TerraformProperty("slack_channel_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SlackChannelName { get; }

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [TerraformProperty("slack_team_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SlackTeamName { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
