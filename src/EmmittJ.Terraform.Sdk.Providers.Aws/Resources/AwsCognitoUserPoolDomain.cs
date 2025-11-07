using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_pool_domain resource.
/// </summary>
public class AwsCognitoUserPoolDomain : TerraformResource
{
    public AwsCognitoUserPoolDomain(string name) : base("aws_cognito_user_pool_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aws_account_id");
        this.DeclareOutput("cloudfront_distribution");
        this.DeclareOutput("cloudfront_distribution_arn");
        this.DeclareOutput("cloudfront_distribution_zone_id");
        this.DeclareOutput("s3_bucket");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The managed_login_version attribute.
    /// </summary>
    public TerraformProperty<double>? ManagedLoginVersion
    {
        get => GetProperty<TerraformProperty<double>>("managed_login_version");
        set => this.WithProperty("managed_login_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserPoolId
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformExpression AwsAccountId => this["aws_account_id"];

    /// <summary>
    /// The cloudfront_distribution attribute.
    /// </summary>
    public TerraformExpression CloudfrontDistribution => this["cloudfront_distribution"];

    /// <summary>
    /// The cloudfront_distribution_arn attribute.
    /// </summary>
    public TerraformExpression CloudfrontDistributionArn => this["cloudfront_distribution_arn"];

    /// <summary>
    /// The cloudfront_distribution_zone_id attribute.
    /// </summary>
    public TerraformExpression CloudfrontDistributionZoneId => this["cloudfront_distribution_zone_id"];

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformExpression S3Bucket => this["s3_bucket"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
