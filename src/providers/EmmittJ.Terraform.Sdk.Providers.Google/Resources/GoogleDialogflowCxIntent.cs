using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentParametersBlock
{
    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/&amp;lt;System Entity Type ID&amp;gt; for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt; for developer entity types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    [TerraformPropertyName("entity_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EntityType { get; set; }

    /// <summary>
    /// The unique identifier of the parameter. This field is used by training phrases to annotate their parts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Indicates whether the parameter represents a list of values.
    /// </summary>
    [TerraformPropertyName("is_list")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsList { get; set; }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log. If redaction is enabled, the parameter content will be replaced by parameter name during logging.
    /// Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    [TerraformPropertyName("redact")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Redact { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxIntentTimeoutsBlock
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
/// Block type for training_phrases in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentTrainingPhrasesBlock
{

    /// <summary>
    /// Indicates how many times this example was added to the intent.
    /// </summary>
    [TerraformPropertyName("repeat_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RepeatCount { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_intent resource.
/// </summary>
public class GoogleDialogflowCxIntent : TerraformResource
{
    public GoogleDialogflowCxIntent(string name) : base("google_dialogflow_cx_intent", name)
    {
    }

    /// <summary>
    /// Human readable description for better understanding an intent like its scope, content, result etc. Maximum character limit: 140 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The human-readable name of the intent, unique within the agent.
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
    /// Marks this as the [Default Negative Intent](https://cloud.google.com/dialogflow/cx/docs/concept/intent#negative) for an agent. When you create an agent, a Default Negative Intent is created automatically.
    /// The Default Negative Intent cannot be deleted; deleting the &#39;google_dialogflow_cx_intent&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_intent&#39; resources linked to the same agent with &#39;is_default_negative_intent = true&#39; because they will compete to control a single Default Negative Intent resource in GCP.
    /// </summary>
    [TerraformPropertyName("is_default_negative_intent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsDefaultNegativeIntent { get; set; }

    /// <summary>
    /// Marks this as the [Default Welcome Intent](https://cloud.google.com/dialogflow/cx/docs/concept/intent#welcome) for an agent. When you create an agent, a Default Welcome Intent is created automatically.
    /// The Default Welcome Intent cannot be deleted; deleting the &#39;google_dialogflow_cx_intent&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_intent&#39; resources linked to the same agent with &#39;is_default_welcome_intent = true&#39; because they will compete to control a single Default Welcome Intent resource in GCP.
    /// </summary>
    [TerraformPropertyName("is_default_welcome_intent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsDefaultWelcomeIntent { get; set; }

    /// <summary>
    /// Indicates whether this is a fallback intent. Currently only default fallback intent is allowed in the agent, which is added upon agent creation.
    /// Adding training phrases to fallback intent is useful in the case of requests that are mistakenly matched, since training phrases assigned to fallback intents act as negative examples that triggers no-match event.
    /// To manage the fallback intent, set &#39;is_default_negative_intent = true&#39;
    /// </summary>
    [TerraformPropertyName("is_fallback")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsFallback { get; set; }

    /// <summary>
    /// The key/value metadata to label an intent. Labels can contain lowercase letters, digits and the symbols &#39;-&#39; and &#39;_&#39;. International characters are allowed, including letters from unicase alphabets. Keys must start with a letter. Keys and values can be no longer than 63 characters and no more than 128 bytes.
    /// Prefix &amp;quot;sys-&amp;quot; is reserved for Dialogflow defined labels. Currently allowed Dialogflow defined labels include: * sys-head * sys-contextual The above labels do not require value. &amp;quot;sys-head&amp;quot; means the intent is a head intent. &amp;quot;sys.contextual&amp;quot; means the intent is a contextual intent.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The language of the following fields in intent:
    /// Intent.training_phrases.parts.text
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The agent to create an intent for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    /// If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds to the Normal priority in the console.
    /// If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("parameters")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxIntentParametersBlock>>? Parameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxIntentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for training_phrases.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("training_phrases")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxIntentTrainingPhrasesBlock>>? TrainingPhrases { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The unique identifier of the intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
