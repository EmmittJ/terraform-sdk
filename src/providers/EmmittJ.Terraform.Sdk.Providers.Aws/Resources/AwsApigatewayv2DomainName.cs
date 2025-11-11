using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for domain_name_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2DomainNameDomainNameConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    [TerraformProperty("certificate_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateArn { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformProperty("endpoint_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EndpointType { get; set; }


    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("ownership_verification_certificate_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OwnershipVerificationCertificateArn { get; set; }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    [TerraformProperty("security_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecurityPolicy { get; set; }


}

/// <summary>
/// Block type for mutual_tls_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    [TerraformProperty("truststore_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TruststoreUri { get; set; }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    [TerraformProperty("truststore_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TruststoreVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsApigatewayv2DomainNameTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_domain_name resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApigatewayv2DomainName : TerraformResource
{
    public AwsApigatewayv2DomainName(string name) : base("aws_apigatewayv2_domain_name", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for domain_name_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DomainNameConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainNameConfiguration block(s) allowed")]
    [TerraformProperty("domain_name_configuration")]
    public TerraformList<TerraformBlock<AwsApigatewayv2DomainNameDomainNameConfigurationBlock>>? DomainNameConfiguration { get; set; }

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    [TerraformProperty("mutual_tls_authentication")]
    public TerraformList<TerraformBlock<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>>? MutualTlsAuthentication { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsApigatewayv2DomainNameTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The api_mapping_selection_expression attribute.
    /// </summary>
    [TerraformProperty("api_mapping_selection_expression")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiMappingSelectionExpression { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
