using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_certificate in GoogleIntegrationsAuthConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigClientCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate";

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptedPrivateKey is required")]
    public required TerraformValue<string> EncryptedPrivateKey
    {
        get => GetArgument<TerraformValue<string>>("encrypted_private_key");
        set => SetArgument("encrypted_private_key", value);
    }

    /// <summary>
    /// &#39;passphrase&#39; should be left unset if private key is not encrypted.
    /// Note that &#39;passphrase&#39; is not the password for web server, but an extra layer of security to protected private key.
    /// </summary>
    public TerraformValue<string>? Passphrase
    {
        get => GetArgument<TerraformValue<string>>("passphrase");
        set => SetArgument("passphrase", value);
    }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    public required TerraformValue<string> SslCertificate
    {
        get => GetArgument<TerraformValue<string>>("ssl_certificate");
        set => SetArgument("ssl_certificate", value);
    }

}


/// <summary>
/// Block type for decrypted_credential in GoogleIntegrationsAuthConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "decrypted_credential";

    /// <summary>
    /// Credential type associated with auth configs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialType is required")]
    public required TerraformValue<string> CredentialType
    {
        get => GetArgument<TerraformValue<string>>("credential_type");
        set => SetArgument("credential_type", value);
    }

    /// <summary>
    /// AuthToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthToken block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockAuthTokenBlock>? AuthToken
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockAuthTokenBlock>>("auth_token");
        set => SetArgument("auth_token", value);
    }

    /// <summary>
    /// Jwt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Jwt block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockJwtBlock>? Jwt
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockJwtBlock>>("jwt");
        set => SetArgument("jwt", value);
    }

    /// <summary>
    /// Oauth2AuthorizationCode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2AuthorizationCode block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2AuthorizationCodeBlock>? Oauth2AuthorizationCode
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2AuthorizationCodeBlock>>("oauth2_authorization_code");
        set => SetArgument("oauth2_authorization_code", value);
    }

    /// <summary>
    /// Oauth2ClientCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2ClientCredentials block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlock>? Oauth2ClientCredentials
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlock>>("oauth2_client_credentials");
        set => SetArgument("oauth2_client_credentials", value);
    }

    /// <summary>
    /// OidcToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcToken block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOidcTokenBlock>? OidcToken
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOidcTokenBlock>>("oidc_token");
        set => SetArgument("oidc_token", value);
    }

    /// <summary>
    /// ServiceAccountCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountCredentials block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockServiceAccountCredentialsBlock>? ServiceAccountCredentials
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockServiceAccountCredentialsBlock>>("service_account_credentials");
        set => SetArgument("service_account_credentials", value);
    }

    /// <summary>
    /// UsernameAndPassword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernameAndPassword block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockUsernameAndPasswordBlock>? UsernameAndPassword
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockUsernameAndPasswordBlock>>("username_and_password");
        set => SetArgument("username_and_password", value);
    }

}

/// <summary>
/// Block type for auth_token in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockAuthTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_token";

    /// <summary>
    /// The token for the auth type.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// Authentication type, e.g. &amp;quot;Basic&amp;quot;, &amp;quot;Bearer&amp;quot;, etc.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for jwt in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockJwtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jwt";

    /// <summary>
    /// The token calculated by the header, payload and signature.
    /// </summary>
    public TerraformValue<string> Jwt
        => AsReference("jwt");

    /// <summary>
    /// Identifies which algorithm is used to generate the signature.
    /// </summary>
    public TerraformValue<string>? JwtHeader
    {
        get => GetArgument<TerraformValue<string>>("jwt_header");
        set => SetArgument("jwt_header", value);
    }

    /// <summary>
    /// Contains a set of claims. The JWT specification defines seven Registered Claim Names which are the standard fields commonly included in tokens. Custom claims are usually also included, depending on the purpose of the token.
    /// </summary>
    public TerraformValue<string>? JwtPayload
    {
        get => GetArgument<TerraformValue<string>>("jwt_payload");
        set => SetArgument("jwt_payload", value);
    }

    /// <summary>
    /// User&#39;s pre-shared secret to sign the token.
    /// </summary>
    public TerraformValue<string>? Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for oauth2_authorization_code in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2AuthorizationCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_authorization_code";

    /// <summary>
    /// The auth url endpoint to send the auth code request to.
    /// </summary>
    public TerraformValue<string>? AuthEndpoint
    {
        get => GetArgument<TerraformValue<string>>("auth_endpoint");
        set => SetArgument("auth_endpoint", value);
    }

    /// <summary>
    /// The client&#39;s id.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client&#39;s secret.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// A space-delimited list of requested scope permissions.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token url endpoint to send the token request to.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

}

/// <summary>
/// Block type for oauth2_client_credentials in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_client_credentials";

    /// <summary>
    /// The client&#39;s ID.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client&#39;s secret.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// Represent how to pass parameters to fetch access token Possible values: [&amp;quot;REQUEST_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;REQUEST_BODY&amp;quot;, &amp;quot;QUERY_PARAMETERS&amp;quot;, &amp;quot;ENCODED_HEADER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RequestType
    {
        get => GetArgument<TerraformValue<string>>("request_type");
        set => SetArgument("request_type", value);
    }

    /// <summary>
    /// A space-delimited list of requested scope permissions.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token endpoint is used by the client to obtain an access token by presenting its authorization grant or refresh token.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// TokenParams block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TokenParams block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlock>? TokenParams
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlock>>("token_params");
        set => SetArgument("token_params", value);
    }

}

