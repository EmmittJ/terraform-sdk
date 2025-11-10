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
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_acmpca_certificate resource.
/// </summary>
public class AwsAcmpcaCertificate : TerraformResource
{
    public AwsAcmpcaCertificate(string name) : base("aws_acmpca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate");
        this.DeclareOutput("certificate_chain");
    }

    /// <summary>
    /// The api_passthrough attribute.
    /// </summary>
    public TerraformProperty<string>? ApiPassthrough
    {
        get => GetProperty<TerraformProperty<string>>("api_passthrough");
        set => this.WithProperty("api_passthrough", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformProperty<string> CertificateAuthorityArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_authority_arn");
        set => this.WithProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateSigningRequest is required")]
    public required TerraformProperty<string> CertificateSigningRequest
    {
        get => GetProperty<TerraformProperty<string>>("certificate_signing_request");
        set => this.WithProperty("certificate_signing_request", value);
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
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformProperty<string> SigningAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("signing_algorithm");
        set => this.WithProperty("signing_algorithm", value);
    }

    /// <summary>
    /// The template_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateArn
    {
        get => GetProperty<TerraformProperty<string>>("template_arn");
        set => this.WithProperty("template_arn", value);
    }

    /// <summary>
    /// Block for validity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validity block(s) allowed")]
    public List<AwsAcmpcaCertificateValidityBlock>? Validity
    {
        get => GetProperty<List<AwsAcmpcaCertificateValidityBlock>>("validity");
        set => this.WithProperty("validity", value);
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
