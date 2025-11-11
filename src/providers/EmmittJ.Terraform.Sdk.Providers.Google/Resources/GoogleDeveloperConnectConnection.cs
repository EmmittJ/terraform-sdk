using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate and create webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretSecretVersion { get; set; }

    /// <summary>
    /// Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Workspace is required")]
    [TerraformPropertyName("workspace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Workspace { get; set; }

}

/// <summary>
/// Block type for bitbucket_data_center_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock
{
    /// <summary>
    /// Required. The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionCryptoKeyConfigBlock
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    [TerraformPropertyName("key_reference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyReference { get; set; }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubConfigBlock
{
    /// <summary>
    /// Optional. GitHub App installation id.
    /// </summary>
    [TerraformPropertyName("app_installation_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AppInstallationId { get; set; } = default!;

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
    public required TerraformValue<string> GithubApp { get; set; }


}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock
{
    /// <summary>
    /// Optional. ID of the GitHub App created from the manifest.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppId { get; set; }

    /// <summary>
    /// Optional. ID of the installation of the GitHub App.
    /// </summary>
    [TerraformPropertyName("app_installation_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppInstallationId { get; set; }


    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformPropertyName("private_key_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKeySecretVersion { get; set; }


    /// <summary>
    /// Optional. SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCaCertificate { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabConfigBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock
{
    /// <summary>
    /// Required. The URI of the GitLab Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectConnectionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Required. Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// connection_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for bitbucket_cloud_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    [TerraformPropertyName("bitbucket_cloud_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock>>? BitbucketCloudConfig { get; set; }

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    [TerraformPropertyName("bitbucket_data_center_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock>>? BitbucketDataCenterConfig { get; set; }

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    [TerraformPropertyName("crypto_key_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock>>? CryptoKeyConfig { get; set; }

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    [TerraformPropertyName("github_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGithubConfigBlock>>? GithubConfig { get; set; }

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    [TerraformPropertyName("github_enterprise_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock>>? GithubEnterpriseConfig { get; set; }

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    [TerraformPropertyName("gitlab_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGitlabConfigBlock>>? GitlabConfig { get; set; }

    /// <summary>
    /// Block for gitlab_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabEnterpriseConfig block(s) allowed")]
    [TerraformPropertyName("gitlab_enterprise_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock>>? GitlabEnterpriseConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDeveloperConnectConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeleteTime => new TerraformReference(this, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Describes stage and necessary actions to be taken by the
    /// user to complete the installation. Used for GitHub and GitHub Enterprise
    /// based connections.
    /// </summary>
    [TerraformPropertyName("installation_state")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstallationState => new TerraformReference(this, "installation_state");

    /// <summary>
    /// Identifier. The resource name of the connection, in the format
    /// &#39;projects/{project}/locations/{location}/connections/{connection_id}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
