using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in GoogleCloudbuildv2Connection.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bitbucket_cloud_config";

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformValue<string> WebhookSecretSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("webhook_secret_secret_version");
        set => SetArgument("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
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
    public required TerraformList<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}


/// <summary>
/// Block type for bitbucket_data_center_config in GoogleCloudbuildv2Connection.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bitbucket_data_center_config";

    /// <summary>
    /// The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformValue<string> HostUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_uri");
        set => SetArgument("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the Bitbucket Data Center running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformValue<string> ServerVersion
        => AsReference("server_version");

    /// <summary>
    /// SSL certificate to use for requests to the Bitbucket Data Center.
    /// </summary>
    public TerraformValue<string>? SslCa
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca");
        set => SetArgument("ssl_ca", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
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
    public required TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}

/// <summary>
/// Block type for service_directory_config in GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// Required. The Service Directory service name. Format: projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for github_config in GoogleCloudbuildv2Connection.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_config";

    /// <summary>
    /// GitHub App installation id.
    /// </summary>
    public TerraformValue<double>? AppInstallationId
    {
        get => GetArgument<TerraformValue<double>>("app_installation_id");
        set => SetArgument("app_installation_id", value);
    }

    /// <summary>
    /// AuthorizerCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerCredential block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionGithubConfigBlockAuthorizerCredentialBlock>? AuthorizerCredential
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionGithubConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleCloudbuildv2ConnectionGithubConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// A SecretManager resource containing the OAuth token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformValue<string>? OauthTokenSecretVersion
    {
        get => GetArgument<TerraformValue<string>>("oauth_token_secret_version");
        set => SetArgument("oauth_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}


/// <summary>
/// Block type for github_enterprise_config in GoogleCloudbuildv2Connection.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_enterprise_config";

    /// <summary>
    /// Id of the GitHub App created from the manifest.
    /// </summary>
    public TerraformValue<double>? AppId
    {
        get => GetArgument<TerraformValue<double>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// ID of the installation of the GitHub App.
    /// </summary>
    public TerraformValue<double>? AppInstallationId
    {
        get => GetArgument<TerraformValue<double>>("app_installation_id");
        set => SetArgument("app_installation_id", value);
    }

    /// <summary>
    /// The URL-friendly name of the GitHub App.
    /// </summary>
    public TerraformValue<string>? AppSlug
    {
        get => GetArgument<TerraformValue<string>>("app_slug");
        set => SetArgument("app_slug", value);
    }

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
    /// SecretManager resource containing the private key of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformValue<string>? PrivateKeySecretVersion
    {
        get => GetArgument<TerraformValue<string>>("private_key_secret_version");
        set => SetArgument("private_key_secret_version", value);
    }

    /// <summary>
    /// SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    public TerraformValue<string>? SslCa
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca");
        set => SetArgument("ssl_ca", value);
    }

    /// <summary>
    /// SecretManager resource containing the webhook secret of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
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
    public TerraformList<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

}

/// <summary>
/// Block type for service_directory_config in GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// Required. The Service Directory service name. Format: projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for gitlab_config in GoogleCloudbuildv2Connection.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGitlabConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gitlab_config";

    /// <summary>
    /// The URI of the GitLab Enterprise host this connection is for. If not specified, the default value is https://gitlab.com.
    /// </summary>
    public TerraformValue<string> HostUri
    {
        get => GetArgument<TerraformValue<string>>("host_uri") ?? AsReference("host_uri");
        set => SetArgument("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the GitLab Enterprise server running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformValue<string> ServerVersion
        => AsReference("server_version");

    /// <summary>
    /// SSL certificate to use for requests to GitLab Enterprise.
    /// </summary>
    public TerraformValue<string>? SslCa
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca");
        set => SetArgument("ssl_ca", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab Enterprise project, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
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
    public required TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlockAuthorizerCredentialBlock> AuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlockAuthorizerCredentialBlock>>("authorizer_credential");
        set => SetArgument("authorizer_credential", value);
    }

    /// <summary>
    /// ReadAuthorizerCredential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAuthorizerCredential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadAuthorizerCredential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadAuthorizerCredential block(s) allowed")]
    public required TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlockReadAuthorizerCredentialBlock> ReadAuthorizerCredential
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlockReadAuthorizerCredentialBlock>>("read_authorizer_credential");
        set => SetArgument("read_authorizer_credential", value);
    }

    /// <summary>
    /// ServiceDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlockServiceDirectoryConfigBlock>? ServiceDirectoryConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlockServiceDirectoryConfigBlock>>("service_directory_config");
        set => SetArgument("service_directory_config", value);
    }

}

/// <summary>
/// Block type for authorizer_credential in GoogleCloudbuildv2ConnectionGitlabConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGitlabConfigBlockAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}

/// <summary>
/// Block type for read_authorizer_credential in GoogleCloudbuildv2ConnectionGitlabConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGitlabConfigBlockReadAuthorizerCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_authorizer_credential";

    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserTokenSecretVersion is required")]
    public required TerraformValue<string> UserTokenSecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_token_secret_version");
        set => SetArgument("user_token_secret_version", value);
    }

    /// <summary>
    /// Output only. The username associated to this token.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}

/// <summary>
/// Block type for service_directory_config in GoogleCloudbuildv2ConnectionGitlabConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGitlabConfigBlockServiceDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_config";

    /// <summary>
    /// Required. The Service Directory service name. Format: projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudbuildv2Connection.
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildv2ConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloudbuildv2_connection Terraform resource.
/// Manages a google_cloudbuildv2_connection resource.
/// </summary>
public partial class GoogleCloudbuildv2Connection(string name) : TerraformResource("google_cloudbuildv2_connection", name)
{
    /// <summary>
    /// Allows clients to store small amounts of arbitrary data.
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
    /// If disabled is set to true, functionality is disabled for this connection. Repository based API methods and webhooks processing for repositories in this connection will be disabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Immutable. The resource name of the connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output only. Installation state of the Connection.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstallationState
        => AsReference("installation_state");

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the background.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// BitbucketCloudConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock>? BitbucketCloudConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock>>("bitbucket_cloud_config");
        set => SetArgument("bitbucket_cloud_config", value);
    }

    /// <summary>
    /// BitbucketDataCenterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock>? BitbucketDataCenterConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock>>("bitbucket_data_center_config");
        set => SetArgument("bitbucket_data_center_config", value);
    }

    /// <summary>
    /// GithubConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionGithubConfigBlock>? GithubConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionGithubConfigBlock>>("github_config");
        set => SetArgument("github_config", value);
    }

    /// <summary>
    /// GithubEnterpriseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock>? GithubEnterpriseConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock>>("github_enterprise_config");
        set => SetArgument("github_enterprise_config", value);
    }

    /// <summary>
    /// GitlabConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    public TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlock>? GitlabConfig
    {
        get => GetArgument<TerraformList<GoogleCloudbuildv2ConnectionGitlabConfigBlock>>("gitlab_config");
        set => SetArgument("gitlab_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudbuildv2ConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudbuildv2ConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
