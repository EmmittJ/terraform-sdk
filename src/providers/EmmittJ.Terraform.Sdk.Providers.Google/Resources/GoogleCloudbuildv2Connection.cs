using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformProperty("webhook_secret_secret_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretSecretVersion { get; set; }

    /// <summary>
    /// The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
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
public partial class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformProperty("host_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// SSL certificate to use for requests to the Bitbucket Data Center.
    /// </summary>
    [TerraformProperty("ssl_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformProperty("webhook_secret_secret_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildv2ConnectionGithubConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// GitHub App installation id.
    /// </summary>
    [TerraformProperty("app_installation_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AppInstallationId { get; set; }

}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Id of the GitHub App created from the manifest.
    /// </summary>
    [TerraformProperty("app_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AppId { get; set; }

    /// <summary>
    /// ID of the installation of the GitHub App.
    /// </summary>
    [TerraformProperty("app_installation_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AppInstallationId { get; set; }

    /// <summary>
    /// The URL-friendly name of the GitHub App.
    /// </summary>
    [TerraformProperty("app_slug")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AppSlug { get; set; }

    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformProperty("host_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostUri { get; set; }

    /// <summary>
    /// SecretManager resource containing the private key of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformProperty("private_key_secret_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateKeySecretVersion { get; set; }

    /// <summary>
    /// SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    [TerraformProperty("ssl_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// SecretManager resource containing the webhook secret of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformProperty("webhook_secret_secret_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildv2ConnectionGitlabConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The URI of the GitLab Enterprise host this connection is for. If not specified, the default value is https://gitlab.com.
    /// </summary>
    [TerraformProperty("host_uri")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// SSL certificate to use for requests to GitLab Enterprise.
    /// </summary>
    [TerraformProperty("ssl_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab Enterprise project, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
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
public partial class GoogleCloudbuildv2ConnectionTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_cloudbuildv2_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudbuildv2Connection : TerraformResource
{
    public GoogleCloudbuildv2Connection(string name) : base("google_cloudbuildv2_connection", name)
    {
    }

    /// <summary>
    /// Allows clients to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// If disabled is set to true, functionality is disabled for this connection. Repository based API methods and webhooks processing for repositories in this connection will be disabled.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The resource name of the connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    public partial TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock>>? BitbucketCloudConfig { get; set; }

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    [TerraformProperty("bitbucket_data_center_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock>>? BitbucketDataCenterConfig { get; set; }

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    [TerraformProperty("github_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionGithubConfigBlock>>? GithubConfig { get; set; }

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    [TerraformProperty("github_enterprise_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock>>? GithubEnterpriseConfig { get; set; }

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    [TerraformProperty("gitlab_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionGitlabConfigBlock>>? GitlabConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleCloudbuildv2ConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. Installation state of the Connection.
    /// </summary>
    [TerraformProperty("installation_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InstallationState { get; }

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the background.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
