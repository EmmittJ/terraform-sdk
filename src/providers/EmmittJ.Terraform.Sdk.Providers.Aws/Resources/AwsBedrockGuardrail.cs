using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_policy_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockGuardrailContentPolicyConfigBlock() : TerraformBlock("content_policy_config")
{
    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    [TerraformProperty("tier_config")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> TierConfig { get; set; }

}

/// <summary>
/// Block type for contextual_grounding_policy_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockGuardrailContextualGroundingPolicyConfigBlock() : TerraformBlock("contextual_grounding_policy_config")
{
}

/// <summary>
/// Block type for cross_region_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockGuardrailCrossRegionConfigBlock() : TerraformBlock("cross_region_config")
{
    /// <summary>
    /// The guardrail_profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailProfileIdentifier is required")]
    [TerraformProperty("guardrail_profile_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GuardrailProfileIdentifier { get; set; }

}

/// <summary>
/// Block type for sensitive_information_policy_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock() : TerraformBlock("sensitive_information_policy_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockGuardrailTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for topic_policy_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockGuardrailTopicPolicyConfigBlock() : TerraformBlock("topic_policy_config")
{
    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    [TerraformProperty("tier_config")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> TierConfig { get; set; }

}

/// <summary>
/// Block type for word_policy_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockGuardrailWordPolicyConfigBlock() : TerraformBlock("word_policy_config")
{
}

/// <summary>
/// Manages a aws_bedrock_guardrail resource.
/// </summary>
public partial class AwsBedrockGuardrail : TerraformResource
{
    public AwsBedrockGuardrail(string name) : base("aws_bedrock_guardrail", name)
    {
    }

    /// <summary>
    /// The blocked_input_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedInputMessaging is required")]
    [TerraformProperty("blocked_input_messaging")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BlockedInputMessaging { get; set; }

    /// <summary>
    /// The blocked_outputs_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedOutputsMessaging is required")]
    [TerraformProperty("blocked_outputs_messaging")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BlockedOutputsMessaging { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for content_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("content_policy_config")]
    public TerraformList<AwsBedrockGuardrailContentPolicyConfigBlock> ContentPolicyConfig { get; set; } = new();

    /// <summary>
    /// Block for contextual_grounding_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("contextual_grounding_policy_config")]
    public TerraformList<AwsBedrockGuardrailContextualGroundingPolicyConfigBlock> ContextualGroundingPolicyConfig { get; set; } = new();

    /// <summary>
    /// Block for cross_region_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cross_region_config")]
    public TerraformList<AwsBedrockGuardrailCrossRegionConfigBlock> CrossRegionConfig { get; set; } = new();

    /// <summary>
    /// Block for sensitive_information_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sensitive_information_policy_config")]
    public TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock> SensitiveInformationPolicyConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBedrockGuardrailTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for topic_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("topic_policy_config")]
    public TerraformList<AwsBedrockGuardrailTopicPolicyConfigBlock> TopicPolicyConfig { get; set; } = new();

    /// <summary>
    /// Block for word_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("word_policy_config")]
    public TerraformList<AwsBedrockGuardrailWordPolicyConfigBlock> WordPolicyConfig { get; set; } = new();

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The guardrail_arn attribute.
    /// </summary>
    [TerraformProperty("guardrail_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GuardrailArn { get; }

    /// <summary>
    /// The guardrail_id attribute.
    /// </summary>
    [TerraformProperty("guardrail_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GuardrailId { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
