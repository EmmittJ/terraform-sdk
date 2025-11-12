using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_path in .
/// Nesting mode: list
/// </summary>
public partial class AwsKendraFaqS3PathBlock() : TerraformBlock("s3_path")
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKendraFaqTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_kendra_faq resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKendraFaq : TerraformResource
{
    public AwsKendraFaq(string name) : base("aws_kendra_faq", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformProperty("file_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileFormat { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    [TerraformProperty("index_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IndexId { get; set; }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LanguageCode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for s3_path.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Path is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Path block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Path block(s) allowed")]
    [TerraformProperty("s3_path")]
    public required TerraformList<AwsKendraFaqS3PathBlock> S3Path { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsKendraFaqTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// The faq_id attribute.
    /// </summary>
    [TerraformProperty("faq_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FaqId { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
