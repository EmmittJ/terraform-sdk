using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bitbucket_cloud_config";

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate and create webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformValue<string> WebhookSecretSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("webhook_secret_secret_version");
        set => SetArgument("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Workspace is required")]
    public required TerraformValue<string> Workspace
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace");
        set => SetArgument("workspace", value);
    }

    /// <summary>
    /// AuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}


/// <summary>
/// Block type for bitbucket_data_center_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bitbucket_data_center_config";

    /// <summary>
    /// Required. The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformValue<string> HostUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_uri");
        set => SetArgument("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the Bitbucket Data Center server running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformValue<string> ServerVersion
        => CreateReference("server_version");

    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    public TerraformValue<string>? SslCaCertificate
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca_certificate");
        set => SetArgument("ssl_ca_certificate", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformValue<string> WebhookSecretSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("webhook_secret_secret_version");
        set => SetArgument("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// AuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}

/// <summary>
/// Block type for service_directory_config in GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for crypto_key_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionCryptoKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key_config";

    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    public required TerraformValue<string> KeyReference
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_reference");
        set => SetArgument("key_reference", value);
    }

}


/// <summary>
/// Block type for github_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_config";

    /// <summary>
    /// Optional. GitHub App installation id.
    /// </summary>
    public TerraformValue<string> AppInstallationId
    {
        get => GetArgument<TerraformValue<string>>("app_installation_id") ?? CreateReference("app_installation_id");
        set => SetArgument("app_installation_id", value);
    }

    /// <summary>
    /// Required. Immutable. The GitHub Application that was installed to the GitHub user or
    /// organization.
    /// Possible values:
    /// GIT_HUB_APP_UNSPECIFIED
    /// DEVELOPER_CONNECT
    /// FIREBASE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GithubApp is required")]
    public required TerraformValue<string> GithubApp
    {
        get => GetRequiredArgument<TerraformValue<string>>("github_app");
        set => SetArgument("github_app", value);
    }

    /// <summary>
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubConfig.
    /// </summary>
    public TerraformValue<string> InstallationUri
        => CreateReference("installation_uri");

    /// <summary>
    /// AuthorizerCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerCredential block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGithubConfigBlockAuthorizerCredentialBlock>? AuthorizerCredential
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGithubConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleDeveloperConnectConnectionGithubConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the OAuth token that authorizes
    /// the connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthTokenSecretVersion is required")]
    public required TerraformValue<string> OauthTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("oauth_token_secret_version");
        set => SetArgument("oauth_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}


/// <summary>
/// Block type for github_enterprise_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_enterprise_config";

    /// <summary>
    /// Optional. ID of the GitHub App created from the manifest.
    /// </summary>
    public TerraformValue<string>? AppId
    {
        get => GetArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// Optional. ID of the installation of the GitHub App.
    /// </summary>
    public TerraformValue<string>? AppInstallationId
    {
        get => GetArgument<TerraformValue<string>>("app_installation_id");
        set => SetArgument("app_installation_id", value);
    }

    /// <summary>
    /// Output only. The URL-friendly name of the GitHub App.
    /// </summary>
    public TerraformValue<string> AppSlug
        => CreateReference("app_slug");

    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformValue<string> HostUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_uri");
        set => SetArgument("host_uri", value);
    }

    /// <summary>
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubEnterpriseConfig.
    /// </summary>
    public TerraformValue<string> InstallationUri
        => CreateReference("installation_uri");

    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformValue<string>? PrivateKeySecretVersion
    {
        get => GetArgument<TerraformValue<string>>("private_key_secret_version");
        set => SetArgument("private_key_secret_version", value);
    }

    /// <summary>
    /// Output only. GitHub Enterprise version installed at the host_uri.
    /// </summary>
    public TerraformValue<string> ServerVersion
        => CreateReference("server_version");

    /// <summary>
    /// Optional. SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    public TerraformValue<string>? SslCaCertificate
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca_certificate");
        set => SetArgument("ssl_ca_certificate", value);
    }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformValue<string>? WebhookSecretSecretVersion
    {
        get => GetArgument<TerraformValue<string>>("webhook_secret_secret_version");
        set => SetArgument("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

}

/// <summary>
/// Block type for service_directory_config in GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for gitlab_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gitlab_config";

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformValue<string> WebhookSecretSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("webhook_secret_secret_version");
        set => SetArgument("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// AuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleDeveloperConnectConnectionGitlabConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleDeveloperConnectConnectionGitlabConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}


/// <summary>
/// Block type for gitlab_enterprise_config in GoogleDeveloperConnectConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gitlab_enterprise_config";

    /// <summary>
    /// Required. The URI of the GitLab Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformValue<string> HostUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_uri");
        set => SetArgument("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the GitLab Enterprise server running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformValue<string> ServerVersion
        => CreateReference("server_version");

    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    public TerraformValue<string>? SslCaCertificate
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca_certificate");
        set => SetArgument("ssl_ca_certificate", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformValue<string> WebhookSecretSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("webhook_secret_secret_version");
        set => SetArgument("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// AuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated with this token.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}

/// <summary>
/// Block type for service_directory_config in GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDeveloperConnectConnection.
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a google_developer_connect_connection Terraform resource.
/// Manages a google_developer_connect_connection resource.
/// </summary>
public partial class GoogleDeveloperConnectConnection(string name) : TerraformResource("google_developer_connect_connection", name)
{
    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Required. Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// connection_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string>? Etag
    {
        get => GetArgument<TerraformValue<string>>("etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    public TerraformValue<string> DeleteTime
        => CreateReference("delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Describes stage and necessary actions to be taken by the
    /// user to complete the installation. Used for GitHub and GitHub Enterprise
    /// based connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstallationState
        => CreateReference("installation_state");

    /// <summary>
    /// Identifier. The resource name of the connection, in the format
    /// &#39;projects/{project}/locations/{location}/connections/{connection_id}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// BitbucketCloudConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock>? BitbucketCloudConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock>>("bitbucket_cloud_config");
        set => SetArgument("bitbucket_cloud_config", value);
    }

    /// <summary>
    /// BitbucketDataCenterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock>? BitbucketDataCenterConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock>>("bitbucket_data_center_config");
        set => SetArgument("bitbucket_data_center_config", value);
    }

    /// <summary>
    /// CryptoKeyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock>? CryptoKeyConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock>>("crypto_key_config");
        set => SetArgument("crypto_key_config", value);
    }

    /// <summary>
    /// GithubConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGithubConfigBlock>? GithubConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGithubConfigBlock>>("github_config");
        set => SetArgument("github_config", value);
    }

    /// <summary>
    /// GithubEnterpriseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock>? GithubEnterpriseConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock>>("github_enterprise_config");
        set => SetArgument("github_enterprise_config", value);
    }

    /// <summary>
    /// GitlabConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlock>? GitlabConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlock>>("gitlab_config");
        set => SetArgument("gitlab_config", value);
    }

    /// <summary>
    /// GitlabEnterpriseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabEnterpriseConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock>? GitlabEnterpriseConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock>>("gitlab_enterprise_config");
        set => SetArgument("gitlab_enterprise_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDeveloperConnectConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDeveloperConnectConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
