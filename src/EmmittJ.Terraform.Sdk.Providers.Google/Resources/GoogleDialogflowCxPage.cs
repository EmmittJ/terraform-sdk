using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<string>? DisplayName
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
    public TerraformProperty<List<string>>? TransitionRouteGroups
    {
        get => GetProperty<TerraformProperty<List<string>>>("transition_route_groups");
        set => this.WithProperty("transition_route_groups", value);
    }

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
