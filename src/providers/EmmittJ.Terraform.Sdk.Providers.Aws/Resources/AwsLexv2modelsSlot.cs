using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiple_values_setting in AwsLexv2modelsSlot.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotMultipleValuesSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiple_values_setting";

    /// <summary>
    /// The allow_multiple_values attribute.
    /// </summary>
    public TerraformValue<bool>? AllowMultipleValues
    {
        get => GetArgument<TerraformValue<bool>>("allow_multiple_values");
        set => SetArgument("allow_multiple_values", value);
    }

}


/// <summary>
/// Block type for obfuscation_setting in AwsLexv2modelsSlot.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotObfuscationSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "obfuscation_setting";

    /// <summary>
    /// The obfuscation_setting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObfuscationSettingType is required")]
    public required TerraformValue<string> ObfuscationSettingType
    {
        get => GetRequiredArgument<TerraformValue<string>>("obfuscation_setting_type");
        set => SetArgument("obfuscation_setting_type", value);
    }

}


/// <summary>
/// Block type for sub_slot_setting in AwsLexv2modelsSlot.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sub_slot_setting";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// SlotSpecification block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlock>? SlotSpecification
    {
        get => GetArgument<TerraformSet<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlock>>("slot_specification");
        set => SetArgument("slot_specification", value);
    }

}

/// <summary>
/// Block type for slot_specification in AwsLexv2modelsSlotSubSlotSettingBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slot_specification";

    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformValue<string> MapBlockKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("map_block_key");
        set => SetArgument("map_block_key", value);
    }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotTypeId is required")]
    public required TerraformValue<string> SlotTypeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("slot_type_id");
        set => SetArgument("slot_type_id", value);
    }

    /// <summary>
    /// ValueElicitationSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock>? ValueElicitationSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock>>("value_elicitation_setting");
        set => SetArgument("value_elicitation_setting", value);
    }

}

/// <summary>
/// Block type for value_elicitation_setting in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_elicitation_setting";

    /// <summary>
    /// DefaultValueSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlock>? DefaultValueSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlock>>("default_value_specification");
        set => SetArgument("default_value_specification", value);
    }

    /// <summary>
    /// PromptSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlock>? PromptSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlock>>("prompt_specification");
        set => SetArgument("prompt_specification", value);
    }

    /// <summary>
    /// SampleUtterance block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockSampleUtteranceBlock>? SampleUtterance
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockSampleUtteranceBlock>>("sample_utterance");
        set => SetArgument("sample_utterance", value);
    }

    /// <summary>
    /// WaitAndContinueSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlock>? WaitAndContinueSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlock>>("wait_and_continue_specification");
        set => SetArgument("wait_and_continue_specification", value);
    }

}

/// <summary>
/// Block type for default_value_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_value_specification";

    /// <summary>
    /// DefaultValueList block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlockDefaultValueListBlock>? DefaultValueList
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlockDefaultValueListBlock>>("default_value_list");
        set => SetArgument("default_value_list", value);
    }

}

/// <summary>
/// Block type for default_value_list in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockDefaultValueSpecificationBlockDefaultValueListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_value_list";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultValue is required")]
    public required TerraformValue<string> DefaultValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
    }

}

/// <summary>
/// Block type for prompt_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt_specification";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetries is required")]
    public required TerraformValue<double> MaxRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The message_selection_strategy attribute.
    /// </summary>
    public TerraformValue<string>? MessageSelectionStrategy
    {
        get => GetArgument<TerraformValue<string>>("message_selection_strategy");
        set => SetArgument("message_selection_strategy", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

    /// <summary>
    /// PromptAttemptsSpecification block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock>? PromptAttemptsSpecification
    {
        get => GetArgument<TerraformSet<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock>>("prompt_attempts_specification");
        set => SetArgument("prompt_attempts_specification", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for prompt_attempts_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt_attempts_specification";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformValue<string> MapBlockKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("map_block_key");
        set => SetArgument("map_block_key", value);
    }

    /// <summary>
    /// AllowedInputTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAllowedInputTypesBlock>? AllowedInputTypes
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAllowedInputTypesBlock>>("allowed_input_types");
        set => SetArgument("allowed_input_types", value);
    }

    /// <summary>
    /// AudioAndDtmfInputSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock>? AudioAndDtmfInputSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock>>("audio_and_dtmf_input_specification");
        set => SetArgument("audio_and_dtmf_input_specification", value);
    }

    /// <summary>
    /// TextInputSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockTextInputSpecificationBlock>? TextInputSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockTextInputSpecificationBlock>>("text_input_specification");
        set => SetArgument("text_input_specification", value);
    }

}

