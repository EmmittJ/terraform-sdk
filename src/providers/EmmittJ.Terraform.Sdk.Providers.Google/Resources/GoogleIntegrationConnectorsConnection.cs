using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for auth_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_config";

    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public TerraformValue<string>? AuthKey
    {
        get => new TerraformReference<string>(this, "auth_key");
        set => SetArgument("auth_key", value);
    }

    /// <summary>
    /// authType of the Connection Possible values: [&amp;quot;AUTH_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;USER_PASSWORD&amp;quot;, &amp;quot;OAUTH2_JWT_BEARER&amp;quot;, &amp;quot;OAUTH2_CLIENT_CREDENTIALS&amp;quot;, &amp;quot;SSH_PUBLIC_KEY&amp;quot;, &amp;quot;OAUTH2_AUTH_CODE_FLOW&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// AdditionalVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlock>? AdditionalVariable
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlock>>("additional_variable");
        set => SetArgument("additional_variable", value);
    }

    /// <summary>
    /// Oauth2AuthCodeFlow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2AuthCodeFlow block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlock>? Oauth2AuthCodeFlow
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlock>>("oauth2_auth_code_flow");
        set => SetArgument("oauth2_auth_code_flow", value);
    }

    /// <summary>
    /// Oauth2ClientCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2ClientCredentials block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlock>? Oauth2ClientCredentials
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlock>>("oauth2_client_credentials");
        set => SetArgument("oauth2_client_credentials", value);
    }

    /// <summary>
    /// Oauth2JwtBearer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2JwtBearer block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlock>? Oauth2JwtBearer
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlock>>("oauth2_jwt_bearer");
        set => SetArgument("oauth2_jwt_bearer", value);
    }

    /// <summary>
    /// SshPublicKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshPublicKey block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlock>? SshPublicKey
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlock>>("ssh_public_key");
        set => SetArgument("ssh_public_key", value);
    }

    /// <summary>
    /// UserPassword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPassword block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlock>? UserPassword
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlock>>("user_password");
        set => SetArgument("user_password", value);
    }

}

/// <summary>
/// Block type for additional_variable in GoogleIntegrationConnectorsConnectionAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_variable";

    /// <summary>
    /// Boolean Value of configVariable.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => new TerraformReference<bool>(this, "boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Integer Value of configVariable.
    /// </summary>
    public TerraformValue<double>? IntegerValue
    {
        get => new TerraformReference<double>(this, "integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// String Value of configVariabley.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// EncryptionKeyValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKeyValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>? EncryptionKeyValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>>("encryption_key_value");
        set => SetArgument("encryption_key_value", value);
    }

    /// <summary>
    /// SecretValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlockSecretValueBlock>? SecretValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlockSecretValueBlock>>("secret_value");
        set => SetArgument("secret_value", value);
    }

}

