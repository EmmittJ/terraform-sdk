using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in AwsBedrockagentFlow.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "definition";

    /// <summary>
    /// ConnectionAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlock>? ConnectionAttribute
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlock>>("connection");
        set => SetArgument("connection", value);
    }

    /// <summary>
    /// NodeAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlock>? NodeAttribute
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlock>>("node");
        set => SetArgument("node", value);
    }

}

/// <summary>
/// Block type for connection in AwsBedrockagentFlowDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection";

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
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
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

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}

/// <summary>
/// Block type for configuration in AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// Conditional block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlockConditionalBlock>? Conditional
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlockConditionalBlock>>("conditional");
        set => SetArgument("conditional", value);
    }

    /// <summary>
    /// Data block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlockDataBlock>? Data
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlockDataBlock>>("data");
        set => SetArgument("data", value);
    }

}

/// <summary>
/// Block type for conditional in AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlockConditionalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional";

    /// <summary>
    /// The condition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    public required TerraformValue<string> Condition
    {
        get => GetArgument<TerraformValue<string>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for data in AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockConnectionAttributeBlockConfigurationBlockDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data";

    /// <summary>
    /// The source_output attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceOutput is required")]
    public required TerraformValue<string> SourceOutput
    {
        get => GetArgument<TerraformValue<string>>("source_output");
        set => SetArgument("source_output", value);
    }

    /// <summary>
    /// The target_input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetInput is required")]
    public required TerraformValue<string> TargetInput
    {
        get => GetArgument<TerraformValue<string>>("target_input");
        set => SetArgument("target_input", value);
    }

}

/// <summary>
/// Block type for node in AwsBedrockagentFlowDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node";

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

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Input block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockInputBlock>? Input
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockInputBlock>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockOutputBlock>? Output
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockOutputBlock>>("output");
        set => SetArgument("output", value);
    }

}

/// <summary>
/// Block type for configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// Agent block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockAgentBlock>? Agent
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockAgentBlock>>("agent");
        set => SetArgument("agent", value);
    }

    /// <summary>
    /// Collector block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockCollectorBlock>? Collector
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockCollectorBlock>>("collector");
        set => SetArgument("collector", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// InlineCode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockInlineCodeBlock>? InlineCode
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockInlineCodeBlock>>("inline_code");
        set => SetArgument("inline_code", value);
    }

    /// <summary>
    /// Input block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockInputBlock>? Input
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockInputBlock>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// Iterator block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockIteratorBlock>? Iterator
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockIteratorBlock>>("iterator");
        set => SetArgument("iterator", value);
    }

    /// <summary>
    /// KnowledgeBase block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlock>? KnowledgeBase
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlock>>("knowledge_base");
        set => SetArgument("knowledge_base", value);
    }

    /// <summary>
    /// LambdaFunction block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockLambdaFunctionBlock>? LambdaFunction
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockLambdaFunctionBlock>>("lambda_function");
        set => SetArgument("lambda_function", value);
    }

    /// <summary>
    /// Lex block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockLexBlock>? Lex
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockLexBlock>>("lex");
        set => SetArgument("lex", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockOutputBlock>? Output
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// Prompt block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlock>? Prompt
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlock>>("prompt");
        set => SetArgument("prompt", value);
    }

    /// <summary>
    /// Retrieval block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlock>? Retrieval
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlock>>("retrieval");
        set => SetArgument("retrieval", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

}

/// <summary>
/// Block type for agent in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockAgentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent";

    /// <summary>
    /// The agent_alias_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAliasArn is required")]
    public required TerraformValue<string> AgentAliasArn
    {
        get => GetArgument<TerraformValue<string>>("agent_alias_arn");
        set => SetArgument("agent_alias_arn", value);
    }

}

/// <summary>
/// Block type for collector in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockCollectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collector";

}

/// <summary>
/// Block type for condition in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for condition in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockConditionBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
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

}

/// <summary>
/// Block type for inline_code in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockInlineCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_code";

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<string> Code
    {
        get => GetArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Language is required")]
    public required TerraformValue<string> Language
    {
        get => GetArgument<TerraformValue<string>>("language");
        set => SetArgument("language", value);
    }

}

/// <summary>
/// Block type for input in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input";

}

/// <summary>
/// Block type for iterator in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockIteratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iterator";

}

