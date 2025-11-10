using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationAuthorizerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_authorizer_override attribute.
    /// </summary>
    [TerraformPropertyName("allow_authorizer_override")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowAuthorizerOverride { get; set; }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    [TerraformPropertyName("default_authorizer_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultAuthorizerName { get; set; }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationTlsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformPropertyName("security_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecurityPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "security_policy");

}

/// <summary>
/// Manages a aws_iot_domain_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotDomainConfiguration : TerraformResource
{
    public AwsIotDomainConfiguration(string name) : base("aws_iot_domain_configuration", name)
    {
    }

    /// <summary>
    /// The application_protocol attribute.
    /// </summary>
    [TerraformPropertyName("application_protocol")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ApplicationProtocol { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_protocol");

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authentication_type");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The server_certificate_arns attribute.
    /// </summary>
    [TerraformPropertyName("server_certificate_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServerCertificateArns { get; set; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformPropertyName("service_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceType { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

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
    /// The validation_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("validation_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ValidationCertificateArn { get; set; }

    /// <summary>
    /// Block for authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerConfig block(s) allowed")]
    [TerraformPropertyName("authorizer_config")]
    public TerraformList<TerraformBlock<AwsIotDomainConfigurationAuthorizerConfigBlock>>? AuthorizerConfig { get; set; } = new();

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformPropertyName("tls_config")]
    public TerraformList<TerraformBlock<AwsIotDomainConfigurationTlsConfigBlock>>? TlsConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    [TerraformPropertyName("domain_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_type");

}
