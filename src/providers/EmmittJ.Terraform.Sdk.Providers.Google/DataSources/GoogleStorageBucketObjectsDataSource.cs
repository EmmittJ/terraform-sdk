using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket_objects.
/// </summary>
public class GoogleStorageBucketObjectsDataSource : TerraformDataSource
{
    public GoogleStorageBucketObjectsDataSource(string name) : base("google_storage_bucket_objects", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The match_glob attribute.
    /// </summary>
    [TerraformPropertyName("match_glob")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MatchGlob { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

    /// <summary>
    /// The bucket_objects attribute.
    /// </summary>
    [TerraformPropertyName("bucket_objects")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BucketObjects => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bucket_objects");

}
