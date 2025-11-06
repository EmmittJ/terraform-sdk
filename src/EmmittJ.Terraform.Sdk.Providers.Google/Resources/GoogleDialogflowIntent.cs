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
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of platforms for which the first responses will be copied from the messages in PLATFORM_UNSPECIFIED
    /// (i.e. default platform). Possible values: [&amp;quot;FACEBOOK&amp;quot;, &amp;quot;SLACK&amp;quot;, &amp;quot;TELEGRAM&amp;quot;, &amp;quot;KIK&amp;quot;, &amp;quot;SKYPE&amp;quot;, &amp;quot;LINE&amp;quot;, &amp;quot;VIBER&amp;quot;, &amp;quot;ACTIONS_ON_GOOGLE&amp;quot;, &amp;quot;GOOGLE_HANGOUTS&amp;quot;]
    /// </summary>
    public List<string>? DefaultResponsePlatforms
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("default_response_platforms")?.Value;
        set => this.WithProperty("default_response_platforms", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name of this intent to be displayed on the console.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collection of event names that trigger the intent. If the collection of input contexts is not empty, all of
    /// the contexts must be present in the active user session for an event to trigger this intent. See the
    /// [events reference](https://cloud.google.com/dialogflow/docs/events-overview) for more details.
    /// </summary>
    public List<string>? Events
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("events")?.Value;
        set => this.WithProperty("events", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of context names required for this intent to be triggered.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/sessions/-/contexts/&amp;lt;Context ID&amp;gt;.
    /// </summary>
    public List<string>? InputContextNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("input_context_names")?.Value;
        set => this.WithProperty("input_context_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Indicates whether this is a fallback intent.
    /// </summary>
    public bool? IsFallback
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_fallback")?.Value;
        set => this.WithProperty("is_fallback", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Indicates whether Machine Learning is disabled for the intent.
    /// Note: If mlDisabled setting is set to true, then this intent is not taken into account during inference in ML
    /// ONLY match mode. Also, auto-markup in the UI is turned off.
    /// </summary>
    public bool? MlDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ml_disabled")?.Value;
        set => this.WithProperty("ml_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The unique identifier of the parent intent in the chain of followup intents.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public string? ParentFollowupIntentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_followup_intent_name")?.Value;
        set => this.WithProperty("parent_followup_intent_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    ///   - If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds
    ///   to the Normal priority in the console.
    ///   - If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates whether to delete all contexts in the current session when this intent is matched.
    /// </summary>
    public bool? ResetContexts
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("reset_contexts")?.Value;
        set => this.WithProperty("reset_contexts", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Indicates whether webhooks are enabled for the intent.
    /// * WEBHOOK_STATE_ENABLED: Webhook is enabled in the agent and in the intent.
    /// * WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING: Webhook is enabled in the agent and in the intent. Also, each slot
    /// filling prompt is forwarded to the webhook. Possible values: [&amp;quot;WEBHOOK_STATE_ENABLED&amp;quot;, &amp;quot;WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING&amp;quot;]
    /// </summary>
    public string? WebhookState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("webhook_state")?.Value;
        set => this.WithProperty("webhook_state", value == null ? null : new TerraformLiteralProperty<string>(value));
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
