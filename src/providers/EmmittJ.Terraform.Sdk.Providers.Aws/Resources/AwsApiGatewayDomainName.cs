using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDomainNameEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    public List<TerraformProperty<string>>? Types
    {
        set => SetProperty("types", value);
    }

}

/// <summary>
/// Block type for mutual_tls_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDomainNameMutualTlsAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    public required TerraformProperty<string> TruststoreUri
    {
        set => SetProperty("truststore_uri", value);
    }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    public TerraformProperty<string>? TruststoreVersion
    {
        set => SetProperty("truststore_version", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_domain_name resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayDomainName : TerraformResource
{
    public AwsApiGatewayDomainName(string name) : base("aws_api_gateway_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate_upload_date");
        SetOutput("cloudfront_domain_name");
        SetOutput("cloudfront_zone_id");
        SetOutput("domain_name_id");
        SetOutput("regional_domain_name");
        SetOutput("regional_zone_id");
        SetOutput("certificate_arn");
        SetOutput("certificate_body");
        SetOutput("certificate_chain");
        SetOutput("certificate_name");
        SetOutput("certificate_private_key");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("ownership_verification_certificate_arn");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("regional_certificate_arn");
        SetOutput("regional_certificate_name");
        SetOutput("security_policy");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> CertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_arn");
        set => SetProperty("certificate_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformProperty<string> CertificateBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_body");
        set => SetProperty("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformProperty<string> CertificateChain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_chain");
        set => SetProperty("certificate_chain", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformProperty<string> CertificateName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_name");
        set => SetProperty("certificate_name", value);
    }

    /// <summary>
    /// The certificate_private_key attribute.
    /// </summary>
    public TerraformProperty<string> CertificatePrivateKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_private_key");
        set => SetProperty("certificate_private_key", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> OwnershipVerificationCertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ownership_verification_certificate_arn");
        set => SetProperty("ownership_verification_certificate_arn", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> RegionalCertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("regional_certificate_arn");
        set => SetProperty("regional_certificate_arn", value);
    }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public TerraformProperty<string> RegionalCertificateName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("regional_certificate_name");
        set => SetProperty("regional_certificate_name", value);
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformProperty<string> SecurityPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_policy");
        set => SetProperty("security_policy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    public List<AwsApiGatewayDomainNameEndpointConfigurationBlock>? EndpointConfiguration
    {
        set => SetProperty("endpoint_configuration", value);
    }

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    public List<AwsApiGatewayDomainNameMutualTlsAuthenticationBlock>? MutualTlsAuthentication
    {
        set => SetProperty("mutual_tls_authentication", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    public TerraformExpression CertificateUploadDate => this["certificate_upload_date"];

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    public TerraformExpression CloudfrontDomainName => this["cloudfront_domain_name"];

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    public TerraformExpression CloudfrontZoneId => this["cloudfront_zone_id"];

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformExpression DomainNameId => this["domain_name_id"];

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    public TerraformExpression RegionalDomainName => this["regional_domain_name"];

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    public TerraformExpression RegionalZoneId => this["regional_zone_id"];

}
