using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationAuthorizerConfigBlock
{
    /// <summary>
    /// The allow_authorizer_override attribute.
    /// </summary>
    [TerraformPropertyName("allow_authorizer_override")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAuthorizerOverride { get; set; }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    [TerraformPropertyName("default_authorizer_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultAuthorizerName { get; set; }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationTlsConfigBlock
{
    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformPropertyName("security_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityPolicy { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ApplicationProtocol { get; set; } = default!;

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationType { get; set; } = default!;

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DomainName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The server_certificate_arns attribute.
    /// </summary>
    [TerraformPropertyName("server_certificate_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ServerCertificateArns { get; set; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformPropertyName("service_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceType { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

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
    /// The validation_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("validation_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ValidationCertificateArn { get; set; }

    /// <summary>
    /// Block for authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerConfig block(s) allowed")]
    [TerraformPropertyName("authorizer_config")]
    public TerraformList<TerraformBlock<AwsIotDomainConfigurationAuthorizerConfigBlock>>? AuthorizerConfig { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformPropertyName("tls_config")]
    public TerraformList<TerraformBlock<AwsIotDomainConfigurationTlsConfigBlock>>? TlsConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    [TerraformPropertyName("domain_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainType => new TerraformReference(this, "domain_type");

}
