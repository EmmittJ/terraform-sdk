using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock() : TerraformBlock("bitbucket_cloud_config")
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate and create webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformProperty("webhook_secret_secret_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretSecretVersion { get; set; }

    /// <summary>
    /// Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Workspace is required")]
    [TerraformProperty("workspace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Workspace { get; set; }

}

/// <summary>
/// Block type for bitbucket_data_center_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock() : TerraformBlock("bitbucket_data_center_config")
{
    /// <summary>
    /// Required. The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformProperty("host_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    [TerraformProperty("ssl_ca_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to
    /// validate webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformProperty("webhook_secret_secret_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionCryptoKeyConfigBlock() : TerraformBlock("crypto_key_config")
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    [TerraformProperty("key_reference")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyReference { get; set; }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionGithubConfigBlock() : TerraformBlock("github_config")
{
    /// <summary>
    /// Optional. GitHub App installation id.
    /// </summary>
    [TerraformProperty("app_installation_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AppInstallationId { get; set; }

    /// <summary>
    /// Required. Immutable. The GitHub Application that was installed to the GitHub user or
    /// organization.
    /// Possible values:
    /// GIT_HUB_APP_UNSPECIFIED
    /// DEVELOPER_CONNECT
    /// FIREBASE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GithubApp is required")]
    [TerraformProperty("github_app")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GithubApp { get; set; }


}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock() : TerraformBlock("github_enterprise_config")
{
    /// <summary>
    /// Optional. ID of the GitHub App created from the manifest.
    /// </summary>
    [TerraformProperty("app_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AppId { get; set; }

    /// <summary>
    /// Optional. ID of the installation of the GitHub App.
    /// </summary>
    [TerraformProperty("app_installation_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AppInstallationId { get; set; }


    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformProperty("host_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformProperty("private_key_secret_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateKeySecretVersion { get; set; }


    /// <summary>
    /// Optional. SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    [TerraformProperty("ssl_ca_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCaCertificate { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformProperty("webhook_secret_secret_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionGitlabConfigBlock() : TerraformBlock("gitlab_config")
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformProperty("webhook_secret_secret_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_enterprise_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock() : TerraformBlock("gitlab_enterprise_config")
{
    /// <summary>
    /// Required. The URI of the GitLab Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformProperty("host_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    [TerraformProperty("ssl_ca_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as &#39;projects/*/secrets/*/versions/*&#39;. This is used to validate
    /// webhooks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformProperty("webhook_secret_secret_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDeveloperConnectConnectionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_developer_connect_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDeveloperConnectConnection : TerraformResource
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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Required. Id of the requesting object
    /// If auto-generating Id server-side, remove this field and
    /// connection_id from the method_signature of Create RPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for bitbucket_cloud_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    [TerraformProperty("bitbucket_cloud_config")]
    public TerraformList<GoogleDeveloperConnectConnectionBitbucketCloudConfigBlock> BitbucketCloudConfig { get; set; } = new();

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    [TerraformProperty("bitbucket_data_center_config")]
    public TerraformList<GoogleDeveloperConnectConnectionBitbucketDataCenterConfigBlock> BitbucketDataCenterConfig { get; set; } = new();

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    [TerraformProperty("crypto_key_config")]
    public TerraformList<GoogleDeveloperConnectConnectionCryptoKeyConfigBlock> CryptoKeyConfig { get; set; } = new();

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    [TerraformProperty("github_config")]
    public TerraformList<GoogleDeveloperConnectConnectionGithubConfigBlock> GithubConfig { get; set; } = new();

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    [TerraformProperty("github_enterprise_config")]
    public TerraformList<GoogleDeveloperConnectConnectionGithubEnterpriseConfigBlock> GithubEnterpriseConfig { get; set; } = new();

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    [TerraformProperty("gitlab_config")]
    public TerraformList<GoogleDeveloperConnectConnectionGitlabConfigBlock> GitlabConfig { get; set; } = new();

    /// <summary>
    /// Block for gitlab_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabEnterpriseConfig block(s) allowed")]
    [TerraformProperty("gitlab_enterprise_config")]
    public TerraformList<GoogleDeveloperConnectConnectionGitlabEnterpriseConfigBlock> GitlabEnterpriseConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDeveloperConnectConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Describes stage and necessary actions to be taken by the
    /// user to complete the installation. Used for GitHub and GitHub Enterprise
    /// based connections.
    /// </summary>
    [TerraformProperty("installation_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InstallationState { get; }

    /// <summary>
    /// Identifier. The resource name of the connection, in the format
    /// &#39;projects/{project}/locations/{location}/connections/{connection_id}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
