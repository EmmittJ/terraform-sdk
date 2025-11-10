using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for domain_name_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2DomainNameDomainNameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformProperty<string> CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostedZoneId
    {
        get => GetProperty<TerraformProperty<string>>("hosted_zone_id");
        set => WithProperty("hosted_zone_id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OwnershipVerificationCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("ownership_verification_certificate_arn");
        set => WithProperty("ownership_verification_certificate_arn", value);
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformProperty<string> SecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("security_policy");
        set => WithProperty("security_policy", value);
    }

    /// <summary>
    /// The target_domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDomainName
    {
        get => GetProperty<TerraformProperty<string>>("target_domain_name");
        set => WithProperty("target_domain_name", value);
    }

}

/// <summary>
/// Block type for mutual_tls_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    public required TerraformProperty<string> TruststoreUri
    {
        get => GetProperty<TerraformProperty<string>>("truststore_uri");
        set => WithProperty("truststore_uri", value);
    }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    public TerraformProperty<string>? TruststoreVersion
    {
        get => GetProperty<TerraformProperty<string>>("truststore_version");
        set => WithProperty("truststore_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2DomainNameTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_domain_name resource.
/// </summary>
public class AwsApigatewayv2DomainName : TerraformResource
{
    public AwsApigatewayv2DomainName(string name) : base("aws_apigatewayv2_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_mapping_selection_expression");
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for domain_name_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DomainNameConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainNameConfiguration block(s) allowed")]
    public List<AwsApigatewayv2DomainNameDomainNameConfigurationBlock>? DomainNameConfiguration
    {
        get => GetProperty<List<AwsApigatewayv2DomainNameDomainNameConfigurationBlock>>("domain_name_configuration");
        set => this.WithProperty("domain_name_configuration", value);
    }

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    public List<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>? MutualTlsAuthentication
    {
        get => GetProperty<List<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>>("mutual_tls_authentication");
        set => this.WithProperty("mutual_tls_authentication", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsApigatewayv2DomainNameTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsApigatewayv2DomainNameTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The api_mapping_selection_expression attribute.
    /// </summary>
    public TerraformExpression ApiMappingSelectionExpression => this["api_mapping_selection_expression"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
