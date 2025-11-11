using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_object_signed_url.
/// </summary>
public partial class GoogleStorageObjectSignedUrlDataSource : TerraformDataSource
{
    public GoogleStorageObjectSignedUrlDataSource(string name) : base("google_storage_object_signed_url", name)
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
    /// The content_md5 attribute.
    /// </summary>
    [TerraformProperty("content_md5")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentMd5 { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    [TerraformProperty("credentials")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Credentials { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformProperty("duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    [TerraformProperty("extension_headers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ExtensionHeaders { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [TerraformProperty("http_method")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    [TerraformProperty("signed_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SignedUrl { get; }

}