/// <summary>
/// Block type for encryption_key_value in GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key_value";

    /// <summary>
    /// The [KMS key name] with which the content of the Operation is encrypted. The
    /// expected format: projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// Will be empty string if google managed.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Type of Encryption Key Possible values: [&amp;quot;GOOGLE_MANAGED&amp;quot;, &amp;quot;CUSTOMER_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for secret_value in GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockAdditionalVariableBlockSecretValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_value";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for oauth2_auth_code_flow in GoogleIntegrationConnectorsConnectionAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_auth_code_flow";

    /// <summary>
    /// Auth URL for Authorization Code Flow.
    /// </summary>
    public TerraformValue<string>? AuthUri
    {
        get => new TerraformReference<string>(this, "auth_uri");
        set => SetArgument("auth_uri", value);
    }

    /// <summary>
    /// Client ID for user-provided OAuth app.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// Whether to enable PKCE when the user performs the auth code flow.
    /// </summary>
    public TerraformValue<bool>? EnablePkce
    {
        get => new TerraformReference<bool>(this, "enable_pkce");
        set => SetArgument("enable_pkce", value);
    }

    /// <summary>
    /// Scopes the connection will request when the user performs the auth code flow.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// ClientSecret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSecret block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlockClientSecretBlock>? ClientSecret
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlockClientSecretBlock>>("client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for client_secret in GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2AuthCodeFlowBlockClientSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_secret";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for oauth2_client_credentials in GoogleIntegrationConnectorsConnectionAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_client_credentials";

    /// <summary>
    /// Secret version of Password for Authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// ClientSecret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSecret block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlockClientSecretBlock>? ClientSecret
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlockClientSecretBlock>>("client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for client_secret in GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2ClientCredentialsBlockClientSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_secret";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for oauth2_jwt_bearer in GoogleIntegrationConnectorsConnectionAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_jwt_bearer";

    /// <summary>
    /// ClientKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientKey block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlockClientKeyBlock>? ClientKey
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlockClientKeyBlock>>("client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// JwtClaims block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtClaims block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlockJwtClaimsBlock>? JwtClaims
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlockJwtClaimsBlock>>("jwt_claims");
        set => SetArgument("jwt_claims", value);
    }

}

/// <summary>
/// Block type for client_key in GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlockClientKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_key";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for jwt_claims in GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockOauth2JwtBearerBlockJwtClaimsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jwt_claims";

    /// <summary>
    /// Value for the &amp;quot;aud&amp;quot; claim.
    /// </summary>
    public TerraformValue<string>? Audience
    {
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// Value for the &amp;quot;iss&amp;quot; claim.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// Value for the &amp;quot;sub&amp;quot; claim.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

}

/// <summary>
/// Block type for ssh_public_key in GoogleIntegrationConnectorsConnectionAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_public_key";

    /// <summary>
    /// Format of SSH Client cert.
    /// </summary>
    public TerraformValue<string>? CertType
    {
        get => new TerraformReference<string>(this, "cert_type");
        set => SetArgument("cert_type", value);
    }

    /// <summary>
    /// The user account used to authenticate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// SshClientCert block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshClientCert block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlockSshClientCertBlock>? SshClientCert
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlockSshClientCertBlock>>("ssh_client_cert");
        set => SetArgument("ssh_client_cert", value);
    }

    /// <summary>
    /// SshClientCertPass block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshClientCertPass block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlockSshClientCertPassBlock>? SshClientCertPass
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlockSshClientCertPassBlock>>("ssh_client_cert_pass");
        set => SetArgument("ssh_client_cert_pass", value);
    }

}

/// <summary>
/// Block type for ssh_client_cert in GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlockSshClientCertBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_client_cert";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for ssh_client_cert_pass in GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockSshPublicKeyBlockSshClientCertPassBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_client_cert_pass";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for user_password in GoogleIntegrationConnectorsConnectionAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_password";

    /// <summary>
    /// Username for Authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Password block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlockPasswordBlock>? Password
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlockPasswordBlock>>("password");
        set => SetArgument("password", value);
    }

}

/// <summary>
/// Block type for password in GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlockUserPasswordBlockPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for config_variable in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionConfigVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_variable";

    /// <summary>
    /// Boolean Value of configVariable
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => new TerraformReference<bool>(this, "boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Integer Value of configVariable
    /// </summary>
    public TerraformValue<double>? IntegerValue
    {
        get => new TerraformReference<double>(this, "integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// String Value of configVariabley
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// EncryptionKeyValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKeyValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlockEncryptionKeyValueBlock>? EncryptionKeyValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlockEncryptionKeyValueBlock>>("encryption_key_value");
        set => SetArgument("encryption_key_value", value);
    }

    /// <summary>
    /// SecretValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlockSecretValueBlock>? SecretValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlockSecretValueBlock>>("secret_value");
        set => SetArgument("secret_value", value);
    }

}

/// <summary>
/// Block type for encryption_key_value in GoogleIntegrationConnectorsConnectionConfigVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionConfigVariableBlockEncryptionKeyValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key_value";

    /// <summary>
    /// The [KMS key name] with which the content of the Operation is encrypted. The
    /// expected format: projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// Will be empty string if google managed.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Type of Encryption Key Possible values: [&amp;quot;GOOGLE_MANAGED&amp;quot;, &amp;quot;CUSTOMER_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for secret_value in GoogleIntegrationConnectorsConnectionConfigVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionConfigVariableBlockSecretValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_value";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for destination_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_config";

    /// <summary>
    /// The key is the destination identifier that is supported by the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionDestinationConfigBlockDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionDestinationConfigBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in GoogleIntegrationConnectorsConnectionDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionDestinationConfigBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// For publicly routable host.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port is the target port number that is accepted by the destination.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// PSC service attachments. Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    public TerraformValue<string>? ServiceAttachment
    {
        get => new TerraformReference<string>(this, "service_attachment");
        set => SetArgument("service_attachment", value);
    }

}


