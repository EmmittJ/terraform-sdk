using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for generic_web_service in GoogleDialogflowCxWebhook.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookGenericWebServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generic_web_service";

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
    public TerraformList<string>? AllowedCaCerts
    {
        get => GetArgument<TerraformList<string>>("allowed_ca_certs");
        set => SetArgument("allowed_ca_certs", value);
    }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST. Possible values: [&amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => GetArgument<TerraformValue<string>>("http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// - Key: session parameter name
    /// - Value: field path in the webhook response
    /// </summary>
    public TerraformMap<string>? ParameterMapping
    {
        get => GetArgument<TerraformMap<string>>("parameter_mapping");
        set => SetArgument("parameter_mapping", value);
    }

    /// <summary>
    /// Defines a custom JSON object as request body to send to flexible webhook.
    /// </summary>
    public TerraformValue<string>? RequestBody
    {
        get => GetArgument<TerraformValue<string>>("request_body");
        set => SetArgument("request_body", value);
    }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests.
    /// </summary>
    public TerraformMap<string>? RequestHeaders
    {
        get => GetArgument<TerraformMap<string>>("request_headers");
        set => SetArgument("request_headers", value);
    }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    public TerraformValue<string>? SecretVersionForUsernamePassword
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_username_password");
        set => SetArgument("secret_version_for_username_password", value);
    }

    /// <summary>
    /// Indicate the auth token type generated from the [Diglogflow service
    /// agent](https://cloud.google.com/iam/docs/service-agents#dialogflow-service-agent).
    /// The generated token is sent in the Authorization header. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;ID_TOKEN&amp;quot;, &amp;quot;ACCESS_TOKEN&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ServiceAgentAuth
    {
        get => GetArgument<TerraformValue<string>>("service_agent_auth");
        set => SetArgument("service_agent_auth", value);
    }

    /// <summary>
    /// The webhook URI for receiving POST requests. It must use https protocol.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// Type of the webhook. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;FLEXIBLE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WebhookType
    {
        get => GetArgument<TerraformValue<string>>("webhook_type");
        set => SetArgument("webhook_type", value);
    }

    /// <summary>
    /// OauthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxWebhookGenericWebServiceBlockOauthConfigBlock>? OauthConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxWebhookGenericWebServiceBlockOauthConfigBlock>>("oauth_config");
        set => SetArgument("oauth_config", value);
    }

    /// <summary>
    /// SecretVersionsForRequestHeaders block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDialogflowCxWebhookGenericWebServiceBlockSecretVersionsForRequestHeadersBlock>? SecretVersionsForRequestHeaders
    {
        get => GetArgument<TerraformSet<GoogleDialogflowCxWebhookGenericWebServiceBlockSecretVersionsForRequestHeadersBlock>>("secret_versions_for_request_headers");
        set => SetArgument("secret_versions_for_request_headers", value);
    }

}

/// <summary>
/// Block type for oauth_config in GoogleDialogflowCxWebhookGenericWebServiceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookGenericWebServiceBlockOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_config";

    /// <summary>
    /// The client ID provided by the 3rd party platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// &#39;secret_version_for_client_secret&#39; field is set, this field will be
    /// ignored.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The OAuth scopes to grant.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the &#39;client_secret&#39; field will be
    /// ignored.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    public TerraformValue<string>? SecretVersionForClientSecret
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_client_secret");
        set => SetArgument("secret_version_for_client_secret", value);
    }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

}

/// <summary>
/// Block type for secret_versions_for_request_headers in GoogleDialogflowCxWebhookGenericWebServiceBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDialogflowCxWebhookGenericWebServiceBlockSecretVersionsForRequestHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_versions_for_request_headers";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => GetArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for service_directory in GoogleDialogflowCxWebhook.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookServiceDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory";

    /// <summary>
    /// The name of Service Directory service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// GenericWebService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenericWebService block(s) allowed")]
    public TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlock>? GenericWebService
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlock>>("generic_web_service");
        set => SetArgument("generic_web_service", value);
    }

}

