using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_object_signed_url.
/// </summary>
public class GoogleStorageObjectSignedUrlDataSource : TerraformDataSource
{
    public GoogleStorageObjectSignedUrlDataSource(string name) : base("google_storage_object_signed_url", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformPropertyName("content_md5")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentMd5 { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    [TerraformPropertyName("credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Credentials { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    [TerraformPropertyName("extension_headers")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ExtensionHeaders { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [TerraformPropertyName("http_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    [TerraformPropertyName("signed_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SignedUrl => new TerraformReference(this, "signed_url");

}
