using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_bucket.
/// </summary>
public class AwsS3BucketDataSource : TerraformDataSource
{
    public AwsS3BucketDataSource(string name) : base("aws_s3_bucket", name)
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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_domain_name");

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformPropertyName("bucket_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_region");

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_regional_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketRegionalDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_regional_domain_name");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [TerraformPropertyName("website_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebsiteDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_domain");

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("website_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebsiteEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_endpoint");

}
