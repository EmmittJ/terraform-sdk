using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_pool_domain resource.
/// </summary>
public class AwsCognitoUserPoolDomain : TerraformResource
{
    public AwsCognitoUserPoolDomain(string name) : base("aws_cognito_user_pool_domain", name)
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateArn { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_login_version attribute.
    /// </summary>
    [TerraformPropertyName("managed_login_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ManagedLoginVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "managed_login_version");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AwsAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The cloudfront_distribution attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_distribution")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudfrontDistribution => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudfront_distribution");

    /// <summary>
    /// The cloudfront_distribution_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_distribution_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudfrontDistributionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudfront_distribution_arn");

    /// <summary>
    /// The cloudfront_distribution_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_distribution_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudfrontDistributionZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudfront_distribution_zone_id");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> S3Bucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_bucket");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
