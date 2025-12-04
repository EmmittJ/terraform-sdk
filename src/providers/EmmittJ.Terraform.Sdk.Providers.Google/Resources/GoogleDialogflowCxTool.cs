using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_store_spec in GoogleDialogflowCxTool.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolDataStoreSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_store_spec";

    /// <summary>
    /// DataStoreConnections block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreConnections is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataStoreConnections block(s) required")]
    public required TerraformList<GoogleDialogflowCxToolDataStoreSpecBlockDataStoreConnectionsBlock> DataStoreConnections
    {
        get => GetRequiredArgument<TerraformList<GoogleDialogflowCxToolDataStoreSpecBlockDataStoreConnectionsBlock>>("data_store_connections");
        set => SetArgument("data_store_connections", value);
    }

    /// <summary>
    /// FallbackPrompt block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FallbackPrompt is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FallbackPrompt block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackPrompt block(s) allowed")]
    public required TerraformList<GoogleDialogflowCxToolDataStoreSpecBlockFallbackPromptBlock> FallbackPrompt
    {
        get => GetRequiredArgument<TerraformList<GoogleDialogflowCxToolDataStoreSpecBlockFallbackPromptBlock>>("fallback_prompt");
        set => SetArgument("fallback_prompt", value);
    }

}

/// <summary>
/// Block type for data_store_connections in GoogleDialogflowCxToolDataStoreSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolDataStoreSpecBlockDataStoreConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_store_connections";

    /// <summary>
    /// The full name of the referenced data store. Formats: projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore} projects/{project}/locations/{location}/dataStores/{dataStore}
    /// </summary>
    public TerraformValue<string>? DataStore
    {
        get => GetArgument<TerraformValue<string>>("data_store");
        set => SetArgument("data_store", value);
    }

    /// <summary>
    /// The type of the connected data store.
    /// See [DataStoreType](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/DataStoreConnection#datastoretype) for valid values.
    /// </summary>
    public TerraformValue<string>? DataStoreType
    {
        get => GetArgument<TerraformValue<string>>("data_store_type");
        set => SetArgument("data_store_type", value);
    }

    /// <summary>
    /// The document processing mode for the data store connection. Should only be set for PUBLIC_WEB and UNSTRUCTURED data stores. If not set it is considered as DOCUMENTS, as this is the legacy mode.
    /// See [DocumentProcessingMode](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/DataStoreConnection#documentprocessingmode) for valid values.
    /// </summary>
    public TerraformValue<string>? DocumentProcessingMode
    {
        get => GetArgument<TerraformValue<string>>("document_processing_mode");
        set => SetArgument("document_processing_mode", value);
    }

}

/// <summary>
/// Block type for fallback_prompt in GoogleDialogflowCxToolDataStoreSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolDataStoreSpecBlockFallbackPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fallback_prompt";

}


/// <summary>
/// Block type for function_spec in GoogleDialogflowCxTool.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolFunctionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "function_spec";

    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the input of the function.
    /// This input is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    public TerraformValue<string>? InputSchema
    {
        get => GetArgument<TerraformValue<string>>("input_schema");
        set => SetArgument("input_schema", value);
    }

    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the output of the function.
    /// This output is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    public TerraformValue<string>? OutputSchema
    {
        get => GetArgument<TerraformValue<string>>("output_schema");
        set => SetArgument("output_schema", value);
    }

}


/// <summary>
/// Block type for open_api_spec in GoogleDialogflowCxTool.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_api_spec";

    /// <summary>
    /// The OpenAPI schema specified as a text.
    /// This field is part of a union field &#39;schema&#39;: only one of &#39;textSchema&#39; may be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextSchema is required")]
    public required TerraformValue<string> TextSchema
    {
        get => GetRequiredArgument<TerraformValue<string>>("text_schema");
        set => SetArgument("text_schema", value);
    }

    /// <summary>
    /// Authentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

    /// <summary>
    /// TlsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlock>? TlsConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlock>>("tls_config");
        set => SetArgument("tls_config", value);
    }

}