/// <summary>
/// Block type for allowed_input_types in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAllowedInputTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_input_types";

    /// <summary>
    /// The allow_audio_input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAudioInput is required")]
    public required TerraformValue<bool> AllowAudioInput
    {
        get => GetRequiredArgument<TerraformValue<bool>>("allow_audio_input");
        set => SetArgument("allow_audio_input", value);
    }

    /// <summary>
    /// The allow_dtmf_input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDtmfInput is required")]
    public required TerraformValue<bool> AllowDtmfInput
    {
        get => GetRequiredArgument<TerraformValue<bool>>("allow_dtmf_input");
        set => SetArgument("allow_dtmf_input", value);
    }

}

/// <summary>
/// Block type for audio_and_dtmf_input_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_and_dtmf_input_specification";

    /// <summary>
    /// The start_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTimeoutMs is required")]
    public required TerraformValue<double> StartTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_timeout_ms");
        set => SetArgument("start_timeout_ms", value);
    }

    /// <summary>
    /// AudioSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockAudioSpecificationBlock>? AudioSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockAudioSpecificationBlock>>("audio_specification");
        set => SetArgument("audio_specification", value);
    }

    /// <summary>
    /// DtmfSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockDtmfSpecificationBlock>? DtmfSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockDtmfSpecificationBlock>>("dtmf_specification");
        set => SetArgument("dtmf_specification", value);
    }

}

/// <summary>
/// Block type for audio_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockAudioSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_specification";

    /// <summary>
    /// The end_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTimeoutMs is required")]
    public required TerraformValue<double> EndTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_timeout_ms");
        set => SetArgument("end_timeout_ms", value);
    }

    /// <summary>
    /// The max_length_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxLengthMs is required")]
    public required TerraformValue<double> MaxLengthMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_length_ms");
        set => SetArgument("max_length_ms", value);
    }

}

/// <summary>
/// Block type for dtmf_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockDtmfSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dtmf_specification";

    /// <summary>
    /// The deletion_character attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeletionCharacter is required")]
    public required TerraformValue<string> DeletionCharacter
    {
        get => GetRequiredArgument<TerraformValue<string>>("deletion_character");
        set => SetArgument("deletion_character", value);
    }

    /// <summary>
    /// The end_character attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndCharacter is required")]
    public required TerraformValue<string> EndCharacter
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_character");
        set => SetArgument("end_character", value);
    }

    /// <summary>
    /// The end_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTimeoutMs is required")]
    public required TerraformValue<double> EndTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_timeout_ms");
        set => SetArgument("end_timeout_ms", value);
    }

    /// <summary>
    /// The max_length attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxLength is required")]
    public required TerraformValue<double> MaxLength
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_length");
        set => SetArgument("max_length", value);
    }

}

/// <summary>
/// Block type for text_input_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockTextInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_input_specification";

    /// <summary>
    /// The start_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTimeoutMs is required")]
    public required TerraformValue<double> StartTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_timeout_ms");
        set => SetArgument("start_timeout_ms", value);
    }

}

/// <summary>
/// Block type for sample_utterance in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockSampleUtteranceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sample_utterance";

    /// <summary>
    /// The utterance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Utterance is required")]
    public required TerraformValue<string> Utterance
    {
        get => GetRequiredArgument<TerraformValue<string>>("utterance");
        set => SetArgument("utterance", value);
    }

}

/// <summary>
/// Block type for wait_and_continue_specification in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wait_and_continue_specification";

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool>? Active
    {
        get => GetArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// ContinueResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock>? ContinueResponse
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock>>("continue_response");
        set => SetArgument("continue_response", value);
    }

    /// <summary>
    /// StillWaitingResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock>? StillWaitingResponse
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock>>("still_waiting_response");
        set => SetArgument("still_waiting_response", value);
    }

    /// <summary>
    /// WaitingResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock>? WaitingResponse
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock>>("waiting_response");
        set => SetArgument("waiting_response", value);
    }

}

