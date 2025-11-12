using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotDomainConfigurationAuthorizerConfigBlock() : TerraformBlock("authorizer_config")
{
    /// <summary>
    /// The allow_authorizer_override attribute.
    /// </summary>
    [TerraformProperty("allow_authorizer_override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAuthorizerOverride { get; set; }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    [TerraformProperty("default_authorizer_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultAuthorizerName { get; set; }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotDomainConfigurationTlsConfigBlock() : TerraformBlock("tls_config")
{
    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformProperty("security_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityPolicy { get; set; }

}

/// <summary>
/// Manages a aws_iot_domain_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIotDomainConfiguration : TerraformResource
{
    public AwsIotDomainConfiguration(string name) : base("aws_iot_domain_configuration", name)
    {
    }

    /// <summary>
    /// The application_protocol attribute.
    /// </summary>
    [TerraformProperty("application_protocol")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ApplicationProtocol { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The server_certificate_arns attribute.
    /// </summary>
    [TerraformProperty("server_certificate_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ServerCertificateArns { get; set; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformProperty("service_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceType { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

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
    /// The validation_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("validation_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValidationCertificateArn { get; set; }

    /// <summary>
    /// Block for authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerConfig block(s) allowed")]
    [TerraformProperty("authorizer_config")]
    public TerraformList<AwsIotDomainConfigurationAuthorizerConfigBlock> AuthorizerConfig { get; set; } = new();

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformProperty("tls_config")]
    public TerraformList<AwsIotDomainConfigurationTlsConfigBlock> TlsConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    [TerraformProperty("domain_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainType { get; }

}
