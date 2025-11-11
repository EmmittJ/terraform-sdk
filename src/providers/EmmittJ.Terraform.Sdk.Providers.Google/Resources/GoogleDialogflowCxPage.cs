using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageAdvancedSettingsBlock
{
}

/// <summary>
/// Block type for entry_fulfillment in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlock
{
    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    [TerraformPropertyName("return_partial_responses")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReturnPartialResponses { get; set; }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("webhook")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Webhook { get; set; }

}

/// <summary>
/// Block type for event_handlers in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlock
{
    /// <summary>
    /// The name of the event to handle.
    /// </summary>
    [TerraformPropertyName("event")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Event { get; set; }


    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("target_flow")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("target_page")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Block type for form in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlock
{
}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock
{
    /// <summary>
    /// Whether Knowledge Connector is enabled or not.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;.
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    [TerraformPropertyName("target_flow")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;/pages/&amp;lt;PageID&amp;gt;.
    /// The page must be in the same host flow (the flow that owns this &#39;KnowledgeConnectorSettings&#39;).
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    [TerraformPropertyName("target_page")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxPageTimeoutsBlock
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
/// Block type for transition_routes in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlock
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [TerraformPropertyName("condition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [TerraformPropertyName("intent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Intent { get; set; }


    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("target_flow")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("target_page")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_page resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxPage : TerraformResource
{
    public GoogleDialogflowCxPage(string name) : base("google_dialogflow_cx_page", name)
    {
    }

    /// <summary>
    /// The human-readable name of the page, unique within the agent.
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
    /// The language of the following fields in page:
    /// 
    /// Page.entry_fulfillment.messages
    /// Page.entry_fulfillment.conditional_cases
    /// Page.event_handlers.trigger_fulfillment.messages
    /// Page.event_handlers.trigger_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.messages
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.conditional_cases
    /// Page.transition_routes.trigger_fulfillment.messages
    /// Page.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&#39;s transition route -&amp;gt; page&#39;s transition route group -&amp;gt; flow&#39;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("transition_route_groups")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// Block for advanced_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    [TerraformPropertyName("advanced_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPageAdvancedSettingsBlock>>? AdvancedSettings { get; set; }

    /// <summary>
    /// Block for entry_fulfillment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntryFulfillment block(s) allowed")]
    [TerraformPropertyName("entry_fulfillment")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPageEntryFulfillmentBlock>>? EntryFulfillment { get; set; }

    /// <summary>
    /// Block for event_handlers.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_handlers")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPageEventHandlersBlock>>? EventHandlers { get; set; }

    /// <summary>
    /// Block for form.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Form block(s) allowed")]
    [TerraformPropertyName("form")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPageFormBlock>>? Form { get; set; }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    [TerraformPropertyName("knowledge_connector_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock>>? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxPageTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for transition_routes.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("transition_routes")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPageTransitionRoutesBlock>>? TransitionRoutes { get; set; }

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
