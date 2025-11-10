using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSamlOptionsSamlOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The master_backend_role attribute.
    /// </summary>
    public TerraformProperty<string>? MasterBackendRole
    {
        get => GetProperty<TerraformProperty<string>>("master_backend_role");
        set => WithProperty("master_backend_role", value);
    }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    public TerraformProperty<string>? MasterUserName
    {
        get => GetProperty<TerraformProperty<string>>("master_user_name");
        set => WithProperty("master_user_name", value);
    }

    /// <summary>
    /// The roles_key attribute.
    /// </summary>
    public TerraformProperty<string>? RolesKey
    {
        get => GetProperty<TerraformProperty<string>>("roles_key");
        set => WithProperty("roles_key", value);
    }

    /// <summary>
    /// The session_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? SessionTimeoutMinutes
    {
        get => GetProperty<TerraformProperty<double>>("session_timeout_minutes");
        set => WithProperty("session_timeout_minutes", value);
    }

    /// <summary>
    /// The subject_key attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectKey
    {
        get => GetProperty<TerraformProperty<string>>("subject_key");
        set => WithProperty("subject_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOpensearchDomainSamlOptionsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
/// Manages a aws_opensearch_domain_saml_options resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchDomainSamlOptions : TerraformResource
{
    public AwsOpensearchDomainSamlOptions(string name) : base("aws_opensearch_domain_saml_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
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
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlOptions block(s) allowed")]
    public List<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>? SamlOptions
    {
        get => GetProperty<List<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>>("saml_options");
        set => this.WithProperty("saml_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOpensearchDomainSamlOptionsTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsOpensearchDomainSamlOptionsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
