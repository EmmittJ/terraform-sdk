using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pubsub_configs in .
/// Nesting mode: set
/// </summary>
public class GoogleSourcerepoRepositoryPubsubConfigsBlock
{
    /// <summary>
    /// The format of the Cloud Pub/Sub messages.
    /// - PROTOBUF: The message payload is a serialized protocol buffer of SourceRepoEvent.
    /// - JSON: The message payload is a JSON string of SourceRepoEvent. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageFormat is required")]
    [TerraformPropertyName("message_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MessageFormat { get; set; }

    /// <summary>
    /// Email address of the service account used for publishing Cloud Pub/Sub messages.
    /// This service account needs to be in the same project as the PubsubConfig. When added,
    /// the caller needs to have iam.serviceAccounts.actAs permission on this service account.
    /// If unspecified, it defaults to the compute engine default service account.
    /// </summary>
    [TerraformPropertyName("service_account_email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccountEmail { get; set; } = default!;

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformPropertyName("topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSourcerepoRepositoryTimeoutsBlock
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
/// Manages a google_sourcerepo_repository resource.
/// </summary>
public class GoogleSourcerepoRepository : TerraformResource
{
    public GoogleSourcerepoRepository(string name) : base("google_sourcerepo_repository", name)
    {
    }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    [TerraformPropertyName("create_ignore_already_exists")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreateIgnoreAlreadyExists { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
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
    /// Block for pubsub_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("pubsub_configs")]
    public TerraformSet<TerraformBlock<GoogleSourcerepoRepositoryPubsubConfigsBlock>>? PubsubConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSourcerepoRepositoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Size => new TerraformReference(this, "size");

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
