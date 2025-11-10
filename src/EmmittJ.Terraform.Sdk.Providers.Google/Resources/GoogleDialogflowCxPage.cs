using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageAdvancedSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for entry_fulfillment in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformProperty<bool>? ReturnPartialResponses
    {
        get => GetProperty<TerraformProperty<bool>>("return_partial_responses");
        set => WithProperty("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => WithProperty("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Webhook
    {
        get => GetProperty<TerraformProperty<string>>("webhook");
        set => WithProperty("webhook", value);
    }

}

/// <summary>
/// Block type for event_handlers in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlock : TerraformBlock
{
    /// <summary>
    /// The name of the event to handle.
    /// </summary>
    public TerraformProperty<string>? Event
    {
        get => GetProperty<TerraformProperty<string>>("event");
        set => WithProperty("event", value);
    }

    /// <summary>
    /// The unique identifier of this event handler.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? TargetFlow
    {
        get => GetProperty<TerraformProperty<string>>("target_flow");
        set => WithProperty("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? TargetPage
    {
        get => GetProperty<TerraformProperty<string>>("target_page");
        set => WithProperty("target_page", value);
    }

}

/// <summary>
/// Block type for form in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlock : TerraformBlock
{
}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Whether Knowledge Connector is enabled or not.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The target flow to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;.
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    public TerraformProperty<string>? TargetFlow
    {
        get => GetProperty<TerraformProperty<string>>("target_flow");
        set => WithProperty("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;/pages/&amp;lt;PageID&amp;gt;.
    /// The page must be in the same host flow (the flow that owns this &#39;KnowledgeConnectorSettings&#39;).
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    public TerraformProperty<string>? TargetPage
    {
        get => GetProperty<TerraformProperty<string>>("target_page");
        set => WithProperty("target_page", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxPageTimeoutsBlock : TerraformBlock
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
/// Block type for transition_routes in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlock : TerraformBlock
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        get => GetProperty<TerraformProperty<string>>("condition");
        set => WithProperty("condition", value);
    }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    public TerraformProperty<string>? Intent
    {
        get => GetProperty<TerraformProperty<string>>("intent");
        set => WithProperty("intent", value);
    }

    /// <summary>
    /// The unique identifier of this transition route.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? TargetFlow
    {
        get => GetProperty<TerraformProperty<string>>("target_flow");
        set => WithProperty("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? TargetPage
    {
        get => GetProperty<TerraformProperty<string>>("target_page");
        set => WithProperty("target_page", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_cx_page resource.
/// </summary>
public class GoogleDialogflowCxPage : TerraformResource
{
    public GoogleDialogflowCxPage(string name) : base("google_dialogflow_cx_page", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The human-readable name of the page, unique within the agent.
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
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&#39;s transition route -&amp;gt; page&#39;s transition route group -&amp;gt; flow&#39;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    public List<TerraformProperty<string>>? TransitionRouteGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("transition_route_groups");
        set => this.WithProperty("transition_route_groups", value);
    }

    /// <summary>
    /// Block for advanced_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public List<GoogleDialogflowCxPageAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetProperty<List<GoogleDialogflowCxPageAdvancedSettingsBlock>>("advanced_settings");
        set => this.WithProperty("advanced_settings", value);
    }

    /// <summary>
    /// Block for entry_fulfillment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntryFulfillment block(s) allowed")]
    public List<GoogleDialogflowCxPageEntryFulfillmentBlock>? EntryFulfillment
    {
        get => GetProperty<List<GoogleDialogflowCxPageEntryFulfillmentBlock>>("entry_fulfillment");
        set => this.WithProperty("entry_fulfillment", value);
    }

    /// <summary>
    /// Block for event_handlers.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxPageEventHandlersBlock>? EventHandlers
    {
        get => GetProperty<List<GoogleDialogflowCxPageEventHandlersBlock>>("event_handlers");
        set => this.WithProperty("event_handlers", value);
    }

    /// <summary>
    /// Block for form.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Form block(s) allowed")]
    public List<GoogleDialogflowCxPageFormBlock>? Form
    {
        get => GetProperty<List<GoogleDialogflowCxPageFormBlock>>("form");
        set => this.WithProperty("form", value);
    }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public List<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        get => GetProperty<List<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock>>("knowledge_connector_settings");
        set => this.WithProperty("knowledge_connector_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxPageTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxPageTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for transition_routes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxPageTransitionRoutesBlock>? TransitionRoutes
    {
        get => GetProperty<List<GoogleDialogflowCxPageTransitionRoutesBlock>>("transition_routes");
        set => this.WithProperty("transition_routes", value);
    }

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
