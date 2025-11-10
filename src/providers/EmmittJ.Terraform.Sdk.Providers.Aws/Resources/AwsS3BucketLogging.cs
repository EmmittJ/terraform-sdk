using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_grant in .
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLoggingTargetGrantBlock : ITerraformBlock
{
    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformPropertyName("permission")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Permission { get; set; }

}

/// <summary>
/// Block type for target_object_key_format in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLoggingTargetObjectKeyFormatBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_s3_bucket_logging resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3BucketLogging : TerraformResource
{
    public AwsS3BucketLogging(string name) : base("aws_s3_bucket_logging", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    [TerraformPropertyName("target_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetBucket { get; set; }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPrefix is required")]
    [TerraformPropertyName("target_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetPrefix { get; set; }

    /// <summary>
    /// Block for target_grant.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("target_grant")]
    public TerraformSet<TerraformBlock<AwsS3BucketLoggingTargetGrantBlock>>? TargetGrant { get; set; } = new();

    /// <summary>
    /// Block for target_object_key_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetObjectKeyFormat block(s) allowed")]
    [TerraformPropertyName("target_object_key_format")]
    public TerraformList<TerraformBlock<AwsS3BucketLoggingTargetObjectKeyFormatBlock>>? TargetObjectKeyFormat { get; set; } = new();

}
