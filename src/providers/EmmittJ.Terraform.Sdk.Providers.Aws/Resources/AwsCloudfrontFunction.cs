using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_function resource.
/// </summary>
public class AwsCloudfrontFunction : TerraformResource
{
    public AwsCloudfrontFunction(string name) : base("aws_cloudfront_function", name)
    {
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    [TerraformPropertyName("code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Code { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    [TerraformPropertyName("key_value_store_associations")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? KeyValueStoreAssociations { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    [TerraformPropertyName("publish")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Publish { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    [TerraformPropertyName("runtime")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Runtime { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The live_stage_etag attribute.
    /// </summary>
    [TerraformPropertyName("live_stage_etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LiveStageEtag => new TerraformReference(this, "live_stage_etag");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
