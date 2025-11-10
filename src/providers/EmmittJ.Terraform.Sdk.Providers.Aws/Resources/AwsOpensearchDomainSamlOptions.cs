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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The master_backend_role attribute.
    /// </summary>
    public TerraformProperty<string>? MasterBackendRole
    {
        set => SetProperty("master_backend_role", value);
    }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    public TerraformProperty<string>? MasterUserName
    {
        set => SetProperty("master_user_name", value);
    }

    /// <summary>
    /// The roles_key attribute.
    /// </summary>
    public TerraformProperty<string>? RolesKey
    {
        set => SetProperty("roles_key", value);
    }

    /// <summary>
    /// The session_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? SessionTimeoutMinutes
    {
        set => SetProperty("session_timeout_minutes", value);
    }

    /// <summary>
    /// The subject_key attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectKey
    {
        set => SetProperty("subject_key", value);
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
        set => SetProperty("delete", value);
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
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("region");
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
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlOptions block(s) allowed")]
    public List<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>? SamlOptions
    {
        set => SetProperty("saml_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOpensearchDomainSamlOptionsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
