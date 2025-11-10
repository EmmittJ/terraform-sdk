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
        get => GetProperty<TerraformProperty<bool>>("allow_authorizer_override");
        set => WithProperty("allow_authorizer_override", value);
    }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAuthorizerName
    {
        get => GetProperty<TerraformProperty<string>>("default_authorizer_name");
        set => WithProperty("default_authorizer_name", value);
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
        get => GetProperty<TerraformProperty<string>>("security_policy");
        set => WithProperty("security_policy", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_type");
    }

    /// <summary>
    /// The application_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationProtocol
    {
        get => GetProperty<TerraformProperty<string>>("application_protocol");
        set => this.WithProperty("application_protocol", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The server_certificate_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServerCertificateArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("server_certificate_arns");
        set => this.WithProperty("server_certificate_arns", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceType
    {
        get => GetProperty<TerraformProperty<string>>("service_type");
        set => this.WithProperty("service_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
    /// The validation_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ValidationCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("validation_certificate_arn");
        set => this.WithProperty("validation_certificate_arn", value);
    }

    /// <summary>
    /// Block for authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerConfig block(s) allowed")]
    public List<AwsIotDomainConfigurationAuthorizerConfigBlock>? AuthorizerConfig
    {
        get => GetProperty<List<AwsIotDomainConfigurationAuthorizerConfigBlock>>("authorizer_config");
        set => this.WithProperty("authorizer_config", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<AwsIotDomainConfigurationTlsConfigBlock>? TlsConfig
    {
        get => GetProperty<List<AwsIotDomainConfigurationTlsConfigBlock>>("tls_config");
        set => this.WithProperty("tls_config", value);
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
