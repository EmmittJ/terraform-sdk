using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowIntentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_intent resource.
/// </summary>
public class GoogleDialogflowIntent : TerraformResource
{
    public GoogleDialogflowIntent(string name) : base("google_dialogflow_intent", name)
    {
    }

    /// <summary>
    /// The name of the action associated with the intent.
    /// Note: The action name must not contain whitespaces.
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Action { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "action");

    /// <summary>
    /// The list of platforms for which the first responses will be copied from the messages in PLATFORM_UNSPECIFIED
    /// (i.e. default platform). Possible values: [&amp;quot;FACEBOOK&amp;quot;, &amp;quot;SLACK&amp;quot;, &amp;quot;TELEGRAM&amp;quot;, &amp;quot;KIK&amp;quot;, &amp;quot;SKYPE&amp;quot;, &amp;quot;LINE&amp;quot;, &amp;quot;VIBER&amp;quot;, &amp;quot;ACTIONS_ON_GOOGLE&amp;quot;, &amp;quot;GOOGLE_HANGOUTS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("default_response_platforms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DefaultResponsePlatforms { get; set; }

    /// <summary>
    /// The name of this intent to be displayed on the console.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The collection of event names that trigger the intent. If the collection of input contexts is not empty, all of
    /// the contexts must be present in the active user session for an event to trigger this intent. See the
    /// [events reference](https://cloud.google.com/dialogflow/docs/events-overview) for more details.
    /// </summary>
    [TerraformPropertyName("events")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Events { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The list of context names required for this intent to be triggered.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/sessions/-/contexts/&amp;lt;Context ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("input_context_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InputContextNames { get; set; }

    /// <summary>
    /// Indicates whether this is a fallback intent.
    /// </summary>
    [TerraformPropertyName("is_fallback")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IsFallback { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_fallback");

    /// <summary>
    /// Indicates whether Machine Learning is disabled for the intent.
    /// Note: If mlDisabled setting is set to true, then this intent is not taken into account during inference in ML
    /// ONLY match mode. Also, auto-markup in the UI is turned off.
    /// </summary>
    [TerraformPropertyName("ml_disabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MlDisabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ml_disabled");

    /// <summary>
    /// The unique identifier of the parent intent in the chain of followup intents.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent_followup_intent_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParentFollowupIntentName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_followup_intent_name");

    /// <summary>
    /// The priority of this intent. Higher numbers represent higher priorities.
    ///   - If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds
    ///   to the Normal priority in the console.
    ///   - If the supplied value is negative, the intent is ignored in runtime detect intent requests.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Priority { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "priority");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Indicates whether to delete all contexts in the current session when this intent is matched.
    /// </summary>
    [TerraformPropertyName("reset_contexts")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ResetContexts { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reset_contexts");

    /// <summary>
    /// Indicates whether webhooks are enabled for the intent.
    /// * WEBHOOK_STATE_ENABLED: Webhook is enabled in the agent and in the intent.
    /// * WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING: Webhook is enabled in the agent and in the intent. Also, each slot
    /// filling prompt is forwarded to the webhook. Possible values: [&amp;quot;WEBHOOK_STATE_ENABLED&amp;quot;, &amp;quot;WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING&amp;quot;]
    /// </summary>
    [TerraformPropertyName("webhook_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WebhookState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "webhook_state");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowIntentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Information about all followup intents that have this intent as a direct or indirect parent. We populate this field
    /// only in the output.
    /// </summary>
    [TerraformPropertyName("followup_intent_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FollowupIntentInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "followup_intent_info");

    /// <summary>
    /// The unique identifier of this intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The unique identifier of the root intent in the chain of followup intents. It identifies the correct followup
    /// intents chain for this intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("root_followup_intent_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootFollowupIntentName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_followup_intent_name");

}