/// <summary>
/// Block type for authentication in GoogleDialogflowCxToolOpenApiSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

    /// <summary>
    /// ApiKeyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiKeyConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockApiKeyConfigBlock>? ApiKeyConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockApiKeyConfigBlock>>("api_key_config");
        set => SetArgument("api_key_config", value);
    }

    /// <summary>
    /// BearerTokenConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BearerTokenConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockBearerTokenConfigBlock>? BearerTokenConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockBearerTokenConfigBlock>>("bearer_token_config");
        set => SetArgument("bearer_token_config", value);
    }

    /// <summary>
    /// OauthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockOauthConfigBlock>? OauthConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockOauthConfigBlock>>("oauth_config");
        set => SetArgument("oauth_config", value);
    }

    /// <summary>
    /// ServiceAgentAuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAgentAuthConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockServiceAgentAuthConfigBlock>? ServiceAgentAuthConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockServiceAgentAuthConfigBlock>>("service_agent_auth_config");
        set => SetArgument("service_agent_auth_config", value);
    }

}

/// <summary>
/// Block type for api_key_config in GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockApiKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key_config";

    /// <summary>
    /// Optional. The API key. If the &#39;secretVersionForApiKey&#39;&#39; field is set, this field will be ignored.
    /// </summary>
    public TerraformValue<string>? ApiKey
    {
        get => GetArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The parameter name or the header name of the API key.
    /// E.g., If the API request is &amp;quot;https://example.com/act?X-Api-Key=&amp;quot;, &amp;quot;X-Api-Key&amp;quot; would be the parameter name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    public required TerraformValue<string> KeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// Key location in the request.
    /// See [RequestLocation](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.tools#requestlocation) for valid values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestLocation is required")]
    public required TerraformValue<string> RequestLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("request_location");
        set => SetArgument("request_location", value);
    }

    /// <summary>
    /// Optional. The name of the SecretManager secret version resource storing the API key.
    /// If this field is set, the apiKey field will be ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    public TerraformValue<string>? SecretVersionForApiKey
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_api_key");
        set => SetArgument("secret_version_for_api_key", value);
    }

}

/// <summary>
/// Block type for bearer_token_config in GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockBearerTokenConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bearer_token_config";

    /// <summary>
    /// Optional. The name of the SecretManager secret version resource storing the Bearer token. If this field is set, the &#39;token&#39; field will be ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    public TerraformValue<string>? SecretVersionForToken
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_token");
        set => SetArgument("secret_version_for_token", value);
    }

    /// <summary>
    /// Optional. The text token appended to the text Bearer to the request Authorization header.
    /// [Session parameters reference](https://cloud.google.com/dialogflow/cx/docs/concept/parameter#session-ref) can be used to pass the token dynamically, e.g. &#39;$session.params.parameter-id&#39;.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

}

/// <summary>
/// Block type for oauth_config in GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_config";

    /// <summary>
    /// The client ID from the OAuth provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// Optional. The client secret from the OAuth provider. If the &#39;secretVersionForClientSecret&#39; field is set, this field will be ignored.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// OAuth grant types.
    /// See [OauthGrantType](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.tools#oauthgranttype) for valid values
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthGrantType is required")]
    public required TerraformValue<string> OauthGrantType
    {
        get => GetRequiredArgument<TerraformValue<string>>("oauth_grant_type");
        set => SetArgument("oauth_grant_type", value);
    }

    /// <summary>
    /// Optional. The OAuth scopes to grant.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// Optional. The name of the SecretManager secret version resource storing the client secret.
    /// If this field is set, the clientSecret field will be ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    public TerraformValue<string>? SecretVersionForClientSecret
    {
        get => GetArgument<TerraformValue<string>>("secret_version_for_client_secret");
        set => SetArgument("secret_version_for_client_secret", value);
    }

    /// <summary>
    /// The token endpoint in the OAuth provider to exchange for an access token.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

}

