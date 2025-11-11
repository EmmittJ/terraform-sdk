using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorLlmModelSettingsBlock
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    [TerraformPropertyName("model")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    [TerraformPropertyName("prompt_text")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PromptText { get; set; }

}

/// <summary>
/// Block type for model_parameter in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorModelParameterBlock
{
    /// <summary>
    /// The maximum number of tokens to generate.
    /// </summary>
    [TerraformPropertyName("max_decode_steps")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxDecodeSteps { get; set; }

    /// <summary>
    /// The temperature used for sampling. Temperature sampling occurs after both topP and topK have been applied.
    /// Valid range: [0.0, 1.0] Low temperature = less random. High temperature = more random.
    /// </summary>
    [TerraformPropertyName("temperature")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Temperature { get; set; }

    /// <summary>
    /// If set, the sampling process in each step is limited to the topK tokens with highest probabilities.
    /// Valid range: [1, 40] or 1000+. Small topK = less random. Large topK = more random.
    /// </summary>
    [TerraformPropertyName("top_k")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TopK { get; set; }

    /// <summary>
    /// If set, only the tokens comprising the top topP probability mass are considered.
    /// If both topP and topK are set, topP will be used for further refining candidates selected with topK.
    /// Valid range: (0.0, 1.0]. Small topP = less random. Large topP = more random.
    /// </summary>
    [TerraformPropertyName("top_p")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TopP { get; set; }

}

/// <summary>
/// Block type for placeholders in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorPlaceholdersBlock
{
    /// <summary>
    /// Unique ID used to map custom placeholder to parameters in fulfillment.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// Custom placeholder value in the prompt text.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for prompt_text in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorPromptTextBlock
{
    /// <summary>
    /// Text input which can be used for prompt or banned phrases.
    /// </summary>
    [TerraformPropertyName("text")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Text { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxGeneratorTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_generator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxGenerator : TerraformResource
{
    public GoogleDialogflowCxGenerator(string name) : base("google_dialogflow_cx_generator", name)
    {
    }

    /// <summary>
    /// The human-readable name of the generator, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The language to create generators for the following fields:
    /// * Generator.prompt_text.text
    /// If not specified, the agent&#39;s default language is used.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The agent to create a Generator for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    [TerraformPropertyName("llm_model_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>>? LlmModelSettings { get; set; }

    /// <summary>
    /// Block for model_parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelParameter block(s) allowed")]
    [TerraformPropertyName("model_parameter")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorModelParameterBlock>>? ModelParameter { get; set; }

    /// <summary>
    /// Block for placeholders.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("placeholders")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorPlaceholdersBlock>>? Placeholders { get; set; }

    /// <summary>
    /// Block for prompt_text.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PromptText is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PromptText block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromptText block(s) allowed")]
    [TerraformPropertyName("prompt_text")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorPromptTextBlock>>? PromptText { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxGeneratorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the Generator.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/generators/&amp;lt;Generator ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
