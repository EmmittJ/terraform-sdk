using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainSamlOptionsSamlOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The master_backend_role attribute.
    /// </summary>
    [TerraformProperty("master_backend_role")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterBackendRole { get; set; }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    [TerraformProperty("master_user_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterUserName { get; set; }

    /// <summary>
    /// The roles_key attribute.
    /// </summary>
    [TerraformProperty("roles_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RolesKey { get; set; }

    /// <summary>
    /// The session_timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("session_timeout_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SessionTimeoutMinutes { get; set; }

    /// <summary>
    /// The subject_key attribute.
    /// </summary>
    [TerraformProperty("subject_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubjectKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOpensearchDomainSamlOptionsTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_opensearch_domain_saml_options resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsOpensearchDomainSamlOptions : TerraformResource
{
    public AwsOpensearchDomainSamlOptions(string name) : base("aws_opensearch_domain_saml_options", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlOptions block(s) allowed")]
    [TerraformProperty("saml_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>>? SamlOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsOpensearchDomainSamlOptionsTimeoutsBlock>? Timeouts { get; set; }

}
