using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretSecretVersion { get; set; }

    /// <summary>
    /// The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
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
public class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock
{
    /// <summary>
    /// The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostUri { get; set; }


    /// <summary>
    /// SSL certificate to use for requests to the Bitbucket Data Center.
    /// </summary>
    [TerraformPropertyName("ssl_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubConfigBlock
{
    /// <summary>
    /// GitHub App installation id.
    /// </summary>
    [TerraformPropertyName("app_installation_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AppInstallationId { get; set; }

}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock
{
    /// <summary>
    /// Id of the GitHub App created from the manifest.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AppId { get; set; }

    /// <summary>
    /// ID of the installation of the GitHub App.
    /// </summary>
    [TerraformPropertyName("app_installation_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AppInstallationId { get; set; }

    /// <summary>
    /// The URL-friendly name of the GitHub App.
    /// </summary>
    [TerraformPropertyName("app_slug")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppSlug { get; set; }

    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostUri { get; set; }

    /// <summary>
    /// SecretManager resource containing the private key of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformPropertyName("private_key_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKeySecretVersion { get; set; }

    /// <summary>
    /// SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    [TerraformPropertyName("ssl_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// SecretManager resource containing the webhook secret of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [TerraformPropertyName("webhook_secret_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebhookSecretSecretVersion { get; set; }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGitlabConfigBlock
{
    /// <summary>
    /// The URI of the GitLab Enterprise host this connection is for. If not specified, the default value is https://gitlab.com.
    /// </summary>
    [TerraformPropertyName("host_uri")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HostUri { get; set; } = default!;


    /// <summary>
    /// SSL certificate to use for requests to GitLab Enterprise.
    /// </summary>
    [TerraformPropertyName("ssl_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab Enterprise project, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
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
public class GoogleCloudbuildv2ConnectionTimeoutsBlock
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
/// Manages a google_cloudbuildv2_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudbuildv2Connection : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// If disabled is set to true, functionality is disabled for this connection. Repository based API methods and webhooks processing for repositories in this connection will be disabled.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The resource name of the connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    public TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock>>? BitbucketCloudConfig { get; set; }

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    [TerraformPropertyName("bitbucket_data_center_config")]
    public TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock>>? BitbucketDataCenterConfig { get; set; }

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    [TerraformPropertyName("github_config")]
    public TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionGithubConfigBlock>>? GithubConfig { get; set; }

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    [TerraformPropertyName("github_enterprise_config")]
    public TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock>>? GithubEnterpriseConfig { get; set; }

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    [TerraformPropertyName("gitlab_config")]
    public TerraformList<TerraformBlock<GoogleCloudbuildv2ConnectionGitlabConfigBlock>>? GitlabConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudbuildv2ConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// Output only. Installation state of the Connection.
    /// </summary>
    [TerraformPropertyName("installation_state")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstallationState => new TerraformReference(this, "installation_state");

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the background.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
