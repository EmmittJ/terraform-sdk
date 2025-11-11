using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDomainNameEndpointConfigurationBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpAddressType { get; set; } = default!;

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    [TerraformPropertyName("types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Types { get; set; }

}

/// <summary>
/// Block type for mutual_tls_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDomainNameMutualTlsAuthenticationBlock
{
    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    [TerraformPropertyName("truststore_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TruststoreUri { get; set; }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    [TerraformPropertyName("truststore_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TruststoreVersion { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_domain_name resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayDomainName : TerraformResource
{
    public AwsApiGatewayDomainName(string name) : base("aws_api_gateway_domain_name", name)
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateArn { get; set; }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformPropertyName("certificate_body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateBody { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateChain { get; set; }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("certificate_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateName { get; set; }

    /// <summary>
    /// The certificate_private_key attribute.
    /// </summary>
    [TerraformPropertyName("certificate_private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePrivateKey { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ownership_verification_certificate_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OwnershipVerificationCertificateArn { get; set; } = default!;

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("regional_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RegionalCertificateArn { get; set; }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("regional_certificate_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RegionalCertificateName { get; set; }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformPropertyName("security_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityPolicy { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    [TerraformPropertyName("endpoint_configuration")]
    public TerraformList<TerraformBlock<AwsApiGatewayDomainNameEndpointConfigurationBlock>>? EndpointConfiguration { get; set; }

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    [TerraformPropertyName("mutual_tls_authentication")]
    public TerraformList<TerraformBlock<AwsApiGatewayDomainNameMutualTlsAuthenticationBlock>>? MutualTlsAuthentication { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

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
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainNameId => new TerraformReference(this, "domain_name_id");

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

}
