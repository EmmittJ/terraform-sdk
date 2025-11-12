using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connected_repositories in .
/// Nesting mode: set
/// </summary>
public partial class GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock() : TerraformBlock("connected_repositories")
{
    /// <summary>
    /// Identifier for the project storing the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectKey is required")]
    [TerraformProperty("project_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectKey { get; set; }

    /// <summary>
    /// Identifier for the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepoSlug is required")]
    [TerraformProperty("repo_slug")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepoSlug { get; set; }

}

/// <summary>
/// Block type for secrets in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildBitbucketServerConfigSecretsBlock() : TerraformBlock("secrets")
{
    /// <summary>
    /// The resource name for the admin access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccessTokenVersionName is required")]
    [TerraformProperty("admin_access_token_version_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminAccessTokenVersionName { get; set; }

    /// <summary>
    /// The resource name for the read access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAccessTokenVersionName is required")]
    [TerraformProperty("read_access_token_version_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReadAccessTokenVersionName { get; set; }

    /// <summary>
    /// Immutable. The resource name for the webhook secret&#39;s secret version. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretVersionName is required")]
    [TerraformProperty("webhook_secret_version_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebhookSecretVersionName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudbuildBitbucketServerConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_cloudbuild_bitbucket_server_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudbuildBitbucketServerConfig : TerraformResource
{
    public GoogleCloudbuildBitbucketServerConfig(string name) : base("google_cloudbuild_bitbucket_server_config", name)
    {
    }

    /// <summary>
    /// Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [TerraformProperty("api_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiKey { get; set; }

    /// <summary>
    /// The ID to use for the BitbucketServerConfig, which will become the final component of the BitbucketServerConfig&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    [TerraformProperty("config_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigId { get; set; }

    /// <summary>
    /// Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be changed.
    /// If you need to change it, please create another BitbucketServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformProperty("host_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of this bitbucket server config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be enabled for private service connection.
    /// This should be set if the Bitbucket Server instance is hosted on-premises and not reachable by public internet. If this field is left empty,
    /// no network peering will occur and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
    /// projects/{project}/global/networks/{network}, where {project} is a project number or id and {network} is the name of a VPC network in the project.
    /// </summary>
    [TerraformProperty("peered_network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PeeredNetwork { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the extension can be one of .pem, .cer, or .crt.
    /// </summary>
    [TerraformProperty("ssl_ca")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// Username of the account Cloud Build will use on Bitbucket Server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

    /// <summary>
    /// Block for connected_repositories.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("connected_repositories")]
    public TerraformSet<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock> ConnectedRepositories { get; set; } = new();

    /// <summary>
    /// Block for secrets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secrets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secrets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secrets block(s) allowed")]
    [TerraformProperty("secrets")]
    public required TerraformList<GoogleCloudbuildBitbucketServerConfigSecretsBlock> Secrets { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleCloudbuildBitbucketServerConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name for the config.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
    /// </summary>
    [TerraformProperty("webhook_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebhookKey { get; }

}