/// <summary>
/// Block type for eventing_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eventing_config";

    /// <summary>
    /// Enrichment Enabled.
    /// </summary>
    public TerraformValue<bool>? EnrichmentEnabled
    {
        get => new TerraformReference<bool>(this, "enrichment_enabled");
        set => SetArgument("enrichment_enabled", value);
    }

    /// <summary>
    /// AdditionalVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlock>? AdditionalVariable
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlock>>("additional_variable");
        set => SetArgument("additional_variable", value);
    }

    /// <summary>
    /// AuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlock>? AuthConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlock>>("auth_config");
        set => SetArgument("auth_config", value);
    }

    /// <summary>
    /// RegistrationDestinationConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistrationDestinationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RegistrationDestinationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrationDestinationConfig block(s) allowed")]
    public required TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlock> RegistrationDestinationConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlock>>("registration_destination_config");
        set => SetArgument("registration_destination_config", value);
    }

}

/// <summary>
/// Block type for additional_variable in GoogleIntegrationConnectorsConnectionEventingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_variable";

    /// <summary>
    /// Boolean Value of configVariable.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => new TerraformReference<bool>(this, "boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Integer Value of configVariable.
    /// </summary>
    public TerraformValue<double>? IntegerValue
    {
        get => new TerraformReference<double>(this, "integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// String Value of configVariabley.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// EncryptionKeyValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKeyValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>? EncryptionKeyValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>>("encryption_key_value");
        set => SetArgument("encryption_key_value", value);
    }

    /// <summary>
    /// SecretValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlockSecretValueBlock>? SecretValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlockSecretValueBlock>>("secret_value");
        set => SetArgument("secret_value", value);
    }

}

/// <summary>
/// Block type for encryption_key_value in GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key_value";

    /// <summary>
    /// The [KMS key name] with which the content of the Operation is encrypted. The
    /// expected format: projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// Will be empty string if google managed.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Type of Encryption Key Possible values: [&amp;quot;GOOGLE_MANAGED&amp;quot;, &amp;quot;CUSTOMER_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for secret_value in GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAdditionalVariableBlockSecretValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_value";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for auth_config in GoogleIntegrationConnectorsConnectionEventingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_config";

    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public TerraformValue<string>? AuthKey
    {
        get => new TerraformReference<string>(this, "auth_key");
        set => SetArgument("auth_key", value);
    }

    /// <summary>
    /// authType of the Connection Possible values: [&amp;quot;USER_PASSWORD&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// AdditionalVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlock>? AdditionalVariable
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlock>>("additional_variable");
        set => SetArgument("additional_variable", value);
    }

    /// <summary>
    /// UserPassword block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPassword is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserPassword block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPassword block(s) allowed")]
    public required TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlock> UserPassword
    {
        get => GetRequiredArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlock>>("user_password");
        set => SetArgument("user_password", value);
    }

}

/// <summary>
/// Block type for additional_variable in GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_variable";

    /// <summary>
    /// Boolean Value of configVariable.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => new TerraformReference<bool>(this, "boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Integer Value of configVariable.
    /// </summary>
    public TerraformValue<double>? IntegerValue
    {
        get => new TerraformReference<double>(this, "integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// String Value of configVariabley.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// EncryptionKeyValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKeyValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>? EncryptionKeyValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>>("encryption_key_value");
        set => SetArgument("encryption_key_value", value);
    }

    /// <summary>
    /// SecretValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlockSecretValueBlock>? SecretValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlockSecretValueBlock>>("secret_value");
        set => SetArgument("secret_value", value);
    }

}

/// <summary>
/// Block type for encryption_key_value in GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key_value";

    /// <summary>
    /// The [KMS key name] with which the content of the Operation is encrypted. The
    /// expected format: projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// Will be empty string if google managed.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Type of Encryption Key Possible values: [&amp;quot;GOOGLE_MANAGED&amp;quot;, &amp;quot;CUSTOMER_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for secret_value in GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockAdditionalVariableBlockSecretValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_value";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for user_password in GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_password";

    /// <summary>
    /// Username for Authentication.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Password block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlockPasswordBlock>? Password
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlockPasswordBlock>>("password");
        set => SetArgument("password", value);
    }

}

