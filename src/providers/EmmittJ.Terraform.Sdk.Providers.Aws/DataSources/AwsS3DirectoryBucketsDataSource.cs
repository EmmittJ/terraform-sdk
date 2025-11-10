using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_directory_buckets.
/// </summary>
public class AwsS3DirectoryBucketsDataSource : TerraformDataSource
{
    public AwsS3DirectoryBucketsDataSource(string name) : base("aws_s3_directory_buckets", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Arns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "arns");

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    [TerraformPropertyName("buckets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Buckets => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "buckets");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
