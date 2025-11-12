using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketAnalyticsConfigurationFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

}

/// <summary>
/// Block type for storage_class_analysis in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlock() : TerraformBlock("storage_class_analysis")
{
}

/// <summary>
/// Manages a aws_s3_bucket_analytics_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketAnalyticsConfiguration : TerraformResource
{
    public AwsS3BucketAnalyticsConfiguration(string name) : base("aws_s3_bucket_analytics_configuration", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public TerraformList<AwsS3BucketAnalyticsConfigurationFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for storage_class_analysis.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageClassAnalysis block(s) allowed")]
    [TerraformProperty("storage_class_analysis")]
    public TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlock> StorageClassAnalysis { get; set; } = new();

}
