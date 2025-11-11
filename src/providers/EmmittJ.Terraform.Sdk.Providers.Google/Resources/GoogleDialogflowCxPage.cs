using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPageAdvancedSettingsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for entry_fulfillment in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPageEntryFulfillmentBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    [TerraformProperty("return_partial_responses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReturnPartialResponses { get; set; }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    [TerraformProperty("webhook")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Webhook { get; set; }

}

/// <summary>
/// Block type for event_handlers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPageEventHandlersBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the event to handle.
    /// </summary>
    [TerraformProperty("event")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Event { get; set; }


    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_flow")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_page")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Block type for form in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPageFormBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether Knowledge Connector is enabled or not.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;.
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    [TerraformProperty("target_flow")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;/pages/&amp;lt;PageID&amp;gt;.
    /// The page must be in the same host flow (the flow that owns this &#39;KnowledgeConnectorSettings&#39;).
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    [TerraformProperty("target_page")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxPageTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for transition_routes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPageTransitionRoutesBlock : TerraformBlockBase
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [TerraformProperty("condition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [TerraformProperty("intent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Intent { get; set; }


    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_flow")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_page")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_page resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxPage : TerraformResource
{
    public GoogleDialogflowCxPage(string name) : base("google_dialogflow_cx_page", name)
    {
    }

    /// <summary>
    /// The human-readable name of the page, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("language_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&#39;s transition route -&amp;gt; page&#39;s transition route group -&amp;gt; flow&#39;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    [TerraformProperty("transition_route_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// Block for advanced_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    [TerraformProperty("advanced_settings")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxPageAdvancedSettingsBlock>>? AdvancedSettings { get; set; }

    /// <summary>
    /// Block for entry_fulfillment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntryFulfillment block(s) allowed")]
    [TerraformProperty("entry_fulfillment")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxPageEntryFulfillmentBlock>>? EntryFulfillment { get; set; }

    /// <summary>
    /// Block for event_handlers.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_handlers")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxPageEventHandlersBlock>>? EventHandlers { get; set; }

    /// <summary>
    /// Block for form.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Form block(s) allowed")]
    [TerraformProperty("form")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxPageFormBlock>>? Form { get; set; }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    [TerraformProperty("knowledge_connector_settings")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock>>? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDialogflowCxPageTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for transition_routes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("transition_routes")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxPageTransitionRoutesBlock>>? TransitionRoutes { get; set; }

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
