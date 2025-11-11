using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_domain resource.
/// </summary>
public class AwsCodeartifactDomain : TerraformResource
{
    public AwsCodeartifactDomain(string name) : base("aws_codeartifact_domain", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EncryptionKey { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The asset_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("asset_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssetSizeBytes => new TerraformReference(this, "asset_size_bytes");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The repository_count attribute.
    /// </summary>
    [TerraformPropertyName("repository_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RepositoryCount => new TerraformReference(this, "repository_count");

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3BucketArn => new TerraformReference(this, "s3_bucket_arn");

}
