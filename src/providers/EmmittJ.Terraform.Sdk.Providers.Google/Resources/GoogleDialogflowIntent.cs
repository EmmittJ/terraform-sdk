using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowIntentTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_intent resource.
/// </summary>
public class GoogleDialogflowIntent : TerraformResource
{
    public GoogleDialogflowIntent(string name) : base("google_dialogflow_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("followup_intent_info");
        SetOutput("name");
        SetOutput("root_followup_intent_name");
        SetOutput("action");
        SetOutput("default_response_platforms");
        SetOutput("display_name");
        SetOutput("events");
        SetOutput("id");
        SetOutput("input_context_names");
        SetOutput("is_fallback");
        SetOutput("ml_disabled");
        SetOutput("parent_followup_intent_name");
        SetOutput("priority");
        SetOutput("project");
        SetOutput("reset_contexts");
        SetOutput("webhook_state");
    }

    /// <summary>
    /// The name of the action associated with the intent.
    /// Note: The action name must not contain whitespaces.
    /// </summary>
    public TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The list of platforms for which the first responses will be copied from the messages in PLATFORM_UNSPECIFIED
    /// (i.e. default platform). Possible values: [&amp;quot;FACEBOOK&amp;quot;, &amp;quot;SLACK&amp;quot;, &amp;quot;TELEGRAM&amp;quot;, &amp;quot;KIK&amp;quot;, &amp;quot;SKYPE&amp;quot;, &amp;quot;LINE&amp;quot;, &amp;quot;VIBER&amp;quot;, &amp;quot;ACTIONS_ON_GOOGLE&amp;quot;, &amp;quot;GOOGLE_HANGOUTS&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>> DefaultResponsePlatforms
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("default_response_platforms");
        set => SetProperty("default_response_platforms", value);
    }

    /// <summary>
    /// The name of this intent to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The collection of event names that trigger the intent. If the collection of input contexts is not empty, all of
    /// the contexts must be present in the active user session for an event to trigger this intent. See the
    /// [events reference](https://cloud.google.com/dialogflow/docs/events-overview) for more details.
    /// </summary>
    public List<TerraformProperty<string>> Events
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("events");
        set => SetProperty("events", value);
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
    /// The list of context names required for this intent to be triggered.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/sessions/-/contexts/&amp;lt;Context ID&amp;gt;.
    /// </summary>
    public List<TerraformProperty<string>> InputContextNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("input_context_names");
        set => SetProperty("input_context_names", value);
    }

    /// <summary>
    /// Indicates whether this is a fallback intent.
    /// </summary>
    public TerraformProperty<bool> IsFallback
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_fallback");
        set => SetProperty("is_fallback", value);
    }

    /// <summary>
    /// Indicates whether Machine Learning is disabled for the intent.
    /// Note: If mlDisabled setting is set to true, then this intent is not taken into account during inference in ML
    /// ONLY match mode. Also, auto-markup in the UI is turned off.
    /// </summary>
    public TerraformProperty<bool> MlDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ml_disabled");
        set => SetProperty("ml_disabled", value);
    }

    /// <summary>
    /// The unique identifier of the parent intent in the chain of followup intents.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string> ParentFollowupIntentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_followup_intent_name");
        set => SetProperty("parent_followup_intent_name", value);
    }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    ///   - If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds
    ///   to the Normal priority in the console.
    ///   - If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Indicates whether to delete all contexts in the current session when this intent is matched.
    /// </summary>
    public TerraformProperty<bool> ResetContexts
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("reset_contexts");
        set => SetProperty("reset_contexts", value);
    }

    /// <summary>
    /// Indicates whether webhooks are enabled for the intent.
    /// * WEBHOOK_STATE_ENABLED: Webhook is enabled in the agent and in the intent.
    /// * WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING: Webhook is enabled in the agent and in the intent. Also, each slot
    /// filling prompt is forwarded to the webhook. Possible values: [&amp;quot;WEBHOOK_STATE_ENABLED&amp;quot;, &amp;quot;WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING&amp;quot;]
    /// </summary>
    public TerraformProperty<string> WebhookState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("webhook_state");
        set => SetProperty("webhook_state", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowIntentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Information about all followup intents that have this intent as a direct or indirect parent. We populate this field
    /// only in the output.
    /// </summary>
    public TerraformExpression FollowupIntentInfo => this["followup_intent_info"];

    /// <summary>
    /// The unique identifier of this intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The unique identifier of the root intent in the chain of followup intents. It identifies the correct followup
    /// intents chain for this intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformExpression RootFollowupIntentName => this["root_followup_intent_name"];

}
