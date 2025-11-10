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
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainNameId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("certificate_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_name");

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    [TerraformPropertyName("certificate_upload_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateUploadDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_upload_date");

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudfrontDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudfront_domain_name");

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudfrontZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudfront_zone_id");

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EndpointConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "endpoint_configuration");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Policy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("regional_certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegionalCertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "regional_certificate_arn");

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("regional_certificate_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegionalCertificateName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "regional_certificate_name");

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("regional_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegionalDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "regional_domain_name");

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("regional_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegionalZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "regional_zone_id");

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformPropertyName("security_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_policy");

}