/// <summary>
/// Block type for continue_response in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "continue_response";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for still_waiting_response in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "still_waiting_response";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// The frequency_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyInSeconds is required")]
    public required TerraformValue<double> FrequencyInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("frequency_in_seconds");
        set => SetArgument("frequency_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutInSeconds is required")]
    public required TerraformValue<double> TimeoutInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for waiting_response in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "waiting_response";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlockSlotSpecificationBlockValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLexv2modelsSlot.
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsSlotTimeoutsBlock : TerraformBlock
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
/// Block type for value_elicitation_setting in AwsLexv2modelsSlot.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_elicitation_setting";

    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    public required TerraformValue<string> SlotConstraint
    {
        get => GetRequiredArgument<TerraformValue<string>>("slot_constraint");
        set => SetArgument("slot_constraint", value);
    }

    /// <summary>
    /// DefaultValueSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlock>? DefaultValueSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlock>>("default_value_specification");
        set => SetArgument("default_value_specification", value);
    }

    /// <summary>
    /// PromptSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlock>? PromptSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlock>>("prompt_specification");
        set => SetArgument("prompt_specification", value);
    }

    /// <summary>
    /// SampleUtterance block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockSampleUtteranceBlock>? SampleUtterance
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockSampleUtteranceBlock>>("sample_utterance");
        set => SetArgument("sample_utterance", value);
    }

    /// <summary>
    /// SlotResolutionSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockSlotResolutionSettingBlock>? SlotResolutionSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockSlotResolutionSettingBlock>>("slot_resolution_setting");
        set => SetArgument("slot_resolution_setting", value);
    }

    /// <summary>
    /// WaitAndContinueSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlock>? WaitAndContinueSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlock>>("wait_and_continue_specification");
        set => SetArgument("wait_and_continue_specification", value);
    }

}

/// <summary>
/// Block type for default_value_specification in AwsLexv2modelsSlotValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_value_specification";

    /// <summary>
    /// DefaultValueList block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlockDefaultValueListBlock>? DefaultValueList
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlockDefaultValueListBlock>>("default_value_list");
        set => SetArgument("default_value_list", value);
    }

}

/// <summary>
/// Block type for default_value_list in AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockDefaultValueSpecificationBlockDefaultValueListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_value_list";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultValue is required")]
    public required TerraformValue<string> DefaultValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
    }

}

/// <summary>
/// Block type for prompt_specification in AwsLexv2modelsSlotValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt_specification";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetries is required")]
    public required TerraformValue<double> MaxRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The message_selection_strategy attribute.
    /// </summary>
    public TerraformValue<string>? MessageSelectionStrategy
    {
        get => GetArgument<TerraformValue<string>>("message_selection_strategy");
        set => SetArgument("message_selection_strategy", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

    /// <summary>
    /// PromptAttemptsSpecification block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock>? PromptAttemptsSpecification
    {
        get => GetArgument<TerraformSet<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock>>("prompt_attempts_specification");
        set => SetArgument("prompt_attempts_specification", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for prompt_attempts_specification in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt_attempts_specification";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformValue<string> MapBlockKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("map_block_key");
        set => SetArgument("map_block_key", value);
    }

    /// <summary>
    /// AllowedInputTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAllowedInputTypesBlock>? AllowedInputTypes
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAllowedInputTypesBlock>>("allowed_input_types");
        set => SetArgument("allowed_input_types", value);
    }

    /// <summary>
    /// AudioAndDtmfInputSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock>? AudioAndDtmfInputSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock>>("audio_and_dtmf_input_specification");
        set => SetArgument("audio_and_dtmf_input_specification", value);
    }

    /// <summary>
    /// TextInputSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockTextInputSpecificationBlock>? TextInputSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockTextInputSpecificationBlock>>("text_input_specification");
        set => SetArgument("text_input_specification", value);
    }

}

/// <summary>
/// Block type for allowed_input_types in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAllowedInputTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_input_types";

    /// <summary>
    /// The allow_audio_input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAudioInput is required")]
    public required TerraformValue<bool> AllowAudioInput
    {
        get => GetRequiredArgument<TerraformValue<bool>>("allow_audio_input");
        set => SetArgument("allow_audio_input", value);
    }

    /// <summary>
    /// The allow_dtmf_input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDtmfInput is required")]
    public required TerraformValue<bool> AllowDtmfInput
    {
        get => GetRequiredArgument<TerraformValue<bool>>("allow_dtmf_input");
        set => SetArgument("allow_dtmf_input", value);
    }

}