/// <summary>
/// Block type for generic_web_service in GoogleDialogflowCxWebhookServiceDirectoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generic_web_service";

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
    public TerraformList<string>? AllowedCaCerts
    {
        get => GetArgument<TerraformList<string>>("allowed_ca_certs");
        set => SetArgument("allowed_ca_certs", value);
    }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST. Possible values: [&amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => GetArgument<TerraformValue<string>>("http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// - Key: session parameter name
    /// - Value: field path in the webhook response
    /// </summary>
    public TerraformMap<string>? ParameterMapping
    {
        get => GetArgument<TerraformMap<string>>("parameter_mapping");
        set => SetArgument("parameter_mapping", value);
    }

    /// <summary>
    /// Defines a custom JSON object as request body to send to flexible webhook.
    /// </summary>
    public TerraformValue<string>? RequestBody
    {
        get => GetArgument<TerraformValue<string>>("request_body");
        set => SetArgument("request_body", value);
    }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests.
    /// </summary>
    public TerraformMap<string>? RequestHeaders
    {
        get => GetArgument<TerraformMap<string>>("request_headers");
        set => SetArgument("request_headers", value);
    }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    public TerraformValue<string>? SecretVersionForUsernamePassword
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_username_password");
        set => SetArgument("secret_version_for_username_password", value);
    }

    /// <summary>
    /// Indicate the auth token type generated from the [Diglogflow service
    /// agent](https://cloud.google.com/iam/docs/service-agents#dialogflow-service-agent).
    /// The generated token is sent in the Authorization header. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;ID_TOKEN&amp;quot;, &amp;quot;ACCESS_TOKEN&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ServiceAgentAuth
    {
        get => GetArgument<TerraformValue<string>>("service_agent_auth");
        set => SetArgument("service_agent_auth", value);
    }

    /// <summary>
    /// The webhook URI for receiving POST requests. It must use https protocol.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// Type of the webhook. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;FLEXIBLE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WebhookType
    {
        get => GetArgument<TerraformValue<string>>("webhook_type");
        set => SetArgument("webhook_type", value);
    }

    /// <summary>
    /// OauthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlockOauthConfigBlock>? OauthConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlockOauthConfigBlock>>("oauth_config");
        set => SetArgument("oauth_config", value);
    }

    /// <summary>
    /// SecretVersionsForRequestHeaders block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlockSecretVersionsForRequestHeadersBlock>? SecretVersionsForRequestHeaders
    {
        get => GetArgument<TerraformSet<GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlockSecretVersionsForRequestHeadersBlock>>("secret_versions_for_request_headers");
        set => SetArgument("secret_versions_for_request_headers", value);
    }

}

/// <summary>
/// Block type for oauth_config in GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlockOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_config";

    /// <summary>
    /// The client ID provided by the 3rd party platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// &#39;secret_version_for_client_secret&#39; field is set, this field will be
    /// ignored.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The OAuth scopes to grant.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the &#39;client_secret&#39; field will be
    /// ignored.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    public TerraformValue<string>? SecretVersionForClientSecret
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_client_secret");
        set => SetArgument("secret_version_for_client_secret", value);
    }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

}

/// <summary>
/// Block type for secret_versions_for_request_headers in GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDialogflowCxWebhookServiceDirectoryBlockGenericWebServiceBlockSecretVersionsForRequestHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_versions_for_request_headers";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => GetArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxWebhook.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxWebhookTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_webhook Terraform resource.
/// Manages a google_dialogflow_cx_webhook resource.
/// </summary>
public partial class GoogleDialogflowCxWebhook(string name) : TerraformResource("google_dialogflow_cx_webhook", name)
{
    /// <summary>
    /// Indicates whether the webhook is disabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The human-readable name of the webhook, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    public TerraformValue<bool>? EnableSpellCorrection
    {
        get => GetArgument<TerraformValue<bool>>("enable_spell_correction");
        set => SetArgument("enable_spell_correction", value);
    }

    /// <summary>
    /// Deprecated. Determines whether this agent should log conversation queries.
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The agent to create a webhook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Deprecated. Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? SecuritySettings
    {
        get => GetArgument<TerraformValue<string>>("security_settings");
        set => SetArgument("security_settings", value);
    }

    /// <summary>
    /// Webhook execution timeout.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unique identifier of the webhook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Deprecated. Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> StartFlow
        => AsReference("start_flow");

    /// <summary>
    /// GenericWebService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenericWebService block(s) allowed")]
    public TerraformList<GoogleDialogflowCxWebhookGenericWebServiceBlock>? GenericWebService
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxWebhookGenericWebServiceBlock>>("generic_web_service");
        set => SetArgument("generic_web_service", value);
    }

    /// <summary>
    /// ServiceDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectory block(s) allowed")]
    public TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlock>? ServiceDirectory
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxWebhookServiceDirectoryBlock>>("service_directory");
        set => SetArgument("service_directory", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxWebhookTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxWebhookTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
