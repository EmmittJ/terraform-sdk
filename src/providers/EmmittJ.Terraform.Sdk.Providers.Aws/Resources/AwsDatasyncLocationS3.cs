using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncLocationS3S3ConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketAccessRoleArn is required")]
    [TerraformProperty("bucket_access_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketAccessRoleArn { get; set; }

}

/// <summary>
/// Manages a aws_datasync_location_s3 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatasyncLocationS3 : TerraformResource
{
    public AwsDatasyncLocationS3(string name) : base("aws_datasync_location_s3", name)
    {
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [TerraformProperty("agent_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AgentArns { get; set; }

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
    /// The s3_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketArn is required")]
    [TerraformProperty("s3_bucket_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketArn { get; set; }

    /// <summary>
    /// The s3_storage_class attribute.
    /// </summary>
    [TerraformProperty("s3_storage_class")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> S3StorageClass { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    [TerraformProperty("subdirectory")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Subdirectory { get; set; }

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
    /// Block for s3_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Config block(s) allowed")]
    [TerraformProperty("s3_config")]
    public partial TerraformList<TerraformBlock<AwsDatasyncLocationS3S3ConfigBlock>>? S3Config { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uri { get; }

}
