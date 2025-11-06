using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_flow resource.
/// </summary>
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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The human-readable name of the flow.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Marks this as the [Default Start Flow](https://cloud.google.com/dialogflow/cx/docs/concept/flow#start) for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the &#39;google_dialogflow_cx_flow&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_flow&#39; resources linked to the same agent with &#39;is_default_start_flow = true&#39; because they will compete to control a single Default Start Flow resource in GCP.
    /// </summary>
    public bool? IsDefaultStartFlow
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_default_start_flow")?.Value;
        set => this.WithProperty("is_default_start_flow", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public string? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code")?.Value;
        set => this.WithProperty("language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A flow&#39;s transition route group serve two purposes:
    /// They are responsible for matching the user&#39;s first utterances in the flow.
    /// They are inherited by every page&#39;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    public List<string>? TransitionRouteGroups
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("transition_route_groups")?.Value;
        set => this.WithProperty("transition_route_groups", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The unique identifier of the flow.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
