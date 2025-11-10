using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorLlmModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        set => SetProperty("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformProperty<string>? PromptText
    {
        set => SetProperty("prompt_text", value);
    }

}

/// <summary>
/// Block type for model_parameter in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorModelParameterBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of tokens to generate.
    /// </summary>
    public TerraformProperty<double>? MaxDecodeSteps
    {
        set => SetProperty("max_decode_steps", value);
    }

    /// <summary>
    /// The temperature used for sampling. Temperature sampling occurs after both topP and topK have been applied.
    /// Valid range: [0.0, 1.0] Low temperature = less random. High temperature = more random.
    /// </summary>
    public TerraformProperty<double>? Temperature
    {
        set => SetProperty("temperature", value);
    }

    /// <summary>
    /// If set, the sampling process in each step is limited to the topK tokens with highest probabilities.
    /// Valid range: [1, 40] or 1000+. Small topK = less random. Large topK = more random.
    /// </summary>
    public TerraformProperty<double>? TopK
    {
        set => SetProperty("top_k", value);
    }

    /// <summary>
    /// If set, only the tokens comprising the top topP probability mass are considered.
    /// If both topP and topK are set, topP will be used for further refining candidates selected with topK.
    /// Valid range: (0.0, 1.0]. Small topP = less random. Large topP = more random.
    /// </summary>
    public TerraformProperty<double>? TopP
    {
        set => SetProperty("top_p", value);
    }

}

/// <summary>
/// Block type for placeholders in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorPlaceholdersBlock : TerraformBlock
{
    /// <summary>
    /// Unique ID used to map custom placeholder to parameters in fulfillment.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Custom placeholder value in the prompt text.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for prompt_text in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGeneratorPromptTextBlock : TerraformBlock
{
    /// <summary>
    /// Text input which can be used for prompt or banned phrases.
    /// </summary>
    public TerraformProperty<string>? Text
    {
        set => SetProperty("text", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxGeneratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_cx_generator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxGenerator : TerraformResource
{
    public GoogleDialogflowCxGenerator(string name) : base("google_dialogflow_cx_generator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("language_code");
        SetOutput("parent");
    }

    /// <summary>
    /// The human-readable name of the generator, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The language to create generators for the following fields:
    /// * Generator.prompt_text.text
    /// If not specified, the agent&#39;s default language is used.
    /// </summary>
    public TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a Generator for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public List<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>? LlmModelSettings
    {
        set => SetProperty("llm_model_settings", value);
    }

    /// <summary>
    /// Block for model_parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelParameter block(s) allowed")]
    public List<GoogleDialogflowCxGeneratorModelParameterBlock>? ModelParameter
    {
        set => SetProperty("model_parameter", value);
    }

    /// <summary>
    /// Block for placeholders.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxGeneratorPlaceholdersBlock>? Placeholders
    {
        set => SetProperty("placeholders", value);
    }

    /// <summary>
    /// Block for prompt_text.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PromptText is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PromptText block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromptText block(s) allowed")]
    public List<GoogleDialogflowCxGeneratorPromptTextBlock>? PromptText
    {
        set => SetProperty("prompt_text", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxGeneratorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the Generator.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/generators/&amp;lt;Generator ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
