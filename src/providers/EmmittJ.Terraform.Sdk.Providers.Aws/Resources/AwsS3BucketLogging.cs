using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_grant in .
/// Nesting mode: set
/// </summary>
public partial class AwsS3BucketLoggingTargetGrantBlock() : TerraformBlock("target_grant")
{
    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformProperty("permission")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Permission { get; set; }

}

/// <summary>
/// Block type for target_object_key_format in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketLoggingTargetObjectKeyFormatBlock() : TerraformBlock("target_object_key_format")
{
}

/// <summary>
/// Manages a aws_s3_bucket_logging resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketLogging : TerraformResource
{
    public AwsS3BucketLogging(string name) : base("aws_s3_bucket_logging", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    [TerraformProperty("target_bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetBucket { get; set; }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPrefix is required")]
    [TerraformProperty("target_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetPrefix { get; set; }

    /// <summary>
    /// Block for target_grant.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("target_grant")]
    public TerraformSet<AwsS3BucketLoggingTargetGrantBlock> TargetGrant { get; set; } = new();

    /// <summary>
    /// Block for target_object_key_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetObjectKeyFormat block(s) allowed")]
    [TerraformProperty("target_object_key_format")]
    public TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlock> TargetObjectKeyFormat { get; set; } = new();

}
