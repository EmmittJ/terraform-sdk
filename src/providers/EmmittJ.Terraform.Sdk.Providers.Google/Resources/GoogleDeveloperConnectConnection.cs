using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate and create webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebhookSecretSecretVersion { get; set; }

    /// <summary>
    /// Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Workspace is required")]
    [TerraformPropertyName("workspace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Workspace { get; set; }

}

/// <summary>
/// Block type for bitbucket_data_center_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostUri { get; set; }

    /// <summary>
    /// Output only. Version of the Bitbucket Data Center server running on the &#39;host_uri&#39;.
    /// </summary>
    [TerraformPropertyName("server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "server_version");

    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionCryptoKeyConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    [TerraformPropertyName("key_reference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyReference { get; set; }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. GitHub App installation id.
    /// </summary>
    [TerraformPropertyName("app_installation_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AppInstallationId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "app_installation_id");

    /// <summary>
    /// Required. Immutable. The GitHub Application that was installed to the GitHub user or
    /// organization.
    /// Possible values:
    /// GIT_HUB_APP_UNSPECIFIED
    /// DEVELOPER_CONNECT
    /// FIREBASE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GithubApp is required")]
    [TerraformPropertyName("github_app")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GithubApp { get; set; }

    /// <summary>
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubConfig.
    /// </summary>
    [TerraformPropertyName("installation_uri")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstallationUri => new TerraformReferenceProperty<TerraformProperty<string>>("", "installation_uri");

}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. ID of the GitHub App created from the manifest.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppId { get; set; }

    /// <summary>
    /// Optional. ID of the installation of the GitHub App.
    /// </summary>
    [TerraformPropertyName("app_installation_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppInstallationId { get; set; }

    /// <summary>
    /// Output only. The URL-friendly name of the GitHub App.
    /// </summary>
    [TerraformPropertyName("app_slug")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppSlug => new TerraformReferenceProperty<TerraformProperty<string>>("", "app_slug");

    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostUri { get; set; }

    /// <summary>
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubEnterpriseConfig.
    /// </summary>
    [TerraformPropertyName("installation_uri")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstallationUri => new TerraformReferenceProperty<TerraformProperty<string>>("", "installation_uri");

    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformPropertyName("private_key_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKeySecretVersion { get; set; }

    /// <summary>
    /// Output only. GitHub Enterprise version installed at the host_uri.
    /// </summary>
    [TerraformPropertyName("server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "server_version");

    /// <summary>
    /// Optional. SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslCaCertificate { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The URI of the GitLab Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostUri { get; set; }

    /// <summary>
    /// Output only. Version of the GitLab Enterprise server running on the &#39;host_uri&#39;.
    /// </summary>
    [TerraformPropertyName("server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "server_version");

    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectConnectionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_developer_connect_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDeveloperConnectConnection : TerraformResource
{
    public GoogleDeveloperConnectConnection(string name) : base("google_developer_connect_connection", name)
    {
    }

    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// Required. Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// connection_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for bitbucket_cloud_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    [TerraformPropertyName("bitbucket_cloud_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock>>? BitbucketCloudConfig { get; set; } = new();

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    [TerraformPropertyName("bitbucket_data_center_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock>>? BitbucketDataCenterConfig { get; set; } = new();

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    [TerraformPropertyName("crypto_key_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock>>? CryptoKeyConfig { get; set; } = new();

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    [TerraformPropertyName("github_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGithubConfigBlock>>? GithubConfig { get; set; } = new();

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    [TerraformPropertyName("github_enterprise_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock>>? GithubEnterpriseConfig { get; set; } = new();

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    [TerraformPropertyName("gitlab_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGitlabConfigBlock>>? GitlabConfig { get; set; } = new();

    /// <summary>
    /// Block for gitlab_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabEnterpriseConfig block(s) allowed")]
    [TerraformPropertyName("gitlab_enterprise_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock>>? GitlabEnterpriseConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDeveloperConnectConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Describes stage and necessary actions to be taken by the
    /// user to complete the installation. Used for GitHub and GitHub Enterprise
    /// based connections.
    /// </summary>
    [TerraformPropertyName("installation_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstallationState => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "installation_state");

    /// <summary>
    /// Identifier. The resource name of the connection, in the format
    /// &#39;projects/{project}/locations/{location}/connections/{connection_id}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
