using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_type_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock
{
    /// <summary>
    /// The forward_when_content_type_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenContentTypeIsUnknown is required")]
    [TerraformPropertyName("forward_when_content_type_is_unknown")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ForwardWhenContentTypeIsUnknown { get; set; }

}

/// <summary>
/// Block type for query_arg_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock
{
    /// <summary>
    /// The forward_when_query_arg_profile_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenQueryArgProfileIsUnknown is required")]
    [TerraformPropertyName("forward_when_query_arg_profile_is_unknown")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ForwardWhenQueryArgProfileIsUnknown { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_field_level_encryption_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontFieldLevelEncryptionConfig : TerraformResource
{
    public AwsCloudfrontFieldLevelEncryptionConfig(string name) : base("aws_cloudfront_field_level_encryption_config", name)
    {
    }

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
    /// Block for content_type_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypeProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTypeProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeProfileConfig block(s) allowed")]
    [TerraformPropertyName("content_type_profile_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock>>? ContentTypeProfileConfig { get; set; }

    /// <summary>
    /// Block for query_arg_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryArgProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryArgProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryArgProfileConfig block(s) allowed")]
    [TerraformPropertyName("query_arg_profile_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock>>? QueryArgProfileConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CallerReference => new TerraformReference(this, "caller_reference");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

}
