using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_type_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The forward_when_content_type_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenContentTypeIsUnknown is required")]
    [TerraformPropertyName("forward_when_content_type_is_unknown")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ForwardWhenContentTypeIsUnknown { get; set; }

}

/// <summary>
/// Block type for query_arg_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The forward_when_query_arg_profile_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenQueryArgProfileIsUnknown is required")]
    [TerraformPropertyName("forward_when_query_arg_profile_is_unknown")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ForwardWhenQueryArgProfileIsUnknown { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for content_type_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypeProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTypeProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeProfileConfig block(s) allowed")]
    [TerraformPropertyName("content_type_profile_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock>>? ContentTypeProfileConfig { get; set; } = new();

    /// <summary>
    /// Block for query_arg_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryArgProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryArgProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryArgProfileConfig block(s) allowed")]
    [TerraformPropertyName("query_arg_profile_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock>>? QueryArgProfileConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CallerReference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "caller_reference");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

}
