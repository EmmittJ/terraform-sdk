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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the registry. One of ASIA, EU, US or not specified. See the official documentation for more information on registry locations.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("bucket_self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketSelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_self_link");

}