/// <summary>
/// Block type for token_params in GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "token_params";

    /// <summary>
    /// Entries block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlock>? Entries
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlock>>("entries");
        set => SetArgument("entries", value);
    }

}

/// <summary>
/// Block type for entries in GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entries";

    /// <summary>
    /// Key block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Key block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlock>? Key
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlock>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for key in GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key";

    /// <summary>
    /// LiteralValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiteralValue block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlockLiteralValueBlock>? LiteralValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlockLiteralValueBlock>>("literal_value");
        set => SetArgument("literal_value", value);
    }

}

/// <summary>
/// Block type for literal_value in GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockKeyBlockLiteralValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "literal_value";

    /// <summary>
    /// String.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}

/// <summary>
/// Block type for value in GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// LiteralValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiteralValue block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlockLiteralValueBlock>? LiteralValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlockLiteralValueBlock>>("literal_value");
        set => SetArgument("literal_value", value);
    }

}

/// <summary>
/// Block type for literal_value in GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOauth2ClientCredentialsBlockTokenParamsBlockEntriesBlockValueBlockLiteralValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "literal_value";

    /// <summary>
    /// String.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}

/// <summary>
/// Block type for oidc_token in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockOidcTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_token";

    /// <summary>
    /// Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is intended for.
    /// </summary>
    public TerraformValue<string>? Audience
    {
        get => GetArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The service account email to be used as the identity for the token.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// ID token obtained for the service account.
    /// </summary>
    public TerraformValue<string> Token
        => AsReference("token");

    /// <summary>
    /// The approximate time until the token retrieved is valid.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> TokenExpireTime
        => AsReference("token_expire_time");

}

/// <summary>
/// Block type for service_account_credentials in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockServiceAccountCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account_credentials";

    /// <summary>
    /// A space-delimited list of requested scope permissions.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Name of the service account that has the permission to make the request.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for username_and_password in GoogleIntegrationsAuthConfigDecryptedCredentialBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlockUsernameAndPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "username_and_password";

    /// <summary>
    /// Password to be used.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Username to be used.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIntegrationsAuthConfig.
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationsAuthConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_integrations_auth_config Terraform resource.
/// Manages a google_integrations_auth_config resource.
/// </summary>
public partial class GoogleIntegrationsAuthConfig(string name) : TerraformResource("google_integrations_auth_config", name)
{
    /// <summary>
    /// A description of the auth config.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name of the auth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// User can define the time to receive notification after which the auth config becomes invalid. Support up to 30 days. Support granularity in hours.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformList<string>? ExpiryNotificationDuration
    {
        get => GetArgument<TerraformList<string>>("expiry_notification_duration");
        set => SetArgument("expiry_notification_duration", value);
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
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// User provided expiry time to override. For the example of Salesforce, username/password credentials can be valid for 6 months depending on the instance settings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? OverrideValidTime
    {
        get => GetArgument<TerraformValue<string>>("override_valid_time");
        set => SetArgument("override_valid_time", value);
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
    /// The visibility of the auth config. Possible values: [&amp;quot;PRIVATE&amp;quot;, &amp;quot;CLIENT_VISIBLE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Visibility
    {
        get => GetArgument<TerraformValue<string>>("visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// Certificate id for client certificate.
    /// </summary>
    public TerraformValue<string> CertificateId
        => AsReference("certificate_id");

    /// <summary>
    /// The timestamp when the auth config is created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The creator&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    public TerraformValue<string> CreatorEmail
        => AsReference("creator_email");

    /// <summary>
    /// Credential type of the encrypted credential.
    /// </summary>
    public TerraformValue<string> CredentialType
        => AsReference("credential_type");

    /// <summary>
    /// Auth credential encrypted by Cloud KMS. Can be decrypted as Credential with proper KMS key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformValue<string> EncryptedCredential
        => AsReference("encrypted_credential");

    /// <summary>
    /// The last modifier&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    public TerraformValue<string> LastModifierEmail
        => AsReference("last_modifier_email");

    /// <summary>
    /// Resource name of the auth config.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The reason / details of the current status.
    /// </summary>
    public TerraformValue<string> Reason
        => AsReference("reason");

    /// <summary>
    /// The status of the auth config.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The timestamp when the auth config is modified.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// The time until the auth config is valid. Empty or max value is considered the auth config won&#39;t expire.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> ValidTime
        => AsReference("valid_time");

    /// <summary>
    /// ClientCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigClientCertificateBlock>? ClientCertificate
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigClientCertificateBlock>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// DecryptedCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DecryptedCredential block(s) allowed")]
    public TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlock>? DecryptedCredential
    {
        get => GetArgument<TerraformList<GoogleIntegrationsAuthConfigDecryptedCredentialBlock>>("decrypted_credential");
        set => SetArgument("decrypted_credential", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIntegrationsAuthConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIntegrationsAuthConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
