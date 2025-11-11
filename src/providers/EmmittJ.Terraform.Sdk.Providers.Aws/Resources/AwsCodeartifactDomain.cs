using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_domain resource.
/// </summary>
public partial class AwsCodeartifactDomain : TerraformResource
{
    public AwsCodeartifactDomain(string name) : base("aws_codeartifact_domain", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformProperty("encryption_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EncryptionKey { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The asset_size_bytes attribute.
    /// </summary>
    [TerraformProperty("asset_size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssetSizeBytes { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Owner { get; }

    /// <summary>
    /// The repository_count attribute.
    /// </summary>
    [TerraformProperty("repository_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RepositoryCount { get; }

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [TerraformProperty("s3_bucket_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3BucketArn { get; }

}
