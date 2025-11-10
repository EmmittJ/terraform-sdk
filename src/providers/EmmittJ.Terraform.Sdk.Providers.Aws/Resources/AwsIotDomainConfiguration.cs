using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationAuthorizerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The allow_authorizer_override attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowAuthorizerOverride
    {
        set => SetProperty("allow_authorizer_override", value);
    }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAuthorizerName
    {
        set => SetProperty("default_authorizer_name", value);
    }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityPolicy
    {
        set => SetProperty("security_policy", value);
    }

}

/// <summary>
/// Manages a aws_iot_domain_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotDomainConfiguration : TerraformResource
{
    public AwsIotDomainConfiguration(string name) : base("aws_iot_domain_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("domain_type");
        SetOutput("application_protocol");
        SetOutput("authentication_type");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("server_certificate_arns");
        SetOutput("service_type");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("validation_certificate_arn");
    }

    /// <summary>
    /// The application_protocol attribute.
    /// </summary>
    public TerraformProperty<string> ApplicationProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_protocol");
        set => SetProperty("application_protocol", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainName
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The server_certificate_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ServerCertificateArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("server_certificate_arns");
        set => SetProperty("server_certificate_arns", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformProperty<string> ServiceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_type");
        set => SetProperty("service_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
    /// The validation_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> ValidationCertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("validation_certificate_arn");
        set => SetProperty("validation_certificate_arn", value);
    }

    /// <summary>
    /// Block for authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerConfig block(s) allowed")]
    public List<AwsIotDomainConfigurationAuthorizerConfigBlock>? AuthorizerConfig
    {
        set => SetProperty("authorizer_config", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<AwsIotDomainConfigurationTlsConfigBlock>? TlsConfig
    {
        set => SetProperty("tls_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    public TerraformExpression DomainType => this["domain_type"];

}
