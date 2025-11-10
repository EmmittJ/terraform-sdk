using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bitbucket_cloud_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        set => SetProperty("webhook_secret_secret_version", value);
    }

    /// <summary>
    /// The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Workspace is required")]
    public required TerraformProperty<string> Workspace
    {
        set => SetProperty("workspace", value);
    }

}

/// <summary>
/// Block type for bitbucket_data_center_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The URI of the Bitbucket Data Center host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        set => SetProperty("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the Bitbucket Data Center running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformProperty<string>? ServerVersion
    {
        set => SetProperty("server_version", value);
    }

    /// <summary>
    /// SSL certificate to use for requests to the Bitbucket Data Center.
    /// </summary>
    public TerraformProperty<string>? SslCa
    {
        set => SetProperty("ssl_ca", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        set => SetProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for github_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubConfigBlock : TerraformBlock
{
    /// <summary>
    /// GitHub App installation id.
    /// </summary>
    public TerraformProperty<double>? AppInstallationId
    {
        set => SetProperty("app_installation_id", value);
    }

}

/// <summary>
/// Block type for github_enterprise_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Id of the GitHub App created from the manifest.
    /// </summary>
    public TerraformProperty<double>? AppId
    {
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// ID of the installation of the GitHub App.
    /// </summary>
    public TerraformProperty<double>? AppInstallationId
    {
        set => SetProperty("app_installation_id", value);
    }

    /// <summary>
    /// The URL-friendly name of the GitHub App.
    /// </summary>
    public TerraformProperty<string>? AppSlug
    {
        set => SetProperty("app_slug", value);
    }

    /// <summary>
    /// Required. The URI of the GitHub Enterprise host this connection is for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        set => SetProperty("host_uri", value);
    }

    /// <summary>
    /// SecretManager resource containing the private key of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformProperty<string>? PrivateKeySecretVersion
    {
        set => SetProperty("private_key_secret_version", value);
    }

    /// <summary>
    /// SSL certificate to use for requests to GitHub Enterprise.
    /// </summary>
    public TerraformProperty<string>? SslCa
    {
        set => SetProperty("ssl_ca", value);
    }

    /// <summary>
    /// SecretManager resource containing the webhook secret of the GitHub App, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    public TerraformProperty<string>? WebhookSecretSecretVersion
    {
        set => SetProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for gitlab_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildv2ConnectionGitlabConfigBlock : TerraformBlock
{
    /// <summary>
    /// The URI of the GitLab Enterprise host this connection is for. If not specified, the default value is https://gitlab.com.
    /// </summary>
    public TerraformProperty<string>? HostUri
    {
        set => SetProperty("host_uri", value);
    }

    /// <summary>
    /// Output only. Version of the GitLab Enterprise server running on the &#39;host_uri&#39;.
    /// </summary>
    public TerraformProperty<string>? ServerVersion
    {
        set => SetProperty("server_version", value);
    }

    /// <summary>
    /// SSL certificate to use for requests to GitLab Enterprise.
    /// </summary>
    public TerraformProperty<string>? SslCa
    {
        set => SetProperty("ssl_ca", value);
    }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab Enterprise project, formatted as &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretSecretVersion is required")]
    public required TerraformProperty<string> WebhookSecretSecretVersion
    {
        set => SetProperty("webhook_secret_secret_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildv2ConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_cloudbuildv2_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudbuildv2Connection : TerraformResource
{
    public GoogleCloudbuildv2Connection(string name) : base("google_cloudbuildv2_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("etag");
        SetOutput("installation_state");
        SetOutput("reconciling");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// Allows clients to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// If disabled is set to true, functionality is disabled for this connection. Repository based API methods and webhooks processing for repositories in this connection will be disabled.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Immutable. The resource name of the connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for bitbucket_cloud_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketCloudConfig block(s) allowed")]
    public List<GoogleCloudbuildv2ConnectionBitbucketCloudConfigBlock>? BitbucketCloudConfig
    {
        set => SetProperty("bitbucket_cloud_config", value);
    }

    /// <summary>
    /// Block for bitbucket_data_center_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BitbucketDataCenterConfig block(s) allowed")]
    public List<GoogleCloudbuildv2ConnectionBitbucketDataCenterConfigBlock>? BitbucketDataCenterConfig
    {
        set => SetProperty("bitbucket_data_center_config", value);
    }

    /// <summary>
    /// Block for github_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfig block(s) allowed")]
    public List<GoogleCloudbuildv2ConnectionGithubConfigBlock>? GithubConfig
    {
        set => SetProperty("github_config", value);
    }

    /// <summary>
    /// Block for github_enterprise_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseConfig block(s) allowed")]
    public List<GoogleCloudbuildv2ConnectionGithubEnterpriseConfigBlock>? GithubEnterpriseConfig
    {
        set => SetProperty("github_enterprise_config", value);
    }

    /// <summary>
    /// Block for gitlab_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitlabConfig block(s) allowed")]
    public List<GoogleCloudbuildv2ConnectionGitlabConfigBlock>? GitlabConfig
    {
        set => SetProperty("gitlab_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudbuildv2ConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. Installation state of the Connection.
    /// </summary>
    public TerraformExpression InstallationState => this["installation_state"];

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the background.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. Server assigned timestamp for when the connection was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
