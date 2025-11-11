using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_entities in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_cloudfront_field_level_encryption_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontFieldLevelEncryptionProfile : TerraformResource
{
    public AwsCloudfrontFieldLevelEncryptionProfile(string name) : base("aws_cloudfront_field_level_encryption_profile", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for encryption_entities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionEntities is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionEntities block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionEntities block(s) allowed")]
    [TerraformProperty("encryption_entities")]
    public TerraformList<TerraformBlock<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlock>>? EncryptionEntities { get; set; }

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
