using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_directory_buckets.
/// </summary>
public partial class AwsS3DirectoryBucketsDataSource : TerraformDataSource
{
    public AwsS3DirectoryBucketsDataSource(string name) : base("aws_s3_directory_buckets", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Arns { get; }

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    [TerraformProperty("buckets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Buckets { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
