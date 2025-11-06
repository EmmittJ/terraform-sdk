using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_bucket.
/// </summary>
public class AwsS3BucketDataSource : TerraformDataSource
{
    public AwsS3BucketDataSource(string name) : base("aws_s3_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bucket_domain_name");
        this.DeclareOutput("bucket_region");
        this.DeclareOutput("bucket_regional_domain_name");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("website_domain");
        this.DeclareOutput("website_endpoint");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    public TerraformExpression BucketDomainName => this["bucket_domain_name"];

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformExpression BucketRegion => this["bucket_region"];

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    public TerraformExpression BucketRegionalDomainName => this["bucket_regional_domain_name"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformExpression WebsiteDomain => this["website_domain"];

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformExpression WebsiteEndpoint => this["website_endpoint"];

}
