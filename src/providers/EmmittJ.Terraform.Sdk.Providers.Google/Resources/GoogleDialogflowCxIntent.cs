using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for parameters in GoogleDialogflowCxIntent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/&amp;lt;System Entity Type ID&amp;gt; for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt; for developer entity types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    public required TerraformValue<string> EntityType
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity_type");
        set => SetArgument("entity_type", value);
    }

    /// <summary>
    /// The unique identifier of the parameter. This field is used by training phrases to annotate their parts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Indicates whether the parameter represents a list of values.
    /// </summary>
    public TerraformValue<bool>? IsList
    {
        get => GetArgument<TerraformValue<bool>>("is_list");
        set => SetArgument("is_list", value);
    }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log. If redaction is enabled, the parameter content will be replaced by parameter name during logging.
    /// Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    public TerraformValue<bool>? Redact
    {
        get => GetArgument<TerraformValue<bool>>("redact");
        set => SetArgument("redact", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxIntent.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxIntentTimeoutsBlock : TerraformBlock
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
/// Block type for training_phrases in GoogleDialogflowCxIntent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentTrainingPhrasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "training_phrases";

    /// <summary>
    /// The unique identifier of the training phrase.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// Indicates how many times this example was added to the intent.
    /// </summary>
    public TerraformValue<double>? RepeatCount
    {
        get => GetArgument<TerraformValue<double>>("repeat_count");
        set => SetArgument("repeat_count", value);
    }

    /// <summary>
    /// Parts block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parts is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parts block(s) required")]
    public required TerraformList<GoogleDialogflowCxIntentTrainingPhrasesBlockPartsBlock> Parts
    {
        get => GetRequiredArgument<TerraformList<GoogleDialogflowCxIntentTrainingPhrasesBlockPartsBlock>>("parts");
        set => SetArgument("parts", value);
    }

}

/// <summary>
/// Block type for parts in GoogleDialogflowCxIntentTrainingPhrasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxIntentTrainingPhrasesBlockPartsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parts";

    /// <summary>
    /// The parameter used to annotate this part of the training phrase. This field is required for annotated parts of the training phrase.
    /// </summary>
    public TerraformValue<string>? ParameterId
    {
        get => GetArgument<TerraformValue<string>>("parameter_id");
        set => SetArgument("parameter_id", value);
    }

    /// <summary>
    /// The text for this part.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_intent Terraform resource.
/// Manages a google_dialogflow_cx_intent resource.
/// </summary>
public partial class GoogleDialogflowCxIntent(string name) : TerraformResource("google_dialogflow_cx_intent", name)
{
    /// <summary>
    /// Human readable description for better understanding an intent like its scope, content, result etc. Maximum character limit: 140 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The human-readable name of the intent, unique within the agent.
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Marks this as the [Default Negative Intent](https://cloud.google.com/dialogflow/cx/docs/concept/intent#negative) for an agent. When you create an agent, a Default Negative Intent is created automatically.
    /// The Default Negative Intent cannot be deleted; deleting the &#39;google_dialogflow_cx_intent&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_intent&#39; resources linked to the same agent with &#39;is_default_negative_intent = true&#39; because they will compete to control a single Default Negative Intent resource in GCP.
    /// </summary>
    public TerraformValue<bool>? IsDefaultNegativeIntent
    {
        get => GetArgument<TerraformValue<bool>>("is_default_negative_intent");
        set => SetArgument("is_default_negative_intent", value);
    }

    /// <summary>
    /// Marks this as the [Default Welcome Intent](https://cloud.google.com/dialogflow/cx/docs/concept/intent#welcome) for an agent. When you create an agent, a Default Welcome Intent is created automatically.
    /// The Default Welcome Intent cannot be deleted; deleting the &#39;google_dialogflow_cx_intent&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_intent&#39; resources linked to the same agent with &#39;is_default_welcome_intent = true&#39; because they will compete to control a single Default Welcome Intent resource in GCP.
    /// </summary>
    public TerraformValue<bool>? IsDefaultWelcomeIntent
    {
        get => GetArgument<TerraformValue<bool>>("is_default_welcome_intent");
        set => SetArgument("is_default_welcome_intent", value);
    }

    /// <summary>
    /// Indicates whether this is a fallback intent. Currently only default fallback intent is allowed in the agent, which is added upon agent creation.
    /// Adding training phrases to fallback intent is useful in the case of requests that are mistakenly matched, since training phrases assigned to fallback intents act as negative examples that triggers no-match event.
    /// To manage the fallback intent, set &#39;is_default_negative_intent = true&#39;
    /// </summary>
    public TerraformValue<bool>? IsFallback
    {
        get => GetArgument<TerraformValue<bool>>("is_fallback");
        set => SetArgument("is_fallback", value);
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
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The language of the following fields in intent:
    /// Intent.training_phrases.parts.text
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The agent to create an intent for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    /// If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds to the Normal priority in the console.
    /// If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The unique identifier of the intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxIntentParametersBlock>? Parameters
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxIntentParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxIntentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxIntentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrainingPhrases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxIntentTrainingPhrasesBlock>? TrainingPhrases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxIntentTrainingPhrasesBlock>>("training_phrases");
        set => SetArgument("training_phrases", value);
    }

}
