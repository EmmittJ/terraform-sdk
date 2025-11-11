using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_registry_repository.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class GoogleContainerRegistryRepositoryDataSource : TerraformDataSource
{
    public GoogleContainerRegistryRepositoryDataSource(string name) : base("google_container_registry_repository", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformProperty("repository_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RepositoryUrl { get; }

}