/// <summary>
/// Block type for service_agent_auth_config in GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockAuthenticationBlockServiceAgentAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_agent_auth_config";

    /// <summary>
    /// Optional. Indicate the auth token type generated from the Diglogflow service agent.
    /// The generated token is sent in the Authorization header.
    /// See [ServiceAgentAuth](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.tools#serviceagentauth) for valid values.
    /// </summary>
    public TerraformValue<string>? ServiceAgentAuth
    {
        get => GetArgument<TerraformValue<string>>("service_agent_auth");
        set => SetArgument("service_agent_auth", value);
    }

}

/// <summary>
/// Block type for service_directory_config in GoogleDialogflowCxToolOpenApiSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// The name of [Service Directory](https://cloud.google.com/service-directory/docs) service.
    /// Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/namespaces/&amp;lt;NamespaceID&amp;gt;/services/&amp;lt;ServiceID&amp;gt;. LocationID of the service directory must be the same as the location of the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for tls_config in GoogleDialogflowCxToolOpenApiSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_config";

    /// <summary>
    /// CaCerts block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCerts is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CaCerts block(s) required")]
    public required TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlockCaCertsBlock> CaCerts
    {
        get => GetRequiredArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlockCaCertsBlock>>("ca_certs");
        set => SetArgument("ca_certs", value);
    }

}

/// <summary>
/// Block type for ca_certs in GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlockTlsConfigBlockCaCertsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ca_certs";

    /// <summary>
    /// The allowed custom CA certificates (in DER format) for HTTPS verification. This overrides the default SSL trust store.
    /// If this is empty or unspecified, Dialogflow will use Google&#39;s default trust store to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &amp;quot;subject alt name&amp;quot;.
    /// For instance a certificate can be self-signed using the following command:
    /// &#39;&#39;&#39;
    ///   openssl x509 -req -days 200 -in example.com.csr \
    ///     -signkey example.com.key \
    ///     -out example.com.crt \
    ///     -extfile &amp;lt;(printf &amp;quot;\nsubjectAltName=&#39;DNS:www.example.com&#39;&amp;quot;)
    /// &#39;&#39;&#39;
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cert is required")]
    public required TerraformValue<string> Cert
    {
        get => GetRequiredArgument<TerraformValue<string>>("cert");
        set => SetArgument("cert", value);
    }

    /// <summary>
    /// The name of the allowed custom CA certificates. This can be used to disambiguate the custom CA certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxTool.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxToolTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_cx_tool Terraform resource.
/// Manages a google_dialogflow_cx_tool resource.
/// </summary>
public partial class GoogleDialogflowCxTool(string name) : TerraformResource("google_dialogflow_cx_tool", name)
{
    /// <summary>
    /// High level description of the Tool and its usage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The human-readable name of the tool, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The agent to create a Tool for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The unique identifier of the Tool.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/tools/&amp;lt;Tool ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The tool type.
    /// </summary>
    public TerraformValue<string> ToolType
        => AsReference("tool_type");

    /// <summary>
    /// DataStoreSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSpec block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolDataStoreSpecBlock>? DataStoreSpec
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolDataStoreSpecBlock>>("data_store_spec");
        set => SetArgument("data_store_spec", value);
    }

    /// <summary>
    /// FunctionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FunctionSpec block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolFunctionSpecBlock>? FunctionSpec
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolFunctionSpecBlock>>("function_spec");
        set => SetArgument("function_spec", value);
    }

    /// <summary>
    /// OpenApiSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiSpec block(s) allowed")]
    public TerraformList<GoogleDialogflowCxToolOpenApiSpecBlock>? OpenApiSpec
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxToolOpenApiSpecBlock>>("open_api_spec");
        set => SetArgument("open_api_spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxToolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxToolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
