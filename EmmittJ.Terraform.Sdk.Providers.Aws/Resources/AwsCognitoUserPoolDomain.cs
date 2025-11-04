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
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The managed_login_version attribute.
    /// </summary>
    public double? ManagedLoginVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("managed_login_version")?.Value;
        set => this.WithProperty("managed_login_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public string? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id")?.Value;
        set => this.WithProperty("user_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
