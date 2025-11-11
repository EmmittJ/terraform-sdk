using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeBackendBucketSignedUrlKeyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_backend_bucket_signed_url_key resource.
/// </summary>
public partial class GoogleComputeBackendBucketSignedUrlKey : TerraformResource
{
    public GoogleComputeBackendBucketSignedUrlKey(string name) : base("google_compute_backend_bucket_signed_url_key", name)
    {
    }

    /// <summary>
    /// The backend bucket this signed URL key belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendBucket is required")]
    [TerraformProperty("backend_bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BackendBucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// 128-bit key value used for signing the URL. The key value must be a
    /// valid RFC 4648 Section 5 base64url encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValue is required")]
    [TerraformProperty("key_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyValue { get; set; }

    /// <summary>
    /// Name of the signed URL key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeBackendBucketSignedUrlKeyTimeoutsBlock>? Timeouts { get; set; }

}
