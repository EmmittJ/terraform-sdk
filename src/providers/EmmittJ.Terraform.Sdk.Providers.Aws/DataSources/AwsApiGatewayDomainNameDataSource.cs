using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_domain_name.
/// </summary>
public class AwsApiGatewayDomainNameDataSource : TerraformDataSource
{
    public AwsApiGatewayDomainNameDataSource(string name) : base("aws_api_gateway_domain_name", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DomainNameId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateArn => new TerraformReference(this, "certificate_arn");

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("certificate_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateName => new TerraformReference(this, "certificate_name");

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    [TerraformPropertyName("certificate_upload_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateUploadDate => new TerraformReference(this, "certificate_upload_date");

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudfrontDomainName => new TerraformReference(this, "cloudfront_domain_name");

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudfrontZoneId => new TerraformReference(this, "cloudfront_zone_id");

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EndpointConfiguration => new TerraformReference(this, "endpoint_configuration");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Policy => new TerraformReference(this, "policy");

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("regional_certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegionalCertificateArn => new TerraformReference(this, "regional_certificate_arn");

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("regional_certificate_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegionalCertificateName => new TerraformReference(this, "regional_certificate_name");

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("regional_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegionalDomainName => new TerraformReference(this, "regional_domain_name");

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("regional_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegionalZoneId => new TerraformReference(this, "regional_zone_id");

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformPropertyName("security_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityPolicy => new TerraformReference(this, "security_policy");

}
