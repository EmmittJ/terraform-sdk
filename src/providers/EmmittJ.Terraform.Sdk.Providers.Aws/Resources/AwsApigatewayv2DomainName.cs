using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for domain_name_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2DomainNameDomainNameConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    [TerraformPropertyName("certificate_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CertificateArn { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointType { get; set; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>("", "hosted_zone_id");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_address_type");

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ownership_verification_certificate_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OwnershipVerificationCertificateArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ownership_verification_certificate_arn");

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    [TerraformPropertyName("security_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityPolicy { get; set; }

    /// <summary>
    /// The target_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("target_domain_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetDomainName => new TerraformReferenceProperty<TerraformProperty<string>>("", "target_domain_name");

}

/// <summary>
/// Block type for mutual_tls_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock : ITerraformBlock
{
    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    [TerraformPropertyName("truststore_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TruststoreUri { get; set; }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    [TerraformPropertyName("truststore_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TruststoreVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2DomainNameTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_domain_name resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2DomainName : TerraformResource
{
    public AwsApigatewayv2DomainName(string name) : base("aws_apigatewayv2_domain_name", name)
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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for domain_name_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DomainNameConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainNameConfiguration block(s) allowed")]
    [TerraformPropertyName("domain_name_configuration")]
    public TerraformList<TerraformBlock<AwsApigatewayv2DomainNameDomainNameConfigurationBlock>>? DomainNameConfiguration { get; set; } = new();

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    [TerraformPropertyName("mutual_tls_authentication")]
    public TerraformList<TerraformBlock<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>>? MutualTlsAuthentication { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsApigatewayv2DomainNameTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The api_mapping_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("api_mapping_selection_expression")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiMappingSelectionExpression => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_mapping_selection_expression");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
