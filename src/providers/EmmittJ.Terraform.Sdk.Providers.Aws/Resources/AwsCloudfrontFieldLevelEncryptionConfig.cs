using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_type_profile_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The forward_when_content_type_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenContentTypeIsUnknown is required")]
    [TerraformProperty("forward_when_content_type_is_unknown")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> ForwardWhenContentTypeIsUnknown { get; set; }

}

/// <summary>
/// Block type for query_arg_profile_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The forward_when_query_arg_profile_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenQueryArgProfileIsUnknown is required")]
    [TerraformProperty("forward_when_query_arg_profile_is_unknown")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> ForwardWhenQueryArgProfileIsUnknown { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_field_level_encryption_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontFieldLevelEncryptionConfig : TerraformResource
{
    public AwsCloudfrontFieldLevelEncryptionConfig(string name) : base("aws_cloudfront_field_level_encryption_config", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for content_type_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypeProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTypeProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeProfileConfig block(s) allowed")]
    [TerraformProperty("content_type_profile_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock>>? ContentTypeProfileConfig { get; set; }

    /// <summary>
    /// Block for query_arg_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryArgProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryArgProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryArgProfileConfig block(s) allowed")]
    [TerraformProperty("query_arg_profile_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock>>? QueryArgProfileConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformProperty("caller_reference")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CallerReference { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

}
