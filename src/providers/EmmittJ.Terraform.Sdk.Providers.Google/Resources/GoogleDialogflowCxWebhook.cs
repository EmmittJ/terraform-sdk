using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for generic_web_service in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxWebhookGenericWebServiceBlock() : TerraformBlock("generic_web_service")
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
    [TerraformProperty("allowed_ca_certs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST. Possible values: [&amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    [TerraformProperty("http_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpMethod { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// - Key: session parameter name
    /// - Value: field path in the webhook response
    /// </summary>
    [TerraformProperty("parameter_mapping")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ParameterMapping { get; set; }

    /// <summary>
    /// Defines a custom JSON object as request body to send to flexible webhook.
    /// </summary>
    [TerraformProperty("request_body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestBody { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests.
    /// </summary>
    [TerraformProperty("request_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    [TerraformProperty("secret_version_for_username_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the [Diglogflow service
    /// agent](https://cloud.google.com/iam/docs/service-agents#dialogflow-service-agent).
    /// The generated token is sent in the Authorization header. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;ID_TOKEN&amp;quot;, &amp;quot;ACCESS_TOKEN&amp;quot;]
    /// </summary>
    [TerraformProperty("service_agent_auth")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAgentAuth { get; set; }

    /// <summary>
    /// The webhook URI for receiving POST requests. It must use https protocol.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

    /// <summary>
    /// Type of the webhook. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;FLEXIBLE&amp;quot;]
    /// </summary>
    [TerraformProperty("webhook_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebhookType { get; set; }

}

/// <summary>
/// Block type for service_directory in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxWebhookServiceDirectoryBlock() : TerraformBlock("service_directory")
{
    /// <summary>
    /// The name of Service Directory service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxWebhookTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_dialogflow_cx_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxWebhook : TerraformResource
{
    public GoogleDialogflowCxWebhook(string name) : base("google_dialogflow_cx_webhook", name)
    {
    }

    /// <summary>
    /// Indicates whether the webhook is disabled.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The human-readable name of the webhook, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    [TerraformProperty("enable_spell_correction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSpellCorrection { get; set; }

    /// <summary>
    /// Deprecated. Determines whether this agent should log conversation queries.
    /// </summary>
    [TerraformProperty("enable_stackdriver_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The agent to create a webhook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Deprecated. Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    [TerraformProperty("security_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecuritySettings { get; set; }

    /// <summary>
    /// Webhook execution timeout.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Timeout { get; set; }

    /// <summary>
    /// Block for generic_web_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenericWebService block(s) allowed")]
    [TerraformProperty("generic_web_service")]
    public TerraformList<GoogleDialogflowCxWebhookGenericWebServiceBlock> GenericWebService { get; set; } = new();

    /// <summary>
    /// Block for service_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectory block(s) allowed")]
    [TerraformProperty("service_directory")]
    public TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlock> ServiceDirectory { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDialogflowCxWebhookTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique identifier of the webhook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Deprecated. Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("start_flow")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartFlow { get; }

}
