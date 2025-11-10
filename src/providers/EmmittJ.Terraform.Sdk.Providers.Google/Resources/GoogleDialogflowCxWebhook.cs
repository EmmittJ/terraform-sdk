using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for generic_web_service in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookGenericWebServiceBlock : TerraformBlock
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&#39;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &amp;quot;subject alt
    /// name&amp;quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr \
    /// -signkey example.com.key \
    /// -out example.com.crt \
    /// -extfile &amp;lt;(printf &amp;quot;\nsubjectAltName=&#39;DNS:www.example.com&#39;&amp;quot;)
    /// </summary>
    public List<TerraformProperty<string>>? AllowedCaCerts
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_ca_certs");
        set => WithProperty("allowed_ca_certs", value);
    }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST. Possible values: [&amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? HttpMethod
    {
        get => GetProperty<TerraformProperty<string>>("http_method");
        set => WithProperty("http_method", value);
    }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// - Key: session parameter name
    /// - Value: field path in the webhook response
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ParameterMapping
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameter_mapping");
        set => WithProperty("parameter_mapping", value);
    }

    /// <summary>
    /// Defines a custom JSON object as request body to send to flexible webhook.
    /// </summary>
    public TerraformProperty<string>? RequestBody
    {
        get => GetProperty<TerraformProperty<string>>("request_body");
        set => WithProperty("request_body", value);
    }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RequestHeaders
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("request_headers");
        set => WithProperty("request_headers", value);
    }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    public TerraformProperty<string>? SecretVersionForUsernamePassword
    {
        get => GetProperty<TerraformProperty<string>>("secret_version_for_username_password");
        set => WithProperty("secret_version_for_username_password", value);
    }

    /// <summary>
    /// Indicate the auth token type generated from the [Diglogflow service
    /// agent](https://cloud.google.com/iam/docs/service-agents#dialogflow-service-agent).
    /// The generated token is sent in the Authorization header. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;ID_TOKEN&amp;quot;, &amp;quot;ACCESS_TOKEN&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ServiceAgentAuth
    {
        get => GetProperty<TerraformProperty<string>>("service_agent_auth");
        set => WithProperty("service_agent_auth", value);
    }

    /// <summary>
    /// The webhook URI for receiving POST requests. It must use https protocol.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

    /// <summary>
    /// Type of the webhook. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;FLEXIBLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? WebhookType
    {
        get => GetProperty<TerraformProperty<string>>("webhook_type");
        set => WithProperty("webhook_type", value);
    }

}

/// <summary>
/// Block type for service_directory in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookServiceDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// The name of Service Directory service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxWebhookTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxWebhook : TerraformResource
{
    public GoogleDialogflowCxWebhook(string name) : base("google_dialogflow_cx_webhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("start_flow");
    }

    /// <summary>
    /// Indicates whether the webhook is disabled.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The human-readable name of the webhook, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    public TerraformProperty<bool>? EnableSpellCorrection
    {
        get => GetProperty<TerraformProperty<bool>>("enable_spell_correction");
        set => this.WithProperty("enable_spell_correction", value);
    }

    /// <summary>
    /// Deprecated. Determines whether this agent should log conversation queries.
    /// </summary>
    public TerraformProperty<bool>? EnableStackdriverLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_stackdriver_logging");
        set => this.WithProperty("enable_stackdriver_logging", value);
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
    /// The agent to create a webhook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Deprecated. Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? SecuritySettings
    {
        get => GetProperty<TerraformProperty<string>>("security_settings");
        set => this.WithProperty("security_settings", value);
    }

    /// <summary>
    /// Webhook execution timeout.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// Block for generic_web_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenericWebService block(s) allowed")]
    public List<GoogleDialogflowCxWebhookGenericWebServiceBlock>? GenericWebService
    {
        get => GetProperty<List<GoogleDialogflowCxWebhookGenericWebServiceBlock>>("generic_web_service");
        set => this.WithProperty("generic_web_service", value);
    }

    /// <summary>
    /// Block for service_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectory block(s) allowed")]
    public List<GoogleDialogflowCxWebhookServiceDirectoryBlock>? ServiceDirectory
    {
        get => GetProperty<List<GoogleDialogflowCxWebhookServiceDirectoryBlock>>("service_directory");
        set => this.WithProperty("service_directory", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxWebhookTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxWebhookTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
