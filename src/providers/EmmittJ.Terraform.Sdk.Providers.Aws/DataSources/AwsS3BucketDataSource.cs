using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_bucket Terraform data source.
/// Retrieves information about a aws_s3_bucket.
/// </summary>
public partial class AwsS3BucketDataSource(string name) : TerraformDataSource("aws_s3_bucket", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    public TerraformValue<string> BucketDomainName
    {
        get => new TerraformReference<string>(this, "bucket_domain_name");
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformValue<string> BucketRegion
    {
        get => new TerraformReference<string>(this, "bucket_region");
    }

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    public TerraformValue<string> BucketRegionalDomainName
    {
        get => new TerraformReference<string>(this, "bucket_regional_domain_name");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformValue<string> WebsiteDomain
    {
        get => new TerraformReference<string>(this, "website_domain");
    }

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformValue<string> WebsiteEndpoint
    {
        get => new TerraformReference<string>(this, "website_endpoint");
    }

}
