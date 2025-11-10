using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for registration_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotCaCertificateRegistrationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateBody
    {
        set => SetProperty("template_body", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateName
    {
        set => SetProperty("template_name", value);
    }

}

/// <summary>
/// Manages a aws_iot_ca_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotCaCertificate : TerraformResource
{
    public AwsIotCaCertificate(string name) : base("aws_iot_ca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("customer_version");
        SetOutput("generation_id");
        SetOutput("validity");
        SetOutput("active");
        SetOutput("allow_auto_registration");
        SetOutput("ca_certificate_pem");
        SetOutput("certificate_mode");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("verification_certificate_pem");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    public required TerraformProperty<bool> Active
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active");
        set => SetProperty("active", value);
    }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAutoRegistration is required")]
    public required TerraformProperty<bool> AllowAutoRegistration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_auto_registration");
        set => SetProperty("allow_auto_registration", value);
    }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatePem is required")]
    public required TerraformProperty<string> CaCertificatePem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ca_certificate_pem");
        set => SetProperty("ca_certificate_pem", value);
    }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public TerraformProperty<string> CertificateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_mode");
        set => SetProperty("certificate_mode", value);
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
    /// The verification_certificate_pem attribute.
    /// </summary>
    public TerraformProperty<string> VerificationCertificatePem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("verification_certificate_pem");
        set => SetProperty("verification_certificate_pem", value);
    }

    /// <summary>
    /// Block for registration_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrationConfig block(s) allowed")]
    public List<AwsIotCaCertificateRegistrationConfigBlock>? RegistrationConfig
    {
        set => SetProperty("registration_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    public TerraformExpression CustomerVersion => this["customer_version"];

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    public TerraformExpression GenerationId => this["generation_id"];

    /// <summary>
    /// The validity attribute.
    /// </summary>
    public TerraformExpression Validity => this["validity"];

}
