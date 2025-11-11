using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connected_repositories in .
/// Nesting mode: set
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock
{
    /// <summary>
    /// Identifier for the project storing the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectKey is required")]
    [TerraformPropertyName("project_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProjectKey { get; set; }

    /// <summary>
    /// Identifier for the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepoSlug is required")]
    [TerraformPropertyName("repo_slug")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepoSlug { get; set; }

}

/// <summary>
/// Block type for secrets in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigSecretsBlock
{
    /// <summary>
    /// The resource name for the admin access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccessTokenVersionName is required")]
    [TerraformPropertyName("admin_access_token_version_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminAccessTokenVersionName { get; set; }

    /// <summary>
    /// The resource name for the read access token&#39;s secret version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadAccessTokenVersionName is required")]
    [TerraformPropertyName("read_access_token_version_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReadAccessTokenVersionName { get; set; }

    /// <summary>
    /// Immutable. The resource name for the webhook secret&#39;s secret version. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookSecretVersionName is required")]
    [TerraformPropertyName("webhook_secret_version_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebhookSecretVersionName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildBitbucketServerConfigTimeoutsBlock
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
/// Manages a google_cloudbuild_bitbucket_server_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudbuildBitbucketServerConfig : TerraformResource
{
    public GoogleCloudbuildBitbucketServerConfig(string name) : base("google_cloudbuild_bitbucket_server_config", name)
    {
    }

    /// <summary>
    /// Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [TerraformPropertyName("api_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiKey { get; set; }

    /// <summary>
    /// The ID to use for the BitbucketServerConfig, which will become the final component of the BitbucketServerConfig&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    [TerraformPropertyName("config_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConfigId { get; set; }

    /// <summary>
    /// Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be changed.
    /// If you need to change it, please create another BitbucketServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUri is required")]
    [TerraformPropertyName("host_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of this bitbucket server config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be enabled for private service connection.
    /// This should be set if the Bitbucket Server instance is hosted on-premises and not reachable by public internet. If this field is left empty,
    /// no network peering will occur and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
    /// projects/{project}/global/networks/{network}, where {project} is a project number or id and {network} is the name of a VPC network in the project.
    /// </summary>
    [TerraformPropertyName("peered_network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PeeredNetwork { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the extension can be one of .pem, .cer, or .crt.
    /// </summary>
    [TerraformPropertyName("ssl_ca")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCa { get; set; }

    /// <summary>
    /// Username of the account Cloud Build will use on Bitbucket Server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

    /// <summary>
    /// Block for connected_repositories.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connected_repositories")]
    public TerraformSet<TerraformBlock<GoogleCloudbuildBitbucketServerConfigConnectedRepositoriesBlock>>? ConnectedRepositories { get; set; }

    /// <summary>
    /// Block for secrets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secrets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secrets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secrets block(s) allowed")]
    [TerraformPropertyName("secrets")]
    public TerraformList<TerraformBlock<GoogleCloudbuildBitbucketServerConfigSecretsBlock>>? Secrets { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudbuildBitbucketServerConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name for the config.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
    /// </summary>
    [TerraformPropertyName("webhook_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebhookKey => new TerraformReference(this, "webhook_key");

}
