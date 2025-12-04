using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connected_repositories in GoogleCloudbuildBitbucketServerConfig.
/// Nesting mode: set
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connected_repositories";

    /// <summary>
    /// Identifier for the project storing the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectKey is required")]
    public required TerraformValue<string> ProjectKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_key");
        set => SetArgument("project_key", value);
    }

    /// <summary>
    /// Identifier for the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepoSlug is required")]
    public required TerraformValue<string> RepoSlug
    {
        get => GetRequiredArgument<TerraformValue<string>>("repo_slug");
        set => SetArgument("repo_slug", value);
    }

}


/// <summary>
/// Block type for secrets in GoogleCloudbuildBitbucketServerConfig.
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigSecretsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secrets";

    /// <summary>
    /// The resource name for the admin access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccessTokenVersionName is required")]
    public required TerraformValue<string> AdminAccessTokenVersionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_access_token_version_name");
        set => SetArgument("admin_access_token_version_name", value);
    }

    /// <summary>
    /// The resource name for the read access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAccessTokenVersionName is required")]
    public required TerraformValue<string> ReadAccessTokenVersionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("read_access_token_version_name");
        set => SetArgument("read_access_token_version_name", value);
    }

    /// <summary>
    /// Immutable. The resource name for the webhook secret&#39;s secret version. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretVersionName is required")]
    public required TerraformValue<string> WebhookSecretVersionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("webhook_secret_version_name");
        set => SetArgument("webhook_secret_version_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudbuildBitbucketServerConfig.
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloudbuild_bitbucket_server_config Terraform resource.
/// Manages a google_cloudbuild_bitbucket_server_config resource.
/// </summary>
public partial class GoogleCloudbuildBitbucketServerConfig(string name) : TerraformResource("google_cloudbuild_bitbucket_server_config", name)
{
    /// <summary>
    /// Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The ID to use for the BitbucketServerConfig, which will become the final component of the BitbucketServerConfig&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    public required TerraformValue<string> ConfigId
    {
        get => GetRequiredArgument<TerraformValue<string>>("config_id");
        set => SetArgument("config_id", value);
    }

    /// <summary>
    /// Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be changed.
    /// If you need to change it, please create another BitbucketServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    public required TerraformValue<string> HostUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_uri");
        set => SetArgument("host_uri", value);
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
    /// The location of this bitbucket server config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be enabled for private service connection.
    /// This should be set if the Bitbucket Server instance is hosted on-premises and not reachable by public internet. If this field is left empty,
    /// no network peering will occur and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
    /// projects/{project}/global/networks/{network}, where {project} is a project number or id and {network} is the name of a VPC network in the project.
    /// </summary>
    public TerraformValue<string>? PeeredNetwork
    {
        get => GetArgument<TerraformValue<string>>("peered_network");
        set => SetArgument("peered_network", value);
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
    /// SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the extension can be one of .pem, .cer, or .crt.
    /// </summary>
    public TerraformValue<string>? SslCa
    {
        get => GetArgument<TerraformValue<string>>("ssl_ca");
        set => SetArgument("ssl_ca", value);
    }

    /// <summary>
    /// Username of the account Cloud Build will use on Bitbucket Server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The resource name for the config.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
    /// </summary>
    public TerraformValue<string> WebhookKey
        => AsReference("webhook_key");

    /// <summary>
    /// ConnectedRepositories block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock>? ConnectedRepositories
    {
        get => GetArgument<TerraformSet<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock>>("connected_repositories");
        set => SetArgument("connected_repositories", value);
    }

    /// <summary>
    /// Secrets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secrets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secrets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secrets block(s) allowed")]
    public required TerraformList<GoogleCloudbuildBitbucketServerConfigSecretsBlock> Secrets
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudbuildBitbucketServerConfigSecretsBlock>>("secrets");
        set => SetArgument("secrets", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudbuildBitbucketServerConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudbuildBitbucketServerConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
