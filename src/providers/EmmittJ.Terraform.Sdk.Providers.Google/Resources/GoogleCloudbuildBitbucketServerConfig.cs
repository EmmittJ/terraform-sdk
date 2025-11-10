using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connected_repositories in .
/// Nesting mode: set
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// Identifier for the project storing the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectKey is required")]
    public required TerraformProperty<string> ProjectKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("project_key");
        set => WithProperty("project_key", value);
    }

    /// <summary>
    /// Identifier for the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepoSlug is required")]
    public required TerraformProperty<string> RepoSlug
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repo_slug");
        set => WithProperty("repo_slug", value);
    }

}

/// <summary>
/// Block type for secrets in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigSecretsBlock : TerraformBlock
{
    /// <summary>
    /// The resource name for the admin access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccessTokenVersionName is required")]
    public required TerraformProperty<string> AdminAccessTokenVersionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("admin_access_token_version_name");
        set => WithProperty("admin_access_token_version_name", value);
    }

    /// <summary>
    /// The resource name for the read access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAccessTokenVersionName is required")]
    public required TerraformProperty<string> ReadAccessTokenVersionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("read_access_token_version_name");
        set => WithProperty("read_access_token_version_name", value);
    }

    /// <summary>
    /// Immutable. The resource name for the webhook secret&#39;s secret version. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretVersionName is required")]
    public required TerraformProperty<string> WebhookSecretVersionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("webhook_secret_version_name");
        set => WithProperty("webhook_secret_version_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_cloudbuild_bitbucket_server_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudbuildBitbucketServerConfig : TerraformResource
{
    public GoogleCloudbuildBitbucketServerConfig(string name) : base("google_cloudbuild_bitbucket_server_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("webhook_key");
    }

    /// <summary>
    /// Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformProperty<string> ApiKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_key");
        set => this.WithProperty("api_key", value);
    }

    /// <summary>
    /// The ID to use for the BitbucketServerConfig, which will become the final component of the BitbucketServerConfig&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    public required TerraformProperty<string> ConfigId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("config_id");
        set => this.WithProperty("config_id", value);
    }

    /// <summary>
    /// Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be changed.
    /// If you need to change it, please create another BitbucketServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("host_uri");
        set => this.WithProperty("host_uri", value);
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
    /// The location of this bitbucket server config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be enabled for private service connection.
    /// This should be set if the Bitbucket Server instance is hosted on-premises and not reachable by public internet. If this field is left empty,
    /// no network peering will occur and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
    /// projects/{project}/global/networks/{network}, where {project} is a project number or id and {network} is the name of a VPC network in the project.
    /// </summary>
    public TerraformProperty<string>? PeeredNetwork
    {
        get => GetProperty<TerraformProperty<string>>("peered_network");
        set => this.WithProperty("peered_network", value);
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
    /// SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the extension can be one of .pem, .cer, or .crt.
    /// </summary>
    public TerraformProperty<string>? SslCa
    {
        get => GetProperty<TerraformProperty<string>>("ssl_ca");
        set => this.WithProperty("ssl_ca", value);
    }

    /// <summary>
    /// Username of the account Cloud Build will use on Bitbucket Server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// Block for connected_repositories.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock>? ConnectedRepositories
    {
        get => GetProperty<HashSet<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock>>("connected_repositories");
        set => this.WithProperty("connected_repositories", value);
    }

    /// <summary>
    /// Block for secrets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secrets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secrets block(s) allowed")]
    public List<GoogleCloudbuildBitbucketServerConfigSecretsBlock>? Secrets
    {
        get => GetProperty<List<GoogleCloudbuildBitbucketServerConfigSecretsBlock>>("secrets");
        set => this.WithProperty("secrets", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudbuildBitbucketServerConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudbuildBitbucketServerConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name for the config.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
    /// </summary>
    public TerraformExpression WebhookKey => this["webhook_key"];

}
