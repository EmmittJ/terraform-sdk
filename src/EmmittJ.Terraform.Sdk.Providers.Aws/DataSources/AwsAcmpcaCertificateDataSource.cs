using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acmpca_certificate.
/// </summary>
public class AwsAcmpcaCertificateDataSource : TerraformDataSource
{
    public AwsAcmpcaCertificateDataSource(string name) : base("aws_acmpca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate");
        this.DeclareOutput("certificate_chain");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

}
