using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowAdvancedSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for event_handlers in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlock : TerraformBlock
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
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock : TerraformBlock
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
/// Block type for nlu_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowNluSettingsBlock : TerraformBlock
{
    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold.
    /// If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.
    /// </summary>
    public TerraformProperty<double>? ClassificationThreshold
    {
        get => GetProperty<TerraformProperty<double>>("classification_threshold");
        set => WithProperty("classification_threshold", value);
    }

    /// <summary>
    /// Indicates NLU model training mode.
    /// * MODEL_TRAINING_MODE_AUTOMATIC: NLU model training is automatically triggered when a flow gets modified. User can also manually trigger model training in this mode.
    /// * MODEL_TRAINING_MODE_MANUAL: User needs to manually trigger NLU model training. Best for large flows whose models take long time to train. Possible values: [&amp;quot;MODEL_TRAINING_MODE_AUTOMATIC&amp;quot;, &amp;quot;MODEL_TRAINING_MODE_MANUAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ModelTrainingMode
    {
        get => GetProperty<TerraformProperty<string>>("model_training_mode");
        set => WithProperty("model_training_mode", value);
    }

    /// <summary>
    /// Indicates the type of NLU model.
    /// * MODEL_TYPE_STANDARD: Use standard NLU model.
    /// * MODEL_TYPE_ADVANCED: Use advanced NLU model. Possible values: [&amp;quot;MODEL_TYPE_STANDARD&amp;quot;, &amp;quot;MODEL_TYPE_ADVANCED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ModelType
    {
        get => GetProperty<TerraformProperty<string>>("model_type");
        set => WithProperty("model_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxFlowTimeoutsBlock : TerraformBlock
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
public class GoogleDialogflowCxFlowTransitionRoutesBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_flow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxFlow : TerraformResource
{
    public GoogleDialogflowCxFlow(string name) : base("google_dialogflow_cx_flow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The human-readable name of the flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
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
    /// Marks this as the [Default Start Flow](https://cloud.google.com/dialogflow/cx/docs/concept/flow#start) for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the &#39;google_dialogflow_cx_flow&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_flow&#39; resources linked to the same agent with &#39;is_default_start_flow = true&#39; because they will compete to control a single Default Start Flow resource in GCP.
    /// </summary>
    public TerraformProperty<bool>? IsDefaultStartFlow
    {
        get => GetProperty<TerraformProperty<bool>>("is_default_start_flow");
        set => this.WithProperty("is_default_start_flow", value);
    }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// A flow&#39;s transition route group serve two purposes:
    /// They are responsible for matching the user&#39;s first utterances in the flow.
    /// They are inherited by every page&#39;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
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
    public List<GoogleDialogflowCxFlowAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetProperty<List<GoogleDialogflowCxFlowAdvancedSettingsBlock>>("advanced_settings");
        set => this.WithProperty("advanced_settings", value);
    }

    /// <summary>
    /// Block for event_handlers.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxFlowEventHandlersBlock>? EventHandlers
    {
        get => GetProperty<List<GoogleDialogflowCxFlowEventHandlersBlock>>("event_handlers");
        set => this.WithProperty("event_handlers", value);
    }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public List<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        get => GetProperty<List<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock>>("knowledge_connector_settings");
        set => this.WithProperty("knowledge_connector_settings", value);
    }

    /// <summary>
    /// Block for nlu_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NluSettings block(s) allowed")]
    public List<GoogleDialogflowCxFlowNluSettingsBlock>? NluSettings
    {
        get => GetProperty<List<GoogleDialogflowCxFlowNluSettingsBlock>>("nlu_settings");
        set => this.WithProperty("nlu_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxFlowTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxFlowTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for transition_routes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDialogflowCxFlowTransitionRoutesBlock>? TransitionRoutes
    {
        get => GetProperty<List<GoogleDialogflowCxFlowTransitionRoutesBlock>>("transition_routes");
        set => this.WithProperty("transition_routes", value);
    }

    /// <summary>
    /// The unique identifier of the flow.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
