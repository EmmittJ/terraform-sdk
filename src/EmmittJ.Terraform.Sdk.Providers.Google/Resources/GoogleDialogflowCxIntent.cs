using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentParametersBlock : TerraformBlock
{
    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/&amp;lt;System Entity Type ID&amp;gt; for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt; for developer entity types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    public required TerraformProperty<string> EntityType
    {
        get => GetProperty<TerraformProperty<string>>("entity_type");
        set => WithProperty("entity_type", value);
    }

    /// <summary>
    /// The unique identifier of the parameter. This field is used by training phrases to annotate their parts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// Indicates whether the parameter represents a list of values.
    /// </summary>
    public TerraformProperty<bool>? IsList
    {
        get => GetProperty<TerraformProperty<bool>>("is_list");
        set => WithProperty("is_list", value);
    }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log. If redaction is enabled, the parameter content will be replaced by parameter name during logging.
    /// Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    public TerraformProperty<bool>? Redact
    {
        get => GetProperty<TerraformProperty<bool>>("redact");
        set => WithProperty("redact", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxIntentTimeoutsBlock : TerraformBlock
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
/// Block type for training_phrases in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentTrainingPhrasesBlock : TerraformBlock
{
    /// <summary>
    /// The unique identifier of the training phrase.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// Indicates how many times this example was added to the intent.
    /// </summary>
    public TerraformProperty<double>? RepeatCount
    {
        get => GetProperty<TerraformProperty<double>>("repeat_count");
        set => WithProperty("repeat_count", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_cx_intent resource.
/// </summary>
public class GoogleDialogflowCxIntent : TerraformResource
{
    public GoogleDialogflowCxIntent(string name) : base("google_dialogflow_cx_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Human readable description for better understanding an intent like its scope, content, result etc. Maximum character limit: 140 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The human-readable name of the intent, unique within the agent.
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
    /// Marks this as the [Default Negative Intent](https://cloud.google.com/dialogflow/cx/docs/concept/intent#negative) for an agent. When you create an agent, a Default Negative Intent is created automatically.
    /// The Default Negative Intent cannot be deleted; deleting the &#39;google_dialogflow_cx_intent&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_intent&#39; resources linked to the same agent with &#39;is_default_negative_intent = true&#39; because they will compete to control a single Default Negative Intent resource in GCP.
    /// </summary>
    public TerraformProperty<bool>? IsDefaultNegativeIntent
    {
        get => GetProperty<TerraformProperty<bool>>("is_default_negative_intent");
        set => this.WithProperty("is_default_negative_intent", value);
    }

    /// <summary>
    /// Marks this as the [Default Welcome Intent](https://cloud.google.com/dialogflow/cx/docs/concept/intent#welcome) for an agent. When you create an agent, a Default Welcome Intent is created automatically.
    /// The Default Welcome Intent cannot be deleted; deleting the &#39;google_dialogflow_cx_intent&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_intent&#39; resources linked to the same agent with &#39;is_default_welcome_intent = true&#39; because they will compete to control a single Default Welcome Intent resource in GCP.
    /// </summary>
    public TerraformProperty<bool>? IsDefaultWelcomeIntent
    {
        get => GetProperty<TerraformProperty<bool>>("is_default_welcome_intent");
        set => this.WithProperty("is_default_welcome_intent", value);
    }

    /// <summary>
    /// Indicates whether this is a fallback intent. Currently only default fallback intent is allowed in the agent, which is added upon agent creation.
    /// Adding training phrases to fallback intent is useful in the case of requests that are mistakenly matched, since training phrases assigned to fallback intents act as negative examples that triggers no-match event.
    /// To manage the fallback intent, set &#39;is_default_negative_intent = true&#39;
    /// </summary>
    public TerraformProperty<bool>? IsFallback
    {
        get => GetProperty<TerraformProperty<bool>>("is_fallback");
        set => this.WithProperty("is_fallback", value);
    }

    /// <summary>
    /// The key/value metadata to label an intent. Labels can contain lowercase letters, digits and the symbols &#39;-&#39; and &#39;_&#39;. International characters are allowed, including letters from unicase alphabets. Keys must start with a letter. Keys and values can be no longer than 63 characters and no more than 128 bytes.
    /// Prefix &amp;quot;sys-&amp;quot; is reserved for Dialogflow defined labels. Currently allowed Dialogflow defined labels include: * sys-head * sys-contextual The above labels do not require value. &amp;quot;sys-head&amp;quot; means the intent is a head intent. &amp;quot;sys.contextual&amp;quot; means the intent is a contextual intent.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The language of the following fields in intent:
    /// Intent.training_phrases.parts.text
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create an intent for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    /// If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds to the Normal priority in the console.
    /// If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxIntentParametersBlock>? Parameters
    {
        get => GetProperty<List<GoogleDialogflowCxIntentParametersBlock>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxIntentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxIntentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for training_phrases.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxIntentTrainingPhrasesBlock>? TrainingPhrases
    {
        get => GetProperty<List<GoogleDialogflowCxIntentTrainingPhrasesBlock>>("training_phrases");
        set => this.WithProperty("training_phrases", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique identifier of the intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
