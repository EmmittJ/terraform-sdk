using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for llm_model_settings in GoogleDialogflowCxGenerator.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorLlmModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "llm_model_settings";

    /// <summary>
    /// The selected LLM model.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => GetArgument<TerraformValue<string>>("model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformValue<string>? PromptText
    {
        get => GetArgument<TerraformValue<string>>("prompt_text");
        set => SetArgument("prompt_text", value);
    }

}


/// <summary>
/// Block type for model_parameter in GoogleDialogflowCxGenerator.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorModelParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_parameter";

    /// <summary>
    /// The maximum number of tokens to generate.
    /// </summary>
    public TerraformValue<double>? MaxDecodeSteps
    {
        get => GetArgument<TerraformValue<double>>("max_decode_steps");
        set => SetArgument("max_decode_steps", value);
    }

    /// <summary>
    /// The temperature used for sampling. Temperature sampling occurs after both topP and topK have been applied.
    /// Valid range: [0.0, 1.0] Low temperature = less random. High temperature = more random.
    /// </summary>
    public TerraformValue<double>? Temperature
    {
        get => GetArgument<TerraformValue<double>>("temperature");
        set => SetArgument("temperature", value);
    }

    /// <summary>
    /// If set, the sampling process in each step is limited to the topK tokens with highest probabilities.
    /// Valid range: [1, 40] or 1000+. Small topK = less random. Large topK = more random.
    /// </summary>
    public TerraformValue<double>? TopK
    {
        get => GetArgument<TerraformValue<double>>("top_k");
        set => SetArgument("top_k", value);
    }

    /// <summary>
    /// If set, only the tokens comprising the top topP probability mass are considered.
    /// If both topP and topK are set, topP will be used for further refining candidates selected with topK.
    /// Valid range: (0.0, 1.0]. Small topP = less random. Large topP = more random.
    /// </summary>
    public TerraformValue<double>? TopP
    {
        get => GetArgument<TerraformValue<double>>("top_p");
        set => SetArgument("top_p", value);
    }

}


/// <summary>
/// Block type for placeholders in GoogleDialogflowCxGenerator.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorPlaceholdersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placeholders";

    /// <summary>
    /// Unique ID used to map custom placeholder to parameters in fulfillment.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Custom placeholder value in the prompt text.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for prompt_text in GoogleDialogflowCxGenerator.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorPromptTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt_text";

    /// <summary>
    /// Text input which can be used for prompt or banned phrases.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxGenerator.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxGeneratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_generator Terraform resource.
/// Manages a google_dialogflow_cx_generator resource.
/// </summary>
public partial class GoogleDialogflowCxGenerator(string name) : TerraformResource("google_dialogflow_cx_generator", name)
{
    /// <summary>
    /// The human-readable name of the generator, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language to create generators for the following fields:
    /// * Generator.prompt_text.text
    /// If not specified, the agent&#39;s default language is used.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The agent to create a Generator for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The unique identifier of the Generator.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/generators/&amp;lt;Generator ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// LlmModelSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>? LlmModelSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>>("llm_model_settings");
        set => SetArgument("llm_model_settings", value);
    }

    /// <summary>
    /// ModelParameter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelParameter block(s) allowed")]
    public TerraformList<GoogleDialogflowCxGeneratorModelParameterBlock>? ModelParameter
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGeneratorModelParameterBlock>>("model_parameter");
        set => SetArgument("model_parameter", value);
    }

    /// <summary>
    /// Placeholders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxGeneratorPlaceholdersBlock>? Placeholders
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGeneratorPlaceholdersBlock>>("placeholders");
        set => SetArgument("placeholders", value);
    }

    /// <summary>
    /// PromptText block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PromptText is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PromptText block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromptText block(s) allowed")]
    public required TerraformList<GoogleDialogflowCxGeneratorPromptTextBlock> PromptText
    {
        get => GetRequiredArgument<TerraformList<GoogleDialogflowCxGeneratorPromptTextBlock>>("prompt_text");
        set => SetArgument("prompt_text", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxGeneratorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxGeneratorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
