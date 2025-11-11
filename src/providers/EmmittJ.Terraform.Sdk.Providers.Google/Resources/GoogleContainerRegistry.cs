using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_registry resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleContainerRegistry : TerraformResource
{
    public GoogleContainerRegistry(string name) : base("google_container_registry", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the registry. One of ASIA, EU, US or not specified. See the official documentation for more information on registry locations.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("bucket_self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BucketSelfLink { get; }

}