/// <summary>
/// Block type for knowledge_base in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_base";

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    public required TerraformValue<string> KnowledgeBaseId
    {
        get => GetArgument<TerraformValue<string>>("knowledge_base_id");
        set => SetArgument("knowledge_base_id", value);
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
    }

    /// <summary>
    /// The number_of_results attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfResults
    {
        get => GetArgument<TerraformValue<double>>("number_of_results");
        set => SetArgument("number_of_results", value);
    }

    /// <summary>
    /// GuardrailConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockGuardrailConfigurationBlock>? GuardrailConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockGuardrailConfigurationBlock>>("guardrail_configuration");
        set => SetArgument("guardrail_configuration", value);
    }

    /// <summary>
    /// InferenceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlock>? InferenceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlock>>("inference_configuration");
        set => SetArgument("inference_configuration", value);
    }

}

/// <summary>
/// Block type for guardrail_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockGuardrailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guardrail_configuration";

    /// <summary>
    /// The guardrail_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailIdentifier is required")]
    public required TerraformValue<string> GuardrailIdentifier
    {
        get => GetArgument<TerraformValue<string>>("guardrail_identifier");
        set => SetArgument("guardrail_identifier", value);
    }

    /// <summary>
    /// The guardrail_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailVersion is required")]
    public required TerraformValue<string> GuardrailVersion
    {
        get => GetArgument<TerraformValue<string>>("guardrail_version");
        set => SetArgument("guardrail_version", value);
    }

}

/// <summary>
/// Block type for inference_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inference_configuration";

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for text in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockKnowledgeBaseBlockInferenceConfigurationBlockTextBlock : TerraformBlock
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
/// Block type for lambda_function in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockLambdaFunctionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

}

/// <summary>
/// Block type for lex in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockLexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lex";

    /// <summary>
    /// The bot_alias_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotAliasArn is required")]
    public required TerraformValue<string> BotAliasArn
    {
        get => GetArgument<TerraformValue<string>>("bot_alias_arn");
        set => SetArgument("bot_alias_arn", value);
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformValue<string> LocaleId
    {
        get => GetArgument<TerraformValue<string>>("locale_id");
        set => SetArgument("locale_id", value);
    }

}

/// <summary>
/// Block type for output in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

}

/// <summary>
/// Block type for prompt in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt";

    /// <summary>
    /// GuardrailConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockGuardrailConfigurationBlock>? GuardrailConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockGuardrailConfigurationBlock>>("guardrail_configuration");
        set => SetArgument("guardrail_configuration", value);
    }

    /// <summary>
    /// SourceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlock>? SourceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlock>>("source_configuration");
        set => SetArgument("source_configuration", value);
    }

}

/// <summary>
/// Block type for guardrail_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockGuardrailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guardrail_configuration";

    /// <summary>
    /// The guardrail_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailIdentifier is required")]
    public required TerraformValue<string> GuardrailIdentifier
    {
        get => GetArgument<TerraformValue<string>>("guardrail_identifier");
        set => SetArgument("guardrail_identifier", value);
    }

    /// <summary>
    /// The guardrail_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuardrailVersion is required")]
    public required TerraformValue<string> GuardrailVersion
    {
        get => GetArgument<TerraformValue<string>>("guardrail_version");
        set => SetArgument("guardrail_version", value);
    }

}

/// <summary>
/// Block type for source_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_configuration";

    /// <summary>
    /// Inline block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlock>? Inline
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlock>>("inline");
        set => SetArgument("inline", value);
    }

    /// <summary>
    /// Resource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockResourceBlock>? Resource
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockResourceBlock>>("resource");
        set => SetArgument("resource", value);
    }

}

/// <summary>
/// Block type for inline in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline";

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
    }

    /// <summary>
    /// The template_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateType is required")]
    public required TerraformValue<string> TemplateType
    {
        get => GetArgument<TerraformValue<string>>("template_type");
        set => SetArgument("template_type", value);
    }

    /// <summary>
    /// InferenceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlock>? InferenceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlock>>("inference_configuration");
        set => SetArgument("inference_configuration", value);
    }

    /// <summary>
    /// TemplateConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlock>? TemplateConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlock>>("template_configuration");
        set => SetArgument("template_configuration", value);
    }

}

/// <summary>
/// Block type for inference_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inference_configuration";

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for text in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockInferenceConfigurationBlockTextBlock : TerraformBlock
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
/// Block type for template_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_configuration";

    /// <summary>
    /// Chat block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock>? Chat
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock>>("chat");
        set => SetArgument("chat", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for chat in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "chat";

    /// <summary>
    /// InputVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockInputVariableBlock>? InputVariable
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockInputVariableBlock>>("input_variable");
        set => SetArgument("input_variable", value);
    }

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// System block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlock>? System
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlock>>("system");
        set => SetArgument("system", value);
    }

    /// <summary>
    /// ToolConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock>? ToolConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock>>("tool_configuration");
        set => SetArgument("tool_configuration", value);
    }

}

