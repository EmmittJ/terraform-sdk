using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContentPolicyConfigBlock
{
    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    [TerraformPropertyName("tier_config")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> TierConfig { get; set; } = default!;

}

/// <summary>
/// Block type for contextual_grounding_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContextualGroundingPolicyConfigBlock
{
}

/// <summary>
/// Block type for cross_region_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailCrossRegionConfigBlock
{
    /// <summary>
    /// The guardrail_profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailProfileIdentifier is required")]
    [TerraformPropertyName("guardrail_profile_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GuardrailProfileIdentifier { get; set; }

}

/// <summary>
/// Block type for sensitive_information_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockGuardrailTimeoutsBlock
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
/// Block type for topic_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailTopicPolicyConfigBlock
{
    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    [TerraformPropertyName("tier_config")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> TierConfig { get; set; } = default!;

}

/// <summary>
/// Block type for word_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailWordPolicyConfigBlock
{
}

/// <summary>
/// Manages a aws_bedrock_guardrail resource.
/// </summary>
public class AwsBedrockGuardrail : TerraformResource
{
    public AwsBedrockGuardrail(string name) : base("aws_bedrock_guardrail", name)
    {
    }

    /// <summary>
    /// The blocked_input_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedInputMessaging is required")]
    [TerraformPropertyName("blocked_input_messaging")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BlockedInputMessaging { get; set; }

    /// <summary>
    /// The blocked_outputs_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedOutputsMessaging is required")]
    [TerraformPropertyName("blocked_outputs_messaging")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BlockedOutputsMessaging { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for content_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("content_policy_config")]
    public TerraformList<TerraformBlock<AwsBedrockGuardrailContentPolicyConfigBlock>>? ContentPolicyConfig { get; set; }

    /// <summary>
    /// Block for contextual_grounding_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("contextual_grounding_policy_config")]
    public TerraformList<TerraformBlock<AwsBedrockGuardrailContextualGroundingPolicyConfigBlock>>? ContextualGroundingPolicyConfig { get; set; }

    /// <summary>
    /// Block for cross_region_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cross_region_config")]
    public TerraformList<TerraformBlock<AwsBedrockGuardrailCrossRegionConfigBlock>>? CrossRegionConfig { get; set; }

    /// <summary>
    /// Block for sensitive_information_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sensitive_information_policy_config")]
    public TerraformList<TerraformBlock<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock>>? SensitiveInformationPolicyConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockGuardrailTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for topic_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("topic_policy_config")]
    public TerraformList<TerraformBlock<AwsBedrockGuardrailTopicPolicyConfigBlock>>? TopicPolicyConfig { get; set; }

    /// <summary>
    /// Block for word_policy_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("word_policy_config")]
    public TerraformList<TerraformBlock<AwsBedrockGuardrailWordPolicyConfigBlock>>? WordPolicyConfig { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The guardrail_arn attribute.
    /// </summary>
    [TerraformPropertyName("guardrail_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GuardrailArn => new TerraformReference(this, "guardrail_arn");

    /// <summary>
    /// The guardrail_id attribute.
    /// </summary>
    [TerraformPropertyName("guardrail_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GuardrailId => new TerraformReference(this, "guardrail_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
