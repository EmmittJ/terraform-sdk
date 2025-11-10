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
        set => SetProperty("certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostedZoneId
    {
        set => SetProperty("hosted_zone_id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OwnershipVerificationCertificateArn
    {
        set => SetProperty("ownership_verification_certificate_arn", value);
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformProperty<string> SecurityPolicy
    {
        set => SetProperty("security_policy", value);
    }

    /// <summary>
    /// The target_domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDomainName
    {
        set => SetProperty("target_domain_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_domain_name resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2DomainName : TerraformResource
{
    public AwsApigatewayv2DomainName(string name) : base("aws_apigatewayv2_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_mapping_selection_expression");
        SetOutput("arn");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for domain_name_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DomainNameConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainNameConfiguration block(s) allowed")]
    public List<AwsApigatewayv2DomainNameDomainNameConfigurationBlock>? DomainNameConfiguration
    {
        set => SetProperty("domain_name_configuration", value);
    }

    /// <summary>
    /// Block for mutual_tls_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    public List<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>? MutualTlsAuthentication
    {
        set => SetProperty("mutual_tls_authentication", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsApigatewayv2DomainNameTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