/// <summary>
/// Block type for password in GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockAuthConfigBlockUserPasswordBlockPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: projects/*/secrets/*/versions/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for registration_destination_config in GoogleIntegrationConnectorsConnectionEventingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registration_destination_config";

    /// <summary>
    /// Key for the connection
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlockDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlockRegistrationDestinationConfigBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// Host
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// port number
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Service Attachment
    /// </summary>
    public TerraformValue<string>? ServiceAttachment
    {
        get => new TerraformReference<string>(this, "service_attachment");
        set => SetArgument("service_attachment", value);
    }

}


/// <summary>
/// Block type for lock_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionLockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lock_config";

    /// <summary>
    /// Indicates whether or not the connection is locked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locked is required")]
    public required TerraformValue<bool> Locked
    {
        get => new TerraformReference<bool>(this, "locked");
        set => SetArgument("locked", value);
    }

    /// <summary>
    /// Describes why a connection is locked.
    /// </summary>
    public TerraformValue<string>? Reason
    {
        get => new TerraformReference<string>(this, "reason");
        set => SetArgument("reason", value);
    }

}


/// <summary>
/// Block type for log_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// Enabled represents whether logging is enabled or not for a connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Log configuration level. Possible values: [&amp;quot;LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;DEBUG&amp;quot;]
    /// </summary>
    public TerraformValue<string> Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    public TerraformValue<double> MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    public TerraformValue<double> MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for ssl_config in GoogleIntegrationConnectorsConnection.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_config";

    /// <summary>
    /// Type of Client Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ClientCertType
    {
        get => new TerraformReference<string>(this, "client_cert_type");
        set => SetArgument("client_cert_type", value);
    }

    /// <summary>
    /// Type of Server Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ServerCertType
    {
        get => new TerraformReference<string>(this, "server_cert_type");
        set => SetArgument("server_cert_type", value);
    }

    /// <summary>
    /// Enum for Trust Model Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;, &amp;quot;INSECURE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TrustModel
    {
        get => new TerraformReference<string>(this, "trust_model");
        set => SetArgument("trust_model", value);
    }

    /// <summary>
    /// Enum for controlling the SSL Type (TLS/MTLS) Possible values: [&amp;quot;TLS&amp;quot;, &amp;quot;MTLS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Bool for enabling SSL
    /// </summary>
    public TerraformValue<bool>? UseSsl
    {
        get => new TerraformReference<bool>(this, "use_ssl");
        set => SetArgument("use_ssl", value);
    }

    /// <summary>
    /// AdditionalVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlock>? AdditionalVariable
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlock>>("additional_variable");
        set => SetArgument("additional_variable", value);
    }

    /// <summary>
    /// ClientCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockClientCertificateBlock>? ClientCertificate
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockClientCertificateBlock>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// ClientPrivateKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientPrivateKey block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockClientPrivateKeyBlock>? ClientPrivateKey
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockClientPrivateKeyBlock>>("client_private_key");
        set => SetArgument("client_private_key", value);
    }

    /// <summary>
    /// ClientPrivateKeyPass block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientPrivateKeyPass block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockClientPrivateKeyPassBlock>? ClientPrivateKeyPass
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockClientPrivateKeyPassBlock>>("client_private_key_pass");
        set => SetArgument("client_private_key_pass", value);
    }

    /// <summary>
    /// PrivateServerCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServerCertificate block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockPrivateServerCertificateBlock>? PrivateServerCertificate
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockPrivateServerCertificateBlock>>("private_server_certificate");
        set => SetArgument("private_server_certificate", value);
    }

}

/// <summary>
/// Block type for additional_variable in GoogleIntegrationConnectorsConnectionSslConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_variable";

    /// <summary>
    /// Boolean Value of configVariable.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => new TerraformReference<bool>(this, "boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Integer Value of configVariable.
    /// </summary>
    public TerraformValue<double>? IntegerValue
    {
        get => new TerraformReference<double>(this, "integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// String Value of configVariabley.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// EncryptionKeyValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKeyValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>? EncryptionKeyValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock>>("encryption_key_value");
        set => SetArgument("encryption_key_value", value);
    }

    /// <summary>
    /// SecretValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretValue block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlockSecretValueBlock>? SecretValue
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlockSecretValueBlock>>("secret_value");
        set => SetArgument("secret_value", value);
    }

}

