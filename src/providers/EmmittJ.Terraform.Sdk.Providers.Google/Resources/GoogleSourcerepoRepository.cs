using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pubsub_configs in .
/// Nesting mode: set
/// </summary>
public partial class GoogleSourcerepoRepositoryPubsubConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// The format of the Cloud Pub/Sub messages.
    /// - PROTOBUF: The message payload is a serialized protocol buffer of SourceRepoEvent.
    /// - JSON: The message payload is a JSON string of SourceRepoEvent. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageFormat is required")]
    [TerraformProperty("message_format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MessageFormat { get; set; }

    /// <summary>
    /// Email address of the service account used for publishing Cloud Pub/Sub messages.
    /// This service account needs to be in the same project as the PubsubConfig. When added,
    /// the caller needs to have iam.serviceAccounts.actAs permission on this service account.
    /// If unspecified, it defaults to the compute engine default service account.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccountEmail { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSourcerepoRepositoryTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_sourcerepo_repository resource.
/// </summary>
public partial class GoogleSourcerepoRepository : TerraformResource
{
    public GoogleSourcerepoRepository(string name) : base("google_sourcerepo_repository", name)
    {
    }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    [TerraformProperty("create_ignore_already_exists")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateIgnoreAlreadyExists { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
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
    /// Block for pubsub_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("pubsub_configs")]
    public partial TerraformSet<TerraformBlock<GoogleSourcerepoRepositoryPubsubConfigsBlock>>? PubsubConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleSourcerepoRepositoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    [TerraformProperty("size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Size { get; }

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