/// <summary>
/// Block type for audio_and_dtmf_input_specification in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_and_dtmf_input_specification";

    /// <summary>
    /// The start_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTimeoutMs is required")]
    public required TerraformValue<double> StartTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_timeout_ms");
        set => SetArgument("start_timeout_ms", value);
    }

    /// <summary>
    /// AudioSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockAudioSpecificationBlock>? AudioSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockAudioSpecificationBlock>>("audio_specification");
        set => SetArgument("audio_specification", value);
    }

    /// <summary>
    /// DtmfSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockDtmfSpecificationBlock>? DtmfSpecification
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockDtmfSpecificationBlock>>("dtmf_specification");
        set => SetArgument("dtmf_specification", value);
    }

}

/// <summary>
/// Block type for audio_specification in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockAudioSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_specification";

    /// <summary>
    /// The end_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTimeoutMs is required")]
    public required TerraformValue<double> EndTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_timeout_ms");
        set => SetArgument("end_timeout_ms", value);
    }

    /// <summary>
    /// The max_length_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxLengthMs is required")]
    public required TerraformValue<double> MaxLengthMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_length_ms");
        set => SetArgument("max_length_ms", value);
    }

}

/// <summary>
/// Block type for dtmf_specification in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockAudioAndDtmfInputSpecificationBlockDtmfSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dtmf_specification";

    /// <summary>
    /// The deletion_character attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeletionCharacter is required")]
    public required TerraformValue<string> DeletionCharacter
    {
        get => GetRequiredArgument<TerraformValue<string>>("deletion_character");
        set => SetArgument("deletion_character", value);
    }

    /// <summary>
    /// The end_character attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndCharacter is required")]
    public required TerraformValue<string> EndCharacter
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_character");
        set => SetArgument("end_character", value);
    }

    /// <summary>
    /// The end_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTimeoutMs is required")]
    public required TerraformValue<double> EndTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_timeout_ms");
        set => SetArgument("end_timeout_ms", value);
    }

    /// <summary>
    /// The max_length attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxLength is required")]
    public required TerraformValue<double> MaxLength
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_length");
        set => SetArgument("max_length", value);
    }

}

/// <summary>
/// Block type for text_input_specification in AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockPromptSpecificationBlockPromptAttemptsSpecificationBlockTextInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_input_specification";

    /// <summary>
    /// The start_timeout_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTimeoutMs is required")]
    public required TerraformValue<double> StartTimeoutMs
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_timeout_ms");
        set => SetArgument("start_timeout_ms", value);
    }

}

/// <summary>
/// Block type for sample_utterance in AwsLexv2modelsSlotValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockSampleUtteranceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sample_utterance";

    /// <summary>
    /// The utterance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Utterance is required")]
    public required TerraformValue<string> Utterance
    {
        get => GetRequiredArgument<TerraformValue<string>>("utterance");
        set => SetArgument("utterance", value);
    }

}

/// <summary>
/// Block type for slot_resolution_setting in AwsLexv2modelsSlotValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockSlotResolutionSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slot_resolution_setting";

    /// <summary>
    /// The slot_resolution_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotResolutionStrategy is required")]
    public required TerraformValue<string> SlotResolutionStrategy
    {
        get => GetRequiredArgument<TerraformValue<string>>("slot_resolution_strategy");
        set => SetArgument("slot_resolution_strategy", value);
    }

}

/// <summary>
/// Block type for wait_and_continue_specification in AwsLexv2modelsSlotValueElicitationSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wait_and_continue_specification";

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool>? Active
    {
        get => GetArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// ContinueResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock>? ContinueResponse
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock>>("continue_response");
        set => SetArgument("continue_response", value);
    }

    /// <summary>
    /// StillWaitingResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock>? StillWaitingResponse
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock>>("still_waiting_response");
        set => SetArgument("still_waiting_response", value);
    }

    /// <summary>
    /// WaitingResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock>? WaitingResponse
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock>>("waiting_response");
        set => SetArgument("waiting_response", value);
    }

}

