using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sourcerepo_repository.
/// </summary>
public partial class GoogleSourcerepoRepositoryDataSource : TerraformDataSource
{
    public GoogleSourcerepoRepositoryDataSource(string name) : base("google_sourcerepo_repository", name)
    {
    }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    [TerraformProperty("create_ignore_already_exists")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> CreateIgnoreAlreadyExists { get; }

    /// <summary>
    /// How this repository publishes a change in the repository through Cloud Pub/Sub.
    /// Keyed by the topic names.
    /// </summary>
    [TerraformProperty("pubsub_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> PubsubConfigs { get; }

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
