using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSamlOptionsSamlOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The master_backend_role attribute.
    /// </summary>
    [TerraformPropertyName("master_backend_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterBackendRole { get; set; }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    [TerraformPropertyName("master_user_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterUserName { get; set; }

    /// <summary>
    /// The roles_key attribute.
    /// </summary>
    [TerraformPropertyName("roles_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RolesKey { get; set; }

    /// <summary>
    /// The session_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("session_timeout_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SessionTimeoutMinutes { get; set; }

    /// <summary>
    /// The subject_key attribute.
    /// </summary>
    [TerraformPropertyName("subject_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubjectKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOpensearchDomainSamlOptionsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_opensearch_domain_saml_options resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchDomainSamlOptions : TerraformResource
{
    public AwsOpensearchDomainSamlOptions(string name) : base("aws_opensearch_domain_saml_options", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlOptions block(s) allowed")]
    [TerraformPropertyName("saml_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>>? SamlOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOpensearchDomainSamlOptionsTimeoutsBlock>? Timeouts { get; set; } = new();

}
