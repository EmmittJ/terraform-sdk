using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_policy_config in AwsBedrockGuardrail.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContentPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_policy_config";

    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? TierConfig
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("tier_config");
        set => SetArgument("tier_config", value);
    }

    /// <summary>
    /// FiltersConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockGuardrailContentPolicyConfigBlockFiltersConfigBlock>? FiltersConfig
    {
        get => GetArgument<TerraformSet<AwsBedrockGuardrailContentPolicyConfigBlockFiltersConfigBlock>>("filters_config");
        set => SetArgument("filters_config", value);
    }

}

/// <summary>
/// Block type for filters_config in AwsBedrockGuardrailContentPolicyConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockGuardrailContentPolicyConfigBlockFiltersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters_config";

    /// <summary>
    /// The input_strength attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputStrength is required")]
    public required TerraformValue<string> InputStrength
    {
        get => GetArgument<TerraformValue<string>>("input_strength");
        set => SetArgument("input_strength", value);
    }

    /// <summary>
    /// The output_strength attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputStrength is required")]
    public required TerraformValue<string> OutputStrength
    {
        get => GetArgument<TerraformValue<string>>("output_strength");
        set => SetArgument("output_strength", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for contextual_grounding_policy_config in AwsBedrockGuardrail.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContextualGroundingPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contextual_grounding_policy_config";

    /// <summary>
    /// FiltersConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailContextualGroundingPolicyConfigBlockFiltersConfigBlock>? FiltersConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailContextualGroundingPolicyConfigBlockFiltersConfigBlock>>("filters_config");
        set => SetArgument("filters_config", value);
    }

}

/// <summary>
/// Block type for filters_config in AwsBedrockGuardrailContextualGroundingPolicyConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailContextualGroundingPolicyConfigBlockFiltersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters_config";

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for cross_region_config in AwsBedrockGuardrail.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailCrossRegionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cross_region_config";

    /// <summary>
    /// The guardrail_profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailProfileIdentifier is required")]
    public required TerraformValue<string> GuardrailProfileIdentifier
    {
        get => GetArgument<TerraformValue<string>>("guardrail_profile_identifier");
        set => SetArgument("guardrail_profile_identifier", value);
    }

}


/// <summary>
/// Block type for sensitive_information_policy_config in AwsBedrockGuardrail.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitive_information_policy_config";

    /// <summary>
    /// PiiEntitiesConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlockPiiEntitiesConfigBlock>? PiiEntitiesConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlockPiiEntitiesConfigBlock>>("pii_entities_config");
        set => SetArgument("pii_entities_config", value);
    }

    /// <summary>
    /// RegexesConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlockRegexesConfigBlock>? RegexesConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlockRegexesConfigBlock>>("regexes_config");
        set => SetArgument("regexes_config", value);
    }

}

/// <summary>
/// Block type for pii_entities_config in AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailSensitiveInformationPolicyConfigBlockPiiEntitiesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pii_entities_config";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The input_action attribute.
    /// </summary>
    public TerraformValue<string>? InputAction
    {
        get => GetArgument<TerraformValue<string>>("input_action");
        set => SetArgument("input_action", value);
    }

    /// <summary>
    /// The input_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("input_enabled");
        set => SetArgument("input_enabled", value);
    }

    /// <summary>
    /// The output_action attribute.
    /// </summary>
    public TerraformValue<string>? OutputAction
    {
        get => GetArgument<TerraformValue<string>>("output_action");
        set => SetArgument("output_action", value);
    }

    /// <summary>
    /// The output_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OutputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("output_enabled");
        set => SetArgument("output_enabled", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for regexes_config in AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailSensitiveInformationPolicyConfigBlockRegexesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regexes_config";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The input_action attribute.
    /// </summary>
    public TerraformValue<string>? InputAction
    {
        get => GetArgument<TerraformValue<string>>("input_action");
        set => SetArgument("input_action", value);
    }

    /// <summary>
    /// The input_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("input_enabled");
        set => SetArgument("input_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The output_action attribute.
    /// </summary>
    public TerraformValue<string>? OutputAction
    {
        get => GetArgument<TerraformValue<string>>("output_action");
        set => SetArgument("output_action", value);
    }

    /// <summary>
    /// The output_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OutputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("output_enabled");
        set => SetArgument("output_enabled", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockGuardrail.
/// Nesting mode: single
/// </summary>
public class AwsBedrockGuardrailTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for topic_policy_config in AwsBedrockGuardrail.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailTopicPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topic_policy_config";

    /// <summary>
    /// The tier_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? TierConfig
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("tier_config");
        set => SetArgument("tier_config", value);
    }

    /// <summary>
    /// TopicsConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailTopicPolicyConfigBlockTopicsConfigBlock>? TopicsConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailTopicPolicyConfigBlockTopicsConfigBlock>>("topics_config");
        set => SetArgument("topics_config", value);
    }

}

