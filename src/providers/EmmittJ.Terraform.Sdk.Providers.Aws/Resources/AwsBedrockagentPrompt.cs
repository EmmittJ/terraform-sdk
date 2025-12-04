using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for variant in AwsBedrockagentPrompt.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variant";

    /// <summary>
    /// The additional_model_request_fields attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalModelRequestFields
    {
        get => GetArgument<TerraformValue<string>>("additional_model_request_fields");
        set => SetArgument("additional_model_request_fields", value);
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    public TerraformValue<string>? ModelId
    {
        get => GetArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
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
    /// The template_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateType is required")]
    public required TerraformValue<string> TemplateType
    {
        get => GetRequiredArgument<TerraformValue<string>>("template_type");
        set => SetArgument("template_type", value);
    }

    /// <summary>
    /// GenAiResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockGenAiResourceBlock>? GenAiResource
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockGenAiResourceBlock>>("gen_ai_resource");
        set => SetArgument("gen_ai_resource", value);
    }

    /// <summary>
    /// InferenceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockInferenceConfigurationBlock>? InferenceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockInferenceConfigurationBlock>>("inference_configuration");
        set => SetArgument("inference_configuration", value);
    }

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// TemplateConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlock>? TemplateConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlock>>("template_configuration");
        set => SetArgument("template_configuration", value);
    }

}

/// <summary>
/// Block type for gen_ai_resource in AwsBedrockagentPromptVariantBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockGenAiResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gen_ai_resource";

    /// <summary>
    /// Agent block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockGenAiResourceBlockAgentBlock>? Agent
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockGenAiResourceBlockAgentBlock>>("agent");
        set => SetArgument("agent", value);
    }

}

/// <summary>
/// Block type for agent in AwsBedrockagentPromptVariantBlockGenAiResourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockGenAiResourceBlockAgentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent";

    /// <summary>
    /// The agent_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentIdentifier is required")]
    public required TerraformValue<string> AgentIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent_identifier");
        set => SetArgument("agent_identifier", value);
    }

}

/// <summary>
/// Block type for inference_configuration in AwsBedrockagentPromptVariantBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockInferenceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inference_configuration";

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockInferenceConfigurationBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockInferenceConfigurationBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for text in AwsBedrockagentPromptVariantBlockInferenceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockInferenceConfigurationBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// The max_tokens attribute.
    /// </summary>
    public TerraformValue<double>? MaxTokens
    {
        get => GetArgument<TerraformValue<double>>("max_tokens");
        set => SetArgument("max_tokens", value);
    }

    /// <summary>
    /// The stop_sequences attribute.
    /// </summary>
    public TerraformList<string>? StopSequences
    {
        get => GetArgument<TerraformList<string>>("stop_sequences");
        set => SetArgument("stop_sequences", value);
    }

    /// <summary>
    /// The temperature attribute.
    /// </summary>
    public TerraformValue<double>? Temperature
    {
        get => GetArgument<TerraformValue<double>>("temperature");
        set => SetArgument("temperature", value);
    }

    /// <summary>
    /// The top_p attribute.
    /// </summary>
    public TerraformValue<double>? TopP
    {
        get => GetArgument<TerraformValue<double>>("top_p");
        set => SetArgument("top_p", value);
    }

}

/// <summary>
/// Block type for metadata in AwsBedrockagentPromptVariantBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
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
/// Block type for template_configuration in AwsBedrockagentPromptVariantBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_configuration";

    /// <summary>
    /// Chat block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock>? Chat
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock>>("chat");
        set => SetArgument("chat", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for chat in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "chat";

    /// <summary>
    /// InputVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockInputVariableBlock>? InputVariable
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockInputVariableBlock>>("input_variable");
        set => SetArgument("input_variable", value);
    }

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// System block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlock>? System
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlock>>("system");
        set => SetArgument("system", value);
    }

    /// <summary>
    /// ToolConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock>? ToolConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock>>("tool_configuration");
        set => SetArgument("tool_configuration", value);
    }

}

/// <summary>
/// Block type for input_variable in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockInputVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_variable";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for message in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetRequiredArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// Content block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock>? Content
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock>>("content");
        set => SetArgument("content", value);
    }

}

/// <summary>
/// Block type for content in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content";

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// CachePoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlockCachePointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_point";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for system in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "system";

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// CachePoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockSystemBlockCachePointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_point";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for tool_configuration in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool_configuration";

    /// <summary>
    /// Tool block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock>? Tool
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock>>("tool");
        set => SetArgument("tool", value);
    }

    /// <summary>
    /// ToolChoice block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock>? ToolChoice
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock>>("tool_choice");
        set => SetArgument("tool_choice", value);
    }

}

/// <summary>
/// Block type for tool in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool";

    /// <summary>
    /// CachePoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

    /// <summary>
    /// ToolSpec block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock>? ToolSpec
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock>>("tool_spec");
        set => SetArgument("tool_spec", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockCachePointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_point";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for tool_spec in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool_spec";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// InputSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlockInputSchemaBlock>? InputSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlockInputSchemaBlock>>("input_schema");
        set => SetArgument("input_schema", value);
    }

}

/// <summary>
/// Block type for input_schema in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlockInputSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_schema";

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string>? Json
    {
        get => GetArgument<TerraformValue<string>>("json");
        set => SetArgument("json", value);
    }

}

/// <summary>
/// Block type for tool_choice in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool_choice";

    /// <summary>
    /// Any block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAnyBlock>? Any
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAnyBlock>>("any");
        set => SetArgument("any", value);
    }

    /// <summary>
    /// Auto block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAutoBlock>? Auto
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAutoBlock>>("auto");
        set => SetArgument("auto", value);
    }

    /// <summary>
    /// Tool block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockToolBlock>? Tool
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockToolBlock>>("tool");
        set => SetArgument("tool", value);
    }

}

/// <summary>
/// Block type for any in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAnyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "any";

}

/// <summary>
/// Block type for auto in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAutoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto";

}

/// <summary>
/// Block type for tool in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockToolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for text in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

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
    /// CachePoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

    /// <summary>
    /// InputVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlockInputVariableBlock>? InputVariable
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlockInputVariableBlock>>("input_variable");
        set => SetArgument("input_variable", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlockCachePointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_point";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for input_variable in AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlockTemplateConfigurationBlockTextBlockInputVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_variable";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagent_prompt Terraform resource.
/// Manages a aws_bedrockagent_prompt resource.
/// </summary>
public partial class AwsBedrockagentPrompt(string name) : TerraformResource("aws_bedrockagent_prompt", name)
{
    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? CustomerEncryptionKeyArn
    {
        get => GetArgument<TerraformValue<string>>("customer_encryption_key_arn");
        set => SetArgument("customer_encryption_key_arn", value);
    }

    /// <summary>
    /// The default_variant attribute.
    /// </summary>
    public TerraformValue<string>? DefaultVariant
    {
        get => GetArgument<TerraformValue<string>>("default_variant");
        set => SetArgument("default_variant", value);
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
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// Variant block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentPromptVariantBlock>? Variant
    {
        get => GetArgument<TerraformList<AwsBedrockagentPromptVariantBlock>>("variant");
        set => SetArgument("variant", value);
    }

}
