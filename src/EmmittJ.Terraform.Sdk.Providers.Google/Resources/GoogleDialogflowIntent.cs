using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("followup_intent_info");
        this.DeclareOutput("name");
        this.DeclareOutput("root_followup_intent_name");
    }

    /// <summary>
    /// The name of the action associated with the intent.
    /// Note: The action name must not contain whitespaces.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The list of platforms for which the first responses will be copied from the messages in PLATFORM_UNSPECIFIED
    /// (i.e. default platform). Possible values: [&amp;quot;FACEBOOK&amp;quot;, &amp;quot;SLACK&amp;quot;, &amp;quot;TELEGRAM&amp;quot;, &amp;quot;KIK&amp;quot;, &amp;quot;SKYPE&amp;quot;, &amp;quot;LINE&amp;quot;, &amp;quot;VIBER&amp;quot;, &amp;quot;ACTIONS_ON_GOOGLE&amp;quot;, &amp;quot;GOOGLE_HANGOUTS&amp;quot;]
    /// </summary>
    public TerraformProperty<List<string>>? DefaultResponsePlatforms
    {
        get => GetProperty<TerraformProperty<List<string>>>("default_response_platforms");
        set => this.WithProperty("default_response_platforms", value);
    }

    /// <summary>
    /// The name of this intent to be displayed on the console.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The collection of event names that trigger the intent. If the collection of input contexts is not empty, all of
    /// the contexts must be present in the active user session for an event to trigger this intent. See the
    /// [events reference](https://cloud.google.com/dialogflow/docs/events-overview) for more details.
    /// </summary>
    public TerraformProperty<List<string>>? Events
    {
        get => GetProperty<TerraformProperty<List<string>>>("events");
        set => this.WithProperty("events", value);
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
    /// The list of context names required for this intent to be triggered.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/sessions/-/contexts/&amp;lt;Context ID&amp;gt;.
    /// </summary>
    public TerraformProperty<List<string>>? InputContextNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("input_context_names");
        set => this.WithProperty("input_context_names", value);
    }

    /// <summary>
    /// Indicates whether this is a fallback intent.
    /// </summary>
    public TerraformProperty<bool>? IsFallback
    {
        get => GetProperty<TerraformProperty<bool>>("is_fallback");
        set => this.WithProperty("is_fallback", value);
    }

    /// <summary>
    /// Indicates whether Machine Learning is disabled for the intent.
    /// Note: If mlDisabled setting is set to true, then this intent is not taken into account during inference in ML
    /// ONLY match mode. Also, auto-markup in the UI is turned off.
    /// </summary>
    public TerraformProperty<bool>? MlDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("ml_disabled");
        set => this.WithProperty("ml_disabled", value);
    }

    /// <summary>
    /// The unique identifier of the parent intent in the chain of followup intents.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? ParentFollowupIntentName
    {
        get => GetProperty<TerraformProperty<string>>("parent_followup_intent_name");
        set => this.WithProperty("parent_followup_intent_name", value);
    }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    ///   - If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds
    ///   to the Normal priority in the console.
    ///   - If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Indicates whether to delete all contexts in the current session when this intent is matched.
    /// </summary>
    public TerraformProperty<bool>? ResetContexts
    {
        get => GetProperty<TerraformProperty<bool>>("reset_contexts");
        set => this.WithProperty("reset_contexts", value);
    }

    /// <summary>
    /// Indicates whether webhooks are enabled for the intent.
    /// * WEBHOOK_STATE_ENABLED: Webhook is enabled in the agent and in the intent.
    /// * WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING: Webhook is enabled in the agent and in the intent. Also, each slot
    /// filling prompt is forwarded to the webhook. Possible values: [&amp;quot;WEBHOOK_STATE_ENABLED&amp;quot;, &amp;quot;WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? WebhookState
    {
        get => GetProperty<TerraformProperty<string>>("webhook_state");
        set => this.WithProperty("webhook_state", value);
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
