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
    public TerraformValue<string>? CertificateArn { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The managed_login_version attribute.
    /// </summary>
    [TerraformPropertyName("managed_login_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ManagedLoginVersion { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsAccountId => new TerraformReference(this, "aws_account_id");

    /// <summary>
    /// The cloudfront_distribution attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_distribution")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudfrontDistribution => new TerraformReference(this, "cloudfront_distribution");

    /// <summary>
    /// The cloudfront_distribution_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_distribution_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudfrontDistributionArn => new TerraformReference(this, "cloudfront_distribution_arn");

    /// <summary>
    /// The cloudfront_distribution_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_distribution_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudfrontDistributionZoneId => new TerraformReference(this, "cloudfront_distribution_zone_id");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3Bucket => new TerraformReference(this, "s3_bucket");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
