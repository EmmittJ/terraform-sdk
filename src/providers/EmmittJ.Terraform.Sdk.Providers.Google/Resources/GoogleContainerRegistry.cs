using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_registry resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleContainerRegistry : TerraformResource
{
    public GoogleContainerRegistry(string name) : base("google_container_registry", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the registry. One of ASIA, EU, US or not specified. See the official documentation for more information on registry locations.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("bucket_self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BucketSelfLink => new TerraformReference(this, "bucket_self_link");

}