/// <summary>
/// Block type for topics_config in AwsBedrockGuardrailTopicPolicyConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailTopicPolicyConfigBlockTopicsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topics_config";

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    public required TerraformValue<string> Definition
    {
        get => GetArgument<TerraformValue<string>>("definition");
        set => SetArgument("definition", value);
    }

    /// <summary>
    /// The examples attribute.
    /// </summary>
    public TerraformList<string>? Examples
    {
        get => GetArgument<TerraformList<string>>("examples");
        set => SetArgument("examples", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for word_policy_config in AwsBedrockGuardrail.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailWordPolicyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_policy_config";

    /// <summary>
    /// ManagedWordListsConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailWordPolicyConfigBlockManagedWordListsConfigBlock>? ManagedWordListsConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailWordPolicyConfigBlockManagedWordListsConfigBlock>>("managed_word_lists_config");
        set => SetArgument("managed_word_lists_config", value);
    }

    /// <summary>
    /// WordsConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailWordPolicyConfigBlockWordsConfigBlock>? WordsConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailWordPolicyConfigBlockWordsConfigBlock>>("words_config");
        set => SetArgument("words_config", value);
    }

}

/// <summary>
/// Block type for managed_word_lists_config in AwsBedrockGuardrailWordPolicyConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailWordPolicyConfigBlockManagedWordListsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_word_lists_config";

    /// <summary>
    /// The input_action attribute.
    /// </summary>
    public TerraformValue<string>? InputAction
    {
        get => GetArgument<TerraformValue<string>>("input_action");
        set => SetArgument("input_action", value);
    }

    /// <summary>
    /// The input_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("input_enabled");
        set => SetArgument("input_enabled", value);
    }

    /// <summary>
    /// The output_action attribute.
    /// </summary>
    public TerraformValue<string>? OutputAction
    {
        get => GetArgument<TerraformValue<string>>("output_action");
        set => SetArgument("output_action", value);
    }

    /// <summary>
    /// The output_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OutputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("output_enabled");
        set => SetArgument("output_enabled", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for words_config in AwsBedrockGuardrailWordPolicyConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockGuardrailWordPolicyConfigBlockWordsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "words_config";

    /// <summary>
    /// The input_action attribute.
    /// </summary>
    public TerraformValue<string>? InputAction
    {
        get => GetArgument<TerraformValue<string>>("input_action");
        set => SetArgument("input_action", value);
    }

    /// <summary>
    /// The input_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("input_enabled");
        set => SetArgument("input_enabled", value);
    }

    /// <summary>
    /// The output_action attribute.
    /// </summary>
    public TerraformValue<string>? OutputAction
    {
        get => GetArgument<TerraformValue<string>>("output_action");
        set => SetArgument("output_action", value);
    }

    /// <summary>
    /// The output_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OutputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("output_enabled");
        set => SetArgument("output_enabled", value);
    }

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Represents a aws_bedrock_guardrail Terraform resource.
/// Manages a aws_bedrock_guardrail resource.
/// </summary>
public partial class AwsBedrockGuardrail(string name) : TerraformResource("aws_bedrock_guardrail", name)
{
    /// <summary>
    /// The blocked_input_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedInputMessaging is required")]
    public required TerraformValue<string> BlockedInputMessaging
    {
        get => GetArgument<TerraformValue<string>>("blocked_input_messaging");
        set => SetArgument("blocked_input_messaging", value);
    }

    /// <summary>
    /// The blocked_outputs_messaging attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockedOutputsMessaging is required")]
    public required TerraformValue<string> BlockedOutputsMessaging
    {
        get => GetArgument<TerraformValue<string>>("blocked_outputs_messaging");
        set => SetArgument("blocked_outputs_messaging", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The guardrail_arn attribute.
    /// </summary>
    public TerraformValue<string> GuardrailArn
        => AsReference("guardrail_arn");

    /// <summary>
    /// The guardrail_id attribute.
    /// </summary>
    public TerraformValue<string> GuardrailId
        => AsReference("guardrail_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// ContentPolicyConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailContentPolicyConfigBlock>? ContentPolicyConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailContentPolicyConfigBlock>>("content_policy_config");
        set => SetArgument("content_policy_config", value);
    }

    /// <summary>
    /// ContextualGroundingPolicyConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailContextualGroundingPolicyConfigBlock>? ContextualGroundingPolicyConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailContextualGroundingPolicyConfigBlock>>("contextual_grounding_policy_config");
        set => SetArgument("contextual_grounding_policy_config", value);
    }

    /// <summary>
    /// CrossRegionConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailCrossRegionConfigBlock>? CrossRegionConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailCrossRegionConfigBlock>>("cross_region_config");
        set => SetArgument("cross_region_config", value);
    }

    /// <summary>
    /// SensitiveInformationPolicyConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock>? SensitiveInformationPolicyConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailSensitiveInformationPolicyConfigBlock>>("sensitive_information_policy_config");
        set => SetArgument("sensitive_information_policy_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockGuardrailTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockGuardrailTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TopicPolicyConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailTopicPolicyConfigBlock>? TopicPolicyConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailTopicPolicyConfigBlock>>("topic_policy_config");
        set => SetArgument("topic_policy_config", value);
    }

    /// <summary>
    /// WordPolicyConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockGuardrailWordPolicyConfigBlock>? WordPolicyConfig
    {
        get => GetArgument<TerraformList<AwsBedrockGuardrailWordPolicyConfigBlock>>("word_policy_config");
        set => SetArgument("word_policy_config", value);
    }

}