/// <summary>
/// Block type for input_variable in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockInputVariableBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for message in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// Content block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock>? Content
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock>>("content");
        set => SetArgument("content", value);
    }

}

/// <summary>
/// Block type for content in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock : TerraformBlock
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
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockMessageBlockContentBlockCachePointBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for system in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlock : TerraformBlock
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
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockSystemBlockCachePointBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for tool_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool_configuration";

    /// <summary>
    /// Tool block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock>? Tool
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock>>("tool");
        set => SetArgument("tool", value);
    }

    /// <summary>
    /// ToolChoice block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock>? ToolChoice
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock>>("tool_choice");
        set => SetArgument("tool_choice", value);
    }

}

/// <summary>
/// Block type for tool in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool";

    /// <summary>
    /// CachePoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

    /// <summary>
    /// ToolSpec block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock>? ToolSpec
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock>>("tool_spec");
        set => SetArgument("tool_spec", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockCachePointBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for tool_spec in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// InputSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlockInputSchemaBlock>? InputSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlockInputSchemaBlock>>("input_schema");
        set => SetArgument("input_schema", value);
    }

}

/// <summary>
/// Block type for input_schema in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolBlockToolSpecBlockInputSchemaBlock : TerraformBlock
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
/// Block type for tool_choice in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool_choice";

    /// <summary>
    /// Any block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAnyBlock>? Any
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAnyBlock>>("any");
        set => SetArgument("any", value);
    }

    /// <summary>
    /// Auto block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAutoBlock>? Auto
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAutoBlock>>("auto");
        set => SetArgument("auto", value);
    }

    /// <summary>
    /// Tool block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockToolBlock>? Tool
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockToolBlock>>("tool");
        set => SetArgument("tool", value);
    }

}

/// <summary>
/// Block type for any in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAnyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "any";

}

/// <summary>
/// Block type for auto in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockAutoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto";

}

/// <summary>
/// Block type for tool in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockChatBlockToolConfigurationBlockToolChoiceBlockToolBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for text in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// CachePoint block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlockCachePointBlock>? CachePoint
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlockCachePointBlock>>("cache_point");
        set => SetArgument("cache_point", value);
    }

    /// <summary>
    /// InputVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlockInputVariableBlock>? InputVariable
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlockInputVariableBlock>>("input_variable");
        set => SetArgument("input_variable", value);
    }

}

/// <summary>
/// Block type for cache_point in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlockCachePointBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for input_variable in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockInlineBlockTemplateConfigurationBlockTextBlockInputVariableBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for resource in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockPromptBlockSourceConfigurationBlockResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource";

    /// <summary>
    /// The prompt_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PromptArn is required")]
    public required TerraformValue<string> PromptArn
    {
        get => GetArgument<TerraformValue<string>>("prompt_arn");
        set => SetArgument("prompt_arn", value);
    }

}

/// <summary>
/// Block type for retrieval in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retrieval";

    /// <summary>
    /// ServiceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlock>? ServiceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlock>>("service_configuration");
        set => SetArgument("service_configuration", value);
    }

}

/// <summary>
/// Block type for service_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_configuration";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockRetrievalBlockServiceConfigurationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

}

/// <summary>
/// Block type for storage in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// ServiceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlock>? ServiceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlock>>("service_configuration");
        set => SetArgument("service_configuration", value);
    }

}

/// <summary>
/// Block type for service_configuration in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_configuration";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockConfigurationBlockStorageBlockServiceConfigurationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

}

/// <summary>
/// Block type for input in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input";

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformValue<string>? Category
    {
        get => GetArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
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
/// Block type for output in AwsBedrockagentFlowDefinitionBlockNodeAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentFlowDefinitionBlockNodeAttributeBlockOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

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
/// Block type for timeouts in AwsBedrockagentFlow.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentFlowTimeoutsBlock : TerraformBlock
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
/// Represents a aws_bedrockagent_flow Terraform resource.
/// Manages a aws_bedrockagent_flow resource.
/// </summary>
public partial class AwsBedrockagentFlow(string name) : TerraformResource("aws_bedrockagent_flow", name)
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
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
    /// Definition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentFlowDefinitionBlock>? Definition
    {
        get => GetArgument<TerraformList<AwsBedrockagentFlowDefinitionBlock>>("definition");
        set => SetArgument("definition", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentFlowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentFlowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
