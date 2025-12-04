using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for open_api_toolset in GoogleCesToolset.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_api_toolset";

    /// <summary>
    /// If true, the agent will ignore unknown fields in the API response for all
    /// operations defined in the OpenAPI schema.
    /// </summary>
    public TerraformValue<bool>? IgnoreUnknownFields
    {
        get => GetArgument<TerraformValue<bool>>("ignore_unknown_fields");
        set => SetArgument("ignore_unknown_fields", value);
    }

    /// <summary>
    /// The OpenAPI schema of the toolset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenApiSchema is required")]
    public required TerraformValue<string> OpenApiSchema
    {
        get => GetArgument<TerraformValue<string>>("open_api_schema");
        set => SetArgument("open_api_schema", value);
    }

    /// <summary>
    /// The server URL of the Open API schema.
    /// This field is only set in toolsets in the environment dependencies
    /// during the export process if the schema contains a server url.
    /// During the import process, if this url is present in the environment dependencies
    /// and the schema has the $env_var placeholder,
    /// it will replace the placeholder in the schema.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// ApiAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiAuthentication block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock>? ApiAuthentication
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock>>("api_authentication");
        set => SetArgument("api_authentication", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

    /// <summary>
    /// TlsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlock>? TlsConfig
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlock>>("tls_config");
        set => SetArgument("tls_config", value);
    }

}

/// <summary>
/// Block type for api_authentication in GoogleCesToolsetOpenApiToolsetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_authentication";

    /// <summary>
    /// ApiKeyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiKeyConfig block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockApiKeyConfigBlock>? ApiKeyConfig
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockApiKeyConfigBlock>>("api_key_config");
        set => SetArgument("api_key_config", value);
    }

    /// <summary>
    /// OauthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockOauthConfigBlock>? OauthConfig
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockOauthConfigBlock>>("oauth_config");
        set => SetArgument("oauth_config", value);
    }

    /// <summary>
    /// ServiceAccountAuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountAuthConfig block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockServiceAccountAuthConfigBlock>? ServiceAccountAuthConfig
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockServiceAccountAuthConfigBlock>>("service_account_auth_config");
        set => SetArgument("service_account_auth_config", value);
    }

    /// <summary>
    /// ServiceAgentIdTokenAuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAgentIdTokenAuthConfig block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockServiceAgentIdTokenAuthConfigBlock>? ServiceAgentIdTokenAuthConfig
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockServiceAgentIdTokenAuthConfigBlock>>("service_agent_id_token_auth_config");
        set => SetArgument("service_agent_id_token_auth_config", value);
    }

}

/// <summary>
/// Block type for api_key_config in GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockApiKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key_config";

    /// <summary>
    /// The name of the SecretManager secret version resource storing the API key.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// Note: You should grant &#39;roles/secretmanager.secretAccessor&#39; role to the CES
    /// service agent
    /// &#39;service-@gcp-sa-ces.iam.gserviceaccount.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKeySecretVersion is required")]
    public required TerraformValue<string> ApiKeySecretVersion
    {
        get => GetArgument<TerraformValue<string>>("api_key_secret_version");
        set => SetArgument("api_key_secret_version", value);
    }

    /// <summary>
    /// The parameter name or the header name of the API key.
    /// E.g., If the API request is &amp;quot;https://example.com/act?X-Api-Key=&amp;quot;, &amp;quot;X-Api-Key&amp;quot; would be the parameter name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    public required TerraformValue<string> KeyName
    {
        get => GetArgument<TerraformValue<string>>("key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// Key location in the request.
    /// Possible values:
    /// HEADER
    /// QUERY_STRING
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestLocation is required")]
    public required TerraformValue<string> RequestLocation
    {
        get => GetArgument<TerraformValue<string>>("request_location");
        set => SetArgument("request_location", value);
    }

}

/// <summary>
/// Block type for oauth_config in GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockOauthConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret.
    /// Format: &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;
    /// 
    /// Note: You should grant &#39;roles/secretmanager.secretAccessor&#39; role to the CES
    /// service agent
    /// &#39;service-@gcp-sa-ces.iam.gserviceaccount.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretVersion is required")]
    public required TerraformValue<string> ClientSecretVersion
    {
        get => GetArgument<TerraformValue<string>>("client_secret_version");
        set => SetArgument("client_secret_version", value);
    }

    /// <summary>
    /// OAuth grant types.
    /// Possible values:
    /// CLIENT_CREDENTIAL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthGrantType is required")]
    public required TerraformValue<string> OauthGrantType
    {
        get => GetArgument<TerraformValue<string>>("oauth_grant_type");
        set => SetArgument("oauth_grant_type", value);
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
    /// The token endpoint in the OAuth provider to exchange for an access token.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

}

/// <summary>
/// Block type for service_account_auth_config in GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockServiceAccountAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account_auth_config";

    /// <summary>
    /// The email address of the service account used for authenticatation. CES
    /// uses this service account to exchange an access token and the access token
    /// is then sent in the &#39;Authorization&#39; header of the request.
    /// 
    /// The service account must have the
    /// &#39;roles/iam.serviceAccountTokenCreator&#39; role granted to the
    /// CES service agent
    /// &#39;service-@gcp-sa-ces.iam.gserviceaccount.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for service_agent_id_token_auth_config in GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockApiAuthenticationBlockServiceAgentIdTokenAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_agent_id_token_auth_config";

}

