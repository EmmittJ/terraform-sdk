using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for validity in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateValidityBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_acmpca_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAcmpcaCertificate : TerraformResource
{
    public AwsAcmpcaCertificate(string name) : base("aws_acmpca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate");
        SetOutput("certificate_chain");
        SetOutput("api_passthrough");
        SetOutput("certificate_authority_arn");
        SetOutput("certificate_signing_request");
        SetOutput("id");
        SetOutput("region");
        SetOutput("signing_algorithm");
        SetOutput("template_arn");
    }

    /// <summary>
    /// The api_passthrough attribute.
    /// </summary>
    public TerraformProperty<string> ApiPassthrough
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_passthrough");
        set => SetProperty("api_passthrough", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformProperty<string> CertificateAuthorityArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_authority_arn");
        set => SetProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateSigningRequest is required")]
    public required TerraformProperty<string> CertificateSigningRequest
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_signing_request");
        set => SetProperty("certificate_signing_request", value);
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
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformProperty<string> SigningAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signing_algorithm");
        set => SetProperty("signing_algorithm", value);
    }

    /// <summary>
    /// The template_arn attribute.
    /// </summary>
    public TerraformProperty<string> TemplateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_arn");
        set => SetProperty("template_arn", value);
    }

    /// <summary>
    /// Block for validity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validity block(s) allowed")]
    public List<AwsAcmpcaCertificateValidityBlock>? Validity
    {
        set => SetProperty("validity", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

}
