using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_pool_domain resource.
/// </summary>
public partial class AwsCognitoUserPoolDomain : TerraformResource
{
    public AwsCognitoUserPoolDomain(string name) : base("aws_cognito_user_pool_domain", name)
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateArn { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_login_version attribute.
    /// </summary>
    [TerraformProperty("managed_login_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ManagedLoginVersion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AwsAccountId { get; }

    /// <summary>
    /// The cloudfront_distribution attribute.
    /// </summary>
    [TerraformProperty("cloudfront_distribution")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudfrontDistribution { get; }

    /// <summary>
    /// The cloudfront_distribution_arn attribute.
    /// </summary>
    [TerraformProperty("cloudfront_distribution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudfrontDistributionArn { get; }

    /// <summary>
    /// The cloudfront_distribution_zone_id attribute.
    /// </summary>
    [TerraformProperty("cloudfront_distribution_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudfrontDistributionZoneId { get; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformProperty("s3_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3Bucket { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
