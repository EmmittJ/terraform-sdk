using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_website_configuration resource.
/// </summary>
public class AwsS3BucketWebsiteConfiguration : TerraformResource
{
    public AwsS3BucketWebsiteConfiguration(string name) : base("aws_s3_bucket_website_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The expected_bucket_owner attribute.
    /// </summary>
    public string? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner")?.Value;
        set => this.WithProperty("expected_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The routing_rules attribute.
    /// </summary>
    public string? RoutingRules
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_rules")?.Value;
        set => this.WithProperty("routing_rules", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformExpression WebsiteDomain => this["website_domain"];

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformExpression WebsiteEndpoint => this["website_endpoint"];

}
