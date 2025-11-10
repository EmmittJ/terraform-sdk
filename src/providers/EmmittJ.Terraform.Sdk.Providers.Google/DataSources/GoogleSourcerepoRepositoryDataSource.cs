using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sourcerepo_repository.
/// </summary>
public class GoogleSourcerepoRepositoryDataSource : TerraformDataSource
{
    public GoogleSourcerepoRepositoryDataSource(string name) : base("google_sourcerepo_repository", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    [TerraformPropertyName("create_ignore_already_exists")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CreateIgnoreAlreadyExists => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "create_ignore_already_exists");

    /// <summary>
    /// How this repository publishes a change in the repository through Cloud Pub/Sub.
    /// Keyed by the topic names.
    /// </summary>
    [TerraformPropertyName("pubsub_configs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PubsubConfigs => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "pubsub_configs");

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Size => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size");

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