/// <summary>
/// Block type for service_directory_config in GoogleCesToolsetOpenApiToolsetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// The name of [Service
    /// Directory](https://cloud.google.com/service-directory) service.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}&#39;.
    /// Location of the service directory must be the same as the location of the
    /// app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for tls_config in GoogleCesToolsetOpenApiToolsetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlock : TerraformBlock
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
    public required TerraformList<GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlockCaCertsBlock> CaCerts
    {
        get => GetRequiredArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlockCaCertsBlock>>("ca_certs");
        set => SetArgument("ca_certs", value);
    }

}

/// <summary>
/// Block type for ca_certs in GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlockTlsConfigBlockCaCertsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ca_certs";

    /// <summary>
    /// The allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, CES will use Google&#39;s default trust
    /// store to verify certificates. N.B. Make sure the HTTPS server
    /// certificates are signed with &amp;quot;subject alt name&amp;quot;. For instance a
    /// certificate can be self-signed using the following command,
    /// openssl x509 -req -days 200 -in example.com.csr \
    /// -signkey example.com.key \
    /// -out example.com.crt \
    /// -extfile &amp;lt;(printf &amp;quot;\nsubjectAltName=&#39;DNS:www.example.com&#39;&amp;quot;)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cert is required")]
    public required TerraformValue<string> Cert
    {
        get => GetArgument<TerraformValue<string>>("cert");
        set => SetArgument("cert", value);
    }

    /// <summary>
    /// The name of the allowed custom CA certificates. This
    /// can be used to disambiguate the custom CA certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCesToolset.
/// Nesting mode: single
/// </summary>
public class GoogleCesToolsetTimeoutsBlock : TerraformBlock
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
/// Represents a google_ces_toolset Terraform resource.
/// Manages a google_ces_toolset resource.
/// </summary>
public partial class GoogleCesToolset(string name) : TerraformResource("google_ces_toolset", name)
{
    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    public required TerraformValue<string> App
    {
        get => GetArgument<TerraformValue<string>>("app");
        set => SetArgument("app", value);
    }

    /// <summary>
    /// The description of the toolset.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the toolset. Must be unique within the same app.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Possible values:
    /// SYNCHRONOUS
    /// ASYNCHRONOUS
    /// </summary>
    public TerraformValue<string>? ExecutionType
    {
        get => GetArgument<TerraformValue<string>>("execution_type");
        set => SetArgument("execution_type", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ID to use for the toolset, which will become the final component of
    /// the toolset&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the toolset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToolsetId is required")]
    public required TerraformValue<string> ToolsetId
    {
        get => GetArgument<TerraformValue<string>>("toolset_id");
        set => SetArgument("toolset_id", value);
    }

    /// <summary>
    /// Timestamp when the toolset was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// ETag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Identifier. The unique identifier of the toolset.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timestamp when the toolset was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// OpenApiToolset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiToolset block(s) allowed")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlock>? OpenApiToolset
    {
        get => GetArgument<TerraformList<GoogleCesToolsetOpenApiToolsetBlock>>("open_api_toolset");
        set => SetArgument("open_api_toolset", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCesToolsetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCesToolsetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
