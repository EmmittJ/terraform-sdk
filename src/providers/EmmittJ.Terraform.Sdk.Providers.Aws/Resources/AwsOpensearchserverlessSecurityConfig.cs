using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchserverlessSecurityConfigSamlOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    [TerraformPropertyName("group_attribute")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GroupAttribute { get; set; }

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    [TerraformPropertyName("metadata")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Metadata { get; set; }

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    [TerraformPropertyName("session_timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SessionTimeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "session_timeout");

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    [TerraformPropertyName("user_attribute")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAttribute { get; set; }

}

/// <summary>
/// Manages a aws_opensearchserverless_security_config resource.
/// </summary>
public class AwsOpensearchserverlessSecurityConfig : TerraformResource
{
    public AwsOpensearchserverlessSecurityConfig(string name) : base("aws_opensearchserverless_security_config", name)
    {
    }

    /// <summary>
    /// Description of the security configuration.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Name of the policy.
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
    /// Type of configuration. Must be `saml`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("saml_options")]
    public TerraformList<TerraformBlock<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>>? SamlOptions { get; set; } = new();

    /// <summary>
    /// Version of the configuration.
    /// </summary>
    [TerraformPropertyName("config_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