/// <summary>
/// Block type for continue_response in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "continue_response";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockContinueResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for still_waiting_response in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "still_waiting_response";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// The frequency_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyInSeconds is required")]
    public required TerraformValue<double> FrequencyInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("frequency_in_seconds");
        set => SetArgument("frequency_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutInSeconds is required")]
    public required TerraformValue<double> TimeoutInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockStillWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for waiting_response in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "waiting_response";

    /// <summary>
    /// The allow_interrupt attribute.
    /// </summary>
    public TerraformValue<bool>? AllowInterrupt
    {
        get => GetArgument<TerraformValue<bool>>("allow_interrupt");
        set => SetArgument("allow_interrupt", value);
    }

    /// <summary>
    /// MessageGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock>? MessageGroup
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock>>("message_group");
        set => SetArgument("message_group", value);
    }

}

/// <summary>
/// Block type for message_group in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_group";

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Variation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock>? Variation
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock>>("variation");
        set => SetArgument("variation", value);
    }

}

/// <summary>
/// Block type for message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockMessageBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for variation in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variation";

    /// <summary>
    /// CustomPayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>? CustomPayload
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock>>("custom_payload");
        set => SetArgument("custom_payload", value);
    }

    /// <summary>
    /// ImageResponseCard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>? ImageResponseCard
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock>>("image_response_card");
        set => SetArgument("image_response_card", value);
    }

    /// <summary>
    /// PlainTextMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>? PlainTextMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock>>("plain_text_message");
        set => SetArgument("plain_text_message", value);
    }

    /// <summary>
    /// SsmlMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>? SsmlMessage
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock>>("ssml_message");
        set => SetArgument("ssml_message", value);
    }

}

/// <summary>
/// Block type for custom_payload in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockCustomPayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_payload";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_response_card in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_response_card";

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string>? ImageUrl
    {
        get => GetArgument<TerraformValue<string>>("image_url");
        set => SetArgument("image_url", value);
    }

    /// <summary>
    /// The subtitle attribute.
    /// </summary>
    public TerraformValue<string>? Subtitle
    {
        get => GetArgument<TerraformValue<string>>("subtitle");
        set => SetArgument("subtitle", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Button block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>? Button
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock>>("button");
        set => SetArgument("button", value);
    }

}

/// <summary>
/// Block type for button in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockImageResponseCardBlockButtonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "button";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for plain_text_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockPlainTextMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plain_text_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ssml_message in AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlockWaitAndContinueSpecificationBlockWaitingResponseBlockMessageGroupBlockVariationBlockSsmlMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssml_message";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_lexv2models_slot Terraform resource.
/// Manages a aws_lexv2models_slot resource.
/// </summary>
public partial class AwsLexv2modelsSlot(string name) : TerraformResource("aws_lexv2models_slot", name)
{
    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformValue<string> BotId
    {
        get => GetRequiredArgument<TerraformValue<string>>("bot_id");
        set => SetArgument("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformValue<string> BotVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("bot_version");
        set => SetArgument("bot_version", value);
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
    /// The intent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentId is required")]
    public required TerraformValue<string> IntentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("intent_id");
        set => SetArgument("intent_id", value);
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformValue<string> LocaleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("locale_id");
        set => SetArgument("locale_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    public TerraformValue<string> SlotTypeId
    {
        get => GetArgument<TerraformValue<string>>("slot_type_id") ?? CreateReference("slot_type_id");
        set => SetArgument("slot_type_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    public TerraformValue<string> SlotId
        => CreateReference("slot_id");

    /// <summary>
    /// MultipleValuesSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotMultipleValuesSettingBlock>? MultipleValuesSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotMultipleValuesSettingBlock>>("multiple_values_setting");
        set => SetArgument("multiple_values_setting", value);
    }

    /// <summary>
    /// ObfuscationSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotObfuscationSettingBlock>? ObfuscationSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotObfuscationSettingBlock>>("obfuscation_setting");
        set => SetArgument("obfuscation_setting", value);
    }

    /// <summary>
    /// SubSlotSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlock>? SubSlotSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotSubSlotSettingBlock>>("sub_slot_setting");
        set => SetArgument("sub_slot_setting", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLexv2modelsSlotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexv2modelsSlotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ValueElicitationSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlock>? ValueElicitationSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlock>>("value_elicitation_setting");
        set => SetArgument("value_elicitation_setting", value);
    }

}
