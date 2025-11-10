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
        set => SetProperty("project_key", value);
    }

    /// <summary>
    /// Identifier for the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepoSlug is required")]
    public required TerraformProperty<string> RepoSlug
    {
        set => SetProperty("repo_slug", value);
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
        set => SetProperty("admin_access_token_version_name", value);
    }

    /// <summary>
    /// The resource name for the read access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAccessTokenVersionName is required")]
    public required TerraformProperty<string> ReadAccessTokenVersionName
    {
        set => SetProperty("read_access_token_version_name", value);
    }

    /// <summary>
    /// Immutable. The resource name for the webhook secret&#39;s secret version. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretVersionName is required")]
    public required TerraformProperty<string> WebhookSecretVersionName
    {
        set => SetProperty("webhook_secret_version_name", value);
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
        SetOutput("name");
        SetOutput("webhook_key");
        SetOutput("api_key");
        SetOutput("config_id");
        SetOutput("host_uri");
        SetOutput("id");
        SetOutput("location");
        SetOutput("peered_network");
        SetOutput("project");
        SetOutput("ssl_ca");
        SetOutput("username");
    }

    /// <summary>
    /// Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformProperty<string> ApiKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_key");
        set => SetProperty("api_key", value);
    }

    /// <summary>
    /// The ID to use for the BitbucketServerConfig, which will become the final component of the BitbucketServerConfig&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    public required TerraformProperty<string> ConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("config_id");
        set => SetProperty("config_id", value);
    }

    /// <summary>
    /// Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be changed.
    /// If you need to change it, please create another BitbucketServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformProperty<string> HostUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_uri");
        set => SetProperty("host_uri", value);
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
    /// The location of this bitbucket server config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be enabled for private service connection.
    /// This should be set if the Bitbucket Server instance is hosted on-premises and not reachable by public internet. If this field is left empty,
    /// no network peering will occur and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
    /// projects/{project}/global/networks/{network}, where {project} is a project number or id and {network} is the name of a VPC network in the project.
    /// </summary>
    public TerraformProperty<string> PeeredNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peered_network");
        set => SetProperty("peered_network", value);
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
    /// SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the extension can be one of .pem, .cer, or .crt.
    /// </summary>
    public TerraformProperty<string> SslCa
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_ca");
        set => SetProperty("ssl_ca", value);
    }

    /// <summary>
    /// Username of the account Cloud Build will use on Bitbucket Server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for connected_repositories.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock>? ConnectedRepositories
    {
        set => SetProperty("connected_repositories", value);
    }

    /// <summary>
    /// Block for secrets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secrets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secrets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secrets block(s) allowed")]
    public List<GoogleCloudbuildBitbucketServerConfigSecretsBlock>? Secrets
    {
        set => SetProperty("secrets", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudbuildBitbucketServerConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