/// <summary>
/// Block type for encryption_key_value in GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlockEncryptionKeyValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key_value";

    /// <summary>
    /// The [KMS key name] with which the content of the Operation is encrypted. The
    /// expected format: projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// Will be empty string if google managed.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Type of Encryption Key Possible values: [&amp;quot;GOOGLE_MANAGED&amp;quot;, &amp;quot;CUSTOMER_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for secret_value in GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockAdditionalVariableBlockSecretValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_value";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for client_certificate in GoogleIntegrationConnectorsConnectionSslConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockClientCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for client_private_key in GoogleIntegrationConnectorsConnectionSslConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockClientPrivateKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_private_key";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for client_private_key_pass in GoogleIntegrationConnectorsConnectionSslConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockClientPrivateKeyPassBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_private_key_pass";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for private_server_certificate in GoogleIntegrationConnectorsConnectionSslConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlockPrivateServerCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_server_certificate";

    /// <summary>
    /// Secret version of Secret Value for Config variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIntegrationConnectorsConnection.
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationConnectorsConnectionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_integration_connectors_connection Terraform resource.
/// Manages a google_integration_connectors_connection resource.
/// </summary>
public partial class GoogleIntegrationConnectorsConnection(string name) : TerraformResource("google_integration_connectors_connection", name)
{
    /// <summary>
    /// connectorVersion of the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorVersion is required")]
    public required TerraformValue<string> ConnectorVersion
    {
        get => new TerraformReference<string>(this, "connector_version");
        set => SetArgument("connector_version", value);
    }

    /// <summary>
    /// An arbitrary description for the Connection.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Eventing enablement type. Will be nil if eventing is not enabled. Possible values: [&amp;quot;EVENTING_AND_CONNECTION&amp;quot;, &amp;quot;ONLY_EVENTING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EventingEnablementType
    {
        get => new TerraformReference<string>(this, "eventing_enablement_type");
        set => SetArgument("eventing_enablement_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location in which Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Service account needed for runtime plane to access Google Cloud resources.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Suspended indicates if a user has suspended a connection or not.
    /// </summary>
    public TerraformValue<bool>? Suspended
    {
        get => new TerraformReference<bool>(this, "suspended");
        set => SetArgument("suspended", value);
    }

    /// <summary>
    /// Connection revision. This field is only updated when the connection is created or updated by User.
    /// </summary>
    public TerraformValue<string> ConnectionRevision
    {
        get => new TerraformReference<string>(this, "connection_revision");
    }

    /// <summary>
    /// This configuration provides infra configs like rate limit threshold which need to be configurable for every connector version.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectorVersionInfraConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connector_version_infra_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Flag to mark the version indicating the launch stage.
    /// </summary>
    public TerraformValue<string> ConnectorVersionLaunchStage
    {
        get => new TerraformReference<string>(this, "connector_version_launch_stage");
    }

    /// <summary>
    /// Time the Namespace was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Eventing Runtime Data.
    /// </summary>
    public TerraformList<TerraformMap<object>> EventingRuntimeData
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "eventing_runtime_data").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB address.
    /// e.g. &amp;quot;projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors&amp;quot;
    /// </summary>
    public TerraformValue<string> ServiceDirectory
    {
        get => new TerraformReference<string>(this, "service_directory");
    }

    /// <summary>
    /// Status of the Integration Connector.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// This subscription type enum states the subscription type of the project.
    /// </summary>
    public TerraformValue<string> SubscriptionType
    {
        get => new TerraformReference<string>(this, "subscription_type");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time the Namespace was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// AuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlock>? AuthConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlock>>("auth_config");
        set => SetArgument("auth_config", value);
    }

    /// <summary>
    /// ConfigVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlock>? ConfigVariable
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlock>>("config_variable");
        set => SetArgument("config_variable", value);
    }

    /// <summary>
    /// DestinationConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIntegrationConnectorsConnectionDestinationConfigBlock>? DestinationConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionDestinationConfigBlock>>("destination_config");
        set => SetArgument("destination_config", value);
    }

    /// <summary>
    /// EventingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventingConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlock>? EventingConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlock>>("eventing_config");
        set => SetArgument("eventing_config", value);
    }

    /// <summary>
    /// LockConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionLockConfigBlock>? LockConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionLockConfigBlock>>("lock_config");
        set => SetArgument("lock_config", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// SslConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlock>? SslConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlock>>("ssl_config");
        set => SetArgument("ssl_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIntegrationConnectorsConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIntegrationConnectorsConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
