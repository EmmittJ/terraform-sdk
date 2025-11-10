using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate and create webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("webhook_secret_secret_version");
        set => WithProperty("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Workspace is required")]
    public required TerraformProperty<string> Workspace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace");
        set => WithProperty("workspace", value);
    }

}

/// <summary>
/// Block type for bitbucket_data_center_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("host_uri");
        set => WithProperty("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the Bitbucket Data Center server running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformProperty<string>? ServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("server_version");
        set => WithProperty("server_version", value);
    }

    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificate
    {
        get => GetProperty<TerraformProperty<string>>("ssl_ca_certificate");
        set => WithProperty("ssl_ca_certificate", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("webhook_secret_secret_version");
        set => WithProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionCryptoKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    public required TerraformProperty<string> KeyReference
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_reference");
        set => WithProperty("key_reference", value);
    }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. GitHub App installation id.
    /// </summary>
    public TerraformProperty<string>? AppInstallationId
    {
        get => GetProperty<TerraformProperty<string>>("app_installation_id");
        set => WithProperty("app_installation_id", value);
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
    public required TerraformProperty<string> GithubApp
    {
        get => GetRequiredProperty<TerraformProperty<string>>("github_app");
        set => WithProperty("github_app", value);
    }

    /// <summary>
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubConfig.
    /// </summary>
    public TerraformProperty<string>? InstallationUri
    {
        get => GetProperty<TerraformProperty<string>>("installation_uri");
        set => WithProperty("installation_uri", value);
    }

}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. ID of the GitHub App created from the manifest.
    /// </summary>
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => WithProperty("app_id", value);
    }

    /// <summary>
    /// Optional. ID of the installation of the GitHub App.
    /// </summary>
    public TerraformProperty<string>? AppInstallationId
    {
        get => GetProperty<TerraformProperty<string>>("app_installation_id");
        set => WithProperty("app_installation_id", value);
    }

    /// <summary>
    /// Output only. The URL-friendly name of the GitHub App.
    /// </summary>
    public TerraformProperty<string>? AppSlug
    {
        get => GetProperty<TerraformProperty<string>>("app_slug");
        set => WithProperty("app_slug", value);
    }

    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("host_uri");
        set => WithProperty("host_uri", value);
    }

    /// <summary>
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubEnterpriseConfig.
    /// </summary>
    public TerraformProperty<string>? InstallationUri
    {
        get => GetProperty<TerraformProperty<string>>("installation_uri");
        set => WithProperty("installation_uri", value);
    }

    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformProperty<string>? PrivateKeySecretVersion
    {
        get => GetProperty<TerraformProperty<string>>("private_key_secret_version");
        set => WithProperty("private_key_secret_version", value);
    }

    /// <summary>
    /// Output only. GitHub Enterprise version installed at the host_uri.
    /// </summary>
    public TerraformProperty<string>? ServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("server_version");
        set => WithProperty("server_version", value);
    }

    /// <summary>
    /// Optional. SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificate
    {
        get => GetProperty<TerraformProperty<string>>("ssl_ca_certificate");
        set => WithProperty("ssl_ca_certificate", value);
    }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformProperty<string>? WebhookSecretSecretVersion
    {
        get => GetProperty<TerraformProperty<string>>("webhook_secret_secret_version");
        set => WithProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("webhook_secret_secret_version");
        set => WithProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for gitlab_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. The URI of the GitLab Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("host_uri");
        set => WithProperty("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the GitLab Enterprise server running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformProperty<string>? ServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("server_version");
        set => WithProperty("server_version", value);
    }

    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificate
    {
        get => GetProperty<TerraformProperty<string>>("ssl_ca_certificate");
        set => WithProperty("ssl_ca_certificate", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("webhook_secret_secret_version");
        set => WithProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectConnectionTimeoutsBlock : TerraformBlock
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
/// Manages a google_developer_connect_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDeveloperConnectConnection : TerraformResource
{
    public GoogleDeveloperConnectConnection(string name) : base("google_developer_connect_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("installation_state");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Required. Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// connection_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
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
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for bitbucket_cloud_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock>? BitbucketCloudConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock>>("bitbucket_cloud_config");
        set => this.WithProperty("bitbucket_cloud_config", value);
    }

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock>? BitbucketDataCenterConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock>>("bitbucket_data_center_config");
        set => this.WithProperty("bitbucket_data_center_config", value);
    }

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock>? CryptoKeyConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock>>("crypto_key_config");
        set => this.WithProperty("crypto_key_config", value);
    }

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionGithubConfigBlock>? GithubConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionGithubConfigBlock>>("github_config");
        set => this.WithProperty("github_config", value);
    }

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock>? GithubEnterpriseConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock>>("github_enterprise_config");
        set => this.WithProperty("github_enterprise_config", value);
    }

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionGitlabConfigBlock>? GitlabConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionGitlabConfigBlock>>("gitlab_config");
        set => this.WithProperty("gitlab_config", value);
    }

    /// <summary>
    /// Block for gitlab_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabEnterpriseConfig block(s) allowed")]
    public List<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock>? GitlabEnterpriseConfig
    {
        get => GetProperty<List<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock>>("gitlab_enterprise_config");
        set => this.WithProperty("gitlab_enterprise_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDeveloperConnectConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDeveloperConnectConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Describes stage and necessary actions to be taken by the
    /// user to complete the installation. Used for GitHub and GitHub Enterprise
    /// based connections.
    /// </summary>
    public TerraformExpression InstallationState => this["installation_state"];

    /// <summary>
    /// Identifier. The resource name of the connection, in the format
    /// &#39;projects/{project}/locations/{location}/connections/{connection_id}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
