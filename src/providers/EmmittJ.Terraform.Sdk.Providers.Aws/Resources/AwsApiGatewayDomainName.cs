using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayDomainNameEndpointConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    [TerraformProperty("types")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Types { get; set; }

}

/// <summary>
/// Block type for mutual_tls_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayDomainNameMutualTlsAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    [TerraformProperty("truststore_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TruststoreUri { get; set; }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    [TerraformProperty("truststore_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TruststoreVersion { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_domain_name resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApiGatewayDomainName : TerraformResource
{
    public AwsApiGatewayDomainName(string name) : base("aws_api_gateway_domain_name", name)
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateArn { get; set; }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformProperty("certificate_body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateBody { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateChain { get; set; }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [TerraformProperty("certificate_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateName { get; set; }

    /// <summary>
    /// The certificate_private_key attribute.
    /// </summary>
    [TerraformProperty("certificate_private_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePrivateKey { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("ownership_verification_certificate_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OwnershipVerificationCertificateArn { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("regional_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegionalCertificateArn { get; set; }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    [TerraformProperty("regional_certificate_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegionalCertificateName { get; set; }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformProperty("security_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityPolicy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    [TerraformProperty("endpoint_configuration")]
    public partial TerraformList<TerraformBlock<AwsApiGatewayDomainNameEndpointConfigurationBlock>>? EndpointConfiguration { get; set; }

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    [TerraformProperty("mutual_tls_authentication")]
    public partial TerraformList<TerraformBlock<AwsApiGatewayDomainNameMutualTlsAuthenticationBlock>>? MutualTlsAuthentication { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    [TerraformProperty("certificate_upload_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateUploadDate { get; }

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    [TerraformProperty("cloudfront_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudfrontDomainName { get; }

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    [TerraformProperty("cloudfront_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudfrontZoneId { get; }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformProperty("domain_name_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainNameId { get; }

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    [TerraformProperty("regional_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegionalDomainName { get; }

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    [TerraformProperty("regional_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegionalZoneId { get; }

}
