using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDialogflowIntent.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowIntentTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_intent Terraform resource.
/// Manages a google_dialogflow_intent resource.
/// </summary>
public partial class GoogleDialogflowIntent(string name) : TerraformResource("google_dialogflow_intent", name)
{
    /// <summary>
    /// The name of the action associated with the intent.
    /// Note: The action name must not contain whitespaces.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The list of platforms for which the first responses will be copied from the messages in PLATFORM_UNSPECIFIED
    /// (i.e. default platform). Possible values: [&amp;quot;FACEBOOK&amp;quot;, &amp;quot;SLACK&amp;quot;, &amp;quot;TELEGRAM&amp;quot;, &amp;quot;KIK&amp;quot;, &amp;quot;SKYPE&amp;quot;, &amp;quot;LINE&amp;quot;, &amp;quot;VIBER&amp;quot;, &amp;quot;ACTIONS_ON_GOOGLE&amp;quot;, &amp;quot;GOOGLE_HANGOUTS&amp;quot;]
    /// </summary>
    public TerraformList<string>? DefaultResponsePlatforms
    {
        get => GetArgument<TerraformList<string>>("default_response_platforms");
        set => SetArgument("default_response_platforms", value);
    }

    /// <summary>
    /// The name of this intent to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The collection of event names that trigger the intent. If the collection of input contexts is not empty, all of
    /// the contexts must be present in the active user session for an event to trigger this intent. See the
    /// [events reference](https://cloud.google.com/dialogflow/docs/events-overview) for more details.
    /// </summary>
    public TerraformList<string>? Events
    {
        get => GetArgument<TerraformList<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The list of context names required for this intent to be triggered.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/sessions/-/contexts/&amp;lt;Context ID&amp;gt;.
    /// </summary>
    public TerraformList<string>? InputContextNames
    {
        get => GetArgument<TerraformList<string>>("input_context_names");
        set => SetArgument("input_context_names", value);
    }

    /// <summary>
    /// Indicates whether this is a fallback intent.
    /// </summary>
    public TerraformValue<bool>? IsFallback
    {
        get => GetArgument<TerraformValue<bool>>("is_fallback");
        set => SetArgument("is_fallback", value);
    }

    /// <summary>
    /// Indicates whether Machine Learning is disabled for the intent.
    /// Note: If mlDisabled setting is set to true, then this intent is not taken into account during inference in ML
    /// ONLY match mode. Also, auto-markup in the UI is turned off.
    /// </summary>
    public TerraformValue<bool>? MlDisabled
    {
        get => GetArgument<TerraformValue<bool>>("ml_disabled");
        set => SetArgument("ml_disabled", value);
    }

    /// <summary>
    /// The unique identifier of the parent intent in the chain of followup intents.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? ParentFollowupIntentName
    {
        get => GetArgument<TerraformValue<string>>("parent_followup_intent_name");
        set => SetArgument("parent_followup_intent_name", value);
    }

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    ///   - If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds
    ///   to the Normal priority in the console.
    ///   - If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Indicates whether to delete all contexts in the current session when this intent is matched.
    /// </summary>
    public TerraformValue<bool>? ResetContexts
    {
        get => GetArgument<TerraformValue<bool>>("reset_contexts");
        set => SetArgument("reset_contexts", value);
    }

    /// <summary>
    /// Indicates whether webhooks are enabled for the intent.
    /// * WEBHOOK_STATE_ENABLED: Webhook is enabled in the agent and in the intent.
    /// * WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING: Webhook is enabled in the agent and in the intent. Also, each slot
    /// filling prompt is forwarded to the webhook. Possible values: [&amp;quot;WEBHOOK_STATE_ENABLED&amp;quot;, &amp;quot;WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WebhookState
    {
        get => GetArgument<TerraformValue<string>>("webhook_state");
        set => SetArgument("webhook_state", value);
    }

    /// <summary>
    /// Information about all followup intents that have this intent as a direct or indirect parent. We populate this field
    /// only in the output.
    /// </summary>
    public TerraformList<TerraformMap<object>> FollowupIntentInfo
        => AsReference("followup_intent_info");

    /// <summary>
    /// The unique identifier of this intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The unique identifier of the root intent in the chain of followup intents. It identifies the correct followup
    /// intents chain for this intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> RootFollowupIntentName
        => AsReference("root_followup_intent_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowIntentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowIntentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
