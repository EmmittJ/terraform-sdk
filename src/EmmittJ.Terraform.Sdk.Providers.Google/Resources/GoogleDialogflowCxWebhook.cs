using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_webhook resource.
/// </summary>
public class GoogleDialogflowCxWebhook : TerraformResource
{
    public GoogleDialogflowCxWebhook(string name) : base("google_dialogflow_cx_webhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("start_flow");
    }

    /// <summary>
    /// Indicates whether the webhook is disabled.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The human-readable name of the webhook, unique within the agent.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    public bool? EnableSpellCorrection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_spell_correction")?.Value;
        set => this.WithProperty("enable_spell_correction", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Deprecated. Determines whether this agent should log conversation queries.
    /// </summary>
    public bool? EnableStackdriverLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_stackdriver_logging")?.Value;
        set => this.WithProperty("enable_stackdriver_logging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The agent to create a webhook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Deprecated. Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public string? SecuritySettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_settings")?.Value;
        set => this.WithProperty("security_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Webhook execution timeout.
    /// </summary>
    public string? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique identifier of the webhook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Deprecated. Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformExpression StartFlow => this["start_flow"];

}
