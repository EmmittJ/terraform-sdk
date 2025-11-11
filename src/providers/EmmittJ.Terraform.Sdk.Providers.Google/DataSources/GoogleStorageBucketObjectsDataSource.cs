using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket_objects.
/// </summary>
public partial class GoogleStorageBucketObjectsDataSource : TerraformDataSource
{
    public GoogleStorageBucketObjectsDataSource(string name) : base("google_storage_bucket_objects", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The match_glob attribute.
    /// </summary>
    [TerraformProperty("match_glob")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MatchGlob { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The bucket_objects attribute.
    /// </summary>
    [TerraformProperty("bucket_objects")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BucketObjects { get; }

}
