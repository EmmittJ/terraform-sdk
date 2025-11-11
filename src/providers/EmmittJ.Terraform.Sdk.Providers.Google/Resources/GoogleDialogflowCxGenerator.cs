using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGeneratorLlmModelSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    [TerraformProperty("model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    [TerraformProperty("prompt_text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PromptText { get; set; }

}

/// <summary>
/// Block type for model_parameter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGeneratorModelParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum number of tokens to generate.
    /// </summary>
    [TerraformProperty("max_decode_steps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxDecodeSteps { get; set; }

    /// <summary>
    /// The temperature used for sampling. Temperature sampling occurs after both topP and topK have been applied.
    /// Valid range: [0.0, 1.0] Low temperature = less random. High temperature = more random.
    /// </summary>
    [TerraformProperty("temperature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Temperature { get; set; }

    /// <summary>
    /// If set, the sampling process in each step is limited to the topK tokens with highest probabilities.
    /// Valid range: [1, 40] or 1000+. Small topK = less random. Large topK = more random.
    /// </summary>
    [TerraformProperty("top_k")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TopK { get; set; }

    /// <summary>
    /// If set, only the tokens comprising the top topP probability mass are considered.
    /// If both topP and topK are set, topP will be used for further refining candidates selected with topK.
    /// Valid range: (0.0, 1.0]. Small topP = less random. Large topP = more random.
    /// </summary>
    [TerraformProperty("top_p")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TopP { get; set; }

}

/// <summary>
/// Block type for placeholders in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGeneratorPlaceholdersBlock : TerraformBlockBase
{
    /// <summary>
    /// Unique ID used to map custom placeholder to parameters in fulfillment.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// Custom placeholder value in the prompt text.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for prompt_text in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGeneratorPromptTextBlock : TerraformBlockBase
{
    /// <summary>
    /// Text input which can be used for prompt or banned phrases.
    /// </summary>
    [TerraformProperty("text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Text { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxGeneratorTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_generator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxGenerator : TerraformResource
{
    public GoogleDialogflowCxGenerator(string name) : base("google_dialogflow_cx_generator", name)
    {
    }

    /// <summary>
    /// The human-readable name of the generator, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The language to create generators for the following fields:
    /// * Generator.prompt_text.text
    /// If not specified, the agent&#39;s default language is used.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The agent to create a Generator for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    [TerraformProperty("llm_model_settings")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>>? LlmModelSettings { get; set; }

    /// <summary>
    /// Block for model_parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelParameter block(s) allowed")]
    [TerraformProperty("model_parameter")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorModelParameterBlock>>? ModelParameter { get; set; }

    /// <summary>
    /// Block for placeholders.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("placeholders")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorPlaceholdersBlock>>? Placeholders { get; set; }

    /// <summary>
    /// Block for prompt_text.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PromptText is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PromptText block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromptText block(s) allowed")]
    [TerraformProperty("prompt_text")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxGeneratorPromptTextBlock>>? PromptText { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDialogflowCxGeneratorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the Generator.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/generators/&amp;lt;Generator ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
