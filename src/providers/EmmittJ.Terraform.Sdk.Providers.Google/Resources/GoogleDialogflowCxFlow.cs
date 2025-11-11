using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxFlowAdvancedSettingsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for event_handlers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxFlowEventHandlersBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the event to handle.
    /// </summary>
    [TerraformProperty("event")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Event { get; set; }


    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_flow")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_page")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether Knowledge Connector is enabled or not.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;.
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    [TerraformProperty("target_flow")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;/pages/&amp;lt;PageID&amp;gt;.
    /// The page must be in the same host flow (the flow that owns this &#39;KnowledgeConnectorSettings&#39;).
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    [TerraformProperty("target_page")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Block type for nlu_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxFlowNluSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold.
    /// If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.
    /// </summary>
    [TerraformProperty("classification_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ClassificationThreshold { get; set; }

    /// <summary>
    /// Indicates NLU model training mode.
    /// * MODEL_TRAINING_MODE_AUTOMATIC: NLU model training is automatically triggered when a flow gets modified. User can also manually trigger model training in this mode.
    /// * MODEL_TRAINING_MODE_MANUAL: User needs to manually trigger NLU model training. Best for large flows whose models take long time to train. Possible values: [&amp;quot;MODEL_TRAINING_MODE_AUTOMATIC&amp;quot;, &amp;quot;MODEL_TRAINING_MODE_MANUAL&amp;quot;]
    /// </summary>
    [TerraformProperty("model_training_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ModelTrainingMode { get; set; }

    /// <summary>
    /// Indicates the type of NLU model.
    /// * MODEL_TYPE_STANDARD: Use standard NLU model.
    /// * MODEL_TYPE_ADVANCED: Use advanced NLU model. Possible values: [&amp;quot;MODEL_TYPE_STANDARD&amp;quot;, &amp;quot;MODEL_TYPE_ADVANCED&amp;quot;]
    /// </summary>
    [TerraformProperty("model_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ModelType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxFlowTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for transition_routes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxFlowTransitionRoutesBlock : TerraformBlockBase
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [TerraformProperty("condition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [TerraformProperty("intent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Intent { get; set; }


    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_flow")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    [TerraformProperty("target_page")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetPage { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_flow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxFlow : TerraformResource
{
    public GoogleDialogflowCxFlow(string name) : base("google_dialogflow_cx_flow", name)
    {
    }

    /// <summary>
    /// The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The human-readable name of the flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Marks this as the [Default Start Flow](https://cloud.google.com/dialogflow/cx/docs/concept/flow#start) for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the &#39;google_dialogflow_cx_flow&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_flow&#39; resources linked to the same agent with &#39;is_default_start_flow = true&#39; because they will compete to control a single Default Start Flow resource in GCP.
    /// </summary>
    [TerraformProperty("is_default_start_flow")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsDefaultStartFlow { get; set; }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// A flow&#39;s transition route group serve two purposes:
    /// They are responsible for matching the user&#39;s first utterances in the flow.
    /// They are inherited by every page&#39;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    [TerraformProperty("transition_route_groups")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// Block for advanced_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    [TerraformProperty("advanced_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxFlowAdvancedSettingsBlock>>? AdvancedSettings { get; set; }

    /// <summary>
    /// Block for event_handlers.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_handlers")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxFlowEventHandlersBlock>>? EventHandlers { get; set; }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    [TerraformProperty("knowledge_connector_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock>>? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// Block for nlu_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NluSettings block(s) allowed")]
    [TerraformProperty("nlu_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxFlowNluSettingsBlock>>? NluSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDialogflowCxFlowTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for transition_routes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("transition_routes")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxFlowTransitionRoutesBlock>>? TransitionRoutes { get; set; }

    /// <summary>
    /// The unique identifier of the flow.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
