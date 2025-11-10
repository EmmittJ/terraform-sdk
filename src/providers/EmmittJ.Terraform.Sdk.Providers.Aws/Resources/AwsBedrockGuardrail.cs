using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContentPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    public List<TerraformProperty<object>>? TierConfig
    {
        set => SetProperty("tier_config", value);
    }

}

/// <summary>
/// Block type for contextual_grounding_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContextualGroundingPolicyConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for cross_region_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailCrossRegionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The guardrail_profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailProfileIdentifier is required")]
    public required TerraformProperty<string> GuardrailProfileIdentifier
    {
        set => SetProperty("guardrail_profile_identifier", value);
    }

}

/// <summary>
/// Block type for sensitive_information_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockGuardrailTimeoutsBlock : TerraformBlock
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
/// Block type for topic_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailTopicPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    public List<TerraformProperty<object>>? TierConfig
    {
        set => SetProperty("tier_config", value);
    }

}

/// <summary>
/// Block type for word_policy_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailWordPolicyConfigBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_bedrock_guardrail resource.
/// </summary>
public class AwsBedrockGuardrail : TerraformResource
{
    public AwsBedrockGuardrail(string name) : base("aws_bedrock_guardrail", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("guardrail_arn");
        SetOutput("guardrail_id");
        SetOutput("status");
        SetOutput("tags_all");
        SetOutput("version");
        SetOutput("blocked_input_messaging");
        SetOutput("blocked_outputs_messaging");
        SetOutput("description");
        SetOutput("kms_key_arn");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The blocked_input_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedInputMessaging is required")]
    public required TerraformProperty<string> BlockedInputMessaging
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blocked_input_messaging");
        set => SetProperty("blocked_input_messaging", value);
    }

    /// <summary>
    /// The blocked_outputs_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedOutputsMessaging is required")]
    public required TerraformProperty<string> BlockedOutputsMessaging
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blocked_outputs_messaging");
        set => SetProperty("blocked_outputs_messaging", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for content_policy_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockGuardrailContentPolicyConfigBlock>? ContentPolicyConfig
    {
        set => SetProperty("content_policy_config", value);
    }

    /// <summary>
    /// Block for contextual_grounding_policy_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockGuardrailContextualGroundingPolicyConfigBlock>? ContextualGroundingPolicyConfig
    {
        set => SetProperty("contextual_grounding_policy_config", value);
    }

    /// <summary>
    /// Block for cross_region_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockGuardrailCrossRegionConfigBlock>? CrossRegionConfig
    {
        set => SetProperty("cross_region_config", value);
    }

    /// <summary>
    /// Block for sensitive_information_policy_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock>? SensitiveInformationPolicyConfig
    {
        set => SetProperty("sensitive_information_policy_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockGuardrailTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for topic_policy_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockGuardrailTopicPolicyConfigBlock>? TopicPolicyConfig
    {
        set => SetProperty("topic_policy_config", value);
    }

    /// <summary>
    /// Block for word_policy_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockGuardrailWordPolicyConfigBlock>? WordPolicyConfig
    {
        set => SetProperty("word_policy_config", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The guardrail_arn attribute.
    /// </summary>
    public TerraformExpression GuardrailArn => this["guardrail_arn"];

    /// <summary>
    /// The guardrail_id attribute.
    /// </summary>
    public TerraformExpression GuardrailId => this["guardrail_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
