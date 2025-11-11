using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_bucket.
/// </summary>
public partial class AwsS3BucketDataSource : TerraformDataSource
{
    public AwsS3BucketDataSource(string name) : base("aws_s3_bucket", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    [TerraformProperty("bucket_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BucketDomainName { get; }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformProperty("bucket_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BucketRegion { get; }

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    [TerraformProperty("bucket_regional_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BucketRegionalDomainName { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [TerraformProperty("website_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebsiteDomain { get; }

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [TerraformProperty("website_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebsiteEndpoint { get; }

}
