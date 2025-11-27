using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_user_pool_domain Terraform resource.
/// Manages a aws_cognito_user_pool_domain resource.
/// </summary>
public partial class AwsCognitoUserPoolDomain(string name) : TerraformResource("aws_cognito_user_pool_domain", name)
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
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
    /// The managed_login_version attribute.
    /// </summary>
    public TerraformValue<double> ManagedLoginVersion
    {
        get => new TerraformReference<double>(this, "managed_login_version");
        set => SetArgument("managed_login_version", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
    }

    /// <summary>
    /// The cloudfront_distribution attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontDistribution
    {
        get => new TerraformReference<string>(this, "cloudfront_distribution");
    }

    /// <summary>
    /// The cloudfront_distribution_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontDistributionArn
    {
        get => new TerraformReference<string>(this, "cloudfront_distribution_arn");
    }

    /// <summary>
    /// The cloudfront_distribution_zone_id attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontDistributionZoneId
    {
        get => new TerraformReference<string>(this, "cloudfront_distribution_zone_id");
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string> S3Bucket
    {
        get => new TerraformReference<string>(this, "s3_bucket");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
