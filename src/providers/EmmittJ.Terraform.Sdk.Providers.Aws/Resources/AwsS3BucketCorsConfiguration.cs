using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsS3BucketCorsConfigurationCorsRuleBlock() : TerraformBlock("cors_rule")
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformProperty("allowed_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformProperty("allowed_origins")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedOrigins { get; set; }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    [TerraformProperty("expose_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    [TerraformProperty("max_age_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAgeSeconds { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_cors_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketCorsConfiguration : TerraformResource
{
    public AwsS3BucketCorsConfiguration(string name) : base("aws_s3_bucket_cors_configuration", name)
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
    /// Block for cors_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CorsRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CorsRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CorsRule block(s) allowed")]
    [TerraformProperty("cors_rule")]
    public required TerraformSet<AwsS3BucketCorsConfigurationCorsRuleBlock> CorsRule { get; set; } = new();

}
