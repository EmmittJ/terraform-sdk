using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? ApiPassthrough
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_passthrough")?.Value;
        set => this.WithProperty("api_passthrough", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public string? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_authority_arn")?.Value;
        set => this.WithProperty("certificate_authority_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public string? CertificateSigningRequest
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_signing_request")?.Value;
        set => this.WithProperty("certificate_signing_request", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    public string? SigningAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signing_algorithm")?.Value;
        set => this.WithProperty("signing_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The template_arn attribute.
    /// </summary>
    public string? TemplateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_arn")?.Value;
        set => this.WithProperty("template_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
