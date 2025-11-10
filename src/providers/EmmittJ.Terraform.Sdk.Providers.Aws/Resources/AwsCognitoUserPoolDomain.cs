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
        SetOutput("aws_account_id");
        SetOutput("cloudfront_distribution");
        SetOutput("cloudfront_distribution_arn");
        SetOutput("cloudfront_distribution_zone_id");
        SetOutput("s3_bucket");
        SetOutput("version");
        SetOutput("certificate_arn");
        SetOutput("domain");
        SetOutput("id");
        SetOutput("managed_login_version");
        SetOutput("region");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> CertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_arn");
        set => SetProperty("certificate_arn", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The managed_login_version attribute.
    /// </summary>
    public TerraformProperty<double> ManagedLoginVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("managed_login_version");
        set => SetProperty("managed_login_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
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
