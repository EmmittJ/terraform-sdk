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
        get => GetProperty<TerraformProperty<string>>("model");
        set => WithProperty("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformProperty<string>? PromptText
    {
        get => GetProperty<TerraformProperty<string>>("prompt_text");
        set => WithProperty("prompt_text", value);
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
        get => GetProperty<TerraformProperty<double>>("max_decode_steps");
        set => WithProperty("max_decode_steps", value);
    }

    /// <summary>
    /// The temperature used for sampling. Temperature sampling occurs after both topP and topK have been applied.
    /// Valid range: [0.0, 1.0] Low temperature = less random. High temperature = more random.
    /// </summary>
    public TerraformProperty<double>? Temperature
    {
        get => GetProperty<TerraformProperty<double>>("temperature");
        set => WithProperty("temperature", value);
    }

    /// <summary>
    /// If set, the sampling process in each step is limited to the topK tokens with highest probabilities.
    /// Valid range: [1, 40] or 1000+. Small topK = less random. Large topK = more random.
    /// </summary>
    public TerraformProperty<double>? TopK
    {
        get => GetProperty<TerraformProperty<double>>("top_k");
        set => WithProperty("top_k", value);
    }

    /// <summary>
    /// If set, only the tokens comprising the top topP probability mass are considered.
    /// If both topP and topK are set, topP will be used for further refining candidates selected with topK.
    /// Valid range: (0.0, 1.0]. Small topP = less random. Large topP = more random.
    /// </summary>
    public TerraformProperty<double>? TopP
    {
        get => GetProperty<TerraformProperty<double>>("top_p");
        set => WithProperty("top_p", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// Custom placeholder value in the prompt text.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("text");
        set => WithProperty("text", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_cx_generator resource.
/// </summary>
public class GoogleDialogflowCxGenerator : TerraformResource
{
    public GoogleDialogflowCxGenerator(string name) : base("google_dialogflow_cx_generator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The human-readable name of the generator, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language to create generators for the following fields:
    /// * Generator.prompt_text.text
    /// If not specified, the agent&#39;s default language is used.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a Generator for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public List<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>? LlmModelSettings
    {
        get => GetProperty<List<GoogleDialogflowCxGeneratorLlmModelSettingsBlock>>("llm_model_settings");
        set => this.WithProperty("llm_model_settings", value);
    }

    /// <summary>
    /// Block for model_parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelParameter block(s) allowed")]
    public List<GoogleDialogflowCxGeneratorModelParameterBlock>? ModelParameter
    {
        get => GetProperty<List<GoogleDialogflowCxGeneratorModelParameterBlock>>("model_parameter");
        set => this.WithProperty("model_parameter", value);
    }

    /// <summary>
    /// Block for placeholders.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxGeneratorPlaceholdersBlock>? Placeholders
    {
        get => GetProperty<List<GoogleDialogflowCxGeneratorPlaceholdersBlock>>("placeholders");
        set => this.WithProperty("placeholders", value);
    }

    /// <summary>
    /// Block for prompt_text.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PromptText block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromptText block(s) allowed")]
    public List<GoogleDialogflowCxGeneratorPromptTextBlock>? PromptText
    {
        get => GetProperty<List<GoogleDialogflowCxGeneratorPromptTextBlock>>("prompt_text");
        set => this.WithProperty("prompt_text", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxGeneratorTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxGeneratorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the Generator.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/generators/&amp;lt;Generator ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
